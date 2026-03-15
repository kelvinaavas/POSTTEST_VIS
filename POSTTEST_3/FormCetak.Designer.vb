<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormCetak
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
        Me.components = New System.ComponentModel.Container()

        ' =========================================================
        '  INISIALISASI SEMUA KOMPONEN
        ' =========================================================
        Me.panelHeader       = New System.Windows.Forms.Panel()
        Me.lblJudul          = New System.Windows.Forms.Label()
        Me.lblSubJudul       = New System.Windows.Forms.Label()
        Me.panelLeft         = New System.Windows.Forms.Panel()
        Me.panelFoto         = New System.Windows.Forms.Panel()
        Me.picFoto           = New System.Windows.Forms.PictureBox()
        Me.btnBrowse         = New System.Windows.Forms.Button()
        Me.GroupBoxJK        = New System.Windows.Forms.GroupBox()
        Me.rbLaki            = New System.Windows.Forms.RadioButton()
        Me.rbPerempuan       = New System.Windows.Forms.RadioButton()
        Me.GroupBoxHobby     = New System.Windows.Forms.GroupBox()
        Me.cbGaming          = New System.Windows.Forms.CheckBox()
        Me.cbFutsal          = New System.Windows.Forms.CheckBox()
        Me.cbBasket          = New System.Windows.Forms.CheckBox()
        Me.cbBadminton       = New System.Windows.Forms.CheckBox()
        Me.cbMancing         = New System.Windows.Forms.CheckBox()
        Me.cbTravel          = New System.Windows.Forms.CheckBox()
        Me.cbMusik           = New System.Windows.Forms.CheckBox()
        Me.cbCoding          = New System.Windows.Forms.CheckBox()
        Me.cbMembaca         = New System.Windows.Forms.CheckBox()
        Me.cbMemasak         = New System.Windows.Forms.CheckBox()
        Me.cbFotografi       = New System.Windows.Forms.CheckBox()
        Me.cbOlahraga        = New System.Windows.Forms.CheckBox()
        Me.panelRight        = New System.Windows.Forms.Panel()
        Me.lblNama           = New System.Windows.Forms.Label()
        Me.txtNama           = New System.Windows.Forms.TextBox()
        Me.lblUmur           = New System.Windows.Forms.Label()
        Me.txtUmur           = New System.Windows.Forms.TextBox()
        Me.lblTelepon        = New System.Windows.Forms.Label()
        Me.txtTelepon        = New System.Windows.Forms.TextBox()
        Me.lblTglLahir       = New System.Windows.Forms.Label()
        Me.dtTanggal         = New System.Windows.Forms.DateTimePicker()
        Me.lblAlamat         = New System.Windows.Forms.Label()
        Me.txtAlamat         = New System.Windows.Forms.TextBox()
        Me.panelBottom       = New System.Windows.Forms.Panel()
        Me.btnCetak          = New System.Windows.Forms.Button()
        Me.btnReset          = New System.Windows.Forms.Button()
        Me.ToolTip1          = New System.Windows.Forms.ToolTip(Me.components)

        ' =========================================================
        '  FORM
        ' =========================================================
        Me.Text            = "Form Input Kartu Komunitas"
        Me.Size            = New System.Drawing.Size(880, 700)
        Me.StartPosition   = FormStartPosition.CenterScreen
        Me.BackColor       = System.Drawing.Color.FromArgb(240, 244, 255)
        Me.Font            = New System.Drawing.Font("Segoe UI", 9)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox     = False

        ' =========================================================
        '  PANEL HEADER
        ' =========================================================
        Me.panelHeader.Dock      = DockStyle.Top
        Me.panelHeader.Height    = 80
        Me.panelHeader.BackColor = System.Drawing.Color.FromArgb(41, 98, 255)

        Me.lblJudul.Text      = "🏆  KARTU KOMUNITAS"
        Me.lblJudul.Font      = New System.Drawing.Font("Segoe UI", 18, System.Drawing.FontStyle.Bold)
        Me.lblJudul.ForeColor = System.Drawing.Color.White
        Me.lblJudul.AutoSize  = True
        Me.lblJudul.Location  = New System.Drawing.Point(20, 10)

        Me.lblSubJudul.Text      = "Isi data diri kamu untuk membuat kartu anggota komunitas"
        Me.lblSubJudul.Font      = New System.Drawing.Font("Segoe UI", 9)
        Me.lblSubJudul.ForeColor = System.Drawing.Color.FromArgb(200, 220, 255)
        Me.lblSubJudul.AutoSize  = True
        Me.lblSubJudul.Location  = New System.Drawing.Point(22, 48)

        Me.panelHeader.Controls.Add(Me.lblJudul)
        Me.panelHeader.Controls.Add(Me.lblSubJudul)

        ' =========================================================
        '  PANEL KIRI
        ' =========================================================
        Me.panelLeft.Location  = New System.Drawing.Point(15, 95)
        Me.panelLeft.Size      = New System.Drawing.Size(240, 555)
        Me.panelLeft.BackColor = System.Drawing.Color.White
        Me.panelLeft.BorderStyle = BorderStyle.None

        ' Panel Foto
        Me.panelFoto.Location  = New System.Drawing.Point(10, 10)
        Me.panelFoto.Size      = New System.Drawing.Size(220, 220)
        Me.panelFoto.BackColor = System.Drawing.Color.FromArgb(230, 236, 255)
        Me.panelFoto.Padding   = New System.Windows.Forms.Padding(5)

        Me.picFoto.Dock        = DockStyle.Fill
        Me.picFoto.BorderStyle = BorderStyle.None
        Me.picFoto.SizeMode    = PictureBoxSizeMode.StretchImage
        Me.picFoto.BackColor   = System.Drawing.Color.FromArgb(200, 212, 255)

        Me.panelFoto.Controls.Add(Me.picFoto)

        Me.btnBrowse.Text      = "📁  Browse Foto"
        Me.btnBrowse.Location  = New System.Drawing.Point(10, 238)
        Me.btnBrowse.Size      = New System.Drawing.Size(220, 36)
        Me.btnBrowse.FlatStyle = FlatStyle.Flat
        Me.btnBrowse.BackColor = System.Drawing.Color.FromArgb(41, 98, 255)
        Me.btnBrowse.ForeColor = System.Drawing.Color.White
        Me.btnBrowse.Font      = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
        Me.btnBrowse.FlatAppearance.BorderSize = 0
        Me.btnBrowse.Cursor    = Cursors.Hand

        ' GroupBox Jenis Kelamin
        Me.GroupBoxJK.Text      = " ⚥  Jenis Kelamin"
        Me.GroupBoxJK.Location  = New System.Drawing.Point(10, 285)
        Me.GroupBoxJK.Size      = New System.Drawing.Size(220, 60)
        Me.GroupBoxJK.Font      = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
        Me.GroupBoxJK.ForeColor = System.Drawing.Color.FromArgb(41, 98, 255)

        Me.rbLaki.Text      = "Laki-Laki"
        Me.rbLaki.Location  = New System.Drawing.Point(10, 25)
        Me.rbLaki.AutoSize  = True

        Me.rbPerempuan.Text     = "Perempuan"
        Me.rbPerempuan.Location = New System.Drawing.Point(105, 25)
        Me.rbPerempuan.AutoSize = True

        Me.GroupBoxJK.Controls.Add(Me.rbLaki)
        Me.GroupBoxJK.Controls.Add(Me.rbPerempuan)

        ' GroupBox Hobby
        Me.GroupBoxHobby.Text      = " 🎯  Hobby"
        Me.GroupBoxHobby.Name      = "GroupBoxHobby"
        Me.GroupBoxHobby.Location  = New System.Drawing.Point(10, 355)
        Me.GroupBoxHobby.Size      = New System.Drawing.Size(220, 190)
        Me.GroupBoxHobby.Font      = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
        Me.GroupBoxHobby.ForeColor = System.Drawing.Color.FromArgb(41, 98, 255)

        Dim hobbies() As CheckBox = {
            cbGaming, cbFutsal, cbBasket, cbBadminton, cbMancing,
            cbTravel, cbMusik, cbCoding, cbMembaca, cbMemasak,
            cbFotografi, cbOlahraga
        }
        Dim hobbyNames() As String = {
            "Gaming", "Futsal", "Basket", "Badminton", "Mancing",
            "Travel", "Musik", "Coding", "Membaca", "Memasak",
            "Fotografi", "Olahraga"
        }

        Dim col As Integer = 0, row As Integer = 0
        For i As Integer = 0 To hobbies.Length - 1
            hobbies(i).Text     = hobbyNames(i)
            hobbies(i).Location = New System.Drawing.Point(10 + col * 110, 22 + row * 22)
            hobbies(i).AutoSize = True
            hobbies(i).Font     = New System.Drawing.Font("Segoe UI", 8.5F)
            hobbies(i).ForeColor = System.Drawing.Color.FromArgb(50, 50, 80)
            Me.GroupBoxHobby.Controls.Add(hobbies(i))
            row += 1
            If row = 6 Then
                row = 0
                col = 1
            End If
        Next

        Me.panelLeft.Controls.Add(Me.panelFoto)
        Me.panelLeft.Controls.Add(Me.btnBrowse)
        Me.panelLeft.Controls.Add(Me.GroupBoxJK)
        Me.panelLeft.Controls.Add(Me.GroupBoxHobby)

        ' =========================================================
        '  PANEL KANAN
        ' =========================================================
        Me.panelRight.Location  = New System.Drawing.Point(270, 95)
        Me.panelRight.Size      = New System.Drawing.Size(590, 555)
        Me.panelRight.BackColor = System.Drawing.Color.White

        ' Helper: buat label
        Dim MakeLabel = Function(txt As String, y As Integer) As Label
                            Dim l As New Label
                            l.Text      = txt
                            l.Location  = New System.Drawing.Point(20, y)
                            l.AutoSize  = True
                            l.Font      = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
                            l.ForeColor = System.Drawing.Color.FromArgb(70, 90, 160)
                            Return l
                        End Function

        ' Helper: buat textbox
        Dim MakeTxt = Function(name As String, y As Integer, Optional multiline As Boolean = False) As TextBox
                          Dim t As New TextBox
                          t.Name        = name
                          t.Location    = New System.Drawing.Point(20, y)
                          t.Size        = New System.Drawing.Size(540, If(multiline, 60, 30))
                          t.Font        = New System.Drawing.Font("Segoe UI", 10)
                          t.BorderStyle = BorderStyle.FixedSingle
                          t.BackColor   = System.Drawing.Color.FromArgb(248, 250, 255)
                          If multiline Then
                              t.Multiline  = True
                              t.ScrollBars = ScrollBars.Vertical
                          End If
                          Return t
                      End Function

        ' Nama
        Me.lblNama    = MakeLabel("👤  Nama Lengkap", 20)
        Me.txtNama    = MakeTxt("txtNama", 45)
        ' Umur
        Me.lblUmur    = MakeLabel("🎂  Umur", 90)
        Me.txtUmur    = MakeTxt("txtUmur", 115)
        Me.txtUmur.Size = New System.Drawing.Size(160, 30)
        ' Telepon
        Me.lblTelepon = MakeLabel("📱  Nomor Telepon", 90)
        Me.lblTelepon.Location = New System.Drawing.Point(200, 90)
        Me.txtTelepon = MakeTxt("txtTelepon", 115)
        Me.txtTelepon.Location = New System.Drawing.Point(200, 115)
        Me.txtTelepon.Size     = New System.Drawing.Size(360, 30)
        ' Tanggal Lahir
        Me.lblTglLahir         = MakeLabel("📅  Tanggal Lahir", 160)
        Me.dtTanggal.Location  = New System.Drawing.Point(20, 185)
        Me.dtTanggal.Size      = New System.Drawing.Size(540, 30)
        Me.dtTanggal.Font      = New System.Drawing.Font("Segoe UI", 10)
        Me.dtTanggal.Format    = DateTimePickerFormat.Long
        Me.dtTanggal.CalendarMonthBackground = System.Drawing.Color.FromArgb(230, 240, 255)
        ' Alamat
        Me.lblAlamat  = MakeLabel("🏠  Alamat", 230)
        Me.txtAlamat  = MakeTxt("txtAlamat", 255, True)
        Me.txtAlamat.Size = New System.Drawing.Size(540, 70)

        Me.panelRight.Controls.AddRange(New Control() {
            Me.lblNama, Me.txtNama,
            Me.lblUmur, Me.txtUmur,
            Me.lblTelepon, Me.txtTelepon,
            Me.lblTglLahir, Me.dtTanggal,
            Me.lblAlamat, Me.txtAlamat
        })

        ' =========================================================
        '  PANEL BOTTOM (Tombol)
        ' =========================================================
        Me.panelBottom.Dock      = DockStyle.Bottom
        Me.panelBottom.Height    = 65
        Me.panelBottom.BackColor = System.Drawing.Color.FromArgb(240, 244, 255)

        Me.btnCetak.Text      = "🖨️  CETAK KARTU"
        Me.btnCetak.Size      = New System.Drawing.Size(200, 44)
        Me.btnCetak.Location  = New System.Drawing.Point(530, 10)
        Me.btnCetak.FlatStyle = FlatStyle.Flat
        Me.btnCetak.BackColor = System.Drawing.Color.FromArgb(41, 98, 255)
        Me.btnCetak.ForeColor = System.Drawing.Color.White
        Me.btnCetak.Font      = New System.Drawing.Font("Segoe UI", 11, System.Drawing.FontStyle.Bold)
        Me.btnCetak.FlatAppearance.BorderSize = 0
        Me.btnCetak.Cursor    = Cursors.Hand

        Me.btnReset.Text      = "🔄  Reset"
        Me.btnReset.Size      = New System.Drawing.Size(120, 44)
        Me.btnReset.Location  = New System.Drawing.Point(395, 10)
        Me.btnReset.FlatStyle = FlatStyle.Flat
        Me.btnReset.BackColor = System.Drawing.Color.FromArgb(220, 53, 69)
        Me.btnReset.ForeColor = System.Drawing.Color.White
        Me.btnReset.Font      = New System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold)
        Me.btnReset.FlatAppearance.BorderSize = 0
        Me.btnReset.Cursor    = Cursors.Hand

        Me.panelBottom.Controls.Add(Me.btnCetak)
        Me.panelBottom.Controls.Add(Me.btnReset)

        ' =========================================================
        '  TAMBAHKAN SEMUA KE FORM
        ' =========================================================
        Me.Controls.Add(Me.panelHeader)
        Me.Controls.Add(Me.panelLeft)
        Me.Controls.Add(Me.panelRight)
        Me.Controls.Add(Me.panelBottom)

    End Sub

    ' =========================================================
    '  DEKLARASI SEMUA KOMPONEN
    ' =========================================================
    Friend WithEvents panelHeader    As System.Windows.Forms.Panel
    Friend WithEvents lblJudul       As System.Windows.Forms.Label
    Friend WithEvents lblSubJudul    As System.Windows.Forms.Label
    Friend WithEvents panelLeft      As System.Windows.Forms.Panel
    Friend WithEvents panelFoto      As System.Windows.Forms.Panel
    Friend WithEvents picFoto        As System.Windows.Forms.PictureBox
    Friend WithEvents btnBrowse      As System.Windows.Forms.Button
    Friend WithEvents GroupBoxJK     As System.Windows.Forms.GroupBox
    Friend WithEvents rbLaki         As System.Windows.Forms.RadioButton
    Friend WithEvents rbPerempuan    As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBoxHobby  As System.Windows.Forms.GroupBox
    Friend WithEvents cbGaming       As System.Windows.Forms.CheckBox
    Friend WithEvents cbFutsal       As System.Windows.Forms.CheckBox
    Friend WithEvents cbBasket       As System.Windows.Forms.CheckBox
    Friend WithEvents cbBadminton    As System.Windows.Forms.CheckBox
    Friend WithEvents cbMancing      As System.Windows.Forms.CheckBox
    Friend WithEvents cbTravel       As System.Windows.Forms.CheckBox
    Friend WithEvents cbMusik        As System.Windows.Forms.CheckBox
    Friend WithEvents cbCoding       As System.Windows.Forms.CheckBox
    Friend WithEvents cbMembaca      As System.Windows.Forms.CheckBox
    Friend WithEvents cbMemasak      As System.Windows.Forms.CheckBox
    Friend WithEvents cbFotografi    As System.Windows.Forms.CheckBox
    Friend WithEvents cbOlahraga     As System.Windows.Forms.CheckBox
    Friend WithEvents panelRight     As System.Windows.Forms.Panel
    Friend WithEvents lblNama        As System.Windows.Forms.Label
    Friend WithEvents txtNama        As System.Windows.Forms.TextBox
    Friend WithEvents lblUmur        As System.Windows.Forms.Label
    Friend WithEvents txtUmur        As System.Windows.Forms.TextBox
    Friend WithEvents lblTelepon     As System.Windows.Forms.Label
    Friend WithEvents txtTelepon     As System.Windows.Forms.TextBox
    Friend WithEvents lblTglLahir    As System.Windows.Forms.Label
    Friend WithEvents dtTanggal      As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblAlamat      As System.Windows.Forms.Label
    Friend WithEvents txtAlamat      As System.Windows.Forms.TextBox
    Friend WithEvents panelBottom    As System.Windows.Forms.Panel
    Friend WithEvents btnCetak       As System.Windows.Forms.Button
    Friend WithEvents btnReset       As System.Windows.Forms.Button
    Friend WithEvents ToolTip1       As System.Windows.Forms.ToolTip

End Class
