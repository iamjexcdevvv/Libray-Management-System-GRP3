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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        DateTimePicker1 = New DateTimePicker()
        GroupBox1 = New GroupBox()
        Label8 = New Label()
        TextBox4 = New TextBox()
        Button1 = New Button()
        RadioButton1 = New RadioButton()
        RadioButton2 = New RadioButton()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(243, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(298, 32)
        Label1.TabIndex = 0
        Label1.Text = "Library Registration Form "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(282, 50)
        Label2.Name = "Label2"
        Label2.Size = New Size(224, 15)
        Label2.TabIndex = 1
        Label2.Text = "Fill out the form carefully for registration "
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(12, 98)
        Label3.Name = "Label3"
        Label3.Size = New Size(165, 20)
        Label3.TabIndex = 2
        Label3.Text = "Name of the applicant "
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(12, 121)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(227, 30)
        TextBox1.TabIndex = 3
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(254, 121)
        TextBox2.Multiline = True
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(227, 30)
        TextBox2.TabIndex = 4
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(496, 121)
        TextBox3.Multiline = True
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(227, 30)
        TextBox3.TabIndex = 5
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(12, 154)
        Label4.Name = "Label4"
        Label4.Size = New Size(64, 15)
        Label4.TabIndex = 6
        Label4.Text = "First Name"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(254, 154)
        Label5.Name = "Label5"
        Label5.Size = New Size(82, 15)
        Label5.TabIndex = 7
        Label5.Text = "Middle  Name"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(496, 154)
        Label6.Name = "Label6"
        Label6.Size = New Size(63, 15)
        Label6.TabIndex = 8
        Label6.Text = "Last Name"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(12, 198)
        Label7.Name = "Label7"
        Label7.Size = New Size(72, 20)
        Label7.TabIndex = 9
        Label7.Text = "Birthdate"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(12, 221)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(227, 23)
        DateTimePicker1.TabIndex = 10
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(RadioButton2)
        GroupBox1.Controls.Add(RadioButton1)
        GroupBox1.Location = New Point(371, 221)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(224, 100)
        GroupBox1.TabIndex = 11
        GroupBox1.TabStop = False
        GroupBox1.Text = "Gender"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(12, 347)
        Label8.Name = "Label8"
        Label8.Size = New Size(63, 20)
        Label8.TabIndex = 12
        Label8.Text = "Address"
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(12, 370)
        TextBox4.Multiline = True
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(494, 30)
        TextBox4.TabIndex = 13
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.ForestGreen
        Button1.ForeColor = SystemColors.ActiveCaptionText
        Button1.Location = New Point(623, 369)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 31)
        Button1.TabIndex = 14
        Button1.Text = "Register"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(6, 22)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(51, 19)
        RadioButton1.TabIndex = 15
        RadioButton1.TabStop = True
        RadioButton1.Text = "Male"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(6, 47)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(63, 19)
        RadioButton2.TabIndex = 16
        RadioButton2.TabStop = True
        RadioButton2.Text = "Female"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(Button1)
        Controls.Add(TextBox4)
        Controls.Add(Label8)
        Controls.Add(GroupBox1)
        Controls.Add(DateTimePicker1)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form2"
        Text = "Form2"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
End Class
