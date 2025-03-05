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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        ComboBox1 = New ComboBox()
        ComboBox2 = New ComboBox()
        ComboBox3 = New ComboBox()
        GroupBox1 = New GroupBox()
        CheckBox1 = New CheckBox()
        CheckBox2 = New CheckBox()
        TextBox4 = New TextBox()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Symbol", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(256, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(270, 30)
        Label1.TabIndex = 0
        Label1.Text = "Library Registration Form"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(282, 48)
        Label2.Name = "Label2"
        Label2.Size = New Size(221, 15)
        Label2.TabIndex = 1
        Label2.Text = "Fill out the form carefully for registration"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(26, 119)
        Label3.Name = "Label3"
        Label3.Size = New Size(125, 15)
        Label3.TabIndex = 2
        Label3.Text = "Name of the applicant"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(26, 185)
        Label4.Name = "Label4"
        Label4.Size = New Size(28, 15)
        Label4.TabIndex = 3
        Label4.Text = "Age"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(26, 348)
        Label5.Name = "Label5"
        Label5.Size = New Size(49, 15)
        Label5.TabIndex = 4
        Label5.Text = "Address"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(26, 137)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(184, 23)
        TextBox1.TabIndex = 5
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(294, 137)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(184, 23)
        TextBox2.TabIndex = 6
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(571, 137)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(184, 23)
        TextBox3.TabIndex = 7
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(26, 203)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(91, 23)
        ComboBox1.TabIndex = 8
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(123, 203)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(91, 23)
        ComboBox2.TabIndex = 9
        ' 
        ' ComboBox3
        ' 
        ComboBox3.FormattingEnabled = True
        ComboBox3.Location = New Point(220, 203)
        ComboBox3.Name = "ComboBox3"
        ComboBox3.Size = New Size(91, 23)
        ComboBox3.TabIndex = 10
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(CheckBox2)
        GroupBox1.Controls.Add(CheckBox1)
        GroupBox1.Location = New Point(372, 203)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(200, 100)
        GroupBox1.TabIndex = 11
        GroupBox1.TabStop = False
        GroupBox1.Text = "Gender"
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(9, 22)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(52, 19)
        CheckBox1.TabIndex = 0
        CheckBox1.Text = "Male"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.Location = New Point(8, 48)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(64, 19)
        CheckBox2.TabIndex = 1
        CheckBox2.Text = "Female"
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(26, 366)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(546, 23)
        TextBox4.TabIndex = 12
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources._1lilb
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(TextBox4)
        Controls.Add(GroupBox1)
        Controls.Add(ComboBox3)
        Controls.Add(ComboBox2)
        Controls.Add(ComboBox1)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label5)
        Controls.Add(Label4)
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
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents TextBox4 As TextBox
End Class
