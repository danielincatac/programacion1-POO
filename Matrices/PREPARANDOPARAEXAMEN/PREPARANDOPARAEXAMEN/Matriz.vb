Public Class Matriz
    Const MAXF = 100
    Const MAXC = 100
    Private M(MAXF, MAXC) As Integer
    Private f, c As Integer
    Public Sub Matriz()
        f = 0 : c = 0
    End Sub
    Public Sub CargarManual(nf As Integer, nc As Integer)
        Dim f1, c1 As Integer
        f1 = 0 : c1 = 0 : f = nf : c = nc
        For f1 = 1 To f
            For c1 = 1 To c
                M(f1, c1) = InputBox("", "", "")
            Next
        Next
    End Sub
    Public Function Descargar() As String
        Dim f1, c1 As Integer
        Dim s As String = ""
        f1 = 0 : c1 = 0
        For f1 = 1 To f
            For c1 = 1 To c
                s = s + CStr(M(f1, c1)) + "  ;  "
            Next
            s = s + Chr(13) + Chr(10)
        Next
        Return s
    End Function
    Public Sub CargarRandom(nf As Integer, nc As Integer, a As Integer, b As Integer)
        Dim f1, c1 As Integer
        f = nf : c = nc
        For f1 = 1 To f
            For c1 = 1 To c
                M(f1, c1) = a + Rnd() * (b - a)
            Next
        Next
    End Sub
    'INSERTAR UNA FILA AL FINAL DE LA MATRIZ'
    Public Sub FilaUltima()
        Dim c1 As Integer
        f = f + 1 : c1 = 0
        For c1 = 1 To c
            M(f, c1) = InputBox("", "", "")
        Next
    End Sub
    'INTERCAMBIO'
    Public Sub Intercambio(fi As Integer, ci As Integer, ff As Integer, cf As Integer)
        Dim aux As Integer = 0
        aux = M(fi, ci)
        M(fi, ci) = M(ff, cf)
        M(ff, cf) = aux
    End Sub
    'INSERTAR UNA COLUMNA AL FINAL DE LA MATRIZ'
    Public Sub UltimaColumna()
        Dim f1 As Integer
        f1 = 0 : c = c + 1
        For f1 = 1 To f
            M(f1, c) = InputBox("", "", "")
        Next
    End Sub
    'INSERTAR UNA FILA EN LA PRIMERA FILA'
    Public Sub PrimeraFila()
        Dim c1, f1, i As Integer
        f = f + 1 : c1 = 1 : f1 = 1 : i = 1
        For f1 = f To 1 Step -1
            For c1 = 1 To c
                If (f1 = 1) Then
                    M(f1, c1) = InputBox("", "", "")
                Else
                    Intercambio(f1, c1, (f1 - 1), c1)
                End If
            Next
        Next
    End Sub
    'INSERTAR UNA COLUMNA EN LA PRIMERA COLUMNA'
    Public Sub PrimeraColumna()
        Dim f1, c1 As Integer
        c = c + 1 : f1 = 0 : c1 = 0
        For c1 = c To 1 Step -1
            For f1 = 1 To f
                If (c1 = 1) Then
                    M(f1, c1) = InputBox("", "", "")
                Else
                    Intercambio(f1, (c1 - 1), f1, c1)
                End If
            Next
        Next
    End Sub
    'INSERTAR COLUMNA DE N'
    Public Sub InsertarColumnaND(ci As Integer)
        Dim f1, c1 As Integer
        f1 = 0 : c1 = 0 : c = c + 1
        For c1 = c To ci Step -1
            For f1 = 1 To f
                If (c1 = ci) Then
                    M(f1, c1) = InputBox("", "", "")
                Else
                    Intercambio(f1, (c1 - 1), f1, c1)
                End If
            Next
        Next
    End Sub
    'INSERTAR FILA DE N'
    Public Sub InsertarFilaND(fi As Integer)
        Dim f1, c1 As Integer
        f1 = 0 : c1 = 0 : f = f + 1
        For f1 = f To fi Step -1
            For c1 = 1 To c
                If (f1 = fi) Then
                    M(f1, c1) = InputBox("", "", "")
                Else
                    Intercambio((f1 - 1), c1, f1, c1)
                End If
            Next
        Next
    End Sub
    'ELIMINAR FILA DE ND'
    Public Sub EliminarFilaND(fi As Integer)
        Dim f1, c1 As Integer
        f1 = 0 : c1 = 0
        For f1 = fi To (f - 1)
            For c1 = 1 To c
                Intercambio((f1 + 1), c1, f1, c1)
            Next
        Next
        f = f - 1
    End Sub
    'ELIMINAR COLUMNA DE ND'
    Public Sub EliminarColumnaND(ci As Integer)
        Dim f1, c1 As Integer
        f1 = 0 : c1 = 0
        For c1 = ci To (c - 1)
            For f1 = 1 To f
                Intercambio(f1, (c1 + 1), f1, c1)
            Next
        Next
        c = c - 1
    End Sub
    'ORDENAR LA DIAGONAL PRINCIPAL'
    Public Sub OrdenarDiagonal()
        Dim f1, c1, i As Integer
        f1 = 0 : c1 = 0 : i = 0
        For f1 = 1 To (f - 1)
            For c1 = f1 To (c - 1)
                If (M(f1, f1)) > (M(((f1 - i) + c1), (c1 + 1))) Then
                    Intercambio(f1, f1, ((f1 - i) + c1), (c1 + 1))
                End If
            Next
            i += 1
        Next
    End Sub
    'ORDENAR LA DIAGIONAL SECUNDARIA'
    Public Sub OrdenarDiagonalSec()
        Dim f1, c1, i, i2 As Integer
        f1 = 0 : c1 = 0 : i = 0 : i2 = 0
        For f1 = 1 To (f - 1)
            For c1 = c - f1 To 1 Step -1
                i += 1
                If M(f1, (c - i2)) > M((f1 + i), c1) Then
                    Intercambio(f1, (c - i2), (f1 + i), c1)
                End If
            Next
            i = 0 : i2 += 1
        Next
    End Sub
    'CONTAR ELEMENTOS'
    Public Function FrecuenciaFila(ele As Integer, fi As Integer) As Integer
        Dim i, c1 As Integer
        i = 0 : c1 = 0
        For c1 = 1 To c
            If M(fi, c1) = ele Then
                i += 1
            End If
        Next
        Return i
    End Function
    Public Sub FrecuenciaYElementUltiFil()
        Dim f1, c1, na, i As Integer
        f1 = 0 : c1 = 1 : na = 0 : i = 0
        For f1 = 1 To f
            i = FrecuenciaFila(M(f1, 1), f1)
            na = M(f1, 1)
            For c1 = 1 To (c - 1)
                If i < FrecuenciaFila(M(f1, c1 + 1), f1) Then
                    i = FrecuenciaFila(M(f1, c1 + 1), f1)
                    na = M(f1, c1 + 1)
                End If
            Next
            M(f1, c + 1) = na
            M(f1, c + 2) = i
        Next
        c += 2
    End Sub
    'ORDENAR LAS COLUMNAS DESCENDENTEMENTE'
    Public Sub OrdenarColDescen()
        Dim f1, c1, fref As Integer
        f1 = 1 : c1 = 0 : fref = 0
        For c1 = 1 To c
            For fref = 1 To f - 1
                For f1 = fref To f - 1
                    If M(fref, c1) < M((f1 + 1), c1) Then
                        Intercambio(fref, c1, (f1 + 1), c1)
                    End If
                Next
            Next
        Next
    End Sub
    'ORDENAR LAS FILAS ASCENDENTEMENTE'
    Public Sub OrdenarFilasAscen()
        Dim f1, c1, c2 As Integer
        f1 = 0 : c1 = 0 : c2 = 0
        For f1 = 1 To f
            For c1 = 1 To c - 1
                For c2 = c1 To c - 1
                    If M(f1, c1) > M(f1, c2 + 1) Then
                        Intercambio(f1, c1, f1, c2 + 1)
                    End If
                Next
            Next
        Next
    End Sub
    'ORDENAR ASCENDENTEMENTE LA MATRIZ'
    Public Sub OrdenarMatrizAscen()
        Dim i, f1, f2, c1, c2 As Integer
        i = 0 : f1 = 0 : f2 = 0 : c1 = 0 : c2 = 0
        For f1 = 1 To f
            For c1 = 1 To c
                For f2 = f1 To f
                    If (f2 = f1) Then
                        i = c1
                    Else
                        i = 1
                    End If
                    For c2 = i To c
                        If M(f1, c1) > M(f2, c2) Then
                            Intercambio(f1, c1, f2, c2)
                        End If
                    Next
                Next
            Next
        Next
    End Sub
    'ORDENAR UNA MATRIZ DESDE FILA SUPERIOR DERECHA'
    Public Sub OrdenarMatrizFDAscen()
        Dim i, f1, f2, c1, c2 As Integer
        i = 0 : f1 = 0 : f2 = 0 : c1 = 0 : c2 = 0
        For f1 = 1 To f
            For c1 = c To 1 Step -1
                For f2 = f1 To f
                    If (f2 = f1) Then
                        i = c1
                    Else
                        i = c
                    End If
                    For c2 = i To 1 Step -1
                        If M(f1, c1) > M(f2, c2) Then
                            Intercambio(f1, c1, f2, c2)
                        End If
                    Next
                Next
            Next
        Next
    End Sub
    'ORDENAR UNA MATRIZ DESDE ULTIMA FILA PRIMERA COLUMNA'
    Public Sub OrdenarMatrizFIzAbajo()
        Dim i, f1, f2, c1, c2 As Integer
        i = 0 : f1 = 0 : f2 = 0 : c1 = 0 : c2 = 0
        For f1 = f To 1 Step -1
            For c1 = 1 To c
                For f2 = f1 To 1 Step -1
                    If (f2 = f1) Then
                        i = c1
                    Else
                        i = 1
                    End If
                    For c2 = i To c
                        If M(f1, c1) > M(f2, c2) Then
                            Intercambio(f1, c1, f2, c2)
                        End If
                    Next
                Next
            Next
        Next
    End Sub
    'ORDENAR UNA MATRIZ DESDE ULTIMA FILA ULTIMA COLUMNA'
    Public Sub OrdenarMatrizFULCOLUL()
        Dim f1, f2, c1, c2, i As Integer
        f1 = 0 : f2 = 0 : c1 = 0 : c2 = 0 : i = 0
        For f1 = f To 1 Step -1
            For c1 = c To 1 Step -1
                For f2 = f1 To 1 Step -1
                    If (f2 = f1) Then
                        i = c1
                    Else
                        i = c
                    End If
                    For c2 = i To 1 Step -1
                        If M(f1, c1) > M(f2, c2) Then
                            Intercambio(f1, c1, f2, c2)
                        End If
                    Next
                Next
            Next
        Next
    End Sub
    'ORDENAR LA TRIANGULAR SUPERIOR POR COLUMNAS TOMANDO DIAGONAL PRINCIPAL'
    Public Sub BuscarMenorDS(fi As Integer, ci As Integer)
        Dim na, f1, c1, f2 As Integer
        na = M(fi, ci) : f2 = fi
        For c1 = ci To c
            For f1 = fi To (c1 - 1)
                If M(f1, c1) < na Then
                    na = M(f1, c1)
                    Intercambio(f2, ci, f1, c1)
                End If
            Next
            fi = 1
        Next
    End Sub
    Public Sub OrdenarTSCol()
        Dim f1, c1 As Integer
        f1 = 0 : c1 = 0
        For c1 = 1 To c
            For f1 = 1 To c1
                BuscarMenorDS(f1, c1)
            Next
        Next
    End Sub
    'ORDENAR LA TRIANGULAR SUPERIOR SIN TOMAR LA DIGIONAL PRINCIPAL'
    Public Sub OrdenarTSColSinDP()
        Dim f1, c1 As Integer
        f1 = 0 : c1 = 0
        For c1 = 1 To c
            For f1 = 1 To (c1 - 1)
                BuscarMenorDS(f1, c1)
            Next
        Next
    End Sub
    'ORDENAR LA TRIANGULAR IZQ POR FILAS'
    Public Sub BuscarMenorDSS(fi As Integer, ci As Integer)
        Dim na, f1, c1, f2, f3 As Integer
        na = M(fi, ci) : f2 = fi : f3 = 1
        For f1 = fi To f
            f3 = f1
            For c1 = ci To 1 Step -1
                If M(f3, c1) < na Then
                    na = M(f3, c1)
                    Intercambio(f2, ci, f3, c1)
                End If
                f3 += 1
            Next
        Next
    End Sub
    Public Sub OrdenarDGIzq()
        Dim f1, c1, f2 As Integer
        f1 = 0 : c1 = 0
        For f1 = 1 To f
            f2 = f1
            For c1 = c To 1 Step -1
                BuscarMenorDSS(f2, c1)
                f2 += 1
            Next
        Next
    End Sub
    '============================================================================'
    'ORDENAR UNA MATRIZ DESDE DIFERENTE POSICIONES DE COLUMNAS'
    'ORDENAR UNA MATRIZ LA TG SUPERRIOR DERECHA'
    Public Sub OrdenarTSD()
        Dim f1, c1, fref As Integer
        f1 = 0 : c1 = 0 : fref = 0
        For f1 = 1 To f
            For c1 = f1 To c
                BuscarMenorInterTSD(f1, c1)
            Next
        Next
    End Sub
    Public Sub BuscarMenorInterTSD(fi, ci)
        Dim f1, c1, cc As Integer
        f1 = fi : c1 = 0 : cc = ci
        While (f1 <= f)
            For c1 = cc To c
                If M(f1, c1) < M(fi, ci) Then
                    Intercambio(fi, ci, f1, c1)
                End If
            Next
            f1 += 1
            cc = f1
        End While
    End Sub
    'ELIMINAR LA TRIANGULAR INFERIOR IZQUIERDA'
    Public Sub EliminarTIIZ()
        Dim f1, c1 As Integer
        f1 = 0 : c1 = 0
        For f1 = 2 To f
            For c1 = 1 To f1 - 1
                M(f1, c1) = 0
            Next
        Next
    End Sub
    'ELIMINAR LA TRIANGUAR SUPERIOR IZQUIERDA'
    Public Sub EliminarTSD()
        Dim f1, c1, i As Integer
        f1 = 0 : c1 = 0 : i = 0
        For f1 = 1 To f - 1
            For c1 = 2 + i To c
                M(f1, c1) = 0
            Next
            i += 1
        Next
    End Sub
    Public Sub BuscarParYOrdenar(fi As Integer, ci As Integer)
        Dim f1 As Integer
        Dim n1 As NEnt = New NEnt
        For f1 = fi To f - 1
            n1.n = M(f1 + 1, ci)
            If (n1.Par() = True) And (M(fi, ci) > M(f1 + 1, ci)) Then
                Intercambio(fi, ci, f1 + 1, ci)
            End If
        Next
    End Sub

    Public Sub OrdenarColumnasSoloPares()
        Dim f1, c1 As Integer
        Dim n1 As NEnt = New NEnt
        For c1 = 1 To c
            For f1 = 1 To f - 1
                n1.n = M(f1, c1)
                If (n1.Par() = True) Then
                    BuscarParYOrdenar(f1, c1)
                End If
            Next
        Next
    End Sub
    Public Function CantElemParesCol(ci As Integer) As Integer
        Dim i, f1 As Integer
        Dim n1 As NEnt = New NEnt
        i = 0 : f1 = 0
        For f1 = 1 To f
            n1.n = M(f1, ci)
            If (n1.Par() = True) Then
                i += 1
            End If
        Next
        Return i
    End Function
    Public Sub InterCambioCol(ci As Integer, cf As Integer)
        Dim f1 As Integer = 0
        For f1 = 1 To f
            Intercambio(f1, ci, f1, cf)
        Next
    End Sub
    Public Sub OrdenarColPorElemPares()
        Dim f1, c1, cref As Integer
        f1 = 1 : c1 = 0
        For c1 = 1 To c
            For cref = c1 To c - 1
                If CantElemParesCol(c1) > CantElemParesCol(cref + 1) Then
                    InterCambioCol(c1, cref + 1)
                End If
            Next
        Next
    End Sub
    Public Sub BuscarMenorSegmen(fi As Integer, ci As Integer, cf As Integer, fo As Integer, co As Integer)
        Dim f1, c1, cc As Integer
        f1 = 0 : c1 = 0 : cc = co
        For f1 = fo To fi Step -1
            For c1 = cc To ci + 1 Step -1
                If M(fo, co) > M(f1, c1 - 1) Then
                    Intercambio(fo, co, f1, c1 - 1)
                End If
            Next
            cc = cf
        Next
    End Sub
    Public Sub OrdenarSegementoAscen(fi As Integer, ci As Integer, ff As Integer, cf As Integer)
        Dim f1, c1 As Integer
        f1 = 0 : c1 = 0
        For f1 = ff To fi Step -1
            For c1 = cf To ci Step -1
                BuscarMenorSegmen(fi, ci, cf, f1, c1)
            Next
        Next
    End Sub
    Public Function FrecuenciaCol(fi As Integer, ff As Integer, co As Integer, ele As Integer)
        Dim f1, cont As Integer
        f1 = 0 : cont = 0
        For f1 = fi To ff
            If (ele = M(f1, co)) Then
                cont += 1
            End If
        Next
        Return cont
    End Function
    Public Sub FrecuenciaElementDelSegmento(fi As Integer, ci As Integer, ff As Integer, cf As Integer)
        Dim ele, frec, f1, c1 As Integer
        ele = 0 : frec = 0 : f1 = 0 : c1 = 0
        For c1 = ci To cf
            frec = FrecuenciaCol(fi, ff, c1, M(fi, c1))
            ele = M(fi, c1)
            For f1 = fi To ff - 1
                If frec < FrecuenciaCol(fi, ff, c1, M(f1 + 1, c1)) Then
                    frec = FrecuenciaCol(fi, ff, c1, M(f1 + 1, c1))
                    ele = M(f1 + 1, c1)
                End If
            Next
            M(f + 1, c1) = ele
            M(f + 2, c1) = frec
        Next
        f += 2
    End Sub
End Class
