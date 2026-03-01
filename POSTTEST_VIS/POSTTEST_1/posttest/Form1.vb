Public Class Form1
    Dim totalIP As Double = 0
    Dim jumlahSemester As Integer = 0
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Dim ipSemester As Double
        If Double.TryParse(txtIP.Text, ipSemester) Then
            totalIP += ipSemester
            jumlahSemester += 1

            Dim ipk As Double = totalIP / jumlahSemester
            txtIPK.Text = ipk.ToString("0.00")

            If ipk >= 3.01 Then
                lblPredikat.Text = "Sangat Memuaskan"
            ElseIf ipk >= 2.76 Then
                lblPredikat.Text = "Memuaskan"
            ElseIf ipk >= 2.0 Then
                lblPredikat.Text = "Cukup"
            End If

            txtIP.Text = ""
            txtIP.Focus()
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        totalIP = 0
        jumlahSemester = 0
        txtIP.Text = ""
        txtIPK.Text = ""
        lblPredikat.Text = ""
    End Sub


End Class
