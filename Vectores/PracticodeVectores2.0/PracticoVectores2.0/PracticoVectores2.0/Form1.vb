Public Class Form1
    Dim v1, v2, v3 As Vector

    Private Sub CargarManualToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CargarManualToolStripMenuItem.Click
        v1.CargarManual(TextBox1.Text)
    End Sub

    Private Sub CargarRandomToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CargarRandomToolStripMenuItem1.Click
        v2.CargarRandom(TextBox1.Text, TextBox2.Text, TextBox3.Text)
    End Sub

    Private Sub DescargarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DescargarToolStripMenuItem.Click
        TextBox4.Text = v1.Descargar()
    End Sub

    Private Sub DescargarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DescargarToolStripMenuItem1.Click
        TextBox5.Text = v2.Descargar()
    End Sub

    Private Sub CargarRandomToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles CargarRandomToolStripMenuItem2.Click
        v3.CargarRandom(TextBox1.Text, TextBox2.Text, TextBox3.Text)
    End Sub

    Private Sub CargarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CargarToolStripMenuItem.Click
        v3.CargarManual(TextBox1.Text)
    End Sub

    Private Sub DescargarToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles DescargarToolStripMenuItem2.Click
        TextBox6.Text = v3.Descargar()
    End Sub

    Private Sub Ejercicio1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Ejercicio1ToolStripMenuItem.Click
        v1.OrdenarElemntRangoAscendente(TextBox2.Text, TextBox3.Text)
        TextBox5.Text = v1.Descargar()
    End Sub

    Private Sub Ejercicio2ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles Ejercicio2ToolStripMenuItem1.Click
        v1.ConvertiraBaseB(TextBox2.Text, v2)
        TextBox5.Text = v2.Descargar()
    End Sub

    Private Sub Ejercicio3ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles Ejercicio3ToolStripMenuItem1.Click
        TextBox5.Text = v1.AcumulaElmentMultiX(TextBox2.Text)
    End Sub

    Private Sub Ejercicio4ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles Ejercicio4ToolStripMenuItem1.Click
        TextBox5.Text = v1.ElementoMenor(TextBox2.Text)
    End Sub

    Private Sub Ejercicio5ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles Ejercicio5ToolStripMenuItem1.Click
        v1.InterseccionDosVectores(v2, v3)
        TextBox6.Text = v3.Descargar()
    End Sub

    Private Sub Ejercicio6ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles Ejercicio6ToolStripMenuItem1.Click
        TextBox5.Text = v1.VerfOrdenadoAscendente(TextBox2.Text, TextBox3.Text)
    End Sub

    Private Sub Ejercicio7ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles Ejercicio7ToolStripMenuItem1.Click
        TextBox5.Text = v1.VerfPrimoRango(TextBox2.Text, TextBox3.Text)
    End Sub

    Private Sub Ejercicio9ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles Ejercicio9ToolStripMenuItem1.Click
        TextBox5.Text = v1.VerfElmentBase(TextBox2.Text)
    End Sub

    Private Sub Ejercicio10ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles Ejercicio10ToolStripMenuItem1.Click
        v1.InvertirElemRango(TextBox2.Text, TextBox3.Text)
        TextBox5.Text = v1.Descargar()
    End Sub

    Private Sub Ejercicio1ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles Ejercicio1ToolStripMenuItem1.Click
        TextBox5.Text = v1.AcumularConDigFibo()
    End Sub

    Private Sub Ejercicio2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Ejercicio2ToolStripMenuItem.Click
        v1.InsertarEnUnaPos(v2, TextBox3.Text)
        TextBox6.Text = v1.Descargar()
    End Sub

    Private Sub Ejercicio3ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Ejercicio3ToolStripMenuItem.Click
        v1.EliminarElemetRango(TextBox2.Text, TextBox3.Text)
        TextBox5.Text = v1.Descargar()
    End Sub

    Private Sub Ejercicio4ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Ejercicio4ToolStripMenuItem.Click
        TextBox5.Text = v1.ContarElementDiferentRango(TextBox2.Text, TextBox3.Text)
    End Sub

    Private Sub Ejercicio5ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Ejercicio5ToolStripMenuItem.Click
        v1.ElementoYFrecuenciaRango(TextBox2.Text, TextBox3.Text, v2, v3)
        TextBox5.Text = v2.Descargar()
        TextBox6.Text = v3.Descargar()
    End Sub

    Private Sub Ejercicio6ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Ejercicio6ToolStripMenuItem.Click
        TextBox5.Text = v1.ElementMenorRango(TextBox2.Text, TextBox3.Text)
    End Sub

    Private Sub Ejercicio8ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Ejercicio8ToolStripMenuItem.Click
        v1.SegmentarPriNoPriOrdenado(TextBox2.Text, TextBox3.Text)
        TextBox5.Text = v1.Descargar()
    End Sub

    Private Sub Ejercicio9ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Ejercicio9ToolStripMenuItem.Click
        v1.SegmentarRepYNoRepOrdenado()
        TextBox5.Text = v1.Descargar()
    End Sub

    Private Sub Ejercicio10ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Ejercicio10ToolStripMenuItem.Click
        v1.IntercalarPriNoPriOrdenado(TextBox2.Text, TextBox3.Text)
        TextBox5.Text = v1.Descargar()
    End Sub

    Private Sub Ejercicio8ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles Ejercicio8ToolStripMenuItem1.Click
        TextBox5.Text = v1.VerfIntercaladoParImpar()
    End Sub

    Private Sub CargarManualToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CargarManualToolStripMenuItem1.Click
        v2.CargarManual(TextBox2.Text)
    End Sub

    Private Sub CargarRandomToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CargarRandomToolStripMenuItem.Click
        v1.CargarRandom(TextBox1.Text, TextBox2.Text, TextBox3.Text)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        v1 = New Vector
        v2 = New Vector
        v3 = New Vector
    End Sub
End Class
