<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Departamentos
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
        Me.Btn_Mostrar_Depto = New System.Windows.Forms.Button()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Btn_Actualizar_Depto = New System.Windows.Forms.Button()
        Me.Btn_Actualizar_Empleado = New System.Windows.Forms.Button()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Btn_Mostrar_Empleado = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Btn_Mostrar_Depto
        '
        Me.Btn_Mostrar_Depto.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Btn_Mostrar_Depto.Location = New System.Drawing.Point(36, 12)
        Me.Btn_Mostrar_Depto.Name = "Btn_Mostrar_Depto"
        Me.Btn_Mostrar_Depto.Size = New System.Drawing.Size(94, 33)
        Me.Btn_Mostrar_Depto.TabIndex = 20
        Me.Btn_Mostrar_Depto.Text = "Mostrar Deptos."
        Me.Btn_Mostrar_Depto.UseVisualStyleBackColor = True
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "Data Source=colmasqlfdc01\facdycdes;Initial Catalog=Tesoreria;Integrated Security" & _
    "=True"
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(27, 51)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(565, 522)
        Me.DataGridView1.TabIndex = 21
        '
        'Btn_Actualizar_Depto
        '
        Me.Btn_Actualizar_Depto.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Btn_Actualizar_Depto.Location = New System.Drawing.Point(484, 12)
        Me.Btn_Actualizar_Depto.Name = "Btn_Actualizar_Depto"
        Me.Btn_Actualizar_Depto.Size = New System.Drawing.Size(96, 33)
        Me.Btn_Actualizar_Depto.TabIndex = 22
        Me.Btn_Actualizar_Depto.Text = "Actualizar Depto."
        Me.Btn_Actualizar_Depto.UseVisualStyleBackColor = True
        '
        'Btn_Actualizar_Empleado
        '
        Me.Btn_Actualizar_Empleado.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Btn_Actualizar_Empleado.Location = New System.Drawing.Point(1075, 12)
        Me.Btn_Actualizar_Empleado.Name = "Btn_Actualizar_Empleado"
        Me.Btn_Actualizar_Empleado.Size = New System.Drawing.Size(114, 33)
        Me.Btn_Actualizar_Empleado.TabIndex = 25
        Me.Btn_Actualizar_Empleado.Text = "Actualizar Empleado"
        Me.Btn_Actualizar_Empleado.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(634, 51)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(565, 522)
        Me.DataGridView2.TabIndex = 24
        '
        'Btn_Mostrar_Empleado
        '
        Me.Btn_Mostrar_Empleado.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Btn_Mostrar_Empleado.Location = New System.Drawing.Point(643, 12)
        Me.Btn_Mostrar_Empleado.Name = "Btn_Mostrar_Empleado"
        Me.Btn_Mostrar_Empleado.Size = New System.Drawing.Size(109, 33)
        Me.Btn_Mostrar_Empleado.TabIndex = 23
        Me.Btn_Mostrar_Empleado.Text = "Mostrar Emplados"
        Me.Btn_Mostrar_Empleado.UseVisualStyleBackColor = True
        '
        'Frm_Departamentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1250, 600)
        Me.Controls.Add(Me.Btn_Actualizar_Empleado)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.Btn_Mostrar_Empleado)
        Me.Controls.Add(Me.Btn_Actualizar_Depto)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Btn_Mostrar_Depto)
        Me.Name = "Frm_Departamentos"
        Me.Text = "Departamentos FACDYC"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Btn_Mostrar_Depto As System.Windows.Forms.Button
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Btn_Actualizar_Depto As System.Windows.Forms.Button
    Friend WithEvents Btn_Actualizar_Empleado As System.Windows.Forms.Button
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents Btn_Mostrar_Empleado As System.Windows.Forms.Button
End Class
