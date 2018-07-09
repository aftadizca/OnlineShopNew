Public Class UserControlAdmin
    Private Sub UserControlTrans_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ButtonDetail_Click(sender As Object, e As EventArgs)
        Using db As New OnlineShopEntity
            Dim result = db.users.First(Function(i) i.id = My.Settings.idUser)
            Dim result2 = db.transactions.First(Function(i) i.id_transaksi = idTransaksi.Text)
            Dim dialog As New FormCheckOut
            With dialog
                .Text = idTransaksi.Text & " - " & getUserName(Me.Name)
                .receiver.Text = result.nama_lengkap
                .address.Text = result.alamat
                .total.Text = formatHarga(result2.total)
                .buttonCheckout.Visible = False
                .Panel2.Visible = False
                .loadListCart(Me.Name, My.Settings.idUser)
                .ShowDialog()
            End With
        End Using
    End Sub

    Private Sub ButtonVerify_Click(sender As Object, e As EventArgs) Handles ButtonVerify.Click
        Using db As New OnlineShopEntity
            Dim result2 = db.carts.Where(Function(i) i.id_transaksi = Me.Name)

            Dim dialog = MessageBox.Show(Me, "VERIFIED?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If dialog = DialogResult.Yes Then
                For Each i In result2
                    i.status = 2
                Next
                db.SaveChanges()
                FormAdmin.refreshUI()
            End If

        End Using
    End Sub
End Class
