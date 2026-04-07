Public Class FormKartu
    Private Sub FormKartu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilkanData()
    End Sub
    Private Sub TampilkanData()
        lblNamaKartu.Text = DataModule.NamaAnggota
        lblIdKartu.Text = "ID:" & DataModule.IdAnggota
        lblKomunitasKartu.Text = DataModule.JenisKomunitas & " — " & DataModule.Peran
        lblTelpKartu.Text = DataModule.NomorTelepon & vbCrLf & "✉ " & DataModule.Email
        lblHobiKartu.Text = DataModule.DaftarHobi

        If DataModule.FotoPath <> "" AndAlso IO.File.Exists(DataModule.FotoPath) Then
            Try
                picFotoKartu.Image = Image.FromFile(DataModule.FotoPath)
                picFotoKartu.SizeMode = PictureBoxSizeMode.Zoom
            Catch ex As Exception
            End Try
        Else
            picFotoKartu.Image = Nothing
        End If
    End Sub
    Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
        Me.Close()
    End Sub

End Class