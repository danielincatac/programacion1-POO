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
    Public Function Frecuencia(d As Integer) As Integer
        Dim i, n1, aux As Integer
        i = 0 : n1 = 0 : aux = 0
        aux = n
        While (n > 0)
            n1 = n Mod 10
            n = n \ 10
            If (n1 = d) Then
                i = i + 1
            End If
        End While
        n = aux
        Return i
    End Function
    Public Function MenordigND(nd As Integer) As Integer
        Dim n1, n2, aux As Integer
        n1 = 0 : n2 = 0 : aux = 0
        aux = n
        n1 = n Mod 10 ^ nd
        n = n \ 10 ^ nd
        While (n > 0)
            n2 = n Mod 10 ^ nd
            n = n \ 10 ^ nd
            If (n2 < n1) Then
                n1 = n2
            End If
        End While
        n = aux
        Return n1
    End Function
    Public Function EliminarDigNumEntND(d As Integer, nd As Integer) As Integer
        Dim n1, aux As Integer
        Dim n2 As NEnt
        Dim b As Boolean
        n1 = 0 : n2 = New NEnt : aux = 0
        aux = n
        While (n > 0) And (b = False)
            n1 = n Mod 10 ^ nd
            n = n \ 10 ^ nd
            If (n1 <> d) Then
                n2.n = (n1 * 10 ^ n2.CantidadDigs()) + n2.n
            Else
                b = True
            End If
        End While
        n1 = (n * 10 ^ n2.CantidadDigs()) + n2.n
        n = aux
        Return n1
    End Function
    Public Function CantidadDigs() As Integer
        Dim i, aux As Integer
        i = 0 : aux = 0
        aux = n
        While (n > 0)
            n = n \ 10
            i = i + 1
        End While
        n = aux
        Return i
    End Function
    Public Function Par() As Boolean
        Dim b As Boolean
        b = False
        If (n Mod 2 = 0) Then
            b = True
        End If
        Return b
    End Function
    Public Function IntercalarND(n1 As Integer, nd As Integer) As Double
        Dim aux As Integer
        Dim n2, na1, na2 As NEnt
        aux = 0 : na1 = New NEnt : na2 = New NEnt : n2 = New NEnt
        aux = n
        While (n > 0) And (n1 > 0)
            na1.n = n Mod 10 ^ nd
            n = n \ 10 ^ nd
            n2.n = (n2.n * 10 ^ nd) + na1.n
            na2.n = n1 Mod 10 ^ nd
            n1 = n1 \ 10 ^ nd
            n2.n = (n2.n * 10 ^ nd) + na2.n
        End While
        If (n > 0) Then
            While (n <> 0)
                na1.n = n Mod 10 ^ nd
                n = n \ 10 ^ nd
                n2.n = (n2.n * 10 ^ nd) + na1.n
            End While
        End If
        If (n1 > 0) Then
            While (n1 <> 0)
                na2.n = n1 Mod 10 ^ nd
                n1 = n1 \ 10 ^ nd
                n2.n = (n2.n * 10 ^ nd) + na2.n
            End While
        End If
        n = aux
        Return n2.n
    End Function
    Public Function EliminarTodoslosdigIguales(d As Integer) As Integer
        Dim n1, n2, aux, c As Integer
        n1 = 0 : n2 = 0 : aux = 0 : c = 1
        aux = n
        While (n > 0)
            n1 = n Mod 10
            n = n \ 10
            If (n1 <> d) Then
                n2 = (n1 * c) + n2
                c = c * 10
            End If
        End While
        n = aux
        Return n2
    End Function
    Public Function VerificarPares() As Boolean
        Dim aux, n1 As Integer
        Dim b As Boolean
        Dim copy As NEnt
        aux = 0 : n1 = 0 : copy = New NEnt
        aux = n
        copy.n = n
        While (n > 0) And (b = False)
            n1 = n Mod 10
            n = n \ 10
            If (copy.Frecuencia(n1) = 2) Then
                b = True
            End If
        End While
        n = aux
        Return b
    End Function
    'Ejercicio #1'
    Public Sub EliminarDigitosRepetidos()
        Dim n2, c, n1 As Integer
        Dim copy As NEnt
        copy = New NEnt : n2 = 0 : c = 1 : n1 = 0
        copy.n = n
        While (n > 0)
            n1 = n Mod 10
            n = n \ 10
            If (copy.Frecuencia(n1) = 1) Then
                n2 = (n1 * c) + n2
                c = c * 10
            End If
        End While
        n = n2
    End Sub
    'Ejercicio #2'
    Public Sub SegmentarenDigitosRepetidosyUnicos()
        Dim nrep, nnorep, n1, c, c1 As Integer
        Dim copy As NEnt
        copy = New NEnt : nrep = 0 : nnorep = 0 : n1 = 0 : c = 1 : c1 = 1
        copy.n = n
        While (n > 0)
            n1 = n Mod 10
            n = n \ 10
            If (copy.Frecuencia(n1) >= 2) Then
                nrep = (n1 * c) + nrep
                c = c * 10
            Else
                nnorep = (n1 * c1) + nnorep
                c1 = c1 * 10
            End If
        End While
        n1 = (nrep * c1) + nnorep
        n = n1
    End Sub
    'Ejercicio #3'
    Public Sub OrdenarMenorMayorNd(nd As Integer)
        Dim n2, n3 As NEnt
        n2 = New NEnt : n3 = New NEnt
        While (n > 0)
            n3.n = MenordigND(nd)
            n = EliminarDigNumEntND(n3.n, nd)
            n2.n = (n2.n * 10 ^ n3.CantidadDigs()) + n3.n
        End While
        n = n2.n
    End Sub
    'Ejercicio #4'
    Public Function CambiarDigitoPorOtro(n1 As NEnt, n2 As NEnt) As Integer
        Dim na, aux As Integer
        Dim b As Boolean
        Dim nb As NEnt
        na = 0 : aux = 0 : nb = New NEnt
        aux = n
        While (n > 0) And (b = False)
            na = n Mod 10 ^ n1.CantidadDigs()
            n = n \ 10 ^ n1.CantidadDigs()
            If (na <> n1.n) Then
                nb.n = (na * 10 ^ nb.CantidadDigs()) + nb.n
            Else
                b = True
            End If
        End While
        If (b = True) Then
            na = (n * 10 ^ n2.CantidadDigs()) + n2.n
            na = (na * 10 ^ nb.CantidadDigs()) + nb.n
        Else
            na = aux
        End If
        n = aux
        Return na
    End Function
    'Ejercicio #5'
    Public Function IntercalarParImpar(nd As Integer) As Double
        Dim aux, c, c1 As Integer
        Dim na1, na2, n1 As NEnt
        n1 = New NEnt : aux = 0 : na1 = New NEnt : na2 = New NEnt : c = 1 : c1 = 1
        aux = n
        If (nd >= 2) Then
            While (n > 0)
                n1.n = n Mod 10 ^ nd
                n = n \ 10 ^ nd
                If (n1.Par() = True) Then
                    na1.n = (n1.n * 10 ^ na1.CantidadDigs()) + na1.n
                Else
                    na2.n = (n1.n * 10 ^ na2.CantidadDigs()) + na2.n
                End If
            End While
        Else
            While (n > 0)
                n1.n = n Mod 10 ^ nd
                n = n \ 10 ^ nd
                If (n1.Par() = True) Then
                    na1.n = (n1.n * c) + na1.n
                    c = c * 10
                Else
                    na2.n = (n1.n * c1) + na2.n
                    c1 = c1 * 10
                End If
            End While
        End If
        n1.n = na1.IntercalarND(na2.n, nd)
        n = aux
        Return n1.n
    End Function
    'Ejercicio #6'
    Public Function UnirTresNumeroEnterosAscendente(n1 As Integer, n2 As Integer) As Integer
        Dim menor, ac As Integer
        Dim medio, mayor As NEnt
        mayor = New NEnt : medio = New NEnt : menor = 0 : ac = 0
        If (n > n1) And (n > n2) Then
            mayor.n = n
        End If
        If (n1 > n) And (n1 > n2) Then
            mayor.n = n1
        End If
        If (n2 > n) And (n2 > n1) Then
            mayor.n = n2
        End If
        If (n = mayor.n) Then
            If (n1 < n2) Then
                menor = n1
                medio.n = n2
            Else
                If (n2 < n1) Then
                    menor = n2
                    medio.n = n1
                End If
            End If
        Else
            If (n1 = mayor.n) Then
                If (n < n2) Then
                    menor = n
                    medio.n = n2
                Else
                    If (n2 < n) Then
                        menor = n2
                        medio.n = n
                    End If
                End If
            End If
        End If
        If (n2 = mayor.n) Then
            If (n < n1) Then
                menor = n
                medio.n = n1
            Else
                If (n1 < n) Then
                    menor = n1
                    medio.n = n
                End If
            End If
        End If
        ac = (menor * 10 ^ medio.CantidadDigs()) + medio.n
        ac = (ac * 10 ^ mayor.CantidadDigs()) + mayor.n
        Return ac
    End Function
    'Ejercicio #7'
    Public Function DividirNumEntCuandoDigSeanIguales(na As NEnt) As Integer
        Dim n1, aux, c, nnorep, nn As Integer
        Dim b As Boolean
        Dim copy As NEnt
        copy = New NEnt : n1 = 0 : aux = 0 : c = 1 : nnorep = 0 : nn = 0
        copy.n = n
        aux = n
        While (n > 0) And (b = False)
            n1 = n Mod 10
            n = n \ 10
            If (copy.Frecuencia(n1) = 1) Then
                nnorep = (n1 * c) + nnorep
                c = c * 10
            Else
                b = True
            End If
        End While
        nnorep = (n1 * c) + nnorep
        na.Cargar(nnorep)
        nn = n
        n = aux
        Return nn
    End Function
    'Ejercicio #8'
    Public Function VerificarTrica() As Boolean
        Dim copy As NEnt
        Dim n1, aux As Integer
        Dim b As Boolean
        copy = New NEnt : n1 = 0 : aux = 0
        copy.n = n
        aux = n
        While (n > 0) And (b = False)
            n1 = n Mod 10
            n = n \ 10
            If (copy.Frecuencia(n1) = 3) Then
                b = True
            End If
        End While
        n = aux
        Return b
    End Function
    'Ejercicio #9'
    Public Function VerificarDosPares() As Boolean
        Dim i, aux, n1 As Integer
        Dim copy As NEnt
        i = 0 : aux = 0 : n1 = 0 : copy = New NEnt
        aux = n
        copy.n = n
        While (n > 0) And (i < 2)
            n1 = n Mod 10
            n = n \ 10
            If (copy.Frecuencia(n1) = 2) Then
                i = i + 1
                copy.n = copy.EliminarTodoslosdigIguales(n1)
            End If
        End While
        n = aux
        Return i = 2
    End Function
    'Ejercicio #10'
    Public Function VerificarFull() As Boolean
        Dim b As Boolean
        b = False
        If (VerificarTrica() = True) And (VerificarPares() = True) Then
            b = True
        End If
        Return b
    End Function
End Class
