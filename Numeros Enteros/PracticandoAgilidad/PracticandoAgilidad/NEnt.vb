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
        Dim n1, aux, i As Integer
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
    Public Function VerfPrimo() As Boolean
        Dim n1, c, aux As Integer
        n1 = 0 : c = 0 : aux = 0
        aux = n
        For i = 1 To n
            If (n Mod i = 0) Then
                c = c + 1
            End If
        Next
        n = aux
        Return c = 2
    End Function
    Public Function Factorial() As Double
        Dim aux As Integer
        Dim f As Double
        aux = n
        f = 1
        For i = 1 To n
            f = f * i
        Next
        n = aux
        Return f
    End Function
    Public Function VerfFibo() As Boolean
        Dim a, b, c As Integer
        a = -1 : b = 1 : c = 0
        While (c < n)
            c = a + b
            a = b
            b = c
        End While
        Return c = n
    End Function
    Public Function VerfPar() As Boolean
        Dim b As Boolean
        b = False
        If (n Mod 2 = 0) Then
            b = True
        End If
        Return b
    End Function
    Public Function CantDig() As Integer
        If (n <> 0) Then
            Return Math.Truncate(Math.Log10(n)) + 1
        Else
            Return 0
        End If
    End Function
    Public Function Intercalar(d As Integer) As Integer
        Dim ac As Integer
        Dim n1, n2 As NEnt
        n1 = New NEnt
        n2 = New NEnt
        While (n > 0) And (d > 0)
            n1.n = n Mod 10
            n = n \ 10
            ac = (ac * 10 ^ n1.CantDig()) + n1.n
            n2.n = d Mod 10
            d = d \ 10
            ac = (ac * 10 ^ n2.CantDig()) + n2.n
        End While
        If (n > 0) Then
            While (n <> 0)
                n1.n = n Mod 10
                n = n \ 10
                ac = (ac * 10 ^ n1.CantDig()) + n1.n
            End While
        End If
        If (d > 0) Then
            While (d <> 0)
                n2.n = d Mod 10
                d = d \ 10
                ac = (ac * 10 ^ n2.CantDig()) + n2.n
            End While
        End If
        Return ac
    End Function
    Public Function EliminarDigNumEnt(nn As Integer) As Integer
        Dim n1, n2, c As Integer
        Dim b As Boolean
        c = 1
        While (n > 0) And (b = False)
            n1 = n Mod 10
            n = n \ 10
            If (n1 <> nn) Then
                n2 = (n1 * c) + n2
                c = c * 10
            Else
                b = True
            End If
        End While
        n1 = (n * c) + n2
        Return n1
    End Function
    Public Function eliminardigrepetidos(d As Integer) As Integer
        Dim n1, n2, c As Integer
        c = 1
        While (n > 0)
            n1 = n Mod 10
            n = n \ 10
            If (n1 <> d) Then
                n2 = (n1 * c) + n2
                c = c * 10
            End If
        End While
        Return n2
    End Function
    Public Function Ultimafilaprimos() As Double
        Dim n2, c, n3, c1 As Integer
        Dim na As New NEnt
        na = New NEnt
        c = 1
        c1 = 1
        While (n > 0)
            na.n = n Mod 10
            n = n \ 10
            If (na.VerfPrimo() = True) Then
                n2 = (na.n * c) + n2
                c = c * 10
            Else
                n3 = (na.n * c1) + n3
                c1 = c1 * 10
            End If
        End While
        na.n = (n3 * c) + n2
        Return na.n
    End Function
    Public Function verificardigpertenecenunentND(d As Integer, nd As Integer) As Boolean
        Dim n1, aux As Integer
        Dim b As Boolean
        Dim n2 As NEnt
        n2 = New NEnt
        aux = n
        While (n > 0) And (b = False)
            n1 = n Mod 10 ^ nd
            n = n \ 10 ^ nd
            If (n1 = d) Then
                b = True
            End If
        End While
        n = aux
        Return b
    End Function
    Public Function ContarDigDiferente(nd As Integer) As Integer
        Dim n1, aux, c, c1 As Integer
        Dim ac As NEnt
        aux = n
        ac = New NEnt
        c1 = 1
        If (nd = 1) Then
            While (n > 0)
                n1 = n Mod 10
                n = n \ 10
                If (ac.verificardigpertenecenunentND(n1, nd) = False) Then
                    ac.n = (n1 * c1) + ac.n
                    c1 = c1 * 10
                    c = c + 1
                End If
            End While
        Else
            While (n > 0)
                n1 = n Mod 10 ^ nd
                n = n \ 10 ^ nd
                If (ac.verificardigpertenecenunentND(n1, nd) = False) Then
                    ac.n = (n1 * 10 ^ ac.CantDig()) + ac.n
                    c = c + 1
                End If
            End While
        End If
        n = aux
        Return c
    End Function
    Public Sub rotardigultimodigaprimerapos()
        Dim n1, n2 As Integer
        n1 = n Mod 10
        n = n \ 10
        n2 = (n1 * 10 ^ CantDig()) + n
        n = n2
    End Sub
    Public Sub rotarprimerdigultimapos()
        Dim n1, n2, n3, c As Integer
        c = 1
        For i = 1 To (CantDig() - 1)
            n1 = n Mod 10
            n = n \ 10
            n2 = (n1 * c) + n2
            c = c * 10
        Next
        n3 = (n2 * 10) + n
        n = n3
    End Sub
    Public Function menorND(nd As Integer) As Integer
        Dim n1, n2, aux As Integer
        aux = n
        n2 = n Mod 10 ^ nd
        n = n \ 10 ^ nd
        While (n > 0)
            n1 = n Mod 10 ^ nd
            n = n \ 10 ^ nd
            If (n1 < n2) Then
                n2 = n1
            End If
        End While
        n = aux
        Return n2
    End Function
    Public Function EliminardignumenND(d As Integer, nd As Integer) As Integer
        Dim n1, n3, aux As Integer
        Dim b As Boolean
        Dim n2 As NEnt
        n2 = New NEnt
        aux = n
        While (n > 0) And (b = False)
            n1 = n Mod 10 ^ nd
            n = n \ 10 ^ nd
            If (n1 <> d) Then
                n2.n = (n1 * 10 ^ n2.CantDig()) + n2.n
            Else
                b = True
            End If
        End While
        n3 = (n * 10 ^ n2.CantDig()) + n2.n
        n = aux
        Return n3
    End Function
    Public Function ordenarascendeteND(nd As Integer) As Integer
        Dim n2, aux As Integer
        Dim n1 As NEnt
        n1 = New NEnt
        aux = n
        For i = 1 To n
            n1.n = menorND(nd)
            n2 = (n2 * 10 ^ n1.CantDig()) + n1.n
            n = EliminardignumenND(n1.n, nd)
        Next
        n = aux
        Return n2
    End Function
    Public Function verificarsiestaordenadoND(nd As Integer) As Boolean
        Dim n1 As NEnt
        Dim aux, n2 As Integer
        n1 = New NEnt
        aux = n
        n1.n = n
        n2 = n1.ordenarascendeteND(nd)
        n = aux
        Return n = n2
    End Function
    Public Function Verificarsilosdigitosnoserepiten(nd As Integer) As Boolean
        Dim aux, n1 As Integer
        Dim b As Boolean
        Dim copy As NEnt
        aux = n
        copy = New NEnt
        b = True
        copy.n = n
        While (n > 0) And (b = True)
            n1 = n Mod 10 ^ nd
            n = n \ 10 ^ nd
            If (copy.Frecuencia(n1) >= 2) Then
                b = False
            End If
        End While
        n = aux
        Return b
    End Function
    Public Sub Segmentarendigprimosynoprimos(nd As Integer)
        Dim n1, npri, nnopri As NEnt
        n1 = New NEnt
        npri = New NEnt
        nnopri = New NEnt
        While (n > 0)
            n1.n = n Mod 10 ^ nd
            n = n \ 10 ^ nd
            If (n1.VerfPrimo() = True) Then
                npri.n = (n1.n * 10 ^ npri.CantDig()) + npri.n
            Else
                nnopri.n = (n1.n * 10 ^ nnopri.CantDig()) + nnopri.n
            End If
        End While
        n1.n = (npri.n * 10 ^ nnopri.CantDig()) + nnopri.n
        n = n1.n
    End Sub
    Public Function Cortardig(d As Integer) As Integer
        Dim n1, aux, n2, c As Integer
        Dim na As NEnt
        Dim b As Boolean = True
        na = New NEnt
        aux = n
        c = 1
        If (d = 0) Then
            na.n = 1
        Else
            na.n = d
        End If
        While (n > 0) And (b = True)
            n1 = n Mod 10 ^ na.CantDig()
            If (n1 <> d) Then
                n1 = n Mod 10
                n2 = (n1 * c) + n2
                c = c * 10
                n = n \ 10
            Else
                n = n \ 10 ^ na.CantDig()
                b = False
            End If
        End While
        n1 = (n * c) + n2
        aux = n
        Return n1
    End Function
    Public Function verificarfiboysielsguienteescontinuaciondelmprimerfibo(x As NEnt) As Boolean
        Dim a, b, c, aux As Integer
        Dim b1 As Boolean
        b1 = False
        a = -1 : b = 1 : c = 0
        aux = n
        If (n = 1) And (x.n = 1) Then
            Return True
        End If
        While (c < n)
            c = a + b
            a = b
            b = c
        End While
        If (c = n) Then
            c = a + b
            If (c = x.n) Then
                b1 = True
            End If
        End If
        n = aux
        Return b1
    End Function
    Public Function IntecarlarND(n2 As Integer, nd As Integer) As Long
        Dim acu As Long = 0
        While (n > 0) Or (n2 > 0)
            If (n > 0) Then
                acu = ((acu * 10 ^ nd) + n Mod 10 ^ nd)
                n = n \ 10 ^ nd
            End If
            If (n2 > 0) Then
                acu = ((acu * 10 ^ nd) + n2 Mod 10 ^ nd)
                n2 = n2 \ 10 ^ nd
            End If
        End While
        Return acu
    End Function
    Public Function ContardigconCeromas() As Integer
        Dim i, aux As Integer
        i = 0 : aux = 0
        aux = n
        If (n > 0) Then
            While (n > 0)
                n = n \ 10
                i = i + 1
            End While
        Else
            i = 1
        End If
        n = aux
        Return i
    End Function
    Public Function ParImparND(nd As Integer, d As NEnt) As Double
        Dim aux As Integer
        Dim n1, npar, nimpar As NEnt
        aux = n
        n1 = New NEnt : npar = New NEnt : nimpar = New NEnt
        While (n > 0)
            n1.n = n Mod 10 ^ nd
            n = n \ 10 ^ nd
            If (n1.VerfPar() = True) Then
                npar.n = (n1.n * 10 ^ npar.CantDig()) + npar.n
            Else
                nimpar.n = (n1.n * 10 ^ nimpar.CantDig()) + nimpar.n
            End If
        End While
        n = aux
        d.Cargar(nimpar.n)
        Return npar.n
    End Function
    Public Sub Eliminarlosterminoscentrales()
        Dim n1, c, i As Integer
        Dim ac As NEnt
        n1 = 0 : c = 0 : i = 1 : ac = New NEnt
        While (n > 0) And (c <> 2)
            n1 = n Mod 10
            n = n \ 10
            If ((CantDig() \ 2) + 1 = i) Or ((CantDig() \ 2) = i) Then
                c = c + 1
            Else
                ac.n = (n1 * 10 ^ ac.CantDig()) + ac.n
            End If
            i = i + 1
        End While
        n = (n * 10 ^ ac.CantDig()) + ac.n
    End Sub
    Public Function mod1() As Integer
        Dim n1 As Integer
        n1 = n \ 2
        Return n1
    End Function
    Public Function Exponenteconsumas(exp As Integer) As Double
        Dim f As Integer
        Dim c, c1 As Integer
        c = 0
        c1 = n
        If (exp = 0) Then
            f = 1
            Return f
        Else
            If (exp = 1) Then
                Return n
            End If
        End If
        For i = 1 To (exp - 1)
            While (n > c)
                f = f + c1
                c = c + 1
            End While
            c = 1
            c1 = f
        Next
        Return f
    End Function
    Public Function prueba1() As Integer
        Dim n1 As Integer
        n1 = n \ 2
        Return n1
    End Function
    Public Function Invertir() As Integer
        Dim n1, ac, aux As Integer
        aux = n
        While (n > 0)
            n1 = n Mod 10
            n = n \ 10
            ac = (ac * 10) + n1
        End While
        n = aux
        Return ac
    End Function
    Public Function Capicua() As Boolean
        Dim n1 As Integer
        Dim b As Boolean
        n1 = n : b = False
        If (n1 = Invertir()) Then
            b = True
        End If
        Return b
    End Function
    Public Sub SegmentarCapicuaND(nd As Integer)
        Dim n1, ncapi, nnocapi As NEnt
        n1 = New NEnt : ncapi = New NEnt : nnocapi = New NEnt
        While (n > 0)
            n1.n = n Mod 10 ^ nd
            n = n \ 10 ^ nd
            If (n1.Capicua() = True) Then
                ncapi.n = (n1.n * 10 ^ ncapi.CantDig()) + ncapi.n
            Else
                nnocapi.n = (n1.n * 10 ^ nnocapi.CantDig()) + nnocapi.n
            End If
        End While
        n = (ncapi.n * 10 ^ nnocapi.CantDig()) + nnocapi.n
    End Sub
    Public Function NumMayor() As Integer
        Dim n1, n2, aux As Integer
        aux = n
        n1 = n Mod 10
        n = n \ 10
        While (n > 0)
            n2 = n Mod 10
            n = n \ 10
            If (n2 > n1) Then
                n1 = n2
            End If
        End While
        n = aux
        Return n1
    End Function
    Public Sub Mayormenor()
        Dim ac, c As Integer
        Dim n1 As NEnt
        n1 = New NEnt : c = 1
        While (n > 0)
            n1.n = n1.NumMayor()
            ac = (ac * 10) + n1.n
            n = EliminarDigNumEnt(n1.n)
        End While
        n = ac
    End Sub
    Public Function IntercalarOrdenado() As Integer
        Dim aux, c, c1, n2, ac As Integer
        Dim n1, dif, dif1 As NEnt
        n1 = New NEnt : dif = New NEnt : dif1 = New NEnt : c = 1 : c1 = 1
        aux = n
        While (n > 0)
            n1.n = n Mod 10
            n = n \ 10
            If (n1.VerfPrimo() = True) Then
                dif.n = (n1.n * c) + dif.n
                c = c * 10
            Else
                dif1.n = (n1.n * c1) + dif1.n
                c1 = c1 * 10
            End If
        End While
        c = 1
        dif.Mayormenor()
        dif1.Mayormenor()
        While (dif.n > 0) And (dif1.n > 0)
            n1.n = dif.n Mod 10
            dif.n = dif.n \ 10
            ac = (n1.n * c) + ac
            c = c * 10
            n2 = dif1.n Mod 10
            dif1.n = dif1.n \ 10
            ac = (n2 * c) + ac
            c = c * 10
        End While
        n = aux
        Return ac
    End Function
    Public Function SinPinponear() As Integer
        Dim b As Integer
        Dim n1 As NEnt
        Dim ac, aux As Integer
        n1 = New NEnt : ac = 0 : b = 1
        aux = n
        While (n > 0)
            n1.n = n Mod 10
            n = n \ 10
            If (n1.VerfPar() = True) Then
                ac = (n1.n - ac) * b
                b = b * -1
            End If
        End While
        n = aux
        Return ac
    End Function
    Public Sub Segementar()
        Dim ac1, ac, c, c1 As Integer
        Dim n1 As NEnt
        n1 = New NEnt
        c = 1 : c1 = 1
        While (n > 0)
            n1.n = n Mod 10
            n = n \ 10
            If ((n1.VerfPrimo) = True) Then
                ac = (n1.n * c1) + ac
                c1 = c1 * 10
            Else
                ac1 = (n1.n * c) + ac1
                c = c * 10
            End If
        End While
        n = (ac * c) + ac1
    End Sub
    Public Function AcumulardigFIboo() As Double
        Dim f As Double
        Dim n1 As NEnt
        Dim b As Boolean = True
        Dim aux As Integer
        n1 = New NEnt
        aux = n
        While (n > 0)
            n1.n = n Mod 10
            n = n \ 10
            If (n1.VerfFibo() = True) Then
                If (b = True) Then
                    f = f + (1 / n1.Factorial())
                    b = False
                Else
                    f = f - (1 / n1.Factorial())
                    b = True
                End If
            End If
        End While
        n = aux
        Return f
    End Function
    Public Function AcumulardigFIbooo() As String
        Dim f As String
        Dim n1 As NEnt
        Dim b As Boolean = True
        Dim aux As Integer
        n1 = New NEnt
        aux = n : f = ""
        While (n > 0)
            n1.n = n Mod 10
            n = n \ 10
            If (n1.VerfFibo() = True) Then
                If (b = True) Then
                    f = f + "+" + "1" + "/" + Str(n1.n)
                    b = False
                Else
                    f = f + "-" + "1" + "/" + Str(n1.n)
                    b = True
                End If
            End If
        End While
        n = aux
        Return f
    End Function
    Public Function Ejercicio2(n1 As NEnt, n2 As NEnt, n3 As NEnt) As Long
        Dim Mayor, medio1, medio2, menor As NEnt
        Mayor = New NEnt
        menor = New NEnt
        medio1 = New NEnt
        medio2 = New NEnt
        If (n > n1.n) And (n > n2.n) And (n > n3.n) Then
            Mayor.n = n
            If (n1.n < n2.n) And (n1.n < n3.n) Then
                menor.n = n1.n
                If (n2.n < n3.n) Then
                    medio1.n = n2.n
                    medio2.n = n3.n
                Else
                    If (n3.n < n2.n) Then
                        medio1.n = n3.n
                        medio2.n = n2.n
                    End If
                End If
            Else
                If (n2.n < n1.n) And (n2.n < n3.n) Then
                    menor.n = n2.n
                    If (n1.n < n3.n) Then
                        medio1.n = n1.n
                        medio2.n = n3.n
                    Else
                        If (n3.n < n1.n) Then
                            medio1.n = n3.n
                            medio2.n = n1.n
                        End If
                    End If
                Else
                    If (n3.n < n1.n) And (n3.n < n2.n) Then
                        menor.n = n3.n
                        If (n1.n < n2.n) Then
                            medio1.n = n1.n
                            medio2.n = n2.n
                        Else
                            If (n2.n < n1.n) Then
                                medio1.n = n2.n
                                medio2.n = n1.n
                            End If
                        End If
                    End If
                End If
            End If
        End If
        '------------------------------------------'
        If (n1.n > n) And (n1.n > n2.n) And (n1.n > n3.n) Then
            Mayor.n = n1.n
            If (n < n2.n) And (n < n3.n) Then
                menor.n = n
                If (n2.n < n3.n) Then
                    medio1.n = n2.n
                    medio2.n = n3.n
                Else
                    If (n3.n < n2.n) Then
                        medio1.n = n3.n
                        medio2.n = n2.n
                    End If
                End If
            Else
                If (n2.n < n) And (n2.n < n3.n) Then
                    menor.n = n2.n
                    If (n < n3.n) Then
                        medio1.n = n
                        medio2.n = n3.n
                    Else
                        If (n3.n < n) Then
                            medio1.n = n3.n
                            medio2.n = n
                        End If
                    End If
                Else
                    If (n3.n < n) And (n3.n < n2.n) Then
                        menor.n = n3.n
                        If (n < n2.n) Then
                            medio1.n = n
                            medio2.n = n2.n
                        Else
                            If (n2.n < n) Then
                                medio1.n = n2.n
                                medio2.n = n
                            End If
                        End If
                    End If
                End If
            End If
        End If
        '-----------------------------------------'
        If (n2.n > n) And (n2.n > n1.n) And (n2.n > n3.n) Then
            Mayor.n = n2.n
            If (n < n1.n) And (n < n3.n) Then
                menor.n = n
                If (n1.n < n3.n) Then
                    medio1.n = n1.n
                    medio2.n = n3.n
                Else
                    If (n3.n < n1.n) Then
                        medio1.n = n3.n
                        medio2.n = n1.n
                    End If
                End If
            Else
                If (n1.n < n) And (n1.n < n3.n) Then
                    menor.n = n1.n
                    If (n < n3.n) Then
                        medio1.n = n
                        medio2.n = n3.n
                    Else
                        If (n3.n < n) Then
                            medio1.n = n3.n
                            medio2.n = n
                        End If
                    End If
                Else
                    If (n3.n < n) And (n3.n < n1.n) Then
                        menor.n = n3.n
                        If (n < n1.n) Then
                            medio1.n = n
                            medio2.n = n1.n
                        Else
                            If (n2.n < n) Then
                                medio1.n = n1.n
                                medio2.n = n
                            End If
                        End If
                    End If
                End If
            End If
        End If
        '========================================================================'
        If (n3.n > n) And (n3.n > n1.n) And (n3.n > n2.n) Then
            Mayor.n = n3.n
            If (n < n1.n) And (n < n2.n) Then
                menor.n = n
                If (n1.n < n2.n) Then
                    medio1.n = n1.n
                    medio2.n = n2.n
                Else
                    If (n2.n < n1.n) Then
                        medio1.n = n2.n
                        medio2.n = n1.n
                    End If
                End If
            Else
                If (n1.n < n) And (n1.n < n2.n) Then
                    menor.n = n1.n
                    If (n < n2.n) Then
                        medio1.n = n
                        medio2.n = n2.n
                    Else
                        If (n2.n < n) Then
                            medio1.n = n2.n
                            medio2.n = n
                        End If
                    End If
                Else
                    If (n2.n < n) And (n2.n < n1.n) Then
                        menor.n = n2.n
                        If (n < n1.n) Then
                            medio1.n = n
                            medio2.n = n1.n
                        Else
                            If (n2.n < n) Then
                                medio1.n = n2.n
                                medio2.n = n
                            End If
                        End If
                    End If
                End If
            End If
        End If
        menor.n = (menor.n * 10 ^ medio1.CantDig()) + medio1.n
        menor.n = (menor.n * 10 ^ medio2.CantDig()) + medio2.n
        menor.n = (menor.n * 10 ^ Mayor.CantDig()) + Mayor.n
        Return menor.n
    End Function
    Public Function InsertarEnOrdenUnDigEntero(d As Integer) As Long
        Dim n1, aux As Integer
        Dim acu As NEnt
        Dim b As Boolean = False
        aux = n : acu = New NEnt
        While (n >= 0) And (b = False)
            n1 = n Mod 10
            n = n \ 10
            If (d <= n1) Then
                acu.n = (n1 * 10 ^ acu.CantDig()) + acu.n
            Else
                acu.n = (d * 10 ^ acu.CantDig()) + acu.n
                acu.n = (n1 * 10 ^ acu.CantDig()) + acu.n
                b = True
            End If
        End While
        n1 = (n * 10 ^ acu.CantDig()) + acu.n
        aux = n
        Return n1
    End Function
    Public Sub DigMenosRepetido()
        Dim n1, n2, d As Integer
        Dim copy As NEnt
        copy = New NEnt
        copy.n = n
        n2 = n Mod 10
        d = n2
        n2 = Frecuencia(n2)
        n = n \ 10
        While (n > 0)
            n1 = n Mod 10
            n = n \ 10
            If (copy.Frecuencia(n1) < n2) Then
                n2 = copy.Frecuencia(n1)
                d = n1
            End If
        End While
        n = d
    End Sub
    Public Function VerificarSegmentar() As Boolean
        Dim pri, npri, c, c1, aux As Integer
        Dim n1 As NEnt = New NEnt
        aux = n
        c = 1 : c1 = 1
        While (n > 0)
            n1.n = n Mod 10
            n = n \ 10
            If (n1.VerfPrimo() = True) Then
                pri = (n1.n * c) + pri
                c = c * 10
            Else
                npri = (n1.n * c1) + npri
                c1 = c1 * 10
            End If
        End While
        n = aux
        pri = (pri * c1) + npri
        Return pri = n
    End Function
    Public Function AcumularConFibo() As Double
        Dim f As Double
        Dim aux, c, b As Integer
        Dim n1 As NEnt = New NEnt
        Dim copy As NEnt = New NEnt
        b = -1 : c = 2
        copy.n = n
        aux = n
        While (n > 0)
            n1.n = n Mod 10
            n = n \ 10
            If (copy.Frecuencia(n1.n) >= 2) Then
                f = f - ((1 / (n1.Factorial() + c)) ^ (1 / c)) * b
                c = c + 2
                b = b * -1
            End If
        End While
        Return f
    End Function
    Public Function AcumularConDigFibonacciii() As Double
        Dim n1 As NEnt = New NEnt
        Dim c, aux As Integer
        Dim b As Integer = 1
        Dim f As Double
        c = 10
        aux = n
        While (n > 0)
            n1.n = n Mod 10
            n = n \ 10
            If (n1.VerfFibo() = True) Then
                f = f - n1.Factorial() ^ (1 / c) * b
                b = b * -1
                c = c - 2
            End If
        End While
        n = aux
        Return f
    End Function
End Class
