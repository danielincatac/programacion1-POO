Public Class Matriz
    Const MAXF = 100
    Const MAXC = 100
    Private M(MAXF, MAXC) As Integer
    Private f, c As Integer
    Public Sub Matriz()
        f = 0 : c = 0
    End Sub
    Public Sub CargarRandom(nf As Integer, nc As Integer, a As Integer, b As Integer)
        Dim f1, c1 As Integer
        f = nf : c = nc
        For f1 = 1 To f
            For c1 = 1 To c
                M(f1, c1) = a + Rnd() * (b - a)
            Next
        Next
    End Sub
    Public Sub CargarProgresivamente(nf As Integer, nc As Integer, vi As Integer, r As Integer)
        Dim f1, c1, i As Integer
        f = nf : c = nc : i = 1
        For f1 = 1 To f
            For c1 = 1 To c
                M(f1, c1) = vi + (i - 1) * r
                i = i + 1
            Next
        Next
    End Sub
    Public Sub CargarManual(nf As Integer, nc As Integer)
        Dim f1, c1 As Integer
        f = nf : c = nc
        For f1 = 1 To f
            For c1 = 1 To c
                M(f1, c1) = InputBox("", "", "")
            Next
        Next
    End Sub
    Public Function Descargar() As String
        Dim s As String = ""
        Dim f1, c1 As Integer
        f1 = 0 : c1 = 0
        For f1 = 1 To f
            For c1 = 1 To c
                s = s + CStr(M(f1, c1)) + " ; "
            Next
            s = s + Chr(13) + Chr(10)
        Next
        Return s
    End Function
    Public Function FrecuenciaMatriz(d As Integer) As Integer
        Dim f1, c1 As Integer
        Dim cont As Byte = 0
        f1 = 0 : c1 = 0
        For f1 = 1 To f
            For c1 = 1 To c
                If (M(f1, c1) = d) Then
                    cont = cont + 1
                End If
            Next
        Next
        Return cont
    End Function
    Public Function FrecuenciaFilas(fi As Integer, d As Integer) As Integer
        Dim c1, i As Integer
        c1 = 0 : i = 0
        For c1 = 1 To c
            If (M(fi, c1) = d) Then
                i = i + 1
            End If
        Next
        Return i
    End Function
    Public Sub IntercambiarColumnas(ci, cf)
        Dim f1, c1, aux As Integer
        f1 = 0 : c1 = 0 : aux = 0
        For f1 = 1 To f
            aux = M(f1, ci)
            M(f1, ci) = M(f1, cf)
            M(f1, cf) = aux
        Next
    End Sub
    Public Function SumarFila(fi As Integer) As Integer
        Dim c1, acu As Integer
        c1 = 0 : acu = 0
        For c1 = 1 To c
            acu = acu + M(fi, c1)
        Next
        Return acu
    End Function
    Public Sub IntercambioFilas(fi As Integer, ff As Integer)
        Dim c1, aux As Integer
        c1 = 0 : aux = 0
        For c1 = 1 To c
            aux = M(fi, c1)
            M(fi, c1) = M(ff, c1)
            M(ff, c1) = aux
        Next
    End Sub
    Public Sub InterCambiarElemFila(fi As Integer, ci As Integer, ff As Integer, cf As Integer)
        Dim aux As Integer = 0
        aux = M(fi, ci)
        M(fi, ci) = M(ff, cf)
        M(ff, cf) = aux
    End Sub
    '========================================= PRIMERA PARTE 1 =========================================================='
    'Ejericio 1'
    Public Function AcumularPrimos() As Double
        Dim acu As Double = 0
        Dim n1 As NEnt = New NEnt
        Dim f1, c1, b As Integer
        f1 = 0 : c1 = 0 : b = 1
        For f1 = f To 1 Step -1
            For c1 = c To 1 Step -1
                n1.n = M(f1, c1)
                If (n1.VerfPrimo() = True) Then
                    acu = acu - (n1.n ^ (1 / 2)) * b
                    b = b * -1
                End If
            Next
        Next
        Return acu
    End Function
    'Ejercicio 2 '
    Public Function ElementosUnicos() As Integer
        Dim i As Byte = 0
        Dim f1, c1 As Integer
        f1 = 0 : c1 = 0
        For f1 = 1 To f
            For c1 = 1 To c
                If (FrecuenciaMatriz(M(f1, c1)) = 1) Then
                    i = i + 1
                End If
            Next
        Next
        Return i
    End Function
    'Ejercicio 3'
    Public Sub ContElemPrimoUltimaFila()
        Dim f1, c1, i As Integer
        Dim n1 As NEnt = New NEnt
        f1 = 0 : c1 = 0 : i = 0
        c = c + 1
        For f1 = 1 To f
            For c1 = 1 To (c - 1)
                n1.n = M(f1, c1)
                If (n1.VerfPrimo() = True) Then
                    i = i + 1
                End If
            Next
            M(f1, c) = i
            i = 0
        Next
    End Sub
    'Ejercicio 4'
    Public Sub ElementMayorFrecFila()
        Dim f1, c1, n1, na As Integer
        f1 = 0 : c1 = 1 : n1 = 0 : na = 0
        c = c + 1
        For f1 = 1 To f
            n1 = FrecuenciaFilas(f1, M(f1, 1))
            na = M(f1, c1)
            For c1 = 1 To (c - 2)
                If (n1 < FrecuenciaFilas(f1, M(f1, c1 + 1))) Then
                    n1 = FrecuenciaFilas(f1, M(f1, c1 + 1))
                    na = M(f1, c1 + 1)
                End If
            Next
            M(f1, c) = na
        Next
    End Sub
    'Ejercicio 5'
    Public Sub SegmentarParImparFila()
        Dim f1, c1, c2 As Integer
        Dim n1, n2 As NEnt
        n1 = New NEnt : n2 = New NEnt
        f1 = 0 : c1 = 0 : c2 = 0
        For f1 = 1 To f
            For c1 = 1 To c
                For c2 = c1 + 1 To c
                    n1.n = M(f1, c2)
                    n2.n = M(f1, c1)
                    If n1.VerfPar() And n2.VerfImpar() Or
                      n1.VerfPar() And n2.VerfPar() And (M(f1, c1) > M(f1, c2)) Or
                      n1.VerfImpar() And n2.VerfImpar() And (M(f1, c1) > M(f1, c2)) Then
                        InterCambiarElemFila(f1, c2, f1, c1)
                    End If
                Next
            Next
        Next
    End Sub
    'Ejercicio 6'
    Public Sub OrdenarFilaCambiandoColumnas(fi As Integer)
        Dim c1, cref As Integer
        c1 = 0 : cref = 0
        For cref = 1 To (c - 1)
            For c1 = 1 To (c - 1)
                If (M(fi, cref) >= M(fi, (c1 + 1))) Then
                    IntercambiarColumnas(cref, c1 + 1)
                End If
            Next
        Next
    End Sub
    'Ejercico 7'
    Public Function VerfColumnaOrdenada() As Boolean
        Dim bo As Boolean = True
        Dim f1, c1 As Integer
        f1 = 0 : c1 = c
        While (c1 > 0) And (bo = True)
            For f1 = (f - 1) To 1 Step -1
                If M((f1 + 1), c1) >= (M(f1, c1)) Then
                    bo = False
                End If
            Next
            c1 = c1 - 1
        End While
        Return bo
    End Function
    'Ejercicio 8'
    Public Function VerfOrdeandoAbajoIzquierda() As Boolean
        Dim bo As Boolean = True
        Dim f1, c1, na As Integer
        f1 = f : c1 = 1 : na = M(f1, c1)
        While (f1 > 0) And (bo = True)
            c1 = 1
            While (c1 <= c) And (bo = True)
                If na <= M(f1, c1) Then
                    na = M(f1, c1)
                Else
                    bo = False
                End If
                c1 = c1 + 1
            End While
            f1 -= 1
        End While
        Return bo
    End Function
    'Ejercicio 9'
    Public Function VerfMatrizIncluidaEnOrtra(m2 As Matriz) As Boolean
        Dim bo As Boolean = True
        Dim f1, c1 As Integer
        f1 = 0 : c1 = 0
        For f1 = 1 To f
            For c1 = 1 To c
                If (m2.FrecuenciaMatriz(M(f1, c1)) = 0) Then
                    bo = False
                End If
            Next
        Next
        Return bo
    End Function
    'Ejercicio 10'
    Public Sub OrdenarFilasPorSumas()
        Dim f1, f2 As Integer
        f1 = 0 : f2 = 0
        For f1 = 1 To (f - 1)
            For f2 = 1 To (f - 1)
                If (SumarFila(f1) >= SumarFila(f2 + 1)) Then
                    IntercambioFilas(f1, (f2 + 1))
                End If
            Next
        Next
    End Sub
End Class
