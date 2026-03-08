Public Module ModulPerpustakaan
    Public daftarBuku(99, 1) As String
    Public jumlahBuku As Integer = 0
    Public Function CariBuku(ByVal judulCari As String) As Integer
        For i As Integer = 0 To jumlahBuku - 1
            If daftarBuku(i, 0).ToLower() = judulCari.ToLower() Then
                Return i
            End If
        Next
        Return -1
    End Function
End Module