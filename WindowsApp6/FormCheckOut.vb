Public Class FormCheckOut
    'load list barang
    Public Sub loadListCart(ByVal id_transaksi As String)
        Using db As New OnlineShopEntity
            checkoutDetailFP.Controls.Clear()
            Dim result = (From cart In db.carts
                          From bd In db.barangdagangans
                          Where bd.id_barang = cart.id_barang And cart.id_pembeli = My.Settings.idUser And cart.status = 0 And cart.id_transaksi = id_transaksi
                          Select New With {.id_barang = cart.id_barang, .id_penjual = bd.id_penjual, .nama_barang = bd.nama_barang, .jumlah = cart.jumlah, .harga = bd.harga * cart.jumlah, .image = bd.image, .deskripsi = bd.deskripsi}).ToList()

            For Each item In result
                Dim UCItem As New UserControlCartList
                UCItem.Name = item.id_barang
                UCItem.nameGood.Text = item.nama_barang
                UCItem.price.Text = formatHarga(item.harga)
                UCItem.pic.ImageLocation = item.image
                UCItem.shopName.Text = getUserName(item.id_penjual)
                UCItem.RichTextBox1.Text = item.deskripsi
                UCItem.jumlah.Text = item.jumlah.ToString
                UCItem.Button2.Visible = False
                UCItem.Button1.Visible = False
                UCItem.addCart.Visible = False
                checkoutDetailFP.Controls.Add(UCItem)
            Next
        End Using
    End Sub

    Public Sub loadListCart(ByVal id_penjual As String, ByVal id_pembeli As String)
        Using db As New OnlineShopEntity
            checkoutDetailFP.Controls.Clear()
            Dim result = (From cart In db.carts
                          From bd In db.barangdagangans
                          Where bd.id_barang = cart.id_barang And cart.id_pembeli = My.Settings.idUser And cart.status = 0 And bd.id_penjual = id_penjual
                          Select New With {.id_barang = cart.id_barang, .id_penjual = bd.id_penjual, .nama_barang = bd.nama_barang, .jumlah = cart.jumlah, .harga = bd.harga * cart.jumlah, .image = bd.image, .deskripsi = bd.deskripsi}).ToList()

            For Each item In result
                Dim UCItem As New UserControlCartList
                UCItem.Name = item.id_barang
                UCItem.nameGood.Text = item.nama_barang
                UCItem.price.Text = formatHarga(item.harga)
                UCItem.pic.ImageLocation = item.image
                UCItem.shopName.Text = getUserName(item.id_penjual)
                UCItem.RichTextBox1.Text = item.deskripsi
                UCItem.jumlah.Text = item.jumlah.ToString
                UCItem.Button2.Visible = False
                UCItem.Button1.Visible = False
                UCItem.addCart.Visible = False
                checkoutDetailFP.Controls.Add(UCItem)
            Next
        End Using
    End Sub

    Private Sub FormCheckOut_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Me.Text = "CHECKOUT" Then
            loadListCart(vbNullString)
        ElseIf Me.Text.Contains("PAYMENT") Then
            loadListCart(Me.Text.Replace(" - PAYMENT", ""))
        End If

    End Sub

    Private Sub buttonCheckout_Click(sender As Object, e As EventArgs) Handles buttonCheckout.Click
        Using db As New OnlineShopEntity

            Dim result = db.carts.Where(Function(i) i.id_pembeli = My.Settings.idUser And i.status = 0 And i.id_transaksi = vbNullString)

            Dim id_trans = makeIdTransaction()

            For Each i In result
                i.id_transaksi = id_trans
            Next

            Dim tran As New transaction
            With tran
                .id_transaksi = id_trans
                .tanggal = DateAndTime.Now
                .total = total.Text.Replace("Rp. ", "").Replace(",", "")
            End With
            db.transactions.Add(tran)
            db.SaveChanges()
        End Using
        FormPembeli.refreshUI()
        Me.Dispose()
    End Sub

    Private Sub resi_TextChanged(sender As Object, e As EventArgs)

    End Sub
End Class