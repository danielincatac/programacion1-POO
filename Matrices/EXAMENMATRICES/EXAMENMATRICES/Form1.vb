Public Class Form1
    Dim m1, m2 As Matriz

    Private Sub CARGARRANDOMToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CARGARRANDOMToolStripMenuItem.Click
        m1.CargarRandom(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text)
    End Sub

    Private Sub CARGARMANUALToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CARGARMANUALToolStripMenuItem.Click
        m1.CargarManual(TextBox1.Text, TextBox2.Text)
    End Sub

    Private Sub DESCARGARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DESCARGARToolStripMenuItem.Click
        TextBox5.Text = m1.Descargar()
    End Sub

    Private Sub Pregunta1ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles Pregunta1ToolStripMenuItem1.Click
        m1.Pregunta1()
        TextBox6.Text = m1.Descargar()
    End Sub

    Private Sub Pregunta2ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles Pregunta2ToolStripMenuItem1.Click
        m1.Pregunta2()
        TextBox6.Text = m1.Descargar()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        m1 = New Matriz
        m2 = New Matriz
    End Sub
End Class
