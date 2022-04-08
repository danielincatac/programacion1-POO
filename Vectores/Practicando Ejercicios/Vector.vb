Public Class Vector
    Const MAX = 100
    Private V(MAX) As Integer
    Private n As Integer
    Public Sub Vector()
        n = 0
    End Sub
    Public Sub CargarRandom(n1 As Integer, a As Integer, b As Integer)
        n = n1
        For i = 1 To n
            V(i) = a + Rnd() * (b - a)
        Next
    End Sub
    Public Sub CargarManual(n1 As Integer)
        n = n1
        For i = 1 To n
            V(i) = InputBox("Bienvenido al Mundo de los Vectores", "Ingrese el Dato", "")
        Next
    End Sub
    Public Function Descagar() As String
        Dim f As String = ""
        For i = 1 To n
            f = f + Str(V(i)) + " ; "
        Next
        Return f
    End Function
    Public Function Acumular() As Integer
        Dim i As Integer = 0
        Dim f As Integer = 0
        For i = 1 To n
            f = f + V(i)
        Next
        Return f
    End Function
    Public Function Promedio() As Double
        Dim f As Double = 0
        f = Acumular() / n
        Return f
    End Function
    Public Function DesviacionMedia() As Double
        Dim f, acu, dvm, p As Double
        f = 0 : acu = 0 : dvm = 0
        p = Promedio()
        For i = 1 To n
            acu = acu + Math.Abs(p - V(i))
        Next
        dvm = acu / n
        Return dvm
    End Function
    Public Function VerfPrimo() As Boolean
        Dim c As Integer = 0
        For i = 1 To n
            If ((n Mod i) = 0) Then
                c = c + 1
            End If
        Next
        Return c = 2
    End Function
    Public Function CuantosPrimos() As Integer
        Dim n1 As Vector = New Vector
        Dim c As Integer = 0
        For i = 1 To n
            n1.n = V(i)
            If (n1.VerfPrimo() = True) Then
                c = c + 1
            End If
        Next
        Return c
    End Function
    Public Function EncontrarElElementoMenor(x As Integer) As Integer
        Dim n1, c As Integer
        n1 = V(x)
        c = x
        For i = 1 To n
            If (i = x) Then
                If (V(i) <= n1) Then
                    n1 = V(i)
                    x = x + c
                End If
            End If
        Next
        Return n1
    End Function
    Public Function VerfOrdenado(a As Integer, b As Integer) As Boolean
        Dim n1 As Integer
        Dim b1 As Boolean = True
        n1 = V(a)
        For i = a To b And (b1 = True)
            If (n1 <= V(a)) Then
                n1 = V(a)
            Else
                b1 = False
            End If
            a = a + 1
        Next
        Return b1
    End Function
    Public Sub EliminarElementoVector(p As Integer, m As Integer)
        Dim k As Integer = 0
        For i = 1 To n
            If (i = p) And (m > 0) Then
                m = m - 1
                p = p + 1
                k = k + 1
            Else
                V(i - k) = V(i)
            End If
        Next
        n = (n - k)
    End Sub
    Public Sub EliminarElmentoVector2(p As Integer, m As Integer)
        For i = 1 To n
            If (i > (p + (m - 1))) Then
                V(i - m) = V(i)
            End If
        Next
        n = n - m
    End Sub
    Public Function Intercalar(n1 As Vector) As Integer
        Dim n2 As Vector = New Vector
        For i = 1 To n
            n2.V(i) = V(i)
            n2.V(i + 1) = n1.V(i)
        Next
        Return n2.n
    End Function
    Public Sub OrdenamientoBurbujaAscendete()
        Dim j, aux As Byte
        j = 0 : aux = 0
        For i = 1 To (n - 1)
            For j = 1 To (n - 1)
                If (V(j) > V(j + 1)) Then
                    aux = V(j)
                    V(j) = V(j + 1)
                    V(j + 1) = aux
                End If
            Next
        Next
    End Sub
    Public Sub OrdenamientoBurbujaDescendente()
        Dim j, aux As Integer
        j = 0 : aux = 0
        For i = (n - 1) To 1 Step -1
            For j = (n - 1) To 1 Step -1
                If (V(j) < V(j + 1)) Then
                    aux = V(j)
                    V(j) = V(j + 1)
                    V(j + 1) = aux
                End If
            Next
        Next
    End Sub
    Public Function VerfPar() As Boolean
        Return n Mod 2 = 0
    End Function
    Public Function VerfImpar() As Boolean
        Return VerfImpar() = False
    End Function
    Public Sub OrdenamientoPorIntercambioAscendente()
        Dim aux As Integer = 0
        Dim j As Byte = 0
        For i = 1 To (n - 1)
            For j = (i + 1) To n
                If (V(j) < V(i)) Then
                    aux = V(i)
                    V(i) = V(j)
                    V(j) = aux
                End If
            Next
        Next
    End Sub
    Public Sub OrdenamientoPorIntercambioAscendentedesdelaultimapos()
        Dim aux As Integer = 0
        Dim j As Integer = 0
        For i = n To 2 Step -1
            For j = (i - 1) To 1 Step -1
                If (V(j) > V(i)) Then
                    aux = V(i)
                    V(i) = V(j)
                    V(j) = aux
                End If
            Next
        Next
    End Sub
    Public Sub InvertirElementosRango(a As Integer, b As Integer)
        Dim i As Byte = 0
        Dim aux As Integer = 0
        While (a < b)
            aux = V(a)
            V(a) = V(b)
            V(b) = aux
            a = a + 1
            b = b - 1
        End While
    End Sub
    Public Sub Segmentarprimosinvectorauxiliar(a As Integer, b As Integer)
        Dim i As Byte = a
        Dim aux As Integer = 0
        Dim n1 As NEnt = New NEnt
        While (i < b)
            For i = a To b
                n1.n = V(i)
                If (n1.VerfPrimo() = True) Then
                    aux = V(a)
                    V(a) = V(i)
                    V(i) = aux
                    a = a + 1
                End If
            Next
            i = i + 1
        End While
    End Sub
    Public Sub IntercalarSinVectorAuxilar(a As Integer, b As Integer)
        Dim bo As Boolean = True
        Dim j, sw, aux As Byte
        Dim n1 As NEnt = New NEnt
        j = 0 : sw = 0 : aux = 0
        For i = a To (b - 1)
            If (sw = 0) Then
                j = i
                While (j <= b) And (bo = True)
                    n1.n = V(j)
                    If (n1.VerfPrimo() = True) Then
                        aux = V(i)
                        V(i) = V(j)
                        V(j) = aux
                        bo = False
                    End If
                    j = j + 1
                End While
                sw = 1
                bo = True
            Else
                j = i
                While (j <= b) And (bo = True)
                    n1.n = V(j)
                    If Not (n1.VerfPrimo() = True) Then
                        aux = V(i)
                        V(i) = V(j)
                        V(j) = aux
                        bo = False
                    End If
                    j = j + 1
                End While
                bo = True
                sw = 0
            End If
        Next
    End Sub
    Public Function ExisteElmenVector(d As Integer) As Boolean
        Dim b As Boolean = False
        Dim n1 As Integer = 0
        For i = 1 To n
            If (V(i) = d) Then
                b = True
            End If
        Next
        Return b
    End Function
    Public Function FrecuenciaVector(d As Integer)
        Dim c As Byte = 0
        For i = 1 To n
            If (V(i) = d) Then
                c = c + 1
            End If
        Next
        Return c
    End Function
    Public Sub ElmentPrimoOrdenado(vr As Vector)
        Dim j As Byte = 0
        Dim n1 As NEnt = New NEnt
        For i = 1 To n
            n1.n = V(i)
            If (n1.VerfPrimo() = True) And (vr.ExisteElmenVector(n1.n) = False) Then
                j = j + 1
                vr.V(j) = V(i)
                vr.n = j
            End If
        Next
        vr.OrdenamientoBurbujaaa()
    End Sub
    Public Sub OrdenamientoBurbujaaa()
        Dim aux, j As Byte
        aux = 0 : j = 0
        For i = 1 To (n - 1)
            For j = 1 To (n - 1)
                If (V(j) > V(j + 1)) Then
                    aux = V(j)
                    V(j) = V(j + 1)
                    V(j + 1) = aux
                End If
            Next
        Next
    End Sub
    Public Function FrecuenciaVectorRango(a As Integer, b As Integer, d As Integer) As Integer
        Dim c As Integer
        For i = a To b
            If (V(i) = d) Then
                c = c + 1
            End If
        Next
        Return c
    End Function
    Public Function ElementoMenosRepetido(a As Integer, b As Integer) As Integer
        Dim menos, menosrep As Integer
        menos = 0 : menosrep = 0
        menosrep = FrecuenciaVectorRango(a, b, V(a))
        menos = V(a)
        For i = a To b
            If (FrecuenciaVectorRango(a, b, V(i)) < menosrep) Then
                menosrep = FrecuenciaVectorRango(a, b, V(i))
                menos = V(i)
            End If
        Next
        Return menos
    End Function
    Public Sub PurgarElmentosPrimos(a As Integer, b As Integer)
        Dim n1 As NEnt = New NEnt
        Dim k As Byte = 0
        For i = 1 To n
            If (i = a) And (a <= b) Then
                n1.n = V(i)
                If (n1.VerfPrimo() = True) Then
                    k = k + 1
                Else
                    V(i - k) = V(i)
                End If
                a = a + 1
            End If
            If (a > b) Then
                V(i - k) = V(i)
            End If
        Next
        n = (n - k)
    End Sub
    Public Sub OrdenarMultiplos(a As Integer, b As Integer, x As Integer)
        Dim xaux, aux, i, k, k1, i1 As Integer
        k = 2
        xaux = x
        i = x

        While (i <= n)
            While (xaux <= n)
                If (V(i) > V(xaux)) Then
                    aux = V(i)
                    V(i) = V(xaux)
                    V(xaux) = aux
                End If
                xaux = x * k
                k = k + 1
            End While
            i = x * k1
            k1 = k1 + 1
            k = k1
            xaux = i
        End While
    End Sub
    Public Sub IntercalarElementoMayorMenor(a As Integer, b As Integer)
        Dim sw, k, aux, n1 As Integer
        n1 = 0 : sw = 0 : k = 0
        For i = a To b
            n1 = V(i)
            If (sw = 0) Then
                For k = i To b
                    If (n1 < V(k)) Then
                        aux = V(i)
                        V(i) = V(k)
                        V(k) = aux
                        n1 = V(i)
                    End If
                Next
                sw = 1
            Else
                For k = i To b
                    If (n1 > V(k)) Then
                        aux = V(i)
                        V(i) = V(k)
                        V(k) = aux
                        n1 = V(i)
                    End If
                Next
                sw = 0
            End If
        Next
    End Sub
    Public Sub OrdenarMultiplosRango(a As Integer, b As Integer, x As Integer)
        Dim i As Byte = 0
        Dim aux, l, l2, ia, j, ie, aux2, auxvector As Byte
        aux = x : i = 0 : ia = 1 : l = 2 : j = 0 : ie = 0 : aux2 = 0 : auxvector = 0
        For i = a To b
            If (ia = aux) Then
                aux2 = aux
                ie = ia
                l2 = l
                aux = x * l
                l = l + 1
                For j = i To b
                    If (ie = aux2) Then
                        aux2 = x * l2
                        l2 = l2 + 1
                        If (V(i) > V(j)) Then
                            auxvector = V(i)
                            V(i) = V(j)
                            V(j) = auxvector
                        End If
                    End If
                    ie = ie + 1
                Next
            End If
            ia = ia + 1
        Next
    End Sub
    Public Sub EliminarMultiplosRango(a As Integer, b As Integer, m As Integer)
        Dim i, ia, k, l, maux As Integer
        i = 0 : l = 2 : k = 0 : maux = m : ia = 1
        For i = 1 To n
            If (i = a) And (a <= b) Then
                a = a + 1
                If (ia = maux) Then
                    maux = m * l
                    l = l + 1
                    k = k + 1
                Else
                    V(i - k) = V(i)
                End If
                ia = ia + 1
            End If
            If (a > b) Then
                V(i - k) = V(i)
            End If
        Next
        n = (n - k)
    End Sub
    Public Sub SegmentarParImparRango(a As Integer, b As Integer)
        Dim i, k, m, m1 As Byte
        Dim n1 As NEnt = New NEnt
        Dim aux As Integer = 0
        i = 0 : k = 0 : m = (a - 1) : m1 = 0
        For i = a To b
            n1.n = V(i)
            If Not (n1.VerfPar() = True) Then
                k = k + 1
            Else
                aux = V(i - k)
                V(i - k) = V(i)
                V(i) = aux
                m = m + 1
            End If
        Next
        OrdenarDannielrango(a, m)
        OrdenarDannielrango((m + 1), b)
    End Sub
    Public Sub OrdenamientoBRango(a As Integer, b As Integer)
        Dim j As Byte = 0
        Dim aux As Integer = 0
        For i = a To (b - 1)
            For j = i To (b - 1)
                If (V(j) > V(j + 1)) Then
                    aux = V(j)
                    V(j) = V(j + 1)
                    V(j + 1) = aux
                End If
            Next
        Next
    End Sub
    Public Sub OrdenarDannielrango(a As Integer, b As Integer)
        Dim j, aux As Integer
        For i = a To b
            For j = i To b
                If V(i) > V(j) Then
                    aux = V(i)
                    V(i) = V(j)
                    V(j) = aux
                End If
            Next
        Next
    End Sub
    Public Sub Intercalar(a As Integer, b As Integer)
        Dim j, i, aux, sw As Byte
        Dim bo As Boolean = True
        Dim n1 As NEnt = New NEnt
        sw = 0 : j = 0 : aux = 0 : i = 0
        For i = a To (b - 1)
            If (sw = 0) Then
                j = i
                While (j <= b) And (bo = True)
                    n1.n = V(j)
                    If (n1.VerfPrimo() = True) Then
                        aux = V(i)
                        V(i) = V(j)
                        V(j) = aux
                        b = False
                    End If
                    j = j + 1
                End While
                bo = True
                sw = 1
            Else
                j = i
                While (j <= b) And (bo = True)
                    n1.n = V(j)
                    If Not (n1.VerfPrimo() = True) Then
                        aux = V(i)
                        V(i) = V(j)
                        V(j) = aux
                        bo = False
                    End If
                    j = j + 1
                End While
                bo = True
                sw = 0
            End If
        Next
    End Sub
    Public Sub InsertarOtroVectorPos(pos As Byte, v2 As Vector)
        Dim k, c, aux, j As Byte
        Dim i As Integer = 1
        Dim n1, n2 As Integer
        k = 0 : c = v2.n : aux = n : j = 0
        For i = (n + v2.n) To 1 Step -1
            If (i >= pos) And ((n - k) >= pos) Then
                n1 = V(n - k)
                V(i) = n1
                j = j + 1
                n2 = v2.V(j)
                V(n - k) = n2
                k = k + 1
            End If
        Next
        n = (n + v2.n)

    End Sub
End Class
