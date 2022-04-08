Public Class NEnt
    Public n As Integer
    Public Sub NEnt()
        n = 0
    End Sub
    Public Sub Cargar(d As Integer)
        n = d
    End Sub
    Public Function Descargar()
        Return n
    End Function
    Public Function VerfPrimo() As Boolean
        Dim c As Byte = 0
        Dim i As Integer = 0
        For i = 1 To n
            If ((n Mod i) = 0) Then
                c = c + 1
            End If
        Next
        Return c = 2
    End Function
    Public Function VerfPar() As Boolean
        Return n Mod 2 = 0
    End Function
    Public Function VerfImpar() As Boolean
        Return n Mod 2 <> 0
    End Function
End Class
