<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class user_dashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(user_dashboard))
        Panel1 = New Panel()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Panel2 = New Panel()
        Panel3 = New Panel()
        Panel6 = New Panel()
        Button3 = New Button()
        PictureBox4 = New PictureBox()
        Panel5 = New Panel()
        Button2 = New Button()
        PictureBox3 = New PictureBox()
        Panel4 = New Panel()
        Button1 = New Button()
        PictureBox2 = New PictureBox()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        Panel6.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        Panel5.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        Panel4.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(238), CByte(115), CByte(12))
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(200, 106)
        Panel1.TabIndex = 0
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(45, 5)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(100, 61)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.FromArgb(CByte(238), CByte(115), CByte(12))
        Label1.Font = New Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(21, 69)
        Label1.Name = "Label1"
        Label1.Size = New Size(158, 22)
        Label1.TabIndex = 0
        Label1.Text = "User Dashboard"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(67), CByte(85), CByte(244))
        Panel2.Location = New Point(0, 106)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(200, 402)
        Panel2.TabIndex = 0
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = SystemColors.ButtonFace
        Panel3.Controls.Add(Panel6)
        Panel3.Controls.Add(Panel5)
        Panel3.Controls.Add(Panel4)
        Panel3.Location = New Point(224, 12)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(525, 484)
        Panel3.TabIndex = 1
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = SystemColors.ActiveCaption
        Panel6.BorderStyle = BorderStyle.FixedSingle
        Panel6.Controls.Add(Button3)
        Panel6.Controls.Add(PictureBox4)
        Panel6.Location = New Point(15, 294)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(114, 144)
        Panel6.TabIndex = 3
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Transparent
        Button3.Cursor = Cursors.Hand
        Button3.FlatStyle = FlatStyle.System
        Button3.Font = New Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button3.ForeColor = Color.White
        Button3.Location = New Point(19, 82)
        Button3.Name = "Button3"
        Button3.Size = New Size(75, 57)
        Button3.TabIndex = 5
        Button3.Text = "RETURN BOOK"
        Button3.UseVisualStyleBackColor = False
        Button3.UseWaitCursor = True
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BorderStyle = BorderStyle.FixedSingle
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(1, 3)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(108, 76)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 4
        PictureBox4.TabStop = False
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = SystemColors.ActiveCaption
        Panel5.BorderStyle = BorderStyle.FixedSingle
        Panel5.Controls.Add(Button2)
        Panel5.Controls.Add(PictureBox3)
        Panel5.Location = New Point(15, 135)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(114, 144)
        Panel5.TabIndex = 2
        ' 
        ' Button2
        ' 
        Button2.AccessibleRole = AccessibleRole.None
        Button2.Cursor = Cursors.Hand
        Button2.FlatStyle = FlatStyle.System
        Button2.Font = New Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.White
        Button2.Location = New Point(13, 82)
        Button2.Name = "Button2"
        Button2.Size = New Size(89, 57)
        Button2.TabIndex = 4
        Button2.Text = "BORROWERS LIST"
        Button2.UseVisualStyleBackColor = True
        Button2.UseWaitCursor = True
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BorderStyle = BorderStyle.FixedSingle
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(3, 3)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(106, 76)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 0
        PictureBox3.TabStop = False
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = SystemColors.ActiveCaption
        Panel4.BorderStyle = BorderStyle.FixedSingle
        Panel4.Controls.Add(Button1)
        Panel4.Controls.Add(PictureBox2)
        Panel4.Location = New Point(15, 15)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(114, 114)
        Panel4.TabIndex = 0
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.ActiveCaption
        Button1.Cursor = Cursors.Hand
        Button1.FlatStyle = FlatStyle.System
        Button1.Font = New Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.White
        Button1.Location = New Point(19, 80)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 29)
        Button1.TabIndex = 3
        Button1.Text = "LIBRARY"
        Button1.UseVisualStyleBackColor = False
        Button1.UseWaitCursor = True
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BorderStyle = BorderStyle.FixedSingle
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(3, 3)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(108, 76)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 1
        PictureBox2.TabStop = False
        ' 
        ' user_dashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(761, 508)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(Panel3)
        Name = "user_dashboard"
        Text = "user_dashboard"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel6.ResumeLayout(False)
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        Panel5.ResumeLayout(False)
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        Panel4.ResumeLayout(False)
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel6 As Panel
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Button3 As Button
End Class
