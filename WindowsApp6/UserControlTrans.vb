Public Class UserControlTrans
    Private Sub UserControlTrans_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ButtonDetail_Click(sender As Object, e As EventArgs) Handles ButtonDetail.Click
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

    Private Sub ButtonReceived_Click(sender As Object, e As EventArgs) Handles ButtonReceived.Click

    End Sub
End Class
