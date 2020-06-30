﻿Imports System.Data.OleDb
Imports System.Data.Odbc
Imports System.Data.SqlClient
Imports System.Data
Imports System.IO
Imports System.Text
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.ReportAppServer
Imports CrystalDecisions.CrystalReports
Public Class FRM_Reporte_Transferencia

    Private Sub FRM_Reporte_Transferencia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call cargar_folio()
    End Sub
    Dim sqlfolio As New SqlCommand
    Dim sqldrfolio As SqlDataReader
    Public sql_transferencia As SqlCommand
    Dim d_table As DataTable
    Private d_adapter As SqlDataAdapter
    Sub cargar_folio()
        Try
            Me.SqlConnection1.Open()
            sqlfolio.CommandType = CommandType.Text
            sqlfolio.CommandText = ("select distinct Folio_Recibe  from Transferencia order by Folio_Recibe desc")
            sqlfolio.Connection = Me.SqlConnection1
            sqldrfolio = sqlfolio.ExecuteReader()
            While sqldrfolio.Read = True
                CB_Folio.Items.Add(sqldrfolio.Item(0))
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        sqldrfolio.Close()
        Me.SqlConnection1.Close()
    End Sub

    Private Sub BtnMostrarDatos_Click(sender As Object, e As EventArgs) Handles BtnMostrarDatos.Click
        Try
            Dim sql_movimiento_alta As String
            Me.SqlConnection1.Open()
            sql_movimiento_alta = ("Select * from Transferencia where  Folio_Recibe ='" & CB_Folio.Text & "'")
            sql_transferencia = New SqlCommand(sql_movimiento_alta, Me.SqlConnection1)
            sql_transferencia.CommandType = CommandType.Text
            sql_transferencia.ExecuteNonQuery()
            d_adapter = New SqlDataAdapter(sql_transferencia)
            d_table = New DataTable
            d_adapter.Fill(d_table)
            DataGridView1.DataSource = d_table
            Me.SqlConnection1.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub BtnImprimir_Click(sender As Object, e As EventArgs) Handles BtnImprimir.Click
        Try
            Dim sql_movimiento_alta As String
            Me.SqlConnection1.Open()
            'sqltitulados = ("Select * from AlumnosTitulados where  Fecha_Examen ='" & Format(DateTimePicker1.Value.Date.ToString, "Short Date") & "'" & "AND Carrera='" & CBCarrera.Text & "'" & "AND HORATP='" & CBHORA_TP.Text & "'" & "Order by Nombre")
            sql_movimiento_alta = ("Select * from Transferencia where  Folio_Recibe ='" & CB_Folio.Text & "'")
            sqlfolio = New SqlCommand(sql_movimiento_alta, Me.SqlConnection1)
            sqlfolio.CommandType = CommandType.Text
            sqlfolio.ExecuteNonQuery()
            d_adapter = New SqlDataAdapter(sqlfolio)
            d_table = New DataTable
            d_adapter.Fill(d_table)

            Dim cr As New CR_Transferencia
            cr.SetDataSource(d_table)

            Dim r As New Frm_Impresion_Transferencias
            r.CrystalReportViewer1.ReportSource = cr
            'r.CRViewer_Patrimonio.ReportSource = cr
            r.ShowDialog()
            Me.SqlConnection1.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class