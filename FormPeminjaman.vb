Imports System.Data.Odbc
Public Class FormPeminjaman
    Private Sub FormPeminjaman_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.DataTable1' table. You can move, or remove it, as needed.
        Me.DataTable1TableAdapter.Fill(Me.DataSet1.DataTable1)
        DataGridView1.Columns(0).Width = 30
        DataGridView1.Columns(1).Width = 150
        DataGridView1.Columns(2).Width = 150
        DataGridView1.Columns(3).Width = 200
        DataGridView1.Columns(4).Width = 85
        DataGridView1.Columns(5).Width = 90
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "dd/MM/yyyy"
        DateTimePicker1.ShowUpDown = True
    End Sub
    Private Sub BindData()
        Dim connectionString As String = "Driver={PostgreSQL Unicode};Server=127.0.0.1;Port=5432;Database=perpus;Uid=postgres;Pwd=tanfi2514;"
        Dim queryString As String = "SELECT transaksi.id AS id, buku.judul AS judul_buku, anggota.nama AS nama_anggota, petugas.nama AS nama_petugas, transaksi.tanggal_pinjam, transaksi.tanggal_kembali
FROM   transaksi, anggota, petugas, buku
WHERE transaksi.anggota_id = anggota.id AND transaksi.petugas_id = petugas.id AND transaksi.buku_id = buku.id"

        Dim connection As New OdbcConnection(connectionString)
        Dim adapter As New OdbcDataAdapter(queryString, connection)

        Dim data As New DataSet()
        adapter.Fill(data)

        DataGridView1.DataSource = data.Tables(0)
    End Sub
    Private Sub btnCariBuku_Click(sender As Object, e As EventArgs) Handles btnCariBuku.Click
        Dim bs As BindingSource = DataTable1BindingSource
        bs.Filter = "judul_buku LIKE '" & txtJudulBuku.Text & "%'"

        If bs.Count > 0 Then
            Dim row As DataRowView = CType(bs.Current, DataRowView)
            MessageBox.Show("Buku ditemukan")
        Else
            MessageBox.Show("Buku tidak ditemukan")
        End If
    End Sub

    Private Sub btnTambahPeminjaman_Click(sender As Object, e As EventArgs) Handles btnTambahPeminjaman.Click
        Dim idAnggota As String = txtIdAnggota.Text
        Dim idPetugas As String = txtIdPetugas.Text
        Dim idBuku As String = txtIdBuku.Text
        Dim tglPinjam As String = DateTimePicker1.Value.ToString("yyyy-MM-dd")

        If String.IsNullOrEmpty(idAnggota) Then
            MessageBox.Show("Id Anggota tidak boleh kosong!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        If String.IsNullOrEmpty(idPetugas) Then
            MessageBox.Show("Id Petugas tidak boleh kosong!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        If String.IsNullOrEmpty(tglPinjam) Then
            MessageBox.Show("Tgl Pinjam tidak boleh kosong!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim connectionString As String = "Driver={PostgreSQL Unicode};Server=127.0.0.1;Port=5432;Database=perpus;Uid=postgres;Pwd=tanfi2514;"
        Dim connection As New OdbcConnection(connectionString)

        Try
            connection.Open()
            Dim sql As String = "INSERT INTO transaksi (anggota_id, petugas_id, buku_id, tanggal_pinjam) VALUES (?, ?, ?, ?)"
            Dim command As New OdbcCommand(sql, connection)
            command.Parameters.AddWithValue("@anggota_id", idAnggota)
            command.Parameters.AddWithValue("@petugas_id", idPetugas)
            command.Parameters.AddWithValue("@buku_id", idBuku)
            command.Parameters.AddWithValue("@tanggal_pinjam", tglPinjam)
            Dim rowsAffected As Integer = command.ExecuteNonQuery()
            BindData()
            MessageBox.Show(rowsAffected & " Laporan telah ditambahkan.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            connection.Close()
        End Try

        txtIdBuku.Text = ""
        txtIdAnggota.Text = ""
        txtIdPetugas.Text = ""
    End Sub
    Private Sub DataGridView1_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles DataGridView1.CellBeginEdit
        ' Check if the current cell is not in the "tanggal_kembali" column
        If e.ColumnIndex <> DataGridView1.Columns(5).Index Then
            ' Cancel the edit for other cells
            e.Cancel = True
        End If
    End Sub
    Private Sub DataGridView1_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellEndEdit
        If e.ColumnIndex = DataGridView1.Columns(5).Index Then
            Dim updatedRow As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            Dim tanggalKembali As String = updatedRow.Cells(5).Value.ToString()

            ' Remove the time component from the date string
            Dim dateParts As String() = tanggalKembali.Split(" "c)
            tanggalKembali = dateParts(0)

            ' Split the date string into day, month, and year
            Dim parts As String() = tanggalKembali.Split("/"c)
            Dim day As String = parts(0)
            Dim month As String = parts(1)
            Dim year As String = parts(2)

            Dim newDateString As String = year & "-" & month & "-" & day

            Dim connectionString As String = "Driver={PostgreSQL Unicode};Server=127.0.0.1;Port=5432;Database=perpus;Uid=postgres;Pwd=tanfi2514;"
            Dim connection As New OdbcConnection(connectionString)

            Try
                connection.Open()
                Dim sql As String = "UPDATE transaksi SET tanggal_kembali=? WHERE id=?"
                Dim command As New OdbcCommand(sql, connection)
                command.Parameters.AddWithValue("@tanggal_kembali", newDateString)
                command.Parameters.AddWithValue("@id", updatedRow.Cells(0).Value.ToString())
                command.ExecuteNonQuery()
                BindData()
                MessageBox.Show("Laporan telah diubah.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                connection.Close()
            End Try
        End If
    End Sub

End Class