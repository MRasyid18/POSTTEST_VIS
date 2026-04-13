Imports MySqlConnector

Module DataModule

    Public Function GetAll() As DataTable
        Dim dt As New DataTable()

        Using conn = GetConnection()
            Dim da As New MySqlDataAdapter("SELECT * FROM tbkamar", conn)
            da.Fill(dt)
        End Using

        Return dt
    End Function

    Public Function SearchData(kunci As String) As DataTable
        Dim dt As New DataTable()

        Using conn = GetConnection()
            Dim query = "SELECT * FROM tbkamar WHERE jenisKamar LIKE @kunci OR nomorKamar LIKE @kunci"
            Dim da As New MySqlDataAdapter(query, conn)
            da.SelectCommand.Parameters.AddWithValue("@kunci", "%" & kunci & "%")
            da.Fill(dt)
        End Using

        Return dt
    End Function

    Public Sub Simpan(jenis As String, nomor As String, status As String)
        Using conn = GetConnection()
            conn.Open()
            Dim cmd As New MySqlCommand(
                "INSERT INTO tbkamar (jenisKamar, nomorKamar, statusKamar) VALUES (@j,@n,@s)", conn)
            cmd.Parameters.AddWithValue("@j", jenis)
            cmd.Parameters.AddWithValue("@n", nomor)
            cmd.Parameters.AddWithValue("@s", status)
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    Public Sub Ubah(id As Integer, jenis As String, nomor As String, status As String)
        Using conn = GetConnection()
            conn.Open()
            Dim cmd As New MySqlCommand(
                "UPDATE tbkamar SET jenisKamar=@j, nomorKamar=@n, statusKamar=@s WHERE idKamar=@id", conn)
            cmd.Parameters.AddWithValue("@id", id)
            cmd.Parameters.AddWithValue("@j", jenis)
            cmd.Parameters.AddWithValue("@n", nomor)
            cmd.Parameters.AddWithValue("@s", status)
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    Public Sub Hapus(id As Integer)
        Using conn = GetConnection()
            conn.Open()
            Dim cmd As New MySqlCommand("DELETE FROM tbkamar WHERE idKamar=@id", conn)
            cmd.Parameters.AddWithValue("@id", id)
            cmd.ExecuteNonQuery()
        End Using
    End Sub

End Module