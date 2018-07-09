<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControlBill
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
        Me.idTransaksi = New System.Windows.Forms.Label()
        Me.tanggal = New System.Windows.Forms.Label()
        Me.total = New System.Windows.Forms.Label()
        Me.status = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.ButtonDetail = New System.Windows.Forms.Button()
        Me.payConfirm = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'idTransaksi
        '
        Me.idTransaksi.AutoSize = True
        Me.idTransaksi.ForeColor = System.Drawing.Color.White
        Me.idTransaksi.Location = New System.Drawing.Point(6, 6)
        Me.idTransaksi.Name = "idTransaksi"
        Me.idTransaksi.Size = New System.Drawing.Size(91, 17)
        Me.idTransaksi.TabIndex = 0
        Me.idTransaksi.Text = "TR0000000002"
        '
        'tanggal
        '
        Me.tanggal.AutoSize = True
        Me.tanggal.ForeColor = System.Drawing.Color.White
        Me.tanggal.Location = New System.Drawing.Point(223, 6)
        Me.tanggal.Name = "tanggal"
        Me.tanggal.Size = New System.Drawing.Size(123, 17)
        Me.tanggal.TabIndex = 1
        Me.tanggal.Text = "14/7/2017 16:00:00"
        '
        'total
        '
        Me.total.AutoSize = True
        Me.total.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.total.Location = New System.Drawing.Point(12, 50)
        Me.total.Name = "total"
        Me.total.Size = New System.Drawing.Size(134, 23)
        Me.total.TabIndex = 2
        Me.total.Text = "RP.  1.800.000"
        '
        'status
        '
        Me.status.AutoSize = True
        Me.status.BackColor = System.Drawing.SystemColors.Info
        Me.status.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.status.Location = New System.Drawing.Point(13, 85)
        Me.status.Name = "status"
        Me.status.Size = New System.Drawing.Size(58, 16)
        Me.status.TabIndex = 3
        Me.status.Text = "UNPAID"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel1.Controls.Add(Me.idTransaksi)
        Me.Panel1.Controls.Add(Me.tanggal)
        Me.Panel1.Location = New System.Drawing.Point(7, 7)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(349, 29)
        Me.Panel1.TabIndex = 4
        '
        'ButtonCancel
        '
        Me.ButtonCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonCancel.BackColor = System.Drawing.Color.Red
        Me.ButtonCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ButtonCancel.FlatAppearance.BorderSize = 0
        Me.ButtonCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue
        Me.ButtonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCancel.ForeColor = System.Drawing.Color.White
        Me.ButtonCancel.Location = New System.Drawing.Point(282, 52)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(71, 24)
        Me.ButtonCancel.TabIndex = 5
        Me.ButtonCancel.Tag = "cart"
        Me.ButtonCancel.Text = "CANCEL"
        Me.ButtonCancel.UseVisualStyleBackColor = False
        '
        'ButtonDetail
        '
        Me.ButtonDetail.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonDetail.BackColor = System.Drawing.Color.SteelBlue
        Me.ButtonDetail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonDetail.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ButtonDetail.FlatAppearance.BorderSize = 0
        Me.ButtonDetail.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue
        Me.ButtonDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonDetail.ForeColor = System.Drawing.Color.White
        Me.ButtonDetail.Location = New System.Drawing.Point(282, 81)
        Me.ButtonDetail.Name = "ButtonDetail"
        Me.ButtonDetail.Size = New System.Drawing.Size(71, 24)
        Me.ButtonDetail.TabIndex = 6
        Me.ButtonDetail.Tag = "cart"
        Me.ButtonDetail.Text = "DETAIL"
        Me.ButtonDetail.UseVisualStyleBackColor = False
        '
        'payConfirm
        '
        Me.payConfirm.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.payConfirm.BackColor = System.Drawing.Color.SteelBlue
        Me.payConfirm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.payConfirm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.payConfirm.FlatAppearance.BorderSize = 0
        Me.payConfirm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue
        Me.payConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.payConfirm.ForeColor = System.Drawing.Color.White
        Me.payConfirm.Location = New System.Drawing.Point(85, 81)
        Me.payConfirm.Name = "payConfirm"
        Me.payConfirm.Size = New System.Drawing.Size(194, 24)
        Me.payConfirm.TabIndex = 7
        Me.payConfirm.Tag = "cart"
        Me.payConfirm.Text = "PAYMENT CONFIRMATION"
        Me.payConfirm.UseVisualStyleBackColor = False
        '
        'UserControlBill
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.payConfirm)
        Me.Controls.Add(Me.ButtonDetail)
        Me.Controls.Add(Me.ButtonCancel)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.status)
        Me.Controls.Add(Me.total)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "UserControlBill"
        Me.Padding = New System.Windows.Forms.Padding(3)
        Me.Size = New System.Drawing.Size(362, 114)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents idTransaksi As Label
    Friend WithEvents tanggal As Label
    Friend WithEvents total As Label
    Friend WithEvents status As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ButtonCancel As Button
    Friend WithEvents ButtonDetail As Button
    Friend WithEvents payConfirm As Button
End Class
