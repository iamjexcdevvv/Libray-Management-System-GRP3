Imports Microsoft.VisualBasic.Devices
Imports MySql.Data.MySqlClient

Public Class user_dashboard
    Dim controlsStartingPointY As Integer = 25
    Public Async Sub FetchUserData(username As String)
        Try
            Dim query As String = "SELECT id, studentName FROM users WHERE username = @username"

            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Using cmd = New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@username", username)

                    Dim reader As MySqlDataReader = Await cmd.ExecuteReaderAsync()

                    If reader.HasRows Then
                        Await reader.ReadAsync()

                        Dim studentName As String = reader.GetString("studentName")
                        Dim studentID As Integer = reader.GetInt32("id")

                        Dim firstName As String = studentName.Split(" ")(0).ToString()

                        StudentSession.Instance.StudentID = studentID
                        StudentSession.Instance.StudentUserName = username

                        Me.Show()

                        Label9.Text = "Hi, " & firstName & ""

                        'OnLoadStudentBorrowedBooks(studentID)

                        Form1.Close()
                    End If

                    reader.Close()
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        'Display all books available from the library
        library_books.Show()
        Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        'Borrow book
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs)
        'Return book
    End Sub
    Private Async Sub OnLoadStudentBorrowedBooks(studentID As Integer)
        Panel3.Controls.Clear()

        Try
            Dim query As String = "SELECT bo.id, bo.issueDate, bo.dueDate, book.bookID, book.bookTitle FROM borrowers bo INNER JOIN books book ON bo.bookID = book.bookID " &
                                  "WHERE bo.studentID = @studentID"

            Using conn As New MySqlConnection(connectionString)
                Await conn.OpenAsync()

                Using cmd = New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@studentID", studentID)

                    Dim reader As MySqlDataReader = Await cmd.ExecuteReaderAsync()

                    Panel1.AutoScroll = True
                    Panel1.Dock = DockStyle.Fill

                    While Await reader.ReadAsync()
                        Dim bookTitle As String = reader.GetString("bookTitle")
                        Dim bookIssueDate As String = reader.GetString("issueDate")
                        Dim bookDueDate As String = reader.GetString("dueDate")
                        Dim borrowerID As Integer = reader.GetInt32("id")
                        Dim bookID As Integer = reader.GetInt32("bookID")

                        CreateDynamicFields(borrowerID, bookID, studentID, bookTitle, bookIssueDate, bookDueDate)
                    End While

                    reader.Close()
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub CreateDynamicFields(borrowerID As Integer, bookID As Integer, studentID As Integer, bookTitle As String, bookIssueDate As String, bookDueDate As String)
        Dim bookTitleX As Integer = 21
        Dim issueDateX As Integer = 193
        Dim dueDateX As Integer = 319
        Dim returnBtnX As Integer = 431

        Dim bookTitleLabel = New Label()
        Dim issueDateLabel = New Label()
        Dim dueDateLabel = New Label()
        Dim returnBtn = New Button()

        bookTitleLabel.Text = "Book Title:"
        issueDateLabel.Text = "Issue Date:"
        dueDateLabel.Text = "Due Date:"
        returnBtn.Text = "Return Book"

        returnBtn.Size = New Size(110, 30)
        returnBtn.TextAlign = ContentAlignment.MiddleCenter
        returnBtn.Cursor = Cursors.Hand
        returnBtn.BackColor = Color.Green
        returnBtn.ForeColor = Color.WhiteSmoke

        returnBtn.Tag = {borrowerID, bookID, studentID}
        AddHandler returnBtn.Click, AddressOf ReturnBook_Click

        bookTitleLabel.Font = New Font("Arial Rounded MT", 10, FontStyle.Bold)
        issueDateLabel.Font = New Font("Arial Rounded MT", 10, FontStyle.Bold)
        dueDateLabel.Font = New Font("Arial Rounded MT", 10, FontStyle.Bold)
        returnBtn.Font = New Font("Arial Rounded MT", 10, FontStyle.Bold)

        bookTitleLabel.Location = New Point(bookTitleX, controlsStartingPointY)
        issueDateLabel.Location = New Point(issueDateX, controlsStartingPointY)
        dueDateLabel.Location = New Point(dueDateX, controlsStartingPointY)
        returnBtn.Location = New Point(returnBtnX, controlsStartingPointY + 21)

        Panel3.Controls.Add(bookTitleLabel)
        Panel3.Controls.Add(issueDateLabel)
        Panel3.Controls.Add(dueDateLabel)
        Panel3.Controls.Add(returnBtn)

        Dim bookTitleTextbox = New TextBox()
        Dim issueDateTextbox = New TextBox()
        Dim dueDateTextbox = New TextBox()

        bookTitleTextbox.Font = New Font("Arial Rounded MT", 9, FontStyle.Bold)
        issueDateTextbox.Font = New Font("Arial Rounded MT", 9, FontStyle.Bold)
        dueDateTextbox.Font = New Font("Arial Rounded MT", 9, FontStyle.Bold)

        bookTitleTextbox.Enabled = False
        issueDateTextbox.Enabled = False
        dueDateTextbox.Enabled = False

        bookTitleTextbox.Text = bookTitle
        issueDateTextbox.Text = bookIssueDate
        dueDateTextbox.Text = bookDueDate

        bookTitleTextbox.Location = New Point(bookTitleX, controlsStartingPointY + 24)
        issueDateTextbox.Location = New Point(issueDateX, controlsStartingPointY + 24)
        dueDateTextbox.Location = New Point(dueDateX, controlsStartingPointY + 24)

        bookTitleTextbox.Width = 150

        Panel3.Controls.Add(bookTitleTextbox)
        Panel3.Controls.Add(issueDateTextbox)
        Panel3.Controls.Add(dueDateTextbox)

        controlsStartingPointY += 66
    End Sub
    Private Async Sub ReturnBook_Click(sender As Object, e As EventArgs)
        Dim btnReturn As Button = CType(sender, Button)
        Dim borrowerID As Integer = CInt(btnReturn.Tag(0))
        Dim bookID As Integer = CInt(btnReturn.Tag(1))
        Dim studentID As Integer = CInt(btnReturn.Tag(2))

        Dim query As String = "DELETE FROM borrowers WHERE id = @borrowerID"

        Using conn As New MySqlConnection(connectionString)
            conn.Open()
            Using cmd = New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@borrowerID", borrowerID)

                Await cmd.ExecuteNonQueryAsync()

                MsgBox("The book has been returned to the librarian", vbInformation, "Book Return")

                book_issuance.UpdateBookStatus(bookID, True)
                controlsStartingPointY = 25
                OnLoadStudentBorrowedBooks(studentID)
            End Using
        End Using
    End Sub
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        search_book.Show()
        Me.Close()
    End Sub
    Private Sub user_dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FetchUserData(StudentSession.Instance.StudentUserName)
        OnLoadStudentBorrowedBooks(StudentSession.Instance.StudentID)
    End Sub
End Class