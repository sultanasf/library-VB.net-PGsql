<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPeminjaman
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.judulPeminjaman = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnCariBuku = New System.Windows.Forms.Button()
        Me.txtIdPetugas = New System.Windows.Forms.TextBox()
        Me.labelTahunTerbitBuku = New System.Windows.Forms.Label()
        Me.labelIdAnggota = New System.Windows.Forms.Label()
        Me.txtIdAnggota = New System.Windows.Forms.TextBox()
        Me.txtIdBuku = New System.Windows.Forms.TextBox()
        Me.labelJudulBuku = New System.Windows.Forms.Label()
        Me.btnTambahPeminjaman = New System.Windows.Forms.Button()
        Me.txtJudulBuku = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataSet1 = New Perpus.DataSet1()
        Me.DataTable1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataTable1TableAdapter = New Perpus.DataSet1TableAdapters.DataTable1TableAdapter()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamapetugasDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaanggotaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JudulbukuDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TanggalpinjamDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TanggalkembaliDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'judulPeminjaman
        '
        Me.judulPeminjaman.AutoSize = True
        Me.judulPeminjaman.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.judulPeminjaman.Location = New System.Drawing.Point(301, 24)
        Me.judulPeminjaman.Name = "judulPeminjaman"
        Me.judulPeminjaman.Size = New System.Drawing.Size(452, 40)
        Me.judulPeminjaman.TabIndex = 6
        Me.judulPeminjaman.Text = "LAPORAN PEMINJAMAN"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.NamapetugasDataGridViewTextBoxColumn, Me.NamaanggotaDataGridViewTextBoxColumn, Me.JudulbukuDataGridViewTextBoxColumn, Me.TanggalpinjamDataGridViewTextBoxColumn, Me.TanggalkembaliDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.DataTable1BindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(97, 277)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 30
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(885, 304)
        Me.DataGridView1.TabIndex = 7
        '
        'btnCariBuku
        '
        Me.btnCariBuku.Location = New System.Drawing.Point(757, 169)
        Me.btnCariBuku.Name = "btnCariBuku"
        Me.btnCariBuku.Size = New System.Drawing.Size(113, 35)
        Me.btnCariBuku.TabIndex = 19
        Me.btnCariBuku.Text = "Cari Buku"
        Me.btnCariBuku.UseVisualStyleBackColor = True
        '
        'txtIdPetugas
        '
        Me.txtIdPetugas.Location = New System.Drawing.Point(254, 160)
        Me.txtIdPetugas.Name = "txtIdPetugas"
        Me.txtIdPetugas.Size = New System.Drawing.Size(102, 26)
        Me.txtIdPetugas.TabIndex = 18
        '
        'labelTahunTerbitBuku
        '
        Me.labelTahunTerbitBuku.AutoSize = True
        Me.labelTahunTerbitBuku.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelTahunTerbitBuku.Location = New System.Drawing.Point(130, 163)
        Me.labelTahunTerbitBuku.Name = "labelTahunTerbitBuku"
        Me.labelTahunTerbitBuku.Size = New System.Drawing.Size(96, 20)
        Me.labelTahunTerbitBuku.TabIndex = 17
        Me.labelTahunTerbitBuku.Text = "Id Petugas"
        '
        'labelIdAnggota
        '
        Me.labelIdAnggota.AutoSize = True
        Me.labelIdAnggota.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelIdAnggota.Location = New System.Drawing.Point(130, 109)
        Me.labelIdAnggota.Name = "labelIdAnggota"
        Me.labelIdAnggota.Size = New System.Drawing.Size(98, 20)
        Me.labelIdAnggota.TabIndex = 16
        Me.labelIdAnggota.Text = "Id Anggota"
        '
        'txtIdAnggota
        '
        Me.txtIdAnggota.Location = New System.Drawing.Point(254, 106)
        Me.txtIdAnggota.Name = "txtIdAnggota"
        Me.txtIdAnggota.Size = New System.Drawing.Size(102, 26)
        Me.txtIdAnggota.TabIndex = 15
        '
        'txtIdBuku
        '
        Me.txtIdBuku.Location = New System.Drawing.Point(478, 106)
        Me.txtIdBuku.Name = "txtIdBuku"
        Me.txtIdBuku.Size = New System.Drawing.Size(102, 26)
        Me.txtIdBuku.TabIndex = 14
        '
        'labelJudulBuku
        '
        Me.labelJudulBuku.AutoSize = True
        Me.labelJudulBuku.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelJudulBuku.Location = New System.Drawing.Point(381, 109)
        Me.labelJudulBuku.Name = "labelJudulBuku"
        Me.labelJudulBuku.Size = New System.Drawing.Size(71, 20)
        Me.labelJudulBuku.TabIndex = 13
        Me.labelJudulBuku.Text = "Id Buku"
        '
        'btnTambahPeminjaman
        '
        Me.btnTambahPeminjaman.Location = New System.Drawing.Point(305, 215)
        Me.btnTambahPeminjaman.Name = "btnTambahPeminjaman"
        Me.btnTambahPeminjaman.Size = New System.Drawing.Size(182, 35)
        Me.btnTambahPeminjaman.TabIndex = 12
        Me.btnTambahPeminjaman.Text = "Tambah Peminjaman"
        Me.btnTambahPeminjaman.UseVisualStyleBackColor = True
        '
        'txtJudulBuku
        '
        Me.txtJudulBuku.Location = New System.Drawing.Point(757, 128)
        Me.txtJudulBuku.Name = "txtJudulBuku"
        Me.txtJudulBuku.Size = New System.Drawing.Size(211, 26)
        Me.txtJudulBuku.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(753, 105)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 20)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Judul Buku"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(478, 160)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(141, 26)
        Me.DateTimePicker1.TabIndex = 25
        Me.DateTimePicker1.Value = New Date(2023, 5, 28, 0, 0, 0, 0)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(381, 161)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 20)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Tgl Pinjam"
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataTable1BindingSource
        '
        Me.DataTable1BindingSource.DataMember = "DataTable1"
        Me.DataTable1BindingSource.DataSource = Me.DataSet1
        '
        'DataTable1TableAdapter
        '
        Me.DataTable1TableAdapter.ClearBeforeFill = True
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "id"
        Me.IdDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.Width = 150
        '
        'NamapetugasDataGridViewTextBoxColumn
        '
        Me.NamapetugasDataGridViewTextBoxColumn.DataPropertyName = "nama_petugas"
        Me.NamapetugasDataGridViewTextBoxColumn.HeaderText = "nama_petugas"
        Me.NamapetugasDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.NamapetugasDataGridViewTextBoxColumn.Name = "NamapetugasDataGridViewTextBoxColumn"
        Me.NamapetugasDataGridViewTextBoxColumn.Width = 150
        '
        'NamaanggotaDataGridViewTextBoxColumn
        '
        Me.NamaanggotaDataGridViewTextBoxColumn.DataPropertyName = "nama_anggota"
        Me.NamaanggotaDataGridViewTextBoxColumn.HeaderText = "nama_anggota"
        Me.NamaanggotaDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.NamaanggotaDataGridViewTextBoxColumn.Name = "NamaanggotaDataGridViewTextBoxColumn"
        Me.NamaanggotaDataGridViewTextBoxColumn.Width = 150
        '
        'JudulbukuDataGridViewTextBoxColumn
        '
        Me.JudulbukuDataGridViewTextBoxColumn.DataPropertyName = "judul_buku"
        Me.JudulbukuDataGridViewTextBoxColumn.HeaderText = "judul_buku"
        Me.JudulbukuDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.JudulbukuDataGridViewTextBoxColumn.Name = "JudulbukuDataGridViewTextBoxColumn"
        Me.JudulbukuDataGridViewTextBoxColumn.Width = 150
        '
        'TanggalpinjamDataGridViewTextBoxColumn
        '
        Me.TanggalpinjamDataGridViewTextBoxColumn.DataPropertyName = "tanggal_pinjam"
        Me.TanggalpinjamDataGridViewTextBoxColumn.HeaderText = "tanggal_pinjam"
        Me.TanggalpinjamDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.TanggalpinjamDataGridViewTextBoxColumn.Name = "TanggalpinjamDataGridViewTextBoxColumn"
        Me.TanggalpinjamDataGridViewTextBoxColumn.Width = 150
        '
        'TanggalkembaliDataGridViewTextBoxColumn
        '
        Me.TanggalkembaliDataGridViewTextBoxColumn.DataPropertyName = "tanggal_kembali"
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.TanggalkembaliDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.TanggalkembaliDataGridViewTextBoxColumn.HeaderText = "tanggal_kembali"
        Me.TanggalkembaliDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.TanggalkembaliDataGridViewTextBoxColumn.Name = "TanggalkembaliDataGridViewTextBoxColumn"
        Me.TanggalkembaliDataGridViewTextBoxColumn.Width = 150
        '
        'FormPeminjaman
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1084, 630)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtJudulBuku)
        Me.Controls.Add(Me.btnCariBuku)
        Me.Controls.Add(Me.txtIdPetugas)
        Me.Controls.Add(Me.labelTahunTerbitBuku)
        Me.Controls.Add(Me.labelIdAnggota)
        Me.Controls.Add(Me.txtIdAnggota)
        Me.Controls.Add(Me.txtIdBuku)
        Me.Controls.Add(Me.labelJudulBuku)
        Me.Controls.Add(Me.btnTambahPeminjaman)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.judulPeminjaman)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormPeminjaman"
        Me.Text = "FormPeminjaman"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents judulPeminjaman As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnCariBuku As Button
    Friend WithEvents txtIdPetugas As TextBox
    Friend WithEvents labelTahunTerbitBuku As Label
    Friend WithEvents labelIdAnggota As Label
    Friend WithEvents txtIdAnggota As TextBox
    Friend WithEvents txtIdBuku As TextBox
    Friend WithEvents labelJudulBuku As Label
    Friend WithEvents btnTambahPeminjaman As Button
    Friend WithEvents txtJudulBuku As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents IdpeminjamanDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents DataTable1BindingSource As BindingSource
    Friend WithEvents DataTable1TableAdapter As DataSet1TableAdapters.DataTable1TableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NamapetugasDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NamaanggotaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents JudulbukuDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TanggalpinjamDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TanggalkembaliDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
