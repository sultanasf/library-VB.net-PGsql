<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAnggota
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.judulAnggota = New System.Windows.Forms.Label()
        Me.labelTahunTerbitBuku = New System.Windows.Forms.Label()
        Me.labelPenulisBuku = New System.Windows.Forms.Label()
        Me.txtAlamatAnggota = New System.Windows.Forms.TextBox()
        Me.txtNamaAnggota = New System.Windows.Forms.TextBox()
        Me.labelJudulBuku = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AlamatDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TanggallahirDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AnggotaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New Perpus.DataSet1()
        Me.AnggotaTableAdapter = New Perpus.DataSet1TableAdapters.anggotaTableAdapter()
        Me.btnTambahAnggota = New System.Windows.Forms.Button()
        Me.btnCariAnggota = New System.Windows.Forms.Button()
        Me.btnHapusAnggota = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AnggotaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'judulAnggota
        '
        Me.judulAnggota.AutoSize = True
        Me.judulAnggota.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.judulAnggota.Location = New System.Drawing.Point(266, 25)
        Me.judulAnggota.Name = "judulAnggota"
        Me.judulAnggota.Size = New System.Drawing.Size(519, 40)
        Me.judulAnggota.TabIndex = 5
        Me.judulAnggota.Text = "ANGGOTA PERPUSTAKAAN"
        '
        'labelTahunTerbitBuku
        '
        Me.labelTahunTerbitBuku.AutoSize = True
        Me.labelTahunTerbitBuku.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelTahunTerbitBuku.Location = New System.Drawing.Point(33, 319)
        Me.labelTahunTerbitBuku.Name = "labelTahunTerbitBuku"
        Me.labelTahunTerbitBuku.Size = New System.Drawing.Size(78, 20)
        Me.labelTahunTerbitBuku.TabIndex = 16
        Me.labelTahunTerbitBuku.Text = "Tgl Lahir"
        '
        'labelPenulisBuku
        '
        Me.labelPenulisBuku.AutoSize = True
        Me.labelPenulisBuku.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelPenulisBuku.Location = New System.Drawing.Point(33, 250)
        Me.labelPenulisBuku.Name = "labelPenulisBuku"
        Me.labelPenulisBuku.Size = New System.Drawing.Size(65, 20)
        Me.labelPenulisBuku.TabIndex = 15
        Me.labelPenulisBuku.Text = "Alamat"
        '
        'txtAlamatAnggota
        '
        Me.txtAlamatAnggota.Location = New System.Drawing.Point(37, 273)
        Me.txtAlamatAnggota.Name = "txtAlamatAnggota"
        Me.txtAlamatAnggota.Size = New System.Drawing.Size(260, 26)
        Me.txtAlamatAnggota.TabIndex = 14
        '
        'txtNamaAnggota
        '
        Me.txtNamaAnggota.Location = New System.Drawing.Point(37, 203)
        Me.txtNamaAnggota.Name = "txtNamaAnggota"
        Me.txtNamaAnggota.Size = New System.Drawing.Size(226, 26)
        Me.txtNamaAnggota.TabIndex = 13
        '
        'labelJudulBuku
        '
        Me.labelJudulBuku.AutoSize = True
        Me.labelJudulBuku.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelJudulBuku.Location = New System.Drawing.Point(33, 180)
        Me.labelJudulBuku.Name = "labelJudulBuku"
        Me.labelJudulBuku.Size = New System.Drawing.Size(55, 20)
        Me.labelJudulBuku.TabIndex = 12
        Me.labelJudulBuku.Text = "Nama"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.NamaDataGridViewTextBoxColumn, Me.AlamatDataGridViewTextBoxColumn, Me.TanggallahirDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.AnggotaBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(412, 141)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 30
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(622, 344)
        Me.DataGridView1.TabIndex = 18
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
        'AnggotaBindingSource
        '
        Me.AnggotaBindingSource.DataMember = "anggota"
        Me.AnggotaBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AnggotaTableAdapter
        '
        Me.AnggotaTableAdapter.ClearBeforeFill = True
        '
        'btnTambahAnggota
        '
        Me.btnTambahAnggota.Location = New System.Drawing.Point(37, 393)
        Me.btnTambahAnggota.Name = "btnTambahAnggota"
        Me.btnTambahAnggota.Size = New System.Drawing.Size(155, 37)
        Me.btnTambahAnggota.TabIndex = 19
        Me.btnTambahAnggota.Text = "Tambah Anggota"
        Me.btnTambahAnggota.UseVisualStyleBackColor = True
        '
        'btnCariAnggota
        '
        Me.btnCariAnggota.Location = New System.Drawing.Point(282, 199)
        Me.btnCariAnggota.Name = "btnCariAnggota"
        Me.btnCariAnggota.Size = New System.Drawing.Size(77, 35)
        Me.btnCariAnggota.TabIndex = 20
        Me.btnCariAnggota.Text = "Cari"
        Me.btnCariAnggota.UseVisualStyleBackColor = True
        '
        'btnHapusAnggota
        '
        Me.btnHapusAnggota.Location = New System.Drawing.Point(889, 508)
        Me.btnHapusAnggota.Name = "btnHapusAnggota"
        Me.btnHapusAnggota.Size = New System.Drawing.Size(145, 35)
        Me.btnHapusAnggota.TabIndex = 21
        Me.btnHapusAnggota.Text = "Hapus Anggota"
        Me.btnHapusAnggota.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(37, 342)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 26)
        Me.DateTimePicker1.TabIndex = 22
        Me.DateTimePicker1.Value = New Date(2023, 5, 28, 0, 0, 0, 0)
        '
        'FormAnggota
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1084, 630)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.btnHapusAnggota)
        Me.Controls.Add(Me.btnCariAnggota)
        Me.Controls.Add(Me.btnTambahAnggota)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.labelTahunTerbitBuku)
        Me.Controls.Add(Me.labelPenulisBuku)
        Me.Controls.Add(Me.txtAlamatAnggota)
        Me.Controls.Add(Me.txtNamaAnggota)
        Me.Controls.Add(Me.labelJudulBuku)
        Me.Controls.Add(Me.judulAnggota)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormAnggota"
        Me.Text = "FormAnggota"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AnggotaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents judulAnggota As Label
    Friend WithEvents labelTahunTerbitBuku As Label
    Friend WithEvents labelPenulisBuku As Label
    Friend WithEvents txtAlamatAnggota As TextBox
    Friend WithEvents txtNamaAnggota As TextBox
    Friend WithEvents labelJudulBuku As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents AnggotaBindingSource As BindingSource
    Friend WithEvents AnggotaTableAdapter As DataSet1TableAdapters.anggotaTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NamaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AlamatDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TanggallahirDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btnTambahAnggota As Button
    Friend WithEvents btnCariAnggota As Button
    Friend WithEvents btnHapusAnggota As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
End Class
