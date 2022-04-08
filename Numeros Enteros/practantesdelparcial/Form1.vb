Public Class Form1
    Dim n1 As NEnt
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        n1 = New NEnt
    End Sub

    Private Sub CargarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CargarToolStripMenuItem.Click
        n1.Cargar(TextBox1.Text)
    End Sub

    Private Sub DescargarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DescargarToolStripMenuItem.Click
        TextBox2.Text = n1.Descargar()
    End Sub

    Private Sub TestToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TestToolStripMenuItem.Click

    End Sub

    Private Sub SegmentarCapiyNoCapiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SegmentarCapiyNoCapiToolStripMenuItem.Click
        n1.SegmentarCapiNoCapiND(TextBox3.Text)
    End Sub

    Private Sub AcumularCToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcumularCToolStripMenuItem.Click
        TextBox2.Text = n1.AcumularConDigPrimos(TextBox3.Text)
    End Sub
End Class
