Public Class Form1
    Dim n1 As NEnt
    Dim n2 As NEnt
    Dim n3 As NEnt
    Dim n4 As NEnt
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        n1 = New NEnt
        n2 = New NEnt
        n3 = New NEnt
        n4 =New NEnt

    End Sub

    Private Sub CargarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CargarToolStripMenuItem.Click
        n1.Cargar(TextBox1.Text)
    End Sub

    Private Sub DescargarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DescargarToolStripMenuItem.Click
        TextBox2.Text = n1.Descargar()
    End Sub

    Private Sub EJERCICIOPR11ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EJERCICIOPR11ToolStripMenuItem.Click
        TextBox2.Text = n1.VerificarNEperteneceFibo()
    End Sub

    Private Sub EJERCICIOPR21ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EJERCICIOPR21ToolStripMenuItem.Click
        n1.EliminarDigitosRepetidos()
        TextBox2.Text = n1.Descargar()
    End Sub

    Private Sub EJERCICIOPR13ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EJERCICIOPR13ToolStripMenuItem.Click
        TextBox2.Text = n1.VerificarPerteneceSerieRegular(TextBox3.Text, TextBox4.Text)
    End Sub

    Private Sub EJERCICIOPR13ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EJERCICIOPR13ToolStripMenuItem1.Click
        TextBox2.Text = n1.AccecarDigitosDeIzaDeND(TextBox3.Text)
    End Sub

    Private Sub EJERCICIOPR44ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EJERCICIOPR44ToolStripMenuItem.Click
        TextBox2.Text = n1.FiltrarParesND(TextBox3.Text)
    End Sub

    Private Sub EJERCICIOPR15ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EJERCICIOPR15ToolStripMenuItem.Click
        TextBox2.Text = n1.FiltrarPrimosND(TextBox3.Text)
    End Sub

    Private Sub EJERCICIOPR16ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EJERCICIOPR16ToolStripMenuItem.Click
        TextBox2.Text = n1.AcumularDigitosFibonacci()
    End Sub

    Private Sub EJERCICIOPR17ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EJERCICIOPR17ToolStripMenuItem.Click
        TextBox2.Text = n1.Convertirdebase10acualquierbase(TextBox3.Text)
    End Sub

    Private Sub EJERCICIOPR18ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EJERCICIOPR18ToolStripMenuItem.Click
        TextBox2.Text = n1.AcumulardigitosprimosND(TextBox3.Text)
    End Sub

    Private Sub EJERCICIOPR19ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EJERCICIOPR19ToolStripMenuItem.Click
        TextBox2.Text = n1.EncontrarDigMayorND(TextBox3.Text)
    End Sub

    Private Sub EJERCICIOPR110ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EJERCICIOPR110ToolStripMenuItem.Click
        TextBox2.Text = n1.FrecuenciadigitosND(TextBox3.Text, TextBox4.Text)
    End Sub

    Private Sub EJERCICIOPR22ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EJERCICIOPR22ToolStripMenuItem.Click
        n1.SegmentarenDigitosRepetidosyUnicos()
        TextBox2.Text = n1.Descargar()
    End Sub

    Private Sub EJERCICIOPR23ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EJERCICIOPR23ToolStripMenuItem.Click
        n1.OrdenarMenorMayorNd(TextBox3.Text)
        TextBox2.Text = n1.Descargar()
    End Sub

    Private Sub EJERCICIOPR24ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EJERCICIOPR24ToolStripMenuItem.Click
        TextBox2.Text = n1.CambiarDigitoPorOtro(n2, n3)
    End Sub

    Private Sub CARGARToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CARGARToolStripMenuItem1.Click
        n2.Cargar(TextBox3.Text)
    End Sub

    Private Sub DESCARGARToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DESCARGARToolStripMenuItem1.Click
        TextBox2.Text = n2.Descargar()
    End Sub

    Private Sub CARGARToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles CARGARToolStripMenuItem2.Click
        n3.Cargar(TextBox4.Text)
    End Sub

    Private Sub DESCARGARToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles DESCARGARToolStripMenuItem2.Click
        TextBox2.Text = n3.Descargar()
    End Sub

    Private Sub EJERCICIOPR25ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EJERCICIOPR25ToolStripMenuItem.Click
        TextBox2.Text = n1.IntercalarParImpar(TextBox3.Text)
    End Sub

    Private Sub EJERCICIOPR26ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EJERCICIOPR26ToolStripMenuItem.Click
        TextBox2.Text = n1.UnirTresNumeroEnterosAscendente(n2, n3)
    End Sub

    Private Sub EJERCICIOPR27ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EJERCICIOPR27ToolStripMenuItem.Click
        TextBox2.Text = n1.DividirNumEntCuandoDigSeanIguales(n2)
        TextBox5.Text = n2.Descargar()
    End Sub

    Private Sub EJERCICIOPR28ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EJERCICIOPR28ToolStripMenuItem.Click
        TextBox2.Text = n1.VerificarTrica()
    End Sub

    Private Sub EJERCICIOPR29ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EJERCICIOPR29ToolStripMenuItem.Click
        TextBox2.Text = n1.VerificarDosPares()
    End Sub

    Private Sub EJERCICIOPR210ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EJERCICIOPR210ToolStripMenuItem.Click
        TextBox2.Text = n1.VerificarFull()
    End Sub

    Private Sub MenorDigToolStripMenuItem_Click(sender As Object, e As EventArgs)
        TextBox2.Text = n1.IntercalarND(TextBox3.Text, TextBox4.Text)
    End Sub
End Class
