Public Class FormCetak

    ' =============================================
    '  BROWSE FOTO
    ' =============================================
    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim openFile As New OpenFileDialog
        openFile.Filter = "Image Files|*.jpg;*.png;*.jpeg"

        If openFile.ShowDialog() = DialogResult.OK Then
            picFoto.Image = Image.FromFile(openFile.FileName)
            picFoto.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub

    ' =============================================
    '  VALIDASI HANYA HURUF (Nama)
    ' =============================================
    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
            ToolTip1.Show("Hanya boleh huruf!", txtNama, 0, -20, 1500)
        End If
    End Sub

    ' =============================================
    '  VALIDASI HANYA ANGKA (Umur)
    ' =============================================
    Private Sub txtUmur_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUmur.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
            ToolTip1.Show("Hanya boleh angka!", txtUmur, 0, -20, 1500)
        End If
    End Sub

    ' =============================================
    '  VALIDASI HANYA ANGKA (Telepon)
    ' =============================================
    Private Sub txtTelepon_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelepon.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
            ToolTip1.Show("Hanya boleh angka!", txtTelepon, 0, -20, 1500)
        End If
    End Sub

    ' =============================================
    '  AMBIL SEMUA HOBBY YANG DICENTANG
    ' =============================================
    Function AmbilHobby() As String
        Dim hobby As String = ""

        For Each ctrl As Control In GroupBoxHobby.Controls
            If TypeOf ctrl Is CheckBox Then
                Dim cb As CheckBox = CType(ctrl, CheckBox)
                If cb.Checked Then
                    hobby &= cb.Text & ", "
                End If
            End If
        Next

        If hobby.Length > 2 Then
            hobby = hobby.Substring(0, hobby.Length - 2) ' buang koma terakhir
        End If

        Return hobby
    End Function

    ' =============================================
    '  AMBIL JENIS KELAMIN
    ' =============================================
    Function AmbilJenisKelamin() As String
        If rbLaki.Checked Then Return "Laki-Laki"
        If rbPerempuan.Checked Then Return "Perempuan"
        Return ""
    End Function

    ' =============================================
    '  TOMBOL CETAK KARTU
    ' =============================================
    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click

        ' Validasi TextBox
        If txtNama.Text.Trim() = "" Then
            MessageBox.Show("Inputan tidak boleh kosong: Nama belum diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNama.Focus()
            Exit Sub
        End If

        If txtUmur.Text.Trim() = "" Then
            MessageBox.Show("Inputan tidak boleh kosong: Umur belum diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtUmur.Focus()
            Exit Sub
        End If

        If txtTelepon.Text.Trim() = "" Then
            MessageBox.Show("Inputan tidak boleh kosong: Nomor Telepon belum diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtTelepon.Focus()
            Exit Sub
        End If

        If txtAlamat.Text.Trim() = "" Then
            MessageBox.Show("Inputan tidak boleh kosong: Alamat belum diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtAlamat.Focus()
            Exit Sub
        End If

        ' Validasi Jenis Kelamin
        If Not rbLaki.Checked AndAlso Not rbPerempuan.Checked Then
            MessageBox.Show("Inputan tidak boleh kosong: Pilih jenis kelamin!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Validasi Hobby
        If AmbilHobby() = "" Then
            MessageBox.Show("Inputan tidak boleh kosong: Pilih minimal satu hobby!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Validasi Foto
        If picFoto.Image Is Nothing Then
            MessageBox.Show("Inputan tidak boleh kosong: Foto profil belum dipilih!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Buka FormHasil dan kirim data
        Dim frmHasil As New FormHasil

        frmHasil.lblNamaVal.Text = txtNama.Text
        frmHasil.lblUmurVal.Text = txtUmur.Text & " Tahun"
        frmHasil.lblTeleponVal.Text = txtTelepon.Text
        frmHasil.lblTanggalVal.Text = dtTanggal.Value.ToString("dd MMMM yyyy")
        frmHasil.lblHobbyVal.Text = AmbilHobby()
        frmHasil.lblAlamatVal.Text = txtAlamat.Text
        frmHasil.lblJKVal.Text = AmbilJenisKelamin()
        frmHasil.picHasil.Image = picFoto.Image
        frmHasil.picHasil.SizeMode = PictureBoxSizeMode.StretchImage

        frmHasil.Show()

    End Sub

    ' =============================================
    '  TOMBOL RESET / BERSIHKAN FORM
    ' =============================================
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtNama.Clear()
        txtUmur.Clear()
        txtTelepon.Clear()
        txtAlamat.Clear()
        rbLaki.Checked = False
        rbPerempuan.Checked = False
        dtTanggal.Value = Now
        picFoto.Image = Nothing

        For Each ctrl As Control In GroupBoxHobby.Controls
            If TypeOf ctrl Is CheckBox Then
                CType(ctrl, CheckBox).Checked = False
            End If
        Next
    End Sub

End Class
