<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class manage_students
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(manage_students))
        Panel1 = New Panel()
        PictureBox4 = New PictureBox()
        Label6 = New Label()
        PictureBox1 = New PictureBox()
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        Button1 = New Button()
        TextBox4 = New TextBox()
        Label5 = New Label()
        Button2 = New Button()
        ComboBox1 = New ComboBox()
        Label4 = New Label()
        TextBox3 = New TextBox()
        Label3 = New Label()
        TextBox2 = New TextBox()
        Label2 = New Label()
        Textbox1 = New TextBox()
        Label1 = New Label()
        PictureBox2 = New PictureBox()
        TabPage2 = New TabPage()
        Label7 = New Label()
        Button3 = New Button()
        Button4 = New Button()
        ComboBox2 = New ComboBox()
        Label8 = New Label()
        TextBox6 = New TextBox()
        Label9 = New Label()
        TextBox7 = New TextBox()
        Label10 = New Label()
        TextBox8 = New TextBox()
        Label11 = New Label()
        PictureBox3 = New PictureBox()
        TabPage3 = New TabPage()
        ErrorProvider1 = New ErrorProvider(components)
        ComboBox3 = New ComboBox()
        Panel1.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        TabPage2.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(238), CByte(115), CByte(12))
        Panel1.Controls.Add(PictureBox4)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(883, 85)
        Panel1.TabIndex = 2
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Cursor = Cursors.Hand
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(821, 19)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(49, 39)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 23
        PictureBox4.TabStop = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.FromArgb(CByte(36), CByte(45), CByte(88))
        Label6.Location = New Point(79, 27)
        Label6.Name = "Label6"
        Label6.Size = New Size(193, 24)
        Label6.TabIndex = 0
        Label6.Text = "Admin Dashboard"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(12, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(61, 46)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' TabControl1
        ' 
        TabControl1.CausesValidation = False
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Controls.Add(TabPage3)
        TabControl1.Cursor = Cursors.Hand
        TabControl1.Font = New Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TabControl1.Location = New Point(0, 64)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(883, 387)
        TabControl1.TabIndex = 3
        ' 
        ' TabPage1
        ' 
        TabPage1.BackColor = Color.FromArgb(CByte(67), CByte(85), CByte(244))
        TabPage1.Controls.Add(Button1)
        TabPage1.Controls.Add(TextBox4)
        TabPage1.Controls.Add(Label5)
        TabPage1.Controls.Add(Button2)
        TabPage1.Controls.Add(ComboBox1)
        TabPage1.Controls.Add(Label4)
        TabPage1.Controls.Add(TextBox3)
        TabPage1.Controls.Add(Label3)
        TabPage1.Controls.Add(TextBox2)
        TabPage1.Controls.Add(Label2)
        TabPage1.Controls.Add(Textbox1)
        TabPage1.Controls.Add(Label1)
        TabPage1.Controls.Add(PictureBox2)
        TabPage1.Location = New Point(4, 23)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(875, 360)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Add User"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Transparent
        Button1.Cursor = Cursors.Hand
        Button1.Image = CType(resources.GetObject("Button1.Image"), Image)
        Button1.ImageAlign = ContentAlignment.MiddleLeft
        Button1.Location = New Point(563, 292)
        Button1.Name = "Button1"
        Button1.Size = New Size(104, 37)
        Button1.TabIndex = 19
        Button1.Text = "Select File"
        Button1.TextAlign = ContentAlignment.MiddleRight
        Button1.UseVisualStyleBackColor = False
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(259, 233)
        TextBox4.Name = "TextBox4"
        TextBox4.PasswordChar = "*"c
        TextBox4.Size = New Size(160, 21)
        TextBox4.TabIndex = 18
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Arial Rounded MT Bold", 12F)
        Label5.ForeColor = Color.WhiteSmoke
        Label5.Location = New Point(161, 232)
        Label5.Name = "Label5"
        Label5.Size = New Size(92, 18)
        Label5.TabIndex = 17
        Label5.Text = "Password:"
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(26), CByte(125), CByte(15))
        Button2.Cursor = Cursors.Hand
        Button2.FlatStyle = FlatStyle.Popup
        Button2.ForeColor = Color.WhiteSmoke
        Button2.Location = New Point(287, 283)
        Button2.Name = "Button2"
        Button2.Size = New Size(106, 32)
        Button2.TabIndex = 16
        Button2.Text = "Add User"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' ComboBox1
        ' 
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(259, 184)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(160, 22)
        ComboBox1.TabIndex = 11
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial Rounded MT Bold", 12F)
        Label4.ForeColor = Color.WhiteSmoke
        Label4.Location = New Point(204, 184)
        Label4.Name = "Label4"
        Label4.Size = New Size(49, 18)
        Label4.TabIndex = 10
        Label4.Text = "Role:"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(259, 134)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(160, 21)
        TextBox3.TabIndex = 9
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial Rounded MT Bold", 12F)
        Label3.ForeColor = Color.WhiteSmoke
        Label3.Location = New Point(156, 134)
        Label3.Name = "Label3"
        Label3.Size = New Size(98, 18)
        Label3.TabIndex = 8
        Label3.Text = "Last Name:"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(259, 84)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(160, 21)
        TextBox2.TabIndex = 7
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial Rounded MT Bold", 12F)
        Label2.ForeColor = Color.WhiteSmoke
        Label2.Location = New Point(156, 84)
        Label2.Name = "Label2"
        Label2.Size = New Size(99, 18)
        Label2.TabIndex = 6
        Label2.Text = "First Name:"
        ' 
        ' Textbox1
        ' 
        Textbox1.Location = New Point(259, 37)
        Textbox1.Name = "Textbox1"
        Textbox1.Size = New Size(160, 21)
        Textbox1.TabIndex = 5
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Rounded MT Bold", 12F)
        Label1.ForeColor = Color.WhiteSmoke
        Label1.Location = New Point(156, 37)
        Label1.Name = "Label1"
        Label1.Size = New Size(101, 18)
        Label1.TabIndex = 1
        Label1.Text = "User Name:"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.White
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(490, 22)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(234, 255)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 0
        PictureBox2.TabStop = False
        ' 
        ' TabPage2
        ' 
        TabPage2.BackColor = Color.FromArgb(CByte(67), CByte(85), CByte(244))
        TabPage2.Controls.Add(ComboBox3)
        TabPage2.Controls.Add(Label7)
        TabPage2.Controls.Add(Button3)
        TabPage2.Controls.Add(Button4)
        TabPage2.Controls.Add(ComboBox2)
        TabPage2.Controls.Add(Label8)
        TabPage2.Controls.Add(TextBox6)
        TabPage2.Controls.Add(Label9)
        TabPage2.Controls.Add(TextBox7)
        TabPage2.Controls.Add(Label10)
        TabPage2.Controls.Add(TextBox8)
        TabPage2.Controls.Add(Label11)
        TabPage2.Controls.Add(PictureBox3)
        TabPage2.Location = New Point(4, 23)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(875, 360)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Edit User"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Arial Rounded MT Bold", 12F)
        Label7.ForeColor = Color.WhiteSmoke
        Label7.Location = New Point(182, 36)
        Label7.Name = "Label7"
        Label7.Size = New Size(72, 18)
        Label7.TabIndex = 33
        Label7.Text = "User ID:"
        Label7.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Transparent
        Button3.Cursor = Cursors.Hand
        Button3.Enabled = False
        Button3.Image = CType(resources.GetObject("Button3.Image"), Image)
        Button3.ImageAlign = ContentAlignment.MiddleLeft
        Button3.Location = New Point(560, 297)
        Button3.Name = "Button3"
        Button3.Size = New Size(104, 37)
        Button3.TabIndex = 32
        Button3.Text = "Select File"
        Button3.TextAlign = ContentAlignment.MiddleRight
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.FromArgb(CByte(26), CByte(125), CByte(15))
        Button4.Cursor = Cursors.Hand
        Button4.Enabled = False
        Button4.FlatStyle = FlatStyle.Popup
        Button4.ForeColor = Color.WhiteSmoke
        Button4.Location = New Point(284, 288)
        Button4.Name = "Button4"
        Button4.Size = New Size(106, 32)
        Button4.TabIndex = 29
        Button4.Text = "Save Data"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' ComboBox2
        ' 
        ComboBox2.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox2.Enabled = False
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(259, 229)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(160, 22)
        ComboBox2.TabIndex = 28
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Arial Rounded MT Bold", 12F)
        Label8.ForeColor = Color.WhiteSmoke
        Label8.Location = New Point(204, 229)
        Label8.Name = "Label8"
        Label8.Size = New Size(49, 18)
        Label8.TabIndex = 27
        Label8.Text = "Role:"
        ' 
        ' TextBox6
        ' 
        TextBox6.Enabled = False
        TextBox6.Location = New Point(259, 179)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(160, 21)
        TextBox6.TabIndex = 26
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Arial Rounded MT Bold", 12F)
        Label9.ForeColor = Color.WhiteSmoke
        Label9.Location = New Point(156, 179)
        Label9.Name = "Label9"
        Label9.Size = New Size(98, 18)
        Label9.TabIndex = 25
        Label9.Text = "Last Name:"
        ' 
        ' TextBox7
        ' 
        TextBox7.Enabled = False
        TextBox7.Location = New Point(259, 129)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(160, 21)
        TextBox7.TabIndex = 24
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Arial Rounded MT Bold", 12F)
        Label10.ForeColor = Color.WhiteSmoke
        Label10.Location = New Point(156, 129)
        Label10.Name = "Label10"
        Label10.Size = New Size(99, 18)
        Label10.TabIndex = 23
        Label10.Text = "First Name:"
        ' 
        ' TextBox8
        ' 
        TextBox8.Enabled = False
        TextBox8.Location = New Point(259, 82)
        TextBox8.Name = "TextBox8"
        TextBox8.Size = New Size(160, 21)
        TextBox8.TabIndex = 22
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Arial Rounded MT Bold", 12F)
        Label11.ForeColor = Color.WhiteSmoke
        Label11.Location = New Point(156, 82)
        Label11.Name = "Label11"
        Label11.Size = New Size(101, 18)
        Label11.TabIndex = 21
        Label11.Text = "User Name:"
        Label11.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.White
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(487, 27)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(234, 255)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 20
        PictureBox3.TabStop = False
        ' 
        ' TabPage3
        ' 
        TabPage3.Location = New Point(4, 23)
        TabPage3.Name = "TabPage3"
        TabPage3.Padding = New Padding(3)
        TabPage3.Size = New Size(875, 360)
        TabPage3.TabIndex = 2
        TabPage3.Text = "Users"
        TabPage3.UseVisualStyleBackColor = True
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' ComboBox3
        ' 
        ComboBox3.FormattingEnabled = True
        ComboBox3.Location = New Point(259, 37)
        ComboBox3.Name = "ComboBox3"
        ComboBox3.Size = New Size(160, 22)
        ComboBox3.TabIndex = 34
        ' 
        ' manage_students
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(877, 442)
        Controls.Add(TabControl1)
        Controls.Add(Panel1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "manage_students"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Student Management"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Textbox1 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents Label7 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents ComboBox3 As ComboBox
End Class
