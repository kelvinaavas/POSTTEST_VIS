Public Class Form1

    Dim dt As New DataTable
    Dim index As Integer = -1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dt.Columns.Add("Nama")
        dt.Columns.Add("Jenis")
        dt.Columns.Add("Harga")

        Pembukuan.DataSource = dt
    End Sub

    Sub ClearForm()
        NamaPelanggan.Clear()
        JenisPemotongan.Clear()
        Harga.Clear()
        Search.Clear()
        index = -1
    End Sub

    ' SIMPAN
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If NamaPelanggan.Text = "" Or JenisPemotongan.Text = "" Or Harga.Text = "" Then
            MessageBox.Show("Data belum lengkap")
            Exit Sub
        End If

        dt.Rows.Add(NamaPelanggan.Text, JenisPemotongan.Text, Harga.Text)
        ClearForm()
    End Sub

    ' KLIK DATA GRID
    Private Sub Pembukuan_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Pembukuan.CellClick
        If e.RowIndex >= 0 Then
            index = e.RowIndex
            NamaPelanggan.Text = dt.Rows(index)(0).ToString()
            JenisPemotongan.Text = dt.Rows(index)(1).ToString()
            Harga.Text = dt.Rows(index)(2).ToString()
        End If
    End Sub

    ' UBAH
    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        If index >= 0 Then
            dt.Rows(index)(0) = NamaPelanggan.Text
            dt.Rows(index)(1) = JenisPemotongan.Text
            dt.Rows(index)(2) = Harga.Text
            ClearForm()
        Else
            MessageBox.Show("Pilih data dulu")
        End If
    End Sub

    ' HAPUS
    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If index >= 0 Then
            dt.Rows.RemoveAt(index)
            ClearForm()
        Else
            MessageBox.Show("Pilih data dulu")
        End If
    End Sub

    ' BATAL
    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        ClearForm()
    End Sub

    ' SEARCH
    Private Sub Search_TextChanged(sender As Object, e As EventArgs) Handles Search.TextChanged
        Dim dv As New DataView(dt)
        dv.RowFilter = "Nama LIKE '%" & Search.Text & "%'"
        Pembukuan.DataSource = dv
    End Sub

End Class