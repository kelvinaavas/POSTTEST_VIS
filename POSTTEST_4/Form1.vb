
Imports System.IO

Public Class Form1

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim openFoto As New OpenFileDialog
        openFoto.Filter = "Image Files|*.jpg;*.png;*.jpeg"

        If openFoto.ShowDialog = DialogResult.OK Then
            picFoto.Image = Image.FromFile(openFoto.FileName)
        End If
    End Sub

    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub mskTelepon_KeyPress(sender As Object, e As KeyPressEventArgs) Handles mskTelepon.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click

        If txtNama.Text = "" Or txtID.Text = "" Then
            MessageBox.Show("Inputan tidak boleh kosong")
            Exit Sub
        End If

        Dim hobby As String = ""

        If cbNgoding.Checked Then hobby &= "Ngoding "
        If cbDesign.Checked Then hobby &= "Design "
        If cbGaming.Checked Then hobby &= "Gaming "
        If cbFotografi.Checked Then hobby &= "Fotografi "
        If cbMusic.Checked Then hobby &= "Music "
        If cbOlahraga.Checked Then hobby &= "Olahraga "
        If cbMenulis.Checked Then hobby &= "Menulis "
        If cbPublicSpeaking.Checked Then hobby &= "Public Speaking "

        Form2.lblNama.Text = txtNama.Text
        Form2.lblID.Text = txtID.Text
        Form2.lblKomunitas.Text = cmbKomunitas.Text
        Form2.lblKontak.Text = mskTelepon.Text
        Form2.lblHobby.Text = hobby
        Form2.picFoto.Image = picFoto.Image

        Form2.Show()

    End Sub

End Class
