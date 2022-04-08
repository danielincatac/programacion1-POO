Public Class NEnt
    Public n As Integer
    Public Sub Nent()
        n = 0
    End Sub
    Public Sub Cargar(d As Integer)
        n = d
    End Sub
    Public Function Descargar()
        Return n
    End Function
    Public Function Par() As Boolean
        Return n Mod 2 = 0
    End Function
End Class
