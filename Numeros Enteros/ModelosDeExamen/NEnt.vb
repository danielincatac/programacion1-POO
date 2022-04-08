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
    Public Sub Invetir()
        Dim n1, ac As Integer
        While (n > 0)
            n1 = n Mod 10
            n = n \ 10
            ac = (ac * 10) + n1
        End While
        n = ac
    End Sub
    Public Function VerfCapi() As Boolean
        Dim n1 As NEnt
        n1 = New NEnt
        n1.n = n
        Invetir()
        Return n1.n = n
    End Function
    Public Function CantDig() As Integer
        If (n <> 0) Then
            Return Math.Truncate(Math.Log10(n)) + 1
        Else
            Return 0
        End If
    End Function
    Public Sub SegmentarCapiNoCapiND(nd As Integer)
        Dim n1, ac, ac1 As NEnt
        n1 = New NEnt : ac = New NEnt : ac1 = New NEnt
        If (nd = 1) Then
            n = n
        Else
            While (n > 0)
                n1.n = n Mod 10 ^ nd
                n = n \ 10 ^ nd
                If (n1.VerfCapi() = True) Then
                    ac.n = (ac.n * 10 ^ n1.CantDig()) + n1.n
                Else
                    ac1.n = (n1.n * 10 ^ ac1.CantDig()) + ac1.n
                End If
            End While
            n = (ac.n * 10 ^ ac1.CantDig()) + ac1.n
        End If
    End Sub
    Public Function VerfPrimo() As Boolean
        Dim c, aux As Integer
        aux = n
        For i = 1 To n
            If ((n Mod i) = 0) Then
                c = c + 1
            End If
        Next
        n = aux
        Return c = 2
    End Function
    Public Function Factorial() As Double
        Dim f As Double
        f = 1
        For i = 1 To n
            f = f * i
        Next
        Return f
    End Function
    Public Function AcumularPrimoND(nd As Integer) As Double
        Dim n1 As NEnt
        Dim ac As Double
        Dim c, aux, b As Integer
        n1 = New NEnt : aux = n : b = 1 : c = 2
        While (n > 0)
            n1.n = n Mod 10 ^ nd
            n = n \ 10 ^ nd
            If (n1.VerfPrimo() = True) Then
                ac = ac + (n1.Factorial() ^ (1 / c)) * b
                c = c + 2
                b = b * -1
            End If
        End While
        n = aux
        Return ac
    End Function
End Class

