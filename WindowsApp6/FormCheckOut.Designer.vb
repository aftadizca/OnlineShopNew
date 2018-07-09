<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormCheckOut
    Inherits MetroFramework.Forms.MetroForm

    'Form overrides dispose to clean up the component list.
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.receiver = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.checkoutDetailFP = New System.Windows.Forms.FlowLayoutPanel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.total = New System.Windows.Forms.TextBox()
        Me.address = New System.Windows.Forms.RichTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.buttonCheckout = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "RECEIVER"
        '
        'receiver
        '
        Me.receiver.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.receiver.Location = New System.Drawing.Point(142, 35)
        Me.receiver.Name = "receiver"
        Me.receiver.ReadOnly = True
        Me.receiver.Size = New System.Drawing.Size(333, 27)
        Me.receiver.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.checkoutDetailFP)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Location = New System.Drawing.Point(24, 64)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(505, 453)
        Me.Panel1.TabIndex = 2
        '
        'checkoutDetailFP
        '
        Me.checkoutDetailFP.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.checkoutDetailFP.AutoScroll = True
        Me.checkoutDetailFP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.checkoutDetailFP.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.checkoutDetailFP.Location = New System.Drawing.Point(4, 296)
        Me.checkoutDetailFP.Name = "checkoutDetailFP"
        Me.checkoutDetailFP.Padding = New System.Windows.Forms.Padding(5)
        Me.checkoutDetailFP.Size = New System.Drawing.Size(498, 157)
        Me.checkoutDetailFP.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Panel2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.total)
        Me.GroupBox1.Controls.Add(Me.address)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.receiver)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(498, 286)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "SHIPMENT DETAILS"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Location = New System.Drawing.Point(142, 207)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(333, 73)
        Me.Panel2.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(51, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(233, 19)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "TRANSFER TO SHOP ACCOUNT"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(60, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(214, 21)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "BANK MANDIRI 143265656"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 171)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 21)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "TOTAL"
        '
        'total
        '
        Me.total.BackColor = System.Drawing.Color.SteelBlue
        Me.total.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.total.ForeColor = System.Drawing.Color.White
        Me.total.Location = New System.Drawing.Point(142, 171)
        Me.total.Name = "total"
        Me.total.ReadOnly = True
        Me.total.Size = New System.Drawing.Size(333, 27)
        Me.total.TabIndex = 5
        '
        'address
        '
        Me.address.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.address.Location = New System.Drawing.Point(142, 69)
        Me.address.Name = "address"
        Me.address.ReadOnly = True
        Me.address.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.address.Size = New System.Drawing.Size(333, 96)
        Me.address.TabIndex = 3
        Me.address.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 21)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "ADDRESS"
        '
        'buttonCheckout
        '
        Me.buttonCheckout.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.buttonCheckout.BackColor = System.Drawing.Color.SteelBlue
        Me.buttonCheckout.FlatAppearance.BorderSize = 0
        Me.buttonCheckout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.buttonCheckout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buttonCheckout.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonCheckout.ForeColor = System.Drawing.Color.White
        Me.buttonCheckout.Location = New System.Drawing.Point(197, 523)
        Me.buttonCheckout.Name = "buttonCheckout"
        Me.buttonCheckout.Size = New System.Drawing.Size(141, 39)
        Me.buttonCheckout.TabIndex = 4
        Me.buttonCheckout.Text = "CHECKOUT"
        Me.buttonCheckout.UseVisualStyleBackColor = False
        '
        'FormCheckOut
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(552, 569)
        Me.Controls.Add(Me.buttonCheckout)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormCheckOut"
        Me.Resizable = False
        Me.Text = "CHECKOUT"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents receiver As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents address As RichTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents checkoutDetailFP As FlowLayoutPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents total As TextBox
    Friend WithEvents buttonCheckout As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label5 As Label
End Class
