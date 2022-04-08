Module Module1
    Public Function PrimeraMitadCapi(n As Integer) As Boolean
        Dim n1, n2, c, ac As Integer
        n1 = n
        While (n1 > 0)
            n1 = n1 \ 10
            c = c + 1
        End While
        c = c \ 2
        n = n \ 10 ^ c
        n2 = n
        While (n > 0)
            n1 = n Mod 10
            n = n \ 10
            ac = (ac * 10) + n1
        End While
        Return n2 = ac
    End Function
    Sub Main()
        Dim n1 As Integer
        n1 = Console.ReadLine()
        If (PrimeraMitadCapi(n1) = True) Then
            Console.WriteLine("Es capi")
        Else
            Console.WriteLine("No es capi")
        End If
        Console.ReadKey()
    End Sub
End Module
