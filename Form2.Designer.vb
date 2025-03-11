<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Label2 = New Label()
        TextBox1 = New TextBox()
        TextBox3 = New TextBox()
        Label4 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Button1 = New Button()
        TextBox6 = New TextBox()
        Label1 = New Label()
        TextBox7 = New TextBox()
        ErrorProvider1 = New ErrorProvider(components)
        TextBox2 = New TextBox()
        Label3 = New Label()
        Label5 = New Label()
        Button2 = New Button()
        Label8 = New Label()
        Label9 = New Label()
        TextBox4 = New TextBox()
        RadioButton1 = New RadioButton()
        RadioButton2 = New RadioButton()
        Label10 = New Label()
        Label14 = New Label()
        Button3 = New Button()
        Label11 = New Label()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Tomato
        Label2.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(180, 68)
        Label2.Name = "Label2"
        Label2.Size = New Size(452, 18)
        Label2.TabIndex = 1
        Label2.Text = "FILL OUT THE FORM CAREFULLY FOR REGISTRATION !"
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.DarkSalmon
        TextBox1.Font = New Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(63, 136)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(227, 30)
        TextBox1.TabIndex = 3
        ' 
        ' TextBox3
        ' 
        TextBox3.BackColor = Color.DarkSalmon
        TextBox3.Font = New Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox3.Location = New Point(325, 136)
        TextBox3.Multiline = True
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(227, 30)
        TextBox3.TabIndex = 5
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.DarkSeaGreen
        Label4.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(63, 115)
        Label4.Name = "Label4"
        Label4.Size = New Size(94, 18)
        Label4.TabIndex = 6
        Label4.Text = "First Name"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.DarkSeaGreen
        Label6.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(325, 115)
        Label6.Name = "Label6"
        Label6.Size = New Size(93, 18)
        Label6.TabIndex = 8
        Label6.Text = "Last Name"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.MediumAquamarine
        Label7.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(325, 252)
        Label7.Name = "Label7"
        Label7.Size = New Size(118, 18)
        Label7.TabIndex = 9
        Label7.Text = "School Name:"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.DarkCyan
        Button1.Cursor = Cursors.Hand
        Button1.Font = New Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = SystemColors.ActiveCaptionText
        Button1.Location = New Point(325, 340)
        Button1.Name = "Button1"
        Button1.Size = New Size(163, 34)
        Button1.TabIndex = 14
        Button1.Text = "Register"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' TextBox6
        ' 
        TextBox6.BackColor = Color.MediumAquamarine
        TextBox6.Font = New Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox6.Location = New Point(325, 275)
        TextBox6.Margin = New Padding(2)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(227, 21)
        TextBox6.TabIndex = 15
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.MediumAquamarine
        Label1.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(63, 252)
        Label1.Name = "Label1"
        Label1.Size = New Size(128, 18)
        Label1.TabIndex = 19
        Label1.Text = "Email Account:"
        ' 
        ' TextBox7
        ' 
        TextBox7.BackColor = Color.MediumAquamarine
        TextBox7.Font = New Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox7.Location = New Point(63, 275)
        TextBox7.Margin = New Padding(2)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(227, 21)
        TextBox7.TabIndex = 20
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = Color.MediumAquamarine
        TextBox2.Font = New Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox2.Location = New Point(325, 208)
        TextBox2.Margin = New Padding(2)
        TextBox2.Name = "TextBox2"
        TextBox2.PasswordChar = "*"c
        TextBox2.Size = New Size(227, 21)
        TextBox2.TabIndex = 23
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.MediumAquamarine
        Label3.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(325, 188)
        Label3.Name = "Label3"
        Label3.Size = New Size(92, 18)
        Label3.TabIndex = 24
        Label3.Text = "Password:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.MediumAquamarine
        Label5.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(588, 115)
        Label5.Name = "Label5"
        Label5.Size = New Size(73, 18)
        Label5.TabIndex = 25
        Label5.Text = "Gender:"
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.DarkCyan
        Button2.Cursor = Cursors.Hand
        Button2.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = SystemColors.ActiveCaptionText
        Button2.Location = New Point(666, 377)
        Button2.Name = "Button2"
        Button2.Size = New Size(79, 32)
        Button2.TabIndex = 26
        Button2.Text = "Login"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(620, 360)
        Label8.Name = "Label8"
        Label8.Size = New Size(157, 14)
        Label8.TabIndex = 27
        Label8.Text = "Already have an account?"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.MediumAquamarine
        Label9.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(63, 188)
        Label9.Name = "Label9"
        Label9.Size = New Size(95, 18)
        Label9.TabIndex = 29
        Label9.Text = "Username:"
        ' 
        ' TextBox4
        ' 
        TextBox4.BackColor = Color.MediumAquamarine
        TextBox4.Font = New Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox4.Location = New Point(63, 208)
        TextBox4.Margin = New Padding(2)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(227, 21)
        TextBox4.TabIndex = 28
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.BackColor = Color.MediumAquamarine
        RadioButton1.Checked = True
        RadioButton1.Cursor = Cursors.Hand
        RadioButton1.FlatStyle = FlatStyle.System
        RadioButton1.Font = New Font("Arial Rounded MT Bold", 9.75F)
        RadioButton1.ForeColor = Color.Black
        RadioButton1.Location = New Point(588, 146)
        RadioButton1.Margin = New Padding(2)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(79, 20)
        RadioButton1.TabIndex = 21
        RadioButton1.TabStop = True
        RadioButton1.Text = "Female"
        RadioButton1.UseVisualStyleBackColor = False
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.BackColor = Color.MediumAquamarine
        RadioButton2.Cursor = Cursors.Hand
        RadioButton2.FlatStyle = FlatStyle.System
        RadioButton2.Font = New Font("Arial Rounded MT Bold", 9.75F)
        RadioButton2.ForeColor = Color.Black
        RadioButton2.Location = New Point(672, 146)
        RadioButton2.Margin = New Padding(2)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(62, 20)
        RadioButton2.TabIndex = 22
        RadioButton2.Text = "Male"
        RadioButton2.UseVisualStyleBackColor = False
        ' 
        ' Label10
        ' 
        Label10.BackColor = Color.OrangeRed
        Label10.Font = New Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(0, -1)
        Label10.Name = "Label10"
        Label10.Size = New Size(800, 49)
        Label10.TabIndex = 30
        Label10.Text = "Library Registration Form"
        Label10.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(588, 233)
        Label14.Name = "Label14"
        Label14.Size = New Size(83, 15)
        Label14.TabIndex = 33
        Label14.Text = "No file chosen"
        Label14.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Transparent
        Button3.Cursor = Cursors.Hand
        Button3.Image = CType(resources.GetObject("Button3.Image"), Image)
        Button3.ImageAlign = ContentAlignment.MiddleLeft
        Button3.Location = New Point(588, 252)
        Button3.Name = "Button3"
        Button3.Size = New Size(91, 37)
        Button3.TabIndex = 31
        Button3.Text = "Browse..."
        Button3.TextAlign = ContentAlignment.MiddleRight
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.BackColor = Color.MediumAquamarine
        Label11.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(588, 207)
        Label11.Name = "Label11"
        Label11.Size = New Size(184, 18)
        Label11.TabIndex = 34
        Label11.Text = "Please select a photo:"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(843, 421)
        Controls.Add(Label11)
        Controls.Add(Label14)
        Controls.Add(Button3)
        Controls.Add(Label10)
        Controls.Add(RadioButton2)
        Controls.Add(RadioButton1)
        Controls.Add(Label9)
        Controls.Add(TextBox4)
        Controls.Add(Label8)
        Controls.Add(Button2)
        Controls.Add(Label5)
        Controls.Add(Label3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox7)
        Controls.Add(Label1)
        Controls.Add(TextBox6)
        Controls.Add(Button1)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox1)
        Controls.Add(Label2)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "Form2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Registration"
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents Label8 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents Label10 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Label11 As Label
End Class
