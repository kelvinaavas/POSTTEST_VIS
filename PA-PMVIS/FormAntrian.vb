Public Class FormAntrian

    Private Sub FormAntrian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilData()
    End Sub

    Private Sub TampilData()
        dgvAntrian.DataSource = DataModule.GetAllAntrian()
        ' Kolom: 0=idAntrian, 1=nomorAntrian, 2=namaCustomer,
        '        3=namaPelayanan, 4=harga, 5=namaBarber, 6=status
        If dgvAntrian.Columns.Count >= 7 Then
            dgvAntrian.Columns(0).Visible = False
            dgvAntrian.Columns(1).HeaderText = "Nomor"
            dgvAntrian.Columns(1).Width = 70
            dgvAntrian.Columns(2).HeaderText = "Nama"
            dgvAntrian.Columns(3).HeaderText = "Pelayanan"
            dgvAntrian.Columns(4).HeaderText = "Harga (Rp)"
            dgvAntrian.Columns(4).Width = 110
            dgvAntrian.Columns(4).DefaultCellStyle.Format = "N0"
            dgvAntrian.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvAntrian.Columns(5).HeaderText = "Barber"
            dgvAntrian.Columns(6).HeaderText = "Status"
            dgvAntrian.Columns(6).Width = 90
        End If
    End Sub

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Me.Close()
    End Sub

    Private Sub FormAntrian_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        FormMenuAwal.Show()
    End Sub

End Class
