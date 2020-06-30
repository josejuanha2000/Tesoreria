Imports System.Data
Imports System.IO
Imports System.Text
Imports System.Data.OleDb
Imports System.Data.Odbc
Imports System.Data.SqlClient
Public Class Frm_SubCategorias
    Private Sub Frm_SubCategorias_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Dim SqlDASubCategorias As SqlDataAdapter
    Dim SqlCBSubCategorias As SqlCommandBuilder
    Dim DT As DataTable
    Dim cnn As New SqlConnection
    Private Sub Btn_Guardar_Click(sender As Object, e As EventArgs) Handles Btn_Guardar.Click
        Try
            cnn = New SqlConnection("Data Source=COLMASQLFDC01\FACDYCDES;Initial Catalog=Tesoreria;Integrated Security=True")
            cnn.Open()
            SqlDASubCategorias = New SqlDataAdapter("Select  Cve_SubCategoria, Nombre_SubCategoria from SubCategorias", cnn)
            DT = New DataTable
            SqlDASubCategorias.Fill(DT)
            DataGridView1.DataSource = DT
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub Btn_Actualizar_Click(sender As Object, e As EventArgs) Handles Btn_Actualizar.Click
        SqlCBSubcategorias = New SqlCommandBuilder(SqlDASubCategorias)
        SqlDASubCategorias.Update(DT)
        MsgBox("Datos guardados correctamente..!", , "Guardar")
    End Sub
End Class