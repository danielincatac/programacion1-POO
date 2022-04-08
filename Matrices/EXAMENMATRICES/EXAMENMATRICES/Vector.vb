Public Class Vector
    Const MAX = 100
    Public V(MAX) As Integer
    Public n As Integer
    Public Sub Vector()
        n = 0
    End Sub
    Public Sub CargarElemen(ele As Integer)
        n = n + 1
        V(n) = ele
    End Sub
    Public Function FrecuenciaVector(d As Integer)
        Dim c As Integer = 0
        For i = 1 To n
            If (V(i) = d) Then
                c = c + 1
            End If
        Next
        Return c
    End Function
End Class
