Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports MySql.Data.MySqlClient

Public Class Form1
    Dim showPass As Boolean
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "Admin" And TextBox2.Text = "Admin678" Then
            MsgBox("Welcome to the Library!", vbInformation, "Welcome")
            admin_dashboard.Show()
            Me.Close()
        Else
            If TextBox1.Text = "" And TextBox2.Text = "" Then
                MsgBox("Fill the blanks", vbCritical, "Fill it!")
                ClearLoginFields()
                Return
            End If

            OnCheckUserPassword(TextBox1.Text, TextBox2.Text)
        End If
    End Sub
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If showPass Then
            showPass = False
            TextBox2.PasswordChar = "*"

            PictureBox2.Image = My.Resources.hide
        Else
            showPass = True
            TextBox2.PasswordChar = Nothing

            PictureBox2.Image = My.Resources.showico
        End If
    End Sub
    Private Async Sub OnCheckUserPassword(userNameInput As String, userPasswordInput As String)
        Dim query As String = "SELECT studentPassword, studentRole FROM users WHERE username = @username"

        Try
            Using conn As New MySqlConnection(connectionString)
                Await conn.OpenAsync()

                Using cmd = New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@username", userNameInput)

                    Dim reader As MySqlDataReader = Await cmd.ExecuteReaderAsync

                    If Not reader.HasRows Then
                        ClearLoginFields()
                        MsgBox("Account not found!", vbCritical, "Login")
                        Return
                    End If

                    Await reader.ReadAsync()
                    Dim password As String = reader.GetString("studentPassword")
                    Dim studentRole As String = reader.GetString("studentRole")

                    If Not BCrypt.Net.BCrypt.Verify(userPasswordInput, password) Then
                        ClearLoginFields()
                        MsgBox("Wrong password!", vbCritical, "Login")
                        Return
                    End If

                    LoginUser(studentRole)
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub LoginUser(studentRole As String)
        Select Case studentRole
            Case "Librarian"
                admin_dashboard.Show()
                Me.Close()
            Case "Student"
                Dim userDashboard As user_dashboard = New user_dashboard()
                userDashboard.FetchUserData(TextBox1.Text)
        End Select
    End Sub
    Private Sub ClearLoginFields()
        TextBox1.Clear()
        TextBox2.Clear()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form2.Show()
        Me.Close()
    End Sub
End Class
