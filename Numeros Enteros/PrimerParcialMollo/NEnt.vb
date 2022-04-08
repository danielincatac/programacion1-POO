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
        a = -1 : b = 1
        While (c < n)
            c = a + b
            a = b
            b = c
        End While
        Return c = n
    End Function
    Public Function Factorial() As Double
        Dim f As Integer = 1
        For i = 1 To n
            f = f * i
        Next
        Return f
    End Function
    Public Function CantDig() As Integer
        If (n <> 0) Then
            Return Math.Truncate(Math.Log10(n)) + 1
        Else
            Return 0
        End If
    End Function
    Public Function AcumularConDigFibonacci() As Double
        Dim n1 As NEnt = New NEnt
        Dim c, aux As Integer
        Dim b As Boolean = True
        Dim f As Double
        c = 10
        aux = n
        While (n > 0)
            n1.n = n Mod 10
            n = n \ 10
            If (n1.VerfFibo() = True) Then
                If (b = True) Then
                    f = f - n1.Factorial() ^ (1 / c)
                    c = c - 2
                    b = False
                Else
                    f = f + n1.Factorial() ^ (1 / c)
                    c = c - 2
                    b = True
                End If
            End If
        End While
        n = aux
        Return f
    End Function
    Public Function OrndenardeFormaDescedente(n1 As NEnt, n2 As NEnt, n3 As NEnt) As Long
        Dim Mayor, medio1, medio2, menor As NEnt
        Mayor = New NEnt
        menor = New NEnt
        medio1 = New NEnt
        medio2 = New NEnt
        If (n >= n1.n) And (n >= n2.n) And (n >= n3.n) Then
            Mayor.n = n
            If (n1.n <= n2.n) And (n1.n <= n3.n) Then
                menor.n = n1.n
                If (n2.n <= n3.n) Then
                    medio1.n = n2.n
                    medio2.n = n3.n
                Else
                    If (n3.n <= n2.n) Then
                        medio1.n = n3.n
                        medio2.n = n2.n
                    End If
                End If
            Else
                If (n2.n <= n1.n) And (n2.n <= n3.n) Then
                    menor.n = n2.n
                    If (n1.n <= n3.n) Then
                        medio1.n = n1.n
                        medio2.n = n3.n
                    Else
                        If (n3.n <= n1.n) Then
                            medio1.n = n3.n
                            medio2.n = n1.n
                        End If
                    End If
                Else
                    If (n3.n <= n1.n) And (n3.n <= n2.n) Then
                        menor.n = n3.n
                        If (n1.n <= n2.n) Then
                            medio1.n = n1.n
                            medio2.n = n2.n
                        Else
                            If (n2.n <= n1.n) Then
                                medio1.n = n2.n
                                medio2.n = n1.n
                            End If
                        End If
                    End If
                End If
            End If
        End If
        '------------------------------------------'
        If (n1.n >= n) And (n1.n >= n2.n) And (n1.n >= n3.n) Then
            Mayor.n = n1.n
            If (n <= n2.n) And (n <= n3.n) Then
                menor.n = n
                If (n2.n <= n3.n) Then
                    medio1.n = n2.n
                    medio2.n = n3.n
                Else
                    If (n3.n <= n2.n) Then
                        medio1.n = n3.n
                        medio2.n = n2.n
                    End If
                End If
            Else
                If (n2.n <= n) And (n2.n <= n3.n) Then
                    menor.n = n2.n
                    If (n <= n3.n) Then
                        medio1.n = n
                        medio2.n = n3.n
                    Else
                        If (n3.n <= n) Then
                            medio1.n = n3.n
                            medio2.n = n
                        End If
                    End If
                Else
                    If (n3.n <= n) And (n3.n <= n2.n) Then
                        menor.n = n3.n
                        If (n <= n2.n) Then
                            medio1.n = n
                            medio2.n = n2.n
                        Else
                            If (n2.n <= n) Then
                                medio1.n = n2.n
                                medio2.n = n
                            End If
                        End If
                    End If
                End If
            End If
        End If
        '-----------------------------------------'
        If (n2.n >= n) And (n2.n >= n1.n) And (n2.n >= n3.n) Then
            Mayor.n = n2.n
            If (n <= n1.n) And (n <= n3.n) Then
                menor.n = n
                If (n1.n <= n3.n) Then
                    medio1.n = n1.n
                    medio2.n = n3.n
                Else
                    If (n3.n <= n1.n) Then
                        medio1.n = n3.n
                        medio2.n = n1.n
                    End If
                End If
            Else
                If (n1.n <= n) And (n1.n <= n3.n) Then
                    menor.n = n1.n
                    If (n <= n3.n) Then
                        medio1.n = n
                        medio2.n = n3.n
                    Else
                        If (n3.n <= n) Then
                            medio1.n = n3.n
                            medio2.n = n
                        End If
                    End If
                Else
                    If (n3.n <= n) And (n3.n <= n1.n) Then
                        menor.n = n3.n
                        If (n <= n1.n) Then
                            medio1.n = n
                            medio2.n = n1.n
                        Else
                            If (n2.n <= n) Then
                                medio1.n = n1.n
                                medio2.n = n
                            End If
                        End If
                    End If
                End If
            End If
        End If
        '========================================================================'
        If (n3.n >= n) And (n3.n >= n1.n) And (n3.n >= n2.n) Then
            Mayor.n = n3.n
            If (n <= n1.n) And (n <= n2.n) Then
                menor.n = n
                If (n1.n <= n2.n) Then
                    medio1.n = n1.n
                    medio2.n = n2.n
                Else
                    If (n2.n <= n1.n) Then
                        medio1.n = n2.n
                        medio2.n = n1.n
                    End If
                End If
            Else
                If (n1.n <= n) And (n1.n <= n2.n) Then
                    menor.n = n1.n
                    If (n <= n2.n) Then
                        medio1.n = n
                        medio2.n = n2.n
                    Else
                        If (n2.n <= n) Then
                            medio1.n = n2.n
                            medio2.n = n
                        End If
                    End If
                Else
                    If (n2.n <= n) And (n2.n <= n1.n) Then
                        menor.n = n2.n
                        If (n <= n1.n) Then
                            medio1.n = n
                            medio2.n = n1.n
                        Else
                            If (n2.n <= n) Then
                                medio1.n = n2.n
                                medio2.n = n
                            End If
                        End If
                    End If
                End If
            End If
        End If
        Mayor.n = (Mayor.n * 10 ^ medio2.CantDig()) + medio2.n
        Mayor.n = (Mayor.n * 10 ^ medio1.CantDig()) + medio1.n
        Mayor.n = (Mayor.n * 10 ^ menor.CantDig()) + menor.n
        Return Mayor.n
    End Function
End Class
