Public Class UserControlTrans
    Private Sub UserControlTrans_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ButtonDetail_Click(sender As Object, e As EventArgs) Handles ButtonDetail.Click
        If Me.Tag = "BUYER" Then
            Using db As New OnlineShopEntity
                Dim result = db.users.First(Function(i) i.id = My.Settings.idUser)
                Dim result2 = db.transactions.First(Function(i) i.id_transaksi = idTransaksi.Text)
                Dim dialog As New FormCheckOut
                With dialog
                    .Text = idTransaksi.Text & " - " & getUserName(Me.Name)
                    .receiver.Text = result.nama_lengkap
                    .address.Text = result.alamat
                    '.total.Text = formatHarga(result2.total)
                    .buttonCheckout.Visible = False
                    .Panel2.Visible = False
                    .loadListCart(Me.Name, idTransaksi.Text)
                    .ShowDialog()
                End With
            End Using
        ElseIf Me.Tag = "SELLER" Then
            Using db As New OnlineShopEntity
                Dim result = db.users.First(Function(i) i.id = Me.Name)
                Dim result2 = db.transactions.First(Function(i) i.id_transaksi = idTransaksi.Text)
                Dim dialog As New FormCheckOut
                With dialog
                    .Text = idTransaksi.Text & " - " & getUserName(Me.Name)
                    .receiver.Text = result.nama_lengkap
                    .address.Text = result.alamat
                    '.total.Text = formatHarga(result2.total)
                    .buttonCheckout.Visible = False
                    .Panel2.Visible = False
                    .loadListCartPenjual(idTransaksi.Text)
                    .ShowDialog()
                End With
            End Using
        End If

    End Sub

    Private Sub ButtonReceived_Click(sender As Object, e As EventArgs) Handles ButtonReceived.Click
        Using db As New OnlineShopEntity
            Dim result = From bd In db.barangdagangans
                         From cart In db.carts
                         Where bd.id_barang = cart.id_barang And cart.id_transaksi = idTransaksi.Text And bd.id_penjual = My.Settings.idUser
                         Select cart

            Dim result2 = From bd In db.barangdagangans
                          From cart In db.carts
                          Where bd.id_barang = cart.id_barang And cart.id_transaksi = idTransaksi.Text And bd.id_penjual = Me.Name
                          Select cart

            If ButtonReceived.Text = "PROCESS" Then
                For Each i In result
                    i.status = 3
                Next
            ElseIf ButtonReceived.Text = "SEND" Then
                Dim resi = InputBox("Input Resi", "Input Resi", "")
                If resi <> vbNullString Then
                    For Each i In result
                        i.resi = resi
                        i.status = 4
                    Next
                End If
            ElseIf ButtonReceived.Text = "EDIT RESI" Then
                Dim resi = InputBox("Input Resi", "Input Resi", "")
                If resi <> vbNullString Then
                    For Each i In result
                        i.resi = resi
                    Next
                End If
            ElseIf ButtonReceived.Text = "RECEIVE" Then
                Dim dialog = MessageBox.Show(Me, "Receive package??", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                If dialog = DialogResult.Yes Then
                    For Each i In result2
                        i.status = 5
                    Next
                End If
            End If

            db.SaveChanges()
        End Using
        FormPenjual.refreshUI()
        FormPembeli.refreshUI()
    End Sub
End Class
