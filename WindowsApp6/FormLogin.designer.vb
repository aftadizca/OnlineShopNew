<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLogin
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLogin))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.loginAsComboBox = New MetroFramework.Controls.MetroComboBox()
        Me.submitLogin = New MetroFramework.Controls.MetroButton()
        Me.passLogin = New MetroFramework.Controls.MetroTextBox()
        Me.emailLogin = New MetroFramework.Controls.MetroTextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.RegisterAsComboBox = New MetroFramework.Controls.MetroComboBox()
        Me.FullnameReg = New MetroFramework.Controls.MetroTextBox()
        Me.RegisterButton = New MetroFramework.Controls.MetroButton()
        Me.PassRepeatReg = New MetroFramework.Controls.MetroTextBox()
        Me.PassReg = New MetroFramework.Controls.MetroTextBox()
        Me.EmailReg = New MetroFramework.Controls.MetroTextBox()
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(31, 82)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(262, 388)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Controls.Add(Me.loginAsComboBox)
        Me.TabPage1.Controls.Add(Me.submitLogin)
        Me.TabPage1.Controls.Add(Me.passLogin)
        Me.TabPage1.Controls.Add(Me.emailLogin)
        Me.TabPage1.ForeColor = System.Drawing.Color.Black
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Size = New System.Drawing.Size(254, 359)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "LOGIN"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.WindowsApp6.My.Resources.Resources.shopping_bag
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Location = New System.Drawing.Point(62, 18)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(129, 126)
        Me.Panel1.TabIndex = 5
        '
        'loginAsComboBox
        '
        Me.loginAsComboBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.loginAsComboBox.BackColor = System.Drawing.SystemColors.Control
        Me.loginAsComboBox.FontWeight = MetroFramework.MetroComboBoxWeight.Bold
        Me.loginAsComboBox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.loginAsComboBox.FormattingEnabled = True
        Me.loginAsComboBox.ItemHeight = 23
        Me.loginAsComboBox.Items.AddRange(New Object() {"BUYER", "SELLER", "ADMIN"})
        Me.loginAsComboBox.Location = New System.Drawing.Point(35, 161)
        Me.loginAsComboBox.Name = "loginAsComboBox"
        Me.loginAsComboBox.PromptText = "LOGIN AS"
        Me.loginAsComboBox.Size = New System.Drawing.Size(183, 29)
        Me.loginAsComboBox.Style = MetroFramework.MetroColorStyle.Blue
        Me.loginAsComboBox.TabIndex = 4
        Me.loginAsComboBox.UseCustomBackColor = True
        Me.loginAsComboBox.UseCustomForeColor = True
        Me.loginAsComboBox.UseSelectable = True
        Me.loginAsComboBox.UseStyleColors = True
        '
        'submitLogin
        '
        Me.submitLogin.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.submitLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.submitLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.submitLogin.DisplayFocus = True
        Me.submitLogin.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.submitLogin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.submitLogin.Highlight = True
        Me.submitLogin.Location = New System.Drawing.Point(89, 284)
        Me.submitLogin.Name = "submitLogin"
        Me.submitLogin.Size = New System.Drawing.Size(75, 36)
        Me.submitLogin.Style = MetroFramework.MetroColorStyle.Silver
        Me.submitLogin.TabIndex = 2
        Me.submitLogin.Text = "LOGIN"
        Me.submitLogin.UseCustomBackColor = True
        Me.submitLogin.UseCustomForeColor = True
        Me.submitLogin.UseSelectable = True
        Me.submitLogin.UseStyleColors = True
        '
        'passLogin
        '
        Me.passLogin.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.passLogin.CustomButton.Image = Nothing
        Me.passLogin.CustomButton.Location = New System.Drawing.Point(161, 2)
        Me.passLogin.CustomButton.Name = ""
        Me.passLogin.CustomButton.Size = New System.Drawing.Size(19, 19)
        Me.passLogin.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.passLogin.CustomButton.TabIndex = 1
        Me.passLogin.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.passLogin.CustomButton.UseSelectable = True
        Me.passLogin.CustomButton.Visible = False
        Me.passLogin.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.passLogin.IconRight = True
        Me.passLogin.Lines = New String(-1) {}
        Me.passLogin.Location = New System.Drawing.Point(35, 245)
        Me.passLogin.MaxLength = 32767
        Me.passLogin.Name = "passLogin"
        Me.passLogin.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.passLogin.PromptText = "PASSWORD"
        Me.passLogin.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.passLogin.SelectedText = ""
        Me.passLogin.SelectionLength = 0
        Me.passLogin.SelectionStart = 0
        Me.passLogin.ShortcutsEnabled = True
        Me.passLogin.ShowClearButton = True
        Me.passLogin.Size = New System.Drawing.Size(183, 24)
        Me.passLogin.Style = MetroFramework.MetroColorStyle.Blue
        Me.passLogin.TabIndex = 1
        Me.passLogin.UseCustomBackColor = True
        Me.passLogin.UseCustomForeColor = True
        Me.passLogin.UseSelectable = True
        Me.passLogin.UseStyleColors = True
        Me.passLogin.UseSystemPasswordChar = True
        Me.passLogin.WaterMark = "PASSWORD"
        Me.passLogin.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.passLogin.WaterMarkFont = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'emailLogin
        '
        Me.emailLogin.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.emailLogin.CustomButton.Image = Nothing
        Me.emailLogin.CustomButton.Location = New System.Drawing.Point(161, 2)
        Me.emailLogin.CustomButton.Name = ""
        Me.emailLogin.CustomButton.Size = New System.Drawing.Size(19, 19)
        Me.emailLogin.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.emailLogin.CustomButton.TabIndex = 1
        Me.emailLogin.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.emailLogin.CustomButton.UseSelectable = True
        Me.emailLogin.CustomButton.Visible = False
        Me.emailLogin.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.emailLogin.IconRight = True
        Me.emailLogin.Lines = New String(-1) {}
        Me.emailLogin.Location = New System.Drawing.Point(35, 206)
        Me.emailLogin.MaxLength = 32767
        Me.emailLogin.Name = "emailLogin"
        Me.emailLogin.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.emailLogin.PromptText = "EMAIL"
        Me.emailLogin.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.emailLogin.SelectedText = ""
        Me.emailLogin.SelectionLength = 0
        Me.emailLogin.SelectionStart = 0
        Me.emailLogin.ShortcutsEnabled = True
        Me.emailLogin.ShowClearButton = True
        Me.emailLogin.Size = New System.Drawing.Size(183, 24)
        Me.emailLogin.Style = MetroFramework.MetroColorStyle.Blue
        Me.emailLogin.TabIndex = 0
        Me.emailLogin.UseCustomBackColor = True
        Me.emailLogin.UseCustomForeColor = True
        Me.emailLogin.UseSelectable = True
        Me.emailLogin.UseStyleColors = True
        Me.emailLogin.WaterMark = "EMAIL"
        Me.emailLogin.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.emailLogin.WaterMarkFont = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.RegisterAsComboBox)
        Me.TabPage2.Controls.Add(Me.FullnameReg)
        Me.TabPage2.Controls.Add(Me.RegisterButton)
        Me.TabPage2.Controls.Add(Me.PassRepeatReg)
        Me.TabPage2.Controls.Add(Me.PassReg)
        Me.TabPage2.Controls.Add(Me.EmailReg)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Size = New System.Drawing.Size(254, 359)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "REGISTER"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'RegisterAsComboBox
        '
        Me.RegisterAsComboBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RegisterAsComboBox.BackColor = System.Drawing.SystemColors.Control
        Me.RegisterAsComboBox.FontWeight = MetroFramework.MetroComboBoxWeight.Bold
        Me.RegisterAsComboBox.FormattingEnabled = True
        Me.RegisterAsComboBox.ItemHeight = 23
        Me.RegisterAsComboBox.Items.AddRange(New Object() {"BUYER", "SELLER"})
        Me.RegisterAsComboBox.Location = New System.Drawing.Point(42, 65)
        Me.RegisterAsComboBox.Name = "RegisterAsComboBox"
        Me.RegisterAsComboBox.PromptText = "REGISTER AS"
        Me.RegisterAsComboBox.Size = New System.Drawing.Size(180, 29)
        Me.RegisterAsComboBox.Style = MetroFramework.MetroColorStyle.Blue
        Me.RegisterAsComboBox.TabIndex = 0
        Me.RegisterAsComboBox.UseCustomBackColor = True
        Me.RegisterAsComboBox.UseCustomForeColor = True
        Me.RegisterAsComboBox.UseSelectable = True
        Me.RegisterAsComboBox.UseStyleColors = True
        '
        'FullnameReg
        '
        Me.FullnameReg.BackColor = System.Drawing.SystemColors.Control
        '
        '
        '
        Me.FullnameReg.CustomButton.Image = Nothing
        Me.FullnameReg.CustomButton.Location = New System.Drawing.Point(158, 1)
        Me.FullnameReg.CustomButton.Name = ""
        Me.FullnameReg.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.FullnameReg.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.FullnameReg.CustomButton.TabIndex = 1
        Me.FullnameReg.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.FullnameReg.CustomButton.UseSelectable = True
        Me.FullnameReg.CustomButton.Visible = False
        Me.FullnameReg.Lines = New String(-1) {}
        Me.FullnameReg.Location = New System.Drawing.Point(42, 121)
        Me.FullnameReg.MaxLength = 32767
        Me.FullnameReg.Name = "FullnameReg"
        Me.FullnameReg.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.FullnameReg.PromptText = "FULLNAME"
        Me.FullnameReg.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.FullnameReg.SelectedText = ""
        Me.FullnameReg.SelectionLength = 0
        Me.FullnameReg.SelectionStart = 0
        Me.FullnameReg.ShortcutsEnabled = True
        Me.FullnameReg.Size = New System.Drawing.Size(180, 23)
        Me.FullnameReg.Style = MetroFramework.MetroColorStyle.Blue
        Me.FullnameReg.TabIndex = 1
        Me.FullnameReg.UseCustomBackColor = True
        Me.FullnameReg.UseCustomForeColor = True
        Me.FullnameReg.UseSelectable = True
        Me.FullnameReg.UseStyleColors = True
        Me.FullnameReg.WaterMark = "FULLNAME"
        Me.FullnameReg.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FullnameReg.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'RegisterButton
        '
        Me.RegisterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.RegisterButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RegisterButton.DisplayFocus = True
        Me.RegisterButton.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.RegisterButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.RegisterButton.Highlight = True
        Me.RegisterButton.Location = New System.Drawing.Point(88, 292)
        Me.RegisterButton.Name = "RegisterButton"
        Me.RegisterButton.Size = New System.Drawing.Size(75, 34)
        Me.RegisterButton.Style = MetroFramework.MetroColorStyle.Silver
        Me.RegisterButton.TabIndex = 6
        Me.RegisterButton.Text = "REGISTER"
        Me.RegisterButton.UseCustomBackColor = True
        Me.RegisterButton.UseCustomForeColor = True
        Me.RegisterButton.UseSelectable = True
        Me.RegisterButton.UseStyleColors = True
        '
        'PassRepeatReg
        '
        Me.PassRepeatReg.BackColor = System.Drawing.SystemColors.Control
        '
        '
        '
        Me.PassRepeatReg.CustomButton.Image = Nothing
        Me.PassRepeatReg.CustomButton.Location = New System.Drawing.Point(158, 1)
        Me.PassRepeatReg.CustomButton.Name = ""
        Me.PassRepeatReg.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.PassRepeatReg.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.PassRepeatReg.CustomButton.TabIndex = 1
        Me.PassRepeatReg.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.PassRepeatReg.CustomButton.UseSelectable = True
        Me.PassRepeatReg.CustomButton.Visible = False
        Me.PassRepeatReg.Lines = New String(-1) {}
        Me.PassRepeatReg.Location = New System.Drawing.Point(42, 208)
        Me.PassRepeatReg.MaxLength = 32767
        Me.PassRepeatReg.Name = "PassRepeatReg"
        Me.PassRepeatReg.PasswordChar = Global.Microsoft.VisualBasic.ChrW(35)
        Me.PassRepeatReg.PromptText = "REPEAT PASSWORD"
        Me.PassRepeatReg.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.PassRepeatReg.SelectedText = ""
        Me.PassRepeatReg.SelectionLength = 0
        Me.PassRepeatReg.SelectionStart = 0
        Me.PassRepeatReg.ShortcutsEnabled = True
        Me.PassRepeatReg.Size = New System.Drawing.Size(180, 23)
        Me.PassRepeatReg.Style = MetroFramework.MetroColorStyle.Blue
        Me.PassRepeatReg.TabIndex = 5
        Me.PassRepeatReg.UseCustomBackColor = True
        Me.PassRepeatReg.UseCustomForeColor = True
        Me.PassRepeatReg.UseSelectable = True
        Me.PassRepeatReg.UseStyleColors = True
        Me.PassRepeatReg.WaterMark = "REPEAT PASSWORD"
        Me.PassRepeatReg.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.PassRepeatReg.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'PassReg
        '
        Me.PassReg.BackColor = System.Drawing.SystemColors.Control
        '
        '
        '
        Me.PassReg.CustomButton.Image = Nothing
        Me.PassReg.CustomButton.Location = New System.Drawing.Point(158, 1)
        Me.PassReg.CustomButton.Name = ""
        Me.PassReg.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.PassReg.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.PassReg.CustomButton.TabIndex = 1
        Me.PassReg.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.PassReg.CustomButton.UseSelectable = True
        Me.PassReg.CustomButton.Visible = False
        Me.PassReg.Lines = New String(-1) {}
        Me.PassReg.Location = New System.Drawing.Point(42, 179)
        Me.PassReg.MaxLength = 32767
        Me.PassReg.Name = "PassReg"
        Me.PassReg.PasswordChar = Global.Microsoft.VisualBasic.ChrW(35)
        Me.PassReg.PromptText = "PASSWORD"
        Me.PassReg.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.PassReg.SelectedText = ""
        Me.PassReg.SelectionLength = 0
        Me.PassReg.SelectionStart = 0
        Me.PassReg.ShortcutsEnabled = True
        Me.PassReg.Size = New System.Drawing.Size(180, 23)
        Me.PassReg.Style = MetroFramework.MetroColorStyle.Blue
        Me.PassReg.TabIndex = 4
        Me.PassReg.UseCustomBackColor = True
        Me.PassReg.UseCustomForeColor = True
        Me.PassReg.UseSelectable = True
        Me.PassReg.UseStyleColors = True
        Me.PassReg.WaterMark = "PASSWORD"
        Me.PassReg.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.PassReg.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'EmailReg
        '
        Me.EmailReg.BackColor = System.Drawing.SystemColors.Control
        '
        '
        '
        Me.EmailReg.CustomButton.Image = Nothing
        Me.EmailReg.CustomButton.Location = New System.Drawing.Point(158, 1)
        Me.EmailReg.CustomButton.Name = ""
        Me.EmailReg.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.EmailReg.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.EmailReg.CustomButton.TabIndex = 1
        Me.EmailReg.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.EmailReg.CustomButton.UseSelectable = True
        Me.EmailReg.CustomButton.Visible = False
        Me.EmailReg.Lines = New String(-1) {}
        Me.EmailReg.Location = New System.Drawing.Point(42, 150)
        Me.EmailReg.MaxLength = 32767
        Me.EmailReg.Name = "EmailReg"
        Me.EmailReg.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.EmailReg.PromptText = "EMAIL"
        Me.EmailReg.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.EmailReg.SelectedText = ""
        Me.EmailReg.SelectionLength = 0
        Me.EmailReg.SelectionStart = 0
        Me.EmailReg.ShortcutsEnabled = True
        Me.EmailReg.Size = New System.Drawing.Size(180, 23)
        Me.EmailReg.Style = MetroFramework.MetroColorStyle.Blue
        Me.EmailReg.TabIndex = 3
        Me.EmailReg.UseCustomBackColor = True
        Me.EmailReg.UseCustomForeColor = True
        Me.EmailReg.UseSelectable = True
        Me.EmailReg.UseStyleColors = True
        Me.EmailReg.WaterMark = "EMAIL"
        Me.EmailReg.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.EmailReg.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'ErrorProvider
        '
        Me.ErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.ErrorProvider.ContainerControl = Me
        Me.ErrorProvider.Icon = CType(resources.GetObject("ErrorProvider.Icon"), System.Drawing.Icon)
        '
        'FormLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(324, 500)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormLogin"
        Me.Padding = New System.Windows.Forms.Padding(27, 78, 27, 26)
        Me.Resizable = False
        Me.Text = "SHOP LOGIN"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents passLogin As MetroFramework.Controls.MetroTextBox
    Friend WithEvents emailLogin As MetroFramework.Controls.MetroTextBox
    Friend WithEvents submitLogin As MetroFramework.Controls.MetroButton
    Friend WithEvents PassRepeatReg As MetroFramework.Controls.MetroTextBox
    Friend WithEvents PassReg As MetroFramework.Controls.MetroTextBox
    Friend WithEvents EmailReg As MetroFramework.Controls.MetroTextBox
    Friend WithEvents RegisterButton As MetroFramework.Controls.MetroButton
    Friend WithEvents FullnameReg As MetroFramework.Controls.MetroTextBox
    Friend WithEvents loginAsComboBox As MetroFramework.Controls.MetroComboBox
    Friend WithEvents RegisterAsComboBox As MetroFramework.Controls.MetroComboBox
    Friend WithEvents ErrorProvider As ErrorProvider
    Friend WithEvents Panel1 As Panel
End Class
