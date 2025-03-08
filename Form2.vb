Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient

Public Class Form2
    Private Function IsValidEmailFormat(input As String) As Boolean
        Return Regex.IsMatch(input, "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$")
    End Function
    Private Function IsValidUserInput()
        Dim isValidInput As Boolean = True

        If TextBox1.Text = "" Then
            ErrorProvider1.SetError(TextBox1, "Please fill this out!")
            isValidInput = False
        Else
            ErrorProvider1.SetError(TextBox1, "")
        End If

        If TextBox3.Text = "" Then
            ErrorProvider1.SetError(TextBox3, "Please fill this out!")
            isValidInput = False
        Else
            ErrorProvider1.SetError(TextBox3, "")
        End If

        If TextBox6.Text = "" Then
            ErrorProvider1.SetError(TextBox6, "Please fill this out!")
            isValidInput = False
        Else
            ErrorProvider1.SetError(TextBox6, "")
        End If

        If TextBox2.Text = "" Then
            ErrorProvider1.SetError(TextBox2, "Please fill this out!")
            isValidInput = False
        Else
            ErrorProvider1.SetError(TextBox2, "")
        End If

        If TextBox7.Text = "" Then
            ErrorProvider1.SetError(TextBox7, "Please fill this out!")
            isValidInput = False
        Else
            If Not IsValidEmailFormat(TextBox7.Text) Then
                ErrorProvider1.SetError(TextBox7, "Invalid email format")
                isValidInput = False
            Else
                ErrorProvider1.SetError(TextBox7, "")
            End If
        End If

        Return isValidInput
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (IsValidUserInput()) Then
            Dim password As String = BCrypt.Net.BCrypt.HashPassword(TextBox2.Text)
            Dim studentName As String = TextBox1.Text + " " + TextBox3.Text
            Dim studentGender As String = "Female"

            If RadioButton2.Checked Then
                studentGender = "Male"
            End If

            RegisterNewUser(TextBox4.Text, TextBox7.Text, password, studentName, studentGender)
        End If
    End Sub
    Private Async Sub RegisterNewUser(userName As String, email As String, password As String, studentName As String, studentGender As String)
        Try
            Dim query As String = "INSERT INTO users (username, email, studentPassword, studentName, studentGender) " &
                                  "VALUES (@username, @email, @studentPassword, @studentName, @studentGender)"

            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@username", userName)
                    cmd.Parameters.AddWithValue("@email", email)
                    cmd.Parameters.AddWithValue("@studentPassword", password)
                    cmd.Parameters.AddWithValue("@studentName", studentName)
                    cmd.Parameters.AddWithValue("@studentGender", studentGender)

                    Await cmd.ExecuteNonQueryAsync()

                    Form1.Show()
                    Me.Close()
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Show()
        Me.Close()
    End Sub
End Class