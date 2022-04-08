Public Class Form1
    Dim m1, m2 As Matriz

    Private Sub CARGARMANUALToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CARGARMANUALToolStripMenuItem.Click
        m1.CargarManual(TextBox3.Text, TextBox4.Text)
    End Sub

    Private Sub DESCARGARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DESCARGARToolStripMenuItem.Click
        TextBox1.Text = m1.Descargar()
    End Sub

    Private Sub CARGARABAJODERECHAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CARGARABAJODERECHAToolStripMenuItem.Click
        m1.CargarAbajodDerecha(TextBox3.Text, TextBox4.Text)
    End Sub

    Private Sub CARGARPORCOLUMNASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CARGARPORCOLUMNASToolStripMenuItem.Click
        m1.CargarColumnas(TextBox3.Text, TextBox4.Text)
    End Sub

    Private Sub CARGARPORCOLUMNASABAJPDERECHAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CARGARPORCOLUMNASABAJPDERECHAToolStripMenuItem.Click
        m1.CargarColumnasAbajoDerecha(TextBox3.Text, TextBox4.Text)
    End Sub

    Private Sub VerfMayorFilaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerfMayorFilaToolStripMenuItem.Click
        TextBox2.Text = m1.VerfMayorFila(TextBox3.Text, TextBox4.Text)
    End Sub

    Private Sub VerfMenorColumnaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerfMenorColumnaToolStripMenuItem.Click
        TextBox2.Text = m1.VerfMenorColumna(TextBox3.Text, TextBox4.Text)
    End Sub

    Private Sub VerfMayorColumnaMenorFilaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerfMayorColumnaMenorFilaToolStripMenuItem.Click
        TextBox7.Text = m1.VerfMayorColumnaMenorFila()
    End Sub

    Private Sub CARGARSERPIENTEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CARGARSERPIENTEToolStripMenuItem.Click
        m1.CargarSerpiente(TextBox3.Text, TextBox4.Text)
        TextBox2.Text = m1.Descargar()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        m1 = New Matriz
        m2 = New Matriz
    End Sub
End Class
