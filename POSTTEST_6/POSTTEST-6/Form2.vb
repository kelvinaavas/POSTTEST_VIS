Public Class Form2

    ' ============================================================
    ' FORM 2 — DATA PELAYANAN (tbpelayanan)
    ' Tabel ANAK yang berelasi ke tbpelanggan
    ' Foreign Key: kodePelanggan → tbpelanggan.kodePelanggan
    ' ON DELETE CASCADE | ON UPDATE CASCADE
    ' ============================================================

    Private Sub KosongForm()
        txtKodePelayanan.Clear()
        cbPelanggan.SelectedIndex = -1
        cbJenisPemotongan.SelectedIndex = -1
        txtHarga.Clear()
        dtpTanggal.Value = DateTime.Today
        txtCari.Clear()
        ErrorProvider1.Clear()
        txtKodePelayanan.Focus()
    End Sub

    Private Sub TampilData()
        dgvPelayanan.DataSource = DataModule.GetAllPelayanan()
        If dgvPelayanan.Columns.Count >= 5 Then
            dgvPelayanan.Columns(0).HeaderText = "Kode Pelayanan"
            dgvPelayanan.Columns(1).HeaderText = "Nama Pelanggan"
            dgvPelayanan.Columns(2).HeaderText = "Jenis Pemotongan"
            dgvPelayanan.Columns(3).HeaderText = "Harga (Rp)"
            dgvPelayanan.Columns(4).HeaderText = "Tanggal"
        End If
    End Sub

    Private Sub MuatDataPelanggan()
        Dim dtPelanggan As DataTable = DataModule.GetAllPelanggan()
        cbPelanggan.DataSource = dtPelanggan
        cbPelanggan.DisplayMember = "namaPelanggan"
        cbPelanggan.ValueMember = "kodePelanggan"
        cbPelanggan.SelectedIndex = -1
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbJenisPemotongan.Items.AddRange(New String() {
            "Cukur Reguler",
            "Cukur + Cuci Rambut",
            "Fade Cut",
            "Undercut",
            "Cukur Jenggot",
            "Cukur Kumis",
            "Full Package (Rambut + Jenggot + Kumis)"
        })
        MuatDataPelanggan()
        TampilData()
        KosongForm()
    End Sub

    ' ---- SIMPAN ----
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        ErrorProvider1.Clear()
        If Not ValidationModule.ValidasiDataPelayanan(ErrorProvider1,
                                                       txtKodePelayanan,
                                                       cbPelanggan,
                                                       cbJenisPemotongan,
                                                       txtHarga) Then Exit Sub

        Dim kode As String = txtKodePelayanan.Text.Trim()
        If DataModule.KodePelayananSudahAda(kode) Then
            MessageBox.Show("Kode Pelayanan sudah terdaftar!", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtKodePelayanan.Focus()
            Exit Sub
        End If

        Dim kodePelanggan As String = cbPelanggan.SelectedValue.ToString()
        Dim jenis As String = cbJenisPemotongan.Text.Trim()
        Dim harga As Integer = Convert.ToInt32(txtHarga.Text.Trim())
        Dim tanggal As String = dtpTanggal.Value.ToString("yyyy-MM-dd")

        If DataModule.SimpanPelayanan(kode, kodePelanggan, jenis, harga, tanggal) Then
            MessageBox.Show("Data pelayanan berhasil disimpan!", "Informasi",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            TampilData()
            KosongForm()
            MuatDataPelanggan()
        End If
    End Sub

    ' ---- UBAH ----
    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        ErrorProvider1.Clear()
        If Not ValidationModule.ValidasiDataPelayanan(ErrorProvider1,
                                                       txtKodePelayanan,
                                                       cbPelanggan,
                                                       cbJenisPemotongan,
                                                       txtHarga) Then Exit Sub

        Dim kodePelanggan As String = cbPelanggan.SelectedValue.ToString()
        Dim jenis As String = cbJenisPemotongan.Text.Trim()
        Dim harga As Integer = Convert.ToInt32(txtHarga.Text.Trim())
        Dim tanggal As String = dtpTanggal.Value.ToString("yyyy-MM-dd")

        If DataModule.UbahPelayanan(txtKodePelayanan.Text.Trim(), kodePelanggan,
                                    jenis, harga, tanggal) Then
            MessageBox.Show("Data pelayanan berhasil diubah!", "Informasi",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            TampilData()
            KosongForm()
        Else
            MessageBox.Show("Data tidak ditemukan!", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    ' ---- HAPUS ----
    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If txtKodePelayanan.Text.Trim() = "" Then
            MessageBox.Show("Pilih data pelayanan yang akan dihapus!", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim konfirmasi As DialogResult = MessageBox.Show(
            "Apakah data pelayanan ini ingin dihapus?",
            "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If konfirmasi = DialogResult.Yes Then
            If DataModule.HapusPelayanan(txtKodePelayanan.Text.Trim()) Then
                MessageBox.Show("Data pelayanan berhasil dihapus!", "Informasi",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)
                TampilData()
                KosongForm()
            End If
        End If
    End Sub

    ' ---- BATAL ----
    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        KosongForm()
        TampilData()
    End Sub

    ' ---- PILIH DARI DGV ----
    Private Sub dgvPelayanan_CellClick(sender As Object, e As DataGridViewCellEventArgs) _
        Handles dgvPelayanan.CellClick
        If e.RowIndex >= 0 Then
            txtKodePelayanan.Text = dgvPelayanan.Rows(e.RowIndex).Cells(0).Value.ToString()
            cbPelanggan.Text = dgvPelayanan.Rows(e.RowIndex).Cells(1).Value.ToString()
            cbJenisPemotongan.Text = dgvPelayanan.Rows(e.RowIndex).Cells(2).Value.ToString()
            txtHarga.Text = dgvPelayanan.Rows(e.RowIndex).Cells(3).Value.ToString()
            Dim tglStr As String = dgvPelayanan.Rows(e.RowIndex).Cells(4).Value.ToString()
            If tglStr <> "" Then
                dtpTanggal.Value = Convert.ToDateTime(tglStr)
            End If
        End If
    End Sub

    ' ---- CARI REAL-TIME ----
    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
        If txtCari.Text.Trim() = "" Then
            TampilData()
        Else
            dgvPelayanan.DataSource = DataModule.SearchPelayanan(txtCari.Text.Trim())
        End If
    End Sub

    ' ---- HANYA ANGKA UNTUK HARGA ----
    Private Sub txtHarga_KeyPress(sender As Object, e As KeyPressEventArgs) _
        Handles txtHarga.KeyPress
        ValidationModule.HanyaAngka(e)
    End Sub

End Class
