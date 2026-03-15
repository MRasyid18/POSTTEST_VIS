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
        picFoto = New PictureBox()
        btnBrowse = New Button()
        btnCetakKartu = New Button()
        lblJudul = New Label()
        lblNama = New Label()
        lblUmur = New Label()
        lblTanggalLahir = New Label()
        lblNoTelpon = New Label()
        lblAlamat = New Label()
        lblFotoHint = New Label()
        txtNama = New TextBox()
        txtUmur = New TextBox()
        txtNoTelpon = New TextBox()
        txtAlamat = New TextBox()
        dtpTanggalLahir = New DateTimePicker()
        grpJenisKelamin = New GroupBox()
        rbLakiLaki = New RadioButton()
        rbPerempuan = New RadioButton()
        grpHobby = New GroupBox()
        chkGaming = New CheckBox()
        chkCoding = New CheckBox()
        chkTraveling = New CheckBox()
        chkMenggambar = New CheckBox()
        chkMenulis = New CheckBox()
        chkMasak = New CheckBox()
        chkMemancing = New CheckBox()
        chkMembaca = New CheckBox()
        chkOlahraga = New CheckBox()
        chkMenyanyi = New CheckBox()
        chkMenari = New CheckBox()
        chkFotografi = New CheckBox()
        CType(picFoto, ComponentModel.ISupportInitialize).BeginInit()
        grpJenisKelamin.SuspendLayout()
        grpHobby.SuspendLayout()
        SuspendLayout()
        ' 
        ' picFoto
        ' 
        picFoto.BackColor = Color.LightGray
        picFoto.BorderStyle = BorderStyle.FixedSingle
        picFoto.Location = New Point(20, 60)
        picFoto.Name = "picFoto"
        picFoto.Size = New Size(170, 190)
        picFoto.SizeMode = PictureBoxSizeMode.Zoom
        picFoto.TabIndex = 0
        picFoto.TabStop = False
        ' 
        ' btnBrowse
        ' 
        btnBrowse.BackColor = Color.SteelBlue
        btnBrowse.FlatStyle = FlatStyle.Flat
        btnBrowse.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBrowse.ForeColor = Color.White
        btnBrowse.Location = New Point(35, 295)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(140, 34)
        btnBrowse.TabIndex = 2
        btnBrowse.Text = "Browse Foto"
        btnBrowse.UseVisualStyleBackColor = False
        ' 
        ' btnCetakKartu
        ' 
        btnCetakKartu.BackColor = Color.SeaGreen
        btnCetakKartu.FlatStyle = FlatStyle.Flat
        btnCetakKartu.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCetakKartu.ForeColor = Color.White
        btnCetakKartu.Location = New Point(300, 475)
        btnCetakKartu.Name = "btnCetakKartu"
        btnCetakKartu.Size = New Size(240, 40)
        btnCetakKartu.TabIndex = 16
        btnCetakKartu.Text = "Cetak Kartu"
        btnCetakKartu.UseVisualStyleBackColor = False
        ' 
        ' lblJudul
        ' 
        lblJudul.BackColor = Color.SteelBlue
        lblJudul.Font = New Font("Segoe UI", 14.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblJudul.ForeColor = Color.White
        lblJudul.Location = New Point(0, 0)
        lblJudul.Name = "lblJudul"
        lblJudul.Size = New Size(884, 45)
        lblJudul.TabIndex = 3
        lblJudul.Text = "Form Input Data - Kartu Komunitas Coding"
        lblJudul.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblNama.Location = New Point(210, 60)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(114, 20)
        lblNama.TabIndex = 4
        lblNama.Text = "Nama Lengkap"
        ' 
        ' lblUmur
        ' 
        lblUmur.AutoSize = True
        lblUmur.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblUmur.Location = New Point(210, 120)
        lblUmur.Name = "lblUmur"
        lblUmur.Size = New Size(49, 20)
        lblUmur.TabIndex = 6
        lblUmur.Text = "Umur"
        ' 
        ' lblTanggalLahir
        ' 
        lblTanggalLahir.AutoSize = True
        lblTanggalLahir.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTanggalLahir.Location = New Point(210, 180)
        lblTanggalLahir.Name = "lblTanggalLahir"
        lblTanggalLahir.Size = New Size(103, 20)
        lblTanggalLahir.TabIndex = 8
        lblTanggalLahir.Text = "Tanggal Lahir"
        ' 
        ' lblNoTelpon
        ' 
        lblNoTelpon.AutoSize = True
        lblNoTelpon.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblNoTelpon.Location = New Point(210, 240)
        lblNoTelpon.Name = "lblNoTelpon"
        lblNoTelpon.Size = New Size(93, 20)
        lblNoTelpon.TabIndex = 10
        lblNoTelpon.Text = "No. Telepon"
        ' 
        ' lblAlamat
        ' 
        lblAlamat.AutoSize = True
        lblAlamat.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblAlamat.Location = New Point(210, 300)
        lblAlamat.Name = "lblAlamat"
        lblAlamat.Size = New Size(60, 20)
        lblAlamat.TabIndex = 12
        lblAlamat.Text = "Alamat"
        ' 
        ' lblFotoHint
        ' 
        lblFotoHint.Font = New Font("Segoe UI", 8.0F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblFotoHint.ForeColor = Color.Gray
        lblFotoHint.Location = New Point(20, 258)
        lblFotoHint.Name = "lblFotoHint"
        lblFotoHint.Size = New Size(170, 30)
        lblFotoHint.TabIndex = 1
        lblFotoHint.Text = "Klik Browse untuk memilih foto"
        lblFotoHint.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' txtNama
        ' 
        txtNama.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtNama.Location = New Point(210, 82)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(220, 30)
        txtNama.TabIndex = 5
        ' 
        ' txtUmur
        ' 
        txtUmur.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtUmur.Location = New Point(210, 142)
        txtUmur.MaxLength = 3
        txtUmur.Name = "txtUmur"
        txtUmur.Size = New Size(220, 30)
        txtUmur.TabIndex = 7
        ' 
        ' txtNoTelpon
        ' 
        txtNoTelpon.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtNoTelpon.Location = New Point(210, 262)
        txtNoTelpon.MaxLength = 15
        txtNoTelpon.Name = "txtNoTelpon"
        txtNoTelpon.Size = New Size(220, 30)
        txtNoTelpon.TabIndex = 11
        ' 
        ' txtAlamat
        ' 
        txtAlamat.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtAlamat.Location = New Point(210, 322)
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(220, 30)
        txtAlamat.TabIndex = 13
        ' 
        ' dtpTanggalLahir
        ' 
        dtpTanggalLahir.CustomFormat = "dd/MM/yyyy"
        dtpTanggalLahir.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        dtpTanggalLahir.Format = DateTimePickerFormat.Custom
        dtpTanggalLahir.Location = New Point(210, 202)
        dtpTanggalLahir.Name = "dtpTanggalLahir"
        dtpTanggalLahir.Size = New Size(220, 30)
        dtpTanggalLahir.TabIndex = 9
        ' 
        ' grpJenisKelamin
        ' 
        grpJenisKelamin.Controls.Add(rbLakiLaki)
        grpJenisKelamin.Controls.Add(rbPerempuan)
        grpJenisKelamin.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        grpJenisKelamin.Location = New Point(568, 276)
        grpJenisKelamin.Name = "grpJenisKelamin"
        grpJenisKelamin.Size = New Size(175, 90)
        grpJenisKelamin.TabIndex = 14
        grpJenisKelamin.TabStop = False
        grpJenisKelamin.Text = "Jenis Kelamin"
        ' 
        ' rbLakiLaki
        ' 
        rbLakiLaki.AutoSize = True
        rbLakiLaki.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        rbLakiLaki.Location = New Point(14, 28)
        rbLakiLaki.Name = "rbLakiLaki"
        rbLakiLaki.Size = New Size(88, 24)
        rbLakiLaki.TabIndex = 0
        rbLakiLaki.Text = "Laki-Laki"
        rbLakiLaki.UseVisualStyleBackColor = True
        ' 
        ' rbPerempuan
        ' 
        rbPerempuan.AutoSize = True
        rbPerempuan.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        rbPerempuan.Location = New Point(14, 56)
        rbPerempuan.Name = "rbPerempuan"
        rbPerempuan.Size = New Size(104, 24)
        rbPerempuan.TabIndex = 1
        rbPerempuan.Text = "Perempuan"
        rbPerempuan.UseVisualStyleBackColor = True
        ' 
        ' grpHobby
        ' 
        grpHobby.Controls.Add(chkGaming)
        grpHobby.Controls.Add(chkCoding)
        grpHobby.Controls.Add(chkTraveling)
        grpHobby.Controls.Add(chkMenggambar)
        grpHobby.Controls.Add(chkMenulis)
        grpHobby.Controls.Add(chkMasak)
        grpHobby.Controls.Add(chkMemancing)
        grpHobby.Controls.Add(chkMembaca)
        grpHobby.Controls.Add(chkOlahraga)
        grpHobby.Controls.Add(chkMenyanyi)
        grpHobby.Controls.Add(chkMenari)
        grpHobby.Controls.Add(chkFotografi)
        grpHobby.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        grpHobby.Location = New Point(568, 60)
        grpHobby.Name = "grpHobby"
        grpHobby.Size = New Size(290, 210)
        grpHobby.TabIndex = 15
        grpHobby.TabStop = False
        grpHobby.Text = "Hobby (Pilih minimal 1)"
        ' 
        ' chkGaming
        ' 
        chkGaming.AutoSize = True
        chkGaming.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        chkGaming.Location = New Point(14, 28)
        chkGaming.Name = "chkGaming"
        chkGaming.Size = New Size(83, 24)
        chkGaming.TabIndex = 0
        chkGaming.Text = "Gaming"
        chkGaming.UseVisualStyleBackColor = True
        ' 
        ' chkCoding
        ' 
        chkCoding.AutoSize = True
        chkCoding.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        chkCoding.Location = New Point(14, 56)
        chkCoding.Name = "chkCoding"
        chkCoding.Size = New Size(79, 24)
        chkCoding.TabIndex = 1
        chkCoding.Text = "Coding"
        chkCoding.UseVisualStyleBackColor = True
        ' 
        ' chkTraveling
        ' 
        chkTraveling.AutoSize = True
        chkTraveling.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        chkTraveling.Location = New Point(14, 84)
        chkTraveling.Name = "chkTraveling"
        chkTraveling.Size = New Size(91, 24)
        chkTraveling.TabIndex = 2
        chkTraveling.Text = "Traveling"
        chkTraveling.UseVisualStyleBackColor = True
        ' 
        ' chkMenggambar
        ' 
        chkMenggambar.AutoSize = True
        chkMenggambar.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        chkMenggambar.Location = New Point(14, 112)
        chkMenggambar.Name = "chkMenggambar"
        chkMenggambar.Size = New Size(121, 24)
        chkMenggambar.TabIndex = 3
        chkMenggambar.Text = "Menggambar"
        chkMenggambar.UseVisualStyleBackColor = True
        ' 
        ' chkMenulis
        ' 
        chkMenulis.AutoSize = True
        chkMenulis.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        chkMenulis.Location = New Point(14, 140)
        chkMenulis.Name = "chkMenulis"
        chkMenulis.Size = New Size(82, 24)
        chkMenulis.TabIndex = 4
        chkMenulis.Text = "Menulis"
        chkMenulis.UseVisualStyleBackColor = True
        ' 
        ' chkMasak
        ' 
        chkMasak.AutoSize = True
        chkMasak.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        chkMasak.Location = New Point(14, 168)
        chkMasak.Name = "chkMasak"
        chkMasak.Size = New Size(94, 24)
        chkMasak.TabIndex = 5
        chkMasak.Text = "Memasak"
        chkMasak.UseVisualStyleBackColor = True
        ' 
        ' chkMemancing
        ' 
        chkMemancing.AutoSize = True
        chkMemancing.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        chkMemancing.Location = New Point(155, 28)
        chkMemancing.Name = "chkMemancing"
        chkMemancing.Size = New Size(109, 24)
        chkMemancing.TabIndex = 6
        chkMemancing.Text = "Memancing"
        chkMemancing.UseVisualStyleBackColor = True
        ' 
        ' chkMembaca
        ' 
        chkMembaca.AutoSize = True
        chkMembaca.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        chkMembaca.Location = New Point(155, 56)
        chkMembaca.Name = "chkMembaca"
        chkMembaca.Size = New Size(97, 24)
        chkMembaca.TabIndex = 7
        chkMembaca.Text = "Membaca"
        chkMembaca.UseVisualStyleBackColor = True
        ' 
        ' chkOlahraga
        ' 
        chkOlahraga.AutoSize = True
        chkOlahraga.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        chkOlahraga.Location = New Point(155, 84)
        chkOlahraga.Name = "chkOlahraga"
        chkOlahraga.Size = New Size(92, 24)
        chkOlahraga.TabIndex = 8
        chkOlahraga.Text = "Olahraga"
        chkOlahraga.UseVisualStyleBackColor = True
        ' 
        ' chkMenyanyi
        ' 
        chkMenyanyi.AutoSize = True
        chkMenyanyi.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        chkMenyanyi.Location = New Point(155, 112)
        chkMenyanyi.Name = "chkMenyanyi"
        chkMenyanyi.Size = New Size(94, 24)
        chkMenyanyi.TabIndex = 9
        chkMenyanyi.Text = "Menyanyi"
        chkMenyanyi.UseVisualStyleBackColor = True
        ' 
        ' chkMenari
        ' 
        chkMenari.AutoSize = True
        chkMenari.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        chkMenari.Location = New Point(155, 140)
        chkMenari.Name = "chkMenari"
        chkMenari.Size = New Size(77, 24)
        chkMenari.TabIndex = 10
        chkMenari.Text = "Menari"
        chkMenari.UseVisualStyleBackColor = True
        ' 
        ' chkFotografi
        ' 
        chkFotografi.AutoSize = True
        chkFotografi.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        chkFotografi.Location = New Point(155, 168)
        chkFotografi.Name = "chkFotografi"
        chkFotografi.Size = New Size(92, 24)
        chkFotografi.TabIndex = 11
        chkFotografi.Text = "Fotografi"
        chkFotografi.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        ClientSize = New Size(884, 535)
        Controls.Add(lblJudul)
        Controls.Add(picFoto)
        Controls.Add(lblFotoHint)
        Controls.Add(btnBrowse)
        Controls.Add(lblNama)
        Controls.Add(txtNama)
        Controls.Add(lblUmur)
        Controls.Add(txtUmur)
        Controls.Add(lblTanggalLahir)
        Controls.Add(dtpTanggalLahir)
        Controls.Add(lblNoTelpon)
        Controls.Add(txtNoTelpon)
        Controls.Add(lblAlamat)
        Controls.Add(txtAlamat)
        Controls.Add(grpJenisKelamin)
        Controls.Add(grpHobby)
        Controls.Add(btnCetakKartu)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Kartu Komunitas - Input Data"
        CType(picFoto, ComponentModel.ISupportInitialize).EndInit()
        grpJenisKelamin.ResumeLayout(False)
        grpJenisKelamin.PerformLayout()
        grpHobby.ResumeLayout(False)
        grpHobby.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents picFoto As PictureBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents btnCetakKartu As Button
    Friend WithEvents lblJudul As Label
    Friend WithEvents lblNama As Label
    Friend WithEvents lblUmur As Label
    Friend WithEvents lblTanggalLahir As Label
    Friend WithEvents lblNoTelpon As Label
    Friend WithEvents lblAlamat As Label
    Friend WithEvents lblFotoHint As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtUmur As TextBox
    Friend WithEvents txtNoTelpon As TextBox
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents dtpTanggalLahir As DateTimePicker
    Friend WithEvents grpJenisKelamin As GroupBox
    Friend WithEvents grpHobby As GroupBox
    Friend WithEvents rbLakiLaki As RadioButton
    Friend WithEvents rbPerempuan As RadioButton
    Friend WithEvents chkGaming As CheckBox
    Friend WithEvents chkCoding As CheckBox
    Friend WithEvents chkTraveling As CheckBox
    Friend WithEvents chkMenggambar As CheckBox
    Friend WithEvents chkMenulis As CheckBox
    Friend WithEvents chkMemancing As CheckBox
    Friend WithEvents chkMembaca As CheckBox
    Friend WithEvents chkOlahraga As CheckBox
    Friend WithEvents chkMenyanyi As CheckBox
    Friend WithEvents chkMenari As CheckBox
    Friend WithEvents chkMasak As CheckBox
    Friend WithEvents chkFotografi As CheckBox

End Class
