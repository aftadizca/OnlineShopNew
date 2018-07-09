<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TambahBarang
    Inherits MetroFramework.Forms.MetroForm

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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NameTB = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DescTB = New System.Windows.Forms.RichTextBox()
        Me.Price = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PriceTB = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.PictureTB = New System.Windows.Forms.PictureBox()
        CType(Me.PictureTB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 278)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "NAME"
        '
        'NameTB
        '
        Me.NameTB.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameTB.Location = New System.Drawing.Point(120, 275)
        Me.NameTB.Name = "NameTB"
        Me.NameTB.Size = New System.Drawing.Size(204, 23)
        Me.NameTB.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 307)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "DESCRIPTION"
        '
        'DescTB
        '
        Me.DescTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DescTB.Location = New System.Drawing.Point(120, 307)
        Me.DescTB.Name = "DescTB"
        Me.DescTB.Size = New System.Drawing.Size(204, 96)
        Me.DescTB.TabIndex = 4
        Me.DescTB.Text = ""
        '
        'Price
        '
        Me.Price.AutoSize = True
        Me.Price.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Price.Location = New System.Drawing.Point(23, 412)
        Me.Price.Name = "Price"
        Me.Price.Size = New System.Drawing.Size(44, 16)
        Me.Price.TabIndex = 5
        Me.Price.Text = "PRICE"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(249, 451)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 35)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "SAVE"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PriceTB
        '
        Me.PriceTB.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PriceTB.Location = New System.Drawing.Point(120, 412)
        Me.PriceTB.Name = "PriceTB"
        Me.PriceTB.Size = New System.Drawing.Size(204, 23)
        Me.PriceTB.TabIndex = 8
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'PictureTB
        '
        Me.PictureTB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureTB.Image = Global.WindowsApp6.My.Resources.Resources.AddImage_520px
        Me.PictureTB.ImageLocation = ""
        Me.PictureTB.Location = New System.Drawing.Point(82, 63)
        Me.PictureTB.Name = "PictureTB"
        Me.PictureTB.Size = New System.Drawing.Size(176, 188)
        Me.PictureTB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureTB.TabIndex = 0
        Me.PictureTB.TabStop = False
        '
        'TambahBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(347, 524)
        Me.Controls.Add(Me.PriceTB)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Price)
        Me.Controls.Add(Me.DescTB)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.NameTB)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureTB)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "TambahBarang"
        Me.Text = "ADD ITEM"
        CType(Me.PictureTB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureTB As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents NameTB As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DescTB As RichTextBox
    Friend WithEvents Price As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents PriceTB As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
