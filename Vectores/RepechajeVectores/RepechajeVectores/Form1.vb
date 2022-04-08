Public Class Form1
    Dim v1, v2, v3 As Vector

    Private Sub CargarRandomToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CargarRandomToolStripMenuItem.Click
        v1.CargarRandom(TextBox1.Text, TextBox2.Text, TextBox3.Text)
    End Sub

    Private Sub CargarManualToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CargarManualToolStripMenuItem.Click
        v1.CargarManual(TextBox1.Text)
    End Sub

    Private Sub DescargarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DescargarToolStripMenuItem.Click
        TextBox4.Text = v1.Descargar()
    End Sub

    Private Sub EliminarRepDejarSoloUnoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarRepDejarSoloUnoToolStripMenuItem.Click
        v1.Pregunta1(TextBox2.Text, TextBox3.Text)
        TextBox5.Text = v1.Descargar()
    End Sub

    Private Sub EliminarPosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarPosToolStripMenuItem.Click
        v1.EliminarPos(TextBox2.Text)
        TextBox5.Text = v1.Descargar()
    End Sub

    Private Sub MayorEleMenorElemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MayorEleMenorElemToolStripMenuItem.Click
        v1.Pregunta2(TextBox2.Text, TextBox3.Text, v2, v3)
        TextBox5.Text = v2.Descargar()
        TextBox6.Text = v3.Descargar()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        v1 = New Vector
        v2 = New Vector
        v3 = New Vector
    End Sub
End Class
