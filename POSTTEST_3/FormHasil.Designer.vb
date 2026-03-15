<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormHasil
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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

        ' Komponen
        Me.panelBg       = New System.Windows.Forms.Panel()
        Me.panelKartu    = New System.Windows.Forms.Panel()
        Me.panelKartuTop = New System.Windows.Forms.Panel()
        Me.lblKartuTitle = New System.Windows.Forms.Label()
        Me.lblKartuSub   = New System.Windows.Forms.Label()
        Me.panelKartuBody= New System.Windows.Forms.Panel()
        Me.picHasil      = New System.Windows.Forms.PictureBox()
        Me.panelData     = New System.Windows.Forms.Panel()

        ' Label nama (judul)
        Me.lblNamaTitle   = New System.Windows.Forms.Label()
        Me.lblNamaVal     = New System.Windows.Forms.Label()

        ' Label Umur
        Me.lblUmurTitle   = New System.Windows.Forms.Label()
        Me.lblUmurVal     = New System.Windows.Forms.Label()

        ' Label JK
        Me.lblJKTitle     = New System.Windows.Forms.Label()
        Me.lblJKVal       = New System.Windows.Forms.Label()

        ' Label Telepon
        Me.lblTeleponTitle = New System.Windows.Forms.Label()
        Me.lblTeleponVal  = New System.Windows.Forms.Label()

        ' Label Tanggal
        Me.lblTanggalTitle = New System.Windows.Forms.Label()
        Me.lblTanggalVal  = New System.Windows.Forms.Label()

        ' Label Hobby
        Me.lblHobbyTitle  = New System.Windows.Forms.Label()
        Me.lblHobbyVal    = New System.Windows.Forms.Label()

        ' Label Alamat
        Me.lblAlamatTitle = New System.Windows.Forms.Label()
        Me.lblAlamatVal   = New System.Windows.Forms.Label()

        ' Divider
        Me.lblDivider     = New System.Windows.Forms.Label()

        ' Tombol
        Me.panelBtn       = New System.Windows.Forms.Panel()
        Me.btnKembali     = New System.Windows.Forms.Button()
        Me.btnSimpan      = New System.Windows.Forms.Button()

        ' =========================================================
        '  FORM SETTINGS
        ' =========================================================
        Me.Text            = "Hasil Kartu Komunitas"
        Me.Size            = New System.Drawing.Size(700, 640)
        Me.StartPosition   = FormStartPosition.CenterScreen
        Me.BackColor       = System.Drawing.Color.FromArgb(230, 236, 255)
        Me.Font            = New System.Drawing.Font("Segoe UI", 9)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox     = False

        ' =========================================================
        '  PANEL BG
        ' =========================================================
        Me.panelBg.Dock      = DockStyle.Fill
        Me.panelBg.BackColor = System.Drawing.Color.FromArgb(230, 236, 255)
        Me.panelBg.Padding   = New System.Windows.Forms.Padding(30)

        ' =========================================================
        '  PANEL KARTU (Card UI)
        ' =========================================================
        Me.panelKartu.Location  = New System.Drawing.Point(30, 20)
        Me.panelKartu.Size      = New System.Drawing.Size(624, 510)
        Me.panelKartu.BackColor = System.Drawing.Color.White
        Me.panelKartu.BorderStyle = BorderStyle.None

        ' Top strip kartu
        Me.panelKartuTop.Dock      = DockStyle.Top
        Me.panelKartuTop.Height    = 90
        Me.panelKartuTop.BackColor = System.Drawing.Color.FromArgb(41, 98, 255)

        Me.lblKartuTitle.Text      = "🏆  KARTU ANGGOTA KOMUNITAS"
        Me.lblKartuTitle.Font      = New System.Drawing.Font("Segoe UI", 15, System.Drawing.FontStyle.Bold)
        Me.lblKartuTitle.ForeColor = System.Drawing.Color.White
        Me.lblKartuTitle.AutoSize  = True
        Me.lblKartuTitle.Location  = New System.Drawing.Point(15, 12)

        Me.lblKartuSub.Text      = "Member Card  •  Official"
        Me.lblKartuSub.Font      = New System.Drawing.Font("Segoe UI", 9)
        Me.lblKartuSub.ForeColor = System.Drawing.Color.FromArgb(180, 210, 255)
        Me.lblKartuSub.AutoSize  = True
        Me.lblKartuSub.Location  = New System.Drawing.Point(17, 52)

        Me.panelKartuTop.Controls.Add(Me.lblKartuTitle)
        Me.panelKartuTop.Controls.Add(Me.lblKartuSub)

        ' Body kartu
        Me.panelKartuBody.Location  = New System.Drawing.Point(0, 90)
        Me.panelKartuBody.Size      = New System.Drawing.Size(624, 420)
        Me.panelKartuBody.BackColor = System.Drawing.Color.White

        ' Foto
        Me.picHasil.Location    = New System.Drawing.Point(20, 20)
        Me.picHasil.Size        = New System.Drawing.Size(150, 170)
        Me.picHasil.SizeMode    = PictureBoxSizeMode.StretchImage
        Me.picHasil.BorderStyle = BorderStyle.FixedSingle
        Me.picHasil.BackColor   = System.Drawing.Color.FromArgb(210, 220, 255)

        ' Panel data (sebelah foto)
        Me.panelData.Location  = New System.Drawing.Point(185, 15)
        Me.panelData.Size      = New System.Drawing.Size(425, 390)
        Me.panelData.BackColor = System.Drawing.Color.Transparent

        ' --- Helper setup label ---
        Dim titleColor As System.Drawing.Color = System.Drawing.Color.FromArgb(130, 140, 170)
        Dim valueColor As System.Drawing.Color = System.Drawing.Color.FromArgb(30, 40, 80)

        Dim rows() As String = {"NAMA LENGKAP", "UMUR", "JENIS KELAMIN", "NO. TELEPON", "TANGGAL LAHIR", "HOBBY", "ALAMAT"}
        Dim titles() As Label = {lblNamaTitle, lblUmurTitle, lblJKTitle, lblTeleponTitle, lblTanggalTitle, lblHobbyTitle, lblAlamatTitle}
        Dim vals() As Label   = {lblNamaVal, lblUmurVal, lblJKVal, lblTeleponVal, lblTanggalVal, lblHobbyVal, lblAlamatVal}

        Dim y As Integer = 5
        For i As Integer = 0 To rows.Length - 1
            titles(i).Text      = rows(i)
            titles(i).Location  = New System.Drawing.Point(5, y)
            titles(i).AutoSize  = True
            titles(i).Font      = New System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold)
            titles(i).ForeColor = titleColor
            y += 18

            vals(i).Text      = "-"
            vals(i).Location  = New System.Drawing.Point(5, y)
            vals(i).AutoSize  = False
            vals(i).Size      = New System.Drawing.Size(415, If(i = 5 OrElse i = 6, 36, 22))
            vals(i).Font      = New System.Drawing.Font("Segoe UI", If(i = 0, 13.0F, 10.5F), If(i = 0, System.Drawing.FontStyle.Bold, System.Drawing.FontStyle.Regular))
            vals(i).ForeColor = valueColor
            y += If(i = 5 OrElse i = 6, 44, 26)
        Next

        ' Divider tipis
        Me.lblDivider.Text      = ""
        Me.lblDivider.Location  = New System.Drawing.Point(5, 200)
        Me.lblDivider.Size      = New System.Drawing.Size(415, 1)
        Me.lblDivider.BackColor = System.Drawing.Color.FromArgb(210, 218, 240)

        Me.panelData.Controls.Add(Me.lblDivider)
        For i As Integer = 0 To titles.Length - 1
            Me.panelData.Controls.Add(titles(i))
            Me.panelData.Controls.Add(vals(i))
        Next

        Me.panelKartuBody.Controls.Add(Me.picHasil)
        Me.panelKartuBody.Controls.Add(Me.panelData)

        Me.panelKartu.Controls.Add(Me.panelKartuTop)
        Me.panelKartu.Controls.Add(Me.panelKartuBody)

        ' =========================================================
        '  PANEL TOMBOL
        ' =========================================================
        Me.panelBtn.Location  = New System.Drawing.Point(30, 540)
        Me.panelBtn.Size      = New System.Drawing.Size(624, 55)
        Me.panelBtn.BackColor = System.Drawing.Color.Transparent

        Me.btnSimpan.Text      = "💾  Simpan Kartu"
        Me.btnSimpan.Size      = New System.Drawing.Size(180, 44)
        Me.btnSimpan.Location  = New System.Drawing.Point(435, 5)
        Me.btnSimpan.FlatStyle = FlatStyle.Flat
        Me.btnSimpan.BackColor = System.Drawing.Color.FromArgb(25, 135, 84)
        Me.btnSimpan.ForeColor = System.Drawing.Color.White
        Me.btnSimpan.Font      = New System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold)
        Me.btnSimpan.FlatAppearance.BorderSize = 0
        Me.btnSimpan.Cursor    = Cursors.Hand

        Me.btnKembali.Text      = "← Kembali"
        Me.btnKembali.Size      = New System.Drawing.Size(140, 44)
        Me.btnKembali.Location  = New System.Drawing.Point(5, 5)
        Me.btnKembali.FlatStyle = FlatStyle.Flat
        Me.btnKembali.BackColor = System.Drawing.Color.FromArgb(108, 117, 125)
        Me.btnKembali.ForeColor = System.Drawing.Color.White
        Me.btnKembali.Font      = New System.Drawing.Font("Segoe UI", 10)
        Me.btnKembali.FlatAppearance.BorderSize = 0
        Me.btnKembali.Cursor    = Cursors.Hand

        Me.panelBtn.Controls.Add(Me.btnSimpan)
        Me.panelBtn.Controls.Add(Me.btnKembali)

        ' =========================================================
        '  TAMBAHKAN KE FORM
        ' =========================================================
        Me.Controls.Add(Me.panelKartu)
        Me.Controls.Add(Me.panelBtn)

    End Sub

    ' Deklarasi
    Friend WithEvents panelBg        As System.Windows.Forms.Panel
    Friend WithEvents panelKartu     As System.Windows.Forms.Panel
    Friend WithEvents panelKartuTop  As System.Windows.Forms.Panel
    Friend WithEvents lblKartuTitle  As System.Windows.Forms.Label
    Friend WithEvents lblKartuSub    As System.Windows.Forms.Label
    Friend WithEvents panelKartuBody As System.Windows.Forms.Panel
    Friend WithEvents picHasil       As System.Windows.Forms.PictureBox
    Friend WithEvents panelData      As System.Windows.Forms.Panel
    Friend WithEvents lblNamaTitle   As System.Windows.Forms.Label
    Friend WithEvents lblNamaVal     As System.Windows.Forms.Label
    Friend WithEvents lblUmurTitle   As System.Windows.Forms.Label
    Friend WithEvents lblUmurVal     As System.Windows.Forms.Label
    Friend WithEvents lblJKTitle     As System.Windows.Forms.Label
    Friend WithEvents lblJKVal       As System.Windows.Forms.Label
    Friend WithEvents lblTeleponTitle As System.Windows.Forms.Label
    Friend WithEvents lblTeleponVal  As System.Windows.Forms.Label
    Friend WithEvents lblTanggalTitle As System.Windows.Forms.Label
    Friend WithEvents lblTanggalVal  As System.Windows.Forms.Label
    Friend WithEvents lblHobbyTitle  As System.Windows.Forms.Label
    Friend WithEvents lblHobbyVal    As System.Windows.Forms.Label
    Friend WithEvents lblAlamatTitle As System.Windows.Forms.Label
    Friend WithEvents lblAlamatVal   As System.Windows.Forms.Label
    Friend WithEvents lblDivider     As System.Windows.Forms.Label
    Friend WithEvents panelBtn       As System.Windows.Forms.Panel
    Friend WithEvents btnKembali     As System.Windows.Forms.Button
    Friend WithEvents btnSimpan      As System.Windows.Forms.Button

End Class
