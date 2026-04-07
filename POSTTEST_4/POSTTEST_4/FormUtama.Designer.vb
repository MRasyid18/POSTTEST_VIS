<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormUtama
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        MenuStrip1 = New MenuStrip()
        InputDataToolStripMenuItem = New ToolStripMenuItem()
        LihatKartuToolStripMenuItem = New ToolStripMenuItem()
        SimpanDataToolStripMenuItem = New ToolStripMenuItem()
        BukaDataToolStripMenuItem = New ToolStripMenuItem()
        KeluarToolStripMenuItem = New ToolStripMenuItem()
        lblJudul = New Label()
        tabControlUtama = New TabControl()
        tabDataUtama = New TabPage()
        btnLanjut1 = New Button()
        cmbKomunitas = New ComboBox()
        gbJK = New GroupBox()
        rbLaki = New RadioButton()
        rbPerempuan = New RadioButton()
        dtpTanggalLahir = New DateTimePicker()
        txtIdAnggota = New TextBox()
        txtNama = New TextBox()
        lblKomunitas = New Label()
        lblJK = New Label()
        lblTglLahir = New Label()
        lblId = New Label()
        lblNama = New Label()
        tabKontak = New TabPage()
        btnLanjut2 = New Button()
        btnKembali2 = New Button()
        txtAlamat = New TextBox()
        lblAlamat = New Label()
        txtEmail = New TextBox()
        lblEmail = New Label()
        mtbTelepon = New MaskedTextBox()
        lblTelp = New Label()
        tabProfil = New TabPage()
        btnKembali3 = New Button()
        btnSimpanCetak = New Button()
        gbAktivitas = New GroupBox()
        chkAI = New RadioButton()
        chkCloud = New RadioButton()
        chkMobile = New RadioButton()
        chkData = New RadioButton()
        chkHacking = New RadioButton()
        chkGame = New RadioButton()
        chkDesain = New RadioButton()
        chkCoding = New RadioButton()
        gbPeran = New GroupBox()
        rbAdmin = New RadioButton()
        rbAnggota = New RadioButton()
        rbKetua = New RadioButton()
        btnBrowse = New Button()
        picFotoProfil = New PictureBox()
        lblFoto = New Label()
        PictureBox1 = New PictureBox()
        ErrorProvider1 = New ErrorProvider(components)
        OpenFileDialog1 = New OpenFileDialog()
        SaveFileDialog1 = New SaveFileDialog()
        MenuStrip1.SuspendLayout()
        tabControlUtama.SuspendLayout()
        tabDataUtama.SuspendLayout()
        gbJK.SuspendLayout()
        tabKontak.SuspendLayout()
        tabProfil.SuspendLayout()
        gbAktivitas.SuspendLayout()
        gbPeran.SuspendLayout()
        CType(picFotoProfil, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {InputDataToolStripMenuItem, LihatKartuToolStripMenuItem, SimpanDataToolStripMenuItem, BukaDataToolStripMenuItem, KeluarToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(962, 28)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' InputDataToolStripMenuItem
        ' 
        InputDataToolStripMenuItem.Name = "InputDataToolStripMenuItem"
        InputDataToolStripMenuItem.Size = New Size(93, 24)
        InputDataToolStripMenuItem.Text = "Input Data"
        ' 
        ' LihatKartuToolStripMenuItem
        ' 
        LihatKartuToolStripMenuItem.Name = "LihatKartuToolStripMenuItem"
        LihatKartuToolStripMenuItem.Size = New Size(94, 24)
        LihatKartuToolStripMenuItem.Text = "Lihat Kartu"
        ' 
        ' SimpanDataToolStripMenuItem
        ' 
        SimpanDataToolStripMenuItem.Name = "SimpanDataToolStripMenuItem"
        SimpanDataToolStripMenuItem.Size = New Size(109, 24)
        SimpanDataToolStripMenuItem.Text = "Simpan Data"
        ' 
        ' BukaDataToolStripMenuItem
        ' 
        BukaDataToolStripMenuItem.Name = "BukaDataToolStripMenuItem"
        BukaDataToolStripMenuItem.Size = New Size(95, 24)
        BukaDataToolStripMenuItem.Text = " Buka Data"
        ' 
        ' KeluarToolStripMenuItem
        ' 
        KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        KeluarToolStripMenuItem.Size = New Size(65, 24)
        KeluarToolStripMenuItem.Text = "Keluar"
        ' 
        ' lblJudul
        ' 
        lblJudul.AutoSize = True
        lblJudul.BackColor = Color.Gainsboro
        lblJudul.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblJudul.ForeColor = Color.FromArgb(CByte(0), CByte(100), CByte(200))
        lblJudul.Location = New Point(95, 35)
        lblJudul.Name = "lblJudul"
        lblJudul.Size = New Size(587, 46)
        lblJudul.TabIndex = 1
        lblJudul.Text = "NEXUS COMMUNITY - Card System"
        ' 
        ' tabControlUtama
        ' 
        tabControlUtama.Controls.Add(tabDataUtama)
        tabControlUtama.Controls.Add(tabKontak)
        tabControlUtama.Controls.Add(tabProfil)
        tabControlUtama.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        tabControlUtama.Location = New Point(41, 103)
        tabControlUtama.Name = "tabControlUtama"
        tabControlUtama.SelectedIndex = 0
        tabControlUtama.Size = New Size(648, 415)
        tabControlUtama.TabIndex = 2
        ' 
        ' tabDataUtama
        ' 
        tabDataUtama.BackColor = SystemColors.ActiveCaption
        tabDataUtama.Controls.Add(btnLanjut1)
        tabDataUtama.Controls.Add(cmbKomunitas)
        tabDataUtama.Controls.Add(gbJK)
        tabDataUtama.Controls.Add(dtpTanggalLahir)
        tabDataUtama.Controls.Add(txtIdAnggota)
        tabDataUtama.Controls.Add(txtNama)
        tabDataUtama.Controls.Add(lblKomunitas)
        tabDataUtama.Controls.Add(lblJK)
        tabDataUtama.Controls.Add(lblTglLahir)
        tabDataUtama.Controls.Add(lblId)
        tabDataUtama.Controls.Add(lblNama)
        tabDataUtama.Location = New Point(4, 34)
        tabDataUtama.Name = "tabDataUtama"
        tabDataUtama.Padding = New Padding(3)
        tabDataUtama.Size = New Size(640, 377)
        tabDataUtama.TabIndex = 0
        tabDataUtama.Text = "Data Utama"
        ' 
        ' btnLanjut1
        ' 
        btnLanjut1.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        btnLanjut1.Location = New Point(544, 331)
        btnLanjut1.Name = "btnLanjut1"
        btnLanjut1.Size = New Size(90, 40)
        btnLanjut1.TabIndex = 12
        btnLanjut1.Text = "Lanjut"
        btnLanjut1.UseVisualStyleBackColor = False
        ' 
        ' cmbKomunitas
        ' 
        cmbKomunitas.DropDownStyle = ComboBoxStyle.DropDownList
        cmbKomunitas.FormattingEnabled = True
        cmbKomunitas.Items.AddRange(New Object() {"Programming & Software Dev", "", "Desain Grafis & UI/UX", "", "Kecerdasan Buatan (AI/ML)", "", "Jaringan & Keamanan Siber", "", "Game Development", "", "Data Science & Analytics", "", "Robotika & IoT", "", "Mobile Development"})
        cmbKomunitas.Location = New Point(267, 172)
        cmbKomunitas.Name = "cmbKomunitas"
        cmbKomunitas.Size = New Size(301, 33)
        cmbKomunitas.TabIndex = 8
        ' 
        ' gbJK
        ' 
        gbJK.Controls.Add(rbLaki)
        gbJK.Controls.Add(rbPerempuan)
        gbJK.Location = New Point(267, 211)
        gbJK.Name = "gbJK"
        gbJK.Size = New Size(301, 78)
        gbJK.TabIndex = 11
        gbJK.TabStop = False
        ' 
        ' rbLaki
        ' 
        rbLaki.AutoSize = True
        rbLaki.Location = New Point(20, 16)
        rbLaki.Name = "rbLaki"
        rbLaki.Size = New Size(102, 29)
        rbLaki.TabIndex = 10
        rbLaki.TabStop = True
        rbLaki.Text = "Laki-laki"
        rbLaki.UseVisualStyleBackColor = True
        ' 
        ' rbPerempuan
        ' 
        rbPerempuan.AutoSize = True
        rbPerempuan.Location = New Point(20, 49)
        rbPerempuan.Name = "rbPerempuan"
        rbPerempuan.Size = New Size(125, 29)
        rbPerempuan.TabIndex = 9
        rbPerempuan.TabStop = True
        rbPerempuan.Text = "Perempuan"
        rbPerempuan.UseVisualStyleBackColor = True
        ' 
        ' dtpTanggalLahir
        ' 
        dtpTanggalLahir.Location = New Point(267, 123)
        dtpTanggalLahir.Name = "dtpTanggalLahir"
        dtpTanggalLahir.Size = New Size(301, 32)
        dtpTanggalLahir.TabIndex = 7
        ' 
        ' txtIdAnggota
        ' 
        txtIdAnggota.Location = New Point(267, 71)
        txtIdAnggota.Name = "txtIdAnggota"
        txtIdAnggota.Size = New Size(301, 32)
        txtIdAnggota.TabIndex = 6
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(267, 33)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(301, 32)
        txtNama.TabIndex = 5
        ' 
        ' lblKomunitas
        ' 
        lblKomunitas.AutoSize = True
        lblKomunitas.Location = New Point(34, 172)
        lblKomunitas.Name = "lblKomunitas"
        lblKomunitas.Size = New Size(193, 25)
        lblKomunitas.TabIndex = 4
        lblKomunitas.Text = "Jenis komunitas/DIvisi"
        ' 
        ' lblJK
        ' 
        lblJK.AutoSize = True
        lblJK.Location = New Point(34, 229)
        lblJK.Name = "lblJK"
        lblJK.Size = New Size(120, 25)
        lblJK.TabIndex = 3
        lblJK.Text = "Jenis kelamin"
        ' 
        ' lblTglLahir
        ' 
        lblTglLahir.AutoSize = True
        lblTglLahir.Location = New Point(36, 123)
        lblTglLahir.Name = "lblTglLahir"
        lblTglLahir.Size = New Size(123, 25)
        lblTglLahir.TabIndex = 2
        lblTglLahir.Text = "Tanggal Lahir"
        ' 
        ' lblId
        ' 
        lblId.AutoSize = True
        lblId.Location = New Point(34, 78)
        lblId.Name = "lblId"
        lblId.Size = New Size(103, 25)
        lblId.TabIndex = 1
        lblId.Text = "ID Anggota"
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Location = New Point(36, 33)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(62, 25)
        lblNama.TabIndex = 0
        lblNama.Text = "Nama"
        ' 
        ' tabKontak
        ' 
        tabKontak.BackColor = SystemColors.ActiveCaption
        tabKontak.Controls.Add(btnLanjut2)
        tabKontak.Controls.Add(btnKembali2)
        tabKontak.Controls.Add(txtAlamat)
        tabKontak.Controls.Add(lblAlamat)
        tabKontak.Controls.Add(txtEmail)
        tabKontak.Controls.Add(lblEmail)
        tabKontak.Controls.Add(mtbTelepon)
        tabKontak.Controls.Add(lblTelp)
        tabKontak.Location = New Point(4, 34)
        tabKontak.Name = "tabKontak"
        tabKontak.Padding = New Padding(3)
        tabKontak.Size = New Size(640, 377)
        tabKontak.TabIndex = 1
        tabKontak.Text = "Kontak & Info"
        ' 
        ' btnLanjut2
        ' 
        btnLanjut2.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        btnLanjut2.Location = New Point(544, 332)
        btnLanjut2.Name = "btnLanjut2"
        btnLanjut2.Size = New Size(90, 39)
        btnLanjut2.TabIndex = 10
        btnLanjut2.Text = "Lanjut"
        btnLanjut2.UseVisualStyleBackColor = False
        ' 
        ' btnKembali2
        ' 
        btnKembali2.BackColor = Color.Red
        btnKembali2.Location = New Point(6, 332)
        btnKembali2.Name = "btnKembali2"
        btnKembali2.Size = New Size(90, 39)
        btnKembali2.TabIndex = 9
        btnKembali2.Text = "Kembali"
        btnKembali2.UseVisualStyleBackColor = False
        ' 
        ' txtAlamat
        ' 
        txtAlamat.Location = New Point(226, 193)
        txtAlamat.Multiline = True
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(253, 140)
        txtAlamat.TabIndex = 8
        ' 
        ' lblAlamat
        ' 
        lblAlamat.AutoSize = True
        lblAlamat.Location = New Point(34, 193)
        lblAlamat.Name = "lblAlamat"
        lblAlamat.Size = New Size(143, 25)
        lblAlamat.TabIndex = 7
        lblAlamat.Text = "Alamat Lengkap"
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(226, 108)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(253, 32)
        txtEmail.TabIndex = 6
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Location = New Point(34, 111)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(57, 25)
        lblEmail.TabIndex = 3
        lblEmail.Text = "Email"
        ' 
        ' mtbTelepon
        ' 
        mtbTelepon.Location = New Point(226, 36)
        mtbTelepon.Mask = "0000-0000-0000"
        mtbTelepon.Name = "mtbTelepon"
        mtbTelepon.Size = New Size(253, 32)
        mtbTelepon.TabIndex = 2
        ' 
        ' lblTelp
        ' 
        lblTelp.AutoSize = True
        lblTelp.Location = New Point(34, 36)
        lblTelp.Name = "lblTelp"
        lblTelp.Size = New Size(137, 25)
        lblTelp.TabIndex = 1
        lblTelp.Text = "Nomor Telepon"
        ' 
        ' tabProfil
        ' 
        tabProfil.BackColor = SystemColors.ActiveCaption
        tabProfil.Controls.Add(btnKembali3)
        tabProfil.Controls.Add(btnSimpanCetak)
        tabProfil.Controls.Add(gbAktivitas)
        tabProfil.Controls.Add(gbPeran)
        tabProfil.Controls.Add(btnBrowse)
        tabProfil.Controls.Add(picFotoProfil)
        tabProfil.Controls.Add(lblFoto)
        tabProfil.Location = New Point(4, 34)
        tabProfil.Name = "tabProfil"
        tabProfil.Padding = New Padding(3)
        tabProfil.Size = New Size(640, 377)
        tabProfil.TabIndex = 2
        tabProfil.Text = "Profil & Aktivitas"
        ' 
        ' btnKembali3
        ' 
        btnKembali3.BackColor = Color.Red
        btnKembali3.Location = New Point(6, 332)
        btnKembali3.Name = "btnKembali3"
        btnKembali3.Size = New Size(90, 42)
        btnKembali3.TabIndex = 12
        btnKembali3.Text = "Kembali"
        btnKembali3.UseVisualStyleBackColor = False
        ' 
        ' btnSimpanCetak
        ' 
        btnSimpanCetak.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        btnSimpanCetak.Location = New Point(464, 332)
        btnSimpanCetak.Name = "btnSimpanCetak"
        btnSimpanCetak.Size = New Size(170, 39)
        btnSimpanCetak.TabIndex = 11
        btnSimpanCetak.Text = "Simpan dan Cetak"
        btnSimpanCetak.UseVisualStyleBackColor = False
        ' 
        ' gbAktivitas
        ' 
        gbAktivitas.Controls.Add(chkAI)
        gbAktivitas.Controls.Add(chkCloud)
        gbAktivitas.Controls.Add(chkMobile)
        gbAktivitas.Controls.Add(chkData)
        gbAktivitas.Controls.Add(chkHacking)
        gbAktivitas.Controls.Add(chkGame)
        gbAktivitas.Controls.Add(chkDesain)
        gbAktivitas.Controls.Add(chkCoding)
        gbAktivitas.Location = New Point(273, 169)
        gbAktivitas.Name = "gbAktivitas"
        gbAktivitas.Size = New Size(349, 157)
        gbAktivitas.TabIndex = 6
        gbAktivitas.TabStop = False
        gbAktivitas.Text = "Aktivitas"
        ' 
        ' chkAI
        ' 
        chkAI.AutoSize = True
        chkAI.Location = New Point(179, 126)
        chkAI.Name = "chkAI"
        chkAI.Size = New Size(50, 29)
        chkAI.TabIndex = 7
        chkAI.TabStop = True
        chkAI.Text = "AI"
        chkAI.UseVisualStyleBackColor = True
        ' 
        ' chkCloud
        ' 
        chkCloud.AutoSize = True
        chkCloud.Location = New Point(179, 91)
        chkCloud.Name = "chkCloud"
        chkCloud.Size = New Size(172, 29)
        chkCloud.TabIndex = 6
        chkCloud.TabStop = True
        chkCloud.Text = "Cloud Computing"
        chkCloud.UseVisualStyleBackColor = True
        ' 
        ' chkMobile
        ' 
        chkMobile.AutoSize = True
        chkMobile.Location = New Point(179, 56)
        chkMobile.Name = "chkMobile"
        chkMobile.Size = New Size(123, 29)
        chkMobile.TabIndex = 5
        chkMobile.TabStop = True
        chkMobile.Text = "Mobile Dev"
        chkMobile.UseVisualStyleBackColor = True
        ' 
        ' chkData
        ' 
        chkData.AutoSize = True
        chkData.Location = New Point(179, 21)
        chkData.Name = "chkData"
        chkData.Size = New Size(144, 29)
        chkData.TabIndex = 4
        chkData.TabStop = True
        chkData.Text = "Data Analysis"
        chkData.UseVisualStyleBackColor = True
        ' 
        ' chkHacking
        ' 
        chkHacking.AutoSize = True
        chkHacking.Location = New Point(31, 128)
        chkHacking.Name = "chkHacking"
        chkHacking.Size = New Size(98, 29)
        chkHacking.TabIndex = 3
        chkHacking.TabStop = True
        chkHacking.Text = "Hacking"
        chkHacking.UseVisualStyleBackColor = True
        ' 
        ' chkGame
        ' 
        chkGame.AutoSize = True
        chkGame.Location = New Point(31, 91)
        chkGame.Name = "chkGame"
        chkGame.Size = New Size(81, 29)
        chkGame.TabIndex = 2
        chkGame.TabStop = True
        chkGame.Text = "Game"
        chkGame.UseVisualStyleBackColor = True
        ' 
        ' chkDesain
        ' 
        chkDesain.AutoSize = True
        chkDesain.Location = New Point(31, 56)
        chkDesain.Name = "chkDesain"
        chkDesain.Size = New Size(143, 29)
        chkDesain.TabIndex = 1
        chkDesain.TabStop = True
        chkDesain.Text = "UI/UX Design"
        chkDesain.UseVisualStyleBackColor = True
        ' 
        ' chkCoding
        ' 
        chkCoding.AutoSize = True
        chkCoding.Location = New Point(31, 21)
        chkCoding.Name = "chkCoding"
        chkCoding.Size = New Size(89, 29)
        chkCoding.TabIndex = 0
        chkCoding.TabStop = True
        chkCoding.Text = "Coding"
        chkCoding.UseVisualStyleBackColor = True
        ' 
        ' gbPeran
        ' 
        gbPeran.Controls.Add(rbAdmin)
        gbPeran.Controls.Add(rbAnggota)
        gbPeran.Controls.Add(rbKetua)
        gbPeran.Location = New Point(33, 169)
        gbPeran.Name = "gbPeran"
        gbPeran.Size = New Size(199, 157)
        gbPeran.TabIndex = 5
        gbPeran.TabStop = False
        gbPeran.Text = "Peran/Jabatan"
        ' 
        ' rbAdmin
        ' 
        rbAdmin.AutoSize = True
        rbAdmin.Location = New Point(32, 111)
        rbAdmin.Name = "rbAdmin"
        rbAdmin.Size = New Size(86, 29)
        rbAdmin.TabIndex = 2
        rbAdmin.TabStop = True
        rbAdmin.Text = "Admin"
        rbAdmin.UseVisualStyleBackColor = True
        ' 
        ' rbAnggota
        ' 
        rbAnggota.AutoSize = True
        rbAnggota.Location = New Point(31, 76)
        rbAnggota.Name = "rbAnggota"
        rbAnggota.Size = New Size(101, 29)
        rbAnggota.TabIndex = 1
        rbAnggota.TabStop = True
        rbAnggota.Text = "Anggota"
        rbAnggota.UseVisualStyleBackColor = True
        ' 
        ' rbKetua
        ' 
        rbKetua.AutoSize = True
        rbKetua.Location = New Point(32, 41)
        rbKetua.Name = "rbKetua"
        rbKetua.Size = New Size(79, 29)
        rbKetua.TabIndex = 0
        rbKetua.TabStop = True
        rbKetua.Text = "Ketua"
        rbKetua.UseVisualStyleBackColor = True
        ' 
        ' btnBrowse
        ' 
        btnBrowse.Location = New Point(322, 110)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(94, 33)
        btnBrowse.TabIndex = 4
        btnBrowse.Text = "Browse"
        btnBrowse.UseVisualStyleBackColor = True
        ' 
        ' picFotoProfil
        ' 
        picFotoProfil.BackColor = Color.Black
        picFotoProfil.BorderStyle = BorderStyle.FixedSingle
        picFotoProfil.Location = New Point(187, 36)
        picFotoProfil.Name = "picFotoProfil"
        picFotoProfil.Size = New Size(120, 107)
        picFotoProfil.SizeMode = PictureBoxSizeMode.Zoom
        picFotoProfil.TabIndex = 3
        picFotoProfil.TabStop = False
        ' 
        ' lblFoto
        ' 
        lblFoto.AutoSize = True
        lblFoto.Location = New Point(33, 36)
        lblFoto.Name = "lblFoto"
        lblFoto.Size = New Size(96, 25)
        lblFoto.TabIndex = 2
        lblFoto.Text = "Foto Profil"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = My.Resources.Resources.Screenshot_2026_04_07_213213_removebg_preview
        PictureBox1.Location = New Point(695, 55)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(222, 170)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' FormUtama
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.Modern_blue_horizontal_banner_design_template__Business_background_with_space___
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(962, 673)
        Controls.Add(PictureBox1)
        Controls.Add(tabControlUtama)
        Controls.Add(lblJudul)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        MinimumSize = New Size(980, 720)
        Name = "FormUtama"
        Text = "Form1"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        tabControlUtama.ResumeLayout(False)
        tabDataUtama.ResumeLayout(False)
        tabDataUtama.PerformLayout()
        gbJK.ResumeLayout(False)
        gbJK.PerformLayout()
        tabKontak.ResumeLayout(False)
        tabKontak.PerformLayout()
        tabProfil.ResumeLayout(False)
        tabProfil.PerformLayout()
        gbAktivitas.ResumeLayout(False)
        gbAktivitas.PerformLayout()
        gbPeran.ResumeLayout(False)
        gbPeran.PerformLayout()
        CType(picFotoProfil, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents InputDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LihatKartuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SimpanDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BukaDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblJudul As Label
    Friend WithEvents tabControlUtama As TabControl
    Friend WithEvents tabDataUtama As TabPage
    Friend WithEvents tabKontak As TabPage
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents tabProfil As TabPage
    Friend WithEvents lblTglLahir As Label
    Friend WithEvents lblId As Label
    Friend WithEvents lblNama As Label
    Friend WithEvents rbLaki As RadioButton
    Friend WithEvents rbPerempuan As RadioButton
    Friend WithEvents cmbKomunitas As ComboBox
    Friend WithEvents dtpTanggalLahir As DateTimePicker
    Friend WithEvents txtIdAnggota As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents lblKomunitas As Label
    Friend WithEvents lblJK As Label
    Friend WithEvents gbJK As GroupBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents mtbTelepon As MaskedTextBox
    Friend WithEvents lblTelp As Label
    Friend WithEvents btnLanjut2 As Button
    Friend WithEvents btnKembali2 As Button
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents lblAlamat As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents picFotoProfil As PictureBox
    Friend WithEvents lblFoto As Label
    Friend WithEvents gbAktivitas As GroupBox
    Friend WithEvents chkHacking As RadioButton
    Friend WithEvents chkGame As RadioButton
    Friend WithEvents chkDesain As RadioButton
    Friend WithEvents chkCoding As RadioButton
    Friend WithEvents gbPeran As GroupBox
    Friend WithEvents rbAdmin As RadioButton
    Friend WithEvents rbAnggota As RadioButton
    Friend WithEvents rbKetua As RadioButton
    Friend WithEvents btnBrowse As Button
    Friend WithEvents chkAI As RadioButton
    Friend WithEvents chkCloud As RadioButton
    Friend WithEvents chkMobile As RadioButton
    Friend WithEvents chkData As RadioButton
    Friend WithEvents btnSimpanCetak As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents btnLanjut1 As Button
    Friend WithEvents btnKembali3 As Button

End Class
