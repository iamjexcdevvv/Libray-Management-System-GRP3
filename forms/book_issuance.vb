Imports System.Net
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Imports Mysqlx.Cursor

Public Class book_issuance
    Private Async Sub LoadBorrowersStudentID()
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                Dim reader As MySqlDataReader
                Dim query As String = "SELECT studentID FROM borrow_request"

                Using cmd = New MySqlCommand(query, conn)
                    reader = Await cmd.ExecuteReaderAsync()

                    While Await reader.ReadAsync()
                        Dim studentID = reader.GetInt32("studentID")
                        If Not ComboBox1.Items.Contains(studentID) Then
                            ComboBox1.Items.Add(studentID)
                        End If
                    End While
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Async Sub LoadBorrowerBooksRequest()
        If ComboBox1.Text <> "" Then
            ComboBox2.Items.Clear()

            Try
                Using conn As New MySqlConnection(connectionString)
                    conn.Open()

                    Dim reader As MySqlDataReader
                    Dim query As String = "SELECT bookID FROM borrow_request WHERE studentID = @studentID"

                    Using cmd = New MySqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@studentID", ComboBox1.Text)

                        reader = Await cmd.ExecuteReaderAsync()

                        While Await reader.ReadAsync()
                            ComboBox2.Items.Add(reader("bookID"))
                        End While
                    End Using
                End Using
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
    Private Async Sub FetchStudentName(studentID As Integer)
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                Dim reader As MySqlDataReader
                Dim query As String = "SELECT studentName FROM users WHERE id = @studentID"

                Using cmd = New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@studentID", studentID)

                    reader = Await cmd.ExecuteReaderAsync()

                    If reader.HasRows Then
                        Await reader.ReadAsync()

                        Dim studentName As String = reader.GetString("studentName")

                        TextBox1.Text = studentName
                    End If
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Async Sub FetchBookTitle(bookID As Integer)
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                Dim reader As MySqlDataReader
                Dim query As String = "SELECT bookTitle FROM books WHERE bookID = @bookID"

                Using cmd = New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@bookID", bookID)

                    reader = Await cmd.ExecuteReaderAsync()

                    If reader.HasRows Then
                        Await reader.ReadAsync()

                        Dim bookTitle As String = reader.GetString("bookTitle")

                        TextBox2.Text = bookTitle
                    End If
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub ClearBookIssueFields()
        ComboBox1.Items.Add("")
        ComboBox2.Items.Add("")

        TextBox1.Text = ""
        TextBox2.Text = ""
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        DateTimePicker1.Value = Date.Today
        DateTimePicker2.Value = Date.Today

        ComboBox1.Items.Remove("")
        ComboBox2.Items.Remove("")
    End Sub
    Private Async Sub IssueNewBookBorrower(studentID As Integer, bookID As Integer, issueDate As String, bookDueDate As String)
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                Dim query As String = "INSERT INTO borrowers (studentID, bookID, issueDate, dueDate) " &
                                      "VALUES (@studentID, @bookID, @issueDate, @dueDate)"

                Using cmd = New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@studentID", studentID)
                    cmd.Parameters.AddWithValue("@bookID", bookID)
                    cmd.Parameters.AddWithValue("@issueDate", issueDate)
                    cmd.Parameters.AddWithValue("@dueDate", bookDueDate)

                    Await cmd.ExecuteNonQueryAsync()

                    Dim message As String = "Book Issued Successfully!" & vbCrLf & vbCrLf &
                            "Book Title: " & TextBox2.Text & vbCrLf &
                            "Student Name: " & TextBox1.Text & " (ID: " & studentID & ")" & vbCrLf &
                            "Issue Date: " & issueDate & vbCrLf &
                            "Due Date: " & bookDueDate & vbCrLf & vbCrLf &
                            "Please remind the student to return the book by the due date to avoid any consequences."

                    MessageBox.Show(message, "Book Issued", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    RemoveBorrowerRequestRecord(studentID, bookID)
                    UpdateBookStatus(bookID, False)
                    ClearBookIssueFields()
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        admin_dashboard.Show()
        Me.Close()
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text <> "" Then
            FetchStudentName(ComboBox1.Text)
            LoadBorrowerBooksRequest()
        End If
    End Sub
    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        If ComboBox2.Text <> "" Then
            FetchBookTitle(ComboBox2.Text)
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim validated = True

        If ComboBox1.Text = "" Then
            ErrorProvider1.SetError(ComboBox1, "Please select the student id")
            validated = False
        Else
            ErrorProvider1.SetError(ComboBox1, "")
        End If

        If ComboBox2.Text = "" Then
            ErrorProvider1.SetError(ComboBox2, "Please select the book id")
            validated = False
        Else
            ErrorProvider1.SetError(ComboBox2, "")
        End If

        If DateTimePicker2.Value < DateTimePicker1.Value Then
            MsgBox("Due date cannot be in the past. Please enter a valid due date!", vbCritical, "Issue Book")
            validated = False
        End If

        If validated Then
            IssueNewBookBorrower(ComboBox1.Text, ComboBox2.Text, DateTimePicker1.Value.ToShortDateString(), DateTimePicker2.Value.ToShortDateString())
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ClearBookIssueFields()
    End Sub
    Private Sub book_issuance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadBorrowersStudentID()
    End Sub
    Public Async Sub UpdateBookStatus(bookID As Integer, bookStatus As Boolean)
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                Dim query As String = "UPDATE books SET bookStatus = @bookStatus WHERE bookID = @bookID"

                Using cmd = New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@bookStatus", bookStatus)
                    cmd.Parameters.AddWithValue("@bookID", bookID)

                    Await cmd.ExecuteNonQueryAsync()

                    LoadBorrowerBooksRequest()
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Async Sub RemoveBorrowerRequestRecord(studentID As Integer, bookID As Integer)
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                Dim query As String = "DELETE FROM borrow_request WHERE studentID = @studentID AND bookID = @bookID"

                Using cmd = New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@studentID", studentID)
                    cmd.Parameters.AddWithValue("@bookID", bookID)

                    Await cmd.ExecuteNonQueryAsync()
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class