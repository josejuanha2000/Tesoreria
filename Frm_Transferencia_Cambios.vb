Imports System.Data
Imports System.IO
Imports System.Text
Imports System.Data.OleDb
Imports System.Data.Odbc
Imports System.Data.SqlClient
Public Class Frm_Transferencia_Cambios
    Dim SqlDATransferencia As SqlDataAdapter
    Dim SqlCBTransferencia As SqlCommandBuilder
    Dim DT As DataTable
    Dim cnn As New SqlConnection
    Private Sub Frm_Transferencia_Cambios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
       
    End Sub
    Private Sub Btn_Mostrar_Click(sender As Object, e As EventArgs) Handles Btn_Mostrar.Click
        Try
            cnn = New SqlConnection("Data Source=COLMASQLFDC01\FACDYCDES;Initial Catalog=Tesoreria;Integrated Security=True")
            cnn.Open()
            SqlDATransferencia = New SqlDataAdapter("Select * from Transferencia where Transferencia.Folio_Recibe='" & TBFolio.Text & "'", cnn)
            DT = New DataTable
            SqlDATransferencia.Fill(DT)
            DataGridView1.DataSource = DT
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Btn_Actualizar_Click(sender As Object, e As EventArgs) Handles Btn_Actualizar.Click
        SqlCBTransferencia = New SqlCommandBuilder(SqlDATransferencia)
        SqlDATransferencia.Update(DT)
        MsgBox("Datos guardados correctamente..!", , "Guardar")
        TBFolio.Focus()
    End Sub
End Class