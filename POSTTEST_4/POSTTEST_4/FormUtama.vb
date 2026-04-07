Imports System.IO

Public Class FormUtama
    Private Sub FormUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tabControlUtama.SelectedTab = tabDataUtama
        cmbKomunitas.SelectedIndex = 0
    End Sub

    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) _
        Handles txtNama.KeyPress
        If Char.IsLetter(e.KeyChar) OrElse
           Char.IsWhiteSpace(e.KeyChar) OrElse
           Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub mtbTelepon_Leave(sender As Object, e As EventArgs) _
        Handles mtbTelepon.Leave
        If Not mtbTelepon.MaskCompleted Then
            ErrorProvider1.SetError(mtbTelepon,
                "Nomor HP harus lengkap, contoh: 0812-3456-7890")
        Else
            ErrorProvider1.SetError(mtbTelepon, "")
        End If
    End Sub

    Private Function ValidasiSemua() As Boolean
        ErrorProvider1.Clear()
        Dim ada_error As Boolean = False
        Dim pesanError As String = "Inputan tidak boleh kosong:" & vbCrLf & vbCrLf

        If txtNama.Text.Trim() = "" Then
            ErrorProvider1.SetError(txtNama, "Inputan tidak boleh kosong")
            pesanError &= "• Nama tidak boleh kosong" & vbCrLf
            ada_error = True
        End If

        If txtIdAnggota.Text.Trim() = "" Then
            ErrorProvider1.SetError(txtIdAnggota, "Inputan tidak boleh kosong")
            pesanError &= "• ID Anggota tidak boleh kosong" & vbCrLf
            ada_error = True
        End If

        If cmbKomunitas.SelectedIndex <= 0 Then
            pesanError &= "• Jenis Komunitas harus dipilih" & vbCrLf
            ada_error = True
        End If

        If Not mtbTelepon.MaskCompleted Then
            ErrorProvider1.SetError(mtbTelepon,
                "Format nomor HP harus lengkap")
            pesanError &= "• Nomor Telepon harus lengkap (0812-3456-7890)" & vbCrLf
            ada_error = True
        End If

        If txtEmail.Text.Trim() = "" Then
            ErrorProvider1.SetError(txtEmail, "Inputan tidak boleh kosong")
            pesanError &= "• Email tidak boleh kosong" & vbCrLf
            ada_error = True
        End If

        If txtAlamat.Text.Trim() = "" Then
            ErrorProvider1.SetError(txtAlamat, "Inputan tidak boleh kosong")
            pesanError &= "• Alamat tidak boleh kosong" & vbCrLf
            ada_error = True
        End If

        Dim adaHobiDipilih As Boolean = (
            chkCoding.Checked Or chkDesain.Checked Or
            chkAI.Checked Or chkGame.Checked Or
            chkData.Checked Or chkHacking.Checked Or
            chkMobile.Checked Or chkCloud.Checked
        )
        If Not adaHobiDipilih Then
            pesanError &= "• Inputan tidak boleh kosong (pilih minimal 1 hobi)" & vbCrLf
            ada_error = True
        End If

        If ada_error Then
            MessageBox.Show(pesanError, "VALIDASI GAGAL",
                MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        Return True
    End Function

    Private Sub KumpulkanData()
        ' Tab 1
        DataModule.NamaAnggota = txtNama.Text.Trim()
        DataModule.IdAnggota = txtIdAnggota.Text.Trim()
        DataModule.TanggalLahir = dtpTanggalLahir.Value.ToString("dd MMMM yyyy")
        DataModule.JenisKelamin = If(rbLaki.Checked, "Laki-laki", "Perempuan")
        DataModule.JenisKomunitas = cmbKomunitas.Text

        ' Tab 2
        DataModule.NomorTelepon = mtbTelepon.Text
        DataModule.Email = txtEmail.Text.Trim()
        DataModule.Alamat = txtAlamat.Text.Trim()

        ' Tab 3
        If rbKetua.Checked Then
            DataModule.Peran = "Ketua"
        ElseIf rbAnggota.Checked Then
            DataModule.Peran = "Wakil Ketua"
        ElseIf rbAdmin.Checked Then
            DataModule.Peran = "Admin"
        Else
            DataModule.Peran = "Anggota"
        End If

        Dim hobi As New List(Of String)
        If chkCoding.Checked Then hobi.Add("Coding")
        If chkDesain.Checked Then hobi.Add("UI/UX Design")
        If chkGame.Checked Then hobi.Add("Game")
        If chkData.Checked Then hobi.Add("Data Analysis")
        If chkMobile.Checked Then hobi.Add("Mobile Development")
        If chkHacking.Checked Then hobi.Add("Hacking")
        If chkCloud.Checked Then hobi.Add("Cloud Computing")
        If chkAI.Checked Then hobi.Add("AI")
        DataModule.DaftarHobi = String.Join(", ", hobi)
    End Sub

    Private Sub btnLanjut1_Click(sender As Object, e As EventArgs) _
        Handles btnLanjut1.Click
        tabControlUtama.SelectedTab = tabKontak
    End Sub

    Private Sub btnKembali2_Click(sender As Object, e As EventArgs) _
        Handles btnKembali2.Click
        tabControlUtama.SelectedTab = tabDataUtama
    End Sub

    Private Sub btnLanjut2_Click(sender As Object, e As EventArgs) _
        Handles btnLanjut2.Click
        tabControlUtama.SelectedTab = tabProfil
    End Sub

    Private Sub btnKembali3_Click(sender As Object, e As EventArgs) _
        Handles btnKembali3.Click
        tabControlUtama.SelectedTab = tabKontak
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        OpenFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
        OpenFileDialog1.Title = "Pilih Foto Profil"

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            Try
                Dim folderPath As String = Path.Combine(Application.StartupPath, "Foto")
                If Not Directory.Exists(folderPath) Then
                    Directory.CreateDirectory(folderPath)
                End If

                Dim ext As String = Path.GetExtension(OpenFileDialog1.FileName)
                Dim fileName As String = "foto_" & DateTime.Now.Ticks & ext
                Dim destPath As String = Path.Combine(folderPath, fileName)

                File.Copy(OpenFileDialog1.FileName, destPath, True)
                DataModule.FotoPath = destPath
                picFotoProfil.Image = Image.FromFile(destPath)
                picFotoProfil.SizeMode = PictureBoxSizeMode.Zoom
            Catch ex As Exception
                MessageBox.Show("Gagal memuat gambar: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnSimpanCetak_Click(sender As Object, e As EventArgs) _
        Handles btnSimpanCetak.Click

        If Not ValidasiSemua() Then Exit Sub
        Dim hasil As DialogResult = MessageBox.Show(
            "Konfirmasi: Simpan data dan tampilkan kartu komunitas?",
            "KONFIRMASI CETAK KARTU",
            MessageBoxButtons.YesNoCancel,
            MessageBoxIcon.Question)

        If hasil = DialogResult.Yes Then
            KumpulkanData()
            Dim fKartu As New FormKartu()
            fKartu.Show()
        ElseIf hasil = DialogResult.No Then
            MessageBox.Show("Pembuatan kartu dibatalkan.",
                "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf hasil = DialogResult.Cancel Then
            MessageBox.Show("Proses dibatalkan.",
                "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub InputDataToolStripMenuItem_Click(sender As Object,
        e As EventArgs) Handles InputDataToolStripMenuItem.Click
        Me.Show()
        Me.BringToFront()
        tabControlUtama.SelectedTab = tabDataUtama
    End Sub

    Private Sub LihatKartuToolStripMenuItem_Click(sender As Object,
        e As EventArgs) Handles LihatKartuToolStripMenuItem.Click
        If DataModule.NamaAnggota = "" Then
            MessageBox.Show(
                "Belum ada data. Silakan isi data terlebih dahulu.",
                "DATA KOSONG",
                MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        Dim fKartu As New FormKartu()
        fKartu.Show()
    End Sub

    Private Sub SimpanDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SimpanDataToolStripMenuItem.Click
        If Not ValidasiSemua() Then Exit Sub
        KumpulkanData()

        Dim konfirmasi As DialogResult = MessageBox.Show(
            "Apakah data ingin disimpan?",
            "SIMPAN DATA",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question)

        If konfirmasi = DialogResult.Yes Then
            SaveFileDialog1.Filter = "Text File|*.txt|CSV File|*.csv"
            SaveFileDialog1.Title = "Simpan Data Anggota"
            SaveFileDialog1.FileName = "data_" & DataModule.IdAnggota

            If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
                Try
                    Dim ext As String = Path.GetExtension(SaveFileDialog1.FileName).ToLower()
                    Dim content As String = ""

                    If ext = ".csv" Then
                        content = "Nama,ID,Tanggal Lahir,Jenis Kelamin,Komunitas,Telepon,Email,Alamat,Peran,Hobi" & vbCrLf
                        content &= $"""{DataModule.NamaAnggota}"",""{DataModule.IdAnggota}"",""{DataModule.TanggalLahir}"",""{DataModule.JenisKelamin}"",""{DataModule.JenisKomunitas}"",""{DataModule.NomorTelepon}"",""{DataModule.Email}"",""{DataModule.Alamat}"",""{DataModule.Peran}"",""{DataModule.DaftarHobi}"""
                    Else
                        content = "===== DATA ANGGOTA NEXUS COMMUNITY =====" & vbCrLf
                        content &= "Nama          : " & DataModule.NamaAnggota & vbCrLf
                        content &= "ID Anggota    : " & DataModule.IdAnggota & vbCrLf
                        content &= "Tanggal Lahir : " & DataModule.TanggalLahir & vbCrLf
                        content &= "Jenis Kelamin : " & DataModule.JenisKelamin & vbCrLf
                        content &= "Komunitas     : " & DataModule.JenisKomunitas & vbCrLf
                        content &= "Telepon       : " & DataModule.NomorTelepon & vbCrLf
                        content &= "Email         : " & DataModule.Email & vbCrLf
                        content &= "Alamat        : " & DataModule.Alamat & vbCrLf
                        content &= "Peran         : " & DataModule.Peran & vbCrLf
                        content &= "Hobi          : " & DataModule.DaftarHobi & vbCrLf
                        content &= "Dibuat        : " & DateTime.Now.ToString("dd/MM/yyyy HH:mm")
                    End If

                    IO.File.WriteAllText(SaveFileDialog1.FileName, content, System.Text.Encoding.UTF8)
                    MessageBox.Show("File berhasil disimpan ke:" & vbCrLf & SaveFileDialog1.FileName, "SIMPAN BERHASIL", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show("Gagal menyimpan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End If
    End Sub

    Private Sub BukaDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BukaDataToolStripMenuItem.Click
        OpenFileDialog1.Filter = "Text File|*.txt|CSV File|*.csv|All Files|*.*"
        OpenFileDialog1.Title = "Buka Data Anggota"
        OpenFileDialog1.FileName = ""

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            Try
                Dim content As String = IO.File.ReadAllText(OpenFileDialog1.FileName, System.Text.Encoding.UTF8)
                Dim ext As String = Path.GetExtension(OpenFileDialog1.FileName).ToLower()

                If ext = ".txt" Then
                    Dim lines() As String = content.Split(vbCrLf)
                    For Each line As String In lines
                        If line.StartsWith("Nama          :") Then DataModule.NamaAnggota = line.Substring(16).Trim()
                        If line.StartsWith("ID Anggota    :") Then DataModule.IdAnggota = line.Substring(16).Trim()
                        If line.StartsWith("Komunitas     :") Then DataModule.JenisKomunitas = line.Substring(16).Trim()
                        If line.StartsWith("Telepon       :") Then DataModule.NomorTelepon = line.Substring(16).Trim()
                        If line.StartsWith("Email         :") Then DataModule.Email = line.Substring(16).Trim()
                        If line.StartsWith("Alamat        :") Then DataModule.Alamat = line.Substring(16).Trim()
                        If line.StartsWith("Peran         :") Then DataModule.Peran = line.Substring(16).Trim()
                        If line.StartsWith("Hobi          :") Then DataModule.DaftarHobi = line.Substring(16).Trim()
                    Next
                End If

                txtNama.Text = DataModule.NamaAnggota
                txtIdAnggota.Text = DataModule.IdAnggota
                txtEmail.Text = DataModule.Email
                txtAlamat.Text = DataModule.Alamat

                MessageBox.Show("Data berhasil dibuka!" & vbCrLf & "Nama: " & DataModule.NamaAnggota, "BUKA DATA", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception
                MessageBox.Show("Gagal membuka file: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object,
        e As EventArgs) Handles KeluarToolStripMenuItem.Click

        Dim hasil As DialogResult = MessageBox.Show(
            "Apakah Anda yakin ingin keluar dari aplikasi?",
            "KONFIRMASI KELUAR",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question)

        If hasil = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

End Class