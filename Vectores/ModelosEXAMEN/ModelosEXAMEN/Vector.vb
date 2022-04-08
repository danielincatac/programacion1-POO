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
            V(i) = InputBox("", "", "")
        Next
    End Sub
    Public Function Descargar() As String
        Dim f As String = ""
        For i = 1 To n
            f = f + CStr(V(i)) + " ; "
        Next
        Return f
    End Function
    Public Sub IntercalarPriNoPri()
        Dim p, d As Integer
        Dim n1, n2 As NEnt
        Dim bo As Boolean = True
        Dim aux As Integer = 0
        p = 0 : d = 0 : n1 = New NEnt : n2 = New NEnt
        For p = 1 To n
            If (bo = True) Then
                For d = (p + 1) To n
                    n1.Cargar(V(d))
                    n2.Cargar(V(p))
                    If (n1.VerfPrimo() = True) And Not (n2.VerfPrimo() = True) Or
                       (n1.VerfPrimo() = True) And (n2.VerfPrimo() = True) And (V(p) > V(d)) Or
                        Not (n1.VerfPrimo() = True) And Not (n2.VerfPrimo() = True) And (V(p) > V(d)) Then
                        aux = V(p)
                        V(p) = V(d)
                        V(d) = aux
                    End If
                Next
                bo = False
            Else
                For d = (p + 1) To n
                    n1.Cargar(V(p))
                    n2.Cargar(V(d))
                    If (n1.VerfPrimo() = True) And Not (n2.VerfPrimo() = True) Or
                       (n1.VerfPrimo() = True) And (n2.VerfPrimo() = True) And (V(p) > V(d)) Or
                       Not (n1.VerfPrimo() = True) And Not (n2.VerfPrimo() = True) And (V(p) > V(d)) Then
                        aux = V(p)
                        V(p) = V(d)
                        V(d) = aux
                    End If
                Next
                bo = True
            End If
        Next
    End Sub
    Public Function FrecuenciaVector(d As Integer) As Integer
        Dim c As Byte = 0
        For i = 1 To n
            If (V(i) = d) Then
                c = c + 1
            End If
        Next
        Return c
    End Function
    Public Function FrecuenciaVectorRango(a As Integer, b As Integer, d As Integer)
        Dim c As Byte = 0
        For i = a To b
            If (V(i) = d) Then
                c = c + 1
            End If
        Next
        Return c
    End Function
    Public Sub Intercambiar(d As Integer, dd As Integer)
        Dim aux As Integer = V(d)
        V(d) = V(dd)
        V(dd) = aux
    End Sub
    Public Sub IntercalarRepNoRepOrdenado()
        Dim p, d As Integer
        Dim bo As Boolean = True
        Dim aux As Integer = 0
        p = 0 : d = 0
        For p = 1 To n
            If (bo = True) Then
                For d = (p + 1) To n
                    If (FrecuenciaVector(V(d))) > (FrecuenciaVector(V(p))) Or
                       (FrecuenciaVector(V(d))) > (FrecuenciaVector(V(p))) And (V(p) > V(d)) Or
                         (FrecuenciaVector(V(d))) = (FrecuenciaVector(V(p))) And (V(p) > V(d)) Then
                        aux = V(p)
                        V(p) = V(d)
                        V(d) = aux
                    End If
                Next
                bo = False
            Else
                For d = (p + 1) To n
                    If (FrecuenciaVector(V(p))) > (FrecuenciaVector(V(d))) Or
                       (FrecuenciaVector(V(p))) > (FrecuenciaVector(V(d))) And (V(p) > V(d)) Or
                       (FrecuenciaVector(V(p))) = (FrecuenciaVector(V(d))) And (V(p) > V(d)) Then
                        aux = V(p)
                        V(p) = V(d)
                        V(d) = aux
                    End If
                Next
                bo = True
            End If
        Next
    End Sub
    Public Sub IntercalarRepNoRepRangoOrdenado(a As Integer, b As Integer)
        Dim p, d As Integer
        Dim bo As Boolean = True
        Dim aux As Integer = 0
        p = 0 : d = 0
        For p = a To b
            If (bo = True) Then
                For d = (p + 1) To b
                    If (FrecuenciaVector(V(d))) > (FrecuenciaVector(V(p))) Or
                       (FrecuenciaVector(V(d))) > (FrecuenciaVector(V(p))) And (V(p) > V(d)) Or
                         (FrecuenciaVector(V(d))) = (FrecuenciaVector(V(p))) And (V(p) > V(d)) Then
                        aux = V(p)
                        V(p) = V(d)
                        V(d) = aux
                    End If
                Next
                bo = False
            Else
                For d = (p + 1) To b
                    If (FrecuenciaVector(V(p))) > (FrecuenciaVector(V(d))) Or
                       (FrecuenciaVector(V(p))) > (FrecuenciaVector(V(d))) And (V(p) > V(d)) Or
                       (FrecuenciaVector(V(p))) = (FrecuenciaVector(V(d))) And (V(p) > V(d)) Then
                        aux = V(p)
                        V(p) = V(d)
                        V(d) = aux
                    End If
                Next
                bo = True
            End If
        Next
    End Sub
    Public Function EncontrarEleMayorYFrecRango(a As Integer, b As Integer, n1 As NEnt)
        Dim ele As Integer
        Dim frec As Integer
        ele = V(a)
        frec = FrecuenciaVectorRango(a, b, V(a))
        For i = (a + 1) To b
            If (FrecuenciaVectorRango(a, b, V(i)) > frec) Then
                ele = V(i)
                frec = FrecuenciaVectorRango(a, b, V(i))
            End If
        Next
        n1.Cargar(frec)
        Return ele
    End Function
    Public Sub SegmentarOrdenado()
        Dim aux As Integer = 0
        Dim k As Byte = 0
        Dim c As Byte = 0
        For i = 1 To n
            If (FrecuenciaVector(V(i)) >= 2) Then
                aux = V(i - k)
                V(i - k) = V(i)
                V(i) = aux
                c = c + 1
            Else
                k = k + 1
            End If
        Next
        OrdenamientoDaniel(1, c)
        OrdenamientoDaniel((c + 1), n)
    End Sub
    Public Sub SegmentarOrdenadoRango(a As Integer, b As Integer)
        Dim k As Byte = 0
        Dim aux As Integer = 0
        Dim c As Integer = (a - 1)
        For i = a To b
            If (FrecuenciaVectorRango(a, b, V(i)) = 1) Then
                aux = V(i - k)
                V(i - k) = V(i)
                V(i) = aux
                c = c + 1
            Else
                k = k + 1
            End If
        Next
        OrdenamientoDaniel(a, c)
        OrdenamientoDaniel((c + 1), b)
    End Sub
    Public Sub OrdenamientoDaniel(a As Integer, b As Integer)
        Dim j As Byte
        Dim aux As Integer
        For i = a To b
            For j = i To b
                If (V(i) > V(j)) Then
                    aux = V(i)
                    V(i) = V(j)
                    V(j) = aux
                End If
            Next
        Next
    End Sub
    Public Sub Recorrer(pos As Integer)
        n = n + 1
        For i = n To (pos + 1) Step -1
            V(i) = V(i - 1)
        Next
    End Sub
    Public Sub OrdenarPosicionesMultiplRango(a As Integer, b As Integer, m As Integer)
        Dim c, c1 As Byte
        Dim j As Integer
        Dim aux As Integer = 0
        c = m : c1 = 0
        For i = (a + (m - 1)) To b
            If ((c Mod m) = 0) Then
                c1 = c
                For j = i To b
                    If (c1 Mod m = 0) Then
                        If (V(i) > V(j)) Then
                            aux = V(i)
                            V(i) = V(j)
                            V(j) = aux
                        End If
                    End If
                    c1 = c1 + 1
                Next
            End If
            c = c + 1
        Next
    End Sub
    Public Sub EliminaMultiRango(a As Integer, b As Integer, m As Integer)

    End Sub
End Class
