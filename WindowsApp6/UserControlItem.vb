Public Class UserControlItem
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles nameGood.Click

    End Sub

    Private Sub detail_Click(sender As Object, e As EventArgs) Handles detail.Click
        If detail.Tag = "down" Then
            detail.BackgroundImage = My.Resources.SlideUp
            detail.Tag = "up"
            Me.Height = 354
        Else
            detail.BackgroundImage = My.Resources.DownButton
            detail.Tag = "down"
            Me.Height = 149

        End If
    End Sub

    Private Sub addCart_Click(sender As Object, e As EventArgs) Handles addCart.Click
        Using db As New OnlineShopEntity
            Dim result = db.carts.FirstOrDefault(Function(i) i.id_pembeli = My.Settings.idUser And i.id_barang = Me.Name And i.status = 0 And i.id_transaksi = vbNullString)

            Dim _cart As New cart

            If result Is Nothing Then
                _cart.id_barang = Me.Name
                _cart.id_pembeli = My.Settings.idUser
                _cart.jumlah = 1
                _cart.status = 0
                _cart.resi = "Not Available"
                db.carts.Add(_cart)
                db.SaveChanges()
                MessageBox.Show("Successfully Add to Cart!")
                FormPembeli.loadListCart()
            Else
                result.jumlah += 1
                db.SaveChanges()
                MessageBox.Show("Successfully Add to Cart!")
                FormPembeli.loadListCart()
            End If

        End Using
    End Sub
End Class
