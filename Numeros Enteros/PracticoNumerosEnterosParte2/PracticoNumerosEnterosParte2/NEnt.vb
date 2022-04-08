Public Class NEnt
    Private n As Integer
    Public Sub NEnt()
        n = 0
    End Sub
    Public Sub Cargar(dato As Integer)
        n = dato
    End Sub
    Public Function Descargar()
        Return n
    End Function
    Public Function Frecuencia(n1 As Integer, n2 As Integer) As Integer
        Dim n3, n4, i As Integer
        n3 = 0 : n4 = 0 : i = 0
        While (n1 > 0)
            n3 = n1 Mod 10
            n1 = n1 \ 10
            If (n2 = n3) Then
                i = i + 1
            End If
        End While
        Return i
    End Function
    Public Function EliminarDigitoenNumEnt(n1 As Integer, n2 As Integer, nd As Integer) As Integer
        Dim n3, n4, n5, c As Integer
        Dim b As Boolean
        n3 = 0 : n4 = 0 : n5 = 0 : c = 1
        While (n1 > 0) And (b = False)
            n3 = n1 Mod 10 ^ nd
            If (n3 = n2) Then
                n1 = n1 \ 10 ^ nd
                b = True
            Else
                n4 = (n3 * 10 ^ CantidadDigitos(n4)) + n4
                n1 = n1 \ 10 ^ nd
            End If
        End While
        n5 = (n1 * 10 ^ CantidadDigitos(n4)) + n4
        Return n5
    End Function
    Public Function CantidadDigitos(n1 As Integer) As Integer
        Dim i As Integer
        i = 0
            While (n1 > 0)
                n1 = n1 \ 10
                i = i + 1
            End While
        Return i
    End Function
    Public Function Par(n1 As Integer) As Boolean
        Dim b As Boolean
        If (n Mod 2 = 0) Then
            b = True
        Else
            b = False
        End If
        Return b
    End Function
    Public Function Invertir(n1 As Integer) As Integer
        Dim n2, n3 As Integer
        While (n1 > 0)
            n2 = n1 Mod 10
            n3 = (n3 * 10) + n2
            n1=n1\10
        End While
        Return n3
    End Function
    'Ejercicio #1'
    Public Sub EliminarDigitosRepetidos()
        Dim n1, n2, n3, c As Integer
        n1 = 0 : n2 = 0 : n3 = 0 : c = 1
        n1 = n
        While (n > 0)
            n2 = n Mod 10
            If (Frecuencia(n1, n2) < 2) Then
                n3 = n3 + (n2 * c)
                c = c * 10
            End If
            n = n \ 10
        End While
        n = n3
    End Sub
    'Ejercicio #2'
    Public Sub SegmentarDigitosRepetidosUnicos()
        Dim n1, n2, n3, n4, c, c1 As Integer
        n1 = 0 : n2 = 0 : n3 = 0 : n4 = 0 : c = 1 : c1 = 1
        n1 = n
        While (n > 0)
            n2 = n Mod 10
            If (Frecuencia(n1, n2) >= 2) Then
                n3 = n3 + (n2 * c)
                c = c * 10
            Else
                n4 = n4 + (n2 * c1)
                c1 = c1 * 10
            End If
            n = n \ 10
        End While
        n2 = (n3 * c1) + n4
        n = n2
    End Sub
    'Ejercicio #3'
    Public Function OrdenarDigitosND(nd As Integer) As Integer
        Dim n1, n2, n3, n4 As Integer
        n1 = 0 : n2 = 0 : n3 = 0 : n4 = 0
        n1 = n
        n2 = n Mod 10 ^ nd
        While (n1 > 0)
            While (n <> 0)
                n3 = n Mod 10 ^ nd
                If (n2 > n3) Then
                    n2 = n3
                End If
                n = n \ 10 ^ nd
            End While
            n1 = EliminarDigitoenNumEnt(n1, n2, nd)
            n4 = (n4 * 10 ^ CantidadDigitos(n2)) + n2
            n = n1
            n2 = n Mod 10 ^ nd
        End While
        Return n4
    End Function
    'Ejercicio #4'
    Public Function CambiarObejtoPorObejto(na1 As NEnt, na2 As NEnt) As Integer
        Dim n1, n2, n3 As Integer
        Dim b As Boolean
        n1 = 0 : n2 = 0 : n3 = 0
        While (n > 0) And (b = False)
            n1 = n Mod 10 ^ CantidadDigitos(na1.n)
            If (n1 = na1.n) Then
                n2 = (na2.n * 10 ^ CantidadDigitos(n2)) + n2
                n = n \ 10 ^ CantidadDigitos(na1.n)
                b = True
            Else
                n2 = (n1 * 10 ^ CantidadDigitos(n2)) + n2
                n = n \ 10 ^ CantidadDigitos(na1.n)
            End If
        End While
        n3 = (n * 10 ^ CantidadDigitos(n2)) + n2
        Return n3
    End Function
    'Ejercicio #5'
    Public Function IntercalarParImpar(nd As Integer) As Double
        Dim n1, n2, npar, nimpar, ac, c, c1 As Integer
        n1 = 0 : npar = 0 : nimpar = 0 : ac = 0 : n2 = 0 : c = 1 : c1 = 1
        If (nd = 1) Then
            While (n > 0)
                n1 = n Mod 10
                If (Par(n1) = True) Then
                    npar = (n1 * c) + npar
                    c = c * 10
                Else
                    nimpar = (n1 * c1) + nimpar
                    c1 = c1 * 10
                End If
                n = n \ 10
            End While
            c = 1
            While (npar > 0) And (nimpar > 0)
                n1 = npar Mod 10
                ac = (ac * c) + n1
                npar = npar \ 10
                n2 = nimpar Mod 10
                c = c * 10
                ac = (ac * 10) + n2
                nimpar = nimpar \ 10
            End While
        Else
            While n > 0
                n1 = n Mod 10 ^ nd
                If (Par(n1) = True) Then
                    npar = (n1 * 10 ^ CantidadDigitos(npar)) + npar
                Else
                    nimpar = (n1 * 10 ^ CantidadDigitos(nimpar)) + nimpar
                End If
                n = n \ 10 ^ nd
            End While
        End If
        While (npar > 0) And (nimpar > 0)
            n1 = npar Mod 10 ^ nd
            npar = npar \ 10 ^ nd
            ac = (ac * 10 ^ CantidadDigitos(n1)) + n1
            n2 = nimpar Mod 10 ^ nd
            nimpar = nimpar \ 10 ^ nd
            ac = (ac * 10 ^ CantidadDigitos(n2)) + n2
        End While
        If (npar <> 0) Then
            While (npar > 0)
                n1 = npar Mod 10 ^ nd
                ac = (ac * 10 ^ CantidadDigitos(n1)) + n1
                npar = npar \ 10 ^ nd
            End While
        End If
        If (nimpar <> 0) Then
            While (nimpar > 0)
                n2 = nimpar Mod 10 ^ nd
                ac = (ac * 10 ^ CantidadDigitos(n2)) + n2
                nimpar = nimpar \ 10 ^ nd
            End While
        End If
        Return ac
    End Function
    'Ejercicio #6'
    Public Function UnirTresNumerosdeMenorMayor(n2 As Integer, n3 As Integer) As Integer
        Dim menor, mayor, ac, medio As Integer
        menor = 0 : mayor = 0 : ac = 0 : medio = 0
        If (n > n2) And (n > n3) Then
            mayor = n
        Else
            If (n2 > n) And (n2 > n3) Then
                mayor = n2
            Else
                If (n3 > n) And (n3 > n2) Then
                    mayor = n3
                End If
            End If
        End If
        If (mayor = n) Then
            If (n2 < n3) Then
                menor = n2
                medio = n3
            Else
                If (n3 < n2) Then
                    menor = n3
                    medio = n2
                End If
            End If
        Else
            If (mayor = n2) Then
                If (n < n3) Then
                    menor = n
                    medio = n3
                Else
                    If (n3 < n) Then
                        menor = n3
                        medio = n
                    End If
                End If
            End If
        End If
        If (mayor = n3) Then
            If (n < n2) Then
                menor = n
                medio = n2
            Else
                If (n2 < n) Then
                    menor = n2
                    medio = n
                End If
            End If
        End If
        ac = (menor * 10 ^ CantidadDigitos(medio)) + medio
        ac = (ac * 10 ^ CantidadDigitos(mayor)) + mayor
        Return ac
    End Function
    'Ejercicio #7'
    Public Function DividirunNEdigIguales(n2 As NEnt) As Double
        Dim n1, nw, c, c1 As Integer
        Dim b As Boolean
        n1 = 0 : nw = 0 : c1 = 1
        b = False
        c = n Mod 10
        n = n \ 10
        While (n > 0) And (b = False)
            n1 = n Mod 10
            n = n \ 10
            If (n1 <> c) Then
                nw = nw + (c * c1)
                c = n1
                c1 = c1 * 10
            Else
                b = True
            End If
        End While
        n = (n * 10 ^ CantidadDigitos(n1)) + n1
        n1 = (n1 * 10 ^ CantidadDigitos(nw)) + nw
        n2.Cargar(n1)
        Return n
    End Function
End Class
