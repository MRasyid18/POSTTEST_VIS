Imports MySqlConnector

Module DataModule

    ' ================================================================
    '  FUNGSI-FUNGSI UNTUK TABEL tbkamar (Tabel Induk)
    ' ================================================================

    Public Function GetAllKamar() As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String = "SELECT idKamar, jenisKamar, nomorKamar, hargaKamar, statusKamar " &
                                  "FROM tbkamar ORDER BY nomorKamar ASC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menampilkan data kamar: " & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function SearchKamar(keyword As String) As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String = "SELECT idKamar, jenisKamar, nomorKamar, hargaKamar, statusKamar " &
                                  "FROM tbkamar " &
                                  "WHERE jenisKamar LIKE @kw OR nomorKamar LIKE @kw OR statusKamar LIKE @kw " &
                                  "ORDER BY nomorKamar ASC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@kw", "%" & keyword & "%")
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mencari data kamar: " & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function GetKamarById(id As Integer) As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String = "SELECT * FROM tbkamar WHERE idKamar = @id"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@id", id)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mengambil data kamar: " & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    ''' <summary>Cek apakah nomor kamar sudah ada (untuk mencegah duplikasi)</summary>
    Public Function NomorKamarSudahAda(nomor As String, Optional excludeId As Integer = 0) As Boolean
        Try
            Dim query As String = "SELECT COUNT(*) FROM tbkamar WHERE nomorKamar = @nomor AND idKamar <> @id"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@nomor", nomor)
                    cmd.Parameters.AddWithValue("@id", excludeId)
                    Return Convert.ToInt32(cmd.ExecuteScalar()) > 0
                End Using
            End Using
        Catch ex As Exception
            Return True
        End Try
    End Function

    Public Function SimpanKamar(jenis As String, nomor As String, harga As Integer, status As String) As Boolean
        Try
            Dim query As String = "INSERT INTO tbkamar (jenisKamar, nomorKamar, hargaKamar, statusKamar) " &
                                  "VALUES (@jenis, @nomor, @harga, @status)"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@jenis", jenis)
                    cmd.Parameters.AddWithValue("@nomor", nomor)
                    cmd.Parameters.AddWithValue("@harga", harga)
                    cmd.Parameters.AddWithValue("@status", status)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Gagal menyimpan data kamar: " & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function UbahKamar(id As Integer, jenis As String, nomor As String, harga As Integer, status As String) As Boolean
        Try
            Dim query As String = "UPDATE tbkamar SET jenisKamar=@jenis, nomorKamar=@nomor, " &
                                  "hargaKamar=@harga, statusKamar=@status WHERE idKamar=@id"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.Parameters.AddWithValue("@jenis", jenis)
                    cmd.Parameters.AddWithValue("@nomor", nomor)
                    cmd.Parameters.AddWithValue("@harga", harga)
                    cmd.Parameters.AddWithValue("@status", status)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mengubah data kamar: " & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function HapusKamar(id As Integer) As Boolean
        Try
            Dim query As String = "DELETE FROM tbkamar WHERE idKamar = @id"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            ' Jika kamar masih punya penyewa aktif, MySQL akan menolak (RESTRICT)
            MessageBox.Show("Gagal menghapus kamar: " & ex.Message & vbCrLf &
                            "Pastikan tidak ada penyewa aktif di kamar ini.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    ''' <summary>Ambil daftar kamar untuk ComboBox di form penyewa</summary>
    Public Function GetKamarKosong() As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String = "SELECT idKamar, CONCAT(nomorKamar, ' - ', jenisKamar, ' (Rp ', FORMAT(hargaKamar,0), ')') AS infoKamar " &
                                  "FROM tbkamar ORDER BY nomorKamar ASC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mengambil data kamar: " & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    ' ================================================================
    '  FUNGSI-FUNGSI UNTUK TABEL tbpenyewa (Tabel Anak / berelasi)
    ' ================================================================

    Public Function GetAllPenyewa() As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String =
                "SELECT p.idPenyewa, k.nomorKamar, k.jenisKamar, " &
                "       FORMAT(k.hargaKamar, 0) AS hargaKamar, " &
                "       p.namaPenyewa, p.noTelp, " &
                "       p.tanggalMasuk, p.tanggalKeluar, p.statusSewa " &
                "FROM tbpenyewa p " &
                "INNER JOIN tbkamar k ON p.idKamar = k.idKamar " &
                "ORDER BY p.idPenyewa ASC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menampilkan data penyewa: " & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function SearchPenyewa(keyword As String) As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String =
                "SELECT p.idPenyewa, k.nomorKamar, k.jenisKamar, " &
                "       FORMAT(k.hargaKamar, 0) AS hargaKamar, " &
                "       p.namaPenyewa, p.noTelp, " &
                "       p.tanggalMasuk, p.tanggalKeluar, p.statusSewa " &
                "FROM tbpenyewa p " &
                "INNER JOIN tbkamar k ON p.idKamar = k.idKamar " &
                "WHERE p.namaPenyewa LIKE @kw OR k.nomorKamar LIKE @kw " &
                "   OR p.noTelp LIKE @kw OR p.statusSewa LIKE @kw " &
                "ORDER BY p.idPenyewa ASC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@kw", "%" & keyword & "%")
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mencari data penyewa: " & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function SimpanPenyewa(idKamar As Integer, nama As String, telp As String,
                                  tglMasuk As Date, tglKeluar As Object, status As String) As Boolean
        Try
            Dim query As String =
                "INSERT INTO tbpenyewa (idKamar, namaPenyewa, noTelp, tanggalMasuk, tanggalKeluar, statusSewa) " &
                "VALUES (@idKamar, @nama, @telp, @tglMasuk, @tglKeluar, @status)"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@idKamar", idKamar)
                    cmd.Parameters.AddWithValue("@nama", nama)
                    cmd.Parameters.AddWithValue("@telp", telp)
                    cmd.Parameters.AddWithValue("@tglMasuk", tglMasuk.ToString("yyyy-MM-dd"))
                    If tglKeluar Is Nothing OrElse tglKeluar Is DBNull.Value Then
                        cmd.Parameters.AddWithValue("@tglKeluar", DBNull.Value)
                    Else
                        cmd.Parameters.AddWithValue("@tglKeluar", CDate(tglKeluar).ToString("yyyy-MM-dd"))
                    End If
                    cmd.Parameters.AddWithValue("@status", status)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            ' Jika status Aktif, update status kamar menjadi Terisi
            If status = "Aktif" Then UpdateStatusKamar(idKamar, "Terisi")
            Return True
        Catch ex As Exception
            MessageBox.Show("Gagal menyimpan data penyewa: " & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function UbahPenyewa(idPenyewa As Integer, idKamar As Integer, nama As String, telp As String,
                                tglMasuk As Date, tglKeluar As Object, status As String) As Boolean
        Try
            ' Ambil idKamar lama untuk update status kamar lama jika perlu
            Dim dtLama As DataTable = GetPenyewaById(idPenyewa)
            Dim idKamarLama As Integer = 0
            If dtLama.Rows.Count > 0 Then idKamarLama = CInt(dtLama.Rows(0)("idKamar"))

            Dim query As String =
                "UPDATE tbpenyewa SET idKamar=@idKamar, namaPenyewa=@nama, noTelp=@telp, " &
                "tanggalMasuk=@tglMasuk, tanggalKeluar=@tglKeluar, statusSewa=@status " &
                "WHERE idPenyewa=@idPenyewa"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@idPenyewa", idPenyewa)
                    cmd.Parameters.AddWithValue("@idKamar", idKamar)
                    cmd.Parameters.AddWithValue("@nama", nama)
                    cmd.Parameters.AddWithValue("@telp", telp)
                    cmd.Parameters.AddWithValue("@tglMasuk", tglMasuk.ToString("yyyy-MM-dd"))
                    If tglKeluar Is Nothing OrElse tglKeluar Is DBNull.Value Then
                        cmd.Parameters.AddWithValue("@tglKeluar", DBNull.Value)
                    Else
                        cmd.Parameters.AddWithValue("@tglKeluar", CDate(tglKeluar).ToString("yyyy-MM-dd"))
                    End If
                    cmd.Parameters.AddWithValue("@status", status)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mengubah data penyewa: " & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function HapusPenyewa(idPenyewa As Integer) As Boolean
        Try
            ' Ambil idKamar sebelum hapus, untuk update status kamar
            Dim dt As DataTable = GetPenyewaById(idPenyewa)
            Dim idKamar As Integer = 0
            If dt.Rows.Count > 0 Then idKamar = CInt(dt.Rows(0)("idKamar"))

            Dim query As String = "DELETE FROM tbpenyewa WHERE idPenyewa = @id"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", idPenyewa)
                    Dim affected As Integer = cmd.ExecuteNonQuery()
                    If affected > 0 AndAlso idKamar > 0 Then
                        ' Cek apakah masih ada penyewa aktif di kamar itu
                        UpdateStatusKamarOtomatis(idKamar)
                    End If
                    Return affected > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menghapus data penyewa: " & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function GetPenyewaById(id As Integer) As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String = "SELECT * FROM tbpenyewa WHERE idPenyewa = @id"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@id", id)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
        End Try
        Return dt
    End Function

    ''' <summary>Update status kamar secara manual</summary>
    Public Sub UpdateStatusKamar(idKamar As Integer, status As String)
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand("UPDATE tbkamar SET statusKamar=@s WHERE idKamar=@id", conn)
                    cmd.Parameters.AddWithValue("@s", status)
                    cmd.Parameters.AddWithValue("@id", idKamar)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
        End Try
    End Sub

    ''' <summary>Update status kamar otomatis berdasarkan keberadaan penyewa aktif</summary>
    Public Sub UpdateStatusKamarOtomatis(idKamar As Integer)
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(
                    "SELECT COUNT(*) FROM tbpenyewa WHERE idKamar=@id AND statusSewa='Aktif'", conn)
                    cmd.Parameters.AddWithValue("@id", idKamar)
                    Dim jumlah As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    Dim statusBaru As String = If(jumlah > 0, "Terisi", "Kosong")
                    UpdateStatusKamar(idKamar, statusBaru)
                End Using
            End Using
        Catch ex As Exception
        End Try
    End Sub

End Module
