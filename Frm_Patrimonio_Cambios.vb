Imports System.Data
Imports System.IO
Imports System.Text
Imports System.Data.OleDb
Imports System.Data.Odbc
Imports System.Data.SqlClient
Public Class Frm_Patrimonio_Cambios
    Dim SqlDAPatrimonio As SqlDataAdapter
    Dim SqlCBPatrimonio As SqlCommandBuilder
    Dim DT As DataTable
    Dim cnn As New SqlConnection
    Private Sub Frm_Patrimonio_Cambios_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Btn_Mostrar_Click(sender As Object, e As EventArgs) Handles Btn_Mostrar.Click
        Try
            cnn = New SqlConnection("Data Source=COLMASQLFDC01\FACDYCDES;Initial Catalog=Tesoreria;Integrated Security=True")
            cnn.Open()
            SqlDAPatrimonio = New SqlDataAdapter("Select * from Patrimonio where Patrimonio.Folio='" & TBFolio.Text & "'", cnn)

            'CTArt4.CommandText = ("Select Nombre_art,Cve_Art,Cve_Pro from Articulo where Articulo.Cve_pro =  '" & TBCpro.Text & "'order by Nombre_Art Asc")
            DT = New DataTable
            SqlDAPatrimonio.Fill(DT)
            DataGridView1.DataSource = DT
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub Btn_Actualizar_Click(sender As Object, e As EventArgs) Handles Btn_Actualizar.Click
        SqlCBPatrimonio = New SqlCommandBuilder(SqlDAPatrimonio)
        SqlDAPatrimonio.Update(DT)
        MsgBox("Datos guardados correctamente..!", , "Guardar")
        TBFolio.Focus()
    End Sub
End Class