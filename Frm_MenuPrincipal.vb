Public Class Frm_MenuPrincipal
    Private Sub PatrimonioIPToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PatrimonioIPToolStripMenuItem.Click
        Frm_Patrimonio.Show()
    End Sub
    Private Sub DepartamentosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DepartamentosToolStripMenuItem.Click
        Frm_Departamentos.Show()
    End Sub
    Private Sub CatalogoDeCategoriasToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CatalogoDeCategoriasToolStripMenuItem1.Click
        Frm_Categorias.Show()
    End Sub
    Private Sub CatalogoDeSubCategoriasToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CatalogoDeSubCategoriasToolStripMenuItem1.Click
        Frm_SubCategorias.Show()
    End Sub
    Private Sub MovimientosDeCambiosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MovimientosDeCambiosToolStripMenuItem.Click
        Frm_Patrimonio_Cambios.Show()
    End Sub
    Private Sub PatrimonioPorFolioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PatrimonioPorFolioToolStripMenuItem.Click
        FRM_Reporte_Patrimonio.Show()
    End Sub

    Private Sub MovDeTransferenciasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MovDeTransferenciasToolStripMenuItem.Click
        Frm_Transferencias.Show()
    End Sub
    Private Sub MovDeCambiosATransferenciasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MovDeCambiosATransferenciasToolStripMenuItem.Click
        Frm_Transferencia_Cambios.Show()
    End Sub

    Private Sub TransferenciaInternaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransferenciaInternaToolStripMenuItem.Click
        FRM_Reporte_Transferencia.Show()

    End Sub
End Class