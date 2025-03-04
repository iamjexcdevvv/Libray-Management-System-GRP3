<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class manage_books
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(manage_books))
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        Button3 = New Button()
        DateTimePicker1 = New DateTimePicker()
        Label9 = New Label()
        Label8 = New Label()
        Button2 = New Button()
        Button1 = New Button()
        PictureBox2 = New PictureBox()
        TextBox5 = New TextBox()
        Label7 = New Label()
        NumericUpDown1 = New NumericUpDown()
        Label5 = New Label()
        TextBox4 = New TextBox()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        TabPage2 = New TabPage()
        Panel1 = New Panel()
        PictureBox1 = New PictureBox()
        Label6 = New Label()
        ComboBox1 = New ComboBox()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Cursor = Cursors.Hand
        TabControl1.Font = New Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TabControl1.Location = New Point(-1, 57)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(885, 331)
        TabControl1.TabIndex = 0
        ' 
        ' TabPage1
        ' 
        TabPage1.BackColor = Color.FromArgb(CByte(67), CByte(85), CByte(244))
        TabPage1.Controls.Add(ComboBox1)
        TabPage1.Controls.Add(Button3)
        TabPage1.Controls.Add(DateTimePicker1)
        TabPage1.Controls.Add(Label9)
        TabPage1.Controls.Add(Label8)
        TabPage1.Controls.Add(Button2)
        TabPage1.Controls.Add(Button1)
        TabPage1.Controls.Add(PictureBox2)
        TabPage1.Controls.Add(TextBox5)
        TabPage1.Controls.Add(Label7)
        TabPage1.Controls.Add(NumericUpDown1)
        TabPage1.Controls.Add(Label5)
        TabPage1.Controls.Add(TextBox4)
        TabPage1.Controls.Add(TextBox2)
        TabPage1.Controls.Add(TextBox1)
        TabPage1.Controls.Add(Label4)
        TabPage1.Controls.Add(Label3)
        TabPage1.Controls.Add(Label2)
        TabPage1.Controls.Add(Label1)
        TabPage1.Font = New Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TabPage1.Location = New Point(4, 23)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(877, 304)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Add Book"
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Red
        Button3.Cursor = Cursors.Hand
        Button3.FlatStyle = FlatStyle.Popup
        Button3.ForeColor = Color.WhiteSmoke
        Button3.Location = New Point(493, 244)
        Button3.Name = "Button3"
        Button3.Size = New Size(106, 32)
        Button3.TabIndex = 20
        Button3.Text = "Back"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(441, 136)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(230, 21)
        DateTimePicker1.TabIndex = 19
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Arial Rounded MT Bold", 12F)
        Label9.ForeColor = Color.WhiteSmoke
        Label9.Location = New Point(305, 136)
        Label9.Name = "Label9"
        Label9.Size = New Size(130, 18)
        Label9.TabIndex = 18
        Label9.Text = "Date Recieved:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Arial Rounded MT Bold", 12F)
        Label8.Location = New Point(739, 19)
        Label8.Name = "Label8"
        Label8.Size = New Size(101, 18)
        Label8.TabIndex = 17
        Label8.Text = "Book Cover"
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(26), CByte(125), CByte(15))
        Button2.Cursor = Cursors.Hand
        Button2.FlatStyle = FlatStyle.Popup
        Button2.ForeColor = Color.WhiteSmoke
        Button2.Location = New Point(372, 244)
        Button2.Name = "Button2"
        Button2.Size = New Size(106, 32)
        Button2.TabIndex = 15
        Button2.Text = "Add Book"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Transparent
        Button1.Cursor = Cursors.Hand
        Button1.Image = CType(resources.GetObject("Button1.Image"), Image)
        Button1.ImageAlign = ContentAlignment.MiddleLeft
        Button1.Location = New Point(739, 198)
        Button1.Name = "Button1"
        Button1.Size = New Size(104, 37)
        Button1.TabIndex = 14
        Button1.Text = "Select File"
        Button1.TextAlign = ContentAlignment.MiddleRight
        Button1.UseVisualStyleBackColor = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(725, 49)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(130, 143)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 13
        PictureBox2.TabStop = False
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(441, 86)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(141, 21)
        TextBox5.TabIndex = 12
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Arial Rounded MT Bold", 12F)
        Label7.ForeColor = Color.WhiteSmoke
        Label7.Location = New Point(347, 86)
        Label7.Name = "Label7"
        Label7.Size = New Size(88, 18)
        Label7.TabIndex = 11
        Label7.Text = "Publisher:"
        ' 
        ' NumericUpDown1
        ' 
        NumericUpDown1.Location = New Point(441, 37)
        NumericUpDown1.Name = "NumericUpDown1"
        NumericUpDown1.Size = New Size(94, 21)
        NumericUpDown1.TabIndex = 10
        NumericUpDown1.ThousandsSeparator = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Arial Rounded MT Bold", 12F)
        Label5.ForeColor = Color.WhiteSmoke
        Label5.Location = New Point(354, 37)
        Label5.Name = "Label5"
        Label5.Size = New Size(81, 18)
        Label5.TabIndex = 8
        Label5.Text = "Quantity:"
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(113, 188)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(141, 21)
        TextBox4.TabIndex = 7
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(113, 87)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(141, 21)
        TextBox2.TabIndex = 5
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(113, 38)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(141, 21)
        TextBox1.TabIndex = 4
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial Rounded MT Bold", 12F)
        Label4.ForeColor = Color.WhiteSmoke
        Label4.Location = New Point(44, 138)
        Label4.Name = "Label4"
        Label4.Size = New Size(63, 18)
        Label4.TabIndex = 3
        Label4.Text = "Genre:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial Rounded MT Bold", 12F)
        Label3.ForeColor = Color.WhiteSmoke
        Label3.Location = New Point(39, 188)
        Label3.Name = "Label3"
        Label3.Size = New Size(68, 18)
        Label3.TabIndex = 2
        Label3.Text = "Author:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial Rounded MT Bold", 12F)
        Label2.ForeColor = Color.WhiteSmoke
        Label2.Location = New Point(60, 87)
        Label2.Name = "Label2"
        Label2.Size = New Size(47, 18)
        Label2.TabIndex = 1
        Label2.Text = "Title:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Rounded MT Bold", 12F)
        Label1.ForeColor = Color.WhiteSmoke
        Label1.Location = New Point(9, 38)
        Label1.Name = "Label1"
        Label1.Size = New Size(98, 18)
        Label1.TabIndex = 0
        Label1.Text = "Book ISBN:"
        ' 
        ' TabPage2
        ' 
        TabPage2.Location = New Point(4, 23)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(877, 304)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Edit Book"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(238), CByte(115), CByte(12))
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(Label6)
        Panel1.Location = New Point(-1, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(885, 59)
        Panel1.TabIndex = 1
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(13, 5)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(61, 46)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.FromArgb(CByte(36), CByte(45), CByte(88))
        Label6.Location = New Point(89, 18)
        Label6.Name = "Label6"
        Label6.Size = New Size(193, 24)
        Label6.TabIndex = 0
        Label6.Text = "Admin Dashboard"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(113, 138)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(141, 22)
        ComboBox1.TabIndex = 21
        ' 
        ' manage_books
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(882, 382)
        Controls.Add(Panel1)
        Controls.Add(TabControl1)
        MaximizeBox = False
        Name = "manage_books"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Manage Books"
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents ComboBox1 As ComboBox
End Class
