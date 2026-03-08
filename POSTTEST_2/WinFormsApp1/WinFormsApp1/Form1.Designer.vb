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
        GroupBox1 = New GroupBox()
        btnTambah = New Button()
        Label2 = New Label()
        Label1 = New Label()
        txtGenre = New TextBox()
        txtJudulTambah = New TextBox()
        GroupBox2 = New GroupBox()
        btnHapus = New Button()
        Label3 = New Label()
        txtJudulHapus = New TextBox()
        lstDaftarBuku = New ListBox()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(btnTambah)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(txtGenre)
        GroupBox1.Controls.Add(txtJudulTambah)
        GroupBox1.Font = New Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GroupBox1.ForeColor = SystemColors.ControlText
        GroupBox1.Location = New Point(57, 28)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(328, 189)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Tambah Buku"
        ' 
        ' btnTambah
        ' 
        btnTambah.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        btnTambah.Font = New Font("Segoe UI", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btnTambah.Location = New Point(228, 154)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(94, 29)
        btnTambah.TabIndex = 4
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(16, 100)
        Label2.Name = "Label2"
        Label2.Size = New Size(51, 20)
        Label2.TabIndex = 3
        Label2.Text = "Genre"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(16, 52)
        Label1.Name = "Label1"
        Label1.Size = New Size(87, 20)
        Label1.TabIndex = 2
        Label1.Text = "Judul Buku"
        ' 
        ' txtGenre
        ' 
        txtGenre.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtGenre.Location = New Point(120, 97)
        txtGenre.Name = "txtGenre"
        txtGenre.Size = New Size(174, 27)
        txtGenre.TabIndex = 1
        ' 
        ' txtJudulTambah
        ' 
        txtJudulTambah.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtJudulTambah.Location = New Point(120, 45)
        txtJudulTambah.Name = "txtJudulTambah"
        txtJudulTambah.Size = New Size(174, 27)
        txtJudulTambah.TabIndex = 0
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(btnHapus)
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Controls.Add(txtJudulHapus)
        GroupBox2.Font = New Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GroupBox2.Location = New Point(416, 27)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(348, 190)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        GroupBox2.Text = "Hapus Buku"
        ' 
        ' btnHapus
        ' 
        btnHapus.BackColor = Color.Red
        btnHapus.BackgroundImageLayout = ImageLayout.None
        btnHapus.Font = New Font("Segoe UI", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btnHapus.Location = New Point(248, 155)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(94, 29)
        btnHapus.TabIndex = 5
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(19, 49)
        Label3.Name = "Label3"
        Label3.Size = New Size(87, 20)
        Label3.TabIndex = 3
        Label3.Text = "Judul Buku"
        ' 
        ' txtJudulHapus
        ' 
        txtJudulHapus.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtJudulHapus.Location = New Point(141, 46)
        txtJudulHapus.Name = "txtJudulHapus"
        txtJudulHapus.Size = New Size(174, 27)
        txtJudulHapus.TabIndex = 1
        ' 
        ' lstDaftarBuku
        ' 
        lstDaftarBuku.BackColor = SystemColors.Info
        lstDaftarBuku.Font = New Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lstDaftarBuku.FormattingEnabled = True
        lstDaftarBuku.Location = New Point(197, 238)
        lstDaftarBuku.Name = "lstDaftarBuku"
        lstDaftarBuku.Size = New Size(367, 202)
        lstDaftarBuku.TabIndex = 2
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkCyan
        ClientSize = New Size(800, 450)
        Controls.Add(lstDaftarBuku)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Name = "Form1"
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtGenre As TextBox
    Friend WithEvents txtJudulTambah As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtJudulHapus As TextBox
    Friend WithEvents lstDaftarBuku As ListBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnHapus As Button

End Class
