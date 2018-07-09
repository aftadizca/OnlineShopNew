Imports System.Security.Cryptography

Public Class MyAccount
    Dim db As New OnlineShopEntity

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Dispose()
    End Sub

    Private Sub Save_Click(sender As Object, e As EventArgs) Handles Save.Click
        Try
            Dim result = db.users.First(Function(i) i.id = My.Settings.idUser)
            If hashPass(result.email, Password.Text) = result.password Then
                result.nama_lengkap = Nama.Text
                result.email = Email.Text
                result.alamat = Alamat.Text
                result.jenis_kelamin = JenisKelamin.SelectedItem
                result.nama_rekening = NamaRek.Text
                result.bank_rekening = NamaBank.Text
                result.no_rekening = NoRek.Text

                If RPass.Text <> NewPass.Text Then
                    MessageBox.Show(Me, "PASSWORD NOT MATCH!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                ElseIf RPass.Text = vbNullString And NewPass.Text = vbNullString Then
                Else
                    result.password = NewPass.Text
                End If

                db.SaveChanges()
                MessageBox.Show(Me, "SAVED!", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else
                MessageBox.Show(Me, "WRONG PASSWORD!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub
End Class