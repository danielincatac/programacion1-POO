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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Pregunta1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Pregunta2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MayorEleMenorElemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.EliminarRepDejarSoloUnoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProbandoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarPosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuVector1ToolStripMenuItem, Me.Pregunta2ToolStripMenuItem, Me.Pregunta1ToolStripMenuItem, Me.ProbandoToolStripMenuItem})
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
        Me.CargarRandomToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CargarRandomToolStripMenuItem.Text = "Cargar Random"
        '
        'CargarManualToolStripMenuItem
        '
        Me.CargarManualToolStripMenuItem.Name = "CargarManualToolStripMenuItem"
        Me.CargarManualToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CargarManualToolStripMenuItem.Text = "Cargar Manual"
        '
        'DescargarToolStripMenuItem
        '
        Me.DescargarToolStripMenuItem.Name = "DescargarToolStripMenuItem"
        Me.DescargarToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.DescargarToolStripMenuItem.Text = "Descargar"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(96, 130)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 1
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(255, 130)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 2
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(416, 130)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 3
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(96, 227)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(420, 20)
        Me.TextBox4.TabIndex = 4
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(96, 285)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(420, 20)
        Me.TextBox5.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(116, 153)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Dimension"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(278, 153)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Desde"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(444, 153)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Hasta"
        '
        'Pregunta1ToolStripMenuItem
        '
        Me.Pregunta1ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EliminarRepDejarSoloUnoToolStripMenuItem})
        Me.Pregunta1ToolStripMenuItem.Name = "Pregunta1ToolStripMenuItem"
        Me.Pregunta1ToolStripMenuItem.Size = New System.Drawing.Size(79, 20)
        Me.Pregunta1ToolStripMenuItem.Text = "Pregunta 1 "
        '
        'Pregunta2ToolStripMenuItem
        '
        Me.Pregunta2ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MayorEleMenorElemToolStripMenuItem})
        Me.Pregunta2ToolStripMenuItem.Name = "Pregunta2ToolStripMenuItem"
        Me.Pregunta2ToolStripMenuItem.Size = New System.Drawing.Size(76, 20)
        Me.Pregunta2ToolStripMenuItem.Text = "Pregunta 2"
        '
        'MayorEleMenorElemToolStripMenuItem
        '
        Me.MayorEleMenorElemToolStripMenuItem.Name = "MayorEleMenorElemToolStripMenuItem"
        Me.MayorEleMenorElemToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.MayorEleMenorElemToolStripMenuItem.Text = "MayorEleMenorElem"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(96, 335)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(420, 20)
        Me.TextBox6.TabIndex = 9
        '
        'EliminarRepDejarSoloUnoToolStripMenuItem
        '
        Me.EliminarRepDejarSoloUnoToolStripMenuItem.Name = "EliminarRepDejarSoloUnoToolStripMenuItem"
        Me.EliminarRepDejarSoloUnoToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.EliminarRepDejarSoloUnoToolStripMenuItem.Text = "EliminarRepDejarSoloUno"
        '
        'ProbandoToolStripMenuItem
        '
        Me.ProbandoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EliminarPosToolStripMenuItem})
        Me.ProbandoToolStripMenuItem.Name = "ProbandoToolStripMenuItem"
        Me.ProbandoToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.ProbandoToolStripMenuItem.Text = "Probando"
        '
        'EliminarPosToolStripMenuItem
        '
        Me.EliminarPosToolStripMenuItem.Name = "EliminarPosToolStripMenuItem"
        Me.EliminarPosToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.EliminarPosToolStripMenuItem.Text = "EliminarPos"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
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
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Pregunta2ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MayorEleMenorElemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Pregunta1ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents EliminarRepDejarSoloUnoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProbandoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarPosToolStripMenuItem As ToolStripMenuItem
End Class
