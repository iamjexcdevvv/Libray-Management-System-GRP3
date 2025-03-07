Imports System.Drawing.Imaging
Imports System.IO
Imports System.Net
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports BCrypt
Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Crypto.Generators
Public Class manage_students
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim defaultImage = New manage_books
        ErrorProvider1.Clear()

        Dim isValid = True

        If String.IsNullOrEmpty(Textbox1.Text) Then
            ErrorProvider1.SetError(Textbox1, "Please fill this field!")
            isValid = False
        End If

        If String.IsNullOrEmpty(TextBox2.Text) Then
            ErrorProvider1.SetError(TextBox2, "Please fill this field!")
            isValid = False
        End If

        If String.IsNullOrEmpty(TextBox3.Text) Then
            ErrorProvider1.SetError(TextBox3, "Please fill this field!")
            isValid = False
        End If

        If String.IsNullOrEmpty(TextBox4.Text) Then
            ErrorProvider1.SetError(TextBox4, "Please fill this field!")
            isValid = False
        End If

        If isValid Then
            Try
                Dim studentProfilePhotoFormat As ImageFormat
                Dim fileExtension = Path.GetExtension("photo.png").ToLower

                Select Case fileExtension
                    Case ".jpg", ".jpeg"
                        studentProfilePhotoFormat = ImageFormat.Jpeg
                    Case ".png"
                        studentProfilePhotoFormat = ImageFormat.Png
                    Case ".bmp"
                        studentProfilePhotoFormat = ImageFormat.Bmp
                    Case ".gif"
                        studentProfilePhotoFormat = ImageFormat.Gif
                    Case ".ico"
                        studentProfilePhotoFormat = ImageFormat.Icon
                    Case Else
                        Throw New NotSupportedException("Unsupported image format.")
                End Select

                Dim mstream As New MemoryStream
                PictureBox2.Image.Save(mstream, studentProfilePhotoFormat)
                Dim convertedImage = mstream.GetBuffer
                mstream.Close()

                Dim password = Net.BCrypt.HashPassword(TextBox4.Text)

                SaveNewUser(Textbox1.Text, password, TextBox2.Text + " " + TextBox3.Text, ComboBox1.Text, convertedImage)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            ClearAddUserField()
        End If
    End Sub
    Private Sub manage_students_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("Librarian")
        ComboBox1.Items.Add("Student")

        ComboBox1.SelectedIndex = 1
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim openUserFolder = New manage_books

        Dim fileName = openUserFolder.OpenUserFolder

        PictureBox2.Image = Image.FromFile(fileName)
    End Sub

    Private Sub ClearAddUserField()
        Textbox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        PictureBox2.Image = My.Resources.photo
        ComboBox1.Text = ComboBox1.SelectedIndex = 1
    End Sub
    Private Async Sub SaveNewUser(username As String, password As String, studentName As String, studentRole As String, studentPhoto As Byte())
        Try
            Dim query As String = "INSERT INTO users (username, studentPassword, studentName, studentRole, studentProfile) VALUES " &
                                  "(@username, @studentPassword, @studentName, @studentRole, @studentProfile)"

            Using conn As New MySqlConnection(connectionString)
                Await conn.OpenAsync()

                Using cmd = New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@username", username)
                    cmd.Parameters.AddWithValue("@studentPassword", password)
                    cmd.Parameters.AddWithValue("@studentName", studentName)
                    cmd.Parameters.AddWithValue("@studentRole", studentRole)
                    cmd.Parameters.AddWithValue("@studentProfile", studentPhoto)

                    Await cmd.ExecuteNonQueryAsync()

                    MsgBox("Data inserted successfully!", vbInformation, "Data Saved")
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
End Class