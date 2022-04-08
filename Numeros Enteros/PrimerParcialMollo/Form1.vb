Public Class Form1
    Dim n1, n2, n3, n4 As NEnt

    Private Sub CargarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CargarToolStripMenuItem1.Click
        n2.Cargar(TextBox3.Text)
    End Sub

    Private Sub DescargarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DescargarToolStripMenuItem1.Click
        TextBox2.Text = n2.Descargar()
    End Sub

    Private Sub CargarToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles CargarToolStripMenuItem2.Click
        n3.Cargar(TextBox4.Text)
    End Sub

    Private Sub DescargarToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles DescargarToolStripMenuItem2.Click
        TextBox2.Text = n3.Descargar()
    End Sub

    Private Sub CargarToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles CargarToolStripMenuItem3.Click
        n4.Cargar(TextBox5.Text)
    End Sub

    Private Sub DescargarToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles DescargarToolStripMenuItem3.Click
        TextBox2.Text = n4.Descargar()
    End Sub

    Private Sub EXAMEN1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EXAMEN1ToolStripMenuItem.Click
        TextBox2.Text = n1.AcumularConDigFibonacci()
    End Sub

    Private Sub EXAMEN2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EXAMEN2ToolStripMenuItem.Click
        TextBox2.Text = n1.OrndenardeFormaDescedente(n2, n3, n4)
    End Sub

    Private Sub MENUOBJETO3ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MENUOBJETO3ToolStripMenuItem.Click

    End Sub

    Private Sub DescargarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DescargarToolStripMenuItem.Click
        TextBox2.Text = n1.Descargar()
    End Sub

    Private Sub CargarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CargarToolStripMenuItem.Click
        n1.Cargar(TextBox1.Text)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        n1 = New NEnt
        n2 = New NEnt
        n3 = New NEnt
        n4 = New NEnt
    End Sub
End Class
