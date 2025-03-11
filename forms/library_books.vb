Public Class library_books
    Private Sub library_books_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.AutoScroll = True

        Dim x As Integer = 13
        Dim y As Integer = 13

        For i As Integer = 1 To 10
            Dim picBox As New PictureBox()
            picBox.Size = New Size(197, 218)
            picBox.Location = New Point(x, y)
            picBox.BorderStyle = BorderStyle.FixedSingle
            picBox.SizeMode = PictureBoxSizeMode.StretchImage
            picBox.BackColor = Color.Transparent

            picBox.Image = My.Resources.photo

            AddHandler picBox.Click, AddressOf PictureBox_Click

            Panel1.Controls.Add(picBox)

            If x + 203 >= Panel1.Width Then
                x = 13
                y += 224
            Else
                x += 203
            End If
        Next
    End Sub

    Private Sub PictureBox_Click(sender As Object, e As EventArgs)
        Dim picBox As PictureBox = CType(sender, PictureBox)
        MessageBox.Show("You clicked on: " & picBox.ImageLocation)
    End Sub
End Class