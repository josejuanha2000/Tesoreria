Imports System.Data
Imports System.IO
Imports System.Text
Imports System.Data.OleDb
Imports System.Data.Odbc
Imports System.Data.SqlClient
Public Class Frm_Categorias


    Dim SqlDAcategorias As SqlDataAdapter
    Dim SqlCBcategorias As SqlCommandBuilder
    Dim DT As DataTable
    Dim cnn As New SqlConnection
    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles Btn_Guardar.Click
        Try
            'cnn = New SqlConnection("Data Source=COLMASQLFDC01\FACDYCDES;Initial Catalog=Tesoreria;Integrated Security=True")
            cnn = New SqlConnection("Data Source = 148.234.110.22;Initial Catalog=Tesoreria;User ID=sa;Password=Facdyc2020")

            cnn.Open()
            SqlDAcategorias = New SqlDataAdapter("Select Id_Categoria, Cve_Categoria, Nombre_Categoria from Categorias", cnn)
            DT = New DataTable
            SqlDAcategorias.Fill(DT)
            DataGridView1.DataSource = DT
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub Btn_Actualizar_Click(sender As Object, e As EventArgs) Handles Btn_Actualizar.Click
        SqlCBcategorias = New SqlCommandBuilder(SqlDAcategorias)
        SqlDAcategorias.Update(DT)
        MsgBox("Datos guardados correctamente..!", , "Guardar")

    End Sub

    Private Sub Frm_Categorias_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class