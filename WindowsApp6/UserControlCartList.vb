Public Class UserControlCartList
    Private Sub detail_Click(sender As Object, e As EventArgs) Handles detail.Click
        If detail.Tag = "down" Then
            detail.BackgroundImage = My.Resources.SlideUp
            detail.Tag = "up"
            Me.Height = 344
        Else
            detail.BackgroundImage = My.Resources.DownButton
            detail.Tag = "down"
            Me.Height = 139

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        updateJmlCart(+1, Me.Name)
        Using db As New OnlineShopEntity
            Dim result = db.carts.First(Function(i) i.id_barang = Me.Name And i.id_pembeli = My.Settings.idUser And i.status = 0 And i.id_transaksi = vbNullString)
            Dim bd = db.barangdagangans.FirstOrDefault(Function(i) i.id_barang = result.id_barang)
            jumlah.Text = result.jumlah
            price.Text = formatHarga(result.jumlah * bd.harga)
        End Using

        FormPembeli.loadTotalHargaCart()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        updateJmlCart(-1, Me.Name)
        Using db As New OnlineShopEntity
            Dim result = db.carts.First(Function(i) i.id_barang = Me.Name And i.id_pembeli = My.Settings.idUser And i.status = 0 And i.id_transaksi = vbNullString)
            Dim bd = db.barangdagangans.FirstOrDefault(Function(i) i.id_barang = result.id_barang)
            jumlah.Text = result.jumlah
            price.Text = formatHarga(result.jumlah * bd.harga)
        End Using

        FormPembeli.loadTotalHargaCart()
    End Sub

    Private Sub addCart_Click(sender As Object, e As EventArgs) Handles addCart.Click
        Dim dialog = MessageBox.Show(Me, "DELETE ITEM?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If dialog = DialogResult.Yes Then
            deleteCart(Me.Name)
            FormPembeli.refreshUI()
        End If
    End Sub

    Private Sub jumlah_Click(sender As Object, e As EventArgs) Handles jumlah.Click

    End Sub
End Class
