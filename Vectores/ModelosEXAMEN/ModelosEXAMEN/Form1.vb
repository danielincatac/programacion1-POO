Public Class Form1
    Dim v1, v2 As Vector
    Dim n1 As NEnt

    Private Sub CargarRandomToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CargarRandomToolStripMenuItem.Click
        v1.CargarRandom(TextBox1.Text, TextBox2.Text, TextBox3.Text)
    End Sub

    Private Sub CargarManualToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CargarManualToolStripMenuItem.Click
        v1.CargarManual(TextBox1.Text)
    End Sub

    Private Sub DescargarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DescargarToolStripMenuItem.Click
        TextBox5.Text = v1.Descargar()
    End Sub

    Private Sub IntercalarRepNoRepToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IntercalarRepNoRepToolStripMenuItem.Click
        v1.IntercalarRepNoRepOrdenado()
        TextBox6.Text = v1.Descargar()
    End Sub

    Private Sub EncontrarElemtoconmayorfrecuenciaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EncontrarElemtoconmayorfrecuenciaToolStripMenuItem.Click
        TextBox6.Text = v1.EncontrarEleMayorYFrecRango(TextBox2.Text, TextBox3.Text, n1)
        TextBox7.Text = n1.Descargar()
    End Sub

    Private Sub IntercalarRepNoRepRangoOrdenadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IntercalarRepNoRepRangoOrdenadoToolStripMenuItem.Click
        v1.IntercalarRepNoRepRangoOrdenado(TextBox2.Text, TextBox3.Text)
        TextBox6.Text = v1.Descargar()
    End Sub

    Private Sub SegmentarOrdenadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SegmentarOrdenadoToolStripMenuItem.Click
        v1.SegmentarOrdenado()
        TextBox6.Text = v1.Descargar()
    End Sub

    Private Sub SegmentarOrdenadoRangoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SegmentarOrdenadoRangoToolStripMenuItem.Click
        v1.SegmentarOrdenadoRango(TextBox2.Text, TextBox3.Text)
        TextBox6.Text = v1.Descargar()
    End Sub

    Private Sub RecorrerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RecorrerToolStripMenuItem.Click
        v1.Recorrer(TextBox2.Text)
        TextBox6.Text = v1.Descargar()
    End Sub

    Private Sub OrdenarMultiplosRangoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrdenarMultiplosRangoToolStripMenuItem.Click
        v1.OrdenarPosicionesMultiplRango(TextBox2.Text, TextBox3.Text, TextBox4.Text)
        TextBox6.Text = v1.Descargar()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        v1 = New Vector
        v2 = New Vector
        n1 = New NEnt
    End Sub
End Class
