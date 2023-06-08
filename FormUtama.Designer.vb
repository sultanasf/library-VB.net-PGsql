<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUtama
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormUtama))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnPeminjaman = New System.Windows.Forms.Button()
        Me.btnPetugas = New System.Windows.Forms.Button()
        Me.btnAnggota = New System.Windows.Forms.Button()
        Me.btnBuku = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel1.Controls.Add(Me.LinkLabel1)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.btnPeminjaman)
        Me.Panel1.Controls.Add(Me.btnPetugas)
        Me.Panel1.Controls.Add(Me.btnAnggota)
        Me.Panel1.Controls.Add(Me.btnBuku)
        Me.Panel1.Location = New System.Drawing.Point(1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(211, 652)
        Me.Panel1.TabIndex = 0
        '
        'LinkLabel1
        '
        Me.LinkLabel1.ActiveLinkColor = System.Drawing.Color.WhiteSmoke
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkColor = System.Drawing.Color.Black
        Me.LinkLabel1.Location = New System.Drawing.Point(89, 566)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(89, 29)
        Me.LinkLabel1.TabIndex = 0
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Keluar"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(38, 557)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(54, 48)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(6, 46)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(200, 100)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'btnPeminjaman
        '
        Me.btnPeminjaman.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnPeminjaman.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPeminjaman.Location = New System.Drawing.Point(9, 393)
        Me.btnPeminjaman.Name = "btnPeminjaman"
        Me.btnPeminjaman.Size = New System.Drawing.Size(194, 67)
        Me.btnPeminjaman.TabIndex = 7
        Me.btnPeminjaman.Text = "Peminjaman"
        Me.btnPeminjaman.UseVisualStyleBackColor = False
        '
        'btnPetugas
        '
        Me.btnPetugas.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnPetugas.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPetugas.Location = New System.Drawing.Point(9, 320)
        Me.btnPetugas.Name = "btnPetugas"
        Me.btnPetugas.Size = New System.Drawing.Size(194, 67)
        Me.btnPetugas.TabIndex = 6
        Me.btnPetugas.Text = "Petugas"
        Me.btnPetugas.UseVisualStyleBackColor = False
        '
        'btnAnggota
        '
        Me.btnAnggota.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAnggota.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAnggota.Location = New System.Drawing.Point(9, 247)
        Me.btnAnggota.Name = "btnAnggota"
        Me.btnAnggota.Size = New System.Drawing.Size(194, 67)
        Me.btnAnggota.TabIndex = 5
        Me.btnAnggota.Text = "Anggota"
        Me.btnAnggota.UseVisualStyleBackColor = False
        '
        'btnBuku
        '
        Me.btnBuku.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnBuku.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBuku.Location = New System.Drawing.Point(9, 174)
        Me.btnBuku.Name = "btnBuku"
        Me.btnBuku.Size = New System.Drawing.Size(194, 67)
        Me.btnBuku.TabIndex = 4
        Me.btnBuku.Text = "Buku"
        Me.btnBuku.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Location = New System.Drawing.Point(218, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1084, 630)
        Me.Panel2.TabIndex = 1
        '
        'FormUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(1314, 654)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormUtama"
        Me.Text = "FormUtama"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnPeminjaman As Button
    Friend WithEvents btnPetugas As Button
    Friend WithEvents btnAnggota As Button
    Friend WithEvents btnBuku As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents LinkLabel1 As LinkLabel
End Class
