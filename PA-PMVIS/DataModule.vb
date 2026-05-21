Imports MySqlConnector

Module DataModule

    Public Function GetConnection() As MySqlConnection
        Dim connStr As String = "Server=localhost;Database=db_barbershop;Uid=root;Pwd=;"
        Return New MySqlConnection(connStr)
    End Function

    ' ============================================================
    ' TABEL ANTRIAN (tbantrian)
    ' ============================================================

    Public Function GetAllAntrian() As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String =
                "SELECT a.idAntrian, a.nomorAntrian, a.namaCustomer, " &
                "p.namaPelayanan, p.harga, b.namaBarber, a.status " &
                "FROM tbantrian a " &
                "INNER JOIN tbpelayanan p ON a.idPelayanan = p.idPelayanan " &
                "INNER JOIN tbbarber b ON a.idBarber = b.idBarber " &
                "ORDER BY a.nomorAntrian ASC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menampilkan antrian: " & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function SearchAntrian(keyword As String) As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String =
                "SELECT a.idAntrian, a.nomorAntrian, a.namaCustomer, " &
                "p.namaPelayanan, p.harga, b.namaBarber, a.status " &
                "FROM tbantrian a " &
                "INNER JOIN tbpelayanan p ON a.idPelayanan = p.idPelayanan " &
                "INNER JOIN tbbarber b ON a.idBarber = b.idBarber " &
                "WHERE a.namaCustomer LIKE @keyword OR a.nomorAntrian LIKE @keyword " &
                "ORDER BY a.nomorAntrian ASC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@keyword", "%" & keyword & "%")
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mencari antrian: " & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function GetNomorAntrianBerikutnya() As String
        Try
            Dim query As String = "SELECT COUNT(*) FROM tbantrian"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    Dim jumlah As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    Return "A" & (jumlah + 1).ToString("D2")
                End Using
            End Using
        Catch ex As Exception
            Return "A01"
        End Try
    End Function

    Public Function SimpanAntrian(nomor As String, nama As String,
                                   idPelayanan As Integer, idBarber As Integer) As Boolean
        Try
            Dim query As String =
                "INSERT INTO tbantrian (nomorAntrian, namaCustomer, idPelayanan, idBarber, status, pembayaran) " &
                "VALUES (@nomor, @nama, @idPelayanan, @idBarber, 'Menunggu', 0)"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@nomor", nomor)
                    cmd.Parameters.AddWithValue("@nama", nama)
                    cmd.Parameters.AddWithValue("@idPelayanan", idPelayanan)
                    cmd.Parameters.AddWithValue("@idBarber", idBarber)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Gagal menyimpan booking: " & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function UbahAntrian(idAntrian As Integer, status As String,
                                 namaCustomer As String,
                                 idPelayanan As Integer, idBarber As Integer) As Boolean
        Try
            Dim query As String =
                "UPDATE tbantrian SET status = @status, namaCustomer = @nama, " &
                "idPelayanan = @idPelayanan, idBarber = @idBarber " &
                "WHERE idAntrian = @id"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@status", status)
                    cmd.Parameters.AddWithValue("@nama", namaCustomer)
                    cmd.Parameters.AddWithValue("@idPelayanan", idPelayanan)
                    cmd.Parameters.AddWithValue("@idBarber", idBarber)
                    cmd.Parameters.AddWithValue("@id", idAntrian)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mengubah antrian: " & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function HapusAntrian(idAntrian As Integer) As Boolean
        Try
            Dim query As String = "DELETE FROM tbantrian WHERE idAntrian = @id"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", idAntrian)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menghapus antrian: " & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    ' ============================================================
    ' TABEL PELAYANAN & BARBER
    ' ============================================================

    Public Function GetAllPelayanan() As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String = "SELECT idPelayanan, namaPelayanan, harga FROM tbpelayanan ORDER BY namaPelayanan"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal memuat pelayanan: " & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function GetAllBarber() As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String = "SELECT idBarber, namaBarber FROM tbbarber ORDER BY namaBarber"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal memuat barber: " & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

End Module
