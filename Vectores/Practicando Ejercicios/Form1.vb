Public Class Form1
    Dim n1, n2, n3 As Vector
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        n1 = New Vector
        n2 = New Vector
        n3 = New Vector
    End Sub

    Private Sub CargarRandomToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CargarRandomToolStripMenuItem.Click
        n1.CargarRandom(TextBox1.Text, TextBox2.Text, TextBox3.Text)
    End Sub

    Private Sub CargarManualToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CargarManualToolStripMenuItem.Click
        n1.CargarManual(TextBox1.Text)
    End Sub

    Private Sub PromedioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PromedioToolStripMenuItem.Click
        TextBox5.Text = n2.Promedio()
    End Sub

    Private Sub DesviacionMediaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DesviacionMediaToolStripMenuItem.Click
        TextBox5.Text = n2.DesviacionMedia()
    End Sub

    Private Sub VerficarPrimoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerficarPrimoToolStripMenuItem.Click
        TextBox5.Text = n2.VerfPrimo()
    End Sub

    Private Sub CuantosPrimosHayEnUnVectorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CuantosPrimosHayEnUnVectorToolStripMenuItem.Click
        TextBox5.Text = n2.CuantosPrimos()
    End Sub

    Private Sub EcontrarElElmentoMenorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EcontrarElElmentoMenorToolStripMenuItem.Click
        TextBox5.Text = n2.EncontrarElElementoMenor(TextBox2.Text)
    End Sub

    Private Sub VerificarsiestaordenadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerificarsiestaordenadoToolStripMenuItem.Click
        TextBox5.Text = n2.VerfOrdenado(TextBox2.Text, TextBox3.Text)
    End Sub

    Private Sub EliminarElementosdeunVectorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarElementosdeunVectorToolStripMenuItem.Click
        n2.EliminarElementoVector(TextBox2.Text, TextBox3.Text)

    End Sub

    Private Sub Lomismodearriba2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Lomismodearriba2ToolStripMenuItem.Click
        n2.EliminarElmentoVector2(TextBox2.Text, TextBox3.Text)
    End Sub

    Private Sub DescargarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DescargarToolStripMenuItem1.Click
        n2.CargarManual(TextBox3.Text)
    End Sub

    Private Sub CargarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CargarToolStripMenuItem.Click
        n3.CargarRandom(TextBox1.Text, TextBox2.Text, TextBox3.Text)
    End Sub

    Private Sub IntercalarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IntercalarToolStripMenuItem.Click
        TextBox5.Text = n2.Intercalar(n3)
    End Sub

    Private Sub OrdenamientoBurbujaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrdenamientoBurbujaToolStripMenuItem.Click
        n1.OrdenamientoBurbujaAscendete()
        TextBox5.Text = n1.Descagar()
    End Sub

    Private Sub OBDescendenteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OBDescendenteToolStripMenuItem.Click
        n1.OrdenamientoBurbujaDescendente()
        TextBox5.Text = n1.Descagar()
    End Sub

    Private Sub ImparToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImparToolStripMenuItem.Click
        TextBox5.Text = n1.VerfImpar()
    End Sub

    Private Sub OrdenamientoporintercambioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrdenamientoporintercambioToolStripMenuItem.Click
        n1.OrdenamientoPorIntercambioAscendente()
        TextBox5.Text = n1.Descagar()
    End Sub

    Private Sub InvertirrangoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InvertirrangoToolStripMenuItem.Click
        n1.InvertirElementosRango(TextBox2.Text, TextBox3.Text)
        TextBox5.Text = n1.Descagar()
    End Sub

    Private Sub SegmentarsinvectorauxliarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SegmentarsinvectorauxliarToolStripMenuItem.Click
        n1.Segmentarprimosinvectorauxiliar(TextBox2.Text, TextBox3.Text)
        TextBox5.Text = n1.Descagar()
    End Sub

    Private Sub IntercalarsinvectorauxiliarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IntercalarsinvectorauxiliarToolStripMenuItem.Click
        n1.IntercalarSinVectorAuxilar(TextBox2.Text, TextBox3.Text)
        TextBox5.Text = n1.Descagar()
    End Sub

    Private Sub ELMENTOSPRIMOSINREPORDENADOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ELMENTOSPRIMOSINREPORDENADOToolStripMenuItem.Click
        n1.ElmentPrimoOrdenado(n2)
        TextBox5.Text = n2.Descagar()
    End Sub

    Private Sub ElementomenosrepToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ElementomenosrepToolStripMenuItem.Click
        TextBox5.Text = n1.ElementoMenosRepetido(TextBox2.Text, TextBox3.Text)
    End Sub

    Private Sub PurgarelementprimosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PurgarelementprimosToolStripMenuItem.Click
        n1.PurgarElmentosPrimos(TextBox2.Text, TextBox3.Text)
        TextBox5.Text = n1.Descagar()
    End Sub

    Private Sub OrdenarmmultilplosdeXToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrdenarmmultilplosdeXToolStripMenuItem.Click

    End Sub

    Private Sub IntercalarelementmayormenorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IntercalarelementmayormenorToolStripMenuItem.Click
        n1.IntercalarElementoMayorMenor(TextBox2.Text, TextBox3.Text)
        TextBox5.Text = n1.Descagar()
    End Sub

    Private Sub OrdenamultiplosrangoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrdenamultiplosrangoToolStripMenuItem.Click
        n1.OrdenarMultiplosRango(TextBox2.Text, TextBox3.Text, TextBox6.Text)
        TextBox5.Text = n1.Descagar()
    End Sub

    Private Sub EliminarelmentrangoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarelmentrangoToolStripMenuItem.Click
        n1.EliminarMultiplosRango(TextBox2.Text, TextBox3.Text, TextBox6.Text)
        TextBox5.Text = n1.Descagar()
    End Sub

    Private Sub SegmenarPariMPARangoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SegmenarPariMPARangoToolStripMenuItem.Click
        n1.SegmentarParImparRango(TextBox2.Text, TextBox3.Text)
        TextBox5.Text = n1.Descagar()
    End Sub

    Private Sub RecorrerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RecorrerToolStripMenuItem.Click

    End Sub

    Private Sub InsertarotrovectorapartindeunaposToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InsertarotrovectorapartindeunaposToolStripMenuItem.Click
        n1.InsertarOtroVectorPos(TextBox2.Text, n2)
        TextBox7.Text = n1.Descagar()
    End Sub

    Private Sub DescargarToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles DescargarToolStripMenuItem2.Click
        TextBox5.Text = n2.Descagar()
    End Sub

    Private Sub DescargarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DescargarToolStripMenuItem.Click
        TextBox4.Text = n1.Descagar()
    End Sub
End Class
