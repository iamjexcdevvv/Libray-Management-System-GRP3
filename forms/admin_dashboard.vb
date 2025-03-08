
Imports System.Net
Imports MySql.Data.MySqlClient
Public Class admin_dashboard
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        manage_books.Show()
        Me.Close()
    End Sub
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        manage_students.Show()
        Me.Close()
    End Sub
    Private Async Sub FetchUsersCount()
        Try
            Using conn As New MySqlConnection(connectionString)
                Await conn.OpenAsync()

                Dim query As String = "SELECT count(*) FROM users"
                Using cmd As New MySqlCommand(query, conn)
                    Dim usersCount As Integer = Await cmd.ExecuteScalarAsync()

                    TextBox2.Text = usersCount
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Async Sub FetchBooksCount()
        Try
            Using conn As New MySqlConnection(connectionString)
                Await conn.OpenAsync()

                Dim query As String = "SELECT count(*) FROM books"
                Using cmd As New MySqlCommand(query, conn)
                    Dim bookCounts As Integer = Await cmd.ExecuteScalarAsync()

                    TextBox1.Text = bookCounts
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub admin_dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FetchBooksCount()
        FetchUsersCount()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Close()
    End Sub
End Class