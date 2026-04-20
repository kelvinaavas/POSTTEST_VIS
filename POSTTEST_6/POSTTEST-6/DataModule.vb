Imports MySqlConnector

Module DataModule

    ' ============================================================
    ' KONEKSI DATABASE
    ' ============================================================
    Public Function GetConnection() As MySqlConnection
        Dim connStr As String = "Server=localhost;Database=db_barbershop;Uid=root;Pwd=;"
        Return New MySqlConnection(connStr)
    End Function

    ' ============================================================
    ' TABEL PELANGGAN (tbpelanggan) — Tabel Induk / Parent
    ' ============================================================

    Public Function GetAllPelanggan() As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String =
                "SELECT kodePelanggan, namaPelanggan, noTelepon, alamat " &
                "FROM tbpelanggan ORDER BY kodePelanggan ASC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menampilkan data pelanggan: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function SearchPelanggan(keyword As String) As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String =
                "SELECT kodePelanggan, namaPelanggan, noTelepon, alamat " &
                "FROM tbpelanggan " &
                "WHERE namaPelanggan LIKE @keyword OR noTelepon LIKE @keyword " &
                "ORDER BY kodePelanggan ASC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@keyword", "%" & keyword & "%")
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mencari data pelanggan: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function KodePelangganSudahAda(kode As String) As Boolean
        Try
            Dim query As String = "SELECT COUNT(*) FROM tbpelanggan WHERE kodePelanggan = @kode"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    Return Convert.ToInt32(cmd.ExecuteScalar()) > 0
                End Using
            End Using
        Catch ex As Exception
            Return True
        End Try
    End Function

    Public Function SimpanPelanggan(kode As String, nama As String,
                                    telepon As String, alamat As String) As Boolean
        Try
            Dim query As String =
                "INSERT INTO tbpelanggan (kodePelanggan, namaPelanggan, noTelepon, alamat) " &
                "VALUES (@kode, @nama, @telepon, @alamat)"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    cmd.Parameters.AddWithValue("@nama", nama)
                    cmd.Parameters.AddWithValue("@telepon", telepon)
                    cmd.Parameters.AddWithValue("@alamat", alamat)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Gagal menyimpan data pelanggan: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function UbahPelanggan(kode As String, nama As String,
                                  telepon As String, alamat As String) As Boolean
        Try
            Dim query As String =
                "UPDATE tbpelanggan SET namaPelanggan = @nama, noTelepon = @telepon, " &
                "alamat = @alamat WHERE kodePelanggan = @kode"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    cmd.Parameters.AddWithValue("@nama", nama)
                    cmd.Parameters.AddWithValue("@telepon", telepon)
                    cmd.Parameters.AddWithValue("@alamat", alamat)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mengubah data pelanggan: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function HapusPelanggan(kode As String) As Boolean
        Try
            Dim query As String = "DELETE FROM tbpelanggan WHERE kodePelanggan = @kode"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menghapus data pelanggan: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    ' ============================================================
    ' TABEL PELAYANAN (tbpelayanan) — Tabel Anak / Child
    ' kodePelanggan = FOREIGN KEY → tbpelanggan.kodePelanggan
    ' ON DELETE CASCADE | ON UPDATE CASCADE
    ' ============================================================

    Public Function GetAllPelayanan() As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String =
                "SELECT tbpelayanan.kodePelayanan, " &
                "tbpelanggan.namaPelanggan AS 'Nama Pelanggan', " &
                "tbpelayanan.jenisPemotongan, " &
                "tbpelayanan.harga, " &
                "tbpelayanan.tanggal " &
                "FROM tbpelayanan " &
                "INNER JOIN tbpelanggan ON tbpelayanan.kodePelanggan = tbpelanggan.kodePelanggan " &
                "ORDER BY tbpelayanan.tanggal DESC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menampilkan data pelayanan: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function SearchPelayanan(keyword As String) As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String =
                "SELECT tbpelayanan.kodePelayanan, " &
                "tbpelanggan.namaPelanggan AS 'Nama Pelanggan', " &
                "tbpelayanan.jenisPemotongan, " &
                "tbpelayanan.harga, " &
                "tbpelayanan.tanggal " &
                "FROM tbpelayanan " &
                "INNER JOIN tbpelanggan ON tbpelayanan.kodePelanggan = tbpelanggan.kodePelanggan " &
                "WHERE tbpelanggan.namaPelanggan LIKE @keyword " &
                "OR tbpelayanan.jenisPemotongan LIKE @keyword " &
                "ORDER BY tbpelayanan.tanggal DESC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@keyword", "%" & keyword & "%")
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mencari data pelayanan: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function KodePelayananSudahAda(kode As String) As Boolean
        Try
            Dim query As String = "SELECT COUNT(*) FROM tbpelayanan WHERE kodePelayanan = @kode"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    Return Convert.ToInt32(cmd.ExecuteScalar()) > 0
                End Using
            End Using
        Catch ex As Exception
            Return True
        End Try
    End Function

    Public Function SimpanPelayanan(kodePelayanan As String, kodePelanggan As String,
                                    jenisPemotongan As String, harga As Integer,
                                    tanggal As String) As Boolean
        Try
            Dim query As String =
                "INSERT INTO tbpelayanan (kodePelayanan, kodePelanggan, jenisPemotongan, harga, tanggal) " &
                "VALUES (@kodePelayanan, @kodePelanggan, @jenis, @harga, @tanggal)"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kodePelayanan", kodePelayanan)
                    cmd.Parameters.AddWithValue("@kodePelanggan", kodePelanggan)
                    cmd.Parameters.AddWithValue("@jenis", jenisPemotongan)
                    cmd.Parameters.AddWithValue("@harga", harga)
                    cmd.Parameters.AddWithValue("@tanggal", tanggal)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Gagal menyimpan data pelayanan: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function UbahPelayanan(kodePelayanan As String, kodePelanggan As String,
                                  jenisPemotongan As String, harga As Integer,
                                  tanggal As String) As Boolean
        Try
            Dim query As String =
                "UPDATE tbpelayanan SET kodePelanggan = @kodePelanggan, " &
                "jenisPemotongan = @jenis, harga = @harga, tanggal = @tanggal " &
                "WHERE kodePelayanan = @kodePelayanan"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kodePelayanan", kodePelayanan)
                    cmd.Parameters.AddWithValue("@kodePelanggan", kodePelanggan)
                    cmd.Parameters.AddWithValue("@jenis", jenisPemotongan)
                    cmd.Parameters.AddWithValue("@harga", harga)
                    cmd.Parameters.AddWithValue("@tanggal", tanggal)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mengubah data pelayanan: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function HapusPelayanan(kode As String) As Boolean
        Try
            Dim query As String = "DELETE FROM tbpelayanan WHERE kodePelayanan = @kode"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menghapus data pelayanan: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

End Module
