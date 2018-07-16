<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPembeli
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
        Me.components = New System.ComponentModel.Container()
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
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.searchItem = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.filterItem = New System.Windows.Forms.ComboBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.homeFP = New System.Windows.Forms.FlowLayoutPanel()
        Me.UserControlItem1 = New WindowsApp6.UserControlItem()
        Me.UserControlItem2 = New WindowsApp6.UserControlItem()
        Me.UserControlItem3 = New WindowsApp6.UserControlItem()
        Me.UserControlItem4 = New WindowsApp6.UserControlItem()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.buttonCheckout = New System.Windows.Forms.Button()
        Me.totalHargaCart = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cartFP = New System.Windows.Forms.FlowLayoutPanel()
        Me.UserControlCartList1 = New WindowsApp6.UserControlCartList()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.billFP = New System.Windows.Forms.FlowLayoutPanel()
        Me.UserControlBill1 = New WindowsApp6.UserControlBill()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.filterTrans = New System.Windows.Forms.ComboBox()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.transFP = New System.Windows.Forms.FlowLayoutPanel()
        Me.UserControlTrans1 = New WindowsApp6.UserControlTrans()
        Me.refresh = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RefreshF5ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.homeFP.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.cartFP.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.billFP.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.transFP.SuspendLayout()
        Me.refresh.SuspendLayout()
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
        Me.Label4.Size = New System.Drawing.Size(41, 15)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "BUYER"
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
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
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
        Me.TabPage1.Controls.Add(Me.Panel6)
        Me.TabPage1.Controls.Add(Me.Panel5)
        Me.TabPage1.Controls.Add(Me.homeFP)
        Me.TabPage1.Location = New System.Drawing.Point(4, 30)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(872, 399)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "HOME"
        Me.TabPage1.UseVisualStyleBackColor = True
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
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.GhostWhite
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.filterItem)
        Me.Panel5.Controls.Add(Me.Panel3)
        Me.Panel5.Location = New System.Drawing.Point(6, 9)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(185, 35)
        Me.Panel5.TabIndex = 5
        '
        'filterItem
        '
        Me.filterItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.filterItem.FormattingEnabled = True
        Me.filterItem.Items.AddRange(New Object() {"ALL", "CHEAPEST", "MOST EXPENSIVE"})
        Me.filterItem.Location = New System.Drawing.Point(37, 2)
        Me.filterItem.Name = "filterItem"
        Me.filterItem.Size = New System.Drawing.Size(144, 29)
        Me.filterItem.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.BackgroundImage = Global.WindowsApp6.My.Resources.Resources.Sorting_512px
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.Location = New System.Drawing.Point(3, 2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(29, 29)
        Me.Panel3.TabIndex = 2
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
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.buttonCheckout)
        Me.TabPage2.Controls.Add(Me.totalHargaCart)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.cartFP)
        Me.TabPage2.Location = New System.Drawing.Point(4, 30)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(872, 399)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "CART"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'buttonCheckout
        '
        Me.buttonCheckout.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonCheckout.BackColor = System.Drawing.Color.SteelBlue
        Me.buttonCheckout.FlatAppearance.BorderSize = 0
        Me.buttonCheckout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.buttonCheckout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buttonCheckout.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonCheckout.ForeColor = System.Drawing.Color.White
        Me.buttonCheckout.Location = New System.Drawing.Point(725, 357)
        Me.buttonCheckout.Name = "buttonCheckout"
        Me.buttonCheckout.Size = New System.Drawing.Size(141, 39)
        Me.buttonCheckout.TabIndex = 3
        Me.buttonCheckout.Text = "CHECKOUT"
        Me.buttonCheckout.UseVisualStyleBackColor = False
        '
        'totalHargaCart
        '
        Me.totalHargaCart.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.totalHargaCart.BackColor = System.Drawing.Color.White
        Me.totalHargaCart.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold)
        Me.totalHargaCart.ForeColor = System.Drawing.Color.SteelBlue
        Me.totalHargaCart.Location = New System.Drawing.Point(479, 357)
        Me.totalHargaCart.Name = "totalHargaCart"
        Me.totalHargaCart.Size = New System.Drawing.Size(240, 39)
        Me.totalHargaCart.TabIndex = 2
        Me.totalHargaCart.Text = "Rp. 15.000.000"
        Me.totalHargaCart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(297, 357)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(176, 39)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "TOTAL PAYMENT"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cartFP
        '
        Me.cartFP.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cartFP.AutoScroll = True
        Me.cartFP.AutoScrollMinSize = New System.Drawing.Size(0, 200)
        Me.cartFP.Controls.Add(Me.UserControlCartList1)
        Me.cartFP.Location = New System.Drawing.Point(6, 6)
        Me.cartFP.Name = "cartFP"
        Me.cartFP.Padding = New System.Windows.Forms.Padding(6)
        Me.cartFP.Size = New System.Drawing.Size(860, 348)
        Me.cartFP.TabIndex = 0
        '
        'UserControlCartList1
        '
        Me.UserControlCartList1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UserControlCartList1.Location = New System.Drawing.Point(9, 9)
        Me.UserControlCartList1.Name = "UserControlCartList1"
        Me.UserControlCartList1.Size = New System.Drawing.Size(399, 139)
        Me.UserControlCartList1.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.billFP)
        Me.TabPage3.Location = New System.Drawing.Point(4, 30)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(872, 399)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "BILLING INFORMATION"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'billFP
        '
        Me.billFP.Controls.Add(Me.UserControlBill1)
        Me.billFP.Location = New System.Drawing.Point(3, 3)
        Me.billFP.Name = "billFP"
        Me.billFP.Padding = New System.Windows.Forms.Padding(6)
        Me.billFP.Size = New System.Drawing.Size(866, 393)
        Me.billFP.TabIndex = 0
        '
        'UserControlBill1
        '
        Me.UserControlBill1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UserControlBill1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserControlBill1.Location = New System.Drawing.Point(9, 9)
        Me.UserControlBill1.Name = "UserControlBill1"
        Me.UserControlBill1.Padding = New System.Windows.Forms.Padding(3)
        Me.UserControlBill1.Size = New System.Drawing.Size(362, 114)
        Me.UserControlBill1.TabIndex = 0
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
        Me.filterTrans.Items.AddRange(New Object() {"All", "Waiting for Verification", "Verification Success", "Processed by Seller", "Canceled by Seller", "Shipped", "Delivered"})
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
        'refresh
        '
        Me.refresh.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RefreshF5ToolStripMenuItem})
        Me.refresh.Name = "refresh"
        Me.refresh.Size = New System.Drawing.Size(137, 26)
        '
        'RefreshF5ToolStripMenuItem
        '
        Me.RefreshF5ToolStripMenuItem.Name = "RefreshF5ToolStripMenuItem"
        Me.RefreshF5ToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.RefreshF5ToolStripMenuItem.Text = "Refresh (F5)"
        '
        'FormPembeli
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(920, 607)
        Me.ContextMenuStrip = Me.refresh
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.DisplayHeader = False
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FormPembeli"
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
        Me.Panel5.ResumeLayout(False)
        Me.homeFP.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.cartFP.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.billFP.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.transFP.ResumeLayout(False)
        Me.refresh.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Panel3 As Panel
    Friend WithEvents filterItem As ComboBox
    Friend WithEvents homeFP As FlowLayoutPanel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents searchItem As TextBox
    Friend WithEvents UserControlItem1 As UserControlItem
    Friend WithEvents UserControlItem2 As UserControlItem
    Friend WithEvents UserControlItem3 As UserControlItem
    Friend WithEvents UserControlItem4 As UserControlItem
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents cartFP As FlowLayoutPanel
    Friend WithEvents UserControlCartList1 As UserControlCartList
    Friend WithEvents Label3 As Label
    Friend WithEvents totalHargaCart As Label
    Friend WithEvents buttonCheckout As Button
    Friend WithEvents billFP As FlowLayoutPanel
    Friend WithEvents UserControlBill1 As UserControlBill
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
    Friend WithEvents refresh As ContextMenuStrip
    Friend WithEvents RefreshF5ToolStripMenuItem As ToolStripMenuItem
End Class
