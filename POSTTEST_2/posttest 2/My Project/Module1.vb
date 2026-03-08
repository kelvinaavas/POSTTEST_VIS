Module Module1

    Public daftarBuku(100) As String
    Public jumlahBuku As Integer = 0

    Function FormatBuku(ByVal judul As String, ByVal genre As String) As String
        Return judul & " (" & genre & ")"
    End Function

    Public Sub TambahBuku(ByVal judul As String, ByVal genre As String)

        daftarBuku(jumlahBuku) = FormatBuku(judul, genre)
        jumlahBuku = jumlahBuku + 1

    End Sub

    Public Sub HapusBuku(ByVal judul As String)

        Dim i As Integer

        For i = 0 To jumlahBuku - 1

            If daftarBuku(i).Contains(judul) Then

                Dim j As Integer

                For j = i To jumlahBuku - 2
                    daftarBuku(j) = daftarBuku(j + 1)
                Next

                jumlahBuku = jumlahBuku - 1
                Exit For

            End If

        Next

    End Sub

End Module