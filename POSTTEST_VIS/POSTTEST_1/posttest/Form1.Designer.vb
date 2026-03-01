<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        txtIP = New TextBox()
        btnTambah = New Button()
        Label2 = New Label()
        txtIPK = New TextBox()
        lblPredikat = New Label()
        btnReset = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(239, 288)
        Label1.Name = "Label1"
        Label1.Size = New Size(167, 32)
        Label1.TabIndex = 0
        Label1.Text = "IP SEMESTER"
        ' 
        ' txtIP
        ' 
        txtIP.Location = New Point(431, 288)
        txtIP.Name = "txtIP"
        txtIP.Size = New Size(200, 39)
        txtIP.TabIndex = 1
        ' 
        ' btnTambah
        ' 
        btnTambah.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        btnTambah.Cursor = Cursors.IBeam
        btnTambah.Font = New Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnTambah.ForeColor = Color.Green
        btnTambah.Location = New Point(240, 352)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(150, 46)
        btnTambah.TabIndex = 2
        btnTambah.Text = "TAMBAH"
        btnTambah.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(239, 436)
        Label2.Name = "Label2"
        Label2.Size = New Size(189, 32)
        Label2.TabIndex = 3
        Label2.Text = "IP KUMULATIF"
        ' 
        ' txtIPK
        ' 
        txtIPK.Enabled = False
        txtIPK.Location = New Point(431, 436)
        txtIPK.Name = "txtIPK"
        txtIPK.Size = New Size(200, 39)
        txtIPK.TabIndex = 4
        ' 
        ' lblPredikat
        ' 
        lblPredikat.AutoSize = True
        lblPredikat.Location = New Point(239, 516)
        lblPredikat.Name = "lblPredikat"
        lblPredikat.Size = New Size(0, 32)
        lblPredikat.TabIndex = 5
        ' 
        ' btnReset
        ' 
        btnReset.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        btnReset.FlatStyle = FlatStyle.Popup
        btnReset.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnReset.ForeColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        btnReset.Location = New Point(396, 352)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(150, 46)
        btnReset.TabIndex = 6
        btnReset.Text = "RESET"
        btnReset.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1612, 996)
        Controls.Add(btnReset)
        Controls.Add(lblPredikat)
        Controls.Add(txtIPK)
        Controls.Add(Label2)
        Controls.Add(btnTambah)
        Controls.Add(txtIP)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "KALKULATOR IP"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtIP As TextBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtIPK As TextBox
    Friend WithEvents lblPredikat As Label
    Friend WithEvents btnReset As Button

End Class
