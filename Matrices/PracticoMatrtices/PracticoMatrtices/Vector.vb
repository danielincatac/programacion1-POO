Public Class Vector
    Const MAX = 100
    Public V(MAX) As Integer
    Public n As Integer
    Public Sub Vector()
        n = 0
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
            f = f + CStr(V(i)) + "  ;  "
        Next
        Return f
    End Function
    Public Function FrecuenciaVector(d As Integer)
        Dim c As Byte = 0
        For i = 1 To n
            If (V(i) = d) Then
                c = c + 1
            End If
        Next
        Return c
    End Function
    Public Sub CargarElement(ele As Integer)
        n = n + 1
        V(n) = ele
    End Sub
End Class
