Imports System.IO

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpTanggalLahir.Format = DateTimePickerFormat.Custom
        dtpTanggalLahir.CustomFormat = "dd/MM/yyyy"
        dtpTanggalLahir.Value = DateTime.Today
    End Sub
    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        If Char.IsLetter(e.KeyChar) OrElse Char.IsWhiteSpace(e.KeyChar) OrElse Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtUmur_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUmur.KeyPress
        If Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtNoTelpon_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNoTelpon.KeyPress
        If Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Function GetHobbyDipilih() As String
        Dim checkboxes As CheckBox() = {
            chkGaming, chkCoding, chkTraveling, chkMenggambar, chkMenulis,
            chkMemancing, chkMembaca, chkOlahraga, chkMenyanyi, chkMenari,
            chkMasak, chkFotografi
        }

        Dim hobbyList As String = ""

        For Each cb As CheckBox In checkboxes
            If cb.Checked Then
                If hobbyList = "" Then
                    hobbyList = cb.Text
                Else
                    hobbyList = hobbyList & ", " & cb.Text
                End If
            End If
        Next

        Return hobbyList
    End Function

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim ofd As New OpenFileDialog()
        ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
        ofd.Title = "Pilih Foto Profil"

        If ofd.ShowDialog() = DialogResult.OK Then
            DataModule.FotoPath = ofd.FileName
            picFoto.Image = Image.FromFile(ofd.FileName)
            picFoto.SizeMode = PictureBoxSizeMode.Zoom
            lblFotoHint.Visible = False
        End If
    End Sub

    Private Sub btnCetakKartu_Click(sender As Object, e As EventArgs) Handles btnCetakKartu.Click

        If txtNama.Text.Trim() = "" Then
            MessageBox.Show("Inputan tidak boleh kosong: Nama belum diisi!", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNama.Focus()
            Return
        End If

        If txtUmur.Text.Trim() = "" Then
            MessageBox.Show("Inputan tidak boleh kosong: Umur belum diisi!", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtUmur.Focus()
            Return
        End If

        If txtNoTelpon.Text.Trim() = "" Then
            MessageBox.Show("Inputan tidak boleh kosong: No Telpon belum diisi!", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNoTelpon.Focus()
            Return
        End If

        If txtAlamat.Text.Trim() = "" Then
            MessageBox.Show("Inputan tidak boleh kosong: Alamat belum diisi!", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtAlamat.Focus()
            Return
        End If

        If Not rbLakiLaki.Checked AndAlso Not rbPerempuan.Checked Then
            MessageBox.Show("Inputan tidak boleh kosong: Jenis Kelamin belum dipilih!", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim hobbyResult As String = GetHobbyDipilih()
        If hobbyResult = "" Then
            MessageBox.Show("Inputan tidak boleh kosong: Pilih minimal 1 Hobby!", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If DataModule.FotoPath = "" Then
            MessageBox.Show("Inputan tidak boleh kosong: Foto profil belum dipilih!", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        DataModule.Nama = txtNama.Text.Trim()
        DataModule.Umur = txtUmur.Text.Trim()
        DataModule.TanggalLahir = dtpTanggalLahir.Value.ToString("dd/MM/yyyy")

        If rbLakiLaki.Checked Then
            DataModule.JenisKelamin = "Laki-Laki"
        Else
            DataModule.JenisKelamin = "Perempuan"
        End If

        DataModule.NoTelpon = txtNoTelpon.Text.Trim()
        DataModule.Alamat = txtAlamat.Text.Trim()
        DataModule.Hobby = hobbyResult

        Dim f2 As New Form2()
        f2.ShowDialog()
    End Sub

End Class
