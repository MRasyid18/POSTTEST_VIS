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
        Label1 = New Label()
        txtIPSemester = New TextBox()
        btnTambah = New Button()
        btnReset = New Button()
        Label2 = New Label()
        txtIPK = New TextBox()
        lblPredikat = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BorderStyle = BorderStyle.Fixed3D
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(133, 86)
        Label1.Name = "Label1"
        Label1.Size = New Size(94, 22)
        Label1.TabIndex = 0
        Label1.Text = "IP Semester"
        ' 
        ' txtIPSemester
        ' 
        txtIPSemester.Location = New Point(245, 83)
        txtIPSemester.Name = "txtIPSemester"
        txtIPSemester.Size = New Size(125, 27)
        txtIPSemester.TabIndex = 1
        ' 
        ' btnTambah
        ' 
        btnTambah.Location = New Point(245, 172)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(94, 29)
        btnTambah.TabIndex = 2
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' btnReset
        ' 
        btnReset.Location = New Point(245, 207)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(94, 29)
        btnReset.TabIndex = 3
        btnReset.Text = "Reset"
        btnReset.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BorderStyle = BorderStyle.Fixed3D
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(133, 139)
        Label2.Name = "Label2"
        Label2.Size = New Size(99, 22)
        Label2.TabIndex = 4
        Label2.Text = "IP Kumulatif"
        ' 
        ' txtIPK
        ' 
        txtIPK.Location = New Point(245, 139)
        txtIPK.Name = "txtIPK"
        txtIPK.ReadOnly = True
        txtIPK.Size = New Size(125, 27)
        txtIPK.TabIndex = 5
        ' 
        ' lblPredikat
        ' 
        lblPredikat.AutoSize = True
        lblPredikat.Font = New Font("Snap ITC", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblPredikat.Location = New Point(450, 139)
        lblPredikat.Name = "lblPredikat"
        lblPredikat.Size = New Size(53, 19)
        lblPredikat.TabIndex = 6
        lblPredikat.Text = "Hasil"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.WindowText
        ClientSize = New Size(800, 450)
        Controls.Add(lblPredikat)
        Controls.Add(txtIPK)
        Controls.Add(Label2)
        Controls.Add(btnReset)
        Controls.Add(btnTambah)
        Controls.Add(txtIPSemester)
        Controls.Add(Label1)
        ForeColor = Color.Crimson
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtIPSemester As TextBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtIPK As TextBox
    Friend WithEvents lblPredikat As Label

End Class
