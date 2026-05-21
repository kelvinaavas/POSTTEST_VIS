<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormAntrian
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then components.Dispose()
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        lblJudul = New Label()
        dgvAntrian = New DataGridView()
        btnKembali = New Button()
        CType(dgvAntrian, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()

        ' lblJudul
        lblJudul.AutoSize = True
        lblJudul.Font = New Font("Segoe UI", 13, FontStyle.Bold)
        lblJudul.ForeColor = Color.DarkSlateBlue
        lblJudul.Location = New Point(15, 15)
        lblJudul.Name = "lblJudul"
        lblJudul.Text = "Lihat Antrian"

        ' dgvAntrian
        dgvAntrian.AllowUserToAddRows = False
        dgvAntrian.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvAntrian.BackgroundColor = Color.White
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.DarkSlateBlue
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = Color.White
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvAntrian.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvAntrian.ColumnHeadersHeight = 34
        dgvAntrian.Location = New Point(15, 55)
        dgvAntrian.Name = "dgvAntrian"
        dgvAntrian.ReadOnly = True
        dgvAntrian.RowHeadersWidth = 30
        dgvAntrian.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvAntrian.Size = New Size(860, 340)
        dgvAntrian.TabIndex = 0

        ' btnKembali
        btnKembali.BackColor = Color.LightGray
        btnKembali.FlatStyle = FlatStyle.Flat
        btnKembali.FlatAppearance.BorderSize = 0
        btnKembali.ForeColor = Color.DimGray
        btnKembali.Font = New Font("Segoe UI", 10)
        btnKembali.Location = New Point(15, 415)
        btnKembali.Name = "btnKembali"
        btnKembali.Size = New Size(120, 36)
        btnKembali.TabIndex = 1
        btnKembali.Text = "Kembali"

        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(896, 470)
        Controls.Add(lblJudul)
        Controls.Add(dgvAntrian)
        Controls.Add(btnKembali)
        Name = "FormAntrian"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Barbershop — Lihat Antrian"
        CType(dgvAntrian, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblJudul As Label
    Friend WithEvents dgvAntrian As DataGridView
    Friend WithEvents btnKembali As Button

End Class
