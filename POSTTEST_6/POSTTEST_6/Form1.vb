Imports System.Data

Public Class Form1

    ' Menyimpan idKamar yang sedang dipilih dari DataGridView
    Dim idKamarTerpilih As Integer = 0

    ' ================================================================
    '  INISIALISASI FORM
    ' ================================================================
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilData()
        Kosong()
    End Sub

    ' ================================================================
    '  FUNGSI PENDUKUNG
    ' ================================================================
    Private Sub TampilData()
        Dim dt As DataTable = GetAllKamar()
        dgvKamar.DataSource = dt

        ' Atur header kolom menjadi lebih ramah
        If dgvKamar.Columns.Count >= 5 Then
            dgvKamar.Columns("idKamar").HeaderText = "ID"
            dgvKamar.Columns("idKamar").Width = 50
            dgvKamar.Columns("jenisKamar").HeaderText = "Jenis Kamar"
            dgvKamar.Columns("jenisKamar").Width = 120
            dgvKamar.Columns("nomorKamar").HeaderText = "No. Kamar"
            dgvKamar.Columns("nomorKamar").Width = 90
            dgvKamar.Columns("hargaKamar").HeaderText = "Harga/Bulan"
            dgvKamar.Columns("hargaKamar").Width = 110
            dgvKamar.Columns("statusKamar").HeaderText = "Status"
            dgvKamar.Columns("statusKamar").Width = 90
        End If
    End Sub

    Private Sub Kosong()
        txtJenis.Clear()
        txtNomor.Clear()
        txtHarga.Clear()
        cmbStatus.SelectedIndex = -1
        ErrorProvider1.Clear()
        idKamarTerpilih = 0
        txtJenis.Focus()
    End Sub

    ' ================================================================
    '  EVENT DATAGRIDVIEW - Pilih baris untuk mengisi form
    ' ================================================================
    Private Sub dgvKamar_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvKamar.CellClick
        If e.RowIndex < 0 Then Exit Sub

        idKamarTerpilih = CInt(dgvKamar.Rows(e.RowIndex).Cells("idKamar").Value)
        txtJenis.Text = dgvKamar.Rows(e.RowIndex).Cells("jenisKamar").Value.ToString()
        txtNomor.Text = dgvKamar.Rows(e.RowIndex).Cells("nomorKamar").Value.ToString()
        txtHarga.Text = dgvKamar.Rows(e.RowIndex).Cells("hargaKamar").Value.ToString()
        cmbStatus.Text = dgvKamar.Rows(e.RowIndex).Cells("statusKamar").Value.ToString()
    End Sub

    ' ================================================================
    '  TOMBOL SIMPAN
    ' ================================================================
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        ErrorProvider1.Clear()

        If Not ValidasiDataKamar(ErrorProvider1, txtJenis, txtNomor, txtHarga, cmbStatus) Then Exit Sub

        Dim nomor As String = txtNomor.Text.Trim()
        If NomorKamarSudahAda(nomor) Then
            MessageBox.Show("Nomor kamar sudah terdaftar!", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNomor.Focus()
            Exit Sub
        End If

        If SimpanKamar(txtJenis.Text.Trim(), nomor,
                       CInt(txtHarga.Text.Trim()), cmbStatus.Text) Then
            MessageBox.Show("Data kamar berhasil disimpan!", "Informasi",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            TampilData()
            Kosong()
        End If
    End Sub

    ' ================================================================
    '  TOMBOL UBAH
    ' ================================================================
    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        If idKamarTerpilih = 0 Then
            MessageBox.Show("Pilih data kamar yang ingin diubah terlebih dahulu!", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ErrorProvider1.Clear()
        If Not ValidasiDataKamar(ErrorProvider1, txtJenis, txtNomor, txtHarga, cmbStatus) Then Exit Sub

        Dim nomor As String = txtNomor.Text.Trim()
        If NomorKamarSudahAda(nomor, idKamarTerpilih) Then
            MessageBox.Show("Nomor kamar sudah dipakai kamar lain!", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNomor.Focus()
            Exit Sub
        End If

        If UbahKamar(idKamarTerpilih, txtJenis.Text.Trim(), nomor,
                     CInt(txtHarga.Text.Trim()), cmbStatus.Text) Then
            MessageBox.Show("Data kamar berhasil diubah!", "Informasi",
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
        If idKamarTerpilih = 0 Then
            MessageBox.Show("Pilih data kamar yang ingin dihapus terlebih dahulu!", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim konfirmasi As DialogResult = MessageBox.Show(
            "Apakah Anda yakin ingin menghapus kamar ini?" & vbCrLf &
            "Kamar yang masih memiliki penyewa aktif tidak bisa dihapus.",
            "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If konfirmasi = DialogResult.Yes Then
            If HapusKamar(idKamarTerpilih) Then
                MessageBox.Show("Data kamar berhasil dihapus!", "Informasi",
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
            dgvKamar.DataSource = SearchKamar(txtCari.Text.Trim())
        End If
    End Sub

    ' ================================================================
    '  VALIDASI INPUT - Hanya angka untuk harga
    ' ================================================================
    Private Sub txtHarga_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHarga.KeyPress
        HanyaAngka(e)
    End Sub

    ' ================================================================
    '  NAVIGASI KE FORM PENYEWA
    ' ================================================================
    Private Sub btnKelolaPenyewa_Click(sender As Object, e As EventArgs) Handles btnKelolaPenyewa.Click
        Dim frm As New Form2()
        frm.Show()
    End Sub

    Private Sub mnuKamar_Click(sender As Object, e As EventArgs) Handles mnuKamar.Click
        ' Sudah di form ini
        Me.BringToFront()
    End Sub

    Private Sub mnuPenyewa_Click(sender As Object, e As EventArgs) Handles mnuPenyewa.Click
        Dim frm As New Form2()
        frm.Show()
    End Sub

    Private Sub mnuKeluar_Click(sender As Object, e As EventArgs) Handles mnuKeluar.Click
        If MessageBox.Show("Keluar dari aplikasi?", "Konfirmasi",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

End Class
