<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        lstKamar = New ListBox()
        btnBatal = New Button()
        btnHapus = New Button()
        btnUbah = New Button()
        btnSimpan = New Button()
        GroupBox3 = New GroupBox()
        Label5 = New Label()
        Label6 = New Label()
        txtSearch = New TextBox()
        Label4 = New Label()
        GroupBox2 = New GroupBox()
        GroupBox1 = New GroupBox()
        Label1 = New Label()
        cmbStatus = New ComboBox()
        txtJenis = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        txtNomor = New TextBox()
        Label7 = New Label()
        GroupBox3.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' lstKamar
        ' 
        lstKamar.BackColor = Color.LightSteelBlue
        lstKamar.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lstKamar.FormattingEnabled = True
        lstKamar.Location = New Point(57, 289)
        lstKamar.Name = "lstKamar"
        lstKamar.Size = New Size(363, 254)
        lstKamar.TabIndex = 20
        ' 
        ' btnBatal
        ' 
        btnBatal.BackColor = Color.Cyan
        btnBatal.Location = New Point(32, 212)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(112, 40)
        btnBatal.TabIndex = 3
        btnBatal.Text = "Batal"
        btnBatal.UseVisualStyleBackColor = False
        ' 
        ' btnHapus
        ' 
        btnHapus.BackColor = Color.Red
        btnHapus.Location = New Point(32, 149)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(112, 40)
        btnHapus.TabIndex = 2
        btnHapus.Text = "Hapus kamar"
        btnHapus.UseVisualStyleBackColor = False
        ' 
        ' btnUbah
        ' 
        btnUbah.BackColor = Color.Yellow
        btnUbah.Location = New Point(32, 90)
        btnUbah.Name = "btnUbah"
        btnUbah.Size = New Size(112, 40)
        btnUbah.TabIndex = 1
        btnUbah.Text = "Ubah "
        btnUbah.UseVisualStyleBackColor = False
        ' 
        ' btnSimpan
        ' 
        btnSimpan.BackColor = Color.Lime
        btnSimpan.Location = New Point(32, 26)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(112, 40)
        btnSimpan.TabIndex = 0
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = False
        ' 
        ' GroupBox3
        ' 
        GroupBox3.BackColor = Color.Goldenrod
        GroupBox3.Controls.Add(btnBatal)
        GroupBox3.Controls.Add(btnHapus)
        GroupBox3.Controls.Add(btnUbah)
        GroupBox3.Controls.Add(btnSimpan)
        GroupBox3.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox3.Location = New Point(603, 58)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(180, 271)
        GroupBox3.TabIndex = 18
        GroupBox3.TabStop = False
        GroupBox3.Text = "Aksi"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(237, 5)
        Label5.Name = "Label5"
        Label5.Size = New Size(390, 31)
        Label5.TabIndex = 16
        Label5.Text = "SISTEM MANAJEMEN KOST RASYID"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(-5, 16)
        Label6.Name = "Label6"
        Label6.Size = New Size(825, 20)
        Label6.TabIndex = 17
        Label6.Text = "________________________________________________________________________________________________________________________________________"
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(83, 56)
        txtSearch.Name = "txtSearch"
        txtSearch.PlaceholderText = "No/Jenis..."
        txtSearch.Size = New Size(97, 30)
        txtSearch.TabIndex = 4
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.AntiqueWhite
        Label4.Location = New Point(18, 59)
        Label4.Name = "Label4"
        Label4.Size = New Size(42, 23)
        Label4.TabIndex = 1
        Label4.Text = "Cari"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = Color.Goldenrod
        GroupBox2.Controls.Add(txtSearch)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox2.Location = New Point(399, 58)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(198, 207)
        GroupBox2.TabIndex = 15
        GroupBox2.TabStop = False
        GroupBox2.Text = "Pencarian"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.Goldenrod
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(cmbStatus)
        GroupBox1.Controls.Add(txtJenis)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(txtNomor)
        GroupBox1.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(57, 55)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(335, 210)
        GroupBox1.TabIndex = 14
        GroupBox1.TabStop = False
        GroupBox1.Text = "Data Kamar"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.AntiqueWhite
        Label1.Location = New Point(24, 50)
        Label1.Name = "Label1"
        Label1.Size = New Size(106, 23)
        Label1.TabIndex = 0
        Label1.Text = "Jenis Kamar"
        ' 
        ' cmbStatus
        ' 
        cmbStatus.FormattingEnabled = True
        cmbStatus.Items.AddRange(New Object() {"Terisi", "Kosong"})
        cmbStatus.Location = New Point(153, 152)
        cmbStatus.Name = "cmbStatus"
        cmbStatus.Size = New Size(154, 31)
        cmbStatus.TabIndex = 5
        ' 
        ' txtJenis
        ' 
        txtJenis.Location = New Point(153, 50)
        txtJenis.Name = "txtJenis"
        txtJenis.PlaceholderText = "Standar/AC/VIP"
        txtJenis.Size = New Size(154, 30)
        txtJenis.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.AntiqueWhite
        Label3.Location = New Point(24, 152)
        Label3.Name = "Label3"
        Label3.Size = New Size(60, 23)
        Label3.TabIndex = 4
        Label3.Text = "Status"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.AntiqueWhite
        Label2.Location = New Point(24, 103)
        Label2.Name = "Label2"
        Label2.Size = New Size(123, 23)
        Label2.TabIndex = 2
        Label2.Text = "Nomor Kamar"
        ' 
        ' txtNomor
        ' 
        txtNomor.Location = New Point(153, 103)
        txtNomor.Name = "txtNomor"
        txtNomor.PlaceholderText = "1-10"
        txtNomor.Size = New Size(154, 30)
        txtNomor.TabIndex = 3
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(426, 523)
        Label7.Name = "Label7"
        Label7.Size = New Size(407, 20)
        Label7.TabIndex = 21
        Label7.Text = "Cara : Jika ingin CRUD, klik data pada listbox terlebih dahulu"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.AntiqueWhite
        ClientSize = New Size(851, 574)
        Controls.Add(Label7)
        Controls.Add(lstKamar)
        Controls.Add(GroupBox3)
        Controls.Add(Label5)
        Controls.Add(Label6)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Name = "Form1"
        Text = "Form1"
        GroupBox3.ResumeLayout(False)
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lstKamar As ListBox
    Friend WithEvents btnBatal As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbStatus As ComboBox
    Friend WithEvents txtJenis As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNomor As TextBox
    Friend WithEvents Label7 As Label

End Class
