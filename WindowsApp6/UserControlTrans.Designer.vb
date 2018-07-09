<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControlTrans
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
        Me.namaToko = New System.Windows.Forms.Label()
        Me.tanggal = New System.Windows.Forms.Label()
        Me.ButtonDetail = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.status = New System.Windows.Forms.Label()
        Me.total = New System.Windows.Forms.Label()
        Me.resi = New System.Windows.Forms.Label()
        Me.idTransaksi = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ButtonReceived = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'namaToko
        '
        Me.namaToko.AutoSize = True
        Me.namaToko.ForeColor = System.Drawing.Color.White
        Me.namaToko.Location = New System.Drawing.Point(6, 6)
        Me.namaToko.Name = "namaToko"
        Me.namaToko.Size = New System.Drawing.Size(70, 16)
        Me.namaToko.TabIndex = 0
        Me.namaToko.Text = "TOKO SAYA"
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
        'ButtonDetail
        '
        Me.ButtonDetail.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonDetail.BackColor = System.Drawing.Color.SteelBlue
        Me.ButtonDetail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonDetail.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ButtonDetail.FlatAppearance.BorderSize = 0
        Me.ButtonDetail.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue
        Me.ButtonDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonDetail.ForeColor = System.Drawing.Color.White
        Me.ButtonDetail.Location = New System.Drawing.Point(193, 128)
        Me.ButtonDetail.Name = "ButtonDetail"
        Me.ButtonDetail.Size = New System.Drawing.Size(71, 24)
        Me.ButtonDetail.TabIndex = 16
        Me.ButtonDetail.Tag = "cart"
        Me.ButtonDetail.Text = "DETAIL"
        Me.ButtonDetail.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel1.Controls.Add(Me.namaToko)
        Me.Panel1.Controls.Add(Me.tanggal)
        Me.Panel1.Location = New System.Drawing.Point(6, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(258, 29)
        Me.Panel1.TabIndex = 14
        '
        'status
        '
        Me.status.AutoSize = True
        Me.status.BackColor = System.Drawing.SystemColors.Info
        Me.status.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.status.ForeColor = System.Drawing.Color.Green
        Me.status.Location = New System.Drawing.Point(12, 48)
        Me.status.Name = "status"
        Me.status.Size = New System.Drawing.Size(58, 16)
        Me.status.TabIndex = 13
        Me.status.Text = "UNPAID"
        '
        'total
        '
        Me.total.AutoSize = True
        Me.total.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.total.Location = New System.Drawing.Point(12, 100)
        Me.total.Name = "total"
        Me.total.Size = New System.Drawing.Size(32, 17)
        Me.total.TabIndex = 12
        Me.total.Text = "RESI"
        '
        'resi
        '
        Me.resi.AutoSize = True
        Me.resi.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.resi.Location = New System.Drawing.Point(130, 100)
        Me.resi.Name = "resi"
        Me.resi.Size = New System.Drawing.Size(127, 17)
        Me.resi.TabIndex = 17
        Me.resi.Text = "12115511151151551"
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
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 17)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "TRANSACTION ID"
        '
        'ButtonReceived
        '
        Me.ButtonReceived.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonReceived.BackColor = System.Drawing.Color.SteelBlue
        Me.ButtonReceived.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonReceived.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ButtonReceived.FlatAppearance.BorderSize = 0
        Me.ButtonReceived.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue
        Me.ButtonReceived.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonReceived.ForeColor = System.Drawing.Color.White
        Me.ButtonReceived.Location = New System.Drawing.Point(116, 128)
        Me.ButtonReceived.Name = "ButtonReceived"
        Me.ButtonReceived.Size = New System.Drawing.Size(71, 24)
        Me.ButtonReceived.TabIndex = 21
        Me.ButtonReceived.Tag = "cart"
        Me.ButtonReceived.Text = "RECEIVED"
        Me.ButtonReceived.UseVisualStyleBackColor = False
        '
        'UserControlTrans
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.ButtonReceived)
        Me.Controls.Add(Me.idTransaksi)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.resi)
        Me.Controls.Add(Me.ButtonDetail)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.status)
        Me.Controls.Add(Me.total)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "UserControlTrans"
        Me.Padding = New System.Windows.Forms.Padding(3)
        Me.Size = New System.Drawing.Size(270, 158)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents namaToko As Label
    Friend WithEvents tanggal As Label
    Friend WithEvents ButtonDetail As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents status As Label
    Friend WithEvents total As Label
    Friend WithEvents resi As Label
    Friend WithEvents idTransaksi As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ButtonReceived As Button
End Class
