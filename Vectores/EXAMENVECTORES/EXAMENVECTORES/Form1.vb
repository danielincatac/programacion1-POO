Public Class Form1
    Dim v1, v2 As Vector

    Private Sub Ejercicio1ToolStripMenuItem_Click(sender As Object, e As EventArgs)
        v1.Pregunta11(TextBox2.Text, TextBox3.Text, TextBox4.Text)
        TextBox6.Text = v1.Descargar()
    End Sub

    Private Sub Ejercicio2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Ejercicio2ToolStripMenuItem.Click
        v1.Respuesta2(TextBox2.Text, TextBox3.Text, TextBox4.Text)
        TextBox6.Text = v1.Descargar()
    End Sub

    Private Sub CargarManualToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CargarManualToolStripMenuItem.Click
        v1.CargarManual(TextBox1.Text)
    End Sub

    Private Sub CargarRandomToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CargarRandomToolStripMenuItem.Click
        v1.CargarRandom(TextBox1.Text, TextBox2.Text, TextBox3.Text)
    End Sub

    Private Sub DescargarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DescargarToolStripMenuItem.Click
        TextBox5.Text = v1.Descargar()
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        v1.Pregunta11(TextBox2.Text, TextBox3.Text, TextBox4.Text)
        TextBox6.Text = v1.Descargar()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        v1 = New Vector
        v2 = New Vector
    End Sub

End Class
