Public Class FormAdmin
    Private Sub AltaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AltaToolStripMenuItem.Click
        AltasChefs.ShowDialog()
    End Sub

    Private Sub BajaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BajaToolStripMenuItem.Click
        BajasChefs.ShowDialog()
    End Sub

    Private Sub ModificarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarToolStripMenuItem.Click
        ModificarChefs.ShowDialog()
    End Sub

    Private Sub AltaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AltaToolStripMenuItem1.Click
        AltaReceta.ShowDialog()
    End Sub

    Private Sub ChefToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChefToolStripMenuItem.Click
        BuscarChef.ShowDialog()
    End Sub

    Private Sub CambioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CambioToolStripMenuItem.Click
        ModificarReceta.ShowDialog()
    End Sub

    Private Sub RecetaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RecetaToolStripMenuItem.Click
        BuscarReceta.ShowDialog()
    End Sub
End Class