<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormKartu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        lblTitleKartu = New Label()
        PictureBox1 = New PictureBox()
        picFotoKartu = New PictureBox()
        lblNamaKartu = New Label()
        lblIdKartu = New Label()
        lblKomunitasKartu = New Label()
        lblTelpKartu = New Label()
        lblHobiKartu = New Label()
        btnTutup = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(picFotoKartu, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblTitleKartu
        ' 
        lblTitleKartu.AutoSize = True
        lblTitleKartu.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(192))
        lblTitleKartu.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitleKartu.ForeColor = Color.Black
        lblTitleKartu.Location = New Point(131, 9)
        lblTitleKartu.Name = "lblTitleKartu"
        lblTitleKartu.Size = New Size(527, 46)
        lblTitleKartu.TabIndex = 2
        lblTitleKartu.Text = "KARTU IDENTITAS KOMUNITAS"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = My.Resources.Resources.Screenshot_2026_04_07_213213_removebg_preview
        PictureBox1.Location = New Point(565, 58)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(174, 122)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 4
        PictureBox1.TabStop = False
        ' 
        ' picFotoKartu
        ' 
        picFotoKartu.BackColor = Color.Black
        picFotoKartu.BorderStyle = BorderStyle.FixedSingle
        picFotoKartu.Location = New Point(37, 90)
        picFotoKartu.Name = "picFotoKartu"
        picFotoKartu.Size = New Size(120, 107)
        picFotoKartu.SizeMode = PictureBoxSizeMode.Zoom
        picFotoKartu.TabIndex = 5
        picFotoKartu.TabStop = False
        ' 
        ' lblNamaKartu
        ' 
        lblNamaKartu.AutoSize = True
        lblNamaKartu.BackColor = Color.Silver
        lblNamaKartu.Font = New Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblNamaKartu.Location = New Point(214, 90)
        lblNamaKartu.Name = "lblNamaKartu"
        lblNamaKartu.Size = New Size(156, 35)
        lblNamaKartu.TabIndex = 6
        lblNamaKartu.Text = "Nama User"
        ' 
        ' lblIdKartu
        ' 
        lblIdKartu.AutoSize = True
        lblIdKartu.BackColor = Color.Silver
        lblIdKartu.Font = New Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblIdKartu.Location = New Point(214, 145)
        lblIdKartu.Name = "lblIdKartu"
        lblIdKartu.Size = New Size(116, 35)
        lblIdKartu.TabIndex = 7
        lblIdKartu.Text = "ID User"
        ' 
        ' lblKomunitasKartu
        ' 
        lblKomunitasKartu.AutoSize = True
        lblKomunitasKartu.BackColor = Color.Silver
        lblKomunitasKartu.Font = New Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblKomunitasKartu.Location = New Point(214, 197)
        lblKomunitasKartu.Name = "lblKomunitasKartu"
        lblKomunitasKartu.Size = New Size(154, 35)
        lblKomunitasKartu.TabIndex = 8
        lblKomunitasKartu.Text = "Komunitas"
        ' 
        ' lblTelpKartu
        ' 
        lblTelpKartu.AutoSize = True
        lblTelpKartu.BackColor = Color.Silver
        lblTelpKartu.Font = New Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTelpKartu.Location = New Point(214, 253)
        lblTelpKartu.Name = "lblTelpKartu"
        lblTelpKartu.Size = New Size(158, 35)
        lblTelpKartu.TabIndex = 9
        lblTelpKartu.Text = "No Telepon"
        ' 
        ' lblHobiKartu
        ' 
        lblHobiKartu.AutoSize = True
        lblHobiKartu.BackColor = Color.Silver
        lblHobiKartu.Font = New Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblHobiKartu.Location = New Point(214, 315)
        lblHobiKartu.Name = "lblHobiKartu"
        lblHobiKartu.Size = New Size(145, 35)
        lblHobiKartu.TabIndex = 10
        lblHobiKartu.Text = "Hobi User"
        ' 
        ' btnTutup
        ' 
        btnTutup.BackColor = Color.Red
        btnTutup.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnTutup.Location = New Point(698, 368)
        btnTutup.Name = "btnTutup"
        btnTutup.Size = New Size(90, 43)
        btnTutup.TabIndex = 13
        btnTutup.Text = "Tutup"
        btnTutup.UseVisualStyleBackColor = False
        ' 
        ' FormKartu
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.Design_business_cards_online_for_free
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(btnTutup)
        Controls.Add(lblHobiKartu)
        Controls.Add(lblTelpKartu)
        Controls.Add(lblKomunitasKartu)
        Controls.Add(lblIdKartu)
        Controls.Add(lblNamaKartu)
        Controls.Add(picFotoKartu)
        Controls.Add(lblTitleKartu)
        Controls.Add(PictureBox1)
        ForeColor = SystemColors.ActiveCaptionText
        Name = "FormKartu"
        Text = "FormKartu"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(picFotoKartu, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitleKartu As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents picFotoKartu As PictureBox
    Friend WithEvents lblNamaKartu As Label
    Friend WithEvents lblIdKartu As Label
    Friend WithEvents lblKomunitasKartu As Label
    Friend WithEvents lblTelpKartu As Label
    Friend WithEvents lblHobiKartu As Label
    Friend WithEvents btnTutup As Button
End Class
