Public Class Form1
    Dim m1, m2 As Matriz

    Private Sub CARGARMANUALToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CARGARMANUALToolStripMenuItem.Click
        m1.CargarManual(TextBox1.Text, TextBox2.Text)
    End Sub

    Private Sub DESCARGARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DESCARGARToolStripMenuItem.Click
        TextBox5.Text = m1.Descargar()
    End Sub

    Private Sub AÑADIRULTIMAFILAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AÑADIRULTIMAFILAToolStripMenuItem.Click
        m1.FilaUltima()
        TextBox6.Text = m1.Descargar()
    End Sub

    Private Sub AÑADIRULTIMACOLUMNAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AÑADIRULTIMACOLUMNAToolStripMenuItem.Click
        m1.UltimaColumna()
        TextBox6.Text = m1.Descargar()
    End Sub

    Private Sub PRIMERAFILAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PRIMERAFILAToolStripMenuItem.Click
        m1.PrimeraFila()
        TextBox6.Text = m1.Descargar()
    End Sub

    Private Sub PRIMERACOLUMNAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PRIMERACOLUMNAToolStripMenuItem.Click
        m1.PrimeraColumna()
        TextBox6.Text = m1.Descargar()
    End Sub

    Private Sub INSERTARCOLUMNANDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles INSERTARCOLUMNANDToolStripMenuItem.Click
        m1.InsertarColumnaND(TextBox3.Text)
        TextBox6.Text = m1.Descargar()
    End Sub

    Private Sub INSERTARFILANDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles INSERTARFILANDToolStripMenuItem.Click
        m1.InsertarFilaND(TextBox3.Text)
        TextBox6.Text = m1.Descargar()
    End Sub

    Private Sub ELIMINARFILANDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ELIMINARFILANDToolStripMenuItem.Click
        m1.EliminarFilaND(TextBox3.Text)
        TextBox6.Text = m1.Descargar()
    End Sub

    Private Sub ELIMINARCOLUMNANDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ELIMINARCOLUMNANDToolStripMenuItem.Click
        m1.EliminarColumnaND(TextBox3.Text)
        TextBox6.Text = m1.Descargar()
    End Sub

    Private Sub ORDENARLADIAGONALPRINCIPALToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ORDENARLADIAGONALPRINCIPALToolStripMenuItem.Click
        m1.OrdenarDiagonal()
        TextBox6.Text = m1.Descargar()
    End Sub

    Private Sub ORDENARLADIAGONALSECUNDARIAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ORDENARLADIAGONALSECUNDARIAToolStripMenuItem.Click
        m1.OrdenarDiagonalSec()
        TextBox6.Text = m1.Descargar()
    End Sub



    Private Sub ORDENARDESCENDENTEMENTECOLUMNASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ORDENARDESCENDENTEMENTECOLUMNASToolStripMenuItem.Click
        m1.OrdenarColDescen()
        TextBox6.Text = m1.Descargar()
    End Sub

    Private Sub ORDENARASCENDENTEMENTEFILASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ORDENARASCENDENTEMENTEFILASToolStripMenuItem.Click
        m1.OrdenarFilasAscen()
        TextBox6.Text = m1.Descargar()
    End Sub

    Private Sub ORDENARLAMATRIZASCENDENTEMENTEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ORDENARLAMATRIZASCENDENTEMENTEToolStripMenuItem.Click
        m1.OrdenarMatrizAscen()
        TextBox6.Text = m1.Descargar()
    End Sub

    Private Sub ORDENARLAMATRIZASCENDENTEMENTEFILAESQUINADERECHAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ORDENARLAMATRIZASCENDENTEMENTEFILAESQUINADERECHAToolStripMenuItem.Click
        m1.OrdenarMatrizFDAscen()
        TextBox6.Text = m1.Descargar()
    End Sub

    Private Sub ORDENARLAMATRIZASCENDENTEMENTEULTIMAFILAPRIMERACOLUMNAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ORDENARLAMATRIZASCENDENTEMENTEULTIMAFILAPRIMERACOLUMNAToolStripMenuItem.Click
        m1.OrdenarMatrizFIzAbajo()
        TextBox6.Text = m1.Descargar()
    End Sub

    Private Sub ORDENARLAMATRIZASCENDENTEMENTEULTIMAFILAULTIMACOLUMNAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ORDENARLAMATRIZASCENDENTEMENTEULTIMAFILAULTIMACOLUMNAToolStripMenuItem.Click
        m1.OrdenarMatrizFULCOLUL()
        TextBox6.Text = m1.Descargar()
    End Sub

    Private Sub ORDENARLAMATRIZDIAGONALSUPERIORPORCOLUMNASTOMANDOLADIAGONALPRINCIPALToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ORDENARLAMATRIZDIAGONALSUPERIORPORCOLUMNASTOMANDOLADIAGONALPRINCIPALToolStripMenuItem.Click
        m1.OrdenarTSCol()
        TextBox6.Text = m1.Descargar()
    End Sub

    Private Sub ORDENARLAMATRIZDIAGONALSUPERIORPORCOLUMNASSINTOMARLADIAGONALPRINCIPALToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ORDENARLAMATRIZDIAGONALSUPERIORPORCOLUMNASSINTOMARLADIAGONALPRINCIPALToolStripMenuItem.Click
        m1.OrdenarTSColSinDP()
        TextBox6.Text = m1.Descargar()
    End Sub

    Private Sub CARGARRANDOMToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CARGARRANDOMToolStripMenuItem.Click
        m1.CargarRandom(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text)
    End Sub

    Private Sub ORDENARLAMATRIZDIAGONALIZQPORFILASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ORDENARLAMATRIZDIAGONALIZQPORFILASToolStripMenuItem.Click
        m1.OrdenarDGIzq()
        TextBox6.Text = m1.Descargar()
    End Sub

    Private Sub ORDENARLAMATRIZTRINGULARSUPERIORDERECHAPORFILASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ORDENARLAMATRIZTRINGULARSUPERIORDERECHAPORFILASToolStripMenuItem.Click
        m1.OrdenarTSD()
        TextBox6.Text = m1.Descargar()
    End Sub

    Private Sub ELIMINARTRIANGULARINFERIORIZQUIERDAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ELIMINARTRIANGULARINFERIORIZQUIERDAToolStripMenuItem.Click
        m1.EliminarTIIZ()
        TextBox6.Text = m1.Descargar()
    End Sub

    Private Sub ELIMINARLATRIANGULARSUPERIORDERECHAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ELIMINARLATRIANGULARSUPERIORDERECHAToolStripMenuItem.Click
        m1.EliminarTSD()
        TextBox6.Text = m1.Descargar()
    End Sub

    Private Sub OrdenarColumnasParesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrdenarColumnasParesToolStripMenuItem.Click
        m1.OrdenarColumnasSoloPares()
        TextBox6.Text = m1.Descargar()
    End Sub

    Private Sub FRECUENCIAYELEMENTOENLAULTIMAFILAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FRECUENCIAYELEMENTOENLAULTIMAFILAToolStripMenuItem.Click
        m1.FrecuenciaYElementUltiFil()
        TextBox6.Text = m1.Descargar()
    End Sub

    Private Sub INTERCAMBIARELEMENTOSPARESPORCOLUMNASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles INTERCAMBIARELEMENTOSPARESPORCOLUMNASToolStripMenuItem.Click
        m1.OrdenarColPorElemPares()
        TextBox6.Text = m1.Descargar()
    End Sub

    Private Sub ORDENARELSEGMENTODELAMATRIZDEFORMAASCENDENTEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ORDENARELSEGMENTODELAMATRIZDEFORMAASCENDENTEToolStripMenuItem.Click
        m1.OrdenarSegementoAscen(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text)
        TextBox6.Text = m1.Descargar()
    End Sub

    Private Sub ELEMENTOFRECUENCIADELACOLUMNADELAMATRIZSEGMENTADAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ELEMENTOFRECUENCIADELACOLUMNADELAMATRIZSEGMENTADAToolStripMenuItem.Click
        m1.FrecuenciaElementDelSegmento(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text)
        TextBox6.Text = m1.Descargar()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        m1 = New Matriz
        m2 = New Matriz
    End Sub
End Class
