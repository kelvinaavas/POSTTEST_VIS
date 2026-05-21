Public Class FormMenuAwal

    Private Sub btnBooking_Click(sender As Object, e As EventArgs) Handles btnBooking.Click
        Dim f As New FormBooking()
        f.Show()
        Me.Hide()
    End Sub

    Private Sub btnAntrian_Click(sender As Object, e As EventArgs) Handles btnAntrian.Click
        Dim f As New FormAntrian()
        f.Show()
        Me.Hide()
    End Sub

    Private Sub btnAdmin_Click(sender As Object, e As EventArgs) Handles btnAdmin.Click
        Dim f As New FormAdmin()
        f.Show()
    End Sub

    Private Sub FormMenuAwal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
