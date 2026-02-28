Public Class Form1
    Private totalNilaiIP As Double = 0
    Private jumlahData As Integer = 0

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Dim ipBaru As Double
        If Double.TryParse(txtIPSemester.Text, ipBaru) Then
            totalNilaiIP += ipBaru
            jumlahData += 1

            Dim ipk As Double = totalNilaiIP / jumlahData
            txtIPK.Text = ipk.ToString("N2")
            If ipk >= 3.01 Then
                lblPredikat.Text = "Sangat Memuaskan"
            ElseIf ipk >= 2.76 Then
                lblPredikat.Text = "Memuaskan"
            ElseIf ipk >= 2.0 Then
                lblPredikat.Text = "Cukup"
            Else
                lblPredikat.Text = "Kurang"
            End If

            txtIPSemester.Clear()
            txtIPSemester.Focus()

        Else
            MessageBox.Show("Mohon masukkan angka yang valid!", "Peringatan")
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        totalNilaiIP = 0
        jumlahData = 0
        txtIPSemester.Clear()
        txtIPK.Clear()
        lblPredikat.Text = ""
        txtIPSemester.Focus()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class