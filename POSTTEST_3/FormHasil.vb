Public Class FormHasil

    Private Sub FormHasil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Tidak diperlukan logic tambahan, data sudah di-set dari FormCetak
    End Sub

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Me.Close()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Try
            Dim saveDialog As New SaveFileDialog()
            saveDialog.Filter   = "PNG Image|*.png"
            saveDialog.FileName = "KartuKomunitas_" & lblNamaVal.Text.Replace(" ", "_")

            If saveDialog.ShowDialog() = DialogResult.OK Then
                ' Capture panel kartu sebagai gambar
                Dim bmp As New System.Drawing.Bitmap(panelKartu.Width, panelKartu.Height)
                panelKartu.DrawToBitmap(bmp, New System.Drawing.Rectangle(0, 0, panelKartu.Width, panelKartu.Height))
                bmp.Save(saveDialog.FileName, System.Drawing.Imaging.ImageFormat.Png)
                MessageBox.Show("Kartu berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Gagal menyimpan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class
