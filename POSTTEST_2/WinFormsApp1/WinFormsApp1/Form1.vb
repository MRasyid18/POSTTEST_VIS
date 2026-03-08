Public Class Form1

    ' Event saat Form pertama kali dimuat
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Modifikasi judul form untuk poin plus kreativitas
        Me.Text = "Sistem Perpustakaan - 6042"
    End Sub

    ' Menerapkan Procedure dengan argumen tipe ByVal [cite: 404, 413]
    ' Procedure ini menjalankan instruksi pembaruan UI tanpa nilai balik [cite: 404]
    Private Sub PerbaruiTampilan(ByVal lst As ListBox)
        lst.Items.Clear()
        For i As Integer = 0 To jumlahBuku - 1
            lst.Items.Add(daftarBuku(i, 0) & " (" & daftarBuku(i, 1) & ")")
        Next
    End Sub

    ' Event untuk Button Tambah
    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Dim judul As String = txtJudulTambah.Text.Trim()
        Dim genre As String = txtGenre.Text.Trim()

        ' Validasi input kosong menggunakan operator logika Or [cite: 225]
        If judul = "" Or genre = "" Then
            MessageBox.Show("Judul dan Genre wajib diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If jumlahBuku < 100 Then
            ' Menyimpan ke array multidimensi di dalam Module
            daftarBuku(jumlahBuku, 0) = judul
            daftarBuku(jumlahBuku, 1) = genre
            jumlahBuku += 1

            ' Mengosongkan field setelah input
            txtJudulTambah.Clear()
            txtGenre.Clear()

            ' Memanggil procedure untuk render ulang list
            PerbaruiTampilan(lstDaftarBuku)
            MessageBox.Show("Data buku berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Kapasitas penyimpanan penuh!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    ' Event untuk Button Hapus
    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Dim judul As String = txtJudulHapus.Text.Trim()

        If judul = "" Then
            MessageBox.Show("Masukkan judul buku yang akan dihapus!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Memanggil Function pencarian yang ada di Module
        Dim indeks As Integer = CariBuku(judul)

        If indeks <> -1 Then
            ' Menghapus dengan cara menggeser elemen array di bawahnya naik ke atas
            For i As Integer = indeks To jumlahBuku - 2
                daftarBuku(i, 0) = daftarBuku(i + 1, 0)
                daftarBuku(i, 1) = daftarBuku(i + 1, 1)
            Next

            ' Mengosongkan data di ujung akhir array
            daftarBuku(jumlahBuku - 1, 0) = ""
            daftarBuku(jumlahBuku - 1, 1) = ""
            jumlahBuku -= 1

            txtJudulHapus.Clear()
            PerbaruiTampilan(lstDaftarBuku)
            MessageBox.Show("Buku berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Buku tidak ditemukan di dalam sistem.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

End Class