Public Class FormPenjual


    'Load list barang dagangan
    Public Sub loadListItem(ByVal search As String)
        Using db As New OnlineShopEntity
            homeFP.Controls.Clear()

            Dim result As List(Of barangdagangan)
            'jika cari Tb kosong
            If searchItem.Text = "" Then
                result = db.barangdagangans.Where(Function(i) i.deleted = 0 And i.id_penjual = My.Settings.idUser).ToList()
            Else
                result = db.barangdagangans.Where(Function(i) i.nama_barang.ToLower.Contains(search.ToLower) And i.deleted = 0 And i.id_penjual = My.Settings.idUser).ToList()
            End If

            For Each item In result
                Dim UCItem As New UserControlItem2
                UCItem.Name = item.id_barang
                UCItem.nameGood.Text = item.nama_barang
                UCItem.price.Text = formatHarga(item.harga)
                UCItem.pic.ImageLocation = item.image
                UCItem.shopName.Text = getUserName(item.id_penjual)
                UCItem.RichTextBox1.Text = item.deskripsi
                homeFP.Controls.Add(UCItem)
            Next
        End Using
    End Sub

    'load Transaksi
    Sub loadTrans(ByVal status As String)
        Using db As New OnlineShopEntity
            transFP.Controls.Clear()
            Dim result As IQueryable
            If status = "All" Then
                result = (From cart In db.carts
                          From trans In db.transactions
                          From bd In db.barangdagangans
                          Where trans.id_transaksi = cart.id_transaksi And bd.id_penjual = My.Settings.idUser And cart.status >= 2 And bd.id_barang = cart.id_barang
                          Select New With {.id_pembeli = cart.id_pembeli, .id_transaksi = trans.id_transaksi, .tanggal = trans.tanggal, .resi = cart.resi, .status = cart.status}).Distinct()
            Else
                Dim statusid = getStatusInt(status)
                result = (From cart In db.carts
                          From trans In db.transactions
                          From bd In db.barangdagangans
                          Where trans.id_transaksi = cart.id_transaksi And bd.id_penjual = My.Settings.idUser And cart.status = statusid And bd.id_barang = cart.id_barang
                          Select New With {.id_pembeli = cart.id_pembeli, .id_transaksi = trans.id_transaksi, .tanggal = trans.tanggal, .resi = cart.resi, .status = cart.status}).Distinct()
            End If


            For Each i In result
                Dim uc As New UserControlTrans
                With uc
                    .Name = i.id_pembeli
                    .namaToko.Text = getUserName(i.id_pembeli)
                    .idTransaksi.Text = i.id_transaksi
                    .tanggal.Text = i.tanggal
                    .resi.Text = i.resi
                    .status.Text = getStatus(i.status)
                    .Tag = My.Settings.Type
                    If i.status = 2 Then
                        uc.ButtonReceived.Visible = True
                        uc.ButtonReceived.Text = "PROCESS"
                    ElseIf i.status = 3 Then
                        uc.ButtonReceived.Visible = True
                        uc.ButtonReceived.Text = "SEND"
                    ElseIf i.status = 4 Then
                        uc.ButtonReceived.Visible = True
                        uc.ButtonReceived.Text = "EDIT RESI"
                    Else
                        uc.ButtonReceived.Visible = False
                    End If
                End With
                transFP.Controls.Add(uc)
            Next

        End Using
    End Sub

    'refresh ui
    Public Sub refreshUI()
        loadListItem(searchItem.Text)
        loadTrans(filterTrans.Text)
        flushMemory()
    End Sub

    Private Sub FormPembeli_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormLogin.Hide()

        'Ui set
        filterTrans.SelectedIndex = 0
        refreshUI()
        UsernameDisplay.Text = getUserName(My.Settings.idUser)
    End Sub

    Private Sub filterItem_SelectedIndexChanged(sender As Object, e As EventArgs)
        loadListItem(searchItem.Text)
    End Sub

    Private Sub searchItem_TextChanged(sender As Object, e As EventArgs) Handles searchItem.TextChanged
        loadListItem(searchItem.Text)
    End Sub

    Private Sub buttonCheckout_Click(sender As Object, e As EventArgs)
        Using db As New OnlineShopEntity
            Dim result = db.users.First(Function(i) i.id = My.Settings.idUser)
            Dim dialog As New FormCheckOut

            With dialog
                .receiver.Text = result.nama_lengkap
                .address.Text = result.alamat
                .total.Text = formatHarga(getTotalHargaCart(My.Settings.idUser))
                .ShowDialog()
            End With
        End Using

    End Sub

    Private Sub filterTrans_SelectedIndexChanged(sender As Object, e As EventArgs) Handles filterTrans.SelectedIndexChanged
        loadTrans(filterTrans.Text)
    End Sub

    Private Sub MYACCOUNTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MYACCOUNTToolStripMenuItem.Click
        Try
            Using db As New OnlineShopEntity
                Dim result = db.users.First(Function(i) i.id = My.Settings.idUser)
                Dim dialog As New MyAccount
                If My.Settings.Type = "SELLER" Then
                    dialog.LabelNama.Text = "SHOP NAME"
                End If
                dialog.Nama.Text = result.nama_lengkap
                dialog.Email.Text = result.email
                dialog.Alamat.Text = result.alamat
                dialog.JenisKelamin.SelectedItem = result.jenis_kelamin
                dialog.NamaRek.Text = result.nama_rekening
                dialog.NamaBank.Text = result.bank_rekening
                dialog.NoRek.Text = result.no_rekening

                dialog.Show()
            End Using
        Catch ex As Exception
        End Try
    End Sub

    Private Sub FormPembeli_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub LOGOUTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LOGOUTToolStripMenuItem.Click
        FormLogin.Show()
        Me.Hide()
    End Sub

    Private Sub ButtonAddItem_Click(sender As Object, e As EventArgs) Handles ButtonAddItem.Click
        TambahBarang.Show()
    End Sub

    Private Sub FormPenjual_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyData = Keys.F5 Then
            refreshUI()
        End If
    End Sub
End Class
