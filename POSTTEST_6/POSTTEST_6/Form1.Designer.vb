<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New System.ComponentModel.Container()

        ' ---- Menu Strip ----
        MainMenuStrip = New MenuStrip()
        mnuData = New ToolStripMenuItem()
        mnuKamar = New ToolStripMenuItem()
        mnuPenyewa = New ToolStripMenuItem()
        ToolStripSeparator1 = New ToolStripSeparator()
        mnuKeluar = New ToolStripMenuItem()

        ' ---- Controls ----
        lblJudul = New Label()
        lblGaris = New Label()

        grpDataKamar = New GroupBox()
        lblJenis = New Label()
        txtJenis = New TextBox()
        lblNomor = New Label()
        txtNomor = New TextBox()
        lblHarga = New Label()
        txtHarga = New TextBox()
        lblStatus = New Label()
        cmbStatus = New ComboBox()

        grpPencarian = New GroupBox()
        lblCari = New Label()
        txtCari = New TextBox()

        grpAksi = New GroupBox()
        btnSimpan = New Button()
        btnUbah = New Button()
        btnHapus = New Button()
        btnBatal = New Button()
        btnKelolaPenyewa = New Button()

        dgvKamar = New DataGridView()
        lblInfo = New Label()
        ErrorProvider1 = New ErrorProvider(components)

        MainMenuStrip.SuspendLayout()
        grpDataKamar.SuspendLayout()
        grpPencarian.SuspendLayout()
        grpAksi.SuspendLayout()
        CType(dgvKamar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()

        ' ---- MenuStrip ----
        MainMenuStrip.Items.AddRange(New ToolStripItem() {mnuData})
        MainMenuStrip.Location = New Point(0, 0)
        MainMenuStrip.Name = "MainMenuStrip"
        MainMenuStrip.Size = New Size(900, 28)
        MainMenuStrip.Text = "MenuStrip1"
        MainMenuStrip.BackColor = Color.FromArgb(60, 60, 60)
        MainMenuStrip.ForeColor = Color.White

        mnuData.DropDownItems.AddRange(New ToolStripItem() {mnuKamar, mnuPenyewa, ToolStripSeparator1, mnuKeluar})
        mnuData.Name = "mnuData"
        mnuData.Text = "Menu"
        mnuData.ForeColor = Color.White

        mnuKamar.Name = "mnuKamar"
        mnuKamar.Text = "Data Kamar"
        mnuKamar.ForeColor = Color.Black

        mnuPenyewa.Name = "mnuPenyewa"
        mnuPenyewa.Text = "Data Penyewa"
        mnuPenyewa.ForeColor = Color.Black

        ToolStripSeparator1.Name = "ToolStripSeparator1"

        mnuKeluar.Name = "mnuKeluar"
        mnuKeluar.Text = "Keluar"
        mnuKeluar.ForeColor = Color.Red

        ' ---- Label Judul ----
        lblJudul.AutoSize = True
        lblJudul.Font = New Font("Segoe UI", 14, FontStyle.Bold Or FontStyle.Italic)
        lblJudul.ForeColor = Color.FromArgb(40, 40, 120)
        lblJudul.Location = New Point(260, 38)
        lblJudul.Name = "lblJudul"
        lblJudul.Text = "SISTEM MANAJEMEN KOST RASYID"

        ' ---- Garis Pemisah ----
        lblGaris.AutoSize = False
        lblGaris.BorderStyle = BorderStyle.Fixed3D
        lblGaris.Location = New Point(10, 70)
        lblGaris.Name = "lblGaris"
        lblGaris.Size = New Size(875, 2)

        ' ---- GroupBox Data Kamar ----
        grpDataKamar.Text = "Data Kamar"
        grpDataKamar.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        grpDataKamar.BackColor = Color.FromArgb(255, 245, 220)
        grpDataKamar.Location = New Point(15, 80)
        grpDataKamar.Size = New Size(360, 210)
        grpDataKamar.Controls.AddRange(New Control() {lblJenis, txtJenis, lblNomor, txtNomor, lblHarga, txtHarga, lblStatus, cmbStatus})

        lblJenis.Text = "Jenis Kamar"
        lblJenis.Location = New Point(15, 35)
        lblJenis.AutoSize = True
        lblJenis.BackColor = Color.Transparent

        txtJenis.Location = New Point(140, 32)
        txtJenis.Size = New Size(200, 30)
        txtJenis.PlaceholderText = "Standar / AC / VIP"
        txtJenis.Font = New Font("Segoe UI", 10)

        lblNomor.Text = "Nomor Kamar"
        lblNomor.Location = New Point(15, 80)
        lblNomor.AutoSize = True
        lblNomor.BackColor = Color.Transparent

        txtNomor.Location = New Point(140, 77)
        txtNomor.Size = New Size(200, 30)
        txtNomor.PlaceholderText = "Contoh: K01"
        txtNomor.Font = New Font("Segoe UI", 10)

        lblHarga.Text = "Harga/Bulan (Rp)"
        lblHarga.Location = New Point(15, 125)
        lblHarga.AutoSize = True
        lblHarga.BackColor = Color.Transparent

        txtHarga.Location = New Point(140, 122)
        txtHarga.Size = New Size(200, 30)
        txtHarga.PlaceholderText = "Contoh: 500000"
        txtHarga.Font = New Font("Segoe UI", 10)

        lblStatus.Text = "Status"
        lblStatus.Location = New Point(15, 170)
        lblStatus.AutoSize = True
        lblStatus.BackColor = Color.Transparent

        cmbStatus.Location = New Point(140, 167)
        cmbStatus.Size = New Size(200, 31)
        cmbStatus.Font = New Font("Segoe UI", 10)
        cmbStatus.Items.AddRange(New Object() {"Kosong", "Terisi"})
        cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList

        ' ---- GroupBox Pencarian ----
        grpPencarian.Text = "Pencarian"
        grpPencarian.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        grpPencarian.BackColor = Color.FromArgb(255, 245, 220)
        grpPencarian.Location = New Point(385, 80)
        grpPencarian.Size = New Size(250, 80)
        grpPencarian.Controls.AddRange(New Control() {lblCari, txtCari})

        lblCari.Text = "Cari"
        lblCari.Location = New Point(15, 35)
        lblCari.AutoSize = True
        lblCari.BackColor = Color.Transparent

        txtCari.Location = New Point(60, 32)
        txtCari.Size = New Size(170, 30)
        txtCari.PlaceholderText = "No/Jenis/Status..."
        txtCari.Font = New Font("Segoe UI", 10)

        ' ---- GroupBox Aksi ----
        grpAksi.Text = "Aksi"
        grpAksi.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        grpAksi.BackColor = Color.FromArgb(255, 245, 220)
        grpAksi.Location = New Point(645, 80)
        grpAksi.Size = New Size(240, 210)
        grpAksi.Controls.AddRange(New Control() {btnSimpan, btnUbah, btnHapus, btnBatal, btnKelolaPenyewa})

        btnSimpan.Text = "💾  Simpan"
        btnSimpan.BackColor = Color.FromArgb(46, 160, 67)
        btnSimpan.ForeColor = Color.White
        btnSimpan.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        btnSimpan.Location = New Point(15, 28)
        btnSimpan.Size = New Size(205, 38)
        btnSimpan.FlatStyle = FlatStyle.Flat

        btnUbah.Text = "✏️  Ubah"
        btnUbah.BackColor = Color.FromArgb(255, 165, 0)
        btnUbah.ForeColor = Color.White
        btnUbah.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        btnUbah.Location = New Point(15, 74)
        btnUbah.Size = New Size(205, 38)
        btnUbah.FlatStyle = FlatStyle.Flat

        btnHapus.Text = "🗑️  Hapus"
        btnHapus.BackColor = Color.FromArgb(200, 50, 50)
        btnHapus.ForeColor = Color.White
        btnHapus.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        btnHapus.Location = New Point(15, 120)
        btnHapus.Size = New Size(205, 38)
        btnHapus.FlatStyle = FlatStyle.Flat

        btnBatal.Text = "✖  Batal"
        btnBatal.BackColor = Color.FromArgb(100, 100, 100)
        btnBatal.ForeColor = Color.White
        btnBatal.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        btnBatal.Location = New Point(15, 166)
        btnBatal.Size = New Size(205, 38)
        btnBatal.FlatStyle = FlatStyle.Flat

        ' ---- Tombol Kelola Penyewa ----
        btnKelolaPenyewa.Text = "👤  Kelola Data Penyewa"
        btnKelolaPenyewa.BackColor = Color.FromArgb(30, 100, 180)
        btnKelolaPenyewa.ForeColor = Color.White
        btnKelolaPenyewa.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        btnKelolaPenyewa.Location = New Point(385, 170)
        btnKelolaPenyewa.Size = New Size(250, 45)
        btnKelolaPenyewa.FlatStyle = FlatStyle.Flat

        ' ---- DataGridView Kamar ----
        dgvKamar.Location = New Point(15, 300)
        dgvKamar.Size = New Size(870, 250)
        dgvKamar.ReadOnly = True
        dgvKamar.AllowUserToAddRows = False
        dgvKamar.AllowUserToDeleteRows = False
        dgvKamar.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvKamar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvKamar.BackgroundColor = Color.White
        dgvKamar.Font = New Font("Segoe UI", 9)
        dgvKamar.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(40, 40, 120)
        dgvKamar.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        dgvKamar.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        dgvKamar.EnableHeadersVisualStyles = False
        dgvKamar.RowHeadersVisible = False
        dgvKamar.GridColor = Color.LightGray

        ' ---- Label Info ----
        lblInfo.Text = "ℹ️ Klik baris pada tabel untuk mengisi form, lalu klik Ubah atau Hapus"
        lblInfo.AutoSize = True
        lblInfo.Font = New Font("Segoe UI", 9, FontStyle.Italic)
        lblInfo.ForeColor = Color.Gray
        lblInfo.Location = New Point(15, 560)

        ' ---- Form1 ----
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        ClientSize = New Size(900, 590)
        MainMenuStrip = MainMenuStrip
        Controls.Add(MainMenuStrip)
        Controls.Add(lblJudul)
        Controls.Add(lblGaris)
        Controls.Add(grpDataKamar)
        Controls.Add(grpPencarian)
        Controls.Add(btnKelolaPenyewa)
        Controls.Add(grpAksi)
        Controls.Add(dgvKamar)
        Controls.Add(lblInfo)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Sistem Manajemen Kost - Data Kamar"

        MainMenuStrip.ResumeLayout(False)
        MainMenuStrip.PerformLayout()
        grpDataKamar.ResumeLayout(False)
        grpDataKamar.PerformLayout()
        grpPencarian.ResumeLayout(False)
        grpPencarian.PerformLayout()
        grpAksi.ResumeLayout(False)
        CType(dgvKamar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MainMenuStrip As MenuStrip
    Friend WithEvents mnuData As ToolStripMenuItem
    Friend WithEvents mnuKamar As ToolStripMenuItem
    Friend WithEvents mnuPenyewa As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents mnuKeluar As ToolStripMenuItem
    Friend WithEvents lblJudul As Label
    Friend WithEvents lblGaris As Label
    Friend WithEvents grpDataKamar As GroupBox
    Friend WithEvents lblJenis As Label
    Friend WithEvents txtJenis As TextBox
    Friend WithEvents lblNomor As Label
    Friend WithEvents txtNomor As TextBox
    Friend WithEvents lblHarga As Label
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents lblStatus As Label
    Friend WithEvents cmbStatus As ComboBox
    Friend WithEvents grpPencarian As GroupBox
    Friend WithEvents lblCari As Label
    Friend WithEvents txtCari As TextBox
    Friend WithEvents grpAksi As GroupBox
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents btnKelolaPenyewa As Button
    Friend WithEvents dgvKamar As DataGridView
    Friend WithEvents lblInfo As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider

End Class
