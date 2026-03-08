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
        Panel1 = New Panel()
        txtGenre = New TextBox()
        txtJudul = New TextBox()
        btnTambah = New Button()
        Label2 = New Label()
        Label3 = New Label()
        Panel2 = New Panel()
        txtHapus = New TextBox()
        btnHapus = New Button()
        Label5 = New Label()
        Label1 = New Label()
        Label4 = New Label()
        lstBuku = New ListBox()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(txtGenre)
        Panel1.Controls.Add(txtJudul)
        Panel1.Controls.Add(btnTambah)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label3)
        Panel1.Location = New Point(93, 108)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(400, 200)
        Panel1.TabIndex = 0
        ' 
        ' txtGenre
        ' 
        txtGenre.Location = New Point(172, 109)
        txtGenre.Name = "txtGenre"
        txtGenre.Size = New Size(200, 39)
        txtGenre.TabIndex = 7
        ' 
        ' txtJudul
        ' 
        txtJudul.Location = New Point(172, 50)
        txtJudul.Name = "txtJudul"
        txtJudul.Size = New Size(200, 39)
        txtJudul.TabIndex = 6
        ' 
        ' btnTambah
        ' 
        btnTambah.Location = New Point(250, 154)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(150, 46)
        btnTambah.TabIndex = 5
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(26, 50)
        Label2.Name = "Label2"
        Label2.Size = New Size(132, 32)
        Label2.TabIndex = 3
        Label2.Text = "Judul Buku"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(26, 109)
        Label3.Name = "Label3"
        Label3.Size = New Size(78, 32)
        Label3.TabIndex = 4
        Label3.Text = "Genre"
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(txtHapus)
        Panel2.Controls.Add(btnHapus)
        Panel2.Controls.Add(Label5)
        Panel2.Location = New Point(93, 416)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(400, 200)
        Panel2.TabIndex = 1
        ' 
        ' txtHapus
        ' 
        txtHapus.Location = New Point(162, 84)
        txtHapus.Name = "txtHapus"
        txtHapus.Size = New Size(200, 39)
        txtHapus.TabIndex = 8
        ' 
        ' btnHapus
        ' 
        btnHapus.Location = New Point(250, 154)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(150, 46)
        btnHapus.TabIndex = 7
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(26, 84)
        Label5.Name = "Label5"
        Label5.Size = New Size(132, 32)
        Label5.TabIndex = 6
        Label5.Text = "Judul Buku"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(93, 73)
        Label1.Name = "Label1"
        Label1.Size = New Size(158, 32)
        Label1.TabIndex = 2
        Label1.Text = "Tambah Buku"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(93, 381)
        Label4.Name = "Label4"
        Label4.Size = New Size(142, 32)
        Label4.TabIndex = 5
        Label4.Text = "Hapus Buku"
        ' 
        ' lstBuku
        ' 
        lstBuku.FormattingEnabled = True
        lstBuku.Location = New Point(691, 108)
        lstBuku.Name = "lstBuku"
        lstBuku.Size = New Size(616, 516)
        lstBuku.TabIndex = 6
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(1454, 764)
        Controls.Add(lstBuku)
        Controls.Add(Label1)
        Controls.Add(Label4)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "Form1"
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtGenre As TextBox
    Friend WithEvents txtJudul As TextBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents txtHapus As TextBox
    Friend WithEvents btnHapus As Button
    Friend WithEvents lstBuku As ListBox

End Class
