<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUsuario
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.BuscarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChefToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RecetaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalificarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RecetaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImprimirRecetaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RecetaToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Restaurantemiamore.My.Resources.Resources.Mi_Amoré
        Me.PictureBox1.Location = New System.Drawing.Point(228, 57)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(238, 230)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BuscarToolStripMenuItem, Me.CalificarToolStripMenuItem, Me.ImprimirRecetaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(691, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'BuscarToolStripMenuItem
        '
        Me.BuscarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChefToolStripMenuItem, Me.RecetaToolStripMenuItem})
        Me.BuscarToolStripMenuItem.Image = Global.Restaurantemiamore.My.Resources.Resources.search
        Me.BuscarToolStripMenuItem.Name = "BuscarToolStripMenuItem"
        Me.BuscarToolStripMenuItem.Size = New System.Drawing.Size(70, 20)
        Me.BuscarToolStripMenuItem.Text = "Buscar"
        '
        'ChefToolStripMenuItem
        '
        Me.ChefToolStripMenuItem.Image = Global.Restaurantemiamore.My.Resources.Resources.cooking1
        Me.ChefToolStripMenuItem.Name = "ChefToolStripMenuItem"
        Me.ChefToolStripMenuItem.Size = New System.Drawing.Size(109, 22)
        Me.ChefToolStripMenuItem.Text = "Chef"
        '
        'RecetaToolStripMenuItem
        '
        Me.RecetaToolStripMenuItem.Image = Global.Restaurantemiamore.My.Resources.Resources.libro_de_cocina
        Me.RecetaToolStripMenuItem.Name = "RecetaToolStripMenuItem"
        Me.RecetaToolStripMenuItem.Size = New System.Drawing.Size(109, 22)
        Me.RecetaToolStripMenuItem.Text = "Receta"
        '
        'CalificarToolStripMenuItem
        '
        Me.CalificarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RecetaToolStripMenuItem1})
        Me.CalificarToolStripMenuItem.Image = Global.Restaurantemiamore.My.Resources.Resources.exam
        Me.CalificarToolStripMenuItem.Name = "CalificarToolStripMenuItem"
        Me.CalificarToolStripMenuItem.Size = New System.Drawing.Size(78, 20)
        Me.CalificarToolStripMenuItem.Text = "Calificar"
        '
        'RecetaToolStripMenuItem1
        '
        Me.RecetaToolStripMenuItem1.Name = "RecetaToolStripMenuItem1"
        Me.RecetaToolStripMenuItem1.Size = New System.Drawing.Size(109, 22)
        Me.RecetaToolStripMenuItem1.Text = "Receta"
        '
        'ImprimirRecetaToolStripMenuItem
        '
        Me.ImprimirRecetaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RecetaToolStripMenuItem2})
        Me.ImprimirRecetaToolStripMenuItem.Image = Global.Restaurantemiamore.My.Resources.Resources.printer1
        Me.ImprimirRecetaToolStripMenuItem.Name = "ImprimirRecetaToolStripMenuItem"
        Me.ImprimirRecetaToolStripMenuItem.Size = New System.Drawing.Size(81, 20)
        Me.ImprimirRecetaToolStripMenuItem.Text = "Imprimir"
        '
        'RecetaToolStripMenuItem2
        '
        Me.RecetaToolStripMenuItem2.Image = Global.Restaurantemiamore.My.Resources.Resources.libro_de_cocina
        Me.RecetaToolStripMenuItem2.Name = "RecetaToolStripMenuItem2"
        Me.RecetaToolStripMenuItem2.Size = New System.Drawing.Size(180, 22)
        Me.RecetaToolStripMenuItem2.Text = "Receta"
        '
        'FormUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Restaurantemiamore.My.Resources.Resources.fondo2
        Me.ClientSize = New System.Drawing.Size(691, 300)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "FormUsuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inicio"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents BuscarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChefToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RecetaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CalificarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RecetaToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ImprimirRecetaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RecetaToolStripMenuItem2 As ToolStripMenuItem
End Class
