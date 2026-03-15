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
        picFotoKartu = New PictureBox()
        btnTutup = New Button()
        lblJudulKartu = New Label()
        lblSubJudul = New Label()
        lblNamaKey = New Label()
        lblUmurKey = New Label()
        lblTglLahirKey = New Label()
        lblJKKey = New Label()
        lblTelpKey = New Label()
        lblHobbyKey = New Label()
        lblAlamatKey = New Label()
        lblNamaValue = New Label()
        lblUmurValue = New Label()
        lblTglLahirValue = New Label()
        lblJKValue = New Label()
        lblTelpValue = New Label()
        lblHobbyValue = New Label()
        lblAlamatValue = New Label()
        pnlKartu = New Panel()
        pnlFooter = New Panel()
        lblFooter = New Label()
        CType(picFotoKartu, ComponentModel.ISupportInitialize).BeginInit()
        pnlKartu.SuspendLayout()
        pnlFooter.SuspendLayout()
        SuspendLayout()
        ' 
        ' picFotoKartu
        ' 
        picFotoKartu.BackColor = Color.LightGray
        picFotoKartu.BorderStyle = BorderStyle.FixedSingle
        picFotoKartu.Location = New Point(20, 80)
        picFotoKartu.Name = "picFotoKartu"
        picFotoKartu.Size = New Size(140, 180)
        picFotoKartu.SizeMode = PictureBoxSizeMode.Zoom
        picFotoKartu.TabIndex = 1
        picFotoKartu.TabStop = False
        ' 
        ' btnTutup
        ' 
        btnTutup.BackColor = Color.Firebrick
        btnTutup.FlatStyle = FlatStyle.Flat
        btnTutup.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnTutup.ForeColor = Color.White
        btnTutup.Location = New Point(295, 435)
        btnTutup.Name = "btnTutup"
        btnTutup.Size = New Size(130, 34)
        btnTutup.TabIndex = 1
        btnTutup.Text = "Tutup"
        btnTutup.UseVisualStyleBackColor = False
        ' 
        ' lblJudulKartu
        ' 
        lblJudulKartu.Font = New Font("Segoe UI Black", 14.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblJudulKartu.ForeColor = Color.White
        lblJudulKartu.Location = New Point(0, 15)
        lblJudulKartu.Name = "lblJudulKartu"
        lblJudulKartu.Size = New Size(720, 35)
        lblJudulKartu.TabIndex = 2
        lblJudulKartu.Text = "Coding Community CARD"
        lblJudulKartu.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblSubJudul
        ' 
        lblSubJudul.Font = New Font("Segoe UI", 8.0F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblSubJudul.ForeColor = Color.LightBlue
        lblSubJudul.Location = New Point(0, 52)
        lblSubJudul.Name = "lblSubJudul"
        lblSubJudul.Size = New Size(720, 18)
        lblSubJudul.TabIndex = 3
        lblSubJudul.Text = "Kartu Anggota Resmi  |  Member Since 2025"
        lblSubJudul.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblNamaKey
        ' 
        lblNamaKey.AutoSize = True
        lblNamaKey.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblNamaKey.ForeColor = Color.LightBlue
        lblNamaKey.Location = New Point(178, 85)
        lblNamaKey.Name = "lblNamaKey"
        lblNamaKey.Size = New Size(59, 20)
        lblNamaKey.TabIndex = 4
        lblNamaKey.Text = "Nama :"
        ' 
        ' lblUmurKey
        ' 
        lblUmurKey.AutoSize = True
        lblUmurKey.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblUmurKey.ForeColor = Color.LightBlue
        lblUmurKey.Location = New Point(178, 118)
        lblUmurKey.Name = "lblUmurKey"
        lblUmurKey.Size = New Size(57, 20)
        lblUmurKey.TabIndex = 5
        lblUmurKey.Text = "Umur :"
        ' 
        ' lblTglLahirKey
        ' 
        lblTglLahirKey.AutoSize = True
        lblTglLahirKey.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTglLahirKey.ForeColor = Color.LightBlue
        lblTglLahirKey.Location = New Point(178, 151)
        lblTglLahirKey.Name = "lblTglLahirKey"
        lblTglLahirKey.Size = New Size(81, 20)
        lblTglLahirKey.TabIndex = 6
        lblTglLahirKey.Text = "Tgl. Lahir :"
        ' 
        ' lblJKKey
        ' 
        lblJKKey.AutoSize = True
        lblJKKey.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblJKKey.ForeColor = Color.LightBlue
        lblJKKey.Location = New Point(178, 184)
        lblJKKey.Name = "lblJKKey"
        lblJKKey.Size = New Size(113, 20)
        lblJKKey.TabIndex = 7
        lblJKKey.Text = "Jenis Kelamin :"
        ' 
        ' lblTelpKey
        ' 
        lblTelpKey.AutoSize = True
        lblTelpKey.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTelpKey.ForeColor = Color.LightBlue
        lblTelpKey.Location = New Point(178, 217)
        lblTelpKey.Name = "lblTelpKey"
        lblTelpKey.Size = New Size(101, 20)
        lblTelpKey.TabIndex = 8
        lblTelpKey.Text = "No. Telepon :"
        ' 
        ' lblHobbyKey
        ' 
        lblHobbyKey.AutoSize = True
        lblHobbyKey.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblHobbyKey.ForeColor = Color.LightBlue
        lblHobbyKey.Location = New Point(178, 250)
        lblHobbyKey.Name = "lblHobbyKey"
        lblHobbyKey.Size = New Size(63, 20)
        lblHobbyKey.TabIndex = 9
        lblHobbyKey.Text = "Hobby :"
        ' 
        ' lblAlamatKey
        ' 
        lblAlamatKey.AutoSize = True
        lblAlamatKey.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblAlamatKey.ForeColor = Color.LightBlue
        lblAlamatKey.Location = New Point(178, 295)
        lblAlamatKey.Name = "lblAlamatKey"
        lblAlamatKey.Size = New Size(68, 20)
        lblAlamatKey.TabIndex = 10
        lblAlamatKey.Text = "Alamat :"
        ' 
        ' lblNamaValue
        ' 
        lblNamaValue.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblNamaValue.ForeColor = Color.White
        lblNamaValue.Location = New Point(340, 83)
        lblNamaValue.Name = "lblNamaValue"
        lblNamaValue.Size = New Size(360, 25)
        lblNamaValue.TabIndex = 11
        ' 
        ' lblUmurValue
        ' 
        lblUmurValue.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblUmurValue.ForeColor = Color.White
        lblUmurValue.Location = New Point(340, 116)
        lblUmurValue.Name = "lblUmurValue"
        lblUmurValue.Size = New Size(200, 25)
        lblUmurValue.TabIndex = 12
        ' 
        ' lblTglLahirValue
        ' 
        lblTglLahirValue.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTglLahirValue.ForeColor = Color.White
        lblTglLahirValue.Location = New Point(340, 149)
        lblTglLahirValue.Name = "lblTglLahirValue"
        lblTglLahirValue.Size = New Size(200, 25)
        lblTglLahirValue.TabIndex = 13
        ' 
        ' lblJKValue
        ' 
        lblJKValue.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblJKValue.ForeColor = Color.White
        lblJKValue.Location = New Point(340, 182)
        lblJKValue.Name = "lblJKValue"
        lblJKValue.Size = New Size(200, 25)
        lblJKValue.TabIndex = 14
        ' 
        ' lblTelpValue
        ' 
        lblTelpValue.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTelpValue.ForeColor = Color.White
        lblTelpValue.Location = New Point(340, 215)
        lblTelpValue.Name = "lblTelpValue"
        lblTelpValue.Size = New Size(280, 25)
        lblTelpValue.TabIndex = 15
        ' 
        ' lblHobbyValue
        ' 
        lblHobbyValue.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblHobbyValue.ForeColor = Color.LightGreen
        lblHobbyValue.Location = New Point(340, 248)
        lblHobbyValue.Name = "lblHobbyValue"
        lblHobbyValue.Size = New Size(360, 38)
        lblHobbyValue.TabIndex = 16
        ' 
        ' lblAlamatValue
        ' 
        lblAlamatValue.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblAlamatValue.ForeColor = Color.White
        lblAlamatValue.Location = New Point(340, 293)
        lblAlamatValue.Name = "lblAlamatValue"
        lblAlamatValue.Size = New Size(360, 38)
        lblAlamatValue.TabIndex = 17
        ' 
        ' pnlKartu
        ' 
        pnlKartu.BackColor = Color.FromArgb(CByte(25), CByte(55), CByte(110))
        pnlKartu.Controls.Add(picFotoKartu)
        pnlKartu.Controls.Add(lblJudulKartu)
        pnlKartu.Controls.Add(lblSubJudul)
        pnlKartu.Controls.Add(lblNamaKey)
        pnlKartu.Controls.Add(lblNamaValue)
        pnlKartu.Controls.Add(lblUmurKey)
        pnlKartu.Controls.Add(lblUmurValue)
        pnlKartu.Controls.Add(lblTglLahirKey)
        pnlKartu.Controls.Add(lblTglLahirValue)
        pnlKartu.Controls.Add(lblJKKey)
        pnlKartu.Controls.Add(lblJKValue)
        pnlKartu.Controls.Add(lblTelpKey)
        pnlKartu.Controls.Add(lblTelpValue)
        pnlKartu.Controls.Add(lblHobbyKey)
        pnlKartu.Controls.Add(lblHobbyValue)
        pnlKartu.Controls.Add(lblAlamatKey)
        pnlKartu.Controls.Add(lblAlamatValue)
        pnlKartu.Controls.Add(pnlFooter)
        pnlKartu.Location = New Point(15, 15)
        pnlKartu.Name = "pnlKartu"
        pnlKartu.Size = New Size(720, 410)
        pnlKartu.TabIndex = 0
        ' 
        ' pnlFooter
        ' 
        pnlFooter.BackColor = Color.FromArgb(CByte(10), CByte(80), CByte(180))
        pnlFooter.Controls.Add(lblFooter)
        pnlFooter.Dock = DockStyle.Bottom
        pnlFooter.Location = New Point(0, 370)
        pnlFooter.Name = "pnlFooter"
        pnlFooter.Size = New Size(720, 40)
        pnlFooter.TabIndex = 18
        ' 
        ' lblFooter
        ' 
        lblFooter.Dock = DockStyle.Fill
        lblFooter.Font = New Font("Segoe UI Black", 11.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblFooter.ForeColor = Color.White
        lblFooter.Location = New Point(0, 0)
        lblFooter.Name = "lblFooter"
        lblFooter.Size = New Size(720, 40)
        lblFooter.TabIndex = 0
        lblFooter.Text = "MEMBER  CARD"
        lblFooter.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        ClientSize = New Size(750, 480)
        Controls.Add(pnlKartu)
        Controls.Add(btnTutup)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "Form2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Kartu Komunitas - Hasil Kartu"
        CType(picFotoKartu, ComponentModel.ISupportInitialize).EndInit()
        pnlKartu.ResumeLayout(False)
        pnlKartu.PerformLayout()
        pnlFooter.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents picFotoKartu As PictureBox
    Friend WithEvents btnTutup As Button
    Friend WithEvents pnlKartu As Panel
    Friend WithEvents pnlFooter As Panel
    Friend WithEvents lblFooter As Label
    Friend WithEvents lblJudulKartu As Label
    Friend WithEvents lblSubJudul As Label
    Friend WithEvents lblNamaKey As Label
    Friend WithEvents lblUmurKey As Label
    Friend WithEvents lblTglLahirKey As Label
    Friend WithEvents lblJKKey As Label
    Friend WithEvents lblTelpKey As Label
    Friend WithEvents lblHobbyKey As Label
    Friend WithEvents lblAlamatKey As Label
    Friend WithEvents lblNamaValue As Label
    Friend WithEvents lblUmurValue As Label
    Friend WithEvents lblTglLahirValue As Label
    Friend WithEvents lblJKValue As Label
    Friend WithEvents lblTelpValue As Label
    Friend WithEvents lblHobbyValue As Label
    Friend WithEvents lblAlamatValue As Label

End Class
