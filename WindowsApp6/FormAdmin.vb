Public Class FormAdmin

    Sub loadTransAdmin(ByVal status As String)
        Using db As New OnlineShopEntity
            transFP.Controls.Clear()
            Dim result As IQueryable
            If status = "All" Then
                result = (From cart In db.carts
                          From trans In db.transactions
                          From user In db.users
                          Where trans.id_transaksi = cart.id_transaksi And cart.id_pembeli = user.id And cart.status >= 1 And cart.status <= 2
                          Select New With {.id_pembeli = cart.id_pembeli, .id_transaksi = trans.id_transaksi, .tanggal = trans.tanggal, .status = cart.status, .total = trans.total, .nama_bank = user.bank_rekening, .nama_rekening = user.nama_rekening, .no_rek = user.no_rekening}).Distinct()
            Else
                Dim statusid = getStatusInt(status)
                result = (From cart In db.carts
                          From trans In db.transactions
                          From user In db.users
                          Where trans.id_transaksi = cart.id_transaksi And cart.id_pembeli = user.id And cart.status = statusid
                          Select New With {.id_pembeli = cart.id_pembeli, .id_transaksi = trans.id_transaksi, .tanggal = trans.tanggal, .status = cart.status, .total = trans.total, .nama_bank = user.bank_rekening, .nama_rekening = user.nama_rekening, .no_rek = user.no_rekening}).Distinct()
            End If


            For Each i In result
                Dim uc As New UserControlAdmin
                With uc
                    .Name = i.id_transaksi
                    .namaPembeli.Text = getUserName(i.id_pembeli)
                    .idTransaksi.Text = i.id_transaksi
                    .tanggal.Text = i.tanggal
                    .bankName.Text = i.nama_bank
                    .senderName.Text = i.nama_rekening
                    .noBank.Text = i.no_rek
                    .paid.Text = formatHarga(i.total)
                    .status.Text = getStatus(i.status)
                    If i.status = 1 Then
                        uc.ButtonVerify.Enabled = True
                    Else
                        uc.ButtonVerify.Enabled = False
                        uc.ButtonVerify.Text = "VERIFIED"
                        uc.ButtonVerify.BackColor = Color.Green
                    End If
                End With
                transFP.Controls.Add(uc)
            Next

        End Using
    End Sub

    'refresh ui
    Public Sub refreshUI()
        loadTransAdmin(filterTrans.Text)
    End Sub

    Private Sub FormPembeli_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormLogin.Hide()
        filterTrans.SelectedIndex = 0
        UsernameDisplay.Text = getUserName(My.Settings.idUser)
        'Ui set
        refreshUI()
    End Sub

    Private Sub filterTrans_SelectedIndexChanged(sender As Object, e As EventArgs) Handles filterTrans.SelectedIndexChanged
        loadTransAdmin(filterTrans.Text)
    End Sub

    Private Sub FormAdmin_FormClosed(sender As Object, e As FormClosedEventArgs)
        Application.Exit()
    End Sub

    Private Sub LOGOUTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LOGOUTToolStripMenuItem.Click
        FormLogin.Show()
        Me.Hide()
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

                dialog.ShowDialog()
            End Using
        Catch ex As Exception
        End Try
    End Sub

    Private Sub FormAdmin_FormClosed_1(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class
