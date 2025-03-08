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
        Button4 = New Button()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Label2 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Panel3 = New Panel()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Panel6 = New Panel()
        Button2 = New Button()
        PictureBox4 = New PictureBox()
        Panel5 = New Panel()
        Button3 = New Button()
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
        Panel1.Controls.Add(Button4)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(Label10)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(830, 75)
        Panel1.TabIndex = 0
        ' 
        ' Button4
        ' 
        Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), Image)
        Button4.BackgroundImageLayout = ImageLayout.Stretch
        Button4.Cursor = Cursors.Hand
        Button4.FlatStyle = FlatStyle.Popup
        Button4.Location = New Point(778, 24)
        Button4.Name = "Button4"
        Button4.Size = New Size(40, 31)
        Button4.TabIndex = 5
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(12, 24)
        Label1.Name = "Label1"
        Label1.Size = New Size(175, 24)
        Label1.TabIndex = 4
        Label1.Text = "User Dashboard"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(536, 6)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(100, 61)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.FromArgb(CByte(238), CByte(115), CByte(12))
        Label2.Font = New Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(642, 6)
        Label2.Name = "Label2"
        Label2.Size = New Size(116, 22)
        Label2.TabIndex = 0
        Label2.Text = "WELCOME!"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = SystemColors.ButtonHighlight
        Label9.Location = New Point(663, 33)
        Label9.Name = "Label9"
        Label9.Size = New Size(69, 15)
        Label9.TabIndex = 2
        Label9.Text = "Hi, Admin"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold)
        Label10.ForeColor = SystemColors.ActiveCaption
        Label10.Location = New Point(642, 52)
        Label10.Name = "Label10"
        Label10.Size = New Size(109, 15)
        Label10.TabIndex = 3
        Label10.Text = "admin@gmail.com"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = SystemColors.ButtonFace
        Panel3.Controls.Add(Label8)
        Panel3.Controls.Add(Label7)
        Panel3.Controls.Add(Label6)
        Panel3.Controls.Add(Label5)
        Panel3.Controls.Add(Label4)
        Panel3.Controls.Add(Label3)
        Panel3.Controls.Add(Panel6)
        Panel3.Controls.Add(Panel5)
        Panel3.Controls.Add(Panel4)
        Panel3.Location = New Point(0, 70)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(830, 437)
        Panel3.TabIndex = 1
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold)
        Label8.Location = New Point(202, 364)
        Label8.Name = "Label8"
        Label8.Size = New Size(387, 21)
        Label8.TabIndex = 9
        Label8.Text = "A Category to return a borrowed book to its owner." & vbCrLf
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold)
        Label7.Location = New Point(153, 215)
        Label7.Name = "Label7"
        Label7.Size = New Size(544, 42)
        Label7.TabIndex = 8
        Label7.Text = " A Record or Books that contains information about individuals who have " & vbCrLf & "borrowed items."
        Label7.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold)
        Label6.Location = New Point(202, 69)
        Label6.Name = "Label6"
        Label6.Size = New Size(404, 21)
        Label6.TabIndex = 7
        Label6.Text = "A Collection of Books and Periodicals held in a Library."
        Label6.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Arial Rounded MT Bold", 15.75F)
        Label5.Location = New Point(316, 306)
        Label5.Name = "Label5"
        Label5.Size = New Size(176, 24)
        Label5.TabIndex = 6
        Label5.Text = "RETURN BOOK:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial Rounded MT Bold", 15.75F)
        Label4.Location = New Point(316, 163)
        Label4.Name = "Label4"
        Label4.Size = New Size(197, 24)
        Label4.TabIndex = 5
        Label4.Text = "BORROWER LIST:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial Rounded MT Bold", 15.75F)
        Label3.Location = New Point(361, 11)
        Label3.Name = "Label3"
        Label3.Size = New Size(110, 24)
        Label3.TabIndex = 4
        Label3.Text = "LIBRARY:"
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = SystemColors.ActiveCaption
        Panel6.BorderStyle = BorderStyle.FixedSingle
        Panel6.Controls.Add(Button2)
        Panel6.Controls.Add(PictureBox4)
        Panel6.Location = New Point(32, 159)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(114, 120)
        Panel6.TabIndex = 3
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Transparent
        Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), Image)
        Button2.BackgroundImageLayout = ImageLayout.Stretch
        Button2.Cursor = Cursors.Hand
        Button2.FlatStyle = FlatStyle.Popup
        Button2.Font = New Font("Arial Rounded MT Bold", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.White
        Button2.Location = New Point(35, 84)
        Button2.Name = "Button2"
        Button2.Size = New Size(40, 31)
        Button2.TabIndex = 4
        Button2.UseVisualStyleBackColor = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BorderStyle = BorderStyle.FixedSingle
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(1, 3)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(108, 75)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 4
        PictureBox4.TabStop = False
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = SystemColors.ActiveCaption
        Panel5.BorderStyle = BorderStyle.FixedSingle
        Panel5.Controls.Add(Button3)
        Panel5.Controls.Add(PictureBox3)
        Panel5.Location = New Point(32, 306)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(114, 120)
        Panel5.TabIndex = 2
        ' 
        ' Button3
        ' 
        Button3.BackColor = SystemColors.ActiveCaption
        Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), Image)
        Button3.BackgroundImageLayout = ImageLayout.Stretch
        Button3.Cursor = Cursors.Hand
        Button3.FlatStyle = FlatStyle.Popup
        Button3.Font = New Font("Arial Rounded MT Bold", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button3.ForeColor = Color.White
        Button3.Location = New Point(35, 84)
        Button3.Name = "Button3"
        Button3.Size = New Size(40, 31)
        Button3.TabIndex = 4
        Button3.UseVisualStyleBackColor = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BorderStyle = BorderStyle.FixedSingle
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(3, 3)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(108, 75)
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
        Panel4.Location = New Point(32, 11)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(114, 120)
        Panel4.TabIndex = 0
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Transparent
        Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), Image)
        Button1.BackgroundImageLayout = ImageLayout.Stretch
        Button1.Cursor = Cursors.Hand
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Font = New Font("Arial Rounded MT Bold", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.White
        Button1.Location = New Point(35, 84)
        Button1.Name = "Button1"
        Button1.Size = New Size(40, 31)
        Button1.TabIndex = 3
        Button1.UseVisualStyleBackColor = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BorderStyle = BorderStyle.FixedSingle
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(3, 3)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(108, 75)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 1
        PictureBox2.TabStop = False
        ' 
        ' user_dashboard
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(830, 508)
        Controls.Add(Panel1)
        Controls.Add(Panel3)
        MaximizeBox = False
        Name = "user_dashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "user_dashboard"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel6.ResumeLayout(False)
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        Panel5.ResumeLayout(False)
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        Panel4.ResumeLayout(False)
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel6 As Panel
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button4 As Button
End Class
