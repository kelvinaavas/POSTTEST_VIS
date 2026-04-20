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
        components = New ComponentModel.Container()

        lblJudul = New Label()
        lblKode = New Label()
        lblNama = New Label()
        lblTelepon = New Label()
        lblAlamat = New Label()
        lblCari = New Label()
        txtKodePelanggan = New TextBox()
        txtNamaPelanggan = New TextBox()
        txtNoTelepon = New TextBox()
        txtAlamat = New TextBox()
        txtCari = New TextBox()
        btnSimpan = New Button()
        btnUbah = New Button()
        btnHapus = New Button()
        btnBatal = New Button()
        btnFormPelayanan = New Button()
        dgvPelanggan = New DataGridView()
        ErrorProvider1 = New ErrorProvider(components)

        CType(dgvPelanggan, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()

        ' lblJudul
        lblJudul.AutoSize = True
        lblJudul.Font = New Font("Segoe UI", 13, FontStyle.Bold)
        lblJudul.ForeColor = Color.DarkSlateBlue
        lblJudul.Location = New Point(12, 12)
        lblJudul.Name = "lblJudul"
        lblJudul.Text = "Data Pelanggan Barbershop"

        ' lblKode
        lblKode.AutoSize = True
        lblKode.Location = New Point(15, 58)
        lblKode.Name = "lblKode"
        lblKode.Text = "Kode Pelanggan"

        ' txtKodePelanggan
        txtKodePelanggan.BackColor = Color.Azure
        txtKodePelanggan.Location = New Point(150, 55)
        txtKodePelanggan.Name = "txtKodePelanggan"
        txtKodePelanggan.PlaceholderText = "Contoh: P001"
        txtKodePelanggan.Size = New Size(130, 23)
        txtKodePelanggan.TabIndex = 0

        ' lblNama
        lblNama.AutoSize = True
        lblNama.Location = New Point(15, 88)
        lblNama.Name = "lblNama"
        lblNama.Text = "Nama Pelanggan"

        ' txtNamaPelanggan
        txtNamaPelanggan.BackColor = Color.Azure
        txtNamaPelanggan.Location = New Point(150, 85)
        txtNamaPelanggan.Name = "txtNamaPelanggan"
        txtNamaPelanggan.PlaceholderText = "Nama lengkap"
        txtNamaPelanggan.Size = New Size(200, 23)
        txtNamaPelanggan.TabIndex = 1

        ' lblTelepon
        lblTelepon.AutoSize = True
        lblTelepon.Location = New Point(15, 118)
        lblTelepon.Name = "lblTelepon"
        lblTelepon.Text = "No. Telepon"

        ' txtNoTelepon
        txtNoTelepon.BackColor = Color.Azure
        txtNoTelepon.Location = New Point(150, 115)
        txtNoTelepon.Name = "txtNoTelepon"
        txtNoTelepon.PlaceholderText = "08xxxxxxxxxx"
        txtNoTelepon.Size = New Size(150, 23)
        txtNoTelepon.TabIndex = 2

        ' lblAlamat
        lblAlamat.AutoSize = True
        lblAlamat.Location = New Point(15, 148)
        lblAlamat.Name = "lblAlamat"
        lblAlamat.Text = "Alamat"

        ' txtAlamat
        txtAlamat.BackColor = Color.Azure
        txtAlamat.Location = New Point(150, 145)
        txtAlamat.Name = "txtAlamat"
        txtAlamat.PlaceholderText = "Alamat (opsional)"
        txtAlamat.Size = New Size(260, 23)
        txtAlamat.TabIndex = 3

        ' btnSimpan
        btnSimpan.BackColor = Color.MediumSeaGreen
        btnSimpan.FlatStyle = FlatStyle.Flat
        btnSimpan.ForeColor = Color.White
        btnSimpan.Location = New Point(15, 185)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(85, 28)
        btnSimpan.TabIndex = 4
        btnSimpan.Text = "Simpan"

        ' btnUbah
        btnUbah.BackColor = Color.SteelBlue
        btnUbah.FlatStyle = FlatStyle.Flat
        btnUbah.ForeColor = Color.White
        btnUbah.Location = New Point(105, 185)
        btnUbah.Name = "btnUbah"
        btnUbah.Size = New Size(80, 28)
        btnUbah.TabIndex = 5
        btnUbah.Text = "Ubah"

        ' btnHapus
        btnHapus.BackColor = Color.IndianRed
        btnHapus.FlatStyle = FlatStyle.Flat
        btnHapus.ForeColor = Color.White
        btnHapus.Location = New Point(190, 185)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(80, 28)
        btnHapus.TabIndex = 6
        btnHapus.Text = "Hapus"

        ' btnBatal
        btnBatal.BackColor = Color.Gray
        btnBatal.FlatStyle = FlatStyle.Flat
        btnBatal.ForeColor = Color.White
        btnBatal.Location = New Point(275, 185)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(80, 28)
        btnBatal.TabIndex = 7
        btnBatal.Text = "Batal"

        ' btnFormPelayanan
        btnFormPelayanan.BackColor = Color.DarkSlateBlue
        btnFormPelayanan.FlatStyle = FlatStyle.Flat
        btnFormPelayanan.ForeColor = Color.White
        btnFormPelayanan.Location = New Point(15, 225)
        btnFormPelayanan.Name = "btnFormPelayanan"
        btnFormPelayanan.Size = New Size(210, 30)
        btnFormPelayanan.TabIndex = 8
        btnFormPelayanan.Text = "Buka Form Data Pelayanan"

        ' lblCari
        lblCari.AutoSize = True
        lblCari.Location = New Point(15, 272)
        lblCari.Name = "lblCari"
        lblCari.Text = "Cari Data"

        ' txtCari
        txtCari.BackColor = Color.LightYellow
        txtCari.Location = New Point(90, 269)
        txtCari.Name = "txtCari"
        txtCari.PlaceholderText = "Cari nama / no. telepon..."
        txtCari.Size = New Size(220, 23)
        txtCari.TabIndex = 9

        ' dgvPelanggan
        dgvPelanggan.AllowUserToAddRows = False
        dgvPelanggan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvPelanggan.BackgroundColor = Color.White
        dgvPelanggan.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkSlateBlue
        dgvPelanggan.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        dgvPelanggan.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        dgvPelanggan.Location = New Point(15, 302)
        dgvPelanggan.Name = "dgvPelanggan"
        dgvPelanggan.ReadOnly = True
        dgvPelanggan.RowHeadersWidth = 30
        dgvPelanggan.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvPelanggan.Size = New Size(760, 220)
        dgvPelanggan.TabIndex = 10

        ' ErrorProvider1
        ErrorProvider1.ContainerControl = Me

        ' Form1
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        ClientSize = New Size(795, 540)
        Controls.Add(lblJudul)
        Controls.Add(lblKode)
        Controls.Add(txtKodePelanggan)
        Controls.Add(lblNama)
        Controls.Add(txtNamaPelanggan)
        Controls.Add(lblTelepon)
        Controls.Add(txtNoTelepon)
        Controls.Add(lblAlamat)
        Controls.Add(txtAlamat)
        Controls.Add(btnSimpan)
        Controls.Add(btnUbah)
        Controls.Add(btnHapus)
        Controls.Add(btnBatal)
        Controls.Add(btnFormPelayanan)
        Controls.Add(lblCari)
        Controls.Add(txtCari)
        Controls.Add(dgvPelanggan)
        Margin = New Padding(2)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Data Pelanggan - Barbershop"

        CType(dgvPelanggan, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblJudul As Label
    Friend WithEvents lblKode As Label
    Friend WithEvents lblNama As Label
    Friend WithEvents lblTelepon As Label
    Friend WithEvents lblAlamat As Label
    Friend WithEvents lblCari As Label
    Friend WithEvents txtKodePelanggan As TextBox
    Friend WithEvents txtNamaPelanggan As TextBox
    Friend WithEvents txtNoTelepon As TextBox
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents txtCari As TextBox
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents btnFormPelayanan As Button
    Friend WithEvents dgvPelanggan As DataGridView
    Friend WithEvents ErrorProvider1 As ErrorProvider

End Class
