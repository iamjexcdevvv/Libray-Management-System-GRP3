﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class search_book
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(search_book))
        TextBox1 = New TextBox()
        Button1 = New Button()
        Label1 = New Label()
        Panel1 = New Panel()
        Button2 = New Button()
        TextBox9 = New TextBox()
        Label8 = New Label()
        TextBox8 = New TextBox()
        TextBox7 = New TextBox()
        Label7 = New Label()
        TextBox6 = New TextBox()
        Label5 = New Label()
        TextBox4 = New TextBox()
        Label6 = New Label()
        Label3 = New Label()
        TextBox2 = New TextBox()
        PictureBox1 = New PictureBox()
        TextBox5 = New TextBox()
        Label4 = New Label()
        TextBox3 = New TextBox()
        Label2 = New Label()
        Panel2 = New Panel()
        PictureBox4 = New PictureBox()
        Label9 = New Label()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(270, 82)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(248, 23)
        TextBox1.TabIndex = 0
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Transparent
        Button1.Cursor = Cursors.Hand
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Image = CType(resources.GetObject("Button1.Image"), Image)
        Button1.Location = New Point(524, 77)
        Button1.Name = "Button1"
        Button1.Size = New Size(35, 28)
        Button1.TabIndex = 1
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ControlText
        Label1.Location = New Point(189, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(86, 17)
        Label1.TabIndex = 2
        Label1.Text = "Book Title:"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.WhiteSmoke
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(TextBox9)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(TextBox8)
        Panel1.Controls.Add(TextBox7)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(TextBox6)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(TextBox4)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(TextBox2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(TextBox5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(TextBox3)
        Panel1.Controls.Add(Label2)
        Panel1.Location = New Point(143, 134)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(509, 339)
        Panel1.TabIndex = 3
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(26), CByte(125), CByte(15))
        Button2.Cursor = Cursors.Hand
        Button2.FlatStyle = FlatStyle.Popup
        Button2.Font = New Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.WhiteSmoke
        Button2.Location = New Point(18, 293)
        Button2.Name = "Button2"
        Button2.Size = New Size(106, 32)
        Button2.TabIndex = 21
        Button2.Text = "Borrow Book"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' TextBox9
        ' 
        TextBox9.Font = New Font("Arial Rounded MT Bold", 9.75F)
        TextBox9.Location = New Point(349, 134)
        TextBox9.Name = "TextBox9"
        TextBox9.ReadOnly = True
        TextBox9.Size = New Size(139, 23)
        TextBox9.TabIndex = 20
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = SystemColors.ControlText
        Label8.Location = New Point(350, 114)
        Label8.Name = "Label8"
        Label8.Size = New Size(101, 17)
        Label8.TabIndex = 19
        Label8.Text = "Book Genre:"
        ' 
        ' TextBox8
        ' 
        TextBox8.Font = New Font("Arial Rounded MT Bold", 9.75F)
        TextBox8.Location = New Point(189, 226)
        TextBox8.Name = "TextBox8"
        TextBox8.ReadOnly = True
        TextBox8.Size = New Size(139, 23)
        TextBox8.TabIndex = 18
        ' 
        ' TextBox7
        ' 
        TextBox7.Font = New Font("Arial Rounded MT Bold", 9.75F)
        TextBox7.Location = New Point(18, 39)
        TextBox7.Name = "TextBox7"
        TextBox7.ReadOnly = True
        TextBox7.Size = New Size(139, 23)
        TextBox7.TabIndex = 17
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = SystemColors.ControlText
        Label7.Location = New Point(18, 19)
        Label7.Name = "Label7"
        Label7.Size = New Size(71, 17)
        Label7.TabIndex = 16
        Label7.Text = "Book ID:"
        ' 
        ' TextBox6
        ' 
        TextBox6.Font = New Font("Arial Rounded MT Bold", 9.75F)
        TextBox6.Location = New Point(354, 39)
        TextBox6.Name = "TextBox6"
        TextBox6.ReadOnly = True
        TextBox6.Size = New Size(139, 23)
        TextBox6.TabIndex = 15
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = SystemColors.ControlText
        Label5.Location = New Point(190, 206)
        Label5.Name = "Label5"
        Label5.Size = New Size(101, 17)
        Label5.TabIndex = 10
        Label5.Text = "Book Status:"
        ' 
        ' TextBox4
        ' 
        TextBox4.Font = New Font("Arial Rounded MT Bold", 9.75F)
        TextBox4.Location = New Point(18, 134)
        TextBox4.Name = "TextBox4"
        TextBox4.ReadOnly = True
        TextBox4.Size = New Size(139, 23)
        TextBox4.TabIndex = 7
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = SystemColors.ControlText
        Label6.Location = New Point(354, 19)
        Label6.Name = "Label6"
        Label6.Size = New Size(92, 17)
        Label6.TabIndex = 14
        Label6.Text = "Book ISBN:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.ControlText
        Label3.Location = New Point(18, 114)
        Label3.Name = "Label3"
        Label3.Size = New Size(77, 17)
        Label3.TabIndex = 6
        Label3.Text = "Publisher"
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Arial Rounded MT Bold", 9.75F)
        TextBox2.Location = New Point(189, 39)
        TextBox2.Name = "TextBox2"
        TextBox2.ReadOnly = True
        TextBox2.Size = New Size(139, 23)
        TextBox2.TabIndex = 3
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Location = New Point(349, 183)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(139, 142)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 13
        PictureBox1.TabStop = False
        ' 
        ' TextBox5
        ' 
        TextBox5.Font = New Font("Arial Rounded MT Bold", 9.75F)
        TextBox5.Location = New Point(189, 134)
        TextBox5.Name = "TextBox5"
        TextBox5.ReadOnly = True
        TextBox5.Size = New Size(139, 23)
        TextBox5.TabIndex = 9
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = SystemColors.ControlText
        Label4.Location = New Point(189, 114)
        Label4.Name = "Label4"
        Label4.Size = New Size(122, 17)
        Label4.TabIndex = 8
        Label4.Text = "Published Date:"
        ' 
        ' TextBox3
        ' 
        TextBox3.Font = New Font("Arial Rounded MT Bold", 9.75F)
        TextBox3.Location = New Point(18, 226)
        TextBox3.Name = "TextBox3"
        TextBox3.ReadOnly = True
        TextBox3.Size = New Size(139, 23)
        TextBox3.TabIndex = 5
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ControlText
        Label2.Location = New Point(18, 206)
        Label2.Name = "Label2"
        Label2.Size = New Size(105, 17)
        Label2.TabIndex = 4
        Label2.Text = "Book Author:"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(238), CByte(115), CByte(12))
        Panel2.Controls.Add(PictureBox4)
        Panel2.Controls.Add(Label9)
        Panel2.Location = New Point(1, -2)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(798, 59)
        Panel2.TabIndex = 4
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Cursor = Cursors.Hand
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(738, 11)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(49, 39)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 24
        PictureBox4.TabStop = False
        ' 
        ' Label9
        ' 
        Label9.Font = New Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.FromArgb(CByte(36), CByte(45), CByte(88))
        Label9.Location = New Point(3, 11)
        Label9.Name = "Label9"
        Label9.Size = New Size(798, 39)
        Label9.TabIndex = 6
        Label9.Text = "Library Books"
        Label9.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' search_book
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(67), CByte(85), CByte(244))
        ClientSize = New Size(800, 505)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(Button1)
        Controls.Add(TextBox1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "search_book"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Book Search"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents PictureBox4 As PictureBox
End Class
