<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormAdmin
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.UsernameDisplay = New System.Windows.Forms.ToolStripMenuItem()
        Me.MYACCOUNTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LOGOUTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.filterTrans = New System.Windows.Forms.ComboBox()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.transFP = New System.Windows.Forms.FlowLayoutPanel()
        Me.UserControlAdmin1 = New WindowsApp6.UserControlAdmin()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Panel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.transFP.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Panel9)
        Me.Panel1.Controls.Add(Me.MenuStrip1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(20, 30)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(880, 118)
        Me.Panel1.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.SteelBlue
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(761, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 15)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "ADMIN"
        '
        'Panel9
        '
        Me.Panel9.BackgroundImage = Global.WindowsApp6.My.Resources.Resources.MaleUser
        Me.Panel9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel9.Location = New System.Drawing.Point(821, 12)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(48, 48)
        Me.Panel9.TabIndex = 6
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.Color.White
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UsernameDisplay})
        Me.MenuStrip1.Location = New System.Drawing.Point(613, 12)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.MenuStrip1.Size = New System.Drawing.Size(202, 33)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'UsernameDisplay
        '
        Me.UsernameDisplay.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MYACCOUNTToolStripMenuItem, Me.LOGOUTToolStripMenuItem})
        Me.UsernameDisplay.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameDisplay.ForeColor = System.Drawing.Color.SteelBlue
        Me.UsernameDisplay.Name = "UsernameDisplay"
        Me.UsernameDisplay.Size = New System.Drawing.Size(188, 29)
        Me.UsernameDisplay.Text = "AFTA DIZCA WAHANA"
        '
        'MYACCOUNTToolStripMenuItem
        '
        Me.MYACCOUNTToolStripMenuItem.Name = "MYACCOUNTToolStripMenuItem"
        Me.MYACCOUNTToolStripMenuItem.Size = New System.Drawing.Size(184, 24)
        Me.MYACCOUNTToolStripMenuItem.Text = "MY ACCOUNT"
        '
        'LOGOUTToolStripMenuItem
        '
        Me.LOGOUTToolStripMenuItem.Name = "LOGOUTToolStripMenuItem"
        Me.LOGOUTToolStripMenuItem.Size = New System.Drawing.Size(184, 24)
        Me.LOGOUTToolStripMenuItem.Text = "LOG OUT"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label2.Location = New System.Drawing.Point(109, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(317, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "STAY HOME ONLINE SHOPPING"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label1.Location = New System.Drawing.Point(109, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 44)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "SHOP"
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = Global.WindowsApp6.My.Resources.Resources.shopping_bag
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Location = New System.Drawing.Point(12, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(91, 87)
        Me.Panel2.TabIndex = 0
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.Panel7)
        Me.TabPage4.Controls.Add(Me.transFP)
        Me.TabPage4.Location = New System.Drawing.Point(4, 30)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(872, 399)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "TRANSACTION"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.GhostWhite
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel7.Controls.Add(Me.filterTrans)
        Me.Panel7.Controls.Add(Me.Panel8)
        Me.Panel7.Location = New System.Drawing.Point(3, 3)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(258, 35)
        Me.Panel7.TabIndex = 7
        '
        'filterTrans
        '
        Me.filterTrans.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.filterTrans.FormattingEnabled = True
        Me.filterTrans.Items.AddRange(New Object() {"All", "Waiting for Verification", "Verification Success"})
        Me.filterTrans.Location = New System.Drawing.Point(37, 2)
        Me.filterTrans.Name = "filterTrans"
        Me.filterTrans.Size = New System.Drawing.Size(216, 29)
        Me.filterTrans.TabIndex = 1
        '
        'Panel8
        '
        Me.Panel8.BackgroundImage = Global.WindowsApp6.My.Resources.Resources.Sorting_512px
        Me.Panel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel8.Location = New System.Drawing.Point(3, 2)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(29, 29)
        Me.Panel8.TabIndex = 2
        '
        'transFP
        '
        Me.transFP.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.transFP.AutoScroll = True
        Me.transFP.Controls.Add(Me.UserControlAdmin1)
        Me.transFP.Location = New System.Drawing.Point(3, 41)
        Me.transFP.Name = "transFP"
        Me.transFP.Padding = New System.Windows.Forms.Padding(6)
        Me.transFP.Size = New System.Drawing.Size(866, 355)
        Me.transFP.TabIndex = 0
        '
        'UserControlAdmin1
        '
        Me.UserControlAdmin1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UserControlAdmin1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserControlAdmin1.Location = New System.Drawing.Point(9, 9)
        Me.UserControlAdmin1.Name = "UserControlAdmin1"
        Me.UserControlAdmin1.Padding = New System.Windows.Forms.Padding(3)
        Me.UserControlAdmin1.Size = New System.Drawing.Size(270, 239)
        Me.UserControlAdmin1.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.ItemSize = New System.Drawing.Size(140, 26)
        Me.TabControl1.Location = New System.Drawing.Point(20, 151)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(880, 433)
        Me.TabControl1.TabIndex = 3
        '
        'FormAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(920, 607)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.DisplayHeader = False
        Me.KeyPreview = True
        Me.Name = "FormAdmin"
        Me.Padding = New System.Windows.Forms.Padding(20, 30, 20, 20)
        Me.Style = MetroFramework.MetroColorStyle.White
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.transFP.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents transFP As FlowLayoutPanel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents UserControlAdmin1 As UserControlAdmin
    Friend WithEvents Panel7 As Panel
    Friend WithEvents filterTrans As ComboBox
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents UsernameDisplay As ToolStripMenuItem
    Friend WithEvents MYACCOUNTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LOGOUTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label3 As Label
End Class
