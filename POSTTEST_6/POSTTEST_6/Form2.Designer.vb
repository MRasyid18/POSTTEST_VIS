<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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

        ' ---- MenuStrip ----
        MainMenuStrip2 = New MenuStrip()
        mnuData2 = New ToolStripMenuItem()
        mnuKamar = New ToolStripMenuItem()
        mnuPenyewa = New ToolStripMenuItem()
        ToolStripSep2 = New ToolStripSeparator()
        mnuKeluar = New ToolStripMenuItem()

        ' ---- Controls ----
        lblJudul2 = New Label()
        lblGaris2 = New Label()

        grpDataPenyewa = New GroupBox()
        lblKamar = New Label()
        cmbKamar = New ComboBox()
        lblNama = New Label()
        txtNama = New TextBox()
        lblTelp = New Label()
        txtTelp = New TextBox()
        lblMasuk = New Label()
        dtpMasuk = New DateTimePicker()
        lblKeluar = New Label()
        cbAktifSaja = New CheckBox()
        dtpKeluar = New DateTimePicker()
        lblStatusSewa = New Label()
        cmbStatusSewa = New ComboBox()

        grpPencarian2 = New GroupBox()
        lblCari2 = New Label()
        txtCari = New TextBox()

        grpAksi2 = New GroupBox()
        btnSimpan = New Button()
        btnUbah = New Button()
        btnHapus = New Button()
        btnBatal = New Button()
        btnKembali = New Button()

        dgvPenyewa = New DataGridView()
        lblInfo2 = New Label()
        ErrorProvider1 = New ErrorProvider(components)

        MainMenuStrip2.SuspendLayout()
        grpDataPenyewa.SuspendLayout()
        grpPencarian2.SuspendLayout()
        grpAksi2.SuspendLayout()
        CType(dgvPenyewa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()

        ' ---- MenuStrip ----
        MainMenuStrip2.Items.AddRange(New ToolStripItem() {mnuData2})
        MainMenuStrip2.Location = New Point(0, 0)
        MainMenuStrip2.Name = "MainMenuStrip2"
        MainMenuStrip2.Size = New Size(960, 28)
        MainMenuStrip2.BackColor = Color.FromArgb(60, 60, 60)
        MainMenuStrip2.ForeColor = Color.White

        mnuData2.DropDownItems.AddRange(New ToolStripItem() {mnuKamar, mnuPenyewa, ToolStripSep2, mnuKeluar})
        mnuData2.Name = "mnuData2"
        mnuData2.Text = "Menu"
        mnuData2.ForeColor = Color.White

        mnuKamar.Name = "mnuKamar"
        mnuKamar.Text = "Data Kamar"
        mnuKamar.ForeColor = Color.Black

        mnuPenyewa.Name = "mnuPenyewa"
        mnuPenyewa.Text = "Data Penyewa"
        mnuPenyewa.ForeColor = Color.Black

        ToolStripSep2.Name = "ToolStripSep2"

        mnuKeluar.Name = "mnuKeluar"
        mnuKeluar.Text = "Keluar"
        mnuKeluar.ForeColor = Color.Red

        ' ---- Label Judul ----
        lblJudul2.AutoSize = True
        lblJudul2.Font = New Font("Segoe UI", 14, FontStyle.Bold Or FontStyle.Italic)
        lblJudul2.ForeColor = Color.FromArgb(120, 40, 40)
        lblJudul2.Location = New Point(270, 38)
        lblJudul2.Name = "lblJudul2"
        lblJudul2.Text = "SISTEM MANAJEMEN KOST - DATA PENYEWA"

        ' ---- Garis Pemisah ----
        lblGaris2.AutoSize = False
        lblGaris2.BorderStyle = BorderStyle.Fixed3D
        lblGaris2.Location = New Point(10, 70)
        lblGaris2.Name = "lblGaris2"
        lblGaris2.Size = New Size(935, 2)

        ' ---- GroupBox Data Penyewa ----
        grpDataPenyewa.Text = "Data Penyewa"
        grpDataPenyewa.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        grpDataPenyewa.BackColor = Color.FromArgb(220, 235, 255)
        grpDataPenyewa.Location = New Point(15, 80)
        grpDataPenyewa.Size = New Size(450, 230)
        grpDataPenyewa.Controls.AddRange(New Control() {
            lblKamar, cmbKamar, lblNama, txtNama, lblTelp, txtTelp,
            lblMasuk, dtpMasuk, lblKeluar, cbAktifSaja, dtpKeluar,
            lblStatusSewa, cmbStatusSewa
        })

        lblKamar.Text = "Kamar"
        lblKamar.Location = New Point(15, 30)
        lblKamar.AutoSize = True
        lblKamar.BackColor = Color.Transparent

        cmbKamar.Location = New Point(140, 27)
        cmbKamar.Size = New Size(290, 31)
        cmbKamar.Font = New Font("Segoe UI", 9)
        cmbKamar.DropDownStyle = ComboBoxStyle.DropDownList

        lblNama.Text = "Nama Penyewa"
        lblNama.Location = New Point(15, 70)
        lblNama.AutoSize = True
        lblNama.BackColor = Color.Transparent

        txtNama.Location = New Point(140, 67)
        txtNama.Size = New Size(290, 30)
        txtNama.Font = New Font("Segoe UI", 10)
        txtNama.PlaceholderText = "Nama lengkap penyewa"

        lblTelp.Text = "No. Telepon"
        lblTelp.Location = New Point(15, 110)
        lblTelp.AutoSize = True
        lblTelp.BackColor = Color.Transparent

        txtTelp.Location = New Point(140, 107)
        txtTelp.Size = New Size(290, 30)
        txtTelp.Font = New Font("Segoe UI", 10)
        txtTelp.PlaceholderText = "Contoh: 081234567890"

        lblMasuk.Text = "Tanggal Masuk"
        lblMasuk.Location = New Point(15, 150)
        lblMasuk.AutoSize = True
        lblMasuk.BackColor = Color.Transparent

        dtpMasuk.Location = New Point(140, 147)
        dtpMasuk.Size = New Size(180, 30)
        dtpMasuk.Format = DateTimePickerFormat.Short

        lblKeluar.Text = "Tanggal Keluar"
        lblKeluar.Location = New Point(15, 192)
        lblKeluar.AutoSize = True
        lblKeluar.BackColor = Color.Transparent

        cbAktifSaja.Text = "Belum Keluar"
        cbAktifSaja.Location = New Point(140, 190)
        cbAktifSaja.AutoSize = True
        cbAktifSaja.Checked = True
        cbAktifSaja.BackColor = Color.Transparent

        dtpKeluar.Location = New Point(255, 190)
        dtpKeluar.Size = New Size(170, 30)
        dtpKeluar.Format = DateTimePickerFormat.Short
        dtpKeluar.Enabled = False

        lblStatusSewa.Text = "Status Sewa"
        lblStatusSewa.Location = New Point(15, 40)
        lblStatusSewa.Name = "lblStatusSewa"
        lblStatusSewa.AutoSize = True
        lblStatusSewa.BackColor = Color.Transparent

        cmbStatusSewa.Location = New Point(140, 37)
        cmbStatusSewa.Size = New Size(150, 31)
        cmbStatusSewa.Font = New Font("Segoe UI", 10)
        cmbStatusSewa.DropDownStyle = ComboBoxStyle.DropDownList

        ' Pindahkan lblStatusSewa dan cmbStatusSewa ke luar grpDataPenyewa
        ' Akan ditambahkan ke form langsung

        ' ---- GroupBox Pencarian ----
        grpPencarian2.Text = "Pencarian"
        grpPencarian2.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        grpPencarian2.BackColor = Color.FromArgb(220, 235, 255)
        grpPencarian2.Location = New Point(475, 80)
        grpPencarian2.Size = New Size(250, 80)
        grpPencarian2.Controls.AddRange(New Control() {lblCari2, txtCari})

        lblCari2.Text = "Cari"
        lblCari2.Location = New Point(15, 35)
        lblCari2.AutoSize = True
        lblCari2.BackColor = Color.Transparent

        txtCari.Location = New Point(60, 32)
        txtCari.Size = New Size(170, 30)
        txtCari.PlaceholderText = "Nama/Kamar/Status..."
        txtCari.Font = New Font("Segoe UI", 10)

        ' ---- GroupBox Aksi ----
        grpAksi2.Text = "Aksi"
        grpAksi2.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        grpAksi2.BackColor = Color.FromArgb(220, 235, 255)
        grpAksi2.Location = New Point(735, 80)
        grpAksi2.Size = New Size(210, 230)
        grpAksi2.Controls.AddRange(New Control() {btnSimpan, btnUbah, btnHapus, btnBatal, btnKembali})

        btnSimpan.Text = "💾  Simpan"
        btnSimpan.BackColor = Color.FromArgb(46, 160, 67)
        btnSimpan.ForeColor = Color.White
        btnSimpan.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        btnSimpan.Location = New Point(12, 28)
        btnSimpan.Size = New Size(186, 38)
        btnSimpan.FlatStyle = FlatStyle.Flat

        btnUbah.Text = "✏️  Ubah"
        btnUbah.BackColor = Color.FromArgb(255, 165, 0)
        btnUbah.ForeColor = Color.White
        btnUbah.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        btnUbah.Location = New Point(12, 74)
        btnUbah.Size = New Size(186, 38)
        btnUbah.FlatStyle = FlatStyle.Flat

        btnHapus.Text = "🗑️  Hapus"
        btnHapus.BackColor = Color.FromArgb(200, 50, 50)
        btnHapus.ForeColor = Color.White
        btnHapus.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        btnHapus.Location = New Point(12, 120)
        btnHapus.Size = New Size(186, 38)
        btnHapus.FlatStyle = FlatStyle.Flat

        btnBatal.Text = "✖  Batal"
        btnBatal.BackColor = Color.FromArgb(100, 100, 100)
        btnBatal.ForeColor = Color.White
        btnBatal.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        btnBatal.Location = New Point(12, 166)
        btnBatal.Size = New Size(186, 38)
        btnBatal.FlatStyle = FlatStyle.Flat

        btnKembali.Text = "⬅  Kembali ke Data Kamar"
        btnKembali.BackColor = Color.FromArgb(30, 100, 180)
        btnKembali.ForeColor = Color.White
        btnKembali.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        btnKembali.Location = New Point(475, 175)
        btnKembali.Size = New Size(250, 40)
        btnKembali.FlatStyle = FlatStyle.Flat

        ' ---- Status Sewa (di luar grpDataPenyewa) ----
        lblStatusSewa.Location = New Point(475, 125)
        lblStatusSewa.Size = New Size(100, 25)
        lblStatusSewa.BackColor = Color.Transparent
        lblStatusSewa.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        cmbStatusSewa.Location = New Point(580, 122)
        cmbStatusSewa.Size = New Size(140, 31)

        ' ---- DataGridView Penyewa ----
        dgvPenyewa.Location = New Point(15, 325)
        dgvPenyewa.Size = New Size(930, 230)
        dgvPenyewa.ReadOnly = True
        dgvPenyewa.AllowUserToAddRows = False
        dgvPenyewa.AllowUserToDeleteRows = False
        dgvPenyewa.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvPenyewa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvPenyewa.BackgroundColor = Color.White
        dgvPenyewa.Font = New Font("Segoe UI", 9)
        dgvPenyewa.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(120, 40, 40)
        dgvPenyewa.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        dgvPenyewa.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        dgvPenyewa.EnableHeadersVisualStyles = False
        dgvPenyewa.RowHeadersVisible = False
        dgvPenyewa.GridColor = Color.LightGray

        ' ---- Label Info ----
        lblInfo2.Text = "ℹ️ Klik baris pada tabel untuk mengisi form, lalu klik Ubah atau Hapus. " &
                        "Relasi: tbpenyewa.idKamar → tbkamar.idKamar (FK RESTRICT)"
        lblInfo2.AutoSize = True
        lblInfo2.Font = New Font("Segoe UI", 9, FontStyle.Italic)
        lblInfo2.ForeColor = Color.Gray
        lblInfo2.Location = New Point(15, 565)

        ' ---- Form2 ----
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        ClientSize = New Size(960, 600)
        MainMenuStrip = MainMenuStrip2
        Controls.Add(MainMenuStrip2)
        Controls.Add(lblJudul2)
        Controls.Add(lblGaris2)
        Controls.Add(grpDataPenyewa)
        Controls.Add(grpPencarian2)
        Controls.Add(lblStatusSewa)
        Controls.Add(cmbStatusSewa)
        Controls.Add(grpAksi2)
        Controls.Add(btnKembali)
        Controls.Add(dgvPenyewa)
        Controls.Add(lblInfo2)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "Form2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Sistem Manajemen Kost - Data Penyewa"

        MainMenuStrip2.ResumeLayout(False)
        MainMenuStrip2.PerformLayout()
        grpDataPenyewa.ResumeLayout(False)
        grpDataPenyewa.PerformLayout()
        grpPencarian2.ResumeLayout(False)
        grpPencarian2.PerformLayout()
        grpAksi2.ResumeLayout(False)
        CType(dgvPenyewa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MainMenuStrip2 As MenuStrip
    Friend WithEvents mnuData2 As ToolStripMenuItem
    Friend WithEvents mnuKamar As ToolStripMenuItem
    Friend WithEvents mnuPenyewa As ToolStripMenuItem
    Friend WithEvents ToolStripSep2 As ToolStripSeparator
    Friend WithEvents mnuKeluar As ToolStripMenuItem
    Friend WithEvents lblJudul2 As Label
    Friend WithEvents lblGaris2 As Label
    Friend WithEvents grpDataPenyewa As GroupBox
    Friend WithEvents lblKamar As Label
    Friend WithEvents cmbKamar As ComboBox
    Friend WithEvents lblNama As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents lblTelp As Label
    Friend WithEvents txtTelp As TextBox
    Friend WithEvents lblMasuk As Label
    Friend WithEvents dtpMasuk As DateTimePicker
    Friend WithEvents lblKeluar As Label
    Friend WithEvents cbAktifSaja As CheckBox
    Friend WithEvents dtpKeluar As DateTimePicker
    Friend WithEvents lblStatusSewa As Label
    Friend WithEvents cmbStatusSewa As ComboBox
    Friend WithEvents grpPencarian2 As GroupBox
    Friend WithEvents lblCari2 As Label
    Friend WithEvents txtCari As TextBox
    Friend WithEvents grpAksi2 As GroupBox
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents btnKembali As Button
    Friend WithEvents dgvPenyewa As DataGridView
    Friend WithEvents lblInfo2 As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider

End Class
