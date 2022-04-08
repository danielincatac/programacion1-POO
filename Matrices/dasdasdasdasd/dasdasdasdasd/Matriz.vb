Public Class Matriz
    Const MAXF = 100
    Const MAXC = 100
    Private M(MAXF, MAXC) As Integer
    Private f, c As Integer
    Public Sub Matriz()
        f = 0 : c = 0
    End Sub
    Public Sub CargarManual(nf As Integer, nc As Integer)
        Dim f1, c1 As Integer
        f1 = 0 : c1 = 0
        f = nf : c = nc
        For f1 = 1 To f
            For c1 = 1 To c
                M(f1, c1) = InputBox("", "", "")
            Next
        Next
    End Sub
    Public Sub CargarAbajodDerecha(nf As Integer, nc As Integer)
        Dim f1, c1 As Integer
        f1 = 0 : c1 = 0
        f = nf : c = nc
        For f1 = f To 1 Step -1
            For c1 = c To 1 Step -1
                M(f1, c1) = InputBox("", "", "")
            Next
        Next
    End Sub
    Public Sub CargarColumnas(nf As Integer, nc As Integer)
        Dim f1, c1 As Integer
        f1 = 0 : c1 = 0
        f = nf : c = nc
        For c1 = 1 To c
            For f1 = 1 To f
                M(f1, c1) = InputBox("", "", "")
            Next
        Next
    End Sub
    Public Sub CargarColumnasAbajoDerecha(nf As Integer, nc As Integer)
        Dim f1, c1 As Integer
        f1 = 0 : c1 = 0
        f = nf : c = nc
        For c1 = c To 1 Step -1
            For f1 = 1 To f
                M(f1, c1) = InputBox("", "", "")
            Next
        Next
    End Sub
    Public Function Descargar() As String
        Dim s As String = ""
        Dim f1, c1 As Integer
        f1 = 0 : c1 = 0
        For f1 = 1 To f
            For c1 = 1 To c
                s = s + CStr(M(f1, c1)) + "  ;  "
            Next
            s = s + Chr(13) + Chr(10)
        Next
        Return s
    End Function
    Public Function VerfMayorFila(fi As Integer, d As Integer) As Boolean
        Dim bo As Boolean = True
        Dim c1 As Integer = 0
        For c1 = 1 To c
            If (d < M(fi, c1)) Then
                bo = False
            End If
        Next
        Return bo
    End Function
    Public Function VerfMenorColumna(ci As Integer, d As Integer)
        Dim bo As Boolean = True
        Dim f1 As Integer = 0
        For f1 = 1 To f
            If (d > M(f1, ci)) Then
                bo = False
            End If
        Next
        Return bo
    End Function
    Public Function VerfMayorColumnaMenorFila() As String
        Dim s As String = ""
        Dim f1, c1, cc As Integer
        Dim bo As Boolean = False
        f1 = 1 : c1 = 1 : cc = 0
        While (f1 <= f) And (bo = False)
            While (c1 <= c) And (bo = False)
                If (VerfMayorFila(f1, M(f1, c1)) = True) Then
                    If (VerfMenorColumna(c1, M(f1, c1)) = True) Then
                        bo = True : cc = c1
                    End If
                End If
                c1 = c1 + 1
            End While
            c1 = 1
            f1 = f1 + 1
        End While
        If (bo = True) Then
            s = s + "  Elemento  " + CStr(M((f1 - 1), cc)) + "  Fila  " + CStr(f1 - 1) + "  Columna  " + CStr(cc)
        Else
            s = s + "No Hay Pan xd"
        End If
        Return s
    End Function
    Public Sub CargarSerpiente(nf As Integer, nc As Integer)
        Dim f1, c1, cont As Integer
        Dim bo As Boolean = True
        Dim boo As Boolean = True
        f = nf : c = nc
        f1 = 1
        While (f1 <= f)
            If (bo = True) Then
                c1 = c
                cont = 0
                bo = False
            Else
                c1 = 1
                cont = c
                bo = True
            End If
            While (boo = True) And (c1 > cont) Or (c1 <= cont) And (boo = True)
                M(f1, c1) = InputBox("", "", "")
                If (bo = False) Then
                    c1 -= 1
                    If (c1 = 0) Then
                        boo = False
                    End If
                Else
                    c1 += 1
                    If (c1 = c + 1) Then
                        boo = False
                    End If
                End If
            End While
            boo = True
            f1 += 1
        End While
    End Sub
End Class
