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
        Panel2 = New Panel()
        Label3 = New Label()
        PictureBox3 = New PictureBox()
        PictureBox2 = New PictureBox()
        Panel3 = New Panel()
        Button1 = New Button()
        Label4 = New Label()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
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
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(836, 77)
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
        Label2.Location = New Point(642, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(116, 22)
        Label2.TabIndex = 0
        Label2.Text = "WELCOME!"
        ' 
        ' Label9
        ' 
        Label9.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = SystemColors.ButtonHighlight
        Label9.Location = New Point(642, 40)
        Label9.Name = "Label9"
        Label9.Size = New Size(116, 15)
        Label9.TabIndex = 2
        Label9.Text = "Hi, Admin"
        Label9.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(67), CByte(85), CByte(244))
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(PictureBox3)
        Panel2.Location = New Point(0, 76)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(187, 441)
        Panel2.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.WhiteSmoke
        Label3.Location = New Point(32, 98)
        Label3.Name = "Label3"
        Label3.Size = New Size(111, 18)
        Label3.TabIndex = 10
        Label3.Text = "Search Book"
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.Transparent
        PictureBox3.Cursor = Cursors.Hand
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(32, 20)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(111, 75)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 9
        PictureBox3.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.inaki_del_olmo_NIJuEQw0RKg_unsplash
        PictureBox2.Location = New Point(185, 76)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(651, 441)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 2
        PictureBox2.TabStop = False
        ' 
        ' Panel3
        ' 
        Panel3.AutoScroll = True
        Panel3.BackColor = SystemColors.ActiveBorder
        Panel3.Controls.Add(Button1)
        Panel3.Location = New Point(229, 153)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(569, 344)
        Panel3.TabIndex = 17
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(215, 79)
        Button1.Name = "Button1"
        Button1.Size = New Size(0, 0)
        Button1.TabIndex = 0
        Button1.Text = "Button1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.BackColor = Color.FromArgb(CByte(67), CByte(85), CByte(244))
        Label4.Font = New Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.WhiteSmoke
        Label4.Location = New Point(229, 138)
        Label4.Name = "Label4"
        Label4.Size = New Size(569, 23)
        Label4.TabIndex = 18
        Label4.Text = "Borrowed Books"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' user_dashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(836, 513)
        Controls.Add(Label4)
        Controls.Add(Panel3)
        Controls.Add(PictureBox2)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        DoubleBuffered = True
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "user_dashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "User Dashboard"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
End Class
