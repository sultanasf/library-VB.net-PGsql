Imports System.Data.Odbc
Public Class FormAnggota
    Private Sub FormAnggota_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.anggota' table. You can move, or remove it, as needed.
        Me.AnggotaTableAdapter.Fill(Me.DataSet1.anggota)
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
        Dim queryString As String = "SELECT * FROM anggota"

        Dim connection As New OdbcConnection(connectionString)
        Dim adapter As New OdbcDataAdapter(queryString, connection)

        Dim data As New DataSet()
        adapter.Fill(data)

        DataGridView1.DataSource = data.Tables(0)
    End Sub
    Private Sub btnTambahAnggota_Click(sender As Object, e As EventArgs) Handles btnTambahAnggota.Click
        Dim namaAnggota As String = txtNamaAnggota.Text
        Dim alamatAnggota As String = txtAlamatAnggota.Text
        Dim tglLahirAnggota As String = DateTimePicker1.Value.ToString("yyyy-MM-dd")

        If String.IsNullOrEmpty(namaAnggota) Then
            MessageBox.Show("Nama Anggota tidak boleh kosong!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        If String.IsNullOrEmpty(alamatAnggota) Then
            MessageBox.Show("Alamat Anggota tidak boleh kosong!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        If String.IsNullOrEmpty(tglLahirAnggota) Then
            MessageBox.Show("Tgl Lahir Anggota tidak boleh kosong!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim connectionString As String = "Driver={PostgreSQL Unicode};Server=127.0.0.1;Port=5432;Database=perpus;Uid=postgres;Pwd=tanfi2514;"
        Dim connection As New OdbcConnection(connectionString)

        Try
            connection.Open()
            Dim sql As String = "INSERT INTO anggota (nama, alamat, tanggal_lahir) VALUES (?, ?, ?)"
            Dim command As New OdbcCommand(Sql, connection)
            command.Parameters.AddWithValue("@nama", namaAnggota)
            command.Parameters.AddWithValue("@alamat", alamatAnggota)
            command.Parameters.AddWithValue("@tanggal_lahir", tglLahirAnggota)
            Dim rowsAffected As Integer = command.ExecuteNonQuery()
            BindData()
            MessageBox.Show(rowsAffected & " Anggota telah ditambahkan.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            connection.Close()
        End Try

        txtNamaAnggota.Text = ""
        txtAlamatAnggota.Text = ""
    End Sub
    Private Sub btnHapusAnggota_Click(sender As Object, e As EventArgs) Handles btnHapusAnggota.Click
        Dim selectedRowId As Integer = DataGridView1.CurrentRow.Cells(0).Value
        Dim selectedRowNama As String = DataGridView1.CurrentRow.Cells(1).Value.ToString()

        Dim confirmResult As DialogResult = MessageBox.Show("Hapus '" & selectedRowNama & "' dari list anggota?", "Konfirmasi Penghapusan", MessageBoxButtons.YesNo)

        If confirmResult = DialogResult.Yes Then
            Dim connectionString As String = "Driver={PostgreSQL Unicode};Server=127.0.0.1;Port=5432;Database=perpus;Uid=postgres;Pwd=tanfi2514;"
            Dim queryString As String = "DELETE FROM anggota WHERE id = ?"

            Dim connection As New OdbcConnection(connectionString)
            Dim command As New OdbcCommand(queryString, connection)

            command.Parameters.AddWithValue("@id", selectedRowId)

            connection.Open()
            command.ExecuteNonQuery()
            connection.Close()

            BindData()
        End If
    End Sub

    Private Sub btnCariAnggota_Click(sender As Object, e As EventArgs) Handles btnCariAnggota.Click
        Dim bs As BindingSource = AnggotaBindingSource
        bs.Filter = "nama LIKE '" & txtNamaAnggota.Text & "%'"

        If bs.Count > 0 Then
            Dim row As DataRowView = CType(bs.Current, DataRowView)
            MessageBox.Show("Anggota ditemukan")
        Else
            MessageBox.Show("Anggota tidak ditemukan")
        End If
    End Sub
End Class