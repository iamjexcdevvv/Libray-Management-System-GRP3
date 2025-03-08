Imports System.Drawing.Imaging
Imports System.IO
Imports System.Net
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar
Imports BCrypt
Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Crypto.Generators
Imports Windows.Win32.UI.Input
Public Class manage_students
    Private selectedStudentPhoto As String = ""
    Private selectedUserID As Integer = -1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
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
                If selectedStudentPhoto = "" Then
                    selectedStudentPhoto = "photo.png"
                End If

                Dim convertedImage As Byte() = ConvertSelectedPhotoToByte(PictureBox2)

                Dim password = Net.BCrypt.HashPassword(TextBox4.Text)

                SaveNewUser(Textbox1.Text, password, TextBox2.Text + " " + TextBox3.Text, ComboBox1.Text, convertedImage)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            ClearAddUserField()
        End If
    End Sub
    Private Sub manage_students_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GenerateAvailableUserRole(ComboBox1)

        ComboBox1.SelectedIndex = 1
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim openUserFolder = New manage_books

        Dim fileName = openUserFolder.OpenUserFolder

        If fileName <> "" Then
            PictureBox2.Image = Image.FromFile(fileName)
            selectedStudentPhoto = fileName
        End If
    End Sub

    Private Sub ClearAddUserField()
        Textbox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        PictureBox2.Image = My.Resources.photo
        ComboBox1.Text = ComboBox1.SelectedIndex = 1

        ErrorProvider1.Clear()
    End Sub
    Private Sub ClearUserEditField()
        TextBox7.Text = ""
        TextBox6.Text = ""
        ComboBox2.Items.Clear()
        ComboBox3.Text = ""
        PictureBox3.Image = My.Resources.photo

        TextBox7.Enabled = False
        TextBox6.Enabled = False
        ComboBox2.Enabled = False
        Button4.Enabled = False
        Button3.Enabled = False
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

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        Dim selectedTab As TabPage = TabControl1.SelectedTab

        Select Case selectedTab.Name
            Case "TabPage3"
                DisplayUsers()
            Case "TabPage2"
                LoadUsers()
        End Select
    End Sub
    Private Async Sub LoadUsers()
        Try
            ComboBox3.Items.Clear()

            Dim query As String = "SELECT id FROM users"
            Using conn As New MySqlConnection(connectionString)
                Await conn.OpenAsync()

                Using cmd = New MySqlCommand(query, conn)
                    Dim reader As MySqlDataReader
                    reader = Await cmd.ExecuteReaderAsync

                    While Await reader.ReadAsync()
                        ComboBox3.Items.Add(reader("id"))
                    End While

                    reader.Close()
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        If IsNumeric(ComboBox3.Text) Then
            Dim userID As Integer = ComboBox3.Text
            LoadUserData(userID)
        End If
    End Sub
    Private Async Sub LoadUserData(userID As Integer)
        Try
            GenerateAvailableUserRole(ComboBox2)

            Dim query As String = "SELECT studentName, studentProfile, studentRole FROM users WHERE id = @userID"

            Using conn As New MySqlConnection(connectionString)
                Await conn.OpenAsync()

                Using cmd = New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@userID", userID)

                    Dim reader As MySqlDataReader = Await cmd.ExecuteReaderAsync

                    If reader.HasRows Then
                        Await reader.ReadAsync()

                        Dim studentName As String = reader.GetString("studentName")
                        Dim studentRole As String = reader.GetString("studentRole")

                        Dim firstName As String = Strings.Split(studentName)(0).ToString()
                        Dim lastName As String = Strings.Split(studentName)(1).ToString()

                        Dim img As Byte() = DirectCast(reader("studentProfile"), Byte())
                        Dim ms As New MemoryStream(img)

                        TextBox7.Text = firstName
                        TextBox6.Text = lastName
                        ComboBox2.Text = studentRole
                        PictureBox3.Image = Image.FromStream(ms)
                    End If

                    reader.Close()
                End Using
            End Using

            TextBox7.Enabled = True
            TextBox6.Enabled = True
            ComboBox2.Enabled = True
            Button4.Enabled = True
            Button3.Enabled = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub GenerateAvailableUserRole(obj As Object)
        obj.Items.Add("Librarian")
        obj.Items.Add("Student")
    End Sub

    Private Sub TabControl1_OnChangeTab(sender As Object, e As TabControlCancelEventArgs) Handles TabControl1.Deselecting
        If e.TabPage.Name = "TabPage2" Then
            ClearUserEditField()
        End If
    End Sub

    Private Async Sub SaveSelectedStudentProfile()
        If selectedStudentPhoto <> "" Then
            Try
                Dim query As String = "UPDATE users SET studentProfile = @studentProfile WHERE id = @userID"

                Dim studentProfile As Byte() = ConvertSelectedPhotoToByte(PictureBox3)

                Using conn As New MySqlConnection(connectionString)
                    conn.Open()

                    Using cmd = New MySqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@studentProfile", studentProfile)
                        cmd.Parameters.AddWithValue("@userID", ComboBox3.Text)

                        Await cmd.ExecuteNonQueryAsync()
                    End Using
                End Using
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        SaveEditedUserData
        SaveSelectedStudentProfile

        MsgBox("Data saved succesfully!", vbInformation)
        ClearUserEditField
    End Sub
    Private Async Sub SaveEditedUserData()
        Try
            Dim query As String = "UPDATE users SET studentName = @studentName, studentRole = @studentRole WHERE id = @userID"

            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                Using cmd = New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@studentName", (TextBox7.Text + " " + TextBox6.Text))
                    cmd.Parameters.AddWithValue("@studentRole", ComboBox2.Text)
                    cmd.Parameters.AddWithValue("@userID", ComboBox3.Text)

                    Await cmd.ExecuteNonQueryAsync()
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Function ConvertSelectedPhotoToByte(imageBox As PictureBox) As Byte()
        Dim studentProfilePhotoFormat As ImageFormat
        Dim fileExtension = Path.GetExtension(selectedStudentPhoto).ToLower

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
        imageBox.Image.Save(mstream, studentProfilePhotoFormat)
        Dim convertedImage = mstream.GetBuffer
        mstream.Close()

        Return convertedImage
    End Function
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim openUserFolder = New manage_books
        Dim fileName = openUserFolder.OpenUserFolder

        If fileName <> "" Then
            PictureBox3.Image = Image.FromFile(fileName)
            selectedStudentPhoto = fileName
        End If
    End Sub
    Private Async Sub DisplayUsers()
        Try
            Dim query As String = "SELECT * FROM users"
            Using conn As New MySqlConnection(connectionString)
                Await conn.OpenAsync()

                Using cmd = New MySqlCommand(query, conn)
                    Await cmd.ExecuteNonQueryAsync()

                    Dim dataTable As New DataTable()
                    Dim dataAdapter As New MySqlDataAdapter(cmd)

                    dataAdapter.Fill(dataTable)

                    DataGridView1.DataSource = dataTable
                    DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        ClearAddUserField()
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            If selectedUserID = 0 Then
                Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete all users?", "Confirm", MessageBoxButtons.YesNo)
                If result = DialogResult.Yes Then
                    DeleteAllUsers()
                End If
            ElseIf selectedUserID = -1 Then
                MsgBox("Invalid selected row!", vbCritical)
                Return
            Else
                Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this user?", "Confirm", MessageBoxButtons.YesNo)
                If result = DialogResult.Yes Then
                    DeleteUser(selectedUserID)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Async Sub DeleteAllUsers()
        Try
            Using conn As New MySqlConnection(connectionString)
                Await conn.OpenAsync()

                Dim query As String = "DELETE FROM users"

                Using cmd As New MySqlCommand(query, conn)
                    Await cmd.ExecuteNonQueryAsync()

                    If DataGridView1.DataSource IsNot Nothing Then
                        Dim dt As DataTable = CType(DataGridView1.DataSource, DataTable)
                        If dt IsNot Nothing Then
                            dt.Rows.Clear()

                            MsgBox("All users has been removed from the database", vbInformation)
                        End If
                    ElseIf DataGridView1.Rows.Count > 0 Then
                        DataGridView1.Rows.Clear()

                        MsgBox("All users has been removed from the database", vbInformation)
                    Else
                        MessageBox.Show("The DataGridView is already empty.")
                    End If
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Async Sub DeleteUser(selectedUserID As Integer)
        Try
            Using conn As New MySqlConnection(connectionString)
                Await conn.OpenAsync()

                Dim query As String = "DELETE FROM users WHERE id = @userID"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@userID", selectedUserID)

                    Await cmd.ExecuteNonQueryAsync()
                End Using
            End Using

            DisplayUsers()

            MsgBox("The user is deleted successfully!", vbInformation, "Manage User")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged
        Try
            If DataGridView1.SelectedRows.Count > 1 Then
                selectedUserID = 0
            ElseIf DataGridView1.SelectedRows.Count = 1 Then
                Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)
                selectedUserID = CInt(selectedRow.Cells("id").Value)
            Else
                Return
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class