<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPenjual
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.UsernameDisplay = New System.Windows.Forms.ToolStripMenuItem()
        Me.MYACCOUNTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LOGOUTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.ButtonAddItem = New System.Windows.Forms.Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.searchItem = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.homeFP = New System.Windows.Forms.FlowLayoutPanel()
        Me.UserControlItem1 = New WindowsApp6.UserControlItem()
        Me.UserControlItem2 = New WindowsApp6.UserControlItem()
        Me.UserControlItem3 = New WindowsApp6.UserControlItem()
        Me.UserControlItem4 = New WindowsApp6.UserControlItem()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.filterTrans = New System.Windows.Forms.ComboBox()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.transFP = New System.Windows.Forms.FlowLayoutPanel()
        Me.UserControlTrans1 = New WindowsApp6.UserControlTrans()
        Me.Panel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.homeFP.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.transFP.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Panel9)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.MenuStrip1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(20, 30)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(880, 118)
        Me.Panel1.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.SteelBlue
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(767, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 15)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "SELLER"
        '
        'Panel9
        '
        Me.Panel9.BackgroundImage = Global.WindowsApp6.My.Resources.Resources.MaleUser
        Me.Panel9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel9.Location = New System.Drawing.Point(822, 12)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(48, 48)
        Me.Panel9.TabIndex = 4
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
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.Color.White
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UsernameDisplay})
        Me.MenuStrip1.Location = New System.Drawing.Point(617, 12)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.MenuStrip1.Size = New System.Drawing.Size(202, 33)
        Me.MenuStrip1.TabIndex = 5
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
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.ItemSize = New System.Drawing.Size(140, 26)
        Me.TabControl1.Location = New System.Drawing.Point(20, 151)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(880, 433)
        Me.TabControl1.TabIndex = 3
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.ButtonAddItem)
        Me.TabPage1.Controls.Add(Me.Panel6)
        Me.TabPage1.Controls.Add(Me.homeFP)
        Me.TabPage1.Location = New System.Drawing.Point(4, 30)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(872, 399)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "HOME"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'ButtonAddItem
        '
        Me.ButtonAddItem.BackColor = System.Drawing.Color.SteelBlue
        Me.ButtonAddItem.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAddItem.ForeColor = System.Drawing.Color.White
        Me.ButtonAddItem.Location = New System.Drawing.Point(6, 9)
        Me.ButtonAddItem.Name = "ButtonAddItem"
        Me.ButtonAddItem.Size = New System.Drawing.Size(75, 35)
        Me.ButtonAddItem.TabIndex = 7
        Me.ButtonAddItem.Text = "ADD"
        Me.ButtonAddItem.UseVisualStyleBackColor = False
        '
        'Panel6
        '
        Me.Panel6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel6.BackColor = System.Drawing.Color.GhostWhite
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.searchItem)
        Me.Panel6.Controls.Add(Me.Panel4)
        Me.Panel6.Location = New System.Drawing.Point(603, 9)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(263, 35)
        Me.Panel6.TabIndex = 6
        '
        'searchItem
        '
        Me.searchItem.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.searchItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.searchItem.Location = New System.Drawing.Point(40, 3)
        Me.searchItem.Name = "searchItem"
        Me.searchItem.Size = New System.Drawing.Size(218, 27)
        Me.searchItem.TabIndex = 3
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.BackgroundImage = Global.WindowsApp6.My.Resources.Resources.Search_512px
        Me.Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel4.Location = New System.Drawing.Point(5, 2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(29, 29)
        Me.Panel4.TabIndex = 4
        '
        'homeFP
        '
        Me.homeFP.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.homeFP.AutoScroll = True
        Me.homeFP.AutoScrollMinSize = New System.Drawing.Size(0, 400)
        Me.homeFP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.homeFP.Controls.Add(Me.UserControlItem1)
        Me.homeFP.Controls.Add(Me.UserControlItem2)
        Me.homeFP.Controls.Add(Me.UserControlItem3)
        Me.homeFP.Controls.Add(Me.UserControlItem4)
        Me.homeFP.Location = New System.Drawing.Point(6, 50)
        Me.homeFP.Name = "homeFP"
        Me.homeFP.Padding = New System.Windows.Forms.Padding(10, 10, 10, 40)
        Me.homeFP.Size = New System.Drawing.Size(860, 343)
        Me.homeFP.TabIndex = 0
        '
        'UserControlItem1
        '
        Me.UserControlItem1.BackColor = System.Drawing.Color.GhostWhite
        Me.UserControlItem1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UserControlItem1.Location = New System.Drawing.Point(16, 16)
        Me.UserControlItem1.Margin = New System.Windows.Forms.Padding(6)
        Me.UserControlItem1.Name = "UserControlItem1"
        Me.UserControlItem1.Padding = New System.Windows.Forms.Padding(6)
        Me.UserControlItem1.Size = New System.Drawing.Size(358, 153)
        Me.UserControlItem1.TabIndex = 0
        '
        'UserControlItem2
        '
        Me.UserControlItem2.BackColor = System.Drawing.Color.GhostWhite
        Me.UserControlItem2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UserControlItem2.Location = New System.Drawing.Point(386, 16)
        Me.UserControlItem2.Margin = New System.Windows.Forms.Padding(6)
        Me.UserControlItem2.Name = "UserControlItem2"
        Me.UserControlItem2.Padding = New System.Windows.Forms.Padding(6)
        Me.UserControlItem2.Size = New System.Drawing.Size(358, 153)
        Me.UserControlItem2.TabIndex = 1
        '
        'UserControlItem3
        '
        Me.UserControlItem3.BackColor = System.Drawing.Color.GhostWhite
        Me.UserControlItem3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UserControlItem3.Location = New System.Drawing.Point(16, 181)
        Me.UserControlItem3.Margin = New System.Windows.Forms.Padding(6)
        Me.UserControlItem3.Name = "UserControlItem3"
        Me.UserControlItem3.Padding = New System.Windows.Forms.Padding(6)
        Me.UserControlItem3.Size = New System.Drawing.Size(358, 153)
        Me.UserControlItem3.TabIndex = 2
        '
        'UserControlItem4
        '
        Me.UserControlItem4.BackColor = System.Drawing.Color.GhostWhite
        Me.UserControlItem4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UserControlItem4.Location = New System.Drawing.Point(386, 181)
        Me.UserControlItem4.Margin = New System.Windows.Forms.Padding(6)
        Me.UserControlItem4.Name = "UserControlItem4"
        Me.UserControlItem4.Padding = New System.Windows.Forms.Padding(6)
        Me.UserControlItem4.Size = New System.Drawing.Size(358, 153)
        Me.UserControlItem4.TabIndex = 3
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
        Me.Panel7.TabIndex = 6
        '
        'filterTrans
        '
        Me.filterTrans.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.filterTrans.FormattingEnabled = True
        Me.filterTrans.Items.AddRange(New Object() {"All", "Verification Success", "Processed by Seller", "Canceled by Seller", "Shipped", "Delivered"})
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
        Me.transFP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.transFP.Controls.Add(Me.UserControlTrans1)
        Me.transFP.Location = New System.Drawing.Point(3, 41)
        Me.transFP.Name = "transFP"
        Me.transFP.Padding = New System.Windows.Forms.Padding(6)
        Me.transFP.Size = New System.Drawing.Size(866, 355)
        Me.transFP.TabIndex = 0
        '
        'UserControlTrans1
        '
        Me.UserControlTrans1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UserControlTrans1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserControlTrans1.Location = New System.Drawing.Point(9, 9)
        Me.UserControlTrans1.Name = "UserControlTrans1"
        Me.UserControlTrans1.Padding = New System.Windows.Forms.Padding(3)
        Me.UserControlTrans1.Size = New System.Drawing.Size(270, 158)
        Me.UserControlTrans1.TabIndex = 0
        '
        'FormPenjual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(920, 607)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.DisplayHeader = False
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FormPenjual"
        Me.Padding = New System.Windows.Forms.Padding(20, 30, 20, 20)
        Me.Style = MetroFramework.MetroColorStyle.White
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.homeFP.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.transFP.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents homeFP As FlowLayoutPanel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents searchItem As TextBox
    Friend WithEvents UserControlItem1 As UserControlItem
    Friend WithEvents UserControlItem2 As UserControlItem
    Friend WithEvents UserControlItem3 As UserControlItem
    Friend WithEvents UserControlItem4 As UserControlItem
    Friend WithEvents Panel6 As Panel
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents transFP As FlowLayoutPanel
    Friend WithEvents UserControlTrans1 As UserControlTrans
    Friend WithEvents Panel7 As Panel
    Friend WithEvents filterTrans As ComboBox
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents UsernameDisplay As ToolStripMenuItem
    Friend WithEvents MYACCOUNTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LOGOUTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label4 As Label
    Friend WithEvents ButtonAddItem As Button
End Class
