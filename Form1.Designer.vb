<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JudulDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PenulisDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TahunterbitDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BukuBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New Perpus.DataSet1()
        Me.BukuTableAdapter = New Perpus.DataSet1TableAdapters.bukuTableAdapter()
        Me.judulBuku = New System.Windows.Forms.Label()
        Me.labelJudulBuku = New System.Windows.Forms.Label()
        Me.txtJudulBuku = New System.Windows.Forms.TextBox()
        Me.labelPenulisBuku = New System.Windows.Forms.Label()
        Me.labelTahunTerbitBuku = New System.Windows.Forms.Label()
        Me.txtTahunTerbitBuku = New System.Windows.Forms.TextBox()
        Me.btnCariBuku = New System.Windows.Forms.Button()
        Me.txtPenulisBuku = New System.Windows.Forms.TextBox()
        Me.btnHapusBuku = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BukuBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnTambah
        '
        Me.btnTambah.Location = New System.Drawing.Point(267, 262)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(141, 35)
        Me.btnTambah.TabIndex = 2
        Me.btnTambah.Text = "Tambah Buku"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.JudulDataGridViewTextBoxColumn, Me.PenulisDataGridViewTextBoxColumn, Me.TahunterbitDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.BukuBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(107, 323)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 30
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(896, 211)
        Me.DataGridView1.TabIndex = 3
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "id"
        Me.IdDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.Width = 150
        '
        'JudulDataGridViewTextBoxColumn
        '
        Me.JudulDataGridViewTextBoxColumn.DataPropertyName = "judul"
        Me.JudulDataGridViewTextBoxColumn.HeaderText = "judul"
        Me.JudulDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.JudulDataGridViewTextBoxColumn.Name = "JudulDataGridViewTextBoxColumn"
        Me.JudulDataGridViewTextBoxColumn.Width = 150
        '
        'PenulisDataGridViewTextBoxColumn
        '
        Me.PenulisDataGridViewTextBoxColumn.DataPropertyName = "penulis"
        Me.PenulisDataGridViewTextBoxColumn.HeaderText = "penulis"
        Me.PenulisDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.PenulisDataGridViewTextBoxColumn.Name = "PenulisDataGridViewTextBoxColumn"
        Me.PenulisDataGridViewTextBoxColumn.Width = 150
        '
        'TahunterbitDataGridViewTextBoxColumn
        '
        Me.TahunterbitDataGridViewTextBoxColumn.DataPropertyName = "tahun_terbit"
        Me.TahunterbitDataGridViewTextBoxColumn.HeaderText = "tahun_terbit"
        Me.TahunterbitDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.TahunterbitDataGridViewTextBoxColumn.Name = "TahunterbitDataGridViewTextBoxColumn"
        Me.TahunterbitDataGridViewTextBoxColumn.Width = 150
        '
        'BukuBindingSource
        '
        Me.BukuBindingSource.DataMember = "buku"
        Me.BukuBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BukuTableAdapter
        '
        Me.BukuTableAdapter.ClearBeforeFill = True
        '
        'judulBuku
        '
        Me.judulBuku.AutoSize = True
        Me.judulBuku.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.judulBuku.Location = New System.Drawing.Point(400, 25)
        Me.judulBuku.Name = "judulBuku"
        Me.judulBuku.Size = New System.Drawing.Size(292, 40)
        Me.judulBuku.TabIndex = 4
        Me.judulBuku.Text = "KOLEKSI BUKU"
        '
        'labelJudulBuku
        '
        Me.labelJudulBuku.AutoSize = True
        Me.labelJudulBuku.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelJudulBuku.Location = New System.Drawing.Point(117, 111)
        Me.labelJudulBuku.Name = "labelJudulBuku"
        Me.labelJudulBuku.Size = New System.Drawing.Size(98, 20)
        Me.labelJudulBuku.TabIndex = 5
        Me.labelJudulBuku.Text = "Judul Buku"
        '
        'txtJudulBuku
        '
        Me.txtJudulBuku.Location = New System.Drawing.Point(267, 108)
        Me.txtJudulBuku.Name = "txtJudulBuku"
        Me.txtJudulBuku.Size = New System.Drawing.Size(272, 26)
        Me.txtJudulBuku.TabIndex = 6
        '
        'labelPenulisBuku
        '
        Me.labelPenulisBuku.AutoSize = True
        Me.labelPenulisBuku.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelPenulisBuku.Location = New System.Drawing.Point(117, 163)
        Me.labelPenulisBuku.Name = "labelPenulisBuku"
        Me.labelPenulisBuku.Size = New System.Drawing.Size(118, 20)
        Me.labelPenulisBuku.TabIndex = 8
        Me.labelPenulisBuku.Text = "Nama Penulis"
        '
        'labelTahunTerbitBuku
        '
        Me.labelTahunTerbitBuku.AutoSize = True
        Me.labelTahunTerbitBuku.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelTahunTerbitBuku.Location = New System.Drawing.Point(117, 217)
        Me.labelTahunTerbitBuku.Name = "labelTahunTerbitBuku"
        Me.labelTahunTerbitBuku.Size = New System.Drawing.Size(110, 20)
        Me.labelTahunTerbitBuku.TabIndex = 9
        Me.labelTahunTerbitBuku.Text = "Tahun Terbit"
        '
        'txtTahunTerbitBuku
        '
        Me.txtTahunTerbitBuku.Location = New System.Drawing.Point(267, 214)
        Me.txtTahunTerbitBuku.Name = "txtTahunTerbitBuku"
        Me.txtTahunTerbitBuku.Size = New System.Drawing.Size(162, 26)
        Me.txtTahunTerbitBuku.TabIndex = 10
        '
        'btnCariBuku
        '
        Me.btnCariBuku.Location = New System.Drawing.Point(566, 104)
        Me.btnCariBuku.Name = "btnCariBuku"
        Me.btnCariBuku.Size = New System.Drawing.Size(113, 35)
        Me.btnCariBuku.TabIndex = 11
        Me.btnCariBuku.Text = "Cari Buku"
        Me.btnCariBuku.UseVisualStyleBackColor = True
        '
        'txtPenulisBuku
        '
        Me.txtPenulisBuku.Location = New System.Drawing.Point(267, 160)
        Me.txtPenulisBuku.Name = "txtPenulisBuku"
        Me.txtPenulisBuku.Size = New System.Drawing.Size(341, 26)
        Me.txtPenulisBuku.TabIndex = 7
        '
        'btnHapusBuku
        '
        Me.btnHapusBuku.Location = New System.Drawing.Point(875, 551)
        Me.btnHapusBuku.Name = "btnHapusBuku"
        Me.btnHapusBuku.Size = New System.Drawing.Size(128, 35)
        Me.btnHapusBuku.TabIndex = 12
        Me.btnHapusBuku.Text = "Hapus Buku"
        Me.btnHapusBuku.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(107, 540)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(144, 24)
        Me.CheckBox1.TabIndex = 13
        Me.CheckBox1.Text = "Ada dalam Rak"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1084, 630)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.btnHapusBuku)
        Me.Controls.Add(Me.btnCariBuku)
        Me.Controls.Add(Me.txtTahunTerbitBuku)
        Me.Controls.Add(Me.labelTahunTerbitBuku)
        Me.Controls.Add(Me.labelPenulisBuku)
        Me.Controls.Add(Me.txtPenulisBuku)
        Me.Controls.Add(Me.txtJudulBuku)
        Me.Controls.Add(Me.labelJudulBuku)
        Me.Controls.Add(Me.judulBuku)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnTambah)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BukuBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnTambah As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents BukuBindingSource As BindingSource
    Friend WithEvents BukuTableAdapter As DataSet1TableAdapters.bukuTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents JudulDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PenulisDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TahunterbitDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents judulBuku As Label
    Friend WithEvents labelJudulBuku As Label
    Friend WithEvents txtJudulBuku As TextBox
    Friend WithEvents labelPenulisBuku As Label
    Friend WithEvents labelTahunTerbitBuku As Label
    Friend WithEvents txtTahunTerbitBuku As TextBox
    Friend WithEvents btnCariBuku As Button
    Friend WithEvents txtPenulisBuku As TextBox
    Friend WithEvents btnHapusBuku As Button
    Friend WithEvents CheckBox1 As CheckBox
End Class
