Public Class FormBooking

    Private dtPelayanan As DataTable   ' simpan DataTable pelayanan agar bisa ambil harga

    Private Sub FormBooking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtPelayanan = DataModule.GetAllPelayanan()
        cbPelayanan.DataSource = dtPelayanan
        cbPelayanan.DisplayMember = "namaPelayanan"
        cbPelayanan.ValueMember = "idPelayanan"
        cbPelayanan.SelectedIndex = -1

        Dim dtBarber As DataTable = DataModule.GetAllBarber()
        cbBarber.DataSource = dtBarber
        cbBarber.DisplayMember = "namaBarber"
        cbBarber.ValueMember = "idBarber"
        cbBarber.SelectedIndex = -1

        txtNomorAntrian.Text = DataModule.GetNomorAntrianBerikutnya()
        txtNomorAntrian.ReadOnly = True

        lblHarga.Text = ""
    End Sub

    ' Tampilkan harga saat pelayanan dipilih
    Private Sub cbPelayanan_SelectedIndexChanged(sender As Object, e As EventArgs) _
        Handles cbPelayanan.SelectedIndexChanged
        If cbPelayanan.SelectedIndex >= 0 AndAlso dtPelayanan IsNot Nothing Then
            Dim harga As Object = dtPelayanan.Rows(cbPelayanan.SelectedIndex)("harga")
            If harga IsNot DBNull.Value Then
                lblHarga.Text = "Harga: Rp " & FormatNumber(Convert.ToInt64(harga), 0)
            Else
                lblHarga.Text = "Harga: -"
            End If
        Else
            lblHarga.Text = ""
        End If
    End Sub

    Private Sub btnBooking_Click(sender As Object, e As EventArgs) Handles btnBooking.Click
        If txtNama.Text.Trim() = "" Then
            MessageBox.Show("Nama tidak boleh kosong!", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNama.Focus() : Exit Sub
        End If
        If cbPelayanan.SelectedIndex = -1 Then
            MessageBox.Show("Silakan pilih jenis pelayanan!", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        If cbBarber.SelectedIndex = -1 Then
            MessageBox.Show("Silakan pilih barber!", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim nomor As String = txtNomorAntrian.Text.Trim()
        Dim nama As String = txtNama.Text.Trim()
        Dim idPelayanan As Integer = Convert.ToInt32(cbPelayanan.SelectedValue)
        Dim idBarber As Integer = Convert.ToInt32(cbBarber.SelectedValue)

        If DataModule.SimpanAntrian(nomor, nama, idPelayanan, idBarber) Then
            MessageBox.Show("Booking berhasil! Nomor antrian kamu: " & nomor,
                            "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtNama.Clear()
            cbPelayanan.SelectedIndex = -1
            cbBarber.SelectedIndex = -1
            lblHarga.Text = ""
            txtNomorAntrian.Text = DataModule.GetNomorAntrianBerikutnya()
        End If
    End Sub

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Me.Close()
    End Sub

    Private Sub FormBooking_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        FormMenuAwal.Show()
    End Sub

End Class
