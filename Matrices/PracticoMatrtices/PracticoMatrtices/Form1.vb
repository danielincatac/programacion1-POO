Public Class Form1
    Dim m1, m2, m3 As Matriz
    Dim v1, v2 As Vector
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        m1 = New Matriz
        m2 = New Matriz
        m3 = New Matriz
        v1 = New Vector
        v2 = New Vector
    End Sub
    Private Sub CargarRandomToolStripMenuItem_Click(sender As Object, e As EventArgs)
        m1.CargarRandom(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text)
    End Sub

    Private Sub CargarProgresivamenteToolStripMenuItem_Click(sender As Object, e As EventArgs)
        m1.CargarProgresivamente(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text)
    End Sub

    Private Sub CargarManualToolStripMenuItem_Click(sender As Object, e As EventArgs)
        m1.CargarManual(TextBox1.Text, TextBox2.Text)
    End Sub

    Private Sub Ejercicio4ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Ejercicio4ToolStripMenuItem.Click
        m1.ElementMayorFrecFila()
        TextBox6.Text = m1.Descargar()
    End Sub
    Private Sub Ejercicio6ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Ejercicio6ToolStripMenuItem.Click
        m1.OrdenarFilaCambiandoColumnas(TextBox3.Text)
        TextBox6.Text = m1.Descargar()
    End Sub

    Private Sub Ejercicio7ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Ejercicio7ToolStripMenuItem.Click
        TextBox7.Text = m1.VerfColumnaOrdenada()
    End Sub

    Private Sub Ejercicio8ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Ejercicio8ToolStripMenuItem.Click
        TextBox7.Text = m1.VerfOrdeandoAbajoIzquierda()
    End Sub

    Private Sub Ejercicio9ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Ejercicio9ToolStripMenuItem.Click
        TextBox7.Text = m1.VerfMatrizIncluidaEnOrtra(m2)
    End Sub

    Private Sub Ejercicio10ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Ejercicio10ToolStripMenuItem.Click
        m1.OrdenarFilasPorSumas()
        TextBox6.Text = m1.Descargar()
    End Sub

    Private Sub Ejercicio5ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Ejercicio5ToolStripMenuItem.Click
        m1.SegmentarParImparFila()
        TextBox6.Text = m1.Descargar()
    End Sub

    Private Sub DescargarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DescargarToolStripMenuItem.Click
        m1.CargarManual(TextBox1.Text, TextBox2.Text)
    End Sub

    Private Sub CargarManualToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles CargarManualToolStripMenuItem.Click
        m1.CargarRandom(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text)
    End Sub

    Private Sub CargarProgresivamenteToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles CargarProgresivamenteToolStripMenuItem.Click
        m1.CargarProgresivamente(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text)
    End Sub

    Private Sub DescargarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DescargarToolStripMenuItem1.Click
        TextBox5.Text = m1.Descargar()
    End Sub

    Private Sub Ejercicio2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Ejercicio2ToolStripMenuItem.Click
        TextBox7.Text = m1.ElementosUnicos()
    End Sub

    Private Sub Ejercicio1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Ejercicio1ToolStripMenuItem.Click
        TextBox7.Text = m1.AcumularPrimos()
    End Sub

    Private Sub Ejercicio3ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Ejercicio3ToolStripMenuItem.Click
        m1.ContElemPrimoUltimaFila()
        TextBox6.Text = m1.Descargar()
    End Sub
End Class
