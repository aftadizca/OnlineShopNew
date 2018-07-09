<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControlItem
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserControlItem))
        Me.nameGood = New System.Windows.Forms.Label()
        Me.shopName = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.price = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.addCart = New System.Windows.Forms.Button()
        Me.detail = New System.Windows.Forms.Button()
        Me.pic = New System.Windows.Forms.PictureBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.pic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'nameGood
        '
        Me.nameGood.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nameGood.AutoEllipsis = True
        Me.nameGood.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nameGood.ForeColor = System.Drawing.Color.SteelBlue
        Me.nameGood.Location = New System.Drawing.Point(122, 9)
        Me.nameGood.Name = "nameGood"
        Me.nameGood.Size = New System.Drawing.Size(224, 44)
        Me.nameGood.TabIndex = 1
        Me.nameGood.Text = "NAME"
        Me.nameGood.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'shopName
        '
        Me.shopName.AutoEllipsis = True
        Me.shopName.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.shopName.ForeColor = System.Drawing.Color.SteelBlue
        Me.shopName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.shopName.Location = New System.Drawing.Point(33, 123)
        Me.shopName.Name = "shopName"
        Me.shopName.Size = New System.Drawing.Size(231, 18)
        Me.shopName.TabIndex = 2
        Me.shopName.Text = "SHOP NAME"
        Me.shopName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.addCart)
        Me.Panel1.Controls.Add(Me.detail)
        Me.Panel1.Location = New System.Drawing.Point(270, 111)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(76, 30)
        Me.Panel1.TabIndex = 3
        '
        'price
        '
        Me.price.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.price.AutoEllipsis = True
        Me.price.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.price.ForeColor = System.Drawing.Color.SteelBlue
        Me.price.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.price.Location = New System.Drawing.Point(122, 53)
        Me.price.Name = "price"
        Me.price.Size = New System.Drawing.Size(227, 47)
        Me.price.TabIndex = 4
        Me.price.Text = "Rp. 125633333"
        Me.price.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = Global.WindowsApp6.My.Resources.Resources.SmallBusiness_512px
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Location = New System.Drawing.Point(9, 123)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(18, 18)
        Me.Panel2.TabIndex = 5
        '
        'addCart
        '
        Me.addCart.BackColor = System.Drawing.Color.Transparent
        Me.addCart.BackgroundImage = Global.WindowsApp6.My.Resources.Resources.AddCart
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
        'pic
        '
        Me.pic.BackgroundImage = Global.WindowsApp6.My.Resources.Resources.RemoveImage_512px
        Me.pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pic.Location = New System.Drawing.Point(9, 9)
        Me.pic.Name = "pic"
        Me.pic.Size = New System.Drawing.Size(107, 108)
        Me.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic.TabIndex = 0
        Me.pic.TabStop = False
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.ForeColor = System.Drawing.Color.Black
        Me.RichTextBox1.Location = New System.Drawing.Point(9, 159)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.RichTextBox1.Size = New System.Drawing.Size(340, 185)
        Me.RichTextBox1.TabIndex = 6
        Me.RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        '
        'UserControlItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.price)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.shopName)
        Me.Controls.Add(Me.nameGood)
        Me.Controls.Add(Me.pic)
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "UserControlItem"
        Me.Padding = New System.Windows.Forms.Padding(6)
        Me.Size = New System.Drawing.Size(358, 149)
        Me.Panel1.ResumeLayout(False)
        CType(Me.pic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pic As PictureBox
    Friend WithEvents nameGood As Label
    Friend WithEvents shopName As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents price As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents addCart As Button
    Friend WithEvents detail As Button
    Friend WithEvents RichTextBox1 As RichTextBox
End Class
