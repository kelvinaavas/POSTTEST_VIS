Module ValidationModule

    Public Function ValidasiTextBox(ep As ErrorProvider, txt As TextBox, pesan As String) As Boolean
        If txt.Text.Trim() = "" Then
            ep.SetError(txt, pesan)
            Return False
        Else
            ep.SetError(txt, "")
            Return True
        End If
    End Function

    Public Function ValidasiComboBox(ep As ErrorProvider, cb As ComboBox, pesan As String) As Boolean
        If cb.SelectedIndex = -1 OrElse cb.Text.Trim() = "" Then
            ep.SetError(cb, pesan)
            Return False
        Else
            ep.SetError(cb, "")
            Return True
        End If
    End Function

    Public Function ValidasiDataPelanggan(ep As ErrorProvider,
                                          txtKode As TextBox,
                                          txtNama As TextBox,
                                          txtTelepon As TextBox) As Boolean
        Dim kodeValid As Boolean = ValidasiTextBox(ep, txtKode, "Kode Pelanggan wajib diisi!")
        Dim namaValid As Boolean = ValidasiTextBox(ep, txtNama, "Nama Pelanggan wajib diisi!")
        Dim teleponValid As Boolean = ValidasiTextBox(ep, txtTelepon, "No. Telepon wajib diisi!")
        Return kodeValid And namaValid And teleponValid
    End Function

    Public Function ValidasiDataPelayanan(ep As ErrorProvider,
                                          txtKode As TextBox,
                                          cbPelanggan As ComboBox,
                                          cbJenis As ComboBox,
                                          txtHarga As TextBox) As Boolean
        Dim kodeValid As Boolean = ValidasiTextBox(ep, txtKode, "Kode Pelayanan wajib diisi!")
        Dim pelangganValid As Boolean = ValidasiComboBox(ep, cbPelanggan, "Silakan pilih Pelanggan!")
        Dim jenisValid As Boolean = ValidasiComboBox(ep, cbJenis, "Silakan pilih Jenis Pemotongan!")
        Dim hargaValid As Boolean = ValidasiTextBox(ep, txtHarga, "Harga wajib diisi!")
        Return kodeValid And pelangganValid And jenisValid And hargaValid
    End Function

    Public Sub HanyaAngka(e As KeyPressEventArgs)
        If Not (Char.IsDigit(e.KeyChar) OrElse e.KeyChar = ControlChars.Back) Then
            e.Handled = True
        End If
    End Sub

    Public Function IsEnterKey(e As KeyPressEventArgs) As Boolean
        Return e.KeyChar = ControlChars.Cr
    End Function

End Module
