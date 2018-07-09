<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UserControlCartList
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserControlCartList))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.addCart = New System.Windows.Forms.Button()
        Me.detail = New System.Windows.Forms.Button()
        Me.shopName = New System.Windows.Forms.Label()
        Me.nameGood = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.price = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.jumlah = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.pic = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.pic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.addCart)
        Me.Panel1.Controls.Add(Me.detail)
        Me.Panel1.Location = New System.Drawing.Point(320, 105)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(76, 30)
        Me.Panel1.TabIndex = 17
        '
        'addCart
        '
        Me.addCart.BackColor = System.Drawing.Color.Transparent
        Me.addCart.BackgroundImage = Global.WindowsApp6.My.Resources.Resources.TrashCan
        Me.addCart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.addCart.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.addCart.FlatAppearance.BorderSize = 0
        Me.addCart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue
        Me.addCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.addCart.Location = New System.Drawing.Point(40, 3)
        Me.addCart.Name = "addCart"
        Me.addCart.Size = New System.Drawing.Size(31, 24)
        Me.addCart.TabIndex = 0
        Me.addCart.Tag = "cart"
        Me.addCart.UseVisualStyleBackColor = False
        '
        'detail
        '
        Me.detail.BackColor = System.Drawing.Color.Transparent
        Me.detail.BackgroundImage = Global.WindowsApp6.My.Resources.Resources.DownButton
        Me.detail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.detail.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.detail.FlatAppearance.BorderSize = 0
        Me.detail.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue
        Me.detail.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.detail.Location = New System.Drawing.Point(3, 3)
        Me.detail.Name = "detail"
        Me.detail.Size = New System.Drawing.Size(31, 24)
        Me.detail.TabIndex = 1
        Me.detail.Tag = "down"
        Me.detail.UseVisualStyleBackColor = False
        '
        'shopName
        '
        Me.shopName.AutoEllipsis = True
        Me.shopName.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.shopName.ForeColor = System.Drawing.Color.SteelBlue
        Me.shopName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.shopName.Location = New System.Drawing.Point(27, 117)
        Me.shopName.Name = "shopName"
        Me.shopName.Size = New System.Drawing.Size(231, 18)
        Me.shopName.TabIndex = 16
        Me.shopName.Text = "SHOP NAME"
        Me.shopName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'nameGood
        '
        Me.nameGood.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nameGood.AutoEllipsis = True
        Me.nameGood.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nameGood.ForeColor = System.Drawing.Color.SteelBlue
        Me.nameGood.Location = New System.Drawing.Point(116, 3)
        Me.nameGood.Name = "nameGood"
        Me.nameGood.Size = New System.Drawing.Size(198, 44)
        Me.nameGood.TabIndex = 15
        Me.nameGood.Text = "NAME"
        Me.nameGood.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.ForeColor = System.Drawing.Color.Black
        Me.RichTextBox1.Location = New System.Drawing.Point(3, 153)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.RichTextBox1.Size = New System.Drawing.Size(393, 185)
        Me.RichTextBox1.TabIndex = 20
        Me.RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        '
        'price
        '
        Me.price.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.price.AutoEllipsis = True
        Me.price.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.price.ForeColor = System.Drawing.Color.SteelBlue
        Me.price.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.price.Location = New System.Drawing.Point(116, 47)
        Me.price.Name = "price"
        Me.price.Size = New System.Drawing.Size(198, 47)
        Me.price.TabIndex = 18
        Me.price.Text = "Rp. 125633333"
        Me.price.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel3.Controls.Add(Me.jumlah)
        Me.Panel3.Location = New System.Drawing.Point(320, 32)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(76, 44)
        Me.Panel3.TabIndex = 21
        '
        'jumlah
        '
        Me.jumlah.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.jumlah.BackColor = System.Drawing.Color.SteelBlue
        Me.jumlah.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jumlah.ForeColor = System.Drawing.Color.White
        Me.jumlah.Location = New System.Drawing.Point(0, -2)
        Me.jumlah.Name = "jumlah"
        Me.jumlah.Size = New System.Drawing.Size(76, 44)
        Me.jumlah.TabIndex = 0
        Me.jumlah.Text = "399"
        Me.jumlah.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BackgroundImage = Global.WindowsApp6.My.Resources.Resources.Plus
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(344, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(31, 24)
        Me.Button2.TabIndex = 23
        Me.Button2.Tag = "down"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = Global.WindowsApp6.My.Resources.Resources.Min
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(344, 80)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(31, 24)
        Me.Button1.TabIndex = 22
        Me.Button1.Tag = "down"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = Global.WindowsApp6.My.Resources.Resources.SmallBusiness_512px
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Location = New System.Drawing.Point(3, 117)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(18, 18)
        Me.Panel2.TabIndex = 19
        '
        'pic
        '
        Me.pic.BackgroundImage = Global.WindowsApp6.My.Resources.Resources.RemoveImage_512px
        Me.pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pic.Location = New System.Drawing.Point(3, 3)
        Me.pic.Name = "pic"
        Me.pic.Size = New System.Drawing.Size(107, 108)
        Me.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic.TabIndex = 14
        Me.pic.TabStop = False
        '
        'UserControlCartList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.shopName)
        Me.Controls.Add(Me.nameGood)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.price)
        Me.Controls.Add(Me.pic)
        Me.Name = "UserControlCartList"
        Me.Size = New System.Drawing.Size(399, 139)
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.pic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents addCart As Button
    Friend WithEvents detail As Button
    Friend WithEvents shopName As Label
    Friend WithEvents nameGood As Label
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents price As Label
    Friend WithEvents pic As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents jumlah As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
