﻿Public Class Form1
    Dim showPass As Boolean
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" And TextBox2.Text = "" Then
            MsgBox("Fill the blanks", vbCritical, "Fill it!")
            TextBox1.Clear()
            TextBox2.Clear()
        End If

        If TextBox1.Text = "user" And TextBox2.Text = "user" Then
            MsgBox("Welcome to the Library!", vbInformation, "Welcome")
            user_dashboard.Show()
            Me.Close()
        End If

        If TextBox1.Text = "Admin" And TextBox2.Text = "Admin678" Then
            MsgBox("Welcome to the Library!", vbInformation, "Welcome")
            admin_dashboard.Show()
            Me.Close()
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
End Class
