Imports System.Data.Odbc
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BindData()
        DataGridView1.Columns(0).Width = 25
        DataGridView1.Columns(1).Width = 200
        DataGridView1.Columns(2).Width = 180

    End Sub
    Private Sub BindData()
        Dim connectionString As String = "Driver={PostgreSQL Unicode};Server=127.0.0.1;Port=5432;Database=perpus;Uid=postgres;Pwd=tanfi2514;"
        Dim queryString As String = "SELECT * FROM buku"

        Dim connection As New OdbcConnection(connectionString)
        Dim adapter As New OdbcDataAdapter(queryString, connection)

        Dim data As New DataSet()
        adapter.Fill(data)

        DataGridView1.DataSource = data.Tables(0)
    End Sub
    Private Sub btnTambahBuku_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Dim judulBuku As String = txtJudulBuku.Text
        Dim penulisBuku As String = txtPenulisBuku.Text
        Dim tahunTerbitBuku As String = txtTahunTerbitBuku.Text

        If String.IsNullOrEmpty(judulBuku) Then
            MessageBox.Show("Judul Buku tidak boleh kosong!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        If String.IsNullOrEmpty(penulisBuku) Then
            MessageBox.Show("Penulis Buku tidak boleh kosong!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        If String.IsNullOrEmpty(tahunTerbitBuku) Then
            MessageBox.Show("Tahun Terbit Buku tidak boleh kosong!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim connectionString As String = "Driver={PostgreSQL Unicode};Server=127.0.0.1;Port=5432;Database=perpus;Uid=postgres;Pwd=tanfi2514;"
        Dim connection As New OdbcConnection(connectionString)

        Try
            connection.Open()
            Dim sql As String = "INSERT INTO buku (judul, penulis, tahun_terbit) VALUES (?, ?, ?)"
            Dim command As New OdbcCommand(sql, connection)
            command.Parameters.AddWithValue("@judul", judulBuku)
            command.Parameters.AddWithValue("@penulis", penulisBuku)
            command.Parameters.AddWithValue("@tahun_terbit", tahunTerbitBuku)
            Dim rowsAffected As Integer = command.ExecuteNonQuery()
            BindData()
            MessageBox.Show(rowsAffected & " Buku telah ditambahkan.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception

        Finally
            connection.Close()
        End Try

        txtJudulBuku.Text = ""
        txtPenulisBuku.Text = ""
        txtTahunTerbitBuku.Text = ""
    End Sub
    Private Sub btnHapusBuku_Click(sender As Object, e As EventArgs) Handles btnHapusBuku.Click
        Dim selectedRowId As Integer = DataGridView1.CurrentRow.Cells(0).Value
        Dim selectedRowJudul As String = DataGridView1.CurrentRow.Cells(1).Value.ToString()

        Dim confirmResult As DialogResult = MessageBox.Show("Hapus buku '" & selectedRowJudul & "' dari koleksi?", "Konfirmasi Penghapusan", MessageBoxButtons.YesNo)

        If confirmResult = DialogResult.Yes Then
            Dim connectionString As String = "Driver={PostgreSQL Unicode};Server=127.0.0.1;Port=5432;Database=perpus;Uid=postgres;Pwd=tanfi2514;"
            Dim queryString As String = "DELETE FROM buku WHERE id = ?"

            Dim connection As New OdbcConnection(connectionString)
            Dim command As New OdbcCommand(queryString, connection)

            command.Parameters.AddWithValue("@id", selectedRowId)

            connection.Open()
            command.ExecuteNonQuery()
            connection.Close()

            BindData()
        End If
    End Sub
    Private Sub btnCariBuku_Click(sender As Object, e As EventArgs) Handles btnCariBuku.Click
        Dim bs As BindingSource = BukuBindingSource
        bs.Filter = "judul LIKE '" & txtJudulBuku.Text & "%'"

        If bs.Count > 0 Then
            Dim row As DataRowView = CType(bs.Current, DataRowView)
            MessageBox.Show("Buku ditemukan")
        Else
            MessageBox.Show("Data tidak ditemukan")
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            Dim connectionString As String = "Driver={PostgreSQL Unicode};Server=127.0.0.1;Port=5432;Database=perpus;Uid=postgres;Pwd=tanfi2514;"
            Dim queryString As String = "SELECT buku.* FROM buku LEFT JOIN transaksi ON buku.id = transaksi.buku_id 
WHERE buku.id NOT IN (SELECT buku_id FROM transaksi WHERE tanggal_kembali IS NULL)
GROUP BY buku.id ORDER BY buku.id"

            Dim connection As New OdbcConnection(connectionString)
            Dim adapter As New OdbcDataAdapter(queryString, connection)

            Dim data As New DataSet()
            adapter.Fill(data)

            DataGridView1.DataSource = data.Tables(0)
        Else
            BindData()
        End If
    End Sub
End Class
