﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_SubCategorias
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
        Me.Btn_Actualizar = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Btn_Guardar = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Btn_Actualizar
        '
        Me.Btn_Actualizar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Btn_Actualizar.Location = New System.Drawing.Point(460, 12)
        Me.Btn_Actualizar.Name = "Btn_Actualizar"
        Me.Btn_Actualizar.Size = New System.Drawing.Size(99, 48)
        Me.Btn_Actualizar.TabIndex = 28
        Me.Btn_Actualizar.Text = "Actualizar"
        Me.Btn_Actualizar.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(18, 77)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(541, 546)
        Me.DataGridView1.TabIndex = 27
        '
        'Btn_Guardar
        '
        Me.Btn_Guardar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Btn_Guardar.Location = New System.Drawing.Point(18, 12)
        Me.Btn_Guardar.Name = "Btn_Guardar"
        Me.Btn_Guardar.Size = New System.Drawing.Size(99, 48)
        Me.Btn_Guardar.TabIndex = 26
        Me.Btn_Guardar.Text = "Mostrar"
        Me.Btn_Guardar.UseVisualStyleBackColor = True
        '
        'Frm_SubCategorias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(579, 633)
        Me.Controls.Add(Me.Btn_Actualizar)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Btn_Guardar)
        Me.Name = "Frm_SubCategorias"
        Me.Text = "Asignación de Subcategorias"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Btn_Actualizar As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Btn_Guardar As System.Windows.Forms.Button
End Class
