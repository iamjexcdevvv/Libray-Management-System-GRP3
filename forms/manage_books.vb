Imports System.ComponentModel
Imports System.Data.Common
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Net
Imports Google.Protobuf.Reflection
Imports MySql.Data.MySqlClient

Public Class manage_books
    Private bookCoverImage As Image = My.Resources.photo
    Private selectedImageFileName As String = ""
    Dim selectedBookID As Integer = -1
    Private Async Sub LoadBookData(bookID As Integer)
        GenerateBookGenreList(ComboBox2)
        GenerateBookStatusList(ComboBox5)

        Try
            Dim query As String = "SELECT bookISBN, bookTitle, bookAuthor, bookGenre, bookPublisher, bookStatus, bookCover, bookPublishedDate FROM books WHERE bookID = @bookID"

            Using conn As New MySqlConnection(connectionString)
                Await conn.OpenAsync()

                Using cmd = New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@bookID", bookID)

                    Dim reader As MySqlDataReader = Await cmd.ExecuteReaderAsync

                    If reader.HasRows Then
                        Await reader.ReadAsync()

                        Dim bookISBN As String = reader.GetString("bookISBN")
                        Dim bookTitle As String = reader.GetString("bookTitle")
                        Dim bookAuthor As String = reader.GetString("bookAuthor")
                        Dim bookGenre As String = reader.GetString("bookGenre")
                        Dim bookPublisher As String = reader.GetString("bookPublisher")
                        Dim bookStatus As Boolean = reader.GetBoolean("bookStatus")
                        Dim bookPublishedDate As String = reader.GetString("bookPublishedDate")

                        Dim img As Byte() = DirectCast(reader("bookCover"), Byte())
                        Dim ms As New MemoryStream(img)

                        TextBox8.Text = bookISBN
                        TextBox7.Text = bookTitle
                        ComboBox2.Text = bookGenre
                        TextBox6.Text = bookAuthor
                        ComboBox5.Text = If(bookStatus, "Available", "Not available")
                        TextBox3.Text = bookPublisher
                        PictureBox3.Image = Image.FromStream(ms)
                        DateTimePicker2.Value = bookPublishedDate
                    End If

                    reader.Close()
                End Using
            End Using

            TextBox8.Enabled = True
            TextBox7.Enabled = True
            TextBox6.Enabled = True
            TextBox3.Enabled = True
            DateTimePicker2.Enabled = True
            ComboBox2.Enabled = True
            ComboBox5.Enabled = True
            Button4.Enabled = True
            Button6.Enabled = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Async Sub LoadBooks()
        Try
            ComboBox3.Items.Clear()
            ComboBox2.Items.Clear()

            Dim query As String = "SELECT bookID FROM books"
            Using conn As New MySqlConnection(connectionString)
                Await conn.OpenAsync()

                Using cmd = New MySqlCommand(query, conn)
                    Dim reader As MySqlDataReader
                    reader = Await cmd.ExecuteReaderAsync

                    While Await reader.ReadAsync()
                        ComboBox3.Items.Add(reader("bookID"))
                    End While

                    reader.Close()
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Async Sub SaveNewBook(bookIsbn As String, bookTitle As String, bookAuthor As String, bookGenre As String, bookPublisher As String, bookCover As Byte(), bookPublishedDate As String, bookStatus As Boolean)
        Try
            Dim query As String = "INSERT INTO books (bookIsbn, bookTitle, bookAuthor, bookGenre, bookPublisher, bookCover, bookStatus, bookPublishedDate) " &
                                  "VALUES (@bookISBN, @bookTitle, @bookAuthor, @bookGenre, @bookPublisher, @bookCover, @bookStatus, @bookPublishedDate)"

            Using conn As New MySqlConnection(connectionString)
                Await conn.OpenAsync()

                Using cmd = New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@bookISBN", bookIsbn)
                    cmd.Parameters.AddWithValue("@bookTitle", bookTitle)
                    cmd.Parameters.AddWithValue("@bookAuthor", bookAuthor)
                    cmd.Parameters.AddWithValue("@bookGenre", bookGenre)
                    cmd.Parameters.AddWithValue("@bookPublisher", bookPublisher)
                    cmd.Parameters.AddWithValue("@bookCover", bookCover)
                    cmd.Parameters.AddWithValue("@bookStatus", bookStatus)
                    cmd.Parameters.AddWithValue("@bookPublishedDate", bookPublishedDate)

                    Await cmd.ExecuteNonQueryAsync()

                    MsgBox("Data inserted successfully!", vbInformation, "Data Saved")
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Function IsUserInputValid(bookISBN As TextBox, bookTitle As TextBox, bookAuthor As TextBox, bookPublisher As TextBox) As Boolean
        Dim isValid = True

        If String.IsNullOrEmpty(bookISBN.Text) Then
            ErrorProvider1.SetError(bookISBN, "Please fill this field!")
            isValid = False
        Else
            ErrorProvider1.SetError(bookISBN, "")
        End If

        If String.IsNullOrEmpty(bookTitle.Text) Then
            ErrorProvider1.SetError(bookTitle, "Please fill this field!")
            isValid = False
        Else
            ErrorProvider1.SetError(bookTitle, "")
        End If

        If String.IsNullOrEmpty(bookAuthor.Text) Then
            ErrorProvider1.SetError(bookAuthor, "Please fill this field!")
            isValid = False
        Else
            ErrorProvider1.SetError(bookAuthor, "")
        End If

        If String.IsNullOrEmpty(bookPublisher.Text) Then
            ErrorProvider1.SetError(bookPublisher, "Please fill this field!")
            isValid = False
        Else
            ErrorProvider1.SetError(bookPublisher, "")
        End If

        Return isValid
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ErrorProvider1.Clear()

        If (IsUserInputValid(Textbox1, TextBox2, TextBox4, TextBox5)) Then
            Try
                Dim convertedImage As Byte() = ConvertBookCoverToByte(PictureBox2)
                Dim bookStatus As Boolean = If(ComboBox4.Text = "Available", True, False)

                SaveNewBook(Textbox1.Text, TextBox2.Text, TextBox4.Text, ComboBox1.Text, TextBox5.Text, convertedImage, DateTimePicker1.Value.ToShortDateString, bookStatus)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            Textbox1.Text = ""
            TextBox2.Text = ""
            TextBox4.Text = ""
            TextBox5.Text = ""
            PictureBox2.Image = bookCoverImage
            DateTimePicker1.Value = Date.Today
            ComboBox1.Text = ComboBox1.Items.Item(0)
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim fileName As String = OpenUserFolder()

        If fileName <> "" Then
            PictureBox2.Image = Image.FromFile(fileName)
            selectedImageFileName = fileName
        End If
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        If ComboBox3.Text <> "" Then
            Dim bookID As Integer = ComboBox3.Text
            LoadBookData(bookID)
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim fileName As String = OpenUserFolder()

        If fileName <> "" Then
            PictureBox2.Image = Image.FromFile(fileName)
            selectedImageFileName = fileName
        End If
    End Sub
    Function OpenUserFolder() As String
        Try
            Dim openFileDialog As OpenFileDialog = New OpenFileDialog

            openFileDialog.InitialDirectory = "c:\"
            openFileDialog.Filter = "Image Files(*.BMP,*.PNG;*.JPG;*.GIF,*.JPEG,*.ICO)|*.BMP,*.PNG;*.JPG;*.GIF,*.JPEG,*.ICO"
            openFileDialog.Title = "Select image"

            If openFileDialog.ShowDialog() <> DialogResult.Cancel Then
                Return openFileDialog.FileName
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return ""
    End Function
    Private Sub GenerateBookGenreList(bookGenreList As ComboBox)
        Dim bookGenre = New String() {"Fiction", "Non-Fiction", "Poetry", "Drama", "Educational"}

        For Each item As String In bookGenre
            bookGenreList.Items.Add(item)
        Next
    End Sub

    Private Sub manage_books_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GenerateBookGenreList(ComboBox1)
        GenerateBookStatusList(ComboBox4)

        ComboBox1.SelectedIndex = 0
    End Sub

    Private Sub ClearEditBookFields()
        ComboBox3.Items.Add("")
        ComboBox5.Items.Add("")

        ComboBox3.Text = ""
        TextBox8.Text = ""
        TextBox7.Text = ""
        ComboBox2.Text = ""
        TextBox6.Text = ""
        TextBox3.Text = ""
        ComboBox5.Text = ""
        DateTimePicker2.Value = Date.Today
        PictureBox3.Image = My.Resources.photo

        TextBox8.Enabled = False
        TextBox7.Enabled = False
        ComboBox2.Enabled = False
        TextBox6.Enabled = False
        ComboBox5.Enabled = False
        TextBox3.Enabled = False
        DateTimePicker2.Enabled = False
        Button4.Enabled = False
        Button6.Enabled = False

        ComboBox3.Items.Remove("")
        ComboBox5.Items.Remove("")

        ErrorProvider1.Clear()
    End Sub

    Private Sub ClearAddBookFields()
        Textbox1.Text = ""
        TextBox2.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        ComboBox1.Text = ComboBox1.Items.Item(0)
        DateTimePicker1.Value = Date.Today
        PictureBox2.Image = My.Resources.photo
    End Sub
    Private Sub TabControl1_OnLoadPage(sender As Object, e As TabControlCancelEventArgs) Handles TabControl1.Deselecting
        If e.TabPage.Name = "TabPage2" Then
            ClearEditBookFields()
        End If
    End Sub
    Private Async Sub DisplayBooksRecord()
        Try
            Dim query As String = "SELECT * FROM books"
            Using conn As New MySqlConnection(connectionString)
                Await conn.OpenAsync()

                Using cmd = New MySqlCommand(query, conn)
                    Await cmd.ExecuteNonQueryAsync()

                    Dim dataTable As New DataTable()
                    Dim dataAdapter As New MySqlDataAdapter(cmd)

                    dataAdapter.Fill(dataTable)
                    DataGridView1.DataSource = dataTable
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged
        Try
            If DataGridView1.SelectedRows.Count > 1 Then
                selectedBookID = 0
            ElseIf DataGridView1.SelectedRows.Count = 1 Then
                Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)
                selectedBookID = CInt(selectedRow.Cells("bookID").Value)
            Else
                Return
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Async Sub DeleteAllBooks()
        Try
            Using conn As New MySqlConnection(connectionString)
                Await conn.OpenAsync()

                Dim query As String = "DELETE FROM books"

                Using cmd As New MySqlCommand(query, conn)
                    Await cmd.ExecuteNonQueryAsync()

                    If DataGridView1.DataSource IsNot Nothing Then
                        Dim dt As DataTable = CType(DataGridView1.DataSource, DataTable)
                        If dt IsNot Nothing Then
                            dt.Rows.Clear()
                        End If
                    ElseIf DataGridView1.Rows.Count > 0 Then
                        DataGridView1.Rows.Clear()
                    Else
                        MessageBox.Show("The DataGridView is already empty.")
                    End If
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Async Sub DeleteBook(bookID As Integer)
        Try
            Using conn As New MySqlConnection(connectionString)
                Await conn.OpenAsync()

                Dim query As String = "DELETE FROM books WHERE bookID = @bookID"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@bookID", bookID)

                    Await cmd.ExecuteNonQueryAsync()
                End Using
            End Using

            DisplayBooksRecord()

            MsgBox("Book deleted successfully! (ID: " & bookID & ")", vbInformation, "Manage Book")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Try
            If selectedBookID = 0 Then
                Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete all books?", "Confirm", MessageBoxButtons.YesNo)
                If result = DialogResult.Yes Then
                    DeleteAllBooks()
                End If
            ElseIf selectedBookID = -1 Then
                MsgBox("Invalid selected row!", vbCritical)
                Return
            Else
                Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this book?", "Confirm", MessageBoxButtons.YesNo)
                If result = DialogResult.Yes Then
                    DeleteBook(selectedBookID)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        Dim selectedTab As TabPage = TabControl1.SelectedTab

        Select Case selectedTab.Name
            Case "TabPage3"
                DisplayBooksRecord()
            Case "TabPage2"
                LoadBooks()
        End Select
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        ClearAddBookFields()
    End Sub
    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        admin_dashboard.Show()
        Close()
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If (IsUserInputValid(TextBox8, TextBox7, TextBox6, TextBox3)) Then
            Dim bookStatus As Boolean = If(ComboBox5.Text = "Available", True, False)

            SaveEditedBookData(ComboBox3.Text, TextBox8.Text, TextBox7.Text, TextBox3.Text, ComboBox2.Text, TextBox6.Text, bookStatus, DateTimePicker2.Value.ToShortDateString())
            SaveSelectedBookCover()

            MsgBox("Data saved succesfully!", vbInformation)
            ClearEditBookFields()
        End If
    End Sub
    Private Async Sub SaveEditedBookData(bookID As Integer, bookIsbn As String, bookTitle As String, bookPublisher As String, bookGenre As String, bookAuthor As String, bookStatus As Boolean, bookPublishedDate As String)
        Try
            Dim query As String = "UPDATE books SET bookISBN = @bookISBN, bookTitle = @bookTitle, bookAuthor = @bookAuthor, bookGenre = @bookGenre, bookPublisher = @bookPublisher, bookStatus = @bookStatus, bookPublishedDate = @bookPublishedDate WHERE bookID = @bookID"

            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                Using cmd = New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@bookISBN", bookIsbn)
                    cmd.Parameters.AddWithValue("@bookTitle", bookTitle)
                    cmd.Parameters.AddWithValue("@bookAuthor", bookAuthor)
                    cmd.Parameters.AddWithValue("@bookGenre", bookGenre)
                    cmd.Parameters.AddWithValue("@bookPublisher", bookPublisher)
                    cmd.Parameters.AddWithValue("@bookStatus", bookStatus)
                    cmd.Parameters.AddWithValue("@bookPublishedDate", bookPublishedDate)
                    cmd.Parameters.AddWithValue("@bookID", bookID)

                    Await cmd.ExecuteNonQueryAsync()
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Async Sub SaveSelectedBookCover()
        If selectedImageFileName <> "" Then
            Try
                Dim query As String = "UPDATE books SET bookCover = @bookCover WHERE bookID = @bookID"

                Dim studentProfile As Byte() = ConvertBookCoverToByte(PictureBox3)

                Using conn As New MySqlConnection(connectionString)
                    conn.Open()

                    Using cmd = New MySqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@bookCover", studentProfile)
                        cmd.Parameters.AddWithValue("@bookID", ComboBox3.Text)

                        Await cmd.ExecuteNonQueryAsync()
                    End Using
                End Using
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Function ConvertBookCoverToByte(bookCoverPictureBox As PictureBox)
        If selectedImageFileName = "" Then
            selectedImageFileName = "photo.png"
        End If

        Dim bookCoverFormat As ImageFormat
        Dim fileExtension = Path.GetExtension(selectedImageFileName).ToLower

        Select Case fileExtension
            Case ".jpg", ".jpeg"
                bookCoverFormat = ImageFormat.Jpeg
            Case ".png"
                bookCoverFormat = ImageFormat.Png
            Case ".bmp"
                bookCoverFormat = ImageFormat.Bmp
            Case ".gif"
                bookCoverFormat = ImageFormat.Gif
            Case ".ico"
                bookCoverFormat = ImageFormat.Icon
            Case Else
                Throw New NotSupportedException("Unsupported image format.")
        End Select

        Dim mstream As New MemoryStream
        bookCoverPictureBox.Image.Save(mstream, bookCoverFormat)
        Dim convertedImage = mstream.GetBuffer
        mstream.Close()

        Return convertedImage
    End Function
    Private Sub GenerateBookStatusList(statusListBox As ComboBox)
        statusListBox.Items.Add("Available")
        statusListBox.Items.Add("Not available")

        statusListBox.SelectedIndex = 0
    End Sub
End Class