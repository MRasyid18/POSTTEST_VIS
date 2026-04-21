Imports System.Data

Public Class Form2

    Dim idPenyewaTerpilih As Integer = 0

    ' ================================================================
    '  INISIALISASI FORM
    ' ================================================================
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Isi ComboBox Kamar dari database
        MuatDataKamar()
        ' Isi ComboBox Status Sewa
        cmbStatusSewa.Items.AddRange(New Object() {"Aktif", "Keluar"})
        cmbStatusSewa.SelectedIndex = 0

        TampilData()
        Kosong()
    End Sub

    ' ================================================================
    '  FUNGSI PENDUKUNG
    ' ================================================================
    Private Sub MuatDataKamar()
        Dim dt As DataTable = GetKamarKosong()
        cmbKamar.DataSource = dt
        cmbKamar.DisplayMember = "infoKamar"
        cmbKamar.ValueMember = "idKamar"
        cmbKamar.SelectedIndex = -1
    End Sub

    Private Sub TampilData()
        Dim dt As DataTable = GetAllPenyewa()
        dgvPenyewa.DataSource = dt

        If dgvPenyewa.Columns.Count > 0 Then
            If dgvPenyewa.Columns.Contains("idPenyewa") Then
                dgvPenyewa.Columns("idPenyewa").HeaderText = "ID"
                dgvPenyewa.Columns("idPenyewa").Width = 45
            End If
            If dgvPenyewa.Columns.Contains("nomorKamar") Then
                dgvPenyewa.Columns("nomorKamar").HeaderText = "No. Kamar"
                dgvPenyewa.Columns("nomorKamar").Width = 90
            End If
            If dgvPenyewa.Columns.Contains("jenisKamar") Then
                dgvPenyewa.Columns("jenisKamar").HeaderText = "Jenis"
                dgvPenyewa.Columns("jenisKamar").Width = 80
            End If
            If dgvPenyewa.Columns.Contains("hargaKamar") Then
                dgvPenyewa.Columns("hargaKamar").HeaderText = "Harga/Bln"
                dgvPenyewa.Columns("hargaKamar").Width = 100
            End If
            If dgvPenyewa.Columns.Contains("namaPenyewa") Then
                dgvPenyewa.Columns("namaPenyewa").HeaderText = "Nama Penyewa"
                dgvPenyewa.Columns("namaPenyewa").Width = 150
            End If
            If dgvPenyewa.Columns.Contains("noTelp") Then
                dgvPenyewa.Columns("noTelp").HeaderText = "No. Telp"
                dgvPenyewa.Columns("noTelp").Width = 115
            End If
            If dgvPenyewa.Columns.Contains("tanggalMasuk") Then
                dgvPenyewa.Columns("tanggalMasuk").HeaderText = "Tgl Masuk"
                dgvPenyewa.Columns("tanggalMasuk").Width = 100
            End If
            If dgvPenyewa.Columns.Contains("tanggalKeluar") Then
                dgvPenyewa.Columns("tanggalKeluar").HeaderText = "Tgl Keluar"
                dgvPenyewa.Columns("tanggalKeluar").Width = 100
            End If
            If dgvPenyewa.Columns.Contains("statusSewa") Then
                dgvPenyewa.Columns("statusSewa").HeaderText = "Status"
                dgvPenyewa.Columns("statusSewa").Width = 70
            End If
        End If
    End Sub

    Private Sub Kosong()
        cmbKamar.SelectedIndex = -1
        txtNama.Clear()
        txtTelp.Clear()
        dtpMasuk.Value = DateTime.Today
        cbAktifSaja.Checked = True
        dtpKeluar.Value = DateTime.Today
        dtpKeluar.Enabled = False
        cmbStatusSewa.SelectedIndex = 0
        ErrorProvider1.Clear()
        idPenyewaTerpilih = 0
        txtNama.Focus()
    End Sub

    ' ================================================================
    '  CHECKBOX TANGGAL KELUAR
    ' ================================================================
    Private Sub cbAktifSaja_CheckedChanged(sender As Object, e As EventArgs) Handles cbAktifSaja.CheckedChanged
        dtpKeluar.Enabled = Not cbAktifSaja.Checked
        If cbAktifSaja.Checked Then
            ErrorProvider1.SetError(dtpKeluar, "")
        End If
    End Sub

    ' ================================================================
    '  DATAGRIDVIEW - Klik baris untuk mengisi form
    ' ================================================================
    Private Sub dgvPenyewa_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPenyewa.CellClick
        If e.RowIndex < 0 Then Exit Sub

        idPenyewaTerpilih = CInt(dgvPenyewa.Rows(e.RowIndex).Cells("idPenyewa").Value)

        ' Set ComboBox Kamar berdasarkan nomor kamar yang tampil
        Dim nomorKamar As String = dgvPenyewa.Rows(e.RowIndex).Cells("nomorKamar").Value.ToString()
        For i As Integer = 0 To cmbKamar.Items.Count - 1
            Dim row As DataRowView = CType(cmbKamar.Items(i), DataRowView)
            Dim infoKamar As String = row("infoKamar").ToString()
            If infoKamar.StartsWith(nomorKamar & " -") Then
                cmbKamar.SelectedIndex = i
                Exit For
            End If
        Next

        txtNama.Text = dgvPenyewa.Rows(e.RowIndex).Cells("namaPenyewa").Value.ToString()
        txtTelp.Text = dgvPenyewa.Rows(e.RowIndex).Cells("noTelp").Value.ToString()

        Dim tglMasuk As Object = dgvPenyewa.Rows(e.RowIndex).Cells("tanggalMasuk").Value
        If tglMasuk IsNot Nothing AndAlso Not IsDBNull(tglMasuk) Then
            dtpMasuk.Value = CDate(tglMasuk)
        End If

        Dim tglKeluar As Object = dgvPenyewa.Rows(e.RowIndex).Cells("tanggalKeluar").Value
        If tglKeluar Is Nothing OrElse IsDBNull(tglKeluar) OrElse tglKeluar.ToString() = "" Then
            cbAktifSaja.Checked = True
            dtpKeluar.Enabled = False
        Else
            cbAktifSaja.Checked = False
            dtpKeluar.Enabled = True
            dtpKeluar.Value = CDate(tglKeluar)
        End If

        cmbStatusSewa.Text = dgvPenyewa.Rows(e.RowIndex).Cells("statusSewa").Value.ToString()
    End Sub

    ' ================================================================
    '  TOMBOL SIMPAN
    ' ================================================================
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        ErrorProvider1.Clear()

        If Not ValidasiDataPenyewa(ErrorProvider1, cmbKamar, txtNama, txtTelp, cmbStatusSewa) Then Exit Sub
        If Not cbAktifSaja.Checked Then
            If Not ValidasiTanggal(ErrorProvider1, dtpMasuk, dtpKeluar, cbAktifSaja) Then Exit Sub
        End If

        Dim idKamar As Integer = CInt(cmbKamar.SelectedValue)
        Dim tglKeluar As Object = If(cbAktifSaja.Checked, Nothing, CType(dtpKeluar.Value.Date, Object))

        If SimpanPenyewa(idKamar, txtNama.Text.Trim(), txtTelp.Text.Trim(),
                         dtpMasuk.Value.Date, tglKeluar, cmbStatusSewa.Text) Then
            MessageBox.Show("Data penyewa berhasil disimpan!", "Informasi",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            TampilData()
            Kosong()
        End If
    End Sub

    ' ================================================================
    '  TOMBOL UBAH
    ' ================================================================
    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        If idPenyewaTerpilih = 0 Then
            MessageBox.Show("Pilih data penyewa yang ingin diubah terlebih dahulu!", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ErrorProvider1.Clear()
        If Not ValidasiDataPenyewa(ErrorProvider1, cmbKamar, txtNama, txtTelp, cmbStatusSewa) Then Exit Sub
        If Not cbAktifSaja.Checked Then
            If Not ValidasiTanggal(ErrorProvider1, dtpMasuk, dtpKeluar, cbAktifSaja) Then Exit Sub
        End If

        Dim idKamar As Integer = CInt(cmbKamar.SelectedValue)
        Dim tglKeluar As Object = If(cbAktifSaja.Checked, Nothing, CType(dtpKeluar.Value.Date, Object))

        If UbahPenyewa(idPenyewaTerpilih, idKamar, txtNama.Text.Trim(), txtTelp.Text.Trim(),
                       dtpMasuk.Value.Date, tglKeluar, cmbStatusSewa.Text) Then
            ' Sinkronisasi status kamar
            UpdateStatusKamarOtomatis(idKamar)
            MessageBox.Show("Data penyewa berhasil diubah!", "Informasi",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            TampilData()
            Kosong()
        Else
            MessageBox.Show("Data tidak ditemukan.", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    ' ================================================================
    '  TOMBOL HAPUS
    ' ================================================================
    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If idPenyewaTerpilih = 0 Then
            MessageBox.Show("Pilih data penyewa yang ingin dihapus terlebih dahulu!", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If MessageBox.Show("Apakah Anda yakin ingin menghapus data penyewa ini?",
                           "Konfirmasi Hapus", MessageBoxButtons.YesNo,
                           MessageBoxIcon.Question) = DialogResult.Yes Then
            If HapusPenyewa(idPenyewaTerpilih) Then
                MessageBox.Show("Data penyewa berhasil dihapus!", "Informasi",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)
                TampilData()
                Kosong()
            End If
        End If
    End Sub

    ' ================================================================
    '  TOMBOL BATAL
    ' ================================================================
    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Kosong()
        TampilData()
    End Sub

    ' ================================================================
    '  PENCARIAN REAL-TIME
    ' ================================================================
    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
        If txtCari.Text.Trim() = "" Then
            TampilData()
        Else
            dgvPenyewa.DataSource = SearchPenyewa(txtCari.Text.Trim())
        End If
    End Sub

    ' ================================================================
    '  VALIDASI KEYBOARD
    ' ================================================================
    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        HanyaHuruf(e)
    End Sub

    Private Sub txtTelp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelp.KeyPress
        HanyaTelp(e)
    End Sub

    ' ================================================================
    '  NAVIGASI KE FORM KAMAR
    ' ================================================================
    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Me.Close()
    End Sub

    Private Sub mnuKamar_Click(sender As Object, e As EventArgs) Handles mnuKamar.Click
        Me.Close()
    End Sub

    Private Sub mnuPenyewa_Click(sender As Object, e As EventArgs) Handles mnuPenyewa.Click
        Me.BringToFront()
    End Sub

    Private Sub mnuKeluar_Click(sender As Object, e As EventArgs) Handles mnuKeluar.Click
        If MessageBox.Show("Keluar dari aplikasi?", "Konfirmasi",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

End Class
