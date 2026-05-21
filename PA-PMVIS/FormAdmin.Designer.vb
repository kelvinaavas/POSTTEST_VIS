<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormAdmin
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        lblJudul = New Label()
        dgvAdmin = New DataGridView()
        txtCari = New TextBox()
        lblStatus = New Label()
        cbStatus = New ComboBox()
        lblNama = New Label()
        txtNama = New TextBox()
        lblPelayanan = New Label()
        cbPelayanan = New ComboBox()
        lblBarber = New Label()
        cbBarber = New ComboBox()
        btnUbah = New Button()
        btnHapus = New Button()
        btnCetak = New Button()
        btnKembali = New Button()
        CType(dgvAdmin, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()

        ' lblJudul
        lblJudul.AutoSize = True
        lblJudul.Font = New Font("Segoe UI", 13.0F, FontStyle.Bold)
        lblJudul.ForeColor = Color.DarkSlateBlue
        lblJudul.Location = New Point(21, 25)
        lblJudul.Name = "lblJudul"
        lblJudul.TabIndex = 0
        lblJudul.Text = "Menu Admin"

        ' dgvAdmin
        dgvAdmin.AllowUserToAddRows = False
        dgvAdmin.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvAdmin.BackgroundColor = Color.White
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.DarkSlateBlue
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = Color.White
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvAdmin.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvAdmin.ColumnHeadersHeight = 34
        dgvAdmin.Location = New Point(21, 75)
        dgvAdmin.Name = "dgvAdmin"
        dgvAdmin.ReadOnly = True
        dgvAdmin.RowHeadersWidth = 30
        dgvAdmin.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvAdmin.Size = New Size(1086, 310)
        dgvAdmin.TabIndex = 0

        ' txtCari
        txtCari.BackColor = Color.LightYellow
        txtCari.Location = New Point(21, 403)
        txtCari.Name = "txtCari"
        txtCari.PlaceholderText = "Cari nama / nomor antrian..."
        txtCari.Size = New Size(370, 31)
        txtCari.TabIndex = 1

        ' lblStatus
        lblStatus.AutoSize = True
        lblStatus.Location = New Point(21, 453)
        lblStatus.Name = "lblStatus"
        lblStatus.TabIndex = 2
        lblStatus.Text = "Status"

        ' cbStatus
        cbStatus.BackColor = Color.Azure
        cbStatus.DropDownStyle = ComboBoxStyle.DropDownList
        cbStatus.Location = New Point(21, 481)
        cbStatus.Name = "cbStatus"
        cbStatus.Size = New Size(255, 33)
        cbStatus.TabIndex = 3

        ' lblNama
        lblNama.AutoSize = True
        lblNama.Location = New Point(21, 530)
        lblNama.Name = "lblNama"
        lblNama.TabIndex = 4
        lblNama.Text = "Ubah Nama"

        ' txtNama
        txtNama.BackColor = Color.Azure
        txtNama.Location = New Point(21, 558)
        txtNama.Name = "txtNama"
        txtNama.PlaceholderText = "Nama customer"
        txtNama.Size = New Size(255, 31)
        txtNama.TabIndex = 5

        ' lblPelayanan
        lblPelayanan.AutoSize = True
        lblPelayanan.Location = New Point(21, 605)
        lblPelayanan.Name = "lblPelayanan"
        lblPelayanan.TabIndex = 6
        lblPelayanan.Text = "Ubah Pelayanan"

        ' cbPelayanan
        cbPelayanan.BackColor = Color.Azure
        cbPelayanan.DropDownStyle = ComboBoxStyle.DropDownList
        cbPelayanan.Location = New Point(21, 633)
        cbPelayanan.Name = "cbPelayanan"
        cbPelayanan.Size = New Size(255, 33)
        cbPelayanan.TabIndex = 7

        ' lblBarber
        lblBarber.AutoSize = True
        lblBarber.Location = New Point(21, 682)
        lblBarber.Name = "lblBarber"
        lblBarber.TabIndex = 8
        lblBarber.Text = "Ubah Barber"

        ' cbBarber
        cbBarber.BackColor = Color.Azure
        cbBarber.DropDownStyle = ComboBoxStyle.DropDownList
        cbBarber.Location = New Point(21, 710)
        cbBarber.Name = "cbBarber"
        cbBarber.Size = New Size(255, 33)
        cbBarber.TabIndex = 9

        ' btnUbah
        btnUbah.BackColor = Color.SteelBlue
        btnUbah.FlatAppearance.BorderSize = 0
        btnUbah.FlatStyle = FlatStyle.Flat
        btnUbah.Font = New Font("Segoe UI", 9.0F)
        btnUbah.ForeColor = Color.White
        btnUbah.Location = New Point(21, 768)
        btnUbah.Name = "btnUbah"
        btnUbah.Size = New Size(120, 45)
        btnUbah.TabIndex = 10
        btnUbah.Text = "Ubah"
        btnUbah.UseVisualStyleBackColor = False

        ' btnHapus
        btnHapus.BackColor = Color.IndianRed
        btnHapus.FlatAppearance.BorderSize = 0
        btnHapus.FlatStyle = FlatStyle.Flat
        btnHapus.Font = New Font("Segoe UI", 9.0F)
        btnHapus.ForeColor = Color.White
        btnHapus.Location = New Point(157, 768)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(120, 45)
        btnHapus.TabIndex = 11
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = False

        ' btnCetak — Cetak Semua Data
        btnCetak.BackColor = Color.DarkOliveGreen
        btnCetak.FlatAppearance.BorderSize = 0
        btnCetak.FlatStyle = FlatStyle.Flat
        btnCetak.Font = New Font("Segoe UI", 9.0F)
        btnCetak.ForeColor = Color.White
        btnCetak.Location = New Point(293, 768)
        btnCetak.Name = "btnCetak"
        btnCetak.Size = New Size(150, 45)
        btnCetak.TabIndex = 12
        btnCetak.Text = "🖨 Cetak Semua"
        btnCetak.UseVisualStyleBackColor = False

        ' btnKembali
        btnKembali.BackColor = Color.LightGray
        btnKembali.FlatAppearance.BorderSize = 0
        btnKembali.FlatStyle = FlatStyle.Flat
        btnKembali.Font = New Font("Segoe UI", 9.0F)
        btnKembali.ForeColor = Color.DimGray
        btnKembali.Location = New Point(21, 835)
        btnKembali.Name = "btnKembali"
        btnKembali.Size = New Size(157, 45)
        btnKembali.TabIndex = 13
        btnKembali.Text = "Kembali"
        btnKembali.UseVisualStyleBackColor = False

        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1137, 905)
        Controls.Add(lblJudul)
        Controls.Add(dgvAdmin)
        Controls.Add(txtCari)
        Controls.Add(lblStatus)
        Controls.Add(cbStatus)
        Controls.Add(lblNama)
        Controls.Add(txtNama)
        Controls.Add(lblPelayanan)
        Controls.Add(cbPelayanan)
        Controls.Add(lblBarber)
        Controls.Add(cbBarber)
        Controls.Add(btnUbah)
        Controls.Add(btnHapus)
        Controls.Add(btnCetak)
        Controls.Add(btnKembali)
        Name = "FormAdmin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Barbershop — Admin"
        CType(dgvAdmin, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblJudul As Label
    Friend WithEvents dgvAdmin As DataGridView
    Friend WithEvents txtCari As TextBox
    Friend WithEvents lblStatus As Label
    Friend WithEvents cbStatus As ComboBox
    Friend WithEvents lblNama As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents lblPelayanan As Label
    Friend WithEvents cbPelayanan As ComboBox
    Friend WithEvents lblBarber As Label
    Friend WithEvents cbBarber As ComboBox
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnCetak As Button
    Friend WithEvents btnKembali As Button

End Class
