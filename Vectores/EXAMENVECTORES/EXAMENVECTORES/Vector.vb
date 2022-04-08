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
    Public Sub Intercambiar(a As String, b As String)
        Dim aux As String
        aux = V(a)
        V(a) = V(b)
        V(b) = aux
    End Sub
    Public Sub ElimPos(p As Byte)
        For i = p To n
            V(i) = V(i + 1)
        Next
        n = n - 1
    End Sub
    Public Sub Respuesta2(a As Integer, b As Integer, m As Integer)
        Dim i, j As Integer
        For i = a + (m - 1) To b - m Step m
            For j = i + m To b Step m
                If V(i) > V(j) Then
                    Intercambiar(i, j)
                End If
            Next
        Next
    End Sub
    Public Sub Respuesta1(a As Integer, b As Integer, m As Integer)
        Dim x = 0
        For i = a + m - 1 To b - x Step m
            ElimPos(i - x)
            x = x + 1
        Next
    End Sub
    Public Sub Pregunta11(a As Integer, b As Integer, m As Integer)
        Dim j, aux, k, l As Integer
        j = 1 : aux = m : k = 0 : l = 2
        For i = 1 To n
            If (i = a) And (a <= b) Then
                a = a + 1
                If (j = aux) Then
                    k = k + 1
                    aux = m * l
                    l = l + 1
                Else
                    V(i - k) = V(i)
                End If
                j = j + 1
            End If
            If (a > b) Then
                V(i - k) = V(i)
            End If
        Next
        n = (n - k)
    End Sub

End Class
