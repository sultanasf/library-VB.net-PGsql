Public Class FormUtama

    Private Sub btnBuku_Click(sender As Object, e As EventArgs) Handles btnBuku.Click
        Dim form = New Form1
        form.TopLevel = False
        form.FormBorderStyle = FormBorderStyle.None
        form.WindowState = FormWindowState.Maximized
        Panel2.Controls.Add(form)
        form.Show()
    End Sub
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        End
    End Sub
    Private Sub btnAnggota_Click(sender As Object, e As EventArgs) Handles btnAnggota.Click
        Dim form = New FormAnggota
        form.TopLevel = False
        form.FormBorderStyle = FormBorderStyle.None
        form.WindowState = FormWindowState.Maximized
        Panel2.Controls.Add(form)
        form.Show()
    End Sub
    Private Sub btnPetugas_Click(sender As Object, e As EventArgs) Handles btnPetugas.Click
        Dim form = New FormPetugas
        form.TopLevel = False
        form.FormBorderStyle = FormBorderStyle.None
        form.WindowState = FormWindowState.Maximized
        Panel2.Controls.Add(form)
        form.Show()
    End Sub
    Private Sub btnPeminjaman_Click(sender As Object, e As EventArgs) Handles btnPeminjaman.Click
        Dim form = New FormPeminjaman
        form.TopLevel = False
        form.FormBorderStyle = FormBorderStyle.None
        form.WindowState = FormWindowState.Maximized
        Panel2.Controls.Add(form)
        form.Show()
    End Sub
    Private Sub FormUtama_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim form = New FormPeminjaman
        form.TopLevel = False
        form.FormBorderStyle = FormBorderStyle.None
        form.WindowState = FormWindowState.Maximized
        Panel2.Controls.Add(form)
        form.Show()
    End Sub
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        End
    End Sub
End Class