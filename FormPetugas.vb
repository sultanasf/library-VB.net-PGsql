Imports System.Data.Odbc

Public Class FormPetugas
    Private Sub FormPetugas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BindData()
        DataGridView1.Columns(0).Width = 25
        DataGridView1.Columns(1).Width = 138
        DataGridView1.Columns(2).Width = 140
        DataGridView1.Columns(3).Width = 80
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "dd/MM/yyyy"
        DateTimePicker1.ShowUpDown = True

    End Sub
    Private Sub BindData()
        Dim connectionString As String = "Driver={PostgreSQL Unicode};Server=127.0.0.1;Port=5432;Database=perpus;Uid=postgres;Pwd=tanfi2514;"
        Dim queryString As String = "SELECT * FROM petugas"

        Dim connection As New OdbcConnection(connectionString)
        Dim adapter As New OdbcDataAdapter(queryString, connection)

        Dim data As New DataSet()
        adapter.Fill(data)

        DataGridView1.DataSource = data.Tables(0)
    End Sub
    Private Sub btnTambahAnggota_Click(sender As Object, e As EventArgs) Handles btnTambahPetugas.Click
        Dim namaPetugas As String = txtNamaPetugas.Text
        Dim alamatPetugas As String = txtAlamatPetugas.Text
        Dim tglLahirPetugas As String = DateTimePicker1.Value.ToString("yyyy-MM-dd")

        If String.IsNullOrEmpty(namaPetugas) Then
            MessageBox.Show("Nama Petugas tidak boleh kosong!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        If String.IsNullOrEmpty(alamatPetugas) Then
            MessageBox.Show("Alamat Petugas tidak boleh kosong!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        If String.IsNullOrEmpty(tglLahirPetugas) Then
            MessageBox.Show("Tgl Lahir Petugas tidak boleh kosong!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim connectionString As String = "Driver={PostgreSQL Unicode};Server=127.0.0.1;Port=5432;Database=perpus;Uid=postgres;Pwd=tanfi2514;"
        Dim connection As New OdbcConnection(connectionString)

        Try
            connection.Open()
            Dim sql As String = "INSERT INTO petugas (nama, alamat, tanggal_lahir) VALUES (?, ?, ?)"
            Dim command As New OdbcCommand(sql, connection)
            command.Parameters.AddWithValue("@nama", namaPetugas)
            command.Parameters.AddWithValue("@alamat", alamatPetugas)
            command.Parameters.AddWithValue("@tanggal_lahir", tglLahirPetugas)
            Dim rowsAffected As Integer = command.ExecuteNonQuery()
            BindData()
            MessageBox.Show(rowsAffected & " Petugas telah ditambahkan.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            connection.Close()
        End Try

        txtNamaPetugas.Text = ""
        txtAlamatPetugas.Text = ""
    End Sub
    Private Sub btnHapusAnggota_Click(sender As Object, e As EventArgs) Handles btnHapusPetugas.Click
        Dim selectedRowId As Integer = DataGridView1.CurrentRow.Cells(0).Value
        Dim selectedRowNama As String = DataGridView1.CurrentRow.Cells(1).Value.ToString()

        Dim confirmResult As DialogResult = MessageBox.Show("Hapus '" & selectedRowNama & "' dari list petugas?", "Konfirmasi Penghapusan", MessageBoxButtons.YesNo)

        If confirmResult = DialogResult.Yes Then
            Dim connectionString As String = "Driver={PostgreSQL Unicode};Server=127.0.0.1;Port=5432;Database=perpus;Uid=postgres;Pwd=tanfi2514;"
            Dim queryString As String = "DELETE FROM petugas WHERE id = ?"

            Dim connection As New OdbcConnection(connectionString)
            Dim command As New OdbcCommand(queryString, connection)

            command.Parameters.AddWithValue("@id", selectedRowId)

            connection.Open()
            command.ExecuteNonQuery()
            connection.Close()

            BindData()
        End If
    End Sub

    Private Sub btnCariAnggota_Click(sender As Object, e As EventArgs) Handles btnCariPetugas.Click
        Dim bs As BindingSource = PetugasBindingSource
        bs.Filter = "nama LIKE '" & txtNamaPetugas.Text & "%'"

        If bs.Count > 0 Then
            Dim row As DataRowView = CType(bs.Current, DataRowView)
            MessageBox.Show("Petugas ditemukan")
        Else
            MessageBox.Show("Petugas tidak ditemukan")
        End If
    End Sub
End Class