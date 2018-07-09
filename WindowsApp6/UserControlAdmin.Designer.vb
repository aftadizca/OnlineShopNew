<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControlAdmin
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
        Me.tanggal = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.namaPembeli = New System.Windows.Forms.Label()
        Me.status = New System.Windows.Forms.Label()
        Me.idTransaksi = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ButtonVerify = New System.Windows.Forms.Button()
        Me.bankName = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.senderName = New System.Windows.Forms.Label()
        Me.name_rek = New System.Windows.Forms.Label()
        Me.noBank = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.paid = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tanggal
        '
        Me.tanggal.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.tanggal.AutoSize = True
        Me.tanggal.ForeColor = System.Drawing.Color.White
        Me.tanggal.Location = New System.Drawing.Point(147, 6)
        Me.tanggal.Name = "tanggal"
        Me.tanggal.Size = New System.Drawing.Size(105, 16)
        Me.tanggal.TabIndex = 1
        Me.tanggal.Text = "14/7/2017 16:00:00"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel1.Controls.Add(Me.namaPembeli)
        Me.Panel1.Controls.Add(Me.tanggal)
        Me.Panel1.Location = New System.Drawing.Point(6, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(258, 29)
        Me.Panel1.TabIndex = 14
        '
        'namaPembeli
        '
        Me.namaPembeli.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.namaPembeli.AutoSize = True
        Me.namaPembeli.ForeColor = System.Drawing.Color.White
        Me.namaPembeli.Location = New System.Drawing.Point(6, 6)
        Me.namaPembeli.Name = "namaPembeli"
        Me.namaPembeli.Size = New System.Drawing.Size(119, 16)
        Me.namaPembeli.TabIndex = 2
        Me.namaPembeli.Text = "AFTA DIZCA WAHANA"
        '
        'status
        '
        Me.status.AutoSize = True
        Me.status.BackColor = System.Drawing.SystemColors.Info
        Me.status.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.status.Location = New System.Drawing.Point(12, 48)
        Me.status.Name = "status"
        Me.status.Size = New System.Drawing.Size(58, 16)
        Me.status.TabIndex = 13
        Me.status.Text = "UNPAID"
        '
        'idTransaksi
        '
        Me.idTransaksi.AutoSize = True
        Me.idTransaksi.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.idTransaksi.Location = New System.Drawing.Point(130, 78)
        Me.idTransaksi.Name = "idTransaksi"
        Me.idTransaksi.Size = New System.Drawing.Size(127, 17)
        Me.idTransaksi.TabIndex = 20
        Me.idTransaksi.Text = "12115511151151551"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 16)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "TRANSACTION ID"
        '
        'ButtonVerify
        '
        Me.ButtonVerify.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonVerify.BackColor = System.Drawing.Color.SteelBlue
        Me.ButtonVerify.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonVerify.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ButtonVerify.FlatAppearance.BorderSize = 0
        Me.ButtonVerify.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue
        Me.ButtonVerify.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonVerify.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonVerify.ForeColor = System.Drawing.Color.White
        Me.ButtonVerify.Location = New System.Drawing.Point(193, 209)
        Me.ButtonVerify.Name = "ButtonVerify"
        Me.ButtonVerify.Size = New System.Drawing.Size(71, 24)
        Me.ButtonVerify.TabIndex = 21
        Me.ButtonVerify.Tag = "cart"
        Me.ButtonVerify.Text = "VERIFY"
        Me.ButtonVerify.UseVisualStyleBackColor = False
        '
        'bankName
        '
        Me.bankName.AutoSize = True
        Me.bankName.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bankName.Location = New System.Drawing.Point(130, 108)
        Me.bankName.Name = "bankName"
        Me.bankName.Size = New System.Drawing.Size(127, 17)
        Me.bankName.TabIndex = 23
        Me.bankName.Text = "12115511151151551"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 16)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "BANK NAME"
        '
        'senderName
        '
        Me.senderName.AutoSize = True
        Me.senderName.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.senderName.Location = New System.Drawing.Point(130, 125)
        Me.senderName.Name = "senderName"
        Me.senderName.Size = New System.Drawing.Size(127, 17)
        Me.senderName.TabIndex = 25
        Me.senderName.Text = "12115511151151551"
        '
        'name_rek
        '
        Me.name_rek.AutoSize = True
        Me.name_rek.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.name_rek.Location = New System.Drawing.Point(12, 125)
        Me.name_rek.Name = "name_rek"
        Me.name_rek.Size = New System.Drawing.Size(47, 16)
        Me.name_rek.TabIndex = 24
        Me.name_rek.Text = "NAME"
        '
        'noBank
        '
        Me.noBank.AutoSize = True
        Me.noBank.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.noBank.Location = New System.Drawing.Point(130, 142)
        Me.noBank.Name = "noBank"
        Me.noBank.Size = New System.Drawing.Size(127, 17)
        Me.noBank.TabIndex = 27
        Me.noBank.Text = "12115511151151551"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 142)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(113, 16)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "BANK ACCOUNT"
        '
        'paid
        '
        Me.paid.AutoSize = True
        Me.paid.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.paid.Location = New System.Drawing.Point(130, 170)
        Me.paid.Name = "paid"
        Me.paid.Size = New System.Drawing.Size(127, 17)
        Me.paid.TabIndex = 29
        Me.paid.Text = "12115511151151551"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 170)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(38, 16)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "PAID"
        '
        'UserControlAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.paid)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.noBank)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.senderName)
        Me.Controls.Add(Me.name_rek)
        Me.Controls.Add(Me.bankName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ButtonVerify)
        Me.Controls.Add(Me.idTransaksi)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.status)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "UserControlAdmin"
        Me.Padding = New System.Windows.Forms.Padding(3)
        Me.Size = New System.Drawing.Size(270, 239)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tanggal As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents status As Label
    Friend WithEvents idTransaksi As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ButtonVerify As Button
    Friend WithEvents bankName As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents senderName As Label
    Friend WithEvents name_rek As Label
    Friend WithEvents noBank As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents paid As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents namaPembeli As Label
End Class
