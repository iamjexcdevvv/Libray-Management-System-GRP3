<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class book_issuance
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(book_issuance))
        Panel1 = New Panel()
        PictureBox4 = New PictureBox()
        PictureBox1 = New PictureBox()
        Label6 = New Label()
        Panel2 = New Panel()
        Label8 = New Label()
        Label7 = New Label()
        DateTimePicker2 = New DateTimePicker()
        Label5 = New Label()
        DateTimePicker1 = New DateTimePicker()
        Label3 = New Label()
        TextBox2 = New TextBox()
        ComboBox2 = New ComboBox()
        Label4 = New Label()
        Label2 = New Label()
        TextBox1 = New TextBox()
        ComboBox1 = New ComboBox()
        Label1 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        ErrorProvider1 = New ErrorProvider(components)
        Panel1.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(238), CByte(115), CByte(12))
        Panel1.Controls.Add(PictureBox4)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(Label6)
        Panel1.Location = New Point(-2, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(845, 62)
        Panel1.TabIndex = 2
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Cursor = Cursors.Hand
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(780, 12)
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
        ' Panel2
        ' 
        Panel2.BackColor = Color.Transparent
        Panel2.BorderStyle = BorderStyle.Fixed3D
        Panel2.Controls.Add(Label8)
        Panel2.Controls.Add(Label7)
        Panel2.Controls.Add(DateTimePicker2)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(DateTimePicker1)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(TextBox2)
        Panel2.Controls.Add(ComboBox2)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(TextBox1)
        Panel2.Controls.Add(ComboBox1)
        Panel2.Controls.Add(Label1)
        Panel2.Location = New Point(12, 139)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(819, 164)
        Panel2.TabIndex = 3
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.WhiteSmoke
        Label8.Location = New Point(692, 64)
        Label8.Name = "Label8"
        Label8.Size = New Size(71, 15)
        Label8.TabIndex = 12
        Label8.Text = "Due Date:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.WhiteSmoke
        Label7.Location = New Point(583, 64)
        Label7.Name = "Label7"
        Label7.Size = New Size(79, 15)
        Label7.TabIndex = 11
        Label7.Text = "Issue Date:"
        ' 
        ' DateTimePicker2
        ' 
        DateTimePicker2.CustomFormat = "dd/MM/yyyy"
        DateTimePicker2.Format = DateTimePickerFormat.Custom
        DateTimePicker2.Location = New Point(692, 82)
        DateTimePicker2.Name = "DateTimePicker2"
        DateTimePicker2.Size = New Size(103, 23)
        DateTimePicker2.TabIndex = 10
        ' 
        ' Label5
        ' 
        Label5.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.WhiteSmoke
        Label5.Location = New Point(-2, 21)
        Label5.Name = "Label5"
        Label5.Size = New Size(819, 23)
        Label5.TabIndex = 9
        Label5.Text = "Book Issue Details"
        Label5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.CustomFormat = "dd/MM/yyyy"
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.Location = New Point(583, 82)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(103, 23)
        DateTimePicker1.TabIndex = 8
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.WhiteSmoke
        Label3.Location = New Point(445, 64)
        Label3.Name = "Label3"
        Label3.Size = New Size(75, 15)
        Label3.TabIndex = 7
        Label3.Text = "Book Title:"
        ' 
        ' TextBox2
        ' 
        TextBox2.Enabled = False
        TextBox2.Font = New Font("Arial Rounded MT Bold", 9.75F)
        TextBox2.Location = New Point(426, 82)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(133, 23)
        TextBox2.TabIndex = 6
        ' 
        ' ComboBox2
        ' 
        ComboBox2.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox2.Font = New Font("Arial Rounded MT Bold", 9.75F)
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(299, 82)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(121, 23)
        ComboBox2.TabIndex = 5
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.WhiteSmoke
        Label4.Location = New Point(308, 64)
        Label4.Name = "Label4"
        Label4.Size = New Size(60, 15)
        Label4.TabIndex = 4
        Label4.Text = "Book ID:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.WhiteSmoke
        Label2.Location = New Point(153, 64)
        Label2.Name = "Label2"
        Label2.Size = New Size(103, 15)
        Label2.TabIndex = 3
        Label2.Text = "Student Name:"
        ' 
        ' TextBox1
        ' 
        TextBox1.Enabled = False
        TextBox1.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(143, 82)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(133, 23)
        TextBox1.TabIndex = 2
        ' 
        ' ComboBox1
        ' 
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox1.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(16, 82)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(121, 23)
        ComboBox1.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.WhiteSmoke
        Label1.Location = New Point(16, 64)
        Label1.Name = "Label1"
        Label1.Size = New Size(79, 15)
        Label1.TabIndex = 0
        Label1.Text = "Student ID:"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Green
        Button1.Cursor = Cursors.Hand
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.WhiteSmoke
        Button1.Location = New Point(331, 372)
        Button1.Name = "Button1"
        Button1.Size = New Size(103, 36)
        Button1.TabIndex = 4
        Button1.Text = "Submit"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Red
        Button2.Cursor = Cursors.Hand
        Button2.FlatStyle = FlatStyle.Popup
        Button2.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.WhiteSmoke
        Button2.Location = New Point(459, 372)
        Button2.Name = "Button2"
        Button2.Size = New Size(103, 36)
        Button2.TabIndex = 5
        Button2.Text = "Clear"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' book_issuance
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(67), CByte(85), CByte(244))
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(843, 450)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "book_issuance"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Issue Book"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
