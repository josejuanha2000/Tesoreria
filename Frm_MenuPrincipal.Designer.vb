<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_MenuPrincipal
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
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DepartamentosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CatalogoDeCategoriasToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CatalogoDeSubCategoriasToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.OperacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PatrimonioIPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MovimientosDeCambiosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransferenciaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MovDeTransferenciasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MovDeCambiosATransferenciasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PatrimonioPorFolioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransferenciaInternaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListaDePatrimoniGeneralPorFechaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadoDePatrimonioPorDepartamentoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReportesToolStripMenuItem, Me.OperacionToolStripMenuItem, Me.TransferenciaToolStripMenuItem, Me.ReportesToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(469, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DepartamentosToolStripMenuItem, Me.CatalogoDeCategoriasToolStripMenuItem1, Me.CatalogoDeSubCategoriasToolStripMenuItem1})
        Me.ReportesToolStripMenuItem.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(79, 20)
        Me.ReportesToolStripMenuItem.Text = "Operación"
        '
        'DepartamentosToolStripMenuItem
        '
        Me.DepartamentosToolStripMenuItem.Name = "DepartamentosToolStripMenuItem"
        Me.DepartamentosToolStripMenuItem.Size = New System.Drawing.Size(243, 22)
        Me.DepartamentosToolStripMenuItem.Text = "&Departamentos - Empleados"
        '
        'CatalogoDeCategoriasToolStripMenuItem1
        '
        Me.CatalogoDeCategoriasToolStripMenuItem1.Name = "CatalogoDeCategoriasToolStripMenuItem1"
        Me.CatalogoDeCategoriasToolStripMenuItem1.Size = New System.Drawing.Size(243, 22)
        Me.CatalogoDeCategoriasToolStripMenuItem1.Text = "Catálogo de Categorias"
        '
        'CatalogoDeSubCategoriasToolStripMenuItem1
        '
        Me.CatalogoDeSubCategoriasToolStripMenuItem1.Name = "CatalogoDeSubCategoriasToolStripMenuItem1"
        Me.CatalogoDeSubCategoriasToolStripMenuItem1.Size = New System.Drawing.Size(243, 22)
        Me.CatalogoDeSubCategoriasToolStripMenuItem1.Text = "Catálogo de Sub Categorias"
        '
        'OperacionToolStripMenuItem
        '
        Me.OperacionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PatrimonioIPToolStripMenuItem, Me.MovimientosDeCambiosToolStripMenuItem})
        Me.OperacionToolStripMenuItem.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OperacionToolStripMenuItem.Name = "OperacionToolStripMenuItem"
        Me.OperacionToolStripMenuItem.Size = New System.Drawing.Size(84, 20)
        Me.OperacionToolStripMenuItem.Text = "Patrimonio"
        '
        'PatrimonioIPToolStripMenuItem
        '
        Me.PatrimonioIPToolStripMenuItem.Name = "PatrimonioIPToolStripMenuItem"
        Me.PatrimonioIPToolStripMenuItem.Size = New System.Drawing.Size(297, 22)
        Me.PatrimonioIPToolStripMenuItem.Text = "Movimiento  de Alta a Patrimonio"
        '
        'MovimientosDeCambiosToolStripMenuItem
        '
        Me.MovimientosDeCambiosToolStripMenuItem.Name = "MovimientosDeCambiosToolStripMenuItem"
        Me.MovimientosDeCambiosToolStripMenuItem.Size = New System.Drawing.Size(297, 22)
        Me.MovimientosDeCambiosToolStripMenuItem.Text = "Movimiento de Cambios a Patrimonio"
        '
        'TransferenciaToolStripMenuItem
        '
        Me.TransferenciaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MovDeTransferenciasToolStripMenuItem, Me.MovDeCambiosATransferenciasToolStripMenuItem})
        Me.TransferenciaToolStripMenuItem.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TransferenciaToolStripMenuItem.Name = "TransferenciaToolStripMenuItem"
        Me.TransferenciaToolStripMenuItem.Size = New System.Drawing.Size(101, 20)
        Me.TransferenciaToolStripMenuItem.Text = "Transferencia"
        '
        'MovDeTransferenciasToolStripMenuItem
        '
        Me.MovDeTransferenciasToolStripMenuItem.Name = "MovDeTransferenciasToolStripMenuItem"
        Me.MovDeTransferenciasToolStripMenuItem.Size = New System.Drawing.Size(326, 22)
        Me.MovDeTransferenciasToolStripMenuItem.Text = "Movimientos de Transferencias"
        '
        'MovDeCambiosATransferenciasToolStripMenuItem
        '
        Me.MovDeCambiosATransferenciasToolStripMenuItem.Name = "MovDeCambiosATransferenciasToolStripMenuItem"
        Me.MovDeCambiosATransferenciasToolStripMenuItem.Size = New System.Drawing.Size(326, 22)
        Me.MovDeCambiosATransferenciasToolStripMenuItem.Text = "Movimientos de cambios a Transferencias"
        '
        'ReportesToolStripMenuItem1
        '
        Me.ReportesToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PatrimonioPorFolioToolStripMenuItem, Me.TransferenciaInternaToolStripMenuItem, Me.ListaDePatrimoniGeneralPorFechaToolStripMenuItem, Me.ListadoDePatrimonioPorDepartamentoToolStripMenuItem})
        Me.ReportesToolStripMenuItem1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReportesToolStripMenuItem1.Name = "ReportesToolStripMenuItem1"
        Me.ReportesToolStripMenuItem1.Size = New System.Drawing.Size(70, 20)
        Me.ReportesToolStripMenuItem1.Text = "Reportes"
        '
        'PatrimonioPorFolioToolStripMenuItem
        '
        Me.PatrimonioPorFolioToolStripMenuItem.Name = "PatrimonioPorFolioToolStripMenuItem"
        Me.PatrimonioPorFolioToolStripMenuItem.Size = New System.Drawing.Size(298, 22)
        Me.PatrimonioPorFolioToolStripMenuItem.Text = "Movimiento de Alta"
        '
        'TransferenciaInternaToolStripMenuItem
        '
        Me.TransferenciaInternaToolStripMenuItem.Name = "TransferenciaInternaToolStripMenuItem"
        Me.TransferenciaInternaToolStripMenuItem.Size = New System.Drawing.Size(298, 22)
        Me.TransferenciaInternaToolStripMenuItem.Text = "Transferencia Interna"
        '
        'ListaDePatrimoniGeneralPorFechaToolStripMenuItem
        '
        Me.ListaDePatrimoniGeneralPorFechaToolStripMenuItem.Name = "ListaDePatrimoniGeneralPorFechaToolStripMenuItem"
        Me.ListaDePatrimoniGeneralPorFechaToolStripMenuItem.Size = New System.Drawing.Size(298, 22)
        Me.ListaDePatrimoniGeneralPorFechaToolStripMenuItem.Text = "Lista de patrimonio general por fecha"
        '
        'ListadoDePatrimonioPorDepartamentoToolStripMenuItem
        '
        Me.ListadoDePatrimonioPorDepartamentoToolStripMenuItem.Name = "ListadoDePatrimonioPorDepartamentoToolStripMenuItem"
        Me.ListadoDePatrimonioPorDepartamentoToolStripMenuItem.Size = New System.Drawing.Size(298, 22)
        Me.ListadoDePatrimonioPorDepartamentoToolStripMenuItem.Text = "Listado de patrimonio por Departamento"
        '
        'Frm_MenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PowderBlue
        Me.ClientSize = New System.Drawing.Size(469, 513)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.Highlight
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Frm_MenuPrincipal"
        Me.Text = "FACDYC Patrimonio"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents OperacionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PatrimonioIPToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DepartamentosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CatalogoDeCategoriasToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CatalogoDeSubCategoriasToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MovimientosDeCambiosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PatrimonioPorFolioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListaDePatrimoniGeneralPorFechaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListadoDePatrimonioPorDepartamentoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TransferenciaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MovDeTransferenciasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MovDeCambiosATransferenciasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TransferenciaInternaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
