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

    Private Sub Ejercicio1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Ejercicio1ToolStripMenuItem.Click
        TextBox2.Text = n1.VerficarFibonacci()
    End Sub

    Private Sub Ejercicio2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Ejercicio2ToolStripMenuItem.Click
        TextBox2.Text = n1.VerfNumPertSeriRegular(TextBox3.Text, TextBox4.Text)
    End Sub

    Private Sub Ejercicio3ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Ejercicio3ToolStripMenuItem.Click
        TextBox2.Text = n1.AccesardigNDIzaDer(TextBox3.Text)
    End Sub
    Private Sub ParToolStripMenuItem_Click(sender As Object, e As EventArgs)
        TextBox2.Text = n1.VerificarImpar(TextBox3.Text)
    End Sub

    Private Sub Ejercicio4ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Ejercicio4ToolStripMenuItem.Click
        TextBox2.Text = n1.FiltrardigImpar(TextBox3.Text)
    End Sub

    Private Sub Ejercicio5ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Ejercicio5ToolStripMenuItem.Click
        TextBox2.Text = n1.FiltrardigPrimo(TextBox3.Text)
    End Sub

    Private Sub Ejercicio6ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Ejercicio6ToolStripMenuItem.Click
        TextBox2.Text = n1.AcumularDigFibo()
    End Sub

    Private Sub Ejercocop8ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Ejercocop8ToolStripMenuItem.Click
        TextBox2.Text = n1.AcumulardigPrimo(TextBox3.Text)
    End Sub

    Private Sub Ejercicio9ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Ejercicio9ToolStripMenuItem.Click
        TextBox2.Text = n1.EncontrarMayorND(TextBox3.Text)
    End Sub

    Private Sub Ejercicio10ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Ejercicio10ToolStripMenuItem.Click
        TextBox2.Text = n1.Frecuencia(TextBox3.Text, TextBox4.Text)
    End Sub

    Private Sub Ejercicio7ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Ejercicio7ToolStripMenuItem.Click
        TextBox2.Text = n1.DecimalCualquierbase(TextBox3.Text)
    End Sub
End Class
