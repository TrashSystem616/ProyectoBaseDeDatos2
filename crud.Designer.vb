<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class crud
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ChefsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AltasToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BajasToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CambiosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RecetasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AltasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BajasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CambiosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalificarRecetaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Miamoreproyecto.My.Resources.Resources.Mi_Amoré
        Me.PictureBox2.Location = New System.Drawing.Point(187, 80)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(194, 177)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChefsToolStripMenuItem, Me.RecetasToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(581, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ChefsToolStripMenuItem
        '
        Me.ChefsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltasToolStripMenuItem1, Me.BajasToolStripMenuItem1, Me.CambiosToolStripMenuItem1})
        Me.ChefsToolStripMenuItem.Image = Global.Miamoreproyecto.My.Resources.Resources.cooking
        Me.ChefsToolStripMenuItem.Name = "ChefsToolStripMenuItem"
        Me.ChefsToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ChefsToolStripMenuItem.Text = "Chefs"
        '
        'AltasToolStripMenuItem1
        '
        Me.AltasToolStripMenuItem1.Image = Global.Miamoreproyecto.My.Resources.Resources.positive1
        Me.AltasToolStripMenuItem1.Name = "AltasToolStripMenuItem1"
        Me.AltasToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.AltasToolStripMenuItem1.Text = "Altas"
        '
        'BajasToolStripMenuItem1
        '
        Me.BajasToolStripMenuItem1.Image = Global.Miamoreproyecto.My.Resources.Resources.borrar
        Me.BajasToolStripMenuItem1.Name = "BajasToolStripMenuItem1"
        Me.BajasToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.BajasToolStripMenuItem1.Text = "Bajas"
        '
        'CambiosToolStripMenuItem1
        '
        Me.CambiosToolStripMenuItem1.Image = Global.Miamoreproyecto.My.Resources.Resources.refresh
        Me.CambiosToolStripMenuItem1.Name = "CambiosToolStripMenuItem1"
        Me.CambiosToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.CambiosToolStripMenuItem1.Text = "Cambios"
        '
        'RecetasToolStripMenuItem
        '
        Me.RecetasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltasToolStripMenuItem, Me.BajasToolStripMenuItem, Me.CambiosToolStripMenuItem, Me.CalificarRecetaToolStripMenuItem})
        Me.RecetasToolStripMenuItem.Image = Global.Miamoreproyecto.My.Resources.Resources.libro_de_cocina
        Me.RecetasToolStripMenuItem.Name = "RecetasToolStripMenuItem"
        Me.RecetasToolStripMenuItem.Size = New System.Drawing.Size(75, 20)
        Me.RecetasToolStripMenuItem.Text = "Recetas"
        '
        'AltasToolStripMenuItem
        '
        Me.AltasToolStripMenuItem.Image = Global.Miamoreproyecto.My.Resources.Resources.positive1
        Me.AltasToolStripMenuItem.Name = "AltasToolStripMenuItem"
        Me.AltasToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AltasToolStripMenuItem.Text = "Altas"
        '
        'BajasToolStripMenuItem
        '
        Me.BajasToolStripMenuItem.Image = Global.Miamoreproyecto.My.Resources.Resources.borrar
        Me.BajasToolStripMenuItem.Name = "BajasToolStripMenuItem"
        Me.BajasToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.BajasToolStripMenuItem.Text = "Bajas"
        '
        'CambiosToolStripMenuItem
        '
        Me.CambiosToolStripMenuItem.Image = Global.Miamoreproyecto.My.Resources.Resources.refresh
        Me.CambiosToolStripMenuItem.Name = "CambiosToolStripMenuItem"
        Me.CambiosToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CambiosToolStripMenuItem.Text = "Cambios"
        '
        'CalificarRecetaToolStripMenuItem
        '
        Me.CalificarRecetaToolStripMenuItem.Image = Global.Miamoreproyecto.My.Resources.Resources.exam
        Me.CalificarRecetaToolStripMenuItem.Name = "CalificarRecetaToolStripMenuItem"
        Me.CalificarRecetaToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CalificarRecetaToolStripMenuItem.Text = "Calificar receta"
        '
        'crud
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Miamoreproyecto.My.Resources.Resources.Fondo1
        Me.ClientSize = New System.Drawing.Size(581, 323)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximumSize = New System.Drawing.Size(597, 362)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(597, 362)
        Me.Name = "crud"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Admin"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ChefsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AltasToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents BajasToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CambiosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents RecetasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AltasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BajasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CambiosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CalificarRecetaToolStripMenuItem As ToolStripMenuItem
End Class
