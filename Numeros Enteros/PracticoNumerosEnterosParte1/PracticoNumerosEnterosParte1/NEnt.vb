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
    Public Function Invertir(b As Integer) As Integer
        Dim n2, n3 As Integer
        n2 = 0 : n3 = 0
        While (b > 0)
            n2 = b Mod 10
            b = b \ 10
            n3 = (n3 * 10) + n2
        End While
        Return n3
    End Function
  
    Public Function CantDig(b As Integer) As Integer
        Dim i As Integer
        i = 0
        While (b <> 0)
            b = b \ 10
            i = i + 1
        End While
        Return i
    End Function
    Public Function SacarDigPos(b As Integer, pos As Integer) As Integer
        Dim n1, n2, n3, n4 As Integer
        n1 = b
        n2 = CantDig(n1) - pos
        n3 = n1 Mod 10 ^ n2
        n1 = n1 \ 10 ^ n2
        n4 = n1 Mod 10
        n1 = n1 \ 10
        n2 = n1 * 10 ^ CantDig(n3) + n3
        Return n4
    End Function
    Public Function EliminarDigPos(b As Integer, pos As Integer) As Integer
        Dim n1, n2, n3 As Integer
        n1 = b
        n2 = CantDig(n1) - pos
        n3 = n1 Mod 10 ^ n2
        n1 = n1 \ 10 ^ n2
        n1 = n1 \ 10
        n2 = n1 * 10 ^ CantDig(n3) + n3
        Return n2
    End Function
    Public Function VerificarPimo(b As Integer) As Boolean
        Dim n1, c As Integer
        n1 = b
        For i = 1 To n1
            If (n1 Mod i = 0) Then
                c = c + 1
            End If
        Next
        Return c = 2
    End Function
    Public Function VerificarImpar(b As Integer) As Boolean
        Dim n1 As Integer
        Dim b1 As Boolean
        n1 = b
        b1 = True
        If (n1 Mod 2 = 0) Then
            b1 = False
        End If
        Return b1
    End Function
    Public Function Factorial(b As Integer) As Double
        Dim n1, f As Integer
        n1 = 0 : f = 1
        n1 = b
        If (n1 > 0) Then
            While n1 > 0
                f = f * n1
                n1 = n1 - 1
            End While
        End If
        Return f
    End Function
    'Ejercicio # 1'
    Public Function VerficarFibonacci() As Boolean
        Dim a, b, c, n1 As Integer
        a = 0 : b = 0 : c = 0
        n1 = n
        a = -1
        b = 1
        c = a + b
        While (c < n1)
            c = a + b
            a = b
            b = c
        End While
        Return c = n1
    End Function
    'Ejercicio # 2'
    Public Function VerfNumPertSeriRegular(vi As Integer, r As Integer) As Boolean
        Dim n1, t, i As Integer
        n1 = 0 : t = 0 : i = 0
        n1 = n
        t = vi + (i - 1) * r
        While (t < n1)
            t = vi + (i - 1) * r
            i = i + 1
        End While
        Return t = n1
    End Function
    'Ejercicio # 3'
    Public Function AccesardigNDIzaDer(nd As Integer) As String
        Dim n1, n2 As Integer
        Dim s As String
        n1 = 0 : n2 = 0 : s = ""
        n1 = n
        If (CantDig(n1) >= nd) Then
            While (n1 <> 0)
                n2 = n1 Mod 10 ^ nd
                n1 = n1 \ 10 ^ nd
                s = CStr(n2) + "," + s
            End While
        Else
            s = "-1"
        End If
            Return s
    End Function
    'Ejercicio # 4'
    Public Function FiltrardigImpar(nd As Integer) As String
        Dim n1, n2 As Integer
        Dim s As String
        n1 = 0 : n2 = 0 : s = ""
        n1 = n
        While (n1 > 0)
            n2 = n1 Mod 10 ^ nd
            If VerificarImpar(n2) = True Then
                s = s + CStr(n2) + ","
            End If
            n1 = n1 \ 10 ^ nd
        End While
        Return s
    End Function
    'Ejercicio # 5'
    Public Function FiltrardigPrimo(nd As Integer) As String
        Dim n1, n2 As Integer
        Dim s As String
        n1 = 0 : n2 = 0 : s = ""
        n1 = n
        While (n1 > 0)
            n2 = n1 Mod 10 ^ nd
            If (VerificarPimo(n2) = True) Then
                s = s + CStr(n2) + ","
            End If
            n1 = n1 \ 10 ^ nd
        End While
        Return s
    End Function
    'Ejercicio # 6'
    Public Function AcumularDigFibo() As String
        Dim n1, n2, n3 As Integer
        Dim ac As String
        Dim b As Boolean
        b = True
        n1 = 0 : n2 = 0 : ac = "" : n3 = 0
        n1 = n
        While (n1 <> 0)
            n = n1 Mod 10
            If (VerficarFibonacci() = True) Then
                n3 = n
                If (b = True) Then
                    ac = ac + "1/" + CStr(n3) + "!" + " - "
                    b = False
                Else
                    ac = ac + "1/" + CStr(n3) + "!" + " + "
                End If
            End If
            n1 = n1 \ 10
        End While
        n = n1
        Return ac
    End Function
    'Ejercicio # 7'
    Public Function DecimalCualquierbase(b As Integer) As Integer
        Dim n1, n2, c As Integer
        c = 1
        While (n > 2)
            n2 = n Mod b
            n1 = n1 + (n2 * c)
            c = c * 10
            n = n \ b
        End While
        Return n1
    End Function
    'Ejercicio # 8'
    Public Function AcumulardigPrimo(nd As Integer) As String
        Dim n1, n2, c As Integer
        Dim f As String
        n1 = 0 : n2 = 0 : f = "" : c = 2
        n1 = n
        While (n1 > 0)
            n2 = n1 Mod 10 ^ nd
            If (VerificarPimo(n2) = True) Then
                f = f + CStr(c) + "√" + CStr(n2) + " +"
                c = c + 2
            End If
            n1 = n1 \ 10 ^ nd
        End While
        Return f
    End Function
    'Ejercicio # 9'
    Public Function EncontrarMayorND(nd As Integer) As Integer
        Dim n1, n2, c As Integer
        n1 = 0 : n2 = 0
        n1 = n
        c = n1 Mod 10 ^ nd
        While (n1 > 0)
            n2 = n1 Mod 10 ^ nd
            n1 = n1 \ 10 ^ nd
            If (n2 > c) Then
                c = n2
            End If
        End While
        Return c
    End Function
    'Ejercicio # 10'
    Public Function Frecuencia(nd As Integer, dig As Integer) As Double
        Dim n1, n2, c As Integer
        n1 = 0 : n2 = 0 : c = 0
        n1 = n
        While (n1 > 0)
            n2 = n1 Mod 10 ^ nd
            If (n2 = dig) Then
                c = c + 1
            End If
            n1 = n1 \ 10 ^ nd
        End While
        Return c
    End Function
End Class
