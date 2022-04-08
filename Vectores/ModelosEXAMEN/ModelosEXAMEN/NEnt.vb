Public Class NEnt
    Public n As Integer
    Public Sub NEnt()
        n = 0
    End Sub
    Public Sub Cargar(dato As Integer)
        n = dato
    End Sub
    Public Function Descargar()
        Return n
    End Function
    Public Function VerfPrimo() As Boolean
        Dim c As Byte
        For i = 1 To n
            If ((n Mod i) = 0) Then
                c = c + 1
            End If
        Next
        Return c = 2
    End Function
End Class
