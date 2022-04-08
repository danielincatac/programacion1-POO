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
        Dim f As String = "{ "
        For i = 1 To n
            f = f + CStr(V(i)) + " ; "
        Next
        f = f + "}"
        Return f
    End Function
    Public Function FrecuenciaVectorRango(a As Integer, b As Integer, dd As Integer) As Integer
        Dim c As Byte = 0
        For i = a To b
            If (V(i) = dd) Then
                c = c + 1
            End If
        Next
        Return c
    End Function
    Public Sub EliminarPos(pos As Integer)
        For i = pos To n
            V(i) = V(i + 1)
        Next
        n = n - 1
    End Sub
    Public Sub Pregunta1(a As Integer, b As Integer)
        Dim n1 As Integer = 0
        Dim k As Integer = 0
        Dim n2 As Integer = 0
        Dim i As Integer = 0
        For i = a To b
            n1 = V(i)
            If (FrecuenciaVectorRango(a, (b - k), V(i)) >= 2) Then
                n2 = V(i)
                k = k + 1
                EliminarPos(i)
            End If

        Next
    End Sub
    Public Sub Pregunta2(a As Integer, b As Integer, vele As Vector, vfre As Vector)
        Dim j, k As Integer
        Dim n1 As Integer = 0
        Dim n2 As Integer = 0
        j = 0 : k = 0
        n1 = FrecuenciaVectorRango(a, b, V(a))
        n2 = V(a)
        For i = a To b
            If (FrecuenciaVectorRango(a, b, V(i)) < n1) Then
                n1 = FrecuenciaVectorRango(a, b, V(i))
                n2 = V(i)
            End If
        Next
        j = j + 1
        vele.V(j) = n2
        vfre.V(j) = n1
        n1 = FrecuenciaVectorRango(a, b, V(a))
        n2 = V(a)
        For i = a To b
            If (FrecuenciaVectorRango(a, b, V(i)) > n1) Then
                n1 = FrecuenciaVectorRango(a, b, V(i))
                n2 = V(i)
            End If
        Next
        j = j + 1
        vele.V(j) = n2
        vfre.V(j) = n1
        vele.n = j : vfre.n = j
    End Sub

End Class
