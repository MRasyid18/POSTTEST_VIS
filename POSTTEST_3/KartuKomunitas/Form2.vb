Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblNamaValue.Text = DataModule.Nama
        lblUmurValue.Text = DataModule.Umur & " Tahun"
        lblTglLahirValue.Text = DataModule.TanggalLahir
        lblJKValue.Text = DataModule.JenisKelamin
        lblTelpValue.Text = DataModule.NoTelpon
        lblHobbyValue.Text = DataModule.Hobby
        lblAlamatValue.Text = DataModule.Alamat

        If DataModule.FotoPath <> "" Then
            picFotoKartu.Image = Image.FromFile(DataModule.FotoPath)
            picFotoKartu.SizeMode = PictureBoxSizeMode.Zoom
        End If

    End Sub

    Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
        Me.Close()
    End Sub

    Private Sub lblJudulKartu_Click(sender As Object, e As EventArgs) Handles lblJudulKartu.Click

    End Sub
End Class
