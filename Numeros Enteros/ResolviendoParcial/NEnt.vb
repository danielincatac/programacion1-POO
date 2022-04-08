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
    Public Function VerfFibo() As Boolean
        Dim a, b, c As Integer
        a = -1 : b = 1 : c = 0
        While (c < n)
            c = a + b
            a = b
            b = c
        End While
        Return (c = n)
    End Function
    Public Function Factorial() As Double
        Dim f As Integer = 1
        For i = 1 To n
            f = f * i
        Next
        Return f
    End Function
    Public Function AcumularDigFibo() As Double
        Dim f As Double = 0
        Dim c, aux, b As Integer
        Dim n1 As NEnt = New NEnt
        aux = n : c = 10 : b = 1
        While (n > 0)
            n1.n = n Mod 10
            n = n \ 10
            If (n1.VerfFibo() = True) Then
                f = f - n1.Factorial() ^ (1 / c) * b
                c = c - 2
                b = b * -1
            End If
        End While
        Return f
    End Function
    Public Function CantDig() As Long
        If (n <> 0) Then
            Return Math.Truncate(Math.Log10(n)) + 1
        Else
            Return 0
        End If
    End Function
    Public Function Ordenardescendente(n1 As NEnt, n2 As NEnt, n3 As NEnt) As Long
        Dim mayor, menor, medio1, medio2 As NEnt
        mayor = New NEnt : menor = New NEnt : medio1 = New NEnt : medio2 = New NEnt
        If (n >= n1.n) And (n >= n2.n) And (n >= n3.n) Then
            mayor.n = n
            If (n1.n >= n2.n) And (n1.n >= n3.n) Then
                medio2.n = n1.n
                If (n2.n >= n3.n) Then
                    medio1.n = n2.n
                    menor.n = n3.n
                Else
                    medio1.n = n3.n
                    menor.n = n2.n
                End If
            Else
                If (n2.n >= n1.n) And (n2.n >= n3.n) Then
                    medio2.n = n2.n
                    If (n1.n >= n3.n) Then
                        medio1.n = n1.n
                        menor.n = n3.n
                    Else
                        medio1.n = n3.n
                        menor.n = n1.n
                    End If
                Else
                    If (n3.n >= n1.n) And (n3.n >= n2.n) Then
                        medio2.n = n3.n
                        If (n1.n >= n2.n) Then
                            medio1.n = n1.n
                            menor.n = n2.n
                        Else
                            medio1.n = n2.n
                            menor.n = n1.n
                        End If
                    End If
                End If
            End If
        End If
        Return mayor.UnirCuatroNum(medio2, medio1, menor)
    End Function
    Public Function OrdenardescendenteObjeto(n1 As NEnt, n2 As NEnt, n3 As NEnt) As Long
        Dim nw As NEnt = New NEnt
        Dim na As NEnt = New NEnt
        na.n = n
        If (Ordenardescendente(n1, n2, n3) <> 0) Then
            nw.n = Ordenardescendente(n1, n2, n3)
        Else
            If (n1.Ordenardescendente(na, n2, n3) <> 0) Then
                nw.n = n1.Ordenardescendente(na, n2, n3)
            Else
                If (n2.Ordenardescendente(na, n1, n3) <> 0) Then
                    nw.n = n2.Ordenardescendente(na, n1, n3)
                Else
                    If (n3.Ordenardescendente(na, n1, n2) <> 0) Then
                        nw.n = n3.Ordenardescendente(na, n1, n3)
                    End If
                End If
            End If
        End If
        Return nw.n
    End Function
    Public Function UnirCuatroNum(n1 As NEnt, n2 As NEnt, n3 As NEnt) As Long
        n = (n * 10 ^ n1.CantDig()) + n1.n
        n = (n * 10 ^ n2.CantDig()) + n2.n
        n = (n * 10 ^ n3.CantDig()) + n3.n
        Return n
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
    Public Function IntercalarPrimoNoPrimo(nd As Integer) As Long
        Dim aux, c, c1, acu As Integer
        Dim dig As NEnt = New NEnt
        Dim primo As NEnt = New NEnt
        Dim noprimo As NEnt = New NEnt
        aux = n : c = 1 : c1 = 1
        While (n > 0)
            dig.n = n Mod 10 ^ nd
            n = n \ 10 ^ nd
            If (dig.Capicua() = True) Then
                primo.n = (dig.n * c) + primo.n
                c = c * 10 ^ nd
            Else
                noprimo.n = (noprimo.n * c1) + dig.n
                c1 = c1 * 10 ^ nd
            End If
        End While
        While (primo.n > 0) Or (noprimo.n > 0)
            If (primo.n <> 0) Then
                c = primo.n Mod 10 ^ nd
                primo.n = primo.n \ 10 ^ nd
                acu = (acu * 10 ^ nd) + c
            End If
            If (noprimo.n > 0) Then
                c1 = noprimo.n Mod 10 ^ nd
                noprimo.n = noprimo.n \ 10 ^ nd
                acu = (acu * 10 ^ nd) + c1
            End If
        End While
        n=aux
        Return acu
    End Function
    Public Function UnirDosNumeros(n1 As NEnt) As Long
        n = (n * 10 ^ n1.CantDig()) + n1.n
        Return n
    End Function
    Public Function Invertir() As Integer
        Dim n1, aux, acu As Integer
        aux = n
        While (n > 0)
            n1 = n Mod 10
            n = n \ 10
            acu = (acu * 10) + n1
        End While
        n = aux
        Return acu
    End Function
    Public Function Capicua() As Boolean
        Dim n1 As Integer
        n1 = Invertir()
        Return n = n1
    End Function
    Public Function Frecuencia(d As Integer) As Integer
        Dim c, n1, aux As Integer
        aux = n
        While (n > 0)
            n1 = n Mod 10
            n = n \ 10
            If (n1 = d) Then
                c = c + 1
            End If
        End While
        n = aux
        Return c
    End Function
    Public Sub Ejercicio1()
        Dim n1 As NEnt = New NEnt
        Dim copy As NEnt = New NEnt
        While (n > 0)
            n1.n = n Mod 10
            n = n \ 10
            If (n1.VerfPrimo() = True) And (copy.Frecuencia(n1.n) = 0) Then
                copy.n = (copy.n * 10) + n1.n
            End If
        End While
        n = copy.n
    End Sub
    Public Sub Ejercicio2()
        Dim c, c1, n1 As Integer
        Dim copy As NEnt = New NEnt
        Dim acu As NEnt = New NEnt
        Dim acu2 As NEnt = New NEnt
        c = 1 : c1 = 1 : copy.n = n
        While (n > 0)
            n1 = n Mod 10
            n = n \ 10
            If (copy.Frecuencia(n1) = 1) Then
                acu.n = (n1 * c) + acu.n
                c = c * 10
            Else
                acu2.n = (n1 * c1) + acu2.n
                c1 = c1 * 10
            End If
        End While
        acu.OrdenarMenorMayor()
        acu2.OrdenarMenorMayor()
        acu2.n = (acu2.n * c) + acu.n
        n = acu2.n
    End Sub
    Public Function Menordig() As Integer
        Dim n2, n1, aux As Integer
        aux = n
        n2 = n Mod 10
        n = n \ 10
        While (n > 0)
            n1 = n Mod 10
            n = n \ 10
            If (n1 < n2) Then
                n2 = n1
            End If
        End While
        n = aux
        Return n2
    End Function
    Public Function EliminarDigNumEnt(d As Integer) As Integer
        Dim n1, acu, c, aux As Integer
        Dim b As Boolean = True
        c = 1 : aux = n
        While (n > 0) And (b = True)
            n1 = n Mod 10
            n = n \ 10
            If (n1 <> d) Then
                acu = (n1 * c) + acu
                c = c * 10
            Else
                b = False
            End If
        End While
        n1 = (n * c) + acu
        n = aux
        Return n1
    End Function
    Public Sub OrdenarMenorMayor()
        Dim c As Integer = 1
        Dim n1, acu As Integer
        While (n > 0)
            n1 = Menordig()
            acu = (acu * 10) + n1
            n = EliminarDigNumEnt(n1)
        End While
        n = acu
    End Sub
End Class
