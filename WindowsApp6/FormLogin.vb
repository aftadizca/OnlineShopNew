Imports System.Security.Cryptography

Public Class FormLogin

    Dim db As New OnlineShopEntity


    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RegisterAsComboBox.SelectedIndex = 0
        loginAsComboBox.SelectedIndex = 0

        If My.Settings.idUser <> vbNullString Then
            If My.Settings.Type = "BUYER" Then
                FormPembeli.ShowDialog()
            ElseIf My.Settings.Type = "ADMIN" Then
                FormAdmin.ShowDialog()
            ElseIf My.Settings.Type = "SELLER" Then
                FormPenjual.ShowDialog()
            End If

        End If


    End Sub

    Private Sub submitLogin_Click(sender As Object, e As EventArgs) Handles submitLogin.Click

        If Not validEmpty(emailLogin, "Email is required", ErrorProvider) Or
            Not validEmpty(passLogin, "Password is required", ErrorProvider) Or
            Not validEmpty(loginAsComboBox, "Select one", ErrorProvider) Then

        Else
            Using db As New OnlineShopEntity
                Dim temp = hashPass(emailLogin.Text, passLogin.Text)
                Dim check = (From g In db.users
                             Select g Where g.email = emailLogin.Text _
                                              And g.password = temp _
                                              And g.tipe = loginAsComboBox.Text).ToList()
                If check.Count > 0 Then
                    My.Settings.idUser = check.Item(0).id
                    'My.Settings.Email = check.Item(0).email
                    My.Settings.Type = loginAsComboBox.Text
                    If loginAsComboBox.Text = "BUYER" Then
                        FormPembeli.ShowDialog()
                    ElseIf loginAsComboBox.Text = "ADMIN" Then
                        FormAdmin.ShowDialog()
                    ElseIf loginAsComboBox.Text = "SELLER" Then
                        FormPenjual.ShowDialog()
                    End If
                Else
                    MessageBox.Show("Login Gagal")
                End If
            End Using

        End If

    End Sub

    Private Sub RegisterButton_Click(sender As Object, e As EventArgs) Handles RegisterButton.Click


        If Not validEmpty(PassReg, "Password is required", ErrorProvider) Or
            Not validEmpty(FullnameReg, "Fullname is required", ErrorProvider) Or
            Not validEmpty(EmailReg, "Email is required", ErrorProvider) Or
            Not validEmpty(PassRepeatReg, "Re-enter your password", ErrorProvider) Or
            Not validEmpty(RegisterAsComboBox, "Select one", ErrorProvider) Then
        Else
            Try
                Dim user As New user
                If RegisterAsComboBox.Text = "BUYER" Then
                    user.id = makeIdBuyyer()
                Else
                    user.id = makeIdSeller()
                End If
                user.tipe = RegisterAsComboBox.Text
                user.nama_lengkap = FullnameReg.Text
                user.email = EmailReg.Text
                user.password = hashPass(EmailReg.Text, PassReg.Text)
                user.timestamp = Date.Now

                db.users.Add(user)
                db.SaveChanges()

                MessageBox.Show("Registrasi Sukses")

                PassRepeatReg.Clear()
                clearError(PassRepeatReg, ErrorProvider)
                PassReg.Clear()
                FullnameReg.Clear()
                EmailReg.Clear()
                clearError(EmailReg, ErrorProvider)

            Catch ex As Exception
                MessageBox.Show(ex.ToString)
                MessageBox.Show("Registrasi Gagal")
            End Try
        End If

    End Sub

    Private Sub EmailReg_TextChanged(sender As Object, e As EventArgs) Handles EmailReg.TextChanged
        If EmailReg.Text.IndexOf("@") > -1 Then
            If EmailReg.Text.IndexOf(".", EmailReg.Text.IndexOf("@")) > EmailReg.Text.IndexOf("@") Then
                Dim check = db.users.Where(Function(i) i.email = EmailReg.Text And i.tipe = RegisterAsComboBox.Text).ToList()
                If check.Count > 0 Then
                    addError(EmailReg, "Email has been used", ErrorProvider)
                Else
                    clearError(EmailReg, ErrorProvider)
                End If
            Else
                addError(EmailReg, "Invalid email. Example 'example@example.com'", ErrorProvider)
            End If
        Else
            addError(EmailReg, "Invalid email. Example 'example@example.com'", ErrorProvider)
        End If




    End Sub

    Private Sub PassRepeatReg_TextChanged(sender As Object, e As EventArgs) Handles PassRepeatReg.TextChanged
        If PassReg.Text <> PassRepeatReg.Text Then
            addError(PassRepeatReg, "Input password is different", ErrorProvider)
        Else
            clearError(PassRepeatReg, ErrorProvider)
        End If
    End Sub

    Private Sub RegisterAsComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RegisterAsComboBox.SelectedIndexChanged
        If RegisterAsComboBox.Text = "SELLER" Then
            FullnameReg.WaterMark = "SHOP NAME"
        Else
            FullnameReg.WaterMark = "FULLNAME"
        End If
    End Sub

    Private Sub FormLogin_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub passLogin_KeyDown(sender As Object, e As KeyEventArgs) Handles passLogin.KeyDown
        If e.KeyCode = Keys.Enter Then
            submitLogin.PerformClick()
        End If
    End Sub
End Class