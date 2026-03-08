Public Module ModulPerpustakaan
    ' Menggunakan Array 2 Dimensi untuk menyimpan Judul (indeks 0) dan Genre (indeks 1)
    ' Ukuran 99 berarti menampung hingga 100 data [cite: 457]
    Public daftarBuku(99, 1) As String
    Public jumlahBuku As Integer = 0

    ' Menerapkan Function: menghasilkan nilai balik berupa indeks jika buku ditemukan [cite: 443]
    Public Function CariBuku(ByVal judulCari As String) As Integer
        ' Menggunakan perulangan For...Next yang sudah diketahui batasannya [cite: 312]
        For i As Integer = 0 To jumlahBuku - 1
            If daftarBuku(i, 0).ToLower() = judulCari.ToLower() Then
                Return i ' Mengembalikan indeks array jika cocok
            End If
        Next
        Return -1 ' Mengembalikan -1 jika buku tidak ada
    End Function
End Module