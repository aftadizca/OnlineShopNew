Public Class UserControlBill
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles total.Click

    End Sub

    Private Sub ButtonDetail_Click(sender As Object, e As EventArgs) Handles ButtonDetail.Click
        Using db As New OnlineShopEntity
            Dim result = db.users.First(Function(i) i.id = My.Settings.idUser)
            Dim result2 = db.transactions.First(Function(i) i.id_transaksi = Me.Name)
            Dim dialog As New FormCheckOut
            With dialog
                .Text = Me.Name & " - PAYMENT"
                .receiver.Text = result.nama_lengkap
                .address.Text = result.alamat
                .total.Text = formatHarga(result2.total)
                .buttonCheckout.Visible = False
                .ShowDialog()
            End With
        End Using


    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        Using db As New OnlineShopEntity
            Dim result2 = db.carts.Where(Function(i) i.id_transaksi = Me.Name)

            Dim dialog = MessageBox.Show(Me, "CANCEL TRANSACTION?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If dialog = DialogResult.Yes Then
                For Each i In result2
                    i.status = 11
                Next
                db.SaveChanges()
                FormPembeli.refreshUI()
            End If

        End Using
    End Sub

    Private Sub payConfirm_Click(sender As Object, e As EventArgs) Handles payConfirm.Click
        Using db As New OnlineShopEntity
            Dim result2 = db.carts.Where(Function(i) i.id_transaksi = Me.Name)

            Dim dialog = MessageBox.Show(Me, "PAYMENT CONFIRMATION?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If dialog = DialogResult.Yes Then
                For Each i In result2
                    i.status = 1
                Next
                db.SaveChanges()
                FormPembeli.refreshUI()
            End If

        End Using
    End Sub
End Class
