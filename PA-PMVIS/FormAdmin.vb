Imports System.Drawing.Printing

Public Class FormAdmin

    Private selectedId As Integer = -1
    Private selectedRow As DataGridViewRow = Nothing

    Private Sub FormAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Isi ComboBox Pelayanan
        Dim dtPelayanan As DataTable = DataModule.GetAllPelayanan()
        cbPelayanan.DataSource = dtPelayanan
        cbPelayanan.DisplayMember = "namaPelayanan"
        cbPelayanan.ValueMember = "idPelayanan"
        cbPelayanan.SelectedIndex = -1

        ' Isi ComboBox Barber
        Dim dtBarber As DataTable = DataModule.GetAllBarber()
        cbBarber.DataSource = dtBarber
        cbBarber.DisplayMember = "namaBarber"
        cbBarber.ValueMember = "idBarber"
        cbBarber.SelectedIndex = -1

        ' Isi ComboBox Status
        cbStatus.Items.AddRange(New String() {"Menunggu", "Proses", "Selesai"})
        cbStatus.SelectedIndex = 0

        TampilData()
    End Sub

    Private Sub TampilData()
        dgvAdmin.DataSource = DataModule.GetAllAntrian()
        ' Kolom: 0=idAntrian, 1=nomorAntrian, 2=namaCustomer,
        '        3=namaPelayanan, 4=harga, 5=namaBarber, 6=status
        If dgvAdmin.Columns.Count >= 7 Then
            dgvAdmin.Columns(0).Visible = False
            dgvAdmin.Columns(1).HeaderText = "Nomor"
            dgvAdmin.Columns(1).Width = 70
            dgvAdmin.Columns(2).HeaderText = "Nama"
            dgvAdmin.Columns(3).HeaderText = "Pelayanan"
            dgvAdmin.Columns(4).HeaderText = "Harga (Rp)"
            dgvAdmin.Columns(4).Width = 110
            dgvAdmin.Columns(4).DefaultCellStyle.Format = "N0"
            dgvAdmin.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvAdmin.Columns(5).HeaderText = "Barber"
            dgvAdmin.Columns(6).HeaderText = "Status"
            dgvAdmin.Columns(6).Width = 90
        End If
        selectedId = -1
        selectedRow = Nothing
        txtNama.Clear()
        cbPelayanan.SelectedIndex = -1
        cbBarber.SelectedIndex = -1
    End Sub

    ' ---- PILIH BARIS DGV ----
    Private Sub dgvAdmin_CellClick(sender As Object, e As DataGridViewCellEventArgs) _
        Handles dgvAdmin.CellClick
        If e.RowIndex >= 0 Then
            selectedId = Convert.ToInt32(dgvAdmin.Rows(e.RowIndex).Cells(0).Value)
            selectedRow = dgvAdmin.Rows(e.RowIndex)
            ' Kolom 6 = status
            cbStatus.Text = dgvAdmin.Rows(e.RowIndex).Cells(6).Value.ToString()
            txtNama.Text = dgvAdmin.Rows(e.RowIndex).Cells(2).Value.ToString()

            ' Set ComboBox Pelayanan sesuai nama pelayanan di baris (kolom 3)
            Dim namaPelayanan As String = dgvAdmin.Rows(e.RowIndex).Cells(3).Value.ToString()
            For i As Integer = 0 To cbPelayanan.Items.Count - 1
                Dim row As DataRowView = CType(cbPelayanan.Items(i), DataRowView)
                If row("namaPelayanan").ToString() = namaPelayanan Then
                    cbPelayanan.SelectedIndex = i
                    Exit For
                End If
            Next

            ' Set ComboBox Barber sesuai nama barber di baris (kolom 5)
            Dim namaBarber As String = dgvAdmin.Rows(e.RowIndex).Cells(5).Value.ToString()
            For i As Integer = 0 To cbBarber.Items.Count - 1
                Dim row As DataRowView = CType(cbBarber.Items(i), DataRowView)
                If row("namaBarber").ToString() = namaBarber Then
                    cbBarber.SelectedIndex = i
                    Exit For
                End If
            Next
        End If
    End Sub

    ' ---- CARI ----
    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
        If txtCari.Text.Trim() = "" Then
            TampilData()
        Else
            dgvAdmin.DataSource = DataModule.SearchAntrian(txtCari.Text.Trim())
        End If
    End Sub

    ' ---- UBAH ----
    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        If selectedId = -1 Then
            MessageBox.Show("Pilih data antrian terlebih dahulu!", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        If txtNama.Text.Trim() = "" Then
            MessageBox.Show("Nama tidak boleh kosong!", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNama.Focus()
            Exit Sub
        End If
        If cbPelayanan.SelectedIndex = -1 Then
            MessageBox.Show("Silakan pilih pelayanan!", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        If cbBarber.SelectedIndex = -1 Then
            MessageBox.Show("Silakan pilih barber!", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim idPelayanan As Integer = Convert.ToInt32(cbPelayanan.SelectedValue)
        Dim idBarber As Integer = Convert.ToInt32(cbBarber.SelectedValue)

        If DataModule.UbahAntrian(selectedId, cbStatus.Text, txtNama.Text.Trim(),
                                   idPelayanan, idBarber) Then
            MessageBox.Show("Data berhasil diubah!", "Informasi",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            TampilData()
        Else
            MessageBox.Show("Data tidak ditemukan!", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    ' ---- HAPUS ----
    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If selectedId = -1 Then
            MessageBox.Show("Pilih data antrian yang akan dihapus!", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim konfirmasi As DialogResult = MessageBox.Show(
            "Apakah data antrian ini ingin dihapus?",
            "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If konfirmasi = DialogResult.Yes Then
            If DataModule.HapusAntrian(selectedId) Then
                MessageBox.Show("Data berhasil dihapus!", "Informasi",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)
                TampilData()
            End If
        End If
    End Sub

    ' ============================================================
    ' ---- CETAK SEMUA DATA ----
    ' ============================================================
    Private allData As DataTable   ' simpan data untuk dipakai saat print

    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click
        allData = DataModule.GetAllAntrian()
        If allData Is Nothing OrElse allData.Rows.Count = 0 Then
            MessageBox.Show("Tidak ada data antrian untuk dicetak!", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim pd As New PrintDocument()
        AddHandler pd.PrintPage, AddressOf CetakSemuaData

        Dim preview As New PrintPreviewDialog()
        preview.Document = pd
        preview.Width = 700
        preview.Height = 750
        preview.Text = "Preview Cetak Semua Data Antrian"
        preview.ShowDialog()
    End Sub

    Private printRowIndex As Integer = 0   ' posisi baris yang sedang dicetak

    Private Sub CetakSemuaData(sender As Object, e As PrintPageEventArgs)
        Dim g As Graphics = e.Graphics

        Dim fontJudul As New Font("Courier New", 13, FontStyle.Bold)
        Dim fontHeader As New Font("Courier New", 8, FontStyle.Bold)
        Dim fontNormal As New Font("Courier New", 8)
        Dim fontKecil As New Font("Courier New", 7)
        Dim brush As New SolidBrush(Color.Black)
        Dim brushHeader As New SolidBrush(Color.DarkSlateBlue)

        Dim marginL As Integer = 20
        Dim pageW As Integer = e.MarginBounds.Width + marginL
        Dim y As Integer = e.MarginBounds.Top

        ' ---- Header halaman pertama saja ----
        If printRowIndex = 0 Then
            g.DrawString("BARBERSHOP", fontJudul, brush,
                         New RectangleF(marginL, y, pageW, 30),
                         New StringFormat() With {.Alignment = StringAlignment.Center})
            y += 28
            g.DrawString("Laporan Semua Data Antrian", fontNormal, brush,
                         New RectangleF(marginL, y, pageW, 20),
                         New StringFormat() With {.Alignment = StringAlignment.Center})
            y += 18
            g.DrawString("Dicetak: " & DateTime.Now.ToString("dd/MM/yyyy HH:mm"),
                         fontKecil, brush, marginL, y)
            y += 18
            g.DrawString(New String("="c, 95), fontKecil, brush, marginL, y)
            y += 14
        End If

        ' ---- Header kolom tabel ----
        Dim colX As Integer() = {marginL, marginL + 45, marginL + 145, marginL + 280, marginL + 370, marginL + 470, marginL + 560}
        Dim headers As String() = {"No.", "Nomor", "Nama", "Pelayanan", "Harga (Rp)", "Barber", "Status"}

        Dim rectHeader As New Rectangle(marginL, y, pageW - marginL, 18)
        g.FillRectangle(brushHeader, rectHeader)
        Dim whiteBrush As New SolidBrush(Color.White)
        For i As Integer = 0 To headers.Length - 1
            g.DrawString(headers(i), fontHeader, whiteBrush, colX(i), y + 2)
        Next
        whiteBrush.Dispose()
        y += 20

        ' ---- Baris data ----
        Dim rowNum As Integer = printRowIndex + 1
        Dim rowH As Integer = 17
        Dim altBrush As New SolidBrush(Color.AliceBlue)

        Do While printRowIndex < allData.Rows.Count
            ' Cek apakah masih muat di halaman
            If y + rowH > e.MarginBounds.Bottom Then
                e.HasMorePages = True
                GoTo CleanUp
            End If

            Dim dr As DataRow = allData.Rows(printRowIndex)
            ' Kolom: 0=idAntrian, 1=nomorAntrian, 2=namaCustomer,
            '        3=namaPelayanan, 4=harga, 5=namaBarber, 6=status

            ' Warna selang-seling
            If printRowIndex Mod 2 = 0 Then
                g.FillRectangle(altBrush, New Rectangle(marginL, y, pageW - marginL, rowH))
            End If

            Dim hargaStr As String = "Rp " & FormatNumber(Convert.ToInt64(If(dr(4) Is DBNull.Value, 0, dr(4))), 0)

            g.DrawString(rowNum.ToString(), fontNormal, brush, colX(0), y + 1)
            g.DrawString(dr(1).ToString(), fontNormal, brush, colX(1), y + 1)
            g.DrawString(TruncStr(dr(2).ToString(), 18), fontNormal, brush, colX(2), y + 1)
            g.DrawString(TruncStr(dr(3).ToString(), 17), fontNormal, brush, colX(3), y + 1)
            g.DrawString(hargaStr, fontNormal, brush, colX(4), y + 1)
            g.DrawString(TruncStr(dr(5).ToString(), 14), fontNormal, brush, colX(5), y + 1)
            g.DrawString(dr(6).ToString(), fontNormal, brush, colX(6), y + 1)

            y += rowH
            printRowIndex += 1
            rowNum += 1
        Loop

        ' Garis bawah & footer
        y += 6
        g.DrawString(New String("="c, 95), fontKecil, brush, marginL, y)
        y += 12
        g.DrawString("Total data: " & allData.Rows.Count.ToString() & " antrian",
                     fontKecil, brush, marginL, y)
        y += 12
        g.DrawString("Terima kasih telah menggunakan layanan BARBERSHOP.",
                     fontKecil, brush,
                     New RectangleF(marginL, y, pageW, 16),
                     New StringFormat() With {.Alignment = StringAlignment.Center})

        e.HasMorePages = False
        printRowIndex = 0   ' reset untuk percetakan berikutnya

CleanUp:
        altBrush.Dispose()
        fontJudul.Dispose()
        fontHeader.Dispose()
        fontNormal.Dispose()
        fontKecil.Dispose()
        brush.Dispose()
        brushHeader.Dispose()
    End Sub

    ' Helper potong teks agar tidak overflow kolom
    Private Function TruncStr(s As String, maxLen As Integer) As String
        If s.Length > maxLen Then Return s.Substring(0, maxLen - 1) & "…"
        Return s
    End Function

    ' ---- KEMBALI ----
    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Me.Close()
    End Sub

    Private Sub FormAdmin_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        FormMenuAwal.Show()
    End Sub

End Class
