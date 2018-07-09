Public Class UserControlItem2
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

    Private Sub addCart_Click(sender As Object, e As EventArgs) Handles edit.Click
        Using db As New OnlineShopEntity
            Dim result = db.barangdagangans.FirstOrDefault(Function(i) i.id_barang = Me.Name)

            Dim dialog As New TambahBarang
            With dialog
                .Text = "EDIT ITEM"
                .Name = result.id_barang
                .NameTB.Text = result.nama_barang
                .DescTB.Text = result.deskripsi
                .PriceTB.Text = result.harga
                .PictureTB.ImageLocation = result.image
                .ShowDialog()
            End With

        End Using
    End Sub

    Private Sub delete_Click(sender As Object, e As EventArgs) Handles delete.Click
        Dim dialog = MessageBox.Show(Me, "DELETE ITEM?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If dialog = DialogResult.Yes Then
            Using db As New OnlineShopEntity
                Dim result = db.barangdagangans.FirstOrDefault(Function(i) i.id_barang = Me.Name)

                With result
                    .deleted = 1
                End With

                db.SaveChangesAsync()

            End Using
            FormPenjual.refreshUI()
        End If

    End Sub
End Class
