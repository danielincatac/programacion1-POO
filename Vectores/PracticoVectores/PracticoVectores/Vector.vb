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
    Public Function FrecuenciaVector(d As Integer) As Integer
        Dim c As Integer = 0
        For i = 1 To n
            If (V(i) = d) Then
                c = c + 1
            End If
        Next
        Return c
    End Function
    '=============================================== Primera Parte ======================================================'
    'Ejercicio 1 '
    Public Function AcumularConDigFibo() As Double
        Dim ac As Double = 0
        Dim n1 As NEnt = New NEnt
        Dim b, s As Integer
        b = 1 : s = 1
        For i = 1 To n
            n1.n = V(i)
            If (n1.Primo() = True) Then
                ac = ac - s / n1.Factorial() * b
                b = b * -1
                s = s + 2
            End If
        Next
        Return ac
    End Function
    ' Ejercicio 2 '
    Public Function ConvertiraBaseB(b As Integer) As String
        Dim v1 As Vector = New Vector
        Dim n1 As NEnt = New NEnt
        Dim j As Byte = 0
        For i = 1 To n
            n1.n = V(i)
            j = j + 1
            v1.V(j) = n1.Convertirdebase10acualquierbase(b)
        Next
        v1.n = j
        Return v1.Descargar()
    End Function
    'Ejercicio 3 '
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
    'Ejercicio 4 '
    Public Function ElementoMenor(x As Integer) As Integer
        Dim menor As Integer = V(x)
        Dim xv, k As Integer
        xv = x : k = 2
        For i = x To n
            If (i = xv) Then
                If (V(i) < menor) Then
                    menor = V(i)
                End If
                xv = x * k
                k = k + 1
            End If
        Next
        Return menor
    End Function
    'Ejercicio 5 '
    Public Sub InterseccionDosVectores(v1 As Vector, v2 As Vector)
        Dim j, k As Byte
        j = 0 : k = 0
        For i = 1 To n
            For k = 1 To v1.n
                If (V(i) = v1.V(k)) And (v2.FrecuenciaVector(V(i)) = 0) Then
                    j = j + 1
                    v2.V(j) = V(i)
                    v2.n = j
                End If
            Next
        Next
    End Sub
    'Ejercicio 6 '
    Public Function VerfOrdenadoAscendente(a As Integer, b As Integer) As Boolean
        Dim b1 As Boolean = True
        Dim n1 As Integer = V(a)
        Dim i As Byte = 1
        For i = a To b And (b1 = True)
            If (V(i) >= n1) Then
                n1 = V(i)
            Else
                b1 = False
            End If
        Next
        Return b1
    End Function
    'Ejercicio 7 '
    Public Function VerfPrimoRango(a As Integer, b As Integer) As Boolean
        Dim n1 As NEnt = New NEnt
        Dim b1 As Boolean = True
        For i = a To b And (b1 = True)
            n1.n = V(i)
            If (n1.Primo() = False) Then
                b1 = False
            End If
        Next
        Return b1
    End Function
    'Ejercicio 8 '
    Public Function VerfIntercaladoParImpar() As Boolean
        Dim n1 As NEnt = New NEnt
        Dim sw, c, k As Integer
        Dim b As Boolean = True
        sw = 1 : c = 0 : k = 0
        For i = 1 To n And (b = True)
            n1.n = V(i)
            If (sw = 1) Then
                If (n1.Par() = False) Then
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
                        If (n1.Par() = False) Then
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
        Dim c, j As Integer
        Dim v1 As Vector = New Vector
        c = 0 : j = 0
        For i = a To b
            j = j + 1
            v1.V(j) = V(i)
            c = c + 1
        Next
        j = c
        For i = a To b
            V(i) = v1.V(j)
            j = j - 1
        Next
    End Sub
    '======================================================== Segunda Parte ===================================================================================='
    'Ejercicio 1 '
    'Ejercicio 2'
    Public Sub InsertarEnUnaPos(v2 As Vector, p As Integer)
        Dim j, k, c, m As Integer
        Dim vn As Vector = New Vector
        j = 0 : k = 0 : c = 0 : m = 0
        c = v2.n
        For i = p To n
            j = j + 1
            vn.V(j) = V(i)
        Next
        vn.n = j
        For i = p To (n + v2.n)
            If (c > 0) Then
                k = k + 1
                V(i) = v2.V(k)
                c = c - 1
            Else
                m = m + 1
                V(i) = vn.V(m)
            End If
        Next
        n = (n + v2.n)
    End Sub
    'Eercicio 3 '
    Public Sub EliminarElemetRango(a As Integer, b As Integer)
        Dim k As Integer = 0
        k = 0
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
        Dim c, j As Integer
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
    Public Sub ElementoYFrecuencia(a As Integer, b As Integer, v2 As Vector, v3 As Vector)
        Dim j, k, m As Integer
        Dim vaux As Vector = New Vector
        v2.n = 0 : v3.n = 0
        j = 0 : k = 0 : m = 0
        For i = a To b
            m = m + 1
            vaux.V(m) = V(i)
            vaux.n = m
        Next
        For i = 1 To vaux.n
            If (v2.FrecuenciaVector(vaux.V(i)) = 0) Then
                j = j + 1
                v2.V(j) = vaux.V(i)
                v2.n = j
                k = k + 1
                v3.V(k) = vaux.FrecuenciaVector(vaux.V(i))
                v3.n = k
            End If
        Next
    End Sub
    'Ejercicio 6'
    Public Function ElementMenorRango(a As Integer, b As Integer) As Integer
        Dim vaux As Vector = New Vector
        Dim j As Byte = 0
        Dim n1, n2 As Integer
        n1 = 0 : n2 = 0
        For i = a To b
            j = j + 1
            vaux.V(j) = V(i)
            vaux.n = j
        Next
        n1 = vaux.FrecuenciaVector(V(a))
        n2 = vaux.V(a)
        For i = 1 To vaux.n
            If (vaux.FrecuenciaVector(vaux.V(i)) < n1) Then
                n1 = vaux.FrecuenciaVector(vaux.V(i))
                n2 = vaux.V(i)
            End If
        Next
        Return n2
    End Function
    'Ejercicio 7'
    Public Sub IntecalarDosElment(v2 As Vector, vr As Vector)
        Dim j, k As Integer
        j = 0 : k = 0
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
    Public Sub SegmentarPrimoNoPrimo(a As Integer, b As Integer)
        Dim vpri, vnopri, vaux As Vector
        Dim k, j, m, n As Byte
        Dim n1 As NEnt = New NEnt
        vpri = New Vector : vnopri = New Vector : vaux = New Vector
        k = 0 : j = 0 : m = 0 : n = 0
        For i = a To b
            j = j + 1
            vaux.V(j) = V(i)
            vaux.n = j
        Next
        For i = 1 To vaux.n
            n1.n = vaux.V(i)
            If (n1.Primo() = True) Then
                m = m + 1
                vpri.V(m) = vaux.V(i)
                vpri.n = m
            Else
                n = n + 1
                vnopri.V(n) = vaux.V(i)
                vnopri.n = n
            End If
        Next
        For i = 1 To vnopri.n
            m = m + 1
            vpri.V(m) = vnopri.V(i)
            vpri.n = m
        Next
        For i = a To b
            k = k + 1
            V(i) = vpri.V(k)
        Next
    End Sub
    'Ejercicio 9'
    Public Sub SegmentarRepYNoRep(vre As Vector)
        Dim vnore As Vector
        Dim k, j As Byte
        vnore = New Vector : k = 0 : j = 0
        For i = 1 To n
            If (FrecuenciaVector(V(i)) >= 2) Then
                j = j + 1
                vre.V(j) = V(i)
                vre.n = j
            Else
                k = k + 1
                vnore.V(k) = V(i)
                vnore.n = k
            End If
        Next
        For i = 1 To vnore.n
            j = j + 1
            vre.V(j) = vnore.V(i)
            vre.n = j
        Next
    End Sub
    'Ejercicio 10'
    Public Sub IntercalarPriNoPri(a As Integer, b As Integer)
        Dim vpri, vnopri, vaux As Vector
        Dim n1 As NEnt = New NEnt
        Dim j, k, m As Byte
        j = 0 : k = 0 : m = 0
        vpri = New Vector : vnopri = New Vector : vaux = New Vector
        For i = a To b
            m = m + 1
            vaux.V(m) = V(i)
            vaux.n = m
        Next
        For i = 1 To vaux.n
            n1.n = vaux.V(i)
            If (n1.Primo() = True) Then
                j = j + 1
                vpri.V(j) = vaux.V(i)
                vpri.n = j
            Else
                k = k + 1
                vnopri.V(k) = vaux.V(i)
                vnopri.n = k
            End If
        Next
        m = 0 : vaux.n = 0
        For i = 1 To (vpri.n + vnopri.n)
            If (vpri.n >= i) Then
                m = m + 1
                vaux.V(m) = vpri.V(i)
                vaux.n = m
            End If
            If (vnopri.n >= i) Then
                m = m + 1
                vaux.V(m) = vnopri.V(i)
                vaux.n = m
            End If
        Next
        m = 0
        For i = a To b
            m = m + 1
            V(i) = vaux.V(m)
            vaux.n = m
        Next
    End Sub
    Public Sub Intercambiar(j As Integer, m As Integer)
        Dim aux = V(j)
        V(j) = V(m)
        V(m) = aux
    End Sub
    'PRACTICANDO APARTE'
    Public Sub OrdenarPorFrecuencia(vele As Vector, vfre As Vector)
        Dim j, i, k As Byte
        Dim num, nfrec As NEnt
        num = New NEnt : nfrec = New NEnt
        k = 0
        For i = 1 To n
            num.n = V(i)
            nfrec.n = FrecuenciaVector(V(i))
            For j = 1 To n
                If nfrec.n < FrecuenciaVector(V(j)) And vele.FrecuenciaVector(V(j)) = 0 Then
                    num.n = V(j)
                    nfrec.n = FrecuenciaVector(V(j))
                End If
            Next
            If vele.FrecuenciaVector(num.n) = 0 Then
                k += 1
                vele.V(k) = num.n
                vfre.V(k) = nfrec.n
                vele.n = k
                vfre.n = k
            End If
        Next
    End Sub


End Class