Public Class TambahBarang
    Dim db As New OnlineShopEntity

    Public Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Me.Text.Contains("ADD") Then
            If NameTB.Text <> vbNullString _
           And DescTB.Text <> vbNullString _
           And Price.Text <> vbNullString _
           And PictureTB.ImageLocation <> vbNullString Then

                Dim barang As New barangdagangan
                Dim hargaTemp = ULong.Parse(PriceTB.Text)
                barang.id_barang = makeIdItem()
                barang.id_penjual = My.Settings.idUser
                barang.nama_barang = NameTB.Text
                barang.deskripsi = DescTB.Text
                barang.harga = hargaTemp
                barang.image = PictureTB.ImageLocation
                barang.tanggal_upload = Date.Now
                barang.deleted = 0

                db.barangdagangans.Add(barang)
                db.SaveChanges()
                MessageBox.Show("Saved!")
                Me.Close()
                FormPenjual.refreshUI()
            Else
                MessageBox.Show("Incomplete Item Information!")
            End If
        Else
            If NameTB.Text <> vbNullString _
            And DescTB.Text <> vbNullString _
            And Price.Text <> vbNullString _
            And PictureTB.ImageLocation <> vbNullString Then

                Dim result = db.barangdagangans.First(Function(i) i.id_barang = Me.Name)

                Dim hargaTemp = ULong.Parse(PriceTB.Text)
                result.id_penjual = My.Settings.idUser
                result.nama_barang = NameTB.Text
                result.deskripsi = DescTB.Text
                result.harga = hargaTemp
                result.image = PictureTB.ImageLocation
                result.tanggal_upload = Date.Now
                db.SaveChanges()
                MessageBox.Show("Saved!")
                FormPenjual.refreshUI()

            End If
        End If

    End Sub

    Private Sub PictureTB_Click(sender As Object, e As EventArgs) Handles PictureTB.Click
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Title = "Find Image"
        OpenFileDialog1.Filter = "Image Files(*.PNG;*.JPG)|*.PNG;*.JPG"
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            PictureTB.ImageLocation = OpenFileDialog1.FileName
        End If

    End Sub

End Class