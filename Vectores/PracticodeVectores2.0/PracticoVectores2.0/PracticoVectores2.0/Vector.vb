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
        Dim f As String = " { "
        For i = 1 To n
            f = f + CStr(V(i)) + "  |  "
        Next
        Return f + "}"
    End Function
    Public Function FrecuenciaVector(d As Integer) As Integer
        Dim c As Byte = 0
        For i = 1 To n
            If (V(i) = d) Then
                c = c + 1
            End If
        Next
        Return c
    End Function
    Public Function FrecunciaVectorRango(a As Integer, b As Integer, d As Integer)
        Dim c As Byte = 0
        For i = a To b
            If (V(i) = d) Then
                c = c + 1
            End If
        Next
        Return c
    End Function
    Public Sub OrdenarAscendenteB()
        Dim aux As Integer = 0
        Dim j As Byte = 0
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
    '=============================================== Primera Parte ==========================================================
    'Ejercicio # 1'
    Public Function AcumularConDigFibo() As Double
        Dim ac As Double = 0
        Dim n1 As NEnt = New NEnt
        Dim b, s As Integer
        b = 1 : s = 1
        For i = 1 To n
            n1.n = V(i)
            If (n1.VerificarNEperteneceFibo() = True) Then
                ac = ac - s / n1.Factorial() * b
                b = b * -1
                s = s + 2
            End If
        Next
        Return ac
    End Function
    'Ejercicio # 2'
    Public Sub ConvertiraBaseB(b As Integer, vr As Vector)
        Dim n1 As NEnt = New NEnt
        Dim j As Byte = 0
        For i = 1 To n
            n1.n = V(i)
            j = j + 1
            vr.V(j) = n1.Convertirdebase10acualquierbase(b)
            vr.n = j
        Next
    End Sub
    'Ejercicio # 3
    Public Function AcumulaElmentMultiX(x As Integer) As Double
        Dim j As Byte = 0
        Dim f As Double = 0
        Dim b, c, k, xaux As Integer
        b = 1 : c = 2 : k = 2 : xaux = 0
        xaux = x
        For i = xaux To n
            If (i = xaux) Then
                f = f + V(i) ^ (1 / c) * b
                b = b * -1
                xaux = x * k
                k = k + 1
                c = c + 2
            End If
        Next
        Return f
    End Function
    'Ejercicio  # 4 '
    Public Function ElementoMenor(x As Integer) As Integer
        Dim menor As Integer = V(x)
        Dim xaux, k As Integer
        xaux = x : k = 2
        For i = xaux To n
            If (i = xaux) Then
                If (V(i) < menor) Then
                    menor = V(i)
                End If
                xaux = x * k
                k = k + 1
            End If
        Next
        Return menor
    End Function
    'Ejercicio 5 '
    Public Sub InterseccionDosVectores(v1 As Vector, vr As Vector)
        Dim j, k As Byte
        j = 0 : k = 0 : vr.n = 0
        For i = 1 To n
            For k = 1 To v1.n
                If (V(i) = v1.V(k)) And (vr.FrecuenciaVector(V(i)) = 0) Then
                    j = j + 1
                    vr.V(j) = V(i)
                    vr.n = j
                End If
            Next
        Next
    End Sub
    'Ejercicio 6 '
    Public Function VerfOrdenadoAscendente(a As Integer, b As Integer) As Boolean
        Dim bo As Boolean = True
        Dim n1 As Integer = V(a)
        For i = a To b And (bo = True)
            If (V(i) >= n1) Then
                n1 = V(i)
            Else
                bo = False
            End If
        Next
        Return bo
    End Function
    'Ejercicio 7 '
    Public Function VerfPrimoRango(a As Integer, b As Integer) As Boolean
        Dim n1 As NEnt = New NEnt
        Dim bo As Boolean = True
        For i = a To b And (bo = True)
            n1.n = V(i)
            If (n1.Primo() = False) Then
                bo = False
            End If
        Next
        Return bo
    End Function
    'Ejercicio 8 '
    Public Function VerfIntercaladoParImpar() As Boolean
        Dim n1 As NEnt = New NEnt
        Dim sw, k As Byte
        Dim b As Boolean = True
        sw = 1 : k = 0
        For i = 1 To n And (b = True)
            n1.n = V(i)
            If (sw = 1) Then
                If (n1.Impar() = True) Then
                    For k = i To n
                        n1.n = V(k)
                        If (n1.Par() = True) Then
                            b = False
                        End If
                    Next
                End If
                sw = 0
            Else
                If (n1.Par() = True) Then
                    For k = i To n
                        n1.n = V(k)
                        If (n1.Impar() = True) Then
                            b = False
                        End If
                    Next
                End If
                sw = 1
            End If
        Next
        Return b
    End Function
    'Ejercicio 9'
    Public Function VerfElmentBase(b As Integer) As Boolean
        Dim n1 As NEnt = New NEnt
        Dim bo As Boolean = True
        For i = 1 To n And (bo = True)
            n1.n = V(i)
            If (n1.VerficarBase(b) = False) Then
                bo = False
            End If
        Next
        Return bo
    End Function
    'Ejercicio 10 '
    Public Sub InvertirElemRango(a As Integer, b As Integer)
        Dim j As Byte = 0
        Dim vaux As Vector = New Vector
        For i = a To b
            j = j + 1
            vaux.V(j) = V(i)
        Next
        For i = a To b
            V(i) = vaux.V(j)
            j = j - 1
        Next
    End Sub
    '======================================================== Segunda Parte ======================================================='
    'Ejercicio 1 '
    Public Sub OrdenarElemntRangoAscendente(a As Integer, b As Integer)
        Dim j, aux As Byte
        j = 0 : aux = 0
        For i = a To (b - 1)
            For j = a To (b - 1)
                If (V(j) > V(j + 1)) Then
                    aux = V(j)
                    V(j) = V(j + 1)
                    V(j + 1) = aux
                End If
            Next
        Next
    End Sub
    'Ejercicio 2'
    Public Sub InsertarEnUnaPos(v2 As Vector, p As Integer)
        Dim j, k, c As Integer
        Dim vaux As Vector = New Vector
        j = 0 : k = 1
        For i = p To n
            j = j + 1
            vaux.V(j) = V(i)
            vaux.n = j
        Next
        j = 0
        For i = p To (n + v2.n)
            If (v2.n >= k) Then
                V(i) = v2.V(k)
                k = k + 1
            Else
                j = j + 1
                V(i) = vaux.V(j)
            End If
        Next
        n = (n + v2.n)
    End Sub
    'Eercicio 3 '
    Public Sub EliminarElemetRango(a As Integer, b As Integer)
        Dim k As Byte = 0
        For i = 1 To n
            If (i = a) And (a <= b) Then
                k = k + 1
                a = a + 1
            Else
                V(i - k) = V(i)
            End If
        Next
        n = (n - k)
    End Sub
    'Ejercicio 4'
    Public Function ContarElementDiferentRango(a As Integer, b As Integer) As Integer
        Dim c, j As Byte
        Dim vaux As Vector = New Vector
        c = 0 : j = 0
        For i = a To b
            If (vaux.FrecuenciaVector(V(i)) = 0) Then
                j = j + 1
                vaux.V(j) = V(i)
                vaux.n = j
                c = c + 1
            End If
        Next
        Return c
    End Function
    'Ejercicio 5 '
    Public Sub ElementoYFrecuenciaRango(a As Integer, b As Integer, v2 As Vector, v3 As Vector)
        Dim j, k As Byte
        v2.n = 0 : v3.n = 0 : j = 0 : k = 0
        For i = a To b
            If (FrecunciaVectorRango(a, b, V(i)) >= 1) And (v2.FrecuenciaVector(V(i)) = 0) Then
                j = j + 1
                v2.V(j) = V(i)
                v2.n = j
                k = k + 1
                v3.V(k) = FrecunciaVectorRango(a, b, V(i))
                v3.n = k
            End If
        Next
    End Sub
    'Ejercicio 6'
    Public Function ElementMenorRango(a As Integer, b As Integer) As Integer
        Dim nfr As Byte = 0
        Dim menosrep As Integer = 0
        nfr = FrecunciaVectorRango(a, b, V(a))
        menosrep = V(a)
        For i = a To b
            If (FrecunciaVectorRango(a, b, V(i)) < nfr) Then
                nfr = FrecunciaVectorRango(a, b, V(i))
                menosrep = V(i)
            End If
        Next
        Return menosrep
    End Function
    'Ejercicio 7'
    Public Sub IntecalarDosElment(v2 As Vector, vr As Vector)
        Dim j, k As Byte
        j = 0 : k = 0 : vr.n = 0
        For i = 1 To (n + v2.n)
            If (n >= i) Then
                j = j + 1
                vr.V(j) = V(i)
            End If
            If (v2.n >= i) Then
                j = j + 1
                vr.V(j) = v2.V(i)
            End If
        Next
        vr.n = j
    End Sub
    'Ejercicio 8'
    Public Sub SegmentarPriNoPriOrdenado(a As Integer, b As Integer)
        Dim vpri, vnopri As Vector
        Dim j, k As Byte
        Dim n1 As NEnt = New NEnt
        vpri = New Vector : vnopri = New Vector : j = 0 : k = 0
        For i = a To b
            n1.n = V(i)
            If (n1.Primo() = True) Then
                j = j + 1
                vpri.V(j) = V(i)
                vpri.n = j
            Else
                k = k + 1
                vnopri.V(k) = V(i)
                vnopri.n = k
            End If
        Next
        vpri.OrdenarAscendenteB()
        vnopri.OrdenarAscendenteB()
        j = 1 : k = 0
        For i = a To b
            If (vpri.n >= j) Then
                V(i) = vpri.V(j)
                j = j + 1
            Else
                k = k + 1
                V(i) = vnopri.V(k)
            End If
        Next
    End Sub
    'Ejercicio 9'
    Public Sub SegmentarRepYNoRepOrdenado()
        Dim vrep, vnorep As Vector
        Dim j, k As Byte
        vrep = New Vector : vnorep = New Vector : j = 0 : k = 0
        For i = 1 To n
            If (FrecuenciaVector(V(i)) = 1) Then
                k = k + 1
                vnorep.V(k) = V(i)
                vnorep.n = k
            Else
                j = j + 1
                vrep.V(j) = V(i)
                vrep.n = j
            End If
        Next
        vrep.OrdenarAscendenteB()
        vnorep.OrdenarAscendenteB()
        j = 0 : k = 0
        For i = 1 To n
            If (vrep.n >= i) Then
                j = j + 1
                V(i) = vrep.V(j)
            Else
                k = k + 1
                V(i) = vnorep.V(k)
            End If
        Next
    End Sub
    'Ejercicio 10'
    Public Sub IntercalarPriNoPriOrdenado(a As Integer, b As Integer)
        Dim vpri, vnopri As Vector
        Dim j, k As Byte
        Dim n1 As NEnt = New NEnt
        vpri = New Vector : vnopri = New Vector : j = 0 : k = 0
        For i = a To b
            n1.n = V(i)
            If (n1.Primo()) Then
                j = j + 1
                vpri.V(j) = V(i)
                vpri.n = j
            Else
                k = k + 1
                vnopri.V(k) = V(i)
                vnopri.n = k
            End If
        Next
        vpri.OrdenarAscendenteB() : vnopri.OrdenarAscendenteB()
        j = 1 : k = a
        For i = a To b
            If (vpri.n >= j) Then
                V(k) = vpri.V(j)
                k = k + 1
            End If
            If (vnopri.n >= j) Then
                V(k) = vnopri.V(j)
                k = k + 1
            End If
            j = j + 1
        Next
    End Sub
End Class
