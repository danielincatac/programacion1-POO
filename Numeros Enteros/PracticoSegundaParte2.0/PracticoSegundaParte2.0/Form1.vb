Public Class Form1

    Dim n1 As NEnt
    Dim n2 As NEnt
    Dim n3 As NEnt
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        n1 = New NEnt
        n2 = New NEnt
        n3 = New NEnt
    End Sub

    Private Sub CargarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CargarToolStripMenuItem.Click
        n1.Cargar(TextBox1.Text)
    End Sub

    Private Sub DescargarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DescargarToolStripMenuItem.Click
        TextBox2.Text = n1.Descargar()
    End Sub

    Private Sub Ejercicio1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Ejercicio1ToolStripMenuItem.Click
        n1.EliminarDigitosRepetidos()
    End Sub

    Private Sub Ejercicio2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Ejercicio2ToolStripMenuItem.Click
        n1.SegmentarenDigitosRepetidosyUnicos()
    End Sub


    Private Sub Ejercicio3ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Ejercicio3ToolStripMenuItem.Click
        n1.OrdenarMenorMayorNd(TextBox3.Text)
    End Sub

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

    Private Sub Ejercicio4ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Ejercicio4ToolStripMenuItem.Click
        TextBox2.Text = n1.CambiarDigitoPorOtro(n2, n3)
    End Sub

    Private Sub DasdToolStripMenuItem_Click(sender As Object, e As EventArgs)
        TextBox2.Text = n1.IntercalarND(TextBox3.Text, TextBox4.Text)
    End Sub

    Private Sub Ejercicio5ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Ejercicio5ToolStripMenuItem.Click
        TextBox2.Text = n1.IntercalarParImpar(TextBox3.Text)
    End Sub

    Private Sub AsdasdToolStripMenuItem_Click(sender As Object, e As EventArgs)
        TextBox2.Text = n1.IntercalarND(TextBox3.Text, TextBox4.Text)
    End Sub

    Private Sub Ejercicio6ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Ejercicio6ToolStripMenuItem.Click
        TextBox2.Text = n1.UnirTresNumeroEnterosAscendente(TextBox3.Text, TextBox4.Text)
    End Sub

    Private Sub Ejercicio7ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Ejercicio7ToolStripMenuItem.Click
        TextBox2.Text = n1.DividirNumEntCuandoDigSeanIguales(n2)
        TextBox5.Text = n2.Descargar()
    End Sub

    Private Sub Ejercicio8ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Ejercicio8ToolStripMenuItem.Click
        TextBox2.Text = n1.VerificarTrica()
    End Sub

    Private Sub Ejercicio9ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Ejercicio9ToolStripMenuItem.Click
        TextBox2.Text = n1.VerificarDosPares()
    End Sub

    Private Sub Ejercicio10ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Ejercicio10ToolStripMenuItem.Click
        TextBox2.Text = n1.VerificarFull()
    End Sub
End Class
