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
        Me.MENUMATRIZ1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CARGARRANDOMToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CARGARMANUALToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DESCARGARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PREGUNTA1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Pregunta1ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PREGUNTA2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Pregunta2ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MENUMATRIZ1ToolStripMenuItem, Me.PREGUNTA1ToolStripMenuItem, Me.PREGUNTA2ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MENUMATRIZ1ToolStripMenuItem
        '
        Me.MENUMATRIZ1ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CARGARRANDOMToolStripMenuItem, Me.CARGARMANUALToolStripMenuItem, Me.DESCARGARToolStripMenuItem})
        Me.MENUMATRIZ1ToolStripMenuItem.Name = "MENUMATRIZ1ToolStripMenuItem"
        Me.MENUMATRIZ1ToolStripMenuItem.Size = New System.Drawing.Size(106, 20)
        Me.MENUMATRIZ1ToolStripMenuItem.Text = "MENU MATRIZ 1"
        '
        'CARGARRANDOMToolStripMenuItem
        '
        Me.CARGARRANDOMToolStripMenuItem.Name = "CARGARRANDOMToolStripMenuItem"
        Me.CARGARRANDOMToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.CARGARRANDOMToolStripMenuItem.Text = "CARGAR RANDOM"
        '
        'CARGARMANUALToolStripMenuItem
        '
        Me.CARGARMANUALToolStripMenuItem.Name = "CARGARMANUALToolStripMenuItem"
        Me.CARGARMANUALToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.CARGARMANUALToolStripMenuItem.Text = "CARGAR MANUAL"
        '
        'DESCARGARToolStripMenuItem
        '
        Me.DESCARGARToolStripMenuItem.Name = "DESCARGARToolStripMenuItem"
        Me.DESCARGARToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.DESCARGARToolStripMenuItem.Text = "DESCARGAR"
        '
        'PREGUNTA1ToolStripMenuItem
        '
        Me.PREGUNTA1ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Pregunta1ToolStripMenuItem1})
        Me.PREGUNTA1ToolStripMenuItem.Name = "PREGUNTA1ToolStripMenuItem"
        Me.PREGUNTA1ToolStripMenuItem.Size = New System.Drawing.Size(96, 20)
        Me.PREGUNTA1ToolStripMenuItem.Text = "PREGUNTA # 1"
        '
        'Pregunta1ToolStripMenuItem1
        '
        Me.Pregunta1ToolStripMenuItem1.Name = "Pregunta1ToolStripMenuItem1"
        Me.Pregunta1ToolStripMenuItem1.Size = New System.Drawing.Size(131, 22)
        Me.Pregunta1ToolStripMenuItem1.Text = "Pregunta 1"
        '
        'PREGUNTA2ToolStripMenuItem
        '
        Me.PREGUNTA2ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Pregunta2ToolStripMenuItem1})
        Me.PREGUNTA2ToolStripMenuItem.Name = "PREGUNTA2ToolStripMenuItem"
        Me.PREGUNTA2ToolStripMenuItem.Size = New System.Drawing.Size(96, 20)
        Me.PREGUNTA2ToolStripMenuItem.Text = "PREGUNTA # 2"
        '
        'Pregunta2ToolStripMenuItem1
        '
        Me.Pregunta2ToolStripMenuItem1.Name = "Pregunta2ToolStripMenuItem1"
        Me.Pregunta2ToolStripMenuItem1.Size = New System.Drawing.Size(131, 22)
        Me.Pregunta2ToolStripMenuItem1.Text = "Pregunta 2"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(74, 142)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 1
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(214, 142)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 2
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(357, 142)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 3
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(511, 142)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 20)
        Me.TextBox4.TabIndex = 4
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(147, 211)
        Me.TextBox5.Multiline = True
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(167, 134)
        Me.TextBox5.TabIndex = 5
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(378, 211)
        Me.TextBox6.Multiline = True
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(167, 134)
        Me.TextBox6.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
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
    Friend WithEvents MENUMATRIZ1ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CARGARRANDOMToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CARGARMANUALToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DESCARGARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PREGUNTA1ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PREGUNTA2ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Pregunta1ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents Pregunta2ToolStripMenuItem1 As ToolStripMenuItem
End Class
