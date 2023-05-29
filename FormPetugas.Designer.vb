<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPetugas
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
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.btnHapusPetugas = New System.Windows.Forms.Button()
        Me.btnCariPetugas = New System.Windows.Forms.Button()
        Me.btnTambahPetugas = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AlamatDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TanggallahirDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PetugasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New Perpus.DataSet1()
        Me.labelTahunTerbitBuku = New System.Windows.Forms.Label()
        Me.labelPenulisBuku = New System.Windows.Forms.Label()
        Me.txtAlamatPetugas = New System.Windows.Forms.TextBox()
        Me.txtNamaPetugas = New System.Windows.Forms.TextBox()
        Me.labelJudulBuku = New System.Windows.Forms.Label()
        Me.judulAnggota = New System.Windows.Forms.Label()
        Me.PetugasTableAdapter = New Perpus.DataSet1TableAdapters.petugasTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PetugasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(46, 373)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 26)
        Me.DateTimePicker1.TabIndex = 33
        Me.DateTimePicker1.Value = New Date(2023, 5, 28, 0, 0, 0, 0)
        '
        'btnHapusPetugas
        '
        Me.btnHapusPetugas.Location = New System.Drawing.Point(898, 539)
        Me.btnHapusPetugas.Name = "btnHapusPetugas"
        Me.btnHapusPetugas.Size = New System.Drawing.Size(145, 35)
        Me.btnHapusPetugas.TabIndex = 32
        Me.btnHapusPetugas.Text = "Hapus Petugas"
        Me.btnHapusPetugas.UseVisualStyleBackColor = True
        '
        'btnCariPetugas
        '
        Me.btnCariPetugas.Location = New System.Drawing.Point(291, 230)
        Me.btnCariPetugas.Name = "btnCariPetugas"
        Me.btnCariPetugas.Size = New System.Drawing.Size(77, 35)
        Me.btnCariPetugas.TabIndex = 31
        Me.btnCariPetugas.Text = "Cari"
        Me.btnCariPetugas.UseVisualStyleBackColor = True
        '
        'btnTambahPetugas
        '
        Me.btnTambahPetugas.Location = New System.Drawing.Point(46, 424)
        Me.btnTambahPetugas.Name = "btnTambahPetugas"
        Me.btnTambahPetugas.Size = New System.Drawing.Size(155, 37)
        Me.btnTambahPetugas.TabIndex = 30
        Me.btnTambahPetugas.Text = "Tambah Petugas"
        Me.btnTambahPetugas.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.NamaDataGridViewTextBoxColumn, Me.AlamatDataGridViewTextBoxColumn, Me.TanggallahirDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.PetugasBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(421, 172)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 30
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(622, 344)
        Me.DataGridView1.TabIndex = 29
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "id"
        Me.IdDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.Width = 150
        '
        'NamaDataGridViewTextBoxColumn
        '
        Me.NamaDataGridViewTextBoxColumn.DataPropertyName = "nama"
        Me.NamaDataGridViewTextBoxColumn.HeaderText = "nama"
        Me.NamaDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.NamaDataGridViewTextBoxColumn.Name = "NamaDataGridViewTextBoxColumn"
        Me.NamaDataGridViewTextBoxColumn.Width = 150
        '
        'AlamatDataGridViewTextBoxColumn
        '
        Me.AlamatDataGridViewTextBoxColumn.DataPropertyName = "alamat"
        Me.AlamatDataGridViewTextBoxColumn.HeaderText = "alamat"
        Me.AlamatDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.AlamatDataGridViewTextBoxColumn.Name = "AlamatDataGridViewTextBoxColumn"
        Me.AlamatDataGridViewTextBoxColumn.Width = 150
        '
        'TanggallahirDataGridViewTextBoxColumn
        '
        Me.TanggallahirDataGridViewTextBoxColumn.DataPropertyName = "tanggal_lahir"
        Me.TanggallahirDataGridViewTextBoxColumn.HeaderText = "tanggal_lahir"
        Me.TanggallahirDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.TanggallahirDataGridViewTextBoxColumn.Name = "TanggallahirDataGridViewTextBoxColumn"
        Me.TanggallahirDataGridViewTextBoxColumn.Width = 150
        '
        'PetugasBindingSource
        '
        Me.PetugasBindingSource.DataMember = "petugas"
        Me.PetugasBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'labelTahunTerbitBuku
        '
        Me.labelTahunTerbitBuku.AutoSize = True
        Me.labelTahunTerbitBuku.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelTahunTerbitBuku.Location = New System.Drawing.Point(42, 350)
        Me.labelTahunTerbitBuku.Name = "labelTahunTerbitBuku"
        Me.labelTahunTerbitBuku.Size = New System.Drawing.Size(78, 20)
        Me.labelTahunTerbitBuku.TabIndex = 28
        Me.labelTahunTerbitBuku.Text = "Tgl Lahir"
        '
        'labelPenulisBuku
        '
        Me.labelPenulisBuku.AutoSize = True
        Me.labelPenulisBuku.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelPenulisBuku.Location = New System.Drawing.Point(42, 281)
        Me.labelPenulisBuku.Name = "labelPenulisBuku"
        Me.labelPenulisBuku.Size = New System.Drawing.Size(65, 20)
        Me.labelPenulisBuku.TabIndex = 27
        Me.labelPenulisBuku.Text = "Alamat"
        '
        'txtAlamatPetugas
        '
        Me.txtAlamatPetugas.Location = New System.Drawing.Point(46, 304)
        Me.txtAlamatPetugas.Name = "txtAlamatPetugas"
        Me.txtAlamatPetugas.Size = New System.Drawing.Size(260, 26)
        Me.txtAlamatPetugas.TabIndex = 26
        '
        'txtNamaPetugas
        '
        Me.txtNamaPetugas.Location = New System.Drawing.Point(46, 234)
        Me.txtNamaPetugas.Name = "txtNamaPetugas"
        Me.txtNamaPetugas.Size = New System.Drawing.Size(226, 26)
        Me.txtNamaPetugas.TabIndex = 25
        '
        'labelJudulBuku
        '
        Me.labelJudulBuku.AutoSize = True
        Me.labelJudulBuku.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelJudulBuku.Location = New System.Drawing.Point(42, 211)
        Me.labelJudulBuku.Name = "labelJudulBuku"
        Me.labelJudulBuku.Size = New System.Drawing.Size(55, 20)
        Me.labelJudulBuku.TabIndex = 24
        Me.labelJudulBuku.Text = "Nama"
        '
        'judulAnggota
        '
        Me.judulAnggota.AutoSize = True
        Me.judulAnggota.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.judulAnggota.Location = New System.Drawing.Point(279, 56)
        Me.judulAnggota.Name = "judulAnggota"
        Me.judulAnggota.Size = New System.Drawing.Size(511, 40)
        Me.judulAnggota.TabIndex = 23
        Me.judulAnggota.Text = "PETUGAS PERPUSTAKAAN"
        '
        'PetugasTableAdapter
        '
        Me.PetugasTableAdapter.ClearBeforeFill = True
        '
        'FormPetugas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1084, 630)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.btnHapusPetugas)
        Me.Controls.Add(Me.btnCariPetugas)
        Me.Controls.Add(Me.btnTambahPetugas)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.labelTahunTerbitBuku)
        Me.Controls.Add(Me.labelPenulisBuku)
        Me.Controls.Add(Me.txtAlamatPetugas)
        Me.Controls.Add(Me.txtNamaPetugas)
        Me.Controls.Add(Me.labelJudulBuku)
        Me.Controls.Add(Me.judulAnggota)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormPetugas"
        Me.Text = "FormPetugas"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PetugasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents btnHapusPetugas As Button
    Friend WithEvents btnCariPetugas As Button
    Friend WithEvents btnTambahPetugas As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents labelTahunTerbitBuku As Label
    Friend WithEvents labelPenulisBuku As Label
    Friend WithEvents txtAlamatPetugas As TextBox
    Friend WithEvents txtNamaPetugas As TextBox
    Friend WithEvents labelJudulBuku As Label
    Friend WithEvents judulAnggota As Label
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents PetugasBindingSource As BindingSource
    Friend WithEvents PetugasTableAdapter As DataSet1TableAdapters.petugasTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NamaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AlamatDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TanggallahirDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
