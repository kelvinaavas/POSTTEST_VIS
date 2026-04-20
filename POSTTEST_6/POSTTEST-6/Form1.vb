Public Class Form1

    ' ============================================================
    ' FORM 1 — DATA PELANGGAN (tbpelanggan)
    ' Tabel INDUK yang berelasi One-to-Many ke tbpelayanan
    ' ============================================================

    Private Sub KosongForm()
        txtKodePelanggan.Clear()
        txtNamaPelanggan.Clear()
        txtNoTelepon.Clear()
        txtAlamat.Clear()
        txtCari.Clear()
        ErrorProvider1.Clear()
        txtKodePelanggan.Focus()
    End Sub

    Private Sub TampilData()
        dgvPelanggan.DataSource = DataModule.GetAllPelanggan()
        If dgvPelanggan.Columns.Count >= 4 Then
            dgvPelanggan.Columns(0).HeaderText = "Kode Pelanggan"
            dgvPelanggan.Columns(1).HeaderText = "Nama Pelanggan"
            dgvPelanggan.Columns(2).HeaderText = "No. Telepon"
            dgvPelanggan.Columns(3).HeaderText = "Alamat"
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilData()
        KosongForm()
    End Sub

    ' ---- SIMPAN ----
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        ErrorProvider1.Clear()
        If Not ValidationModule.ValidasiDataPelanggan(ErrorProvider1,
                                                       txtKodePelanggan,
                                                       txtNamaPelanggan,
                                                       txtNoTelepon) Then Exit Sub

        Dim kode As String = txtKodePelanggan.Text.Trim()
        If DataModule.KodePelangganSudahAda(kode) Then
            MessageBox.Show("Kode Pelanggan sudah terdaftar!", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtKodePelanggan.Focus()
            Exit Sub
        End If

        If DataModule.SimpanPelanggan(kode,
                                       txtNamaPelanggan.Text.Trim(),
                                       txtNoTelepon.Text.Trim(),
                                       txtAlamat.Text.Trim()) Then
            MessageBox.Show("Data pelanggan berhasil disimpan!", "Informasi",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            TampilData()
            KosongForm()
        End If
    End Sub

    ' ---- UBAH ----
    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        ErrorProvider1.Clear()
        If Not ValidationModule.ValidasiDataPelanggan(ErrorProvider1,
                                                       txtKodePelanggan,
                                                       txtNamaPelanggan,
                                                       txtNoTelepon) Then Exit Sub

        If DataModule.UbahPelanggan(txtKodePelanggan.Text.Trim(),
                                     txtNamaPelanggan.Text.Trim(),
                                     txtNoTelepon.Text.Trim(),
                                     txtAlamat.Text.Trim()) Then
            MessageBox.Show("Data pelanggan berhasil diubah!", "Informasi",
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
        If txtKodePelanggan.Text.Trim() = "" Then
            MessageBox.Show("Pilih data pelanggan yang akan dihapus!", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim konfirmasi As DialogResult = MessageBox.Show(
            "Apakah data pelanggan ini ingin dihapus?" & Environment.NewLine &
            "Semua data pelayanan terkait juga akan terhapus (CASCADE).",
            "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If konfirmasi = DialogResult.Yes Then
            If DataModule.HapusPelanggan(txtKodePelanggan.Text.Trim()) Then
                MessageBox.Show("Data pelanggan berhasil dihapus!", "Informasi",
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
    Private Sub dgvPelanggan_CellClick(sender As Object, e As DataGridViewCellEventArgs) _
        Handles dgvPelanggan.CellClick
        If e.RowIndex >= 0 Then
            txtKodePelanggan.Text = dgvPelanggan.Rows(e.RowIndex).Cells(0).Value.ToString()
            txtNamaPelanggan.Text = dgvPelanggan.Rows(e.RowIndex).Cells(1).Value.ToString()
            txtNoTelepon.Text = dgvPelanggan.Rows(e.RowIndex).Cells(2).Value.ToString()
            txtAlamat.Text = dgvPelanggan.Rows(e.RowIndex).Cells(3).Value.ToString()
        End If
    End Sub

    ' ---- CARI REAL-TIME ----
    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
        If txtCari.Text.Trim() = "" Then
            TampilData()
        Else
            dgvPelanggan.DataSource = DataModule.SearchPelanggan(txtCari.Text.Trim())
        End If
    End Sub

    ' ---- BUKA FORM PELAYANAN ----
    Private Sub btnFormPelayanan_Click(sender As Object, e As EventArgs) Handles btnFormPelayanan.Click
        Dim f2 As New Form2()
        f2.Show()
    End Sub

    ' ---- HANYA ANGKA UNTUK NO TELEPON ----
    Private Sub txtNoTelepon_KeyPress(sender As Object, e As KeyPressEventArgs) _
        Handles txtNoTelepon.KeyPress
        ValidationModule.HanyaAngka(e)
    End Sub

End Class
