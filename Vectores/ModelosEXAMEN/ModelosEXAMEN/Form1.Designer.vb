<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuVector1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CargarRandomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CargarManualToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DescargarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PreguntasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IntercalarRepNoRepToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.EncontrarElemtoconmayorfrecuenciaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IntercalarRepNoRepRangoOrdenadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SegmentarOrdenadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SegmentarOrdenadoRangoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RecorrerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrdenarMultiplosRangoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuVector1ToolStripMenuItem, Me.PreguntasToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuVector1ToolStripMenuItem
        '
        Me.MenuVector1ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CargarRandomToolStripMenuItem, Me.CargarManualToolStripMenuItem, Me.DescargarToolStripMenuItem})
        Me.MenuVector1ToolStripMenuItem.Name = "MenuVector1ToolStripMenuItem"
        Me.MenuVector1ToolStripMenuItem.Size = New System.Drawing.Size(95, 20)
        Me.MenuVector1ToolStripMenuItem.Text = "Menu Vector 1"
        '
        'CargarRandomToolStripMenuItem
        '
        Me.CargarRandomToolStripMenuItem.Name = "CargarRandomToolStripMenuItem"
        Me.CargarRandomToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.CargarRandomToolStripMenuItem.Text = "CargarRandom"
        '
        'CargarManualToolStripMenuItem
        '
        Me.CargarManualToolStripMenuItem.Name = "CargarManualToolStripMenuItem"
        Me.CargarManualToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.CargarManualToolStripMenuItem.Text = "CargarManual"
        '
        'DescargarToolStripMenuItem
        '
        Me.DescargarToolStripMenuItem.Name = "DescargarToolStripMenuItem"
        Me.DescargarToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.DescargarToolStripMenuItem.Text = "Descargar"
        '
        'PreguntasToolStripMenuItem
        '
        Me.PreguntasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IntercalarRepNoRepToolStripMenuItem, Me.EncontrarElemtoconmayorfrecuenciaToolStripMenuItem, Me.IntercalarRepNoRepRangoOrdenadoToolStripMenuItem, Me.SegmentarOrdenadoToolStripMenuItem, Me.SegmentarOrdenadoRangoToolStripMenuItem, Me.RecorrerToolStripMenuItem, Me.OrdenarMultiplosRangoToolStripMenuItem})
        Me.PreguntasToolStripMenuItem.Name = "PreguntasToolStripMenuItem"
        Me.PreguntasToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.PreguntasToolStripMenuItem.Text = "Preguntas"
        '
        'IntercalarRepNoRepToolStripMenuItem
        '
        Me.IntercalarRepNoRepToolStripMenuItem.Name = "IntercalarRepNoRepToolStripMenuItem"
        Me.IntercalarRepNoRepToolStripMenuItem.Size = New System.Drawing.Size(232, 22)
        Me.IntercalarRepNoRepToolStripMenuItem.Text = "IntercalarRepNoRepOrdenado"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(103, 139)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 1
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(257, 139)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 2
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(410, 139)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 3
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(546, 139)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 20)
        Me.TextBox4.TabIndex = 4
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(103, 218)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(543, 20)
        Me.TextBox5.TabIndex = 5
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(103, 261)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(543, 20)
        Me.TextBox6.TabIndex = 6
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(103, 309)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(543, 20)
        Me.TextBox7.TabIndex = 7
        '
        'EncontrarElemtoconmayorfrecuenciaToolStripMenuItem
        '
        Me.EncontrarElemtoconmayorfrecuenciaToolStripMenuItem.Name = "EncontrarElemtoconmayorfrecuenciaToolStripMenuItem"
        Me.EncontrarElemtoconmayorfrecuenciaToolStripMenuItem.Size = New System.Drawing.Size(271, 22)
        Me.EncontrarElemtoconmayorfrecuenciaToolStripMenuItem.Text = "EncontrarElemtoconmayorfrecuencia"
        '
        'IntercalarRepNoRepRangoOrdenadoToolStripMenuItem
        '
        Me.IntercalarRepNoRepRangoOrdenadoToolStripMenuItem.Name = "IntercalarRepNoRepRangoOrdenadoToolStripMenuItem"
        Me.IntercalarRepNoRepRangoOrdenadoToolStripMenuItem.Size = New System.Drawing.Size(271, 22)
        Me.IntercalarRepNoRepRangoOrdenadoToolStripMenuItem.Text = "IntercalarRepNoRepRangoOrdenado"
        '
        'SegmentarOrdenadoToolStripMenuItem
        '
        Me.SegmentarOrdenadoToolStripMenuItem.Name = "SegmentarOrdenadoToolStripMenuItem"
        Me.SegmentarOrdenadoToolStripMenuItem.Size = New System.Drawing.Size(271, 22)
        Me.SegmentarOrdenadoToolStripMenuItem.Text = "SegmentarOrdenado"
        '
        'SegmentarOrdenadoRangoToolStripMenuItem
        '
        Me.SegmentarOrdenadoRangoToolStripMenuItem.Name = "SegmentarOrdenadoRangoToolStripMenuItem"
        Me.SegmentarOrdenadoRangoToolStripMenuItem.Size = New System.Drawing.Size(271, 22)
        Me.SegmentarOrdenadoRangoToolStripMenuItem.Text = "SegmentarOrdenadoRango"
        '
        'RecorrerToolStripMenuItem
        '
        Me.RecorrerToolStripMenuItem.Name = "RecorrerToolStripMenuItem"
        Me.RecorrerToolStripMenuItem.Size = New System.Drawing.Size(271, 22)
        Me.RecorrerToolStripMenuItem.Text = "Recorrer"
        '
        'OrdenarMultiplosRangoToolStripMenuItem
        '
        Me.OrdenarMultiplosRangoToolStripMenuItem.Name = "OrdenarMultiplosRangoToolStripMenuItem"
        Me.OrdenarMultiplosRangoToolStripMenuItem.Size = New System.Drawing.Size(271, 22)
        Me.OrdenarMultiplosRangoToolStripMenuItem.Text = "OrdenarMultiplosRango"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuVector1ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CargarRandomToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CargarManualToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DescargarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents PreguntasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IntercalarRepNoRepToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents EncontrarElemtoconmayorfrecuenciaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IntercalarRepNoRepRangoOrdenadoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SegmentarOrdenadoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SegmentarOrdenadoRangoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RecorrerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OrdenarMultiplosRangoToolStripMenuItem As ToolStripMenuItem
End Class
