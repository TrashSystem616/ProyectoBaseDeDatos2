<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAdmin
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
        Me.AdministradorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChefsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AltaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BajaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RecetasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AltaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CambioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChefToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RecetaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalificarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RecetaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImprimirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RecetaToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdministradorToolStripMenuItem, Me.BuscarToolStripMenuItem, Me.CalificarToolStripMenuItem, Me.ImprimirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(693, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AdministradorToolStripMenuItem
        '
        Me.AdministradorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChefsToolStripMenuItem, Me.RecetasToolStripMenuItem})
        Me.AdministradorToolStripMenuItem.Image = Global.Restaurantemiamore.My.Resources.Resources.lapiz
        Me.AdministradorToolStripMenuItem.Name = "AdministradorToolStripMenuItem"
        Me.AdministradorToolStripMenuItem.Size = New System.Drawing.Size(111, 20)
        Me.AdministradorToolStripMenuItem.Text = "Administrador"
        '
        'ChefsToolStripMenuItem
        '
        Me.ChefsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltaToolStripMenuItem, Me.BajaToolStripMenuItem, Me.ModificarToolStripMenuItem})
        Me.ChefsToolStripMenuItem.Image = Global.Restaurantemiamore.My.Resources.Resources.cooking
        Me.ChefsToolStripMenuItem.Name = "ChefsToolStripMenuItem"
        Me.ChefsToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ChefsToolStripMenuItem.Text = "Chefs"
        '
        'AltaToolStripMenuItem
        '
        Me.AltaToolStripMenuItem.Image = Global.Restaurantemiamore.My.Resources.Resources.positive
        Me.AltaToolStripMenuItem.Name = "AltaToolStripMenuItem"
        Me.AltaToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.AltaToolStripMenuItem.Text = "Alta"
        '
        'BajaToolStripMenuItem
        '
        Me.BajaToolStripMenuItem.Image = Global.Restaurantemiamore.My.Resources.Resources.borrar1
        Me.BajaToolStripMenuItem.Name = "BajaToolStripMenuItem"
        Me.BajaToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.BajaToolStripMenuItem.Text = "Baja"
        '
        'ModificarToolStripMenuItem
        '
        Me.ModificarToolStripMenuItem.Image = Global.Restaurantemiamore.My.Resources.Resources.refresh
        Me.ModificarToolStripMenuItem.Name = "ModificarToolStripMenuItem"
        Me.ModificarToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.ModificarToolStripMenuItem.Text = "Modificar"
        '
        'RecetasToolStripMenuItem
        '
        Me.RecetasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltaToolStripMenuItem1, Me.CambioToolStripMenuItem})
        Me.RecetasToolStripMenuItem.Image = Global.Restaurantemiamore.My.Resources.Resources.libro_de_cocina
        Me.RecetasToolStripMenuItem.Name = "RecetasToolStripMenuItem"
        Me.RecetasToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.RecetasToolStripMenuItem.Text = "Recetas"
        '
        'AltaToolStripMenuItem1
        '
        Me.AltaToolStripMenuItem1.Image = Global.Restaurantemiamore.My.Resources.Resources.positive
        Me.AltaToolStripMenuItem1.Name = "AltaToolStripMenuItem1"
        Me.AltaToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.AltaToolStripMenuItem1.Text = "Alta"
        '
        'CambioToolStripMenuItem
        '
        Me.CambioToolStripMenuItem.Image = Global.Restaurantemiamore.My.Resources.Resources.refresh
        Me.CambioToolStripMenuItem.Name = "CambioToolStripMenuItem"
        Me.CambioToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CambioToolStripMenuItem.Text = "Cambio"
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
        Me.ChefToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ChefToolStripMenuItem.Text = "Chef"
        '
        'RecetaToolStripMenuItem
        '
        Me.RecetaToolStripMenuItem.Image = Global.Restaurantemiamore.My.Resources.Resources.libro_de_cocina
        Me.RecetaToolStripMenuItem.Name = "RecetaToolStripMenuItem"
        Me.RecetaToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
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
        Me.RecetaToolStripMenuItem1.Image = Global.Restaurantemiamore.My.Resources.Resources.libro_de_cocina
        Me.RecetaToolStripMenuItem1.Name = "RecetaToolStripMenuItem1"
        Me.RecetaToolStripMenuItem1.Size = New System.Drawing.Size(109, 22)
        Me.RecetaToolStripMenuItem1.Text = "Receta"
        '
        'ImprimirToolStripMenuItem
        '
        Me.ImprimirToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RecetaToolStripMenuItem2})
        Me.ImprimirToolStripMenuItem.Image = Global.Restaurantemiamore.My.Resources.Resources.printer2
        Me.ImprimirToolStripMenuItem.Name = "ImprimirToolStripMenuItem"
        Me.ImprimirToolStripMenuItem.Size = New System.Drawing.Size(81, 20)
        Me.ImprimirToolStripMenuItem.Text = "Imprimir"
        '
        'RecetaToolStripMenuItem2
        '
        Me.RecetaToolStripMenuItem2.Image = Global.Restaurantemiamore.My.Resources.Resources.libro_de_cocina
        Me.RecetaToolStripMenuItem2.Name = "RecetaToolStripMenuItem2"
        Me.RecetaToolStripMenuItem2.Size = New System.Drawing.Size(109, 22)
        Me.RecetaToolStripMenuItem2.Text = "Receta"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Restaurantemiamore.My.Resources.Resources.Mi_Amoré
        Me.PictureBox1.Location = New System.Drawing.Point(228, 44)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(238, 230)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'FormAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Restaurantemiamore.My.Resources.Resources.fondo2
        Me.ClientSize = New System.Drawing.Size(693, 298)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximumSize = New System.Drawing.Size(709, 337)
        Me.MinimumSize = New System.Drawing.Size(709, 337)
        Me.Name = "FormAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inicio"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AdministradorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChefsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AltaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BajaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModificarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RecetasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AltaToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CambioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BuscarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChefToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RecetaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents CalificarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RecetaToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ImprimirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RecetaToolStripMenuItem2 As ToolStripMenuItem
End Class
