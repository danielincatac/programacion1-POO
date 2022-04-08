Public Class Matriz
    Const MAXF = 100
    Const MAXC = 100
    Private M(MAXF, MAXC) As Integer
    Private f, c As Integer
    Public Sub Matriz()
        f = 0 : c = 0
    End Sub
    Public Sub CargarRandom(nf As Integer, nc As Integer, a As Integer, b As Integer)
        Dim f1, c1 As Integer
        f1 = 0 : c1 = 0 : f = nf : c = nc
        For f1 = 1 To f
            For c1 = 1 To c
                M(f1, c1) = a + Rnd() * (b - a)
            Next
        Next
    End Sub
    Public Sub CargarManual(nf As Integer, nc As Integer)
        Dim f1, c1 As Integer
        f1 = 0 : c1 = 0 : f = nf : c = nc
        For f1 = 1 To f
            For c1 = 1 To c
                M(f1, c1) = InputBox("", "", "")
            Next
        Next
    End Sub
    Public Function Descargar() As String
        Dim f1, c1 As Integer
        Dim s As String = ""
        f1 = 0 : c1 = 0
        For f1 = 1 To f
            For c1 = 1 To c
                s = s + CStr(M(f1, c1)) + "  ;  "
            Next
            s = s + Chr(13) + Chr(10)
        Next
        Return s
    End Function
    Public Sub Inter(fi As Integer, ci As Integer, ff As Integer, cf As Integer)
        Dim aux As Integer = 0
        aux = M(fi, ci)
        M(fi, ci) = M(ff, cf)
        M(ff, cf) = aux
    End Sub
    Public Function FilaMayor(ele As Integer, fi As Integer) As Integer
        Dim f1, c1 As Integer
        f1 = 0 : c1 = 0
        For c1 = 1 To c
            If M(fi, c1) > ele Then
                ele = M(fi, c1)
            End If
        Next
        Return ele
    End Function
    Public Sub InterFilas(fi As Integer, ff As Integer)
        Dim f1, c1 As Integer
        f1 = 0 : c1 = 0
        For c1 = 1 To c
            Inter(fi, c1, ff, c1)
        Next
    End Sub
    Public Sub Pregunta1()
        Dim f1, c1, cont As Integer
        Dim v1 As Vector = New Vector
        f1 = 0 : c1 = 0 : cont = 0
        For c1 = 1 To c
            For f1 = 1 To f
                If (v1.FrecuenciaVector(M(f1, c1)) = 0) Then
                    v1.CargarElemen(M(f1, c1))
                    cont += 1
                End If
            Next
            M(f + 1, c1) = cont
            cont = 0
            v1.n = 0
        Next
        f = f + 1
    End Sub
    Public Sub Pregunta2()
        Dim f1, c1, fref As Integer
        f1 = 0 : c1 = 1 : fref = 0
        For f1 = 1 To f
            fref = f1
            For fref = f1 To f
                If FilaMayor(M(f1, c1), f1) < FilaMayor(M(fref, c1), fref) Then
                    InterFilas(f1, fref)
                End If
            Next
        Next
    End Sub
End Class
