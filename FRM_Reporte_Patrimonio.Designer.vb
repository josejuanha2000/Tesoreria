﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_Reporte_Patrimonio
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
        Me.CB_Folio = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.BtnMostrarDatos = New System.Windows.Forms.Button()
        Me.BtnImprimir = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CB_Folio
        '
        Me.CB_Folio.FormattingEnabled = True
        Me.CB_Folio.Location = New System.Drawing.Point(38, 31)
        Me.CB_Folio.Name = "CB_Folio"
        Me.CB_Folio.Size = New System.Drawing.Size(113, 21)
        Me.CB_Folio.TabIndex = 62
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(41, 11)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(38, 13)
        Me.Label16.TabIndex = 61
        Me.Label16.Text = "Folio:"
        '
        'BtnMostrarDatos
        '
        Me.BtnMostrarDatos.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.BtnMostrarDatos.Location = New System.Drawing.Point(173, 27)
        Me.BtnMostrarDatos.Name = "BtnMostrarDatos"
        Me.BtnMostrarDatos.Size = New System.Drawing.Size(87, 28)
        Me.BtnMostrarDatos.TabIndex = 60
        Me.BtnMostrarDatos.Text = "Mostrar Datos"
        Me.BtnMostrarDatos.UseVisualStyleBackColor = False
        '
        'BtnImprimir
        '
        Me.BtnImprimir.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.BtnImprimir.Location = New System.Drawing.Point(1137, 27)
        Me.BtnImprimir.Name = "BtnImprimir"
        Me.BtnImprimir.Size = New System.Drawing.Size(77, 28)
        Me.BtnImprimir.TabIndex = 59
        Me.BtnImprimir.Text = "Imprimir"
        Me.BtnImprimir.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(24, 71)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1213, 396)
        Me.DataGridView1.TabIndex = 63
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "Data Source=colmasqlfdc01\facdycdes;Initial Catalog=Tesoreria;Integrated Security" & _
    "=True"
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'FRM_Reporte_Patrimonio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1260, 479)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.CB_Folio)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.BtnMostrarDatos)
        Me.Controls.Add(Me.BtnImprimir)
        Me.Name = "FRM_Reporte_Patrimonio"
        Me.Text = "Movimientos de Alta"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CB_Folio As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents BtnMostrarDatos As System.Windows.Forms.Button
    Friend WithEvents BtnImprimir As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
End Class
