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
        Me.Menu1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CargarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DescargarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EjerciciosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SegmentarCapiyNoCapiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.AcumularCToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Menu1ToolStripMenuItem, Me.EjerciciosToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Menu1ToolStripMenuItem
        '
        Me.Menu1ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CargarToolStripMenuItem, Me.DescargarToolStripMenuItem})
        Me.Menu1ToolStripMenuItem.Name = "Menu1ToolStripMenuItem"
        Me.Menu1ToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.Menu1ToolStripMenuItem.Text = "Menu 1"
        '
        'CargarToolStripMenuItem
        '
        Me.CargarToolStripMenuItem.Name = "CargarToolStripMenuItem"
        Me.CargarToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CargarToolStripMenuItem.Text = "Cargar"
        '
        'DescargarToolStripMenuItem
        '
        Me.DescargarToolStripMenuItem.Name = "DescargarToolStripMenuItem"
        Me.DescargarToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.DescargarToolStripMenuItem.Text = "Descargar"
        '
        'EjerciciosToolStripMenuItem
        '
        Me.EjerciciosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TestToolStripMenuItem, Me.SegmentarCapiyNoCapiToolStripMenuItem, Me.AcumularCToolStripMenuItem})
        Me.EjerciciosToolStripMenuItem.Name = "EjerciciosToolStripMenuItem"
        Me.EjerciciosToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.EjerciciosToolStripMenuItem.Text = "Ejercicios"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(248, 134)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 1
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(248, 248)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 2
        '
        'TestToolStripMenuItem
        '
        Me.TestToolStripMenuItem.Name = "TestToolStripMenuItem"
        Me.TestToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.TestToolStripMenuItem.Text = "test"
        '
        'SegmentarCapiyNoCapiToolStripMenuItem
        '
        Me.SegmentarCapiyNoCapiToolStripMenuItem.Name = "SegmentarCapiyNoCapiToolStripMenuItem"
        Me.SegmentarCapiyNoCapiToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.SegmentarCapiyNoCapiToolStripMenuItem.Text = "SegmentarCapiyNoCapi"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(375, 134)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 3
        '
        'AcumularCToolStripMenuItem
        '
        Me.AcumularCToolStripMenuItem.Name = "AcumularCToolStripMenuItem"
        Me.AcumularCToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.AcumularCToolStripMenuItem.Text = "AcumularConDigPrimos"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
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
    Friend WithEvents Menu1ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CargarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DescargarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EjerciciosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TestToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SegmentarCapiyNoCapiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents AcumularCToolStripMenuItem As ToolStripMenuItem
End Class
