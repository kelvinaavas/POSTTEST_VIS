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
        components = New ComponentModel.Container()

        lblJudul = New Label()
        lblRelasi = New Label()
        lblKodePelayanan = New Label()
        lblPelanggan = New Label()
        lblJenis = New Label()
        lblHarga = New Label()
        lblTanggal = New Label()
        lblCari = New Label()
        txtKodePelayanan = New TextBox()
        txtHarga = New TextBox()
        txtCari = New TextBox()
        cbPelanggan = New ComboBox()
        cbJenisPemotongan = New ComboBox()
        dtpTanggal = New DateTimePicker()
        btnSimpan = New Button()
        btnUbah = New Button()
        btnHapus = New Button()
        btnBatal = New Button()
        dgvPelayanan = New DataGridView()
        ErrorProvider1 = New ErrorProvider(components)

        CType(dgvPelayanan, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()

        ' lblJudul
        lblJudul.AutoSize = True
        lblJudul.Font = New Font("Segoe UI", 13, FontStyle.Bold)
        lblJudul.ForeColor = Color.DarkSlateBlue
        lblJudul.Location = New Point(12, 12)
        lblJudul.Name = "lblJudul"
        lblJudul.Text = "Data Pelayanan Barbershop"

        ' lblRelasi
        lblRelasi.AutoSize = True
        lblRelasi.Font = New Font("Segoe UI", 8, FontStyle.Italic)
        lblRelasi.ForeColor = Color.SlateGray
        lblRelasi.Location = New Point(14, 38)
        lblRelasi.Name = "lblRelasi"
        lblRelasi.Text = "Tabel ini berelasi (Foreign Key) dengan tabel tbpelanggan"

        ' lblKodePelayanan
        lblKodePelayanan.AutoSize = True
        lblKodePelayanan.Location = New Point(15, 70)
        lblKodePelayanan.Name = "lblKodePelayanan"
        lblKodePelayanan.Text = "Kode Pelayanan"

        ' txtKodePelayanan
        txtKodePelayanan.BackColor = Color.Azure
        txtKodePelayanan.Location = New Point(160, 67)
        txtKodePelayanan.Name = "txtKodePelayanan"
        txtKodePelayanan.PlaceholderText = "Contoh: SV001"
        txtKodePelayanan.Size = New Size(120, 23)
        txtKodePelayanan.TabIndex = 0

        ' lblPelanggan
        lblPelanggan.AutoSize = True
        lblPelanggan.Location = New Point(15, 100)
        lblPelanggan.Name = "lblPelanggan"
        lblPelanggan.Text = "Pelanggan (FK)"

        ' cbPelanggan
        cbPelanggan.BackColor = Color.Azure
        cbPelanggan.DropDownStyle = ComboBoxStyle.DropDownList
        cbPelanggan.Location = New Point(160, 97)
        cbPelanggan.Name = "cbPelanggan"
        cbPelanggan.Size = New Size(220, 23)
        cbPelanggan.TabIndex = 1

        ' lblJenis
        lblJenis.AutoSize = True
        lblJenis.Location = New Point(15, 130)
        lblJenis.Name = "lblJenis"
        lblJenis.Text = "Jenis Pemotongan"

        ' cbJenisPemotongan
        cbJenisPemotongan.BackColor = Color.Azure
        cbJenisPemotongan.DropDownStyle = ComboBoxStyle.DropDownList
        cbJenisPemotongan.Location = New Point(160, 127)
        cbJenisPemotongan.Name = "cbJenisPemotongan"
        cbJenisPemotongan.Size = New Size(280, 23)
        cbJenisPemotongan.TabIndex = 2

        ' lblHarga
        lblHarga.AutoSize = True
        lblHarga.Location = New Point(15, 160)
        lblHarga.Name = "lblHarga"
        lblHarga.Text = "Harga (Rp)"

        ' txtHarga
        txtHarga.BackColor = Color.Azure
        txtHarga.Location = New Point(160, 157)
        txtHarga.Name = "txtHarga"
        txtHarga.PlaceholderText = "Contoh: 35000"
        txtHarga.Size = New Size(130, 23)
        txtHarga.TabIndex = 3

        ' lblTanggal
        lblTanggal.AutoSize = True
        lblTanggal.Location = New Point(15, 190)
        lblTanggal.Name = "lblTanggal"
        lblTanggal.Text = "Tanggal Pelayanan"

        ' dtpTanggal
        dtpTanggal.Format = DateTimePickerFormat.Short
        dtpTanggal.Location = New Point(160, 187)
        dtpTanggal.Name = "dtpTanggal"
        dtpTanggal.Size = New Size(160, 23)
        dtpTanggal.TabIndex = 4

        ' btnSimpan
        btnSimpan.BackColor = Color.MediumSeaGreen
        btnSimpan.FlatStyle = FlatStyle.Flat
        btnSimpan.ForeColor = Color.White
        btnSimpan.Location = New Point(15, 228)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(85, 28)
        btnSimpan.TabIndex = 5
        btnSimpan.Text = "Simpan"

        ' btnUbah
        btnUbah.BackColor = Color.SteelBlue
        btnUbah.FlatStyle = FlatStyle.Flat
        btnUbah.ForeColor = Color.White
        btnUbah.Location = New Point(105, 228)
        btnUbah.Name = "btnUbah"
        btnUbah.Size = New Size(80, 28)
        btnUbah.TabIndex = 6
        btnUbah.Text = "Ubah"

        ' btnHapus
        btnHapus.BackColor = Color.IndianRed
        btnHapus.FlatStyle = FlatStyle.Flat
        btnHapus.ForeColor = Color.White
        btnHapus.Location = New Point(190, 228)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(80, 28)
        btnHapus.TabIndex = 7
        btnHapus.Text = "Hapus"

        ' btnBatal
        btnBatal.BackColor = Color.Gray
        btnBatal.FlatStyle = FlatStyle.Flat
        btnBatal.ForeColor = Color.White
        btnBatal.Location = New Point(275, 228)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(80, 28)
        btnBatal.TabIndex = 8
        btnBatal.Text = "Batal"

        ' lblCari
        lblCari.AutoSize = True
        lblCari.Location = New Point(15, 275)
        lblCari.Name = "lblCari"
        lblCari.Text = "Cari Data"

        ' txtCari
        txtCari.BackColor = Color.LightYellow
        txtCari.Location = New Point(90, 272)
        txtCari.Name = "txtCari"
        txtCari.PlaceholderText = "Cari nama pelanggan / jenis..."
        txtCari.Size = New Size(250, 23)
        txtCari.TabIndex = 9

        ' dgvPelayanan
        dgvPelayanan.AllowUserToAddRows = False
        dgvPelayanan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvPelayanan.BackgroundColor = Color.White
        dgvPelayanan.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkSlateBlue
        dgvPelayanan.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        dgvPelayanan.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        dgvPelayanan.Location = New Point(15, 305)
        dgvPelayanan.Name = "dgvPelayanan"
        dgvPelayanan.ReadOnly = True
        dgvPelayanan.RowHeadersWidth = 30
        dgvPelayanan.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvPelayanan.Size = New Size(860, 230)
        dgvPelayanan.TabIndex = 10

        ' ErrorProvider1
        ErrorProvider1.ContainerControl = Me

        ' Form2
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        ClientSize = New Size(895, 552)
        Controls.Add(lblJudul)
        Controls.Add(lblRelasi)
        Controls.Add(lblKodePelayanan)
        Controls.Add(txtKodePelayanan)
        Controls.Add(lblPelanggan)
        Controls.Add(cbPelanggan)
        Controls.Add(lblJenis)
        Controls.Add(cbJenisPemotongan)
        Controls.Add(lblHarga)
        Controls.Add(txtHarga)
        Controls.Add(lblTanggal)
        Controls.Add(dtpTanggal)
        Controls.Add(btnSimpan)
        Controls.Add(btnUbah)
        Controls.Add(btnHapus)
        Controls.Add(btnBatal)
        Controls.Add(lblCari)
        Controls.Add(txtCari)
        Controls.Add(dgvPelayanan)
        Margin = New Padding(2)
        Name = "Form2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Data Pelayanan - Barbershop"

        CType(dgvPelayanan, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblJudul As Label
    Friend WithEvents lblRelasi As Label
    Friend WithEvents lblKodePelayanan As Label
    Friend WithEvents lblPelanggan As Label
    Friend WithEvents lblJenis As Label
    Friend WithEvents lblHarga As Label
    Friend WithEvents lblTanggal As Label
    Friend WithEvents lblCari As Label
    Friend WithEvents txtKodePelayanan As TextBox
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents txtCari As TextBox
    Friend WithEvents cbPelanggan As ComboBox
    Friend WithEvents cbJenisPemotongan As ComboBox
    Friend WithEvents dtpTanggal As DateTimePicker
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents dgvPelayanan As DataGridView
    Friend WithEvents ErrorProvider1 As ErrorProvider

End Class
