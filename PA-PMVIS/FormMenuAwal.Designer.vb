<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMenuAwal
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblJudul = New Label()
        lblSub = New Label()
        btnBooking = New Button()
        btnAntrian = New Button()
        btnAdmin = New Button()
        SuspendLayout()
        ' 
        ' lblJudul
        ' 
        lblJudul.AutoSize = True
        lblJudul.Font = New Font("Segoe UI", 18.0F, FontStyle.Bold)
        lblJudul.ForeColor = Color.DarkSlateBlue
        lblJudul.Location = New Point(86, 67)
        lblJudul.Margin = New Padding(4, 0, 4, 0)
        lblJudul.Name = "lblJudul"
        lblJudul.Size = New Size(283, 48)
        lblJudul.TabIndex = 0
        lblJudul.Text = "✂  Barbershop"
        ' 
        ' lblSub
        ' 
        lblSub.AutoSize = True
        lblSub.Font = New Font("Segoe UI", 10.0F)
        lblSub.ForeColor = Color.Gray
        lblSub.Location = New Point(86, 137)
        lblSub.Margin = New Padding(4, 0, 4, 0)
        lblSub.Name = "lblSub"
        lblSub.Size = New Size(121, 28)
        lblSub.TabIndex = 1
        lblSub.Text = "Pilih layanan"
        ' 
        ' btnBooking
        ' 
        btnBooking.BackColor = Color.AliceBlue
        btnBooking.FlatAppearance.BorderColor = Color.SteelBlue
        btnBooking.FlatStyle = FlatStyle.Flat
        btnBooking.Font = New Font("Segoe UI", 11.0F)
        btnBooking.ForeColor = Color.DarkSlateBlue
        btnBooking.Location = New Point(86, 217)
        btnBooking.Margin = New Padding(4, 5, 4, 5)
        btnBooking.Name = "btnBooking"
        btnBooking.Size = New Size(371, 70)
        btnBooking.TabIndex = 0
        btnBooking.Text = "📅  Booking"
        btnBooking.UseVisualStyleBackColor = False
        ' 
        ' btnAntrian
        ' 
        btnAntrian.BackColor = Color.WhiteSmoke
        btnAntrian.FlatAppearance.BorderColor = Color.LightSlateGray
        btnAntrian.FlatStyle = FlatStyle.Flat
        btnAntrian.Font = New Font("Segoe UI", 11.0F)
        btnAntrian.ForeColor = Color.DarkSlateGray
        btnAntrian.Location = New Point(86, 308)
        btnAntrian.Margin = New Padding(4, 5, 4, 5)
        btnAntrian.Name = "btnAntrian"
        btnAntrian.Size = New Size(371, 70)
        btnAntrian.TabIndex = 1
        btnAntrian.Text = "📋  Lihat Antrian"
        btnAntrian.UseVisualStyleBackColor = False
        ' 
        ' btnAdmin
        ' 
        btnAdmin.BackColor = Color.WhiteSmoke
        btnAdmin.FlatAppearance.BorderColor = Color.LightSlateGray
        btnAdmin.FlatStyle = FlatStyle.Flat
        btnAdmin.Font = New Font("Segoe UI", 11.0F)
        btnAdmin.ForeColor = Color.DarkSlateGray
        btnAdmin.Location = New Point(86, 400)
        btnAdmin.Margin = New Padding(4, 5, 4, 5)
        btnAdmin.Name = "btnAdmin"
        btnAdmin.Size = New Size(371, 70)
        btnAdmin.TabIndex = 2
        btnAdmin.Text = "🔒  Admin"
        btnAdmin.UseVisualStyleBackColor = False
        ' 
        ' FormMenuAwal
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(543, 533)
        Controls.Add(lblJudul)
        Controls.Add(lblSub)
        Controls.Add(btnBooking)
        Controls.Add(btnAntrian)
        Controls.Add(btnAdmin)
        Margin = New Padding(4, 5, 4, 5)
        Name = "FormMenuAwal"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Barbershop — Menu Awal"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblJudul As Label
    Friend WithEvents lblSub As Label
    Friend WithEvents btnBooking As Button
    Friend WithEvents btnAntrian As Button
    Friend WithEvents btnAdmin As Button

End Class
