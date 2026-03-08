Public Class Form1

    Sub TampilData()

        lstBuku.Items.Clear()

        Dim i As Integer
        For i = 0 To jumlahBuku - 1
            lstBuku.Items.Add(daftarBuku(i))
        Next

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        daftarBuku(0) = "Harry Potter (Fantasi)"
        daftarBuku(1) = "Sherlock Holmes (Misteri)"
        jumlahBuku = 2

        TampilData()

    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click

        Dim judul As String
        Dim genre As String

        judul = txtJudul.Text
        genre = txtGenre.Text

        TambahBuku(judul, genre)

        txtJudul.Text = ""
        txtGenre.Text = ""

        TampilData()

    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click

        Dim judul As String

        judul = txtHapus.Text

        HapusBuku(judul)

        txtHapus.Text = ""

        TampilData()

    End Sub

End Class