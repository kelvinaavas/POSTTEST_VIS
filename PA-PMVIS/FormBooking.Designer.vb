<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormBooking
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then components.Dispose()
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblJudul = New Label()
        lblNama = New Label()
        txtNama = New TextBox()
        lblPelayanan = New Label()
        cbPelayanan = New ComboBox()
        lblHarga = New Label()
        lblBarber = New Label()
        cbBarber = New ComboBox()
        lblNomor = New Label()
        txtNomorAntrian = New TextBox()
        btnBooking = New Button()
        btnKembali = New Button()
        SuspendLayout()

        ' lblJudul
        lblJudul.AutoSize = True
        lblJudul.Font = New Font("Segoe UI", 13, FontStyle.Bold)
        lblJudul.ForeColor = Color.DarkSlateBlue
        lblJudul.Location = New Point(20, 15)
        lblJudul.Text = "Menu Pemesanan"

        ' lblNama
        lblNama.AutoSize = True
        lblNama.Location = New Point(20, 55)
        lblNama.Text = "Nama :"

        ' txtNama
        txtNama.BackColor = Color.Azure
        txtNama.Location = New Point(20, 73)
        txtNama.Name = "txtNama"
        txtNama.PlaceholderText = "Masukkan nama kamu"
        txtNama.Size = New Size(300, 23)
        txtNama.TabIndex = 0

        ' lblPelayanan
        lblPelayanan.AutoSize = True
        lblPelayanan.Location = New Point(20, 108)
        lblPelayanan.Text = "Pilih Pelayanan :"

        ' cbPelayanan
        cbPelayanan.BackColor = Color.Azure
        cbPelayanan.DropDownStyle = ComboBoxStyle.DropDownList
        cbPelayanan.Location = New Point(20, 126)
        cbPelayanan.Name = "cbPelayanan"
        cbPelayanan.Size = New Size(300, 23)
        cbPelayanan.TabIndex = 1

        ' lblHarga — tampil harga setelah pilih pelayanan
        lblHarga.AutoSize = True
        lblHarga.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        lblHarga.ForeColor = Color.DarkGreen
        lblHarga.Location = New Point(20, 155)
        lblHarga.Name = "lblHarga"
        lblHarga.Text = ""

        ' lblBarber
        lblBarber.AutoSize = True
        lblBarber.Location = New Point(20, 178)
        lblBarber.Text = "Pilih Barber :"

        ' cbBarber
        cbBarber.BackColor = Color.Azure
        cbBarber.DropDownStyle = ComboBoxStyle.DropDownList
        cbBarber.Location = New Point(20, 196)
        cbBarber.Name = "cbBarber"
        cbBarber.Size = New Size(300, 23)
        cbBarber.TabIndex = 2

        ' lblNomor
        lblNomor.AutoSize = True
        lblNomor.Location = New Point(20, 231)
        lblNomor.Text = "Nomor Antrian :"

        ' txtNomorAntrian
        txtNomorAntrian.BackColor = Color.LightYellow
        txtNomorAntrian.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        txtNomorAntrian.Location = New Point(20, 249)
        txtNomorAntrian.Name = "txtNomorAntrian"
        txtNomorAntrian.Size = New Size(120, 25)
        txtNomorAntrian.TabIndex = 3

        ' btnBooking
        btnBooking.BackColor = Color.SteelBlue
        btnBooking.FlatStyle = FlatStyle.Flat
        btnBooking.FlatAppearance.BorderSize = 0
        btnBooking.ForeColor = Color.White
        btnBooking.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        btnBooking.Location = New Point(20, 295)
        btnBooking.Name = "btnBooking"
        btnBooking.Size = New Size(140, 34)
        btnBooking.TabIndex = 4
        btnBooking.Text = "Booking"

        ' btnKembali
        btnKembali.BackColor = Color.LightGray
        btnKembali.FlatStyle = FlatStyle.Flat
        btnKembali.FlatAppearance.BorderSize = 0
        btnKembali.ForeColor = Color.DimGray
        btnKembali.Font = New Font("Segoe UI", 10)
        btnKembali.Location = New Point(170, 295)
        btnKembali.Name = "btnKembali"
        btnKembali.Size = New Size(110, 34)
        btnKembali.TabIndex = 5
        btnKembali.Text = "Kembali"

        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(360, 360)
        Controls.Add(lblJudul)
        Controls.Add(lblNama)
        Controls.Add(txtNama)
        Controls.Add(lblPelayanan)
        Controls.Add(cbPelayanan)
        Controls.Add(lblHarga)
        Controls.Add(lblBarber)
        Controls.Add(cbBarber)
        Controls.Add(lblNomor)
        Controls.Add(txtNomorAntrian)
        Controls.Add(btnBooking)
        Controls.Add(btnKembali)
        Name = "FormBooking"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Barbershop — Booking"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblJudul As Label
    Friend WithEvents lblNama As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents lblPelayanan As Label
    Friend WithEvents cbPelayanan As ComboBox
    Friend WithEvents lblHarga As Label
    Friend WithEvents lblBarber As Label
    Friend WithEvents cbBarber As ComboBox
    Friend WithEvents lblNomor As Label
    Friend WithEvents txtNomorAntrian As TextBox
    Friend WithEvents btnBooking As Button
    Friend WithEvents btnKembali As Button

End Class
