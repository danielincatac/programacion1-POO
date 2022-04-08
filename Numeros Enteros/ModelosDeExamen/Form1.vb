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
        n1.SegmentarCapiNoCapiND(TextBox3.Text)
    End Sub

    Private Sub AcumularConDigitosPrimosNDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcumularConDigitosPrimosNDToolStripMenuItem.Click
        TextBox2.Text = n1.AcumularPrimoND(TextBox3.Text)
    End Sub
End Class
