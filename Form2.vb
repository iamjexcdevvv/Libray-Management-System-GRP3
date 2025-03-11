Imports System.Text.RegularExpressions
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports MySql.Data.MySqlClient

Public Class Form2
    Private selectedStudentPhoto As String = ""
    Public Function IsValidEmailFormat(input As String) As Boolean
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

        If TextBox4.Text = "" Then
            ErrorProvider1.SetError(TextBox4, "Please fill this out!")
            isValidInput = False
        Else
            ErrorProvider1.SetError(TextBox4, "")
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

        If selectedStudentPhoto = "" Then
            ErrorProvider1.SetError(Label14, "Please select a photo")
            isValidInput = False
        Else
            ErrorProvider1.SetError(Label14, "")
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
        If IsValidUserInput() Then
            Dim password = BCrypt.Net.BCrypt.HashPassword(TextBox2.Text)
            Dim studentName = TextBox1.Text + " " + TextBox3.Text
            Dim studentGender = "Female"

            If RadioButton2.Checked Then
                studentGender = "Male"
            End If

            CheckUserNameAccount(TextBox4.Text, password, studentName, studentGender)
        End If
    End Sub
    Private Async Sub CheckUserNameAccount(userName As String, password As String, studentName As String, studentGender As String)
        Try
            Dim query As String = "SELECT COUNT(*) FROM users WHERE username = @username"

            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@username", userName)

                    Dim userCounts As Integer = Await cmd.ExecuteScalarAsync()

                    If userCounts >= 1 Then
                        MsgBox("This username is no longer available", vbCritical, "Registration")
                        Return
                    End If

                    Dim convertedImage As Byte() = manage_students.ConvertSelectedPhotoToByte(selectedStudentPhoto)

                    RegisterNewUser(TextBox4.Text, TextBox7.Text, password, studentName, studentGender, convertedImage)
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Async Sub RegisterNewUser(userName As String, email As String, password As String, studentName As String, studentGender As String, studentProfile As Byte())
        Try
            Dim query As String = "INSERT INTO users (username, email, studentPassword, studentName, studentGender, studentProfile) " &
                                  "VALUES (@username, @email, @studentPassword, @studentName, @studentGender, @studentProfile)"

            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@username", userName)
                    cmd.Parameters.AddWithValue("@email", email)
                    cmd.Parameters.AddWithValue("@studentPassword", password)
                    cmd.Parameters.AddWithValue("@studentName", studentName)
                    cmd.Parameters.AddWithValue("@studentGender", studentGender)
                    cmd.Parameters.AddWithValue("@studentProfile", studentProfile)

                    Await cmd.ExecuteNonQueryAsync()

                    Dim message As String = "Welcome " & studentName & "!" & Environment.NewLine &
                                            "To get started, log in to your account and explore our application." & Environment.NewLine

                    MsgBox(message, vbInformation, "Registration")

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
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim openUserFolder = New manage_books

        Dim fileName = openUserFolder.OpenUserFolder

        If fileName <> "" Then
            selectedStudentPhoto = fileName
            Label14.Text = fileName
        End If
    End Sub
End Class