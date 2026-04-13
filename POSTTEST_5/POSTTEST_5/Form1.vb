Imports System.Data

Public Class Form1

    Dim idTerpilih As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbStatus.Items.Add("Terisi")
        cmbStatus.Items.Add("Kosong")

        Tampil()
    End Sub

    Sub Tampil()
        lstKamar.Items.Clear()

        Dim dt As DataTable = GetAll()

        For Each row As DataRow In dt.Rows
            Dim teks As String =
                row("idKamar").ToString() & " | " &
                row("jenisKamar").ToString() & " | " &
                row("nomorKamar").ToString() & " | " &
                row("statusKamar").ToString()

            lstKamar.Items.Add(teks)
        Next
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs)

        If txtJenis.Text = "" Or txtNomor.Text = "" Or cmbStatus.Text = "" Then
            MessageBox.Show("Isi semua data!")
            Exit Sub
        End If

        Simpan(txtJenis.Text, txtNomor.Text, cmbStatus.Text)

        MessageBox.Show("Data disimpan")
        Tampil()
        Kosong()

    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs)

        If idTerpilih = 0 Then
            MessageBox.Show("Pilih data dulu!")
            Exit Sub
        End If

        Ubah(idTerpilih, txtJenis.Text, txtNomor.Text, cmbStatus.Text)

        MessageBox.Show("Data diubah")
        Tampil()
        Kosong()

    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs)

        If idTerpilih = 0 Then
            MessageBox.Show("Pilih data dulu!")
            Exit Sub
        End If

        If MessageBox.Show("Hapus data?", "Konfirmasi", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Hapus(idTerpilih)

            MessageBox.Show("Data dihapus")
            Tampil()
            Kosong()
        End If

    End Sub

    Private Sub lstKamar_SelectedIndexChanged(sender As Object, e As EventArgs)

        If lstKamar.SelectedItem Is Nothing Then Exit Sub

        Dim data = lstKamar.SelectedItem.ToString.Split("|")

        idTerpilih = Val(data(0))
        txtJenis.Text = data(1).Trim
        txtNomor.Text = data(2).Trim
        cmbStatus.Text = data(3).Trim

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs)

        lstKamar.Items.Clear()

        Dim dt = SearchData(txtSearch.Text)

        For Each row As DataRow In dt.Rows
            Dim teks As String =
                row("idKamar") & " | " &
                row("jenisKamar") & " | " &
                row("nomorKamar") & " | " &
                row("statusKamar")

            lstKamar.Items.Add(teks)
        Next

    End Sub

    Sub Kosong()
        txtJenis.Clear()
        txtNomor.Clear()
        cmbStatus.SelectedIndex = -1
        idTerpilih = 0
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs)
        Kosong()
    End Sub

End Class