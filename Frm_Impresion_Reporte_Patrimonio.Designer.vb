<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Impresion_Reporte_Patrimonio
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
        Me.CRViewer_Patrimonio = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'CRViewer_Patrimonio
        '
        Me.CRViewer_Patrimonio.ActiveViewIndex = -1
        Me.CRViewer_Patrimonio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRViewer_Patrimonio.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRViewer_Patrimonio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRViewer_Patrimonio.Location = New System.Drawing.Point(0, 0)
        Me.CRViewer_Patrimonio.Name = "CRViewer_Patrimonio"
        Me.CRViewer_Patrimonio.Size = New System.Drawing.Size(762, 635)
        Me.CRViewer_Patrimonio.TabIndex = 0
        '
        'Frm_Impresion_Reporte_Patrimonio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(762, 635)
        Me.Controls.Add(Me.CRViewer_Patrimonio)
        Me.Name = "Frm_Impresion_Reporte_Patrimonio"
        Me.Text = "Frm_Impresion_Reporte_Patrimonio"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CRViewer_Patrimonio As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
