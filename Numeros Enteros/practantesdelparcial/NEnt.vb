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
    Public Sub Invertir()
        Dim n1, ac As Integer
        n1 = 0 : ac = 0
        While (n > 0)
            n1 = n Mod 10
            n = n \ 10
            ac = (ac * 10) + n1
        End While
        n = ac
    End Sub
    Public Function VerfCapi() As Boolean
        Dim n1, aux As Integer
        Dim b As Boolean
        n1 = 0 : aux = 0
        n1 = n
        aux = n
        Invertir()
        If (n1 = n) Then
            b = True
        Else
            b = False
        End If
        n = aux
        Return b
    End Function
    Public Function CantDig() As Integer
        Dim c, aux As Integer
        c = 0 : aux = 0
        aux = n
        While (n > 0)
            n = n \ 10
            c = c + 1
        End While
        n = aux
        Return c
    End Function
    Public Sub SegmentarCapiNoCapiND(nd As Integer)
        Dim n1, ac1 As NEnt
        Dim ac As Integer
        n1 = New NEnt : ac = 0 : ac1 = New NEnt
        If (nd = 1) Or (nd = 0) Then
            n = n
        Else
            While (n > 0)
                n1.n = n Mod 10 ^ nd
                n = n \ 10 ^ nd
                If (n1.VerfCapi() = True) Then
                    ac = (ac * 10 ^ n1.CantDig()) + n1.n
                Else
                    ac1.n = (n1.n * 10 ^ ac1.CantDig()) + ac1.n
                End If
            End While
            n = (ac * 10 ^ ac1.CantDig()) + ac1.n
        End If
    End Sub
    Public Function VerfPrimo() As Boolean
        Dim c, aux As Integer
        Dim b As Boolean
        c = 0 : aux = 0
        aux = n
        For i = 1 To n
            If ((n Mod i) = 0) Then
                c = c + 1
            End If
        Next
        If (c = 2) Then
            b = True
        Else
            b = False
        End If
        n = aux
        Return b
    End Function
    Public Function Factorial() As Double
        Dim f, aux As Integer
        f = 1 : aux = 0
        aux = n
        For i = 1 To n
            f = f * i
        Next
        n = aux
        Return f
    End Function
    Public Function AcumularConDigPrimos(nd As Integer) As Double
        Dim f As Double
        Dim n1 As NEnt
        Dim c, aux, bandera, c1, c2 As Integer
        n1 = New NEnt : c = 2 : aux = 0 : bandera = 0 : c1 = 0 : c2 = 0
        aux = n
        While (n > 0)
            n1.n = n Mod 10 ^ nd
            n = n \ 10 ^ nd
            If (n1.VerfPrimo() = True) Then
                If (bandera = 0) Then
                    f = f + n1.Factorial ^ (1 / (c * c1))
                    c1 = c1 + (2 - c2)
                    c2 = 1
                    bandera = 1
                Else
                    f = f - n1.Factorial ^ (1 / (c * c1))
                    c1 = c1 + (2 - c2)
                    bandera = 0
                End If
            End If
        End While
        aux = n
        Return f
    End Function
End Class
