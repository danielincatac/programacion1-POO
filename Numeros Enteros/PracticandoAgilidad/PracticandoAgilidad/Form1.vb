Public Class Form1
    Dim n1 As NEnt
    Dim n2 As NEnt
    Dim n3 As NEnt
    Dim n4 As NEnt
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        n1 = New NEnt
        n2 = New NEnt
        n3 = New NEnt
        n4 = New NEnt
    End Sub

    Private Sub CargarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CargarToolStripMenuItem.Click
        n1.Cargar(TextBox1.Text)
    End Sub

    Private Sub DescargarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DescargarToolStripMenuItem.Click
        TextBox2.Text = n1.Descargar()
    End Sub

    Private Sub FacToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FacToolStripMenuItem.Click
        TextBox2.Text = n1.Factorial()
    End Sub

    Private Sub PrimoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrimoToolStripMenuItem.Click
        TextBox2.Text = n1.VerfPrimo()
    End Sub

    Private Sub FiboToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FiboToolStripMenuItem.Click
        TextBox2.Text = n1.VerfFibo()
    End Sub

    Private Sub EliminardignumentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminardignumentToolStripMenuItem.Click
        TextBox2.Text = n1.EliminarDigNumEnt(TextBox1.Text)
    End Sub

    Private Sub EliminardignuementToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminardignuementToolStripMenuItem.Click
        TextBox2.Text = n1.eliminardigrepetidos(TextBox1.Text)
    End Sub

    Private Sub UltimofilaprimosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UltimofilaprimosToolStripMenuItem.Click
        TextBox2.Text = n1.Ultimafilaprimos()
    End Sub

    Private Sub ContardigdiferentesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContardigdiferentesToolStripMenuItem.Click
        TextBox2.Text = n1.ContarDigDiferente(TextBox3.Text)
    End Sub

    Private Sub RotarultimoprimeroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RotarultimoprimeroToolStripMenuItem.Click
        n1.rotardigultimodigaprimerapos()
        TextBox2.Text = n1.Descargar()
    End Sub

    Private Sub RotarprimeraultimoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RotarprimeraultimoToolStripMenuItem.Click
        n1.rotarprimerdigultimapos()
        TextBox2.Text = n1.Descargar()
    End Sub

    Private Sub VerificarsiestaordenadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerificarsiestaordenadoToolStripMenuItem.Click
        TextBox2.Text = n1.verificarsiestaordenadoND(TextBox3.Text)
    End Sub

    Private Sub VerificarsilosdigitosnoserepitenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerificarsilosdigitosnoserepitenToolStripMenuItem.Click
        TextBox2.Text = n1.Verificarsilosdigitosnoserepiten(TextBox3.Text)
    End Sub

    Private Sub SegmentarprimonoprimoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SegmentarprimonoprimoToolStripMenuItem.Click
        n1.Segmentarendigprimosynoprimos(TextBox3.Text)
        TextBox2.Text = n1.Descargar()
    End Sub

    Private Sub CortardigToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CortardigToolStripMenuItem.Click
        TextBox2.Text = n1.Cortardig(TextBox3.Text)
    End Sub

    Private Sub VerificarsiesfiboyelqsigaescontinuacionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerificarsiesfiboyelqsigaescontinuacionToolStripMenuItem.Click
        TextBox2.Text = n1.verificarfiboysielsguienteescontinuaciondelmprimerfibo(n2)
    End Sub

    Private Sub CargarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CargarToolStripMenuItem1.Click
        n2.Cargar(TextBox3.Text)
    End Sub

    Private Sub DescargarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DescargarToolStripMenuItem1.Click
        TextBox2.Text = n2.Descargar()
    End Sub

    Private Sub IntercalarNDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IntercalarNDToolStripMenuItem.Click
        TextBox2.Text = n1.IntecarlarND(TextBox3.Text, TextBox4.Text)
    End Sub

    Private Sub ProbandoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProbandoToolStripMenuItem.Click
        TextBox2.Text = n1.ParImparND(TextBox3.Text, n2)
        TextBox5.Text = n2.Descargar()
    End Sub

    Private Sub EliminarLosTerminosCentralesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarLosTerminosCentralesToolStripMenuItem.Click
        n1.Eliminarlosterminoscentrales()
        TextBox2.Text = n1.Descargar()
    End Sub

    Private Sub Mod1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Mod1ToolStripMenuItem.Click
        TextBox2.Text = n1.mod1()
    End Sub

    Private Sub SumaconexpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SumaconexpToolStripMenuItem.Click
        TextBox2.Text = n1.Exponenteconsumas(TextBox3.Text)
    End Sub

    Private Sub Prueba1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Prueba1ToolStripMenuItem.Click
        TextBox2.Text = n1.prueba1()
    End Sub

    Private Sub SegmentarcapinocapiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SegmentarcapinocapiToolStripMenuItem.Click
        n1.SegmentarCapicuaND(TextBox3.Text)
        TextBox2.Text = n1.Descargar()
    End Sub

    Private Sub IntercalarordenadomayormenorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IntercalarordenadomayormenorToolStripMenuItem.Click
        TextBox2.Text = n1.IntercalarOrdenado()
    End Sub

    Private Sub SegmentarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SegmentarToolStripMenuItem.Click
        n1.Segementar()
        TextBox2.Text = n1.Descargar()
    End Sub

    Private Sub AcumularfiboooooToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcumularfiboooooToolStripMenuItem.Click
        TextBox2.Text = n1.AcumulardigFIbooo()
    End Sub

    Private Sub ProbandosinbanderaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProbandosinbanderaToolStripMenuItem.Click
        TextBox2.Text = n1.SinPinponear()
    End Sub

    Private Sub InsertarEnOrdenUnDigEnteroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InsertarEnOrdenUnDigEnteroToolStripMenuItem.Click
        TextBox2.Text = n1.InsertarEnOrdenUnDigEntero(TextBox3.Text)
    End Sub

    Private Sub DigMENOSREPETIDOSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DigMENOSREPETIDOSToolStripMenuItem.Click
        n1.DigMenosRepetido()
    End Sub

    Private Sub Unir4numerosenordenascenteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Unir4numerosenordenascenteToolStripMenuItem.Click

    End Sub
    Private Sub DescargarToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles DescargarToolStripMenuItem2.Click
        TextBox2.Text = n3.Descargar()
    End Sub

    Private Sub CargarToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles CargarToolStripMenuItem3.Click
        n1.Cargar(TextBox4.Text)
    End Sub

    Private Sub CargarToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles CargarToolStripMenuItem2.Click
        n4.Cargar(TextBox6.Text)
    End Sub

    Private Sub VerifiarsegmentarprimosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerifiarsegmentarprimosToolStripMenuItem.Click
        TextBox2.Text = n1.VerificarSegmentar()
    End Sub

    Private Sub AcumularConFiboToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcumularConFiboToolStripMenuItem.Click
        TextBox2.Text = n1.AcumularConFibo()
    End Sub

    Private Sub Exmane1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Exmane1ToolStripMenuItem.Click
        TextBox2.Text = n1.AcumularConDigFibonacciii()
    End Sub
End Class
