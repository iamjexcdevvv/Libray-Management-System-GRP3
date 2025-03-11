Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Imports System.Linq
Imports Org.BouncyCastle.Asn1.Cmp.Challenge
Imports System.IO
Imports System.Net
Public Class search_book
    Private books As New Dictionary(Of String, Integer)
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text <> "" Then
            SearchBookByUserInput(TextBox1.Text)
        End If
    End Sub
    Private Sub SearchBookByUserInput(userInput As String)
        Try
            Dim matchingBook = books.FirstOrDefault(Function(book) book.Key.Replace(" ", "").IndexOf(userInput.Replace(" ", ""), StringComparison.OrdinalIgnoreCase) >= 0)

            If matchingBook.Key = "" AndAlso matchingBook.Value = 0 Then
                MsgBox("No book found", vbCritical, "Book Shelves")
                Return
            End If

            DisplayBookDetails(matchingBook.Value, matchingBook.Key)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub search_book_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAllBooks()
    End Sub
    Public Async Sub LoadAllBooks()
        Try
            Dim query As String = "SELECT bookTitle, bookID FROM books"

            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                Using cmd = New MySqlCommand(query, conn)
                    Dim reader As MySqlDataReader
                    reader = Await cmd.ExecuteReaderAsync

                    While Await reader.ReadAsync()
                        books.Add(reader.GetString("bookTitle"), reader.GetInt32("bookID"))
                    End While

                    reader.Close()
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Async Sub DisplayBookDetails(bookID As Integer, bookTitle As String)
        Try
            Dim query As String = "SELECT bookISBN, bookAuthor, bookPublisher, bookStatus, bookPublishedDate, bookCover, bookGenre FROM books " &
                                  "WHERE bookID = @bookID"

            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                Using cmd = New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@bookID", bookID)

                    Dim reader As MySqlDataReader = Await cmd.ExecuteReaderAsync

                    If reader.HasRows Then
                        Await reader.ReadAsync()

                        Dim bookISBN As String = reader.GetString("bookISBN")
                        Dim bookAuthor As String = reader.GetString("bookAuthor")
                        Dim bookPublisher As String = reader.GetString("bookPublisher")
                        Dim bookStatus As String = If(reader.GetBoolean("bookStatus"), "Available", "Not available")
                        Dim bookPublishedDate As String = reader.GetString("bookPublishedDate")
                        Dim bookGenre As String = reader.GetString("bookGenre")

                        Dim img As Byte() = DirectCast(reader("bookCover"), Byte())
                        Dim ms As New MemoryStream(img)

                        TextBox7.Text = bookID
                        TextBox2.Text = bookTitle
                        TextBox6.Text = bookISBN
                        TextBox4.Text = bookPublisher
                        TextBox5.Text = bookPublishedDate
                        TextBox3.Text = bookAuthor
                        TextBox8.Text = bookStatus
                        TextBox9.Text = bookGenre
                        PictureBox1.Image = Image.FromStream(ms)
                    End If

                    reader.Close()
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub ClearBookDetailsField()
        TextBox7.Text = ""
        TextBox2.Text = ""
        TextBox6.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox3.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        PictureBox1.Image = Nothing
    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text = "" Then
            ClearBookDetailsField()
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox7.Text <> "" Then
            If TextBox8.Text = "Not available" Then
                Dim result As DialogResult = MessageBox.Show("This book is currently not available, would you like to submit a reservation?", "Confirm", MessageBoxButtons.YesNo)
                If result = DialogResult.Yes Then
                    SubmitNewBookReservationForUser(StudentSession.Instance.StudentID, TextBox7.Text)
                End If
            Else
                SubmitBorrowBookRequest(StudentSession.Instance.StudentID, TextBox7.Text)
            End If
        End If
    End Sub
    Private Async Sub SubmitBorrowBookRequest(studentID As Integer, bookID As Integer)
        Try
            Dim query As String = "INSERT INTO borrow_request (studentID, bookID, borrowRequestDate) VALUES (@studentID, @bookID, @borrowRequestDate)"

            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@studentID", studentID)
                    cmd.Parameters.AddWithValue("@bookID", bookID)
                    cmd.Parameters.AddWithValue("@borrowRequestDate", Date.Today.ToShortDateString())

                    Await cmd.ExecuteNonQueryAsync()

                    MsgBox("Your request to borrow a book has been already recorded, Please wait for any librarian to process your request", vbInformation, "Borrow Request")
                End Using
            End Using
        Catch ex As MySqlException
            If ex.Number = 1062 Then
                MsgBox("You have already requested this book. Please wait for a librarian to process your request.", vbInformation, "Duplicate Request")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        user_dashboard.Show()
        Me.Close()
    End Sub
    Private Async Sub SubmitNewBookReservationForUser(studentID As Integer, bookID As Integer)
        Try
            Dim query As String = "INSERT INTO book_reservation (studentID, bookID) VALUES (@studentID, @bookID)"

            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@studentID", studentID)
                    cmd.Parameters.AddWithValue("@bookID", bookID)

                    Await cmd.ExecuteNonQueryAsync()

                    MsgBox("Your request for a book reservation has been recorded, Please wait until the book is available", vbInformation, "Reservation Request")
                End Using
            End Using
        Catch ex As MySqlException
            If ex.Number = 1062 Then
                MsgBox("You have already submit a book reservation request for this book, Please wait until the book is available", vbInformation, "Duplicate Request")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class