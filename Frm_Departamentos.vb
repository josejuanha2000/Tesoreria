Imports System.Data
Imports System.IO
Imports System.Text
Imports System.Data.OleDb
Imports System.Data.Odbc
Imports System.Data.SqlClient
Public Class Frm_Departamentos
    Dim cbdepartamento As New SqlCommand
    Dim dadepartamento As SqlDataReader
    Dim sqlDepto As New SqlCommand
    Dim sqldrDepto As SqlDataReader

    Dim SDADep As SqlDataAdapter
    Dim SCBDep As SqlCommandBuilder
    Dim DT As DataTable
    Dim cnn As New SqlConnection

    Dim SDAEmp As SqlDataAdapter
    Dim SCBEmp As SqlCommandBuilder
    Dim DT_EMP As DataTable
    Dim cnn_EMP As New SqlConnection
    Private Sub Frm_Departamentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Call cargar_departamentos()

    End Sub
    Private Sub Btn_Mostrar_Depto_Click(sender As Object, e As EventArgs) Handles Btn_Mostrar_Depto.Click
        Try
            cnn = New SqlConnection("Data Source=COLMASQLFDC01\FACDYCDES;Initial Catalog=Tesoreria;Integrated Security=True")
            cnn.Open()
            SDADep = New SqlDataAdapter("Select Id, Departamento, Titular from Departamentos", cnn)
            DT = New DataTable
            SDADep.Fill(DT)
            DataGridView1.DataSource = DT
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub Btn_Actualizar_Depto_Click(sender As Object, e As EventArgs) Handles Btn_Actualizar_Depto.Click
        SCBDep = New SqlCommandBuilder(SDADep)
        SDADep.Update(DT)
        MsgBox("Datos guardados correctamente..!", , "Guardar")
    End Sub

    Private Sub Btn_Mostrar_Empleado_Click(sender As Object, e As EventArgs) Handles Btn_Mostrar_Empleado.Click
        Try
            cnn_EMP = New SqlConnection("Data Source=COLMASQLFDC01\FACDYCDES;Initial Catalog=Tesoreria;Integrated Security=True")
            cnn_EMP.Open()
            SDAEmp = New SqlDataAdapter("Select Id_Departamento, Id_Empleado, Nombre_Empleado from Empleados", cnn_EMP)
            DT_EMP = New DataTable
            SDAEmp.Fill(DT_EMP)
            DataGridView2.DataSource = DT_EMP
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Btn_Actualizar_Empleado_Click(sender As Object, e As EventArgs) Handles Btn_Actualizar_Empleado.Click
        SCBEmp = New SqlCommandBuilder(SDAEmp)
        SDAEmp.Update(DT_EMP)
        MsgBox("Datos guardados correctamente..!", , "Guardar")
    End Sub
End Class