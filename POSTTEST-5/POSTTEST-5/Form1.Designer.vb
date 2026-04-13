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
        components = New ComponentModel.Container()
        Label1 = New Label()
        Label2 = New Label()
        NamaPelanggan = New TextBox()
        JenisPemotongan = New TextBox()
        Label3 = New Label()
        Search = New TextBox()
        btnSimpan = New Button()
        btnUbah = New Button()
        btnHapus = New Button()
        btnBatal = New Button()
        Pembukuan = New DataGridView()
        ErrorProvider1 = New ErrorProvider(components)
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Harga = New TextBox()
        CType(Pembukuan, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(8, 7)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(98, 15)
        Label1.TabIndex = 0
        Label1.Text = "Nama Pelanggan"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(10, 32)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(104, 15)
        Label2.TabIndex = 1
        Label2.Text = "Jenis Pemotongan"
        ' 
        ' NamaPelanggan
        ' 
        NamaPelanggan.BackColor = Color.Azure
        NamaPelanggan.Location = New Point(127, 5)
        NamaPelanggan.Margin = New Padding(2)
        NamaPelanggan.Name = "NamaPelanggan"
        NamaPelanggan.PlaceholderText = "Nama Pelanggan"
        NamaPelanggan.Size = New Size(106, 23)
        NamaPelanggan.TabIndex = 2
        ' 
        ' JenisPemotongan
        ' 
        JenisPemotongan.BackColor = Color.Azure
        JenisPemotongan.Location = New Point(127, 32)
        JenisPemotongan.Margin = New Padding(2)
        JenisPemotongan.Name = "JenisPemotongan"
        JenisPemotongan.PlaceholderText = "Jenis Pemotongan"
        JenisPemotongan.Size = New Size(106, 23)
        JenisPemotongan.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(11, 84)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(55, 15)
        Label3.TabIndex = 4
        Label3.Text = "Cari Data"
        ' 
        ' Search
        ' 
        Search.BackColor = Color.Azure
        Search.Location = New Point(127, 85)
        Search.Margin = New Padding(2)
        Search.Name = "Search"
        Search.PlaceholderText = "Search"
        Search.Size = New Size(106, 23)
        Search.TabIndex = 5
        ' 
        ' btnSimpan
        ' 
        btnSimpan.Location = New Point(11, 134)
        btnSimpan.Margin = New Padding(2)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(78, 20)
        btnSimpan.TabIndex = 6
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = True
        ' 
        ' btnUbah
        ' 
        btnUbah.Location = New Point(92, 134)
        btnUbah.Margin = New Padding(2)
        btnUbah.Name = "btnUbah"
        btnUbah.Size = New Size(78, 20)
        btnUbah.TabIndex = 7
        btnUbah.Text = "Ubah"
        btnUbah.UseVisualStyleBackColor = True
        ' 
        ' btnHapus
        ' 
        btnHapus.Location = New Point(10, 158)
        btnHapus.Margin = New Padding(2)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(78, 20)
        btnHapus.TabIndex = 8
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = True
        ' 
        ' btnBatal
        ' 
        btnBatal.Location = New Point(92, 158)
        btnBatal.Margin = New Padding(2)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(78, 20)
        btnBatal.TabIndex = 9
        btnBatal.Text = "Batal"
        btnBatal.UseVisualStyleBackColor = True
        ' 
        ' Pembukuan
        ' 
        Pembukuan.BackgroundColor = SystemColors.ControlLightLight
        Pembukuan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Pembukuan.Location = New Point(242, 11)
        Pembukuan.Margin = New Padding(2)
        Pembukuan.Name = "Pembukuan"
        Pembukuan.RowHeadersWidth = 62
        Pembukuan.Size = New Size(437, 167)
        Pembukuan.TabIndex = 10
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.ForeColor = Color.Yellow
        Label4.Location = New Point(174, 158)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(19, 15)
        Label4.TabIndex = 11
        Label4.Text = "🌟"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.ForeColor = Color.SaddleBrown
        Label5.Location = New Point(219, 116)
        Label5.Margin = New Padding(2, 0, 2, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(19, 15)
        Label5.TabIndex = 12
        Label5.Text = "📒"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.ForeColor = Color.Yellow
        Label6.Location = New Point(174, 137)
        Label6.Margin = New Padding(2, 0, 2, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(19, 15)
        Label6.TabIndex = 13
        Label6.Text = "🌟"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(11, 57)
        Label7.Name = "Label7"
        Label7.Size = New Size(39, 15)
        Label7.TabIndex = 14
        Label7.Text = "Harga"
        ' 
        ' Harga
        ' 
        Harga.BackColor = Color.Azure
        Harga.Location = New Point(127, 58)
        Harga.Margin = New Padding(2)
        Harga.Name = "Harga"
        Harga.PlaceholderText = "Harga"
        Harga.Size = New Size(106, 23)
        Harga.TabIndex = 15
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.GradientInactiveCaption
        ClientSize = New Size(691, 195)
        Controls.Add(Harga)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Pembukuan)
        Controls.Add(btnBatal)
        Controls.Add(btnHapus)
        Controls.Add(btnUbah)
        Controls.Add(btnSimpan)
        Controls.Add(Search)
        Controls.Add(Label3)
        Controls.Add(JenisPemotongan)
        Controls.Add(NamaPelanggan)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Margin = New Padding(2)
        Name = "Form1"
        Text = "Form1"
        CType(Pembukuan, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents NamaPelanggan As TextBox
    Friend WithEvents JenisPemotongan As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Search As TextBox
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents Pembukuan As DataGridView
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Harga As TextBox

End Class

