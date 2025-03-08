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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(manage_books))
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        Button7 = New Button()
        ComboBox1 = New ComboBox()
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
        Textbox1 = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        TabPage2 = New TabPage()
        Button6 = New Button()
        ComboBox3 = New ComboBox()
        Label18 = New Label()
        ComboBox2 = New ComboBox()
        DateTimePicker2 = New DateTimePicker()
        Label10 = New Label()
        Label11 = New Label()
        Button4 = New Button()
        PictureBox3 = New PictureBox()
        TextBox3 = New TextBox()
        Label12 = New Label()
        NumericUpDown2 = New NumericUpDown()
        Label13 = New Label()
        TextBox6 = New TextBox()
        TextBox7 = New TextBox()
        TextBox8 = New TextBox()
        Label14 = New Label()
        Label15 = New Label()
        Label16 = New Label()
        Label17 = New Label()
        TabPage3 = New TabPage()
        Button9 = New Button()
        DataGridView1 = New DataGridView()
        Panel1 = New Panel()
        PictureBox4 = New PictureBox()
        PictureBox1 = New PictureBox()
        Label6 = New Label()
        ErrorProvider1 = New ErrorProvider(components)
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).BeginInit()
        TabPage2.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumericUpDown2, ComponentModel.ISupportInitialize).BeginInit()
        TabPage3.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TabControl1
        ' 
        TabControl1.CausesValidation = False
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Controls.Add(TabPage3)
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
        TabPage1.Controls.Add(Button7)
        TabPage1.Controls.Add(ComboBox1)
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
        TabPage1.Controls.Add(Textbox1)
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
        ' Button7
        ' 
        Button7.BackColor = Color.Red
        Button7.Cursor = Cursors.Hand
        Button7.FlatStyle = FlatStyle.Popup
        Button7.ForeColor = Color.WhiteSmoke
        Button7.Location = New Point(491, 258)
        Button7.Name = "Button7"
        Button7.Size = New Size(106, 32)
        Button7.TabIndex = 22
        Button7.Text = "Clear Fields"
        Button7.UseVisualStyleBackColor = False
        ' 
        ' ComboBox1
        ' 
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(113, 138)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(141, 22)
        ComboBox1.TabIndex = 21
        ComboBox1.TabStop = False
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.CustomFormat = "dd/MM/yyyy"
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.Location = New Point(441, 138)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(94, 21)
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
        Label8.ForeColor = Color.WhiteSmoke
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
        Button2.Location = New Point(368, 258)
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
        PictureBox2.BackColor = Color.White
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
        ' Textbox1
        ' 
        Textbox1.Location = New Point(113, 38)
        Textbox1.Name = "Textbox1"
        Textbox1.Size = New Size(141, 21)
        Textbox1.TabIndex = 4
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
        TabPage2.BackColor = Color.FromArgb(CByte(67), CByte(85), CByte(244))
        TabPage2.Controls.Add(Button6)
        TabPage2.Controls.Add(ComboBox3)
        TabPage2.Controls.Add(Label18)
        TabPage2.Controls.Add(ComboBox2)
        TabPage2.Controls.Add(DateTimePicker2)
        TabPage2.Controls.Add(Label10)
        TabPage2.Controls.Add(Label11)
        TabPage2.Controls.Add(Button4)
        TabPage2.Controls.Add(PictureBox3)
        TabPage2.Controls.Add(TextBox3)
        TabPage2.Controls.Add(Label12)
        TabPage2.Controls.Add(NumericUpDown2)
        TabPage2.Controls.Add(Label13)
        TabPage2.Controls.Add(TextBox6)
        TabPage2.Controls.Add(TextBox7)
        TabPage2.Controls.Add(TextBox8)
        TabPage2.Controls.Add(Label14)
        TabPage2.Controls.Add(Label15)
        TabPage2.Controls.Add(Label16)
        TabPage2.Controls.Add(Label17)
        TabPage2.Location = New Point(4, 23)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(877, 304)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Edit Book"
        ' 
        ' Button6
        ' 
        Button6.BackColor = Color.FromArgb(CByte(26), CByte(125), CByte(15))
        Button6.Cursor = Cursors.Hand
        Button6.Enabled = False
        Button6.FlatStyle = FlatStyle.Popup
        Button6.ForeColor = Color.WhiteSmoke
        Button6.Location = New Point(361, 258)
        Button6.Name = "Button6"
        Button6.Size = New Size(106, 32)
        Button6.TabIndex = 41
        Button6.Text = "Save Book"
        Button6.UseVisualStyleBackColor = False
        ' 
        ' ComboBox3
        ' 
        ComboBox3.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox3.FormattingEnabled = True
        ComboBox3.Location = New Point(127, 40)
        ComboBox3.Name = "ComboBox3"
        ComboBox3.Size = New Size(141, 22)
        ComboBox3.TabIndex = 40
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Font = New Font("Arial Rounded MT Bold", 12F)
        Label18.ForeColor = Color.WhiteSmoke
        Label18.Location = New Point(46, 40)
        Label18.Name = "Label18"
        Label18.Size = New Size(75, 18)
        Label18.TabIndex = 39
        Label18.Text = "Book ID:"
        ' 
        ' ComboBox2
        ' 
        ComboBox2.Enabled = False
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(127, 185)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(141, 22)
        ComboBox2.TabIndex = 38
        ' 
        ' DateTimePicker2
        ' 
        DateTimePicker2.CustomFormat = "dd/MM/yyyy"
        DateTimePicker2.Enabled = False
        DateTimePicker2.Format = DateTimePickerFormat.Custom
        DateTimePicker2.Location = New Point(447, 161)
        DateTimePicker2.Name = "DateTimePicker2"
        DateTimePicker2.Size = New Size(141, 21)
        DateTimePicker2.TabIndex = 37
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Arial Rounded MT Bold", 12F)
        Label10.ForeColor = Color.WhiteSmoke
        Label10.Location = New Point(311, 161)
        Label10.Name = "Label10"
        Label10.Size = New Size(130, 18)
        Label10.TabIndex = 36
        Label10.Text = "Date Recieved:"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Arial Rounded MT Bold", 12F)
        Label11.Location = New Point(745, 44)
        Label11.Name = "Label11"
        Label11.Size = New Size(101, 18)
        Label11.TabIndex = 35
        Label11.Text = "Book Cover"
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.Transparent
        Button4.Cursor = Cursors.Hand
        Button4.Enabled = False
        Button4.Image = CType(resources.GetObject("Button4.Image"), Image)
        Button4.ImageAlign = ContentAlignment.MiddleLeft
        Button4.Location = New Point(745, 223)
        Button4.Name = "Button4"
        Button4.Size = New Size(104, 37)
        Button4.TabIndex = 34
        Button4.Text = "Select File"
        Button4.TextAlign = ContentAlignment.MiddleRight
        Button4.UseVisualStyleBackColor = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.White
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(731, 74)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(130, 143)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 33
        PictureBox3.TabStop = False
        ' 
        ' TextBox3
        ' 
        TextBox3.Enabled = False
        TextBox3.Location = New Point(447, 111)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(141, 21)
        TextBox3.TabIndex = 32
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Arial Rounded MT Bold", 12F)
        Label12.ForeColor = Color.WhiteSmoke
        Label12.Location = New Point(353, 111)
        Label12.Name = "Label12"
        Label12.Size = New Size(88, 18)
        Label12.TabIndex = 31
        Label12.Text = "Publisher:"
        ' 
        ' NumericUpDown2
        ' 
        NumericUpDown2.Enabled = False
        NumericUpDown2.Location = New Point(447, 62)
        NumericUpDown2.Name = "NumericUpDown2"
        NumericUpDown2.Size = New Size(94, 21)
        NumericUpDown2.TabIndex = 30
        NumericUpDown2.ThousandsSeparator = True
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Arial Rounded MT Bold", 12F)
        Label13.ForeColor = Color.WhiteSmoke
        Label13.Location = New Point(373, 62)
        Label13.Name = "Label13"
        Label13.Size = New Size(68, 18)
        Label13.TabIndex = 29
        Label13.Text = "Copies:"
        ' 
        ' TextBox6
        ' 
        TextBox6.Enabled = False
        TextBox6.Location = New Point(127, 235)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(141, 21)
        TextBox6.TabIndex = 28
        ' 
        ' TextBox7
        ' 
        TextBox7.Enabled = False
        TextBox7.Location = New Point(127, 134)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(141, 21)
        TextBox7.TabIndex = 27
        ' 
        ' TextBox8
        ' 
        TextBox8.Enabled = False
        TextBox8.Location = New Point(127, 85)
        TextBox8.Name = "TextBox8"
        TextBox8.Size = New Size(141, 21)
        TextBox8.TabIndex = 26
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Arial Rounded MT Bold", 12F)
        Label14.ForeColor = Color.WhiteSmoke
        Label14.Location = New Point(58, 185)
        Label14.Name = "Label14"
        Label14.Size = New Size(63, 18)
        Label14.TabIndex = 25
        Label14.Text = "Genre:"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Arial Rounded MT Bold", 12F)
        Label15.ForeColor = Color.WhiteSmoke
        Label15.Location = New Point(53, 235)
        Label15.Name = "Label15"
        Label15.Size = New Size(68, 18)
        Label15.TabIndex = 24
        Label15.Text = "Author:"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Arial Rounded MT Bold", 12F)
        Label16.ForeColor = Color.WhiteSmoke
        Label16.Location = New Point(74, 134)
        Label16.Name = "Label16"
        Label16.Size = New Size(47, 18)
        Label16.TabIndex = 23
        Label16.Text = "Title:"
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Arial Rounded MT Bold", 12F)
        Label17.ForeColor = Color.WhiteSmoke
        Label17.Location = New Point(23, 85)
        Label17.Name = "Label17"
        Label17.Size = New Size(98, 18)
        Label17.TabIndex = 22
        Label17.Text = "Book ISBN:"
        ' 
        ' TabPage3
        ' 
        TabPage3.Controls.Add(Button9)
        TabPage3.Controls.Add(DataGridView1)
        TabPage3.Location = New Point(4, 23)
        TabPage3.Name = "TabPage3"
        TabPage3.Padding = New Padding(3)
        TabPage3.Size = New Size(877, 304)
        TabPage3.TabIndex = 2
        TabPage3.Text = "Books"
        TabPage3.UseVisualStyleBackColor = True
        ' 
        ' Button9
        ' 
        Button9.BackColor = Color.Red
        Button9.Cursor = Cursors.Hand
        Button9.FlatStyle = FlatStyle.Popup
        Button9.ForeColor = Color.WhiteSmoke
        Button9.Location = New Point(396, 258)
        Button9.Name = "Button9"
        Button9.Size = New Size(106, 32)
        Button9.TabIndex = 43
        Button9.Text = "Delete Book"
        Button9.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.AllowUserToResizeColumns = False
        DataGridView1.AllowUserToResizeRows = False
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(28, 18)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(816, 223)
        DataGridView1.TabIndex = 0
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(238), CByte(115), CByte(12))
        Panel1.Controls.Add(PictureBox4)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(Label6)
        Panel1.Location = New Point(-1, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(885, 59)
        Panel1.TabIndex = 1
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Cursor = Cursors.Hand
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(822, 12)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(49, 39)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 23
        PictureBox4.TabStop = False
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
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' manage_books
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(882, 382)
        Controls.Add(Panel1)
        Controls.Add(TabControl1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "manage_books"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Manage Books"
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).EndInit()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(NumericUpDown2, ComponentModel.ISupportInitialize).EndInit()
        TabPage3.ResumeLayout(False)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Textbox1 As TextBox
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
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents NumericUpDown2 As NumericUpDown
    Friend WithEvents Label13 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Button6 As Button
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents Button9 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents PictureBox4 As PictureBox
End Class
