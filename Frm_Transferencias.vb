Imports System.Data
Imports System.IO
Imports System.Text
Imports System.Data.OleDb
Imports System.Data.Odbc
Imports System.Data.SqlClient
Public Class Frm_Transferencias
    Dim sqlfolio As New SqlCommand
    Dim sqldrFolio As SqlDataReader
    Dim sqlsd_departamento As New SqlCommand
    Dim sqlda_departamento As SqlDataReader

    Dim CTArt1 As New SqlCommand
    Dim DAARTICULO1 As SqlDataReader
    Dim CTArt2 As New SqlCommand
    Dim DAARTICULO2 As SqlDataReader
    Dim CTArt3 As New SqlCommand
    Dim DAARTICULO3 As SqlDataReader
    Dim CTArt4 As New SqlCommand
    Dim DAARTICULO4 As SqlDataReader
    Dim CTArt5 As New SqlCommand
    Dim DAARTICULO5 As SqlDataReader
    Dim CTArt6 As New SqlCommand
    Dim DAARTICULO6 As SqlDataReader
    Dim CTArt7 As New SqlCommand
    Dim DAARTICULO7 As SqlDataReader
    Dim CTArt8 As New SqlCommand
    Dim DAARTICULO8 As SqlDataReader
    Dim CTArt9 As New SqlCommand
    Dim DAARTICULO9 As SqlDataReader
    Dim CTArt10 As New SqlCommand
    Dim DAARTICULO10 As SqlDataReader
    Dim CTArt11 As New SqlCommand
    Dim DAARTICULO11 As SqlDataReader
    Dim CTArt12 As New SqlCommand
    Dim DAARTICULO12 As SqlDataReader
    Dim CTArt13 As New SqlCommand
    Dim DAARTICULO13 As SqlDataReader
    Dim CTArt14 As New SqlCommand
    Dim DAARTICULO14 As SqlDataReader
    Dim CTArt15 As New SqlCommand
    Dim DAARTICULO15 As SqlDataReader
    Dim CTArt16 As New SqlCommand
    Dim DAARTICULO16 As SqlDataReader
    Dim CTArt17 As New SqlCommand
    Dim DAARTICULO17 As SqlDataReader
    Dim CTArt18 As New SqlCommand
    Dim DAARTICULO18 As SqlDataReader
    Dim CTArt19 As New SqlCommand
    Dim DAARTICULO19 As SqlDataReader
    Dim CTArt20 As New SqlCommand
    Dim DAARTICULO20 As SqlDataReader
    

    'Dim drdel_A1 As SqlCommand

    Dim st1 As Integer = 0
    Dim st2 As Integer = 0
    Dim st3 As Integer = 0
    Dim st4 As Integer = 0
    Dim st5 As Integer = 0
    Dim st6 As Integer = 0
    Dim st7 As Integer = 0
    Dim st8 As Integer = 0
    Dim st9 As Integer = 0
    Dim st10 As Integer = 0
    Dim st11 As Integer = 0
    Dim st12 As Integer = 0
    Dim st13 As Integer = 0
    Dim st14 As Integer = 0
    Dim st15 As Integer = 0
    Dim st16 As Integer = 0
    Dim st17 As Integer = 0
    Dim st18 As Integer = 0
    Dim st19 As Integer = 0
    Dim st20 As Integer = 0

    Private Sub Frm_Transferencias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call buscar_ultimo_folio_transferencia()
        Call cargar_folio()
        Call cargar_departamentos()
    End Sub
    Sub cargar_folio()
        Try
            Me.SqlConnection1.Open()
            sqlfolio.CommandType = CommandType.Text
            sqlfolio.CommandText = ("select distinct folio from Patrimonio order by Folio desc")
            sqlfolio.Connection = Me.SqlConnection1
            sqldrFolio = sqlfolio.ExecuteReader()
            While sqldrFolio.Read = True
                CB_Folio.Items.Add(sqldrFolio.Item(0))
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        sqldrFolio.Close()
        Me.SqlConnection1.Close()
    End Sub
    Sub buscar_folio()
        Try
            Me.SqlConnection1.Open()
            'Btn_Transferir_Equipo.Enabled = False
            sqlfolio.CommandType = CommandType.Text
            sqlfolio.CommandText = ("Select * from Patrimonio where Patrimonio.Folio =  '" & CB_Folio.Text & "'")
            sqlfolio.Connection = Me.SqlConnection1
            sqldrFolio = sqlfolio.ExecuteReader()
            While (sqldrFolio.Read())
                CB_Departamento.Text = sqldrFolio("Departamento")
                CB_Responsable_Entrega.Text = sqldrFolio("Titular")
                'TB_Solicitud_Transferencia.Text = sqldrFolio("Solicitud")
                CB_Responsable_Entrega.Text = sqldrFolio("Titular")
                TB_Solicitud_Entrega.Text = sqldrFolio("Solicitud")



            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        sqldrFolio.Close()
        Me.SqlConnection1.Close()
    End Sub
    Sub buscar_ultimo_folio_transferencia()
        Try
            Me.SqlConnection1.Open()
            Dim comsql As New SqlClient.SqlCommand
            comsql.Connection = Me.SqlConnection1
            comsql.CommandText = ("select top 1 * from Transferencia order by Folio_Recibe desc")
            Dim DRFolio As SqlClient.SqlDataReader
            DRFolio = comsql.ExecuteReader(CommandBehavior.CloseConnection)
            DRFolio.Read()
            TB_Folio_Transferencia.Text = DRFolio("Folio_Recibe") + 1
            DRFolio.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Me.SqlConnection1.Close()
    End Sub
    Sub cargar_departamentos()
        Try
            Me.SqlConnection1.Open()
            sqlsd_departamento.CommandType = CommandType.Text
            sqlsd_departamento.CommandText = ("select  Departamento,Titular,Id  from Departamentos")
            sqlsd_departamento.Connection = Me.SqlConnection1
            sqlda_departamento = sqlsd_departamento.ExecuteReader()
            While sqlda_departamento.Read = True
                CB_Depto_Transferencia.Items.Add(sqlda_departamento.Item(0))
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        sqlsd_departamento.CommandType = CommandType.StoredProcedure
        sqlsd_departamento.Connection = Me.SqlConnection1
        sqlsd_departamento.CommandText = ("Buscar_Titular_Depto")
        sqlsd_departamento.Parameters.Add("var_nombre_departamento", SqlDbType.NVarChar, 50)
        sqlda_departamento.Close()
        Me.SqlConnection1.Close()
    End Sub
    Private Sub CB_Depto_Transferencia_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_Depto_Transferencia.SelectedIndexChanged
        Try
            Me.SqlConnection1.Open()
            sqlsd_departamento.Parameters("var_nombre_departamento").Value = CB_Depto_Transferencia.SelectedItem
            sqlda_departamento = sqlsd_departamento.ExecuteReader()
            sqlda_departamento.Read()
            CB_Responsable_Recibe.Text = sqlda_departamento("Titular").ToString
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Me.SqlConnection1.Close()
        'Call cargar_Art1()
        'Call cargar_Art2()
    End Sub
    Sub cargar_Art1()
        Try
            Me.SqlConnection1.Open()
            CTArt1.CommandType = CommandType.Text
            'CTArt1.CommandText = ("Select Cve_Art,Nombre_art,Justificacion,Cant_Art,Precio_Unitario,Status_Titular,Status_Sub_Adm from Requerimiento where Requerimiento.Folio =  '" & TB_Pat1.Text & "'" & "and Act='" & 1 & "'")
            CTArt1.CommandText = ("Select * from Patrimonio where Patrimonio.Folio =  '" & CB_Folio.Text & "'" & "and Act='" & 1 & "'")
            CTArt1.Connection = Me.SqlConnection1
            DAARTICULO1 = CTArt1.ExecuteReader()
            If DAARTICULO1.Read() = True Then
                TB_CI_1.Text = DAARTICULO1("No_Activo")
                TB_CAT1.Text = DAARTICULO1("Cve_Categoria")
                TB_Cve_A1.Text = DAARTICULO1("Cve_SubCategoria")
                TB_Art1.Text = DAARTICULO1("Descripcion")
                TB_Marca1.Text = DAARTICULO1("Marca")
                TB_Modelo1.Text = DAARTICULO1("Modelo")
                TB_Serie1.Text = DAARTICULO1("Serie")
                TB_NoFactura1.Text = DAARTICULO1("No_Factura")
                DateTimePicker_Factura1.Text = DAARTICULO1("Fecha_Factura")
                NUpDown_CanArt1.Text = DAARTICULO1("Cantidad_Articulos")
                TB_CostoUnit1.Text = DAARTICULO1("Costo_Unitario")
                TB_CostoTotal1.Text = DAARTICULO1("Costo_Total")
            Else
                ChB_Status1.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        DAARTICULO1.Close()
        Me.SqlConnection1.Close()
    End Sub
    Sub cargar_Art2()
        Try
            Me.SqlConnection1.Open()
            CTArt2.CommandType = CommandType.Text
            CTArt2.CommandText = ("Select * from Patrimonio where Patrimonio.Folio =  '" & CB_Folio.Text & "'" & "and Act='" & 2 & "'")
            CTArt2.Connection = Me.SqlConnection1
            DAARTICULO2 = CTArt2.ExecuteReader()
            If DAARTICULO2.Read() = True Then
                TB_CI_2.Text = DAARTICULO2("No_Activo")
                TB_CAT2.Text = DAARTICULO2("Cve_Categoria")
                TB_Cve_A2.Text = DAARTICULO2("Cve_SubCategoria")
                TB_Art2.Text = DAARTICULO2("Descripcion")
                TB_Marca2.Text = DAARTICULO2("Marca")
                TB_Modelo2.Text = DAARTICULO2("Modelo")
                TB_Serie2.Text = DAARTICULO2("Serie")
                TB_NoFactura2.Text = DAARTICULO2("No_Factura")
                DateTimePicker_Factura2.Text = DAARTICULO2("Fecha_Factura")
                NUpDown_CanArt2.Text = DAARTICULO2("Cantidad_Articulos")
                TB_CostoUnit2.Text = DAARTICULO2("Costo_Unitario")
                TB_CostoTotal2.Text = DAARTICULO2("Costo_Total")
            Else
                ChB_Status2.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        DAARTICULO2.Close()
        Me.SqlConnection1.Close()
    End Sub
    Sub cargar_Art3()
        Try
            Me.SqlConnection1.Open()
            CTArt3.CommandType = CommandType.Text
            CTArt3.CommandText = ("Select * from Patrimonio where Patrimonio.Folio =  '" & CB_Folio.Text & "'" & "and Act='" & 3 & "'")
            CTArt3.Connection = Me.SqlConnection1
            DAARTICULO3 = CTArt3.ExecuteReader()
            If DAARTICULO3.Read() = True Then
                TB_CI_3.Text = DAARTICULO3("No_Activo")
                TB_CAT3.Text = DAARTICULO3("Cve_Categoria")
                TB_Cve_A3.Text = DAARTICULO3("Cve_SubCategoria")
                TB_Art3.Text = DAARTICULO3("Descripcion")
                TB_Marca3.Text = DAARTICULO3("Marca")
                TB_Modelo3.Text = DAARTICULO3("Modelo")
                TB_Serie3.Text = DAARTICULO3("Serie")
                TB_NoFactura3.Text = DAARTICULO3("No_Factura")
                DateTimePicker_Factura3.Text = DAARTICULO3("Fecha_Factura")
                NUpDown_CanArt3.Text = DAARTICULO3("Cantidad_Articulos")
                TB_CostoUnit3.Text = DAARTICULO3("Costo_Unitario")
                TB_CostoTotal3.Text = DAARTICULO3("Costo_Total")
            Else
                ChB_Status3.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        DAARTICULO3.Close()
        Me.SqlConnection1.Close()
    End Sub
    Sub cargar_Art4()
        Try
            Me.SqlConnection1.Open()
            CTArt4.CommandType = CommandType.Text
            CTArt4.CommandText = ("Select * from Patrimonio where Patrimonio.Folio =  '" & CB_Folio.Text & "'" & "and Act='" & 4 & "'")
            CTArt4.Connection = Me.SqlConnection1
            DAARTICULO4 = CTArt4.ExecuteReader()
            If DAARTICULO4.Read() = True Then
                TB_CI_4.Text = DAARTICULO4("No_Activo")
                TB_CAT4.Text = DAARTICULO4("Cve_Categoria")
                TB_Cve_A4.Text = DAARTICULO4("Cve_SubCategoria")
                TB_Art4.Text = DAARTICULO4("Descripcion")
                TB_Marca4.Text = DAARTICULO4("Marca")
                TB_Modelo4.Text = DAARTICULO4("Modelo")
                TB_Serie4.Text = DAARTICULO4("Serie")
                TB_NoFactura4.Text = DAARTICULO4("No_Factura")
                DateTimePicker_Factura4.Text = DAARTICULO4("Fecha_Factura")
                NUpDown_CanArt4.Text = DAARTICULO4("Cantidad_Articulos")
                TB_CostoUnit4.Text = DAARTICULO4("Costo_Unitario")
                TB_CostoTotal4.Text = DAARTICULO4("Costo_Total")
            Else
                ChB_Status4.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        DAARTICULO4.Close()
        Me.SqlConnection1.Close()
    End Sub
    Sub cargar_Art5()
        Try
            Me.SqlConnection1.Open()
            CTArt5.CommandType = CommandType.Text
            CTArt5.CommandText = ("Select * from Patrimonio where Patrimonio.Folio =  '" & CB_Folio.Text & "'" & "and Act='" & 5 & "'")
            CTArt5.Connection = Me.SqlConnection1
            DAARTICULO5 = CTArt5.ExecuteReader()
            If DAARTICULO5.Read() = True Then
                TB_CI_5.Text = DAARTICULO5("No_Activo")
                TB_CAT5.Text = DAARTICULO5("Cve_Categoria")
                TB_Cve_A5.Text = DAARTICULO5("Cve_SubCategoria")
                TB_Art5.Text = DAARTICULO5("Descripcion")
                TB_Marca5.Text = DAARTICULO5("Marca")
                TB_Modelo5.Text = DAARTICULO5("Modelo")
                TB_Serie5.Text = DAARTICULO5("Serie")
                TB_NoFactura5.Text = DAARTICULO5("No_Factura")
                DateTimePicker_Factura5.Text = DAARTICULO5("Fecha_Factura")
                NUpDown_CanArt5.Text = DAARTICULO5("Cantidad_Articulos")
                TB_CostoUnit5.Text = DAARTICULO5("Costo_Unitario")
                TB_CostoTotal5.Text = DAARTICULO5("Costo_Total")
            Else
                ChB_Status5.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        DAARTICULO5.Close()
        Me.SqlConnection1.Close()
    End Sub
    Sub cargar_Art6()
        Try
            Me.SqlConnection1.Open()
            CTArt6.CommandType = CommandType.Text
            CTArt6.CommandText = ("Select * from Patrimonio where Patrimonio.Folio =  '" & CB_Folio.Text & "'" & "and Act='" & 6 & "'")
            CTArt6.Connection = Me.SqlConnection1
            DAARTICULO6 = CTArt6.ExecuteReader()
            If DAARTICULO6.Read() = True Then
                TB_CI_6.Text = DAARTICULO6("No_Activo")
                TB_CAT6.Text = DAARTICULO6("Cve_Categoria")
                TB_Cve_A6.Text = DAARTICULO6("Cve_SubCategoria")
                TB_Art6.Text = DAARTICULO6("Descripcion")
                TB_Marca6.Text = DAARTICULO6("Marca")
                TB_Modelo6.Text = DAARTICULO6("Modelo")
                TB_Serie6.Text = DAARTICULO6("Serie")
                TB_NoFactura6.Text = DAARTICULO6("No_Factura")
                DateTimePicker_Factura6.Text = DAARTICULO6("Fecha_Factura")
                NUpDown_CanArt6.Text = DAARTICULO6("Cantidad_Articulos")
                TB_CostoUnit6.Text = DAARTICULO6("Costo_Unitario")
                TB_CostoTotal6.Text = DAARTICULO6("Costo_Total")
            Else
                ChB_Status6.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        DAARTICULO6.Close()
        Me.SqlConnection1.Close()
    End Sub
    Sub cargar_Art7()
        Try
            Me.SqlConnection1.Open()
            CTArt7.CommandType = CommandType.Text
            CTArt7.CommandText = ("Select * from Patrimonio where Patrimonio.Folio =  '" & CB_Folio.Text & "'" & "and Act='" & 7 & "'")
            CTArt7.Connection = Me.SqlConnection1
            DAARTICULO7 = CTArt7.ExecuteReader()
            If DAARTICULO7.Read() = True Then
                TB_CI_7.Text = DAARTICULO7("No_Activo")
                TB_CAT7.Text = DAARTICULO7("Cve_Categoria")
                TB_Cve_A7.Text = DAARTICULO7("Cve_SubCategoria")
                TB_Art7.Text = DAARTICULO7("Descripcion")
                TB_Marca7.Text = DAARTICULO7("Marca")
                TB_Modelo7.Text = DAARTICULO7("Modelo")
                TB_Serie7.Text = DAARTICULO7("Serie")
                TB_NoFactura7.Text = DAARTICULO7("No_Factura")
                DateTimePicker_Factura7.Text = DAARTICULO7("Fecha_Factura")
                NUpDown_CanArt7.Text = DAARTICULO7("Cantidad_Articulos")
                TB_CostoUnit7.Text = DAARTICULO7("Costo_Unitario")
                TB_CostoTotal7.Text = DAARTICULO7("Costo_Total")
            Else
                ChB_Status7.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        DAARTICULO7.Close()
        Me.SqlConnection1.Close()
    End Sub
    Sub cargar_Art8()
        Try
            Me.SqlConnection1.Open()
            CTArt8.CommandType = CommandType.Text
            CTArt8.CommandText = ("Select * from Patrimonio where Patrimonio.Folio =  '" & CB_Folio.Text & "'" & "and Act='" & 8 & "'")
            CTArt8.Connection = Me.SqlConnection1
            DAARTICULO8 = CTArt8.ExecuteReader()
            If DAARTICULO8.Read() = True Then
                TB_CI_8.Text = DAARTICULO8("No_Activo")
                TB_CAT8.Text = DAARTICULO8("Cve_Categoria")
                TB_Cve_A8.Text = DAARTICULO8("Cve_SubCategoria")
                TB_Art8.Text = DAARTICULO8("Descripcion")
                TB_Marca8.Text = DAARTICULO8("Marca")
                TB_Modelo8.Text = DAARTICULO8("Modelo")
                TB_Serie8.Text = DAARTICULO8("Serie")
                TB_NoFactura8.Text = DAARTICULO8("No_Factura")
                DateTimePicker_Factura8.Text = DAARTICULO8("Fecha_Factura")
                NUpDown_CanArt8.Text = DAARTICULO8("Cantidad_Articulos")
                TB_CostoUnit8.Text = DAARTICULO8("Costo_Unitario")
                TB_CostoTotal8.Text = DAARTICULO8("Costo_Total")
            Else
                ChB_Status8.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        DAARTICULO8.Close()
        Me.SqlConnection1.Close()
    End Sub
    Sub cargar_Art9()
        Try
            Me.SqlConnection1.Open()
            CTArt9.CommandType = CommandType.Text
            CTArt9.CommandText = ("Select * from Patrimonio where Patrimonio.Folio =  '" & CB_Folio.Text & "'" & "and Act='" & 9 & "'")
            CTArt9.Connection = Me.SqlConnection1
            DAARTICULO9 = CTArt9.ExecuteReader()
            If DAARTICULO9.Read() = True Then
                TB_CI_9.Text = DAARTICULO9("No_Activo")
                TB_CAT9.Text = DAARTICULO9("Cve_Categoria")
                TB_Cve_A9.Text = DAARTICULO9("Cve_SubCategoria")
                TB_Art9.Text = DAARTICULO9("Descripcion")
                TB_Marca9.Text = DAARTICULO9("Marca")
                TB_Modelo9.Text = DAARTICULO9("Modelo")
                TB_Serie9.Text = DAARTICULO9("Serie")
                TB_NoFactura9.Text = DAARTICULO9("No_Factura")
                DateTimePicker_Factura8.Text = DAARTICULO9("Fecha_Factura")
                NUpDown_CanArt9.Text = DAARTICULO9("Cantidad_Articulos")
                TB_CostoUnit9.Text = DAARTICULO9("Costo_Unitario")
                TB_CostoTotal9.Text = DAARTICULO9("Costo_Total")
            Else
                ChB_Status9.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        DAARTICULO9.Close()
        Me.SqlConnection1.Close()
    End Sub
    Sub cargar_Art10()
        Try
            Me.SqlConnection1.Open()
            CTArt10.CommandType = CommandType.Text
            CTArt10.CommandText = ("Select * from Patrimonio where Patrimonio.Folio =  '" & CB_Folio.Text & "'" & "and Act='" & 10 & "'")
            CTArt10.Connection = Me.SqlConnection1
            DAARTICULO10 = CTArt10.ExecuteReader()
            If DAARTICULO10.Read() = True Then
                TB_CI_10.Text = DAARTICULO10("No_Activo")
                TB_CAT10.Text = DAARTICULO10("Cve_Categoria")
                TB_Cve_A10.Text = DAARTICULO10("Cve_SubCategoria")
                TB_Art10.Text = DAARTICULO10("Descripcion")
                TB_Marca10.Text = DAARTICULO10("Marca")
                TB_Modelo10.Text = DAARTICULO10("Modelo")
                TB_Serie10.Text = DAARTICULO10("Serie")
                TB_NoFactura10.Text = DAARTICULO10("No_Factura")
                DateTimePicker_Factura10.Text = DAARTICULO10("Fecha_Factura")
                NUpDown_CanArt10.Text = DAARTICULO10("Cantidad_Articulos")
                TB_CostoUnit10.Text = DAARTICULO10("Costo_Unitario")
                TB_CostoTotal10.Text = DAARTICULO10("Costo_Total")
            Else
                ChB_Status10.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        DAARTICULO10.Close()
        Me.SqlConnection1.Close()
    End Sub
    Sub cargar_Art11()
        Try
            Me.SqlConnection1.Open()
            CTArt11.CommandType = CommandType.Text
            CTArt11.CommandText = ("Select * from Patrimonio where Patrimonio.Folio =  '" & CB_Folio.Text & "'" & "and Act='" & 11 & "'")
            CTArt11.Connection = Me.SqlConnection1
            DAARTICULO11 = CTArt11.ExecuteReader()
            If DAARTICULO11.Read() = True Then
                TB_CI_11.Text = DAARTICULO11("No_Activo")
                TB_CAT11.Text = DAARTICULO11("Cve_Categoria")
                TB_Cve_A11.Text = DAARTICULO11("Cve_SubCategoria")
                TB_Art11.Text = DAARTICULO11("Descripcion")
                TB_Marca11.Text = DAARTICULO11("Marca")
                TB_Modelo11.Text = DAARTICULO11("Modelo")
                TB_Serie11.Text = DAARTICULO11("Serie")
                TB_NoFactura11.Text = DAARTICULO11("No_Factura")
                DateTimePicker_Factura11.Text = DAARTICULO11("Fecha_Factura")
                NUpDown_CanArt11.Text = DAARTICULO11("Cantidad_Articulos")
                TB_CostoUnit11.Text = DAARTICULO11("Costo_Unitario")
                TB_CostoTotal11.Text = DAARTICULO11("Costo_Total")
            Else
                ChB_Status11.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        DAARTICULO11.Close()
        Me.SqlConnection1.Close()
    End Sub
    Sub cargar_Art12()
        Try
            Me.SqlConnection1.Open()
            CTArt12.CommandType = CommandType.Text
            CTArt12.CommandText = ("Select * from Patrimonio where Patrimonio.Folio =  '" & CB_Folio.Text & "'" & "and Act='" & 12 & "'")
            CTArt12.Connection = Me.SqlConnection1
            DAARTICULO12 = CTArt12.ExecuteReader()
            If DAARTICULO12.Read() = True Then
                TB_CI_12.Text = DAARTICULO12("No_Activo")
                TB_CAT12.Text = DAARTICULO12("Cve_Categoria")
                TB_Cve_A12.Text = DAARTICULO12("Cve_SubCategoria")
                TB_Art12.Text = DAARTICULO12("Descripcion")
                TB_Marca12.Text = DAARTICULO12("Marca")
                TB_Modelo12.Text = DAARTICULO12("Modelo")
                TB_Serie12.Text = DAARTICULO12("Serie")
                TB_NoFactura12.Text = DAARTICULO12("No_Factura")
                DateTimePicker_Factura12.Text = DAARTICULO12("Fecha_Factura")
                NUpDown_CanArt12.Text = DAARTICULO12("Cantidad_Articulos")
                TB_CostoUnit12.Text = DAARTICULO12("Costo_Unitario")
                TB_CostoTotal12.Text = DAARTICULO12("Costo_Total")
            Else
                ChB_Status12.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        DAARTICULO12.Close()
        Me.SqlConnection1.Close()
    End Sub
    Sub cargar_Art13()
        Try
            Me.SqlConnection1.Open()
            CTArt13.CommandType = CommandType.Text
            CTArt13.CommandText = ("Select * from Patrimonio where Patrimonio.Folio =  '" & CB_Folio.Text & "'" & "and Act='" & 13 & "'")
            CTArt13.Connection = Me.SqlConnection1
            DAARTICULO13 = CTArt13.ExecuteReader()
            If DAARTICULO13.Read() = True Then
                TB_CI_13.Text = DAARTICULO13("No_Activo")
                TB_CAT13.Text = DAARTICULO13("Cve_Categoria")
                TB_Cve_A13.Text = DAARTICULO13("Cve_SubCategoria")
                TB_Art13.Text = DAARTICULO13("Descripcion")
                TB_Marca13.Text = DAARTICULO13("Marca")
                TB_Modelo13.Text = DAARTICULO13("Modelo")
                TB_Serie13.Text = DAARTICULO13("Serie")
                TB_NoFactura13.Text = DAARTICULO13("No_Factura")
                DateTimePicker_Factura13.Text = DAARTICULO13("Fecha_Factura")
                NUpDown_CanArt13.Text = DAARTICULO13("Cantidad_Articulos")
                TB_CostoUnit13.Text = DAARTICULO13("Costo_Unitario")
                TB_CostoTotal13.Text = DAARTICULO13("Costo_Total")
            Else
                ChB_Status13.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        DAARTICULO13.Close()
        Me.SqlConnection1.Close()
    End Sub
    Sub cargar_Art14()
        Try
            Me.SqlConnection1.Open()
            CTArt14.CommandType = CommandType.Text
            CTArt14.CommandText = ("Select * from Patrimonio where Patrimonio.Folio =  '" & CB_Folio.Text & "'" & "and Act='" & 14 & "'")
            CTArt14.Connection = Me.SqlConnection1
            DAARTICULO14 = CTArt14.ExecuteReader()
            If DAARTICULO14.Read() = True Then
                TB_CI_14.Text = DAARTICULO14("No_Activo")
                TB_CAT14.Text = DAARTICULO14("Cve_Categoria")
                TB_Cve_A14.Text = DAARTICULO14("Cve_SubCategoria")
                TB_Art14.Text = DAARTICULO14("Descripcion")
                TB_Marca14.Text = DAARTICULO14("Marca")
                TB_Modelo14.Text = DAARTICULO14("Modelo")
                TB_Serie14.Text = DAARTICULO14("Serie")
                TB_NoFactura14.Text = DAARTICULO14("No_Factura")
                DateTimePicker_Factura14.Text = DAARTICULO14("Fecha_Factura")
                NUpDown_CanArt14.Text = DAARTICULO14("Cantidad_Articulos")
                TB_CostoUnit14.Text = DAARTICULO14("Costo_Unitario")
                TB_CostoTotal14.Text = DAARTICULO14("Costo_Total")
            Else
                ChB_Status14.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        DAARTICULO14.Close()
        Me.SqlConnection1.Close()
    End Sub
    Sub cargar_Art15()
        Try
            Me.SqlConnection1.Open()
            CTArt15.CommandType = CommandType.Text
            CTArt15.CommandText = ("Select * from Patrimonio where Patrimonio.Folio =  '" & CB_Folio.Text & "'" & "and Act='" & 15 & "'")
            CTArt15.Connection = Me.SqlConnection1
            DAARTICULO15 = CTArt15.ExecuteReader()
            If DAARTICULO15.Read() = True Then
                TB_CI_15.Text = DAARTICULO15("No_Activo")
                TB_CAT15.Text = DAARTICULO15("Cve_Categoria")
                TB_Cve_A15.Text = DAARTICULO15("Cve_SubCategoria")
                TB_Art15.Text = DAARTICULO15("Descripcion")
                TB_Marca15.Text = DAARTICULO15("Marca")
                TB_Modelo15.Text = DAARTICULO15("Modelo")
                TB_Serie15.Text = DAARTICULO15("Serie")
                TB_NoFactura15.Text = DAARTICULO15("No_Factura")
                DateTimePicker_Factura15.Text = DAARTICULO15("Fecha_Factura")
                NUpDown_CanArt15.Text = DAARTICULO15("Cantidad_Articulos")
                TB_CostoUnit15.Text = DAARTICULO15("Costo_Unitario")
                TB_CostoTotal15.Text = DAARTICULO15("Costo_Total")
            Else
                ChB_Status15.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        DAARTICULO15.Close()
        Me.SqlConnection1.Close()
    End Sub
    Sub cargar_Art16()
        Try
            Me.SqlConnection1.Open()
            CTArt16.CommandType = CommandType.Text
            CTArt16.CommandText = ("Select * from Patrimonio where Patrimonio.Folio =  '" & CB_Folio.Text & "'" & "and Act='" & 16 & "'")
            CTArt16.Connection = Me.SqlConnection1
            DAARTICULO16 = CTArt16.ExecuteReader()
            If DAARTICULO16.Read() = True Then
                TB_CI_16.Text = DAARTICULO16("No_Activo")
                TB_CAT16.Text = DAARTICULO16("Cve_Categoria")
                TB_Cve_A16.Text = DAARTICULO16("Cve_SubCategoria")
                TB_Art16.Text = DAARTICULO16("Descripcion")
                TB_Marca16.Text = DAARTICULO16("Marca")
                TB_Modelo16.Text = DAARTICULO16("Modelo")
                TB_Serie16.Text = DAARTICULO16("Serie")
                TB_NoFactura16.Text = DAARTICULO16("No_Factura")
                DateTimePicker_Factura16.Text = DAARTICULO16("Fecha_Factura")
                NUpDown_CanArt16.Text = DAARTICULO16("Cantidad_Articulos")
                TB_CostoUnit16.Text = DAARTICULO16("Costo_Unitario")
                TB_CostoTotal16.Text = DAARTICULO16("Costo_Total")
            Else
                ChB_Status16.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        DAARTICULO16.Close()
        Me.SqlConnection1.Close()
    End Sub
    Sub cargar_Art17()
        Try
            Me.SqlConnection1.Open()
            CTArt17.CommandType = CommandType.Text
            CTArt17.CommandText = ("Select * from Patrimonio where Patrimonio.Folio =  '" & CB_Folio.Text & "'" & "and Act='" & 17 & "'")
            CTArt17.Connection = Me.SqlConnection1
            DAARTICULO17 = CTArt17.ExecuteReader()
            If DAARTICULO17.Read() = True Then
                TB_CI_17.Text = DAARTICULO17("No_Activo")
                TB_CAT17.Text = DAARTICULO17("Cve_Categoria")
                TB_Cve_A17.Text = DAARTICULO17("Cve_SubCategoria")
                TB_Art17.Text = DAARTICULO17("Descripcion")
                TB_Marca17.Text = DAARTICULO17("Marca")
                TB_Modelo17.Text = DAARTICULO17("Modelo")
                TB_Serie17.Text = DAARTICULO17("Serie")
                TB_NoFactura17.Text = DAARTICULO17("No_Factura")
                DateTimePicker_Factura17.Text = DAARTICULO17("Fecha_Factura")
                NUpDown_CanArt17.Text = DAARTICULO17("Cantidad_Articulos")
                TB_CostoUnit17.Text = DAARTICULO17("Costo_Unitario")
                TB_CostoTotal17.Text = DAARTICULO17("Costo_Total")
            Else
                ChB_Status17.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        DAARTICULO17.Close()
        Me.SqlConnection1.Close()
    End Sub
    Sub cargar_Art18()
        Try
            Me.SqlConnection1.Open()
            CTArt18.CommandType = CommandType.Text
            CTArt18.CommandText = ("Select * from Patrimonio where Patrimonio.Folio =  '" & CB_Folio.Text & "'" & "and Act='" & 18 & "'")
            CTArt18.Connection = Me.SqlConnection1
            DAARTICULO18 = CTArt18.ExecuteReader()
            If DAARTICULO18.Read() = True Then
                TB_CI_18.Text = DAARTICULO18("No_Activo")
                TB_CAT18.Text = DAARTICULO18("Cve_Categoria")
                TB_Cve_A18.Text = DAARTICULO18("Cve_SubCategoria")
                TB_Art18.Text = DAARTICULO18("Descripcion")
                TB_Marca18.Text = DAARTICULO18("Marca")
                TB_Modelo18.Text = DAARTICULO18("Modelo")
                TB_Serie18.Text = DAARTICULO18("Serie")
                TB_NoFactura18.Text = DAARTICULO18("No_Factura")
                DateTimePicker_Factura18.Text = DAARTICULO18("Fecha_Factura")
                NUpDown_CanArt18.Text = DAARTICULO18("Cantidad_Articulos")
                TB_CostoUnit18.Text = DAARTICULO18("Costo_Unitario")
                TB_CostoTotal18.Text = DAARTICULO18("Costo_Total")
            Else
                ChB_Status18.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        DAARTICULO18.Close()
        Me.SqlConnection1.Close()
    End Sub
    Sub cargar_Art19()
        Try
            Me.SqlConnection1.Open()
            CTArt19.CommandType = CommandType.Text
            CTArt19.CommandText = ("Select * from Patrimonio where Patrimonio.Folio =  '" & CB_Folio.Text & "'" & "and Act='" & 19 & "'")
            CTArt19.Connection = Me.SqlConnection1
            DAARTICULO19 = CTArt19.ExecuteReader()
            If DAARTICULO19.Read() = True Then
                TB_CI_19.Text = DAARTICULO19("No_Activo")
                TB_CAT19.Text = DAARTICULO19("Cve_Categoria")
                TB_Cve_A19.Text = DAARTICULO19("Cve_SubCategoria")
                TB_Art19.Text = DAARTICULO19("Descripcion")
                TB_Marca19.Text = DAARTICULO19("Marca")
                TB_Modelo19.Text = DAARTICULO19("Modelo")
                TB_Serie19.Text = DAARTICULO19("Serie")
                TB_NoFactura19.Text = DAARTICULO19("No_Factura")
                DateTimePicker_Factura19.Text = DAARTICULO19("Fecha_Factura")
                NUpDown_CanArt19.Text = DAARTICULO19("Cantidad_Articulos")
                TB_CostoUnit19.Text = DAARTICULO19("Costo_Unitario")
                TB_CostoTotal19.Text = DAARTICULO19("Costo_Total")
            Else
                ChB_Status19.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        DAARTICULO19.Close()
        Me.SqlConnection1.Close()
    End Sub
    Sub cargar_Art20()
        Try
            Me.SqlConnection1.Open()
            CTArt20.CommandType = CommandType.Text
            CTArt20.CommandText = ("Select * from Patrimonio where Patrimonio.Folio =  '" & CB_Folio.Text & "'" & "and Act='" & 20 & "'")
            CTArt20.Connection = Me.SqlConnection1
            DAARTICULO20 = CTArt20.ExecuteReader()
            If DAARTICULO20.Read() = True Then
                TB_CI_20.Text = DAARTICULO20("No_Activo")
                TB_CAT20.Text = DAARTICULO20("Cve_Categoria")
                TB_Cve_A20.Text = DAARTICULO20("Cve_SubCategoria")
                TB_Art20.Text = DAARTICULO20("Descripcion")
                TB_Marca20.Text = DAARTICULO20("Marca")
                TB_Modelo20.Text = DAARTICULO20("Modelo")
                TB_Serie20.Text = DAARTICULO20("Serie")
                TB_NoFactura20.Text = DAARTICULO20("No_Factura")
                DateTimePicker_Factura20.Text = DAARTICULO20("Fecha_Factura")
                NUpDown_CanArt20.Text = DAARTICULO20("Cantidad_Articulos")
                TB_CostoUnit20.Text = DAARTICULO20("Costo_Unitario")
                TB_CostoTotal20.Text = DAARTICULO20("Costo_Total")
            Else
                ChB_Status20.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        DAARTICULO20.Close()
        Me.SqlConnection1.Close()
    End Sub

    Private Sub Btn_Mostrar_Click(sender As Object, e As EventArgs) Handles Btn_Mostrar.Click
        Call limpiar_formulario()
        Call buscar_folio()
        Call cargar_Art1()
        Call cargar_Art2()
        Call cargar_Art3()
        Call cargar_Art4()
        Call cargar_Art5()
        Call cargar_Art6()
        Call cargar_Art7()
        Call cargar_Art8()
        Call cargar_Art9()
        Call cargar_Art10()
        Call cargar_Art11()
        Call cargar_Art12()
        Call cargar_Art13()
        Call cargar_Art14()
        Call cargar_Art15()
        Call cargar_Art16()
        Call cargar_Art17()
        Call cargar_Art18()
        Call cargar_Art19()
        Call cargar_Art20()

    End Sub
    Sub Transferencia1()
        Try
            Me.SqlConnection1.Open()
            Dim Insar1 As String = "INSERT INTO Transferencia (Folio_Entrega,Folio_Recibe,Solicitud_Entrega,Solicitud_Transferencia,Fecha_Registro_Transferencia,Depto_Entrega,Depto_Recibe,Responsable_Entrega,Responsable_Recibe,No_Activo,Cve_Categoria,Cve_SubCategoria,Nombre_Articulo,Marca,Modelo,Serie,No_Factura,Fecha_Factura,Cantidad_Articulos,Costo_Unitario,Costo_Total,Act_Transferencia) values(@Folio_Entrega,@Folio_Recibe,@Solicitud_Entrega,@Solicitud_Transferencia,@Fecha_Registro_Transferencia,@Depto_Entrega,@Depto_Recibe,@Responsable_Entrega,@Responsable_Recibe,@No_Activo,@Cve_Categoria,@Cve_SubCategoria,@Nombre_Articulo,@Marca,@Modelo,@Serie,@No_Factura,@Fecha_Factura,@Cantidad_Articulos,@Costo_Unitario,@Costo_Total,@Act_Transferencia)"
            Dim conex1 As New SqlClient.SqlCommand(Insar1, Me.SqlConnection1)
            conex1.Parameters.Add(New SqlParameter("@Folio_Entrega", SqlDbType.Int, 4)).Value = Me.CB_Folio.Text
            conex1.Parameters.Add(New SqlParameter("@Folio_Recibe", SqlDbType.Int, 4)).Value = Me.TB_Folio_Transferencia.Text
            conex1.Parameters.Add(New SqlParameter("@Solicitud_Entrega", SqlDbType.NChar, 10)).Value = TB_Solicitud_Entrega.Text
            conex1.Parameters.Add(New SqlParameter("@Solicitud_Transferencia", SqlDbType.NChar, 10)).Value = TB_Solicitud_Transferencia.Text
            conex1.Parameters.Add(New SqlParameter("@Fecha_Registro_Transferencia", SqlDbType.SmallDateTime)).Value = DateTimePicker_Registro.Text
            conex1.Parameters.Add(New SqlParameter("@Depto_Entrega", SqlDbType.NVarChar, 50)).Value = Me.CB_Departamento.Text
            conex1.Parameters.Add(New SqlParameter("@Depto_Recibe", SqlDbType.NVarChar, 50)).Value = Me.CB_Depto_Transferencia.Text
            conex1.Parameters.Add(New SqlParameter("@Responsable_Entrega", SqlDbType.NVarChar, 50)).Value = Me.CB_Responsable_Entrega.Text
            conex1.Parameters.Add(New SqlParameter("@Responsable_Recibe", SqlDbType.NVarChar, 50)).Value = Me.CB_Responsable_Recibe.Text
            conex1.Parameters.Add(New SqlParameter("@No_Activo", SqlDbType.Int, 4)).Value = Me.TB_CI_1.Text
            conex1.Parameters.Add(New SqlParameter("@Cve_Categoria", SqlDbType.NChar, 10)).Value = Me.TB_CAT1.Text
            conex1.Parameters.Add(New SqlParameter("@Cve_SubCategoria", SqlDbType.NChar, 10)).Value = Me.TB_Cve_A1.Text
            conex1.Parameters.Add(New SqlParameter("@Nombre_Articulo", SqlDbType.NVarChar, 50)).Value = Me.TB_Art1.Text
            conex1.Parameters.Add(New SqlParameter("@Marca", SqlDbType.NChar, 10)).Value = Me.TB_Marca1.Text
            conex1.Parameters.Add(New SqlParameter("@Modelo", SqlDbType.NVarChar, 50)).Value = Me.TB_Modelo1.Text
            conex1.Parameters.Add(New SqlParameter("@Serie", SqlDbType.NChar, 20)).Value = Me.TB_Serie1.Text
            conex1.Parameters.Add(New SqlParameter("@No_Factura", SqlDbType.NChar, 20)).Value = TB_NoFactura1.Text
            conex1.Parameters.Add(New SqlParameter("@Fecha_Factura", SqlDbType.SmallDateTime)).Value = DateTimePicker_Factura1.Text
            conex1.Parameters.Add(New SqlParameter("@Cantidad_Articulos", SqlDbType.Int)).Value = Val(NUpDown_CanArt1.Text)
            conex1.Parameters.Add(New SqlParameter("@Costo_Unitario", SqlDbType.Int)).Value = Val(TB_CostoUnit1.Text)
            conex1.Parameters.Add(New SqlParameter("@Costo_Total", SqlDbType.Int)).Value = Val(TB_CostoTotal1.Text)
            conex1.Parameters.Add(New SqlParameter("@Act_Transferencia", SqlDbType.NChar, 2)).Value = "1"
            conex1.CommandText = Insar1
            conex1.ExecuteNonQuery()
            Me.SqlConnection1.Close()
        Catch es As Exception
            MsgBox(es.ToString)
        End Try
    End Sub
    Sub Transferencia2()
        Try
            Me.SqlConnection1.Open()
            Dim Insar2 As String = "INSERT INTO Transferencia (Folio_Entrega,Folio_Recibe,Solicitud_Entrega,Solicitud_Transferencia,Fecha_Registro_Transferencia,Depto_Entrega,Depto_Recibe,Responsable_Entrega,Responsable_Recibe,No_Activo,Cve_Categoria,Cve_SubCategoria,Nombre_Articulo,Marca,Modelo,Serie,No_Factura,Fecha_Factura,Cantidad_Articulos,Costo_Unitario,Costo_Total,Act_Transferencia) values(@Folio_Entrega,@Folio_Recibe,@Solicitud_Entrega,@Solicitud_Transferencia,@Fecha_Registro_Transferencia,@Depto_Entrega,@Depto_Recibe,@Responsable_Entrega,@Responsable_Recibe,@No_Activo,@Cve_Categoria,@Cve_SubCategoria,@Nombre_Articulo,@Marca,@Modelo,@Serie,@No_Factura,@Fecha_Factura,@Cantidad_Articulos,@Costo_Unitario,@Costo_Total,@Act_Transferencia)"
            Dim conex1 As New SqlClient.SqlCommand(Insar2, Me.SqlConnection1)
            conex1.Parameters.Add(New SqlParameter("@Folio_Entrega", SqlDbType.Int, 4)).Value = Me.CB_Folio.Text
            conex1.Parameters.Add(New SqlParameter("@Folio_Recibe", SqlDbType.Int, 4)).Value = Me.TB_Folio_Transferencia.Text
            conex1.Parameters.Add(New SqlParameter("@Solicitud_Entrega", SqlDbType.NChar, 10)).Value = TB_Solicitud_Entrega.Text
            conex1.Parameters.Add(New SqlParameter("@Solicitud_Transferencia", SqlDbType.NChar, 10)).Value = TB_Solicitud_Transferencia.Text
            conex1.Parameters.Add(New SqlParameter("@Fecha_Registro_Transferencia", SqlDbType.SmallDateTime)).Value = DateTimePicker_Registro.Text
            conex1.Parameters.Add(New SqlParameter("@Depto_Entrega", SqlDbType.NVarChar, 50)).Value = Me.CB_Departamento.Text
            conex1.Parameters.Add(New SqlParameter("@Depto_Recibe", SqlDbType.NVarChar, 50)).Value = Me.CB_Depto_Transferencia.Text
            conex1.Parameters.Add(New SqlParameter("@Responsable_Entrega", SqlDbType.NVarChar, 50)).Value = Me.CB_Responsable_Entrega.Text
            conex1.Parameters.Add(New SqlParameter("@Responsable_Recibe", SqlDbType.NVarChar, 50)).Value = Me.CB_Responsable_Recibe.Text
            conex1.Parameters.Add(New SqlParameter("@No_Activo", SqlDbType.Int, 4)).Value = Me.TB_CI_2.Text
            conex1.Parameters.Add(New SqlParameter("@Cve_Categoria", SqlDbType.NChar, 10)).Value = Me.TB_CAT2.Text
            conex1.Parameters.Add(New SqlParameter("@Cve_SubCategoria", SqlDbType.NChar, 10)).Value = Me.TB_Cve_A2.Text
            conex1.Parameters.Add(New SqlParameter("@Nombre_Articulo", SqlDbType.NVarChar, 50)).Value = Me.TB_Art2.Text
            conex1.Parameters.Add(New SqlParameter("@Marca", SqlDbType.NChar, 10)).Value = Me.TB_Marca2.Text
            conex1.Parameters.Add(New SqlParameter("@Modelo", SqlDbType.NVarChar, 50)).Value = Me.TB_Modelo2.Text
            conex1.Parameters.Add(New SqlParameter("@Serie", SqlDbType.NChar, 20)).Value = Me.TB_Serie2.Text
            conex1.Parameters.Add(New SqlParameter("@No_Factura", SqlDbType.NChar, 20)).Value = TB_NoFactura2.Text
            conex1.Parameters.Add(New SqlParameter("@Fecha_Factura", SqlDbType.SmallDateTime)).Value = DateTimePicker_Factura2.Text
            conex1.Parameters.Add(New SqlParameter("@Cantidad_Articulos", SqlDbType.Int)).Value = Val(NUpDown_CanArt2.Text)
            conex1.Parameters.Add(New SqlParameter("@Costo_Unitario", SqlDbType.Int)).Value = Val(TB_CostoUnit2.Text)
            conex1.Parameters.Add(New SqlParameter("@Costo_Total", SqlDbType.Int)).Value = Val(TB_CostoTotal2.Text)
            conex1.Parameters.Add(New SqlParameter("@Act_Transferencia", SqlDbType.NChar, 2)).Value = "2"
            conex1.CommandText = Insar2
            conex1.ExecuteNonQuery()
            Me.SqlConnection1.Close()
        Catch es As Exception
            MsgBox(es.ToString)
        End Try
    End Sub
    Sub Transferencia3()
        Try
            Me.SqlConnection1.Open()
            Dim Insar3 As String = "INSERT INTO Transferencia (Folio_Entrega,Folio_Recibe,Solicitud_Entrega,Solicitud_Transferencia,Fecha_Registro_Transferencia,Depto_Entrega,Depto_Recibe,Responsable_Entrega,Responsable_Recibe,No_Activo,Cve_Categoria,Cve_SubCategoria,Nombre_Articulo,Marca,Modelo,Serie,No_Factura,Fecha_Factura,Cantidad_Articulos,Costo_Unitario,Costo_Total,Act_Transferencia) values(@Folio_Entrega,@Folio_Recibe,@Solicitud_Entrega,@Solicitud_Transferencia,@Fecha_Registro_Transferencia,@Depto_Entrega,@Depto_Recibe,@Responsable_Entrega,@Responsable_Recibe,@No_Activo,@Cve_Categoria,@Cve_SubCategoria,@Nombre_Articulo,@Marca,@Modelo,@Serie,@No_Factura,@Fecha_Factura,@Cantidad_Articulos,@Costo_Unitario,@Costo_Total,@Act_Transferencia)"
            Dim conex1 As New SqlClient.SqlCommand(Insar3, Me.SqlConnection1)
            conex1.Parameters.Add(New SqlParameter("@Folio_Entrega", SqlDbType.Int, 4)).Value = Me.CB_Folio.Text
            conex1.Parameters.Add(New SqlParameter("@Folio_Recibe", SqlDbType.Int, 4)).Value = Me.TB_Folio_Transferencia.Text
            conex1.Parameters.Add(New SqlParameter("@Solicitud_Entrega", SqlDbType.NChar, 10)).Value = TB_Solicitud_Entrega.Text
            conex1.Parameters.Add(New SqlParameter("@Solicitud_Transferencia", SqlDbType.NChar, 10)).Value = TB_Solicitud_Transferencia.Text
            conex1.Parameters.Add(New SqlParameter("@Fecha_Registro_Transferencia", SqlDbType.SmallDateTime)).Value = DateTimePicker_Registro.Text
            conex1.Parameters.Add(New SqlParameter("@Depto_Entrega", SqlDbType.NVarChar, 50)).Value = Me.CB_Departamento.Text
            conex1.Parameters.Add(New SqlParameter("@Depto_Recibe", SqlDbType.NVarChar, 50)).Value = Me.CB_Depto_Transferencia.Text
            conex1.Parameters.Add(New SqlParameter("@Responsable_Entrega", SqlDbType.NVarChar, 50)).Value = Me.CB_Responsable_Entrega.Text
            conex1.Parameters.Add(New SqlParameter("@Responsable_Recibe", SqlDbType.NVarChar, 50)).Value = Me.CB_Responsable_Recibe.Text
            conex1.Parameters.Add(New SqlParameter("@No_Activo", SqlDbType.Int, 4)).Value = Me.TB_CI_3.Text
            conex1.Parameters.Add(New SqlParameter("@Cve_Categoria", SqlDbType.NChar, 10)).Value = Me.TB_CAT3.Text
            conex1.Parameters.Add(New SqlParameter("@Cve_SubCategoria", SqlDbType.NChar, 10)).Value = Me.TB_Cve_A3.Text
            conex1.Parameters.Add(New SqlParameter("@Nombre_Articulo", SqlDbType.NVarChar, 50)).Value = Me.TB_Art3.Text
            conex1.Parameters.Add(New SqlParameter("@Marca", SqlDbType.NChar, 10)).Value = Me.TB_Marca3.Text
            conex1.Parameters.Add(New SqlParameter("@Modelo", SqlDbType.NVarChar, 50)).Value = Me.TB_Modelo3.Text
            conex1.Parameters.Add(New SqlParameter("@Serie", SqlDbType.NChar, 20)).Value = Me.TB_Serie3.Text
            conex1.Parameters.Add(New SqlParameter("@No_Factura", SqlDbType.NChar, 20)).Value = TB_NoFactura3.Text
            conex1.Parameters.Add(New SqlParameter("@Fecha_Factura", SqlDbType.SmallDateTime)).Value = DateTimePicker_Factura3.Text
            conex1.Parameters.Add(New SqlParameter("@Cantidad_Articulos", SqlDbType.Int)).Value = Val(NUpDown_CanArt3.Text)
            conex1.Parameters.Add(New SqlParameter("@Costo_Unitario", SqlDbType.Int)).Value = Val(TB_CostoUnit3.Text)
            conex1.Parameters.Add(New SqlParameter("@Costo_Total", SqlDbType.Int)).Value = Val(TB_CostoTotal3.Text)
            conex1.Parameters.Add(New SqlParameter("@Act_Transferencia", SqlDbType.NChar, 2)).Value = "3"
            conex1.CommandText = Insar3
            conex1.ExecuteNonQuery()
            Me.SqlConnection1.Close()
        Catch es As Exception
            MsgBox(es.ToString)
        End Try
    End Sub
    Sub Transferencia4()
        Try
            Me.SqlConnection1.Open()
            Dim Insar4 As String = "INSERT INTO Transferencia (Folio_Entrega,Folio_Recibe,Solicitud_Entrega,Solicitud_Transferencia,Fecha_Registro_Transferencia,Depto_Entrega,Depto_Recibe,Responsable_Entrega,Responsable_Recibe,No_Activo,Cve_Categoria,Cve_SubCategoria,Nombre_Articulo,Marca,Modelo,Serie,No_Factura,Fecha_Factura,Cantidad_Articulos,Costo_Unitario,Costo_Total,Act_Transferencia) values(@Folio_Entrega,@Folio_Recibe,@Solicitud_Entrega,@Solicitud_Transferencia,@Fecha_Registro_Transferencia,@Depto_Entrega,@Depto_Recibe,@Responsable_Entrega,@Responsable_Recibe,@No_Activo,@Cve_Categoria,@Cve_SubCategoria,@Nombre_Articulo,@Marca,@Modelo,@Serie,@No_Factura,@Fecha_Factura,@Cantidad_Articulos,@Costo_Unitario,@Costo_Total,@Act_Transferencia)"
            Dim conex1 As New SqlClient.SqlCommand(Insar4, Me.SqlConnection1)
            conex1.Parameters.Add(New SqlParameter("@Folio_Entrega", SqlDbType.Int, 4)).Value = Me.CB_Folio.Text
            conex1.Parameters.Add(New SqlParameter("@Folio_Recibe", SqlDbType.Int, 4)).Value = Me.TB_Folio_Transferencia.Text
            conex1.Parameters.Add(New SqlParameter("@Solicitud_Entrega", SqlDbType.NChar, 10)).Value = TB_Solicitud_Entrega.Text
            conex1.Parameters.Add(New SqlParameter("@Solicitud_Transferencia", SqlDbType.NChar, 10)).Value = TB_Solicitud_Transferencia.Text
            conex1.Parameters.Add(New SqlParameter("@Fecha_Registro_Transferencia", SqlDbType.SmallDateTime)).Value = DateTimePicker_Registro.Text
            conex1.Parameters.Add(New SqlParameter("@Depto_Entrega", SqlDbType.NVarChar, 50)).Value = Me.CB_Departamento.Text
            conex1.Parameters.Add(New SqlParameter("@Depto_Recibe", SqlDbType.NVarChar, 50)).Value = Me.CB_Depto_Transferencia.Text
            conex1.Parameters.Add(New SqlParameter("@Responsable_Entrega", SqlDbType.NVarChar, 50)).Value = Me.CB_Responsable_Entrega.Text
            conex1.Parameters.Add(New SqlParameter("@Responsable_Recibe", SqlDbType.NVarChar, 50)).Value = Me.CB_Responsable_Recibe.Text
            conex1.Parameters.Add(New SqlParameter("@No_Activo", SqlDbType.Int, 4)).Value = Me.TB_CI_4.Text
            conex1.Parameters.Add(New SqlParameter("@Cve_Categoria", SqlDbType.NChar, 10)).Value = Me.TB_CAT4.Text
            conex1.Parameters.Add(New SqlParameter("@Cve_SubCategoria", SqlDbType.NChar, 10)).Value = Me.TB_Cve_A4.Text
            conex1.Parameters.Add(New SqlParameter("@Nombre_Articulo", SqlDbType.NVarChar, 50)).Value = Me.TB_Art4.Text
            conex1.Parameters.Add(New SqlParameter("@Marca", SqlDbType.NChar, 10)).Value = Me.TB_Marca4.Text
            conex1.Parameters.Add(New SqlParameter("@Modelo", SqlDbType.NVarChar, 50)).Value = Me.TB_Modelo4.Text
            conex1.Parameters.Add(New SqlParameter("@Serie", SqlDbType.NChar, 20)).Value = Me.TB_Serie4.Text
            conex1.Parameters.Add(New SqlParameter("@No_Factura", SqlDbType.NChar, 20)).Value = TB_NoFactura4.Text
            conex1.Parameters.Add(New SqlParameter("@Fecha_Factura", SqlDbType.SmallDateTime)).Value = DateTimePicker_Factura4.Text
            conex1.Parameters.Add(New SqlParameter("@Cantidad_Articulos", SqlDbType.Int)).Value = Val(NUpDown_CanArt4.Text)
            conex1.Parameters.Add(New SqlParameter("@Costo_Unitario", SqlDbType.Int)).Value = Val(TB_CostoUnit4.Text)
            conex1.Parameters.Add(New SqlParameter("@Costo_Total", SqlDbType.Int)).Value = Val(TB_CostoTotal4.Text)
            conex1.Parameters.Add(New SqlParameter("@Act_Transferencia", SqlDbType.NChar, 2)).Value = "4"
            conex1.CommandText = Insar4
            conex1.ExecuteNonQuery()
            Me.SqlConnection1.Close()
        Catch es As Exception
            MsgBox(es.ToString)
        End Try
    End Sub
    Sub Transferencia5()
        Try
            Me.SqlConnection1.Open()
            Dim Insar5 As String = "INSERT INTO Transferencia (Folio_Entrega,Folio_Recibe,Solicitud_Entrega,Solicitud_Transferencia,Fecha_Registro_Transferencia,Depto_Entrega,Depto_Recibe,Responsable_Entrega,Responsable_Recibe,No_Activo,Cve_Categoria,Cve_SubCategoria,Nombre_Articulo,Marca,Modelo,Serie,No_Factura,Fecha_Factura,Cantidad_Articulos,Costo_Unitario,Costo_Total,Act_Transferencia) values(@Folio_Entrega,@Folio_Recibe,@Solicitud_Entrega,@Solicitud_Transferencia,@Fecha_Registro_Transferencia,@Depto_Entrega,@Depto_Recibe,@Responsable_Entrega,@Responsable_Recibe,@No_Activo,@Cve_Categoria,@Cve_SubCategoria,@Nombre_Articulo,@Marca,@Modelo,@Serie,@No_Factura,@Fecha_Factura,@Cantidad_Articulos,@Costo_Unitario,@Costo_Total,@Act_Transferencia)"
            Dim conex1 As New SqlClient.SqlCommand(Insar5, Me.SqlConnection1)
            conex1.Parameters.Add(New SqlParameter("@Folio_Entrega", SqlDbType.Int, 4)).Value = Me.CB_Folio.Text
            conex1.Parameters.Add(New SqlParameter("@Folio_Recibe", SqlDbType.Int, 4)).Value = Me.TB_Folio_Transferencia.Text
            conex1.Parameters.Add(New SqlParameter("@Solicitud_Entrega", SqlDbType.NChar, 10)).Value = TB_Solicitud_Entrega.Text
            conex1.Parameters.Add(New SqlParameter("@Solicitud_Transferencia", SqlDbType.NChar, 10)).Value = TB_Solicitud_Transferencia.Text
            conex1.Parameters.Add(New SqlParameter("@Fecha_Registro_Transferencia", SqlDbType.SmallDateTime)).Value = DateTimePicker_Registro.Text
            conex1.Parameters.Add(New SqlParameter("@Depto_Entrega", SqlDbType.NVarChar, 50)).Value = Me.CB_Departamento.Text
            conex1.Parameters.Add(New SqlParameter("@Depto_Recibe", SqlDbType.NVarChar, 50)).Value = Me.CB_Depto_Transferencia.Text
            conex1.Parameters.Add(New SqlParameter("@Responsable_Entrega", SqlDbType.NVarChar, 50)).Value = Me.CB_Responsable_Entrega.Text
            conex1.Parameters.Add(New SqlParameter("@Responsable_Recibe", SqlDbType.NVarChar, 50)).Value = Me.CB_Responsable_Recibe.Text
            conex1.Parameters.Add(New SqlParameter("@No_Activo", SqlDbType.Int, 4)).Value = Me.TB_CI_5.Text
            conex1.Parameters.Add(New SqlParameter("@Cve_Categoria", SqlDbType.NChar, 10)).Value = Me.TB_CAT5.Text
            conex1.Parameters.Add(New SqlParameter("@Cve_SubCategoria", SqlDbType.NChar, 10)).Value = Me.TB_Cve_A5.Text
            conex1.Parameters.Add(New SqlParameter("@Nombre_Articulo", SqlDbType.NVarChar, 50)).Value = Me.TB_Art5.Text
            conex1.Parameters.Add(New SqlParameter("@Marca", SqlDbType.NChar, 10)).Value = Me.TB_Marca5.Text
            conex1.Parameters.Add(New SqlParameter("@Modelo", SqlDbType.NVarChar, 50)).Value = Me.TB_Modelo5.Text
            conex1.Parameters.Add(New SqlParameter("@Serie", SqlDbType.NChar, 20)).Value = Me.TB_Serie5.Text
            conex1.Parameters.Add(New SqlParameter("@No_Factura", SqlDbType.NChar, 20)).Value = TB_NoFactura5.Text
            conex1.Parameters.Add(New SqlParameter("@Fecha_Factura", SqlDbType.SmallDateTime)).Value = DateTimePicker_Factura5.Text
            conex1.Parameters.Add(New SqlParameter("@Cantidad_Articulos", SqlDbType.Int)).Value = Val(NUpDown_CanArt5.Text)
            conex1.Parameters.Add(New SqlParameter("@Costo_Unitario", SqlDbType.Int)).Value = Val(TB_CostoUnit5.Text)
            conex1.Parameters.Add(New SqlParameter("@Costo_Total", SqlDbType.Int)).Value = Val(TB_CostoTotal5.Text)
            conex1.Parameters.Add(New SqlParameter("@Act_Transferencia", SqlDbType.NChar, 2)).Value = "5"
            conex1.CommandText = Insar5
            conex1.ExecuteNonQuery()
            Me.SqlConnection1.Close()
        Catch es As Exception
            MsgBox(es.ToString)
        End Try
    End Sub
    Sub Transferencia6()
        Try
            Me.SqlConnection1.Open()
            Dim Insar6 As String = "INSERT INTO Transferencia (Folio_Entrega,Folio_Recibe,Solicitud_Entrega,Solicitud_Transferencia,Fecha_Registro_Transferencia,Depto_Entrega,Depto_Recibe,Responsable_Entrega,Responsable_Recibe,No_Activo,Cve_Categoria,Cve_SubCategoria,Nombre_Articulo,Marca,Modelo,Serie,No_Factura,Fecha_Factura,Cantidad_Articulos,Costo_Unitario,Costo_Total,Act_Transferencia) values(@Folio_Entrega,@Folio_Recibe,@Solicitud_Entrega,@Solicitud_Transferencia,@Fecha_Registro_Transferencia,@Depto_Entrega,@Depto_Recibe,@Responsable_Entrega,@Responsable_Recibe,@No_Activo,@Cve_Categoria,@Cve_SubCategoria,@Nombre_Articulo,@Marca,@Modelo,@Serie,@No_Factura,@Fecha_Factura,@Cantidad_Articulos,@Costo_Unitario,@Costo_Total,@Act_Transferencia)"
            Dim conex1 As New SqlClient.SqlCommand(Insar6, Me.SqlConnection1)
            conex1.Parameters.Add(New SqlParameter("@Folio_Entrega", SqlDbType.Int, 4)).Value = Me.CB_Folio.Text
            conex1.Parameters.Add(New SqlParameter("@Folio_Recibe", SqlDbType.Int, 4)).Value = Me.TB_Folio_Transferencia.Text
            conex1.Parameters.Add(New SqlParameter("@Solicitud_Entrega", SqlDbType.NChar, 10)).Value = TB_Solicitud_Entrega.Text
            conex1.Parameters.Add(New SqlParameter("@Solicitud_Transferencia", SqlDbType.NChar, 10)).Value = TB_Solicitud_Transferencia.Text
            conex1.Parameters.Add(New SqlParameter("@Fecha_Registro_Transferencia", SqlDbType.SmallDateTime)).Value = DateTimePicker_Registro.Text
            conex1.Parameters.Add(New SqlParameter("@Depto_Entrega", SqlDbType.NVarChar, 50)).Value = Me.CB_Departamento.Text
            conex1.Parameters.Add(New SqlParameter("@Depto_Recibe", SqlDbType.NVarChar, 50)).Value = Me.CB_Depto_Transferencia.Text
            conex1.Parameters.Add(New SqlParameter("@Responsable_Entrega", SqlDbType.NVarChar, 50)).Value = Me.CB_Responsable_Entrega.Text
            conex1.Parameters.Add(New SqlParameter("@Responsable_Recibe", SqlDbType.NVarChar, 50)).Value = Me.CB_Responsable_Recibe.Text
            conex1.Parameters.Add(New SqlParameter("@No_Activo", SqlDbType.Int, 4)).Value = Me.TB_CI_6.Text
            conex1.Parameters.Add(New SqlParameter("@Cve_Categoria", SqlDbType.NChar, 10)).Value = Me.TB_CAT6.Text
            conex1.Parameters.Add(New SqlParameter("@Cve_SubCategoria", SqlDbType.NChar, 10)).Value = Me.TB_Cve_A6.Text
            conex1.Parameters.Add(New SqlParameter("@Nombre_Articulo", SqlDbType.NVarChar, 50)).Value = Me.TB_Art6.Text
            conex1.Parameters.Add(New SqlParameter("@Marca", SqlDbType.NChar, 10)).Value = Me.TB_Marca6.Text
            conex1.Parameters.Add(New SqlParameter("@Modelo", SqlDbType.NVarChar, 50)).Value = Me.TB_Modelo6.Text
            conex1.Parameters.Add(New SqlParameter("@Serie", SqlDbType.NChar, 20)).Value = Me.TB_Serie6.Text
            conex1.Parameters.Add(New SqlParameter("@No_Factura", SqlDbType.NChar, 20)).Value = TB_NoFactura6.Text
            conex1.Parameters.Add(New SqlParameter("@Fecha_Factura", SqlDbType.SmallDateTime)).Value = DateTimePicker_Factura6.Text
            conex1.Parameters.Add(New SqlParameter("@Cantidad_Articulos", SqlDbType.Int)).Value = Val(NUpDown_CanArt6.Text)
            conex1.Parameters.Add(New SqlParameter("@Costo_Unitario", SqlDbType.Int)).Value = Val(TB_CostoUnit6.Text)
            conex1.Parameters.Add(New SqlParameter("@Costo_Total", SqlDbType.Int)).Value = Val(TB_CostoTotal6.Text)
            conex1.Parameters.Add(New SqlParameter("@Act_Transferencia", SqlDbType.NChar, 2)).Value = "6"
            conex1.CommandText = Insar6
            conex1.ExecuteNonQuery()
            Me.SqlConnection1.Close()
        Catch es As Exception
            MsgBox(es.ToString)
        End Try
    End Sub
    Sub Transferencia7()
        Try
            Me.SqlConnection1.Open()
            Dim Insar7 As String = "INSERT INTO Transferencia (Folio_Entrega,Folio_Recibe,Solicitud_Entrega,Solicitud_Transferencia,Fecha_Registro_Transferencia,Depto_Entrega,Depto_Recibe,Responsable_Entrega,Responsable_Recibe,No_Activo,Cve_Categoria,Cve_SubCategoria,Nombre_Articulo,Marca,Modelo,Serie,No_Factura,Fecha_Factura,Cantidad_Articulos,Costo_Unitario,Costo_Total,Act_Transferencia) values(@Folio_Entrega,@Folio_Recibe,@Solicitud_Entrega,@Solicitud_Transferencia,@Fecha_Registro_Transferencia,@Depto_Entrega,@Depto_Recibe,@Responsable_Entrega,@Responsable_Recibe,@No_Activo,@Cve_Categoria,@Cve_SubCategoria,@Nombre_Articulo,@Marca,@Modelo,@Serie,@No_Factura,@Fecha_Factura,@Cantidad_Articulos,@Costo_Unitario,@Costo_Total,@Act_Transferencia)"
            Dim conex1 As New SqlClient.SqlCommand(Insar7, Me.SqlConnection1)
            conex1.Parameters.Add(New SqlParameter("@Folio_Entrega", SqlDbType.Int, 4)).Value = Me.CB_Folio.Text
            conex1.Parameters.Add(New SqlParameter("@Folio_Recibe", SqlDbType.Int, 4)).Value = Me.TB_Folio_Transferencia.Text
            conex1.Parameters.Add(New SqlParameter("@Solicitud_Entrega", SqlDbType.NChar, 10)).Value = TB_Solicitud_Entrega.Text
            conex1.Parameters.Add(New SqlParameter("@Solicitud_Transferencia", SqlDbType.NChar, 10)).Value = TB_Solicitud_Transferencia.Text
            conex1.Parameters.Add(New SqlParameter("@Fecha_Registro_Transferencia", SqlDbType.SmallDateTime)).Value = DateTimePicker_Registro.Text
            conex1.Parameters.Add(New SqlParameter("@Depto_Entrega", SqlDbType.NVarChar, 50)).Value = Me.CB_Departamento.Text
            conex1.Parameters.Add(New SqlParameter("@Depto_Recibe", SqlDbType.NVarChar, 50)).Value = Me.CB_Depto_Transferencia.Text
            conex1.Parameters.Add(New SqlParameter("@Responsable_Entrega", SqlDbType.NVarChar, 50)).Value = Me.CB_Responsable_Entrega.Text
            conex1.Parameters.Add(New SqlParameter("@Responsable_Recibe", SqlDbType.NVarChar, 50)).Value = Me.CB_Responsable_Recibe.Text
            conex1.Parameters.Add(New SqlParameter("@No_Activo", SqlDbType.Int, 4)).Value = Me.TB_CI_7.Text
            conex1.Parameters.Add(New SqlParameter("@Cve_Categoria", SqlDbType.NChar, 10)).Value = Me.TB_CAT7.Text
            conex1.Parameters.Add(New SqlParameter("@Cve_SubCategoria", SqlDbType.NChar, 10)).Value = Me.TB_Cve_A7.Text
            conex1.Parameters.Add(New SqlParameter("@Nombre_Articulo", SqlDbType.NVarChar, 50)).Value = Me.TB_Art7.Text
            conex1.Parameters.Add(New SqlParameter("@Marca", SqlDbType.NChar, 10)).Value = Me.TB_Marca7.Text
            conex1.Parameters.Add(New SqlParameter("@Modelo", SqlDbType.NVarChar, 50)).Value = Me.TB_Modelo7.Text
            conex1.Parameters.Add(New SqlParameter("@Serie", SqlDbType.NChar, 20)).Value = Me.TB_Serie7.Text
            conex1.Parameters.Add(New SqlParameter("@No_Factura", SqlDbType.NChar, 20)).Value = TB_NoFactura7.Text
            conex1.Parameters.Add(New SqlParameter("@Fecha_Factura", SqlDbType.SmallDateTime)).Value = DateTimePicker_Factura7.Text
            conex1.Parameters.Add(New SqlParameter("@Cantidad_Articulos", SqlDbType.Int)).Value = Val(NUpDown_CanArt7.Text)
            conex1.Parameters.Add(New SqlParameter("@Costo_Unitario", SqlDbType.Int)).Value = Val(TB_CostoUnit7.Text)
            conex1.Parameters.Add(New SqlParameter("@Costo_Total", SqlDbType.Int)).Value = Val(TB_CostoTotal7.Text)
            conex1.Parameters.Add(New SqlParameter("@Act_Transferencia", SqlDbType.NChar, 2)).Value = "7"
            conex1.CommandText = Insar7
            conex1.ExecuteNonQuery()
            Me.SqlConnection1.Close()
        Catch es As Exception
            MsgBox(es.ToString)
        End Try
    End Sub
    Sub Transferencia8()
        Try
            Me.SqlConnection1.Open()
            Dim Insar8 As String = "INSERT INTO Transferencia (Folio_Entrega,Folio_Recibe,Solicitud_Entrega,Solicitud_Transferencia,Fecha_Registro_Transferencia,Depto_Entrega,Depto_Recibe,Responsable_Entrega,Responsable_Recibe,No_Activo,Cve_Categoria,Cve_SubCategoria,Nombre_Articulo,Marca,Modelo,Serie,No_Factura,Fecha_Factura,Cantidad_Articulos,Costo_Unitario,Costo_Total,Act_Transferencia) values(@Folio_Entrega,@Folio_Recibe,@Solicitud_Entrega,@Solicitud_Transferencia,@Fecha_Registro_Transferencia,@Depto_Entrega,@Depto_Recibe,@Responsable_Entrega,@Responsable_Recibe,@No_Activo,@Cve_Categoria,@Cve_SubCategoria,@Nombre_Articulo,@Marca,@Modelo,@Serie,@No_Factura,@Fecha_Factura,@Cantidad_Articulos,@Costo_Unitario,@Costo_Total,@Act_Transferencia)"
            Dim conex1 As New SqlClient.SqlCommand(Insar8, Me.SqlConnection1)
            conex1.Parameters.Add(New SqlParameter("@Folio_Entrega", SqlDbType.Int, 4)).Value = Me.CB_Folio.Text
            conex1.Parameters.Add(New SqlParameter("@Folio_Recibe", SqlDbType.Int, 4)).Value = Me.TB_Folio_Transferencia.Text
            conex1.Parameters.Add(New SqlParameter("@Solicitud_Entrega", SqlDbType.NChar, 10)).Value = TB_Solicitud_Entrega.Text
            conex1.Parameters.Add(New SqlParameter("@Solicitud_Transferencia", SqlDbType.NChar, 10)).Value = TB_Solicitud_Transferencia.Text
            conex1.Parameters.Add(New SqlParameter("@Fecha_Registro_Transferencia", SqlDbType.SmallDateTime)).Value = DateTimePicker_Registro.Text
            conex1.Parameters.Add(New SqlParameter("@Depto_Entrega", SqlDbType.NVarChar, 50)).Value = Me.CB_Departamento.Text
            conex1.Parameters.Add(New SqlParameter("@Depto_Recibe", SqlDbType.NVarChar, 50)).Value = Me.CB_Depto_Transferencia.Text
            conex1.Parameters.Add(New SqlParameter("@Responsable_Entrega", SqlDbType.NVarChar, 50)).Value = Me.CB_Responsable_Entrega.Text
            conex1.Parameters.Add(New SqlParameter("@Responsable_Recibe", SqlDbType.NVarChar, 50)).Value = Me.CB_Responsable_Recibe.Text
            conex1.Parameters.Add(New SqlParameter("@No_Activo", SqlDbType.Int, 4)).Value = Me.TB_CI_8.Text
            conex1.Parameters.Add(New SqlParameter("@Cve_Categoria", SqlDbType.NChar, 10)).Value = Me.TB_CAT8.Text
            conex1.Parameters.Add(New SqlParameter("@Cve_SubCategoria", SqlDbType.NChar, 10)).Value = Me.TB_Cve_A8.Text
            conex1.Parameters.Add(New SqlParameter("@Nombre_Articulo", SqlDbType.NVarChar, 50)).Value = Me.TB_Art8.Text
            conex1.Parameters.Add(New SqlParameter("@Marca", SqlDbType.NChar, 10)).Value = Me.TB_Marca8.Text
            conex1.Parameters.Add(New SqlParameter("@Modelo", SqlDbType.NVarChar, 50)).Value = Me.TB_Modelo8.Text
            conex1.Parameters.Add(New SqlParameter("@Serie", SqlDbType.NChar, 20)).Value = Me.TB_Serie8.Text
            conex1.Parameters.Add(New SqlParameter("@No_Factura", SqlDbType.NChar, 20)).Value = TB_NoFactura8.Text
            conex1.Parameters.Add(New SqlParameter("@Fecha_Factura", SqlDbType.SmallDateTime)).Value = DateTimePicker_Factura8.Text
            conex1.Parameters.Add(New SqlParameter("@Cantidad_Articulos", SqlDbType.Int)).Value = Val(NUpDown_CanArt8.Text)
            conex1.Parameters.Add(New SqlParameter("@Costo_Unitario", SqlDbType.Int)).Value = Val(TB_CostoUnit8.Text)
            conex1.Parameters.Add(New SqlParameter("@Costo_Total", SqlDbType.Int)).Value = Val(TB_CostoTotal8.Text)
            conex1.Parameters.Add(New SqlParameter("@Act_Transferencia", SqlDbType.NChar, 2)).Value = "8"
            conex1.CommandText = Insar8
            conex1.ExecuteNonQuery()
            Me.SqlConnection1.Close()
        Catch es As Exception
            MsgBox(es.ToString)
        End Try
    End Sub
    Sub Transferencia9()
        Try
            Me.SqlConnection1.Open()
            Dim Insar9 As String = "INSERT INTO Transferencia (Folio_Entrega,Folio_Recibe,Solicitud_Entrega,Solicitud_Transferencia,Fecha_Registro_Transferencia,Depto_Entrega,Depto_Recibe,Responsable_Entrega,Responsable_Recibe,No_Activo,Cve_Categoria,Cve_SubCategoria,Nombre_Articulo,Marca,Modelo,Serie,No_Factura,Fecha_Factura,Cantidad_Articulos,Costo_Unitario,Costo_Total,Act_Transferencia) values(@Folio_Entrega,@Folio_Recibe,@Solicitud_Entrega,@Solicitud_Transferencia,@Fecha_Registro_Transferencia,@Depto_Entrega,@Depto_Recibe,@Responsable_Entrega,@Responsable_Recibe,@No_Activo,@Cve_Categoria,@Cve_SubCategoria,@Nombre_Articulo,@Marca,@Modelo,@Serie,@No_Factura,@Fecha_Factura,@Cantidad_Articulos,@Costo_Unitario,@Costo_Total,@Act_Transferencia)"
            Dim conex1 As New SqlClient.SqlCommand(Insar9, Me.SqlConnection1)
            conex1.Parameters.Add(New SqlParameter("@Folio_Entrega", SqlDbType.Int, 4)).Value = Me.CB_Folio.Text
            conex1.Parameters.Add(New SqlParameter("@Folio_Recibe", SqlDbType.Int, 4)).Value = Me.TB_Folio_Transferencia.Text
            conex1.Parameters.Add(New SqlParameter("@Solicitud_Entrega", SqlDbType.NChar, 10)).Value = TB_Solicitud_Entrega.Text
            conex1.Parameters.Add(New SqlParameter("@Solicitud_Transferencia", SqlDbType.NChar, 10)).Value = TB_Solicitud_Transferencia.Text
            conex1.Parameters.Add(New SqlParameter("@Fecha_Registro_Transferencia", SqlDbType.SmallDateTime)).Value = DateTimePicker_Registro.Text
            conex1.Parameters.Add(New SqlParameter("@Depto_Entrega", SqlDbType.NVarChar, 50)).Value = Me.CB_Departamento.Text
            conex1.Parameters.Add(New SqlParameter("@Depto_Recibe", SqlDbType.NVarChar, 50)).Value = Me.CB_Depto_Transferencia.Text
            conex1.Parameters.Add(New SqlParameter("@Responsable_Entrega", SqlDbType.NVarChar, 50)).Value = Me.CB_Responsable_Entrega.Text
            conex1.Parameters.Add(New SqlParameter("@Responsable_Recibe", SqlDbType.NVarChar, 50)).Value = Me.CB_Responsable_Recibe.Text
            conex1.Parameters.Add(New SqlParameter("@No_Activo", SqlDbType.Int, 4)).Value = Me.TB_CI_9.Text
            conex1.Parameters.Add(New SqlParameter("@Cve_Categoria", SqlDbType.NChar, 10)).Value = Me.TB_CAT9.Text
            conex1.Parameters.Add(New SqlParameter("@Cve_SubCategoria", SqlDbType.NChar, 10)).Value = Me.TB_Cve_A9.Text
            conex1.Parameters.Add(New SqlParameter("@Nombre_Articulo", SqlDbType.NVarChar, 50)).Value = Me.TB_Art9.Text
            conex1.Parameters.Add(New SqlParameter("@Marca", SqlDbType.NChar, 10)).Value = Me.TB_Marca9.Text
            conex1.Parameters.Add(New SqlParameter("@Modelo", SqlDbType.NVarChar, 50)).Value = Me.TB_Modelo9.Text
            conex1.Parameters.Add(New SqlParameter("@Serie", SqlDbType.NChar, 20)).Value = Me.TB_Serie9.Text
            conex1.Parameters.Add(New SqlParameter("@No_Factura", SqlDbType.NChar, 20)).Value = TB_NoFactura9.Text
            conex1.Parameters.Add(New SqlParameter("@Fecha_Factura", SqlDbType.SmallDateTime)).Value = DateTimePicker_Factura9.Text
            conex1.Parameters.Add(New SqlParameter("@Cantidad_Articulos", SqlDbType.Int)).Value = Val(NUpDown_CanArt9.Text)
            conex1.Parameters.Add(New SqlParameter("@Costo_Unitario", SqlDbType.Int)).Value = Val(TB_CostoUnit9.Text)
            conex1.Parameters.Add(New SqlParameter("@Costo_Total", SqlDbType.Int)).Value = Val(TB_CostoTotal9.Text)
            conex1.Parameters.Add(New SqlParameter("@Act_Transferencia", SqlDbType.NChar, 2)).Value = "9"
            conex1.CommandText = Insar9
            conex1.ExecuteNonQuery()
            Me.SqlConnection1.Close()
        Catch es As Exception
            MsgBox(es.ToString)
        End Try
    End Sub
    Sub Transferencia10()
        Try
            Me.SqlConnection1.Open()
            Dim Insar10 As String = "INSERT INTO Transferencia (Folio_Entrega,Folio_Recibe,Solicitud_Entrega,Solicitud_Transferencia,Fecha_Registro_Transferencia,Depto_Entrega,Depto_Recibe,Responsable_Entrega,Responsable_Recibe,No_Activo,Cve_Categoria,Cve_SubCategoria,Nombre_Articulo,Marca,Modelo,Serie,No_Factura,Fecha_Factura,Cantidad_Articulos,Costo_Unitario,Costo_Total,Act_Transferencia) values(@Folio_Entrega,@Folio_Recibe,@Solicitud_Entrega,@Solicitud_Transferencia,@Fecha_Registro_Transferencia,@Depto_Entrega,@Depto_Recibe,@Responsable_Entrega,@Responsable_Recibe,@No_Activo,@Cve_Categoria,@Cve_SubCategoria,@Nombre_Articulo,@Marca,@Modelo,@Serie,@No_Factura,@Fecha_Factura,@Cantidad_Articulos,@Costo_Unitario,@Costo_Total,@Act_Transferencia)"
            Dim conex1 As New SqlClient.SqlCommand(Insar10, Me.SqlConnection1)
            conex1.Parameters.Add(New SqlParameter("@Folio_Entrega", SqlDbType.Int, 4)).Value = Me.CB_Folio.Text
            conex1.Parameters.Add(New SqlParameter("@Folio_Recibe", SqlDbType.Int, 4)).Value = Me.TB_Folio_Transferencia.Text
            conex1.Parameters.Add(New SqlParameter("@Solicitud_Entrega", SqlDbType.NChar, 10)).Value = TB_Solicitud_Entrega.Text
            conex1.Parameters.Add(New SqlParameter("@Solicitud_Transferencia", SqlDbType.NChar, 10)).Value = TB_Solicitud_Transferencia.Text
            conex1.Parameters.Add(New SqlParameter("@Fecha_Registro_Transferencia", SqlDbType.SmallDateTime)).Value = DateTimePicker_Registro.Text
            conex1.Parameters.Add(New SqlParameter("@Depto_Entrega", SqlDbType.NVarChar, 50)).Value = Me.CB_Departamento.Text
            conex1.Parameters.Add(New SqlParameter("@Depto_Recibe", SqlDbType.NVarChar, 50)).Value = Me.CB_Depto_Transferencia.Text
            conex1.Parameters.Add(New SqlParameter("@Responsable_Entrega", SqlDbType.NVarChar, 50)).Value = Me.CB_Responsable_Entrega.Text
            conex1.Parameters.Add(New SqlParameter("@Responsable_Recibe", SqlDbType.NVarChar, 50)).Value = Me.CB_Responsable_Recibe.Text
            conex1.Parameters.Add(New SqlParameter("@No_Activo", SqlDbType.Int, 4)).Value = Me.TB_CI_10.Text
            conex1.Parameters.Add(New SqlParameter("@Cve_Categoria", SqlDbType.NChar, 10)).Value = Me.TB_CAT10.Text
            conex1.Parameters.Add(New SqlParameter("@Cve_SubCategoria", SqlDbType.NChar, 10)).Value = Me.TB_Cve_A10.Text
            conex1.Parameters.Add(New SqlParameter("@Nombre_Articulo", SqlDbType.NVarChar, 50)).Value = Me.TB_Art10.Text
            conex1.Parameters.Add(New SqlParameter("@Marca", SqlDbType.NChar, 10)).Value = Me.TB_Marca10.Text
            conex1.Parameters.Add(New SqlParameter("@Modelo", SqlDbType.NVarChar, 50)).Value = Me.TB_Modelo10.Text
            conex1.Parameters.Add(New SqlParameter("@Serie", SqlDbType.NChar, 20)).Value = Me.TB_Serie10.Text
            conex1.Parameters.Add(New SqlParameter("@No_Factura", SqlDbType.NChar, 20)).Value = TB_NoFactura10.Text
            conex1.Parameters.Add(New SqlParameter("@Fecha_Factura", SqlDbType.SmallDateTime)).Value = DateTimePicker_Factura10.Text
            conex1.Parameters.Add(New SqlParameter("@Cantidad_Articulos", SqlDbType.Int)).Value = Val(NUpDown_CanArt10.Text)
            conex1.Parameters.Add(New SqlParameter("@Costo_Unitario", SqlDbType.Int)).Value = Val(TB_CostoUnit10.Text)
            conex1.Parameters.Add(New SqlParameter("@Costo_Total", SqlDbType.Int)).Value = Val(TB_CostoTotal10.Text)
            conex1.Parameters.Add(New SqlParameter("@Act_Transferencia", SqlDbType.NChar, 2)).Value = "10"
            conex1.CommandText = Insar10
            conex1.ExecuteNonQuery()
            Me.SqlConnection1.Close()
        Catch es As Exception
            MsgBox(es.ToString)
        End Try
    End Sub
    Sub Transferencia11()
        Try
            Me.SqlConnection1.Open()
            Dim Insar11 As String = "INSERT INTO Transferencia (Folio_Entrega,Folio_Recibe,Solicitud_Entrega,Solicitud_Transferencia,Fecha_Registro_Transferencia,Depto_Entrega,Depto_Recibe,Responsable_Entrega,Responsable_Recibe,No_Activo,Cve_Categoria,Cve_SubCategoria,Nombre_Articulo,Marca,Modelo,Serie,No_Factura,Fecha_Factura,Cantidad_Articulos,Costo_Unitario,Costo_Total,Act_Transferencia) values(@Folio_Entrega,@Folio_Recibe,@Solicitud_Entrega,@Solicitud_Transferencia,@Fecha_Registro_Transferencia,@Depto_Entrega,@Depto_Recibe,@Responsable_Entrega,@Responsable_Recibe,@No_Activo,@Cve_Categoria,@Cve_SubCategoria,@Nombre_Articulo,@Marca,@Modelo,@Serie,@No_Factura,@Fecha_Factura,@Cantidad_Articulos,@Costo_Unitario,@Costo_Total,@Act_Transferencia)"
            Dim conex1 As New SqlClient.SqlCommand(Insar11, Me.SqlConnection1)
            conex1.Parameters.Add(New SqlParameter("@Folio_Entrega", SqlDbType.Int, 4)).Value = Me.CB_Folio.Text
            conex1.Parameters.Add(New SqlParameter("@Folio_Recibe", SqlDbType.Int, 4)).Value = Me.TB_Folio_Transferencia.Text
            conex1.Parameters.Add(New SqlParameter("@Solicitud_Entrega", SqlDbType.NChar, 10)).Value = TB_Solicitud_Entrega.Text
            conex1.Parameters.Add(New SqlParameter("@Solicitud_Transferencia", SqlDbType.NChar, 10)).Value = TB_Solicitud_Transferencia.Text
            conex1.Parameters.Add(New SqlParameter("@Fecha_Registro_Transferencia", SqlDbType.SmallDateTime)).Value = DateTimePicker_Registro.Text
            conex1.Parameters.Add(New SqlParameter("@Depto_Entrega", SqlDbType.NVarChar, 50)).Value = Me.CB_Departamento.Text
            conex1.Parameters.Add(New SqlParameter("@Depto_Recibe", SqlDbType.NVarChar, 50)).Value = Me.CB_Depto_Transferencia.Text
            conex1.Parameters.Add(New SqlParameter("@Responsable_Entrega", SqlDbType.NVarChar, 50)).Value = Me.CB_Responsable_Entrega.Text
            conex1.Parameters.Add(New SqlParameter("@Responsable_Recibe", SqlDbType.NVarChar, 50)).Value = Me.CB_Responsable_Recibe.Text
            conex1.Parameters.Add(New SqlParameter("@No_Activo", SqlDbType.Int, 4)).Value = Me.TB_CI_11.Text
            conex1.Parameters.Add(New SqlParameter("@Cve_Categoria", SqlDbType.NChar, 10)).Value = Me.TB_CAT11.Text
            conex1.Parameters.Add(New SqlParameter("@Cve_SubCategoria", SqlDbType.NChar, 10)).Value = Me.TB_Cve_A11.Text
            conex1.Parameters.Add(New SqlParameter("@Nombre_Articulo", SqlDbType.NVarChar, 50)).Value = Me.TB_Art11.Text
            conex1.Parameters.Add(New SqlParameter("@Marca", SqlDbType.NChar, 10)).Value = Me.TB_Marca11.Text
            conex1.Parameters.Add(New SqlParameter("@Modelo", SqlDbType.NVarChar, 50)).Value = Me.TB_Modelo11.Text
            conex1.Parameters.Add(New SqlParameter("@Serie", SqlDbType.NChar, 20)).Value = Me.TB_Serie11.Text
            conex1.Parameters.Add(New SqlParameter("@No_Factura", SqlDbType.NChar, 20)).Value = TB_NoFactura11.Text
            conex1.Parameters.Add(New SqlParameter("@Fecha_Factura", SqlDbType.SmallDateTime)).Value = DateTimePicker_Factura11.Text
            conex1.Parameters.Add(New SqlParameter("@Cantidad_Articulos", SqlDbType.Int)).Value = Val(NUpDown_CanArt11.Text)
            conex1.Parameters.Add(New SqlParameter("@Costo_Unitario", SqlDbType.Int)).Value = Val(TB_CostoUnit11.Text)
            conex1.Parameters.Add(New SqlParameter("@Costo_Total", SqlDbType.Int)).Value = Val(TB_CostoTotal11.Text)
            conex1.Parameters.Add(New SqlParameter("@Act_Transferencia", SqlDbType.NChar, 2)).Value = "11"
            conex1.CommandText = Insar11
            conex1.ExecuteNonQuery()
            Me.SqlConnection1.Close()
        Catch es As Exception
            MsgBox(es.ToString)
        End Try
    End Sub
    Sub Transferencia12()
        Try
            Me.SqlConnection1.Open()
            Dim Insar12 As String = "INSERT INTO Transferencia (Folio_Entrega,Folio_Recibe,Solicitud_Entrega,Solicitud_Transferencia,Fecha_Registro_Transferencia,Depto_Entrega,Depto_Recibe,Responsable_Entrega,Responsable_Recibe,No_Activo,Cve_Categoria,Cve_SubCategoria,Nombre_Articulo,Marca,Modelo,Serie,No_Factura,Fecha_Factura,Cantidad_Articulos,Costo_Unitario,Costo_Total,Act_Transferencia) values(@Folio_Entrega,@Folio_Recibe,@Solicitud_Entrega,@Solicitud_Transferencia,@Fecha_Registro_Transferencia,@Depto_Entrega,@Depto_Recibe,@Responsable_Entrega,@Responsable_Recibe,@No_Activo,@Cve_Categoria,@Cve_SubCategoria,@Nombre_Articulo,@Marca,@Modelo,@Serie,@No_Factura,@Fecha_Factura,@Cantidad_Articulos,@Costo_Unitario,@Costo_Total,@Act_Transferencia)"
            Dim conex1 As New SqlClient.SqlCommand(Insar12, Me.SqlConnection1)
            conex1.Parameters.Add(New SqlParameter("@Folio_Entrega", SqlDbType.Int, 4)).Value = Me.CB_Folio.Text
            conex1.Parameters.Add(New SqlParameter("@Folio_Recibe", SqlDbType.Int, 4)).Value = Me.TB_Folio_Transferencia.Text
            conex1.Parameters.Add(New SqlParameter("@Solicitud_Entrega", SqlDbType.NChar, 10)).Value = TB_Solicitud_Entrega.Text
            conex1.Parameters.Add(New SqlParameter("@Solicitud_Transferencia", SqlDbType.NChar, 10)).Value = TB_Solicitud_Transferencia.Text
            conex1.Parameters.Add(New SqlParameter("@Fecha_Registro_Transferencia", SqlDbType.SmallDateTime)).Value = DateTimePicker_Registro.Text
            conex1.Parameters.Add(New SqlParameter("@Depto_Entrega", SqlDbType.NVarChar, 50)).Value = Me.CB_Departamento.Text
            conex1.Parameters.Add(New SqlParameter("@Depto_Recibe", SqlDbType.NVarChar, 50)).Value = Me.CB_Depto_Transferencia.Text
            conex1.Parameters.Add(New SqlParameter("@Responsable_Entrega", SqlDbType.NVarChar, 50)).Value = Me.CB_Responsable_Entrega.Text
            conex1.Parameters.Add(New SqlParameter("@Responsable_Recibe", SqlDbType.NVarChar, 50)).Value = Me.CB_Responsable_Recibe.Text
            conex1.Parameters.Add(New SqlParameter("@No_Activo", SqlDbType.Int, 4)).Value = Me.TB_CI_12.Text
            conex1.Parameters.Add(New SqlParameter("@Cve_Categoria", SqlDbType.NChar, 10)).Value = Me.TB_CAT12.Text
            conex1.Parameters.Add(New SqlParameter("@Cve_SubCategoria", SqlDbType.NChar, 10)).Value = Me.TB_Cve_A12.Text
            conex1.Parameters.Add(New SqlParameter("@Nombre_Articulo", SqlDbType.NVarChar, 50)).Value = Me.TB_Art12.Text
            conex1.Parameters.Add(New SqlParameter("@Marca", SqlDbType.NChar, 10)).Value = Me.TB_Marca12.Text
            conex1.Parameters.Add(New SqlParameter("@Modelo", SqlDbType.NVarChar, 50)).Value = Me.TB_Modelo12.Text
            conex1.Parameters.Add(New SqlParameter("@Serie", SqlDbType.NChar, 20)).Value = Me.TB_Serie12.Text
            conex1.Parameters.Add(New SqlParameter("@No_Factura", SqlDbType.NChar, 20)).Value = TB_NoFactura12.Text
            conex1.Parameters.Add(New SqlParameter("@Fecha_Factura", SqlDbType.SmallDateTime)).Value = DateTimePicker_Factura12.Text
            conex1.Parameters.Add(New SqlParameter("@Cantidad_Articulos", SqlDbType.Int)).Value = Val(NUpDown_CanArt12.Text)
            conex1.Parameters.Add(New SqlParameter("@Costo_Unitario", SqlDbType.Int)).Value = Val(TB_CostoUnit12.Text)
            conex1.Parameters.Add(New SqlParameter("@Costo_Total", SqlDbType.Int)).Value = Val(TB_CostoTotal12.Text)
            conex1.Parameters.Add(New SqlParameter("@Act_Transferencia", SqlDbType.NChar, 2)).Value = "12"
            conex1.CommandText = Insar12
            conex1.ExecuteNonQuery()
            Me.SqlConnection1.Close()
        Catch es As Exception
            MsgBox(es.ToString)
        End Try
    End Sub
    Sub Transferencia13()
        Try
            Me.SqlConnection1.Open()
            Dim Insar13 As String = "INSERT INTO Transferencia (Folio_Entrega,Folio_Recibe,Solicitud_Entrega,Solicitud_Transferencia,Fecha_Registro_Transferencia,Depto_Entrega,Depto_Recibe,Responsable_Entrega,Responsable_Recibe,No_Activo,Cve_Categoria,Cve_SubCategoria,Nombre_Articulo,Marca,Modelo,Serie,No_Factura,Fecha_Factura,Cantidad_Articulos,Costo_Unitario,Costo_Total,Act_Transferencia) values(@Folio_Entrega,@Folio_Recibe,@Solicitud_Entrega,@Solicitud_Transferencia,@Fecha_Registro_Transferencia,@Depto_Entrega,@Depto_Recibe,@Responsable_Entrega,@Responsable_Recibe,@No_Activo,@Cve_Categoria,@Cve_SubCategoria,@Nombre_Articulo,@Marca,@Modelo,@Serie,@No_Factura,@Fecha_Factura,@Cantidad_Articulos,@Costo_Unitario,@Costo_Total,@Act_Transferencia)"
            Dim conex1 As New SqlClient.SqlCommand(Insar13, Me.SqlConnection1)
            conex1.Parameters.Add(New SqlParameter("@Folio_Entrega", SqlDbType.Int, 4)).Value = Me.CB_Folio.Text
            conex1.Parameters.Add(New SqlParameter("@Folio_Recibe", SqlDbType.Int, 4)).Value = Me.TB_Folio_Transferencia.Text
            conex1.Parameters.Add(New SqlParameter("@Solicitud_Entrega", SqlDbType.NChar, 10)).Value = TB_Solicitud_Entrega.Text
            conex1.Parameters.Add(New SqlParameter("@Solicitud_Transferencia", SqlDbType.NChar, 10)).Value = TB_Solicitud_Transferencia.Text
            conex1.Parameters.Add(New SqlParameter("@Fecha_Registro_Transferencia", SqlDbType.SmallDateTime)).Value = DateTimePicker_Registro.Text
            conex1.Parameters.Add(New SqlParameter("@Depto_Entrega", SqlDbType.NVarChar, 50)).Value = Me.CB_Departamento.Text
            conex1.Parameters.Add(New SqlParameter("@Depto_Recibe", SqlDbType.NVarChar, 50)).Value = Me.CB_Depto_Transferencia.Text
            conex1.Parameters.Add(New SqlParameter("@Responsable_Entrega", SqlDbType.NVarChar, 50)).Value = Me.CB_Responsable_Entrega.Text
            conex1.Parameters.Add(New SqlParameter("@Responsable_Recibe", SqlDbType.NVarChar, 50)).Value = Me.CB_Responsable_Recibe.Text
            conex1.Parameters.Add(New SqlParameter("@No_Activo", SqlDbType.Int, 4)).Value = Me.TB_CI_13.Text
            conex1.Parameters.Add(New SqlParameter("@Cve_Categoria", SqlDbType.NChar, 10)).Value = Me.TB_CAT13.Text
            conex1.Parameters.Add(New SqlParameter("@Cve_SubCategoria", SqlDbType.NChar, 10)).Value = Me.TB_Cve_A13.Text
            conex1.Parameters.Add(New SqlParameter("@Nombre_Articulo", SqlDbType.NVarChar, 50)).Value = Me.TB_Art13.Text
            conex1.Parameters.Add(New SqlParameter("@Marca", SqlDbType.NChar, 10)).Value = Me.TB_Marca13.Text
            conex1.Parameters.Add(New SqlParameter("@Modelo", SqlDbType.NVarChar, 50)).Value = Me.TB_Modelo13.Text
            conex1.Parameters.Add(New SqlParameter("@Serie", SqlDbType.NChar, 20)).Value = Me.TB_Serie13.Text
            conex1.Parameters.Add(New SqlParameter("@No_Factura", SqlDbType.NChar, 20)).Value = TB_NoFactura13.Text
            conex1.Parameters.Add(New SqlParameter("@Fecha_Factura", SqlDbType.SmallDateTime)).Value = DateTimePicker_Factura13.Text
            conex1.Parameters.Add(New SqlParameter("@Cantidad_Articulos", SqlDbType.Int)).Value = Val(NUpDown_CanArt13.Text)
            conex1.Parameters.Add(New SqlParameter("@Costo_Unitario", SqlDbType.Int)).Value = Val(TB_CostoUnit13.Text)
            conex1.Parameters.Add(New SqlParameter("@Costo_Total", SqlDbType.Int)).Value = Val(TB_CostoTotal13.Text)
            conex1.Parameters.Add(New SqlParameter("@Act_Transferencia", SqlDbType.NChar, 2)).Value = "13"
            conex1.CommandText = Insar13
            conex1.ExecuteNonQuery()
            Me.SqlConnection1.Close()
        Catch es As Exception
            MsgBox(es.ToString)
        End Try
    End Sub
    Sub Transferencia14()
        Try
            Me.SqlConnection1.Open()
            Dim Insar14 As String = "INSERT INTO Transferencia (Folio_Entrega,Folio_Recibe,Solicitud_Entrega,Solicitud_Transferencia,Fecha_Registro_Transferencia,Depto_Entrega,Depto_Recibe,Responsable_Entrega,Responsable_Recibe,No_Activo,Cve_Categoria,Cve_SubCategoria,Nombre_Articulo,Marca,Modelo,Serie,No_Factura,Fecha_Factura,Cantidad_Articulos,Costo_Unitario,Costo_Total,Act_Transferencia) values(@Folio_Entrega,@Folio_Recibe,@Solicitud_Entrega,@Solicitud_Transferencia,@Fecha_Registro_Transferencia,@Depto_Entrega,@Depto_Recibe,@Responsable_Entrega,@Responsable_Recibe,@No_Activo,@Cve_Categoria,@Cve_SubCategoria,@Nombre_Articulo,@Marca,@Modelo,@Serie,@No_Factura,@Fecha_Factura,@Cantidad_Articulos,@Costo_Unitario,@Costo_Total,@Act_Transferencia)"
            Dim conex1 As New SqlClient.SqlCommand(Insar14, Me.SqlConnection1)
            conex1.Parameters.Add(New SqlParameter("@Folio_Entrega", SqlDbType.Int, 4)).Value = Me.CB_Folio.Text
            conex1.Parameters.Add(New SqlParameter("@Folio_Recibe", SqlDbType.Int, 4)).Value = Me.TB_Folio_Transferencia.Text
            conex1.Parameters.Add(New SqlParameter("@Solicitud_Entrega", SqlDbType.NChar, 10)).Value = TB_Solicitud_Entrega.Text
            conex1.Parameters.Add(New SqlParameter("@Solicitud_Transferencia", SqlDbType.NChar, 10)).Value = TB_Solicitud_Transferencia.Text
            conex1.Parameters.Add(New SqlParameter("@Fecha_Registro_Transferencia", SqlDbType.SmallDateTime)).Value = DateTimePicker_Registro.Text
            conex1.Parameters.Add(New SqlParameter("@Depto_Entrega", SqlDbType.NVarChar, 50)).Value = Me.CB_Departamento.Text
            conex1.Parameters.Add(New SqlParameter("@Depto_Recibe", SqlDbType.NVarChar, 50)).Value = Me.CB_Depto_Transferencia.Text
            conex1.Parameters.Add(New SqlParameter("@Responsable_Entrega", SqlDbType.NVarChar, 50)).Value = Me.CB_Responsable_Entrega.Text
            conex1.Parameters.Add(New SqlParameter("@Responsable_Recibe", SqlDbType.NVarChar, 50)).Value = Me.CB_Responsable_Recibe.Text
            conex1.Parameters.Add(New SqlParameter("@No_Activo", SqlDbType.Int, 4)).Value = Me.TB_CI_14.Text
            conex1.Parameters.Add(New SqlParameter("@Cve_Categoria", SqlDbType.NChar, 10)).Value = Me.TB_CAT14.Text
            conex1.Parameters.Add(New SqlParameter("@Cve_SubCategoria", SqlDbType.NChar, 10)).Value = Me.TB_Cve_A14.Text
            conex1.Parameters.Add(New SqlParameter("@Nombre_Articulo", SqlDbType.NVarChar, 50)).Value = Me.TB_Art14.Text
            conex1.Parameters.Add(New SqlParameter("@Marca", SqlDbType.NChar, 10)).Value = Me.TB_Marca14.Text
            conex1.Parameters.Add(New SqlParameter("@Modelo", SqlDbType.NVarChar, 50)).Value = Me.TB_Modelo14.Text
            conex1.Parameters.Add(New SqlParameter("@Serie", SqlDbType.NChar, 20)).Value = Me.TB_Serie14.Text
            conex1.Parameters.Add(New SqlParameter("@No_Factura", SqlDbType.NChar, 20)).Value = TB_NoFactura14.Text
            conex1.Parameters.Add(New SqlParameter("@Fecha_Factura", SqlDbType.SmallDateTime)).Value = DateTimePicker_Factura14.Text
            conex1.Parameters.Add(New SqlParameter("@Cantidad_Articulos", SqlDbType.Int)).Value = Val(NUpDown_CanArt14.Text)
            conex1.Parameters.Add(New SqlParameter("@Costo_Unitario", SqlDbType.Int)).Value = Val(TB_CostoUnit14.Text)
            conex1.Parameters.Add(New SqlParameter("@Costo_Total", SqlDbType.Int)).Value = Val(TB_CostoTotal14.Text)
            conex1.Parameters.Add(New SqlParameter("@Act_Transferencia", SqlDbType.NChar, 2)).Value = "14"
            conex1.CommandText = Insar14
            conex1.ExecuteNonQuery()
            Me.SqlConnection1.Close()
        Catch es As Exception
            MsgBox(es.ToString)
        End Try
    End Sub
    Sub Transferencia15()
        Try
            Me.SqlConnection1.Open()
            Dim Insar15 As String = "INSERT INTO Transferencia (Folio_Entrega,Folio_Recibe,Solicitud_Entrega,Solicitud_Transferencia,Fecha_Registro_Transferencia,Depto_Entrega,Depto_Recibe,Responsable_Entrega,Responsable_Recibe,No_Activo,Cve_Categoria,Cve_SubCategoria,Nombre_Articulo,Marca,Modelo,Serie,No_Factura,Fecha_Factura,Cantidad_Articulos,Costo_Unitario,Costo_Total,Act_Transferencia) values(@Folio_Entrega,@Folio_Recibe,@Solicitud_Entrega,@Solicitud_Transferencia,@Fecha_Registro_Transferencia,@Depto_Entrega,@Depto_Recibe,@Responsable_Entrega,@Responsable_Recibe,@No_Activo,@Cve_Categoria,@Cve_SubCategoria,@Nombre_Articulo,@Marca,@Modelo,@Serie,@No_Factura,@Fecha_Factura,@Cantidad_Articulos,@Costo_Unitario,@Costo_Total,@Act_Transferencia)"
            Dim conex1 As New SqlClient.SqlCommand(Insar15, Me.SqlConnection1)
            conex1.Parameters.Add(New SqlParameter("@Folio_Entrega", SqlDbType.Int, 4)).Value = Me.CB_Folio.Text
            conex1.Parameters.Add(New SqlParameter("@Folio_Recibe", SqlDbType.Int, 4)).Value = Me.TB_Folio_Transferencia.Text
            conex1.Parameters.Add(New SqlParameter("@Solicitud_Entrega", SqlDbType.NChar, 10)).Value = TB_Solicitud_Entrega.Text
            conex1.Parameters.Add(New SqlParameter("@Solicitud_Transferencia", SqlDbType.NChar, 10)).Value = TB_Solicitud_Transferencia.Text
            conex1.Parameters.Add(New SqlParameter("@Fecha_Registro_Transferencia", SqlDbType.SmallDateTime)).Value = DateTimePicker_Registro.Text
            conex1.Parameters.Add(New SqlParameter("@Depto_Entrega", SqlDbType.NVarChar, 50)).Value = Me.CB_Departamento.Text
            conex1.Parameters.Add(New SqlParameter("@Depto_Recibe", SqlDbType.NVarChar, 50)).Value = Me.CB_Depto_Transferencia.Text
            conex1.Parameters.Add(New SqlParameter("@Responsable_Entrega", SqlDbType.NVarChar, 50)).Value = Me.CB_Responsable_Entrega.Text
            conex1.Parameters.Add(New SqlParameter("@Responsable_Recibe", SqlDbType.NVarChar, 50)).Value = Me.CB_Responsable_Recibe.Text
            conex1.Parameters.Add(New SqlParameter("@No_Activo", SqlDbType.Int, 4)).Value = Me.TB_CI_15.Text
            conex1.Parameters.Add(New SqlParameter("@Cve_Categoria", SqlDbType.NChar, 10)).Value = Me.TB_CAT15.Text
            conex1.Parameters.Add(New SqlParameter("@Cve_SubCategoria", SqlDbType.NChar, 10)).Value = Me.TB_Cve_A15.Text
            conex1.Parameters.Add(New SqlParameter("@Nombre_Articulo", SqlDbType.NVarChar, 50)).Value = Me.TB_Art15.Text
            conex1.Parameters.Add(New SqlParameter("@Marca", SqlDbType.NChar, 10)).Value = Me.TB_Marca15.Text
            conex1.Parameters.Add(New SqlParameter("@Modelo", SqlDbType.NVarChar, 50)).Value = Me.TB_Modelo15.Text
            conex1.Parameters.Add(New SqlParameter("@Serie", SqlDbType.NChar, 20)).Value = Me.TB_Serie15.Text
            conex1.Parameters.Add(New SqlParameter("@No_Factura", SqlDbType.NChar, 20)).Value = TB_NoFactura15.Text
            conex1.Parameters.Add(New SqlParameter("@Fecha_Factura", SqlDbType.SmallDateTime)).Value = DateTimePicker_Factura15.Text
            conex1.Parameters.Add(New SqlParameter("@Cantidad_Articulos", SqlDbType.Int)).Value = Val(NUpDown_CanArt15.Text)
            conex1.Parameters.Add(New SqlParameter("@Costo_Unitario", SqlDbType.Int)).Value = Val(TB_CostoUnit15.Text)
            conex1.Parameters.Add(New SqlParameter("@Costo_Total", SqlDbType.Int)).Value = Val(TB_CostoTotal15.Text)
            conex1.Parameters.Add(New SqlParameter("@Act_Transferencia", SqlDbType.NChar, 2)).Value = "15"
            conex1.CommandText = Insar15
            conex1.ExecuteNonQuery()
            Me.SqlConnection1.Close()
        Catch es As Exception
            MsgBox(es.ToString)
        End Try
    End Sub
    
    Sub Transferencia16()
        Try
            Me.SqlConnection1.Open()
            Dim Insar16 As String = "INSERT INTO Transferencia (Folio_Entrega,Folio_Recibe,Solicitud_Entrega,Solicitud_Transferencia,Fecha_Registro_Transferencia,Depto_Entrega,Depto_Recibe,Responsable_Entrega,Responsable_Recibe,No_Activo,Cve_Categoria,Cve_SubCategoria,Nombre_Articulo,Marca,Modelo,Serie,No_Factura,Fecha_Factura,Cantidad_Articulos,Costo_Unitario,Costo_Total,Act_Transferencia) values(@Folio_Entrega,@Folio_Recibe,@Solicitud_Entrega,@Solicitud_Transferencia,@Fecha_Registro_Transferencia,@Depto_Entrega,@Depto_Recibe,@Responsable_Entrega,@Responsable_Recibe,@No_Activo,@Cve_Categoria,@Cve_SubCategoria,@Nombre_Articulo,@Marca,@Modelo,@Serie,@No_Factura,@Fecha_Factura,@Cantidad_Articulos,@Costo_Unitario,@Costo_Total,@Act_Transferencia)"
            Dim conex1 As New SqlClient.SqlCommand(Insar16, Me.SqlConnection1)
            conex1.Parameters.Add(New SqlParameter("@Folio_Entrega", SqlDbType.Int, 4)).Value = Me.CB_Folio.Text
            conex1.Parameters.Add(New SqlParameter("@Folio_Recibe", SqlDbType.Int, 4)).Value = Me.TB_Folio_Transferencia.Text
            conex1.Parameters.Add(New SqlParameter("@Solicitud_Entrega", SqlDbType.NChar, 10)).Value = TB_Solicitud_Entrega.Text
            conex1.Parameters.Add(New SqlParameter("@Solicitud_Transferencia", SqlDbType.NChar, 10)).Value = TB_Solicitud_Transferencia.Text
            conex1.Parameters.Add(New SqlParameter("@Fecha_Registro_Transferencia", SqlDbType.SmallDateTime)).Value = DateTimePicker_Registro.Text
            conex1.Parameters.Add(New SqlParameter("@Depto_Entrega", SqlDbType.NVarChar, 50)).Value = Me.CB_Departamento.Text
            conex1.Parameters.Add(New SqlParameter("@Depto_Recibe", SqlDbType.NVarChar, 50)).Value = Me.CB_Depto_Transferencia.Text
            conex1.Parameters.Add(New SqlParameter("@Responsable_Entrega", SqlDbType.NVarChar, 50)).Value = Me.CB_Responsable_Entrega.Text
            conex1.Parameters.Add(New SqlParameter("@Responsable_Recibe", SqlDbType.NVarChar, 50)).Value = Me.CB_Responsable_Recibe.Text
            conex1.Parameters.Add(New SqlParameter("@No_Activo", SqlDbType.Int, 4)).Value = Me.TB_CI_16.Text
            conex1.Parameters.Add(New SqlParameter("@Cve_Categoria", SqlDbType.NChar, 10)).Value = Me.TB_CAT16.Text
            conex1.Parameters.Add(New SqlParameter("@Cve_SubCategoria", SqlDbType.NChar, 10)).Value = Me.TB_Cve_A16.Text
            conex1.Parameters.Add(New SqlParameter("@Nombre_Articulo", SqlDbType.NVarChar, 50)).Value = Me.TB_Art16.Text
            conex1.Parameters.Add(New SqlParameter("@Marca", SqlDbType.NChar, 10)).Value = Me.TB_Marca16.Text
            conex1.Parameters.Add(New SqlParameter("@Modelo", SqlDbType.NVarChar, 50)).Value = Me.TB_Modelo16.Text
            conex1.Parameters.Add(New SqlParameter("@Serie", SqlDbType.NChar, 20)).Value = Me.TB_Serie16.Text
            conex1.Parameters.Add(New SqlParameter("@No_Factura", SqlDbType.NChar, 20)).Value = TB_NoFactura16.Text
            conex1.Parameters.Add(New SqlParameter("@Fecha_Factura", SqlDbType.SmallDateTime)).Value = DateTimePicker_Factura16.Text
            conex1.Parameters.Add(New SqlParameter("@Cantidad_Articulos", SqlDbType.Int)).Value = Val(NUpDown_CanArt16.Text)
            conex1.Parameters.Add(New SqlParameter("@Costo_Unitario", SqlDbType.Int)).Value = Val(TB_CostoUnit16.Text)
            conex1.Parameters.Add(New SqlParameter("@Costo_Total", SqlDbType.Int)).Value = Val(TB_CostoTotal16.Text)
            conex1.Parameters.Add(New SqlParameter("@Act_Transferencia", SqlDbType.NChar, 2)).Value = "16"
            conex1.CommandText = Insar16
            conex1.ExecuteNonQuery()
            Me.SqlConnection1.Close()
        Catch es As Exception
            MsgBox(es.ToString)
        End Try
    End Sub
    Sub Transferencia17()
        Try
            Me.SqlConnection1.Open()
            Dim Insar17 As String = "INSERT INTO Transferencia (Folio_Entrega,Folio_Recibe,Solicitud_Entrega,Solicitud_Transferencia,Fecha_Registro_Transferencia,Depto_Entrega,Depto_Recibe,Responsable_Entrega,Responsable_Recibe,No_Activo,Cve_Categoria,Cve_SubCategoria,Nombre_Articulo,Marca,Modelo,Serie,No_Factura,Fecha_Factura,Cantidad_Articulos,Costo_Unitario,Costo_Total,Act_Transferencia) values(@Folio_Entrega,@Folio_Recibe,@Solicitud_Entrega,@Solicitud_Transferencia,@Fecha_Registro_Transferencia,@Depto_Entrega,@Depto_Recibe,@Responsable_Entrega,@Responsable_Recibe,@No_Activo,@Cve_Categoria,@Cve_SubCategoria,@Nombre_Articulo,@Marca,@Modelo,@Serie,@No_Factura,@Fecha_Factura,@Cantidad_Articulos,@Costo_Unitario,@Costo_Total,@Act_Transferencia)"
            Dim conex1 As New SqlClient.SqlCommand(Insar17, Me.SqlConnection1)
            conex1.Parameters.Add(New SqlParameter("@Folio_Entrega", SqlDbType.Int, 4)).Value = Me.CB_Folio.Text
            conex1.Parameters.Add(New SqlParameter("@Folio_Recibe", SqlDbType.Int, 4)).Value = Me.TB_Folio_Transferencia.Text
            conex1.Parameters.Add(New SqlParameter("@Solicitud_Entrega", SqlDbType.NChar, 10)).Value = TB_Solicitud_Entrega.Text
            conex1.Parameters.Add(New SqlParameter("@Solicitud_Transferencia", SqlDbType.NChar, 10)).Value = TB_Solicitud_Transferencia.Text
            conex1.Parameters.Add(New SqlParameter("@Fecha_Registro_Transferencia", SqlDbType.SmallDateTime)).Value = DateTimePicker_Registro.Text
            conex1.Parameters.Add(New SqlParameter("@Depto_Entrega", SqlDbType.NVarChar, 50)).Value = Me.CB_Departamento.Text
            conex1.Parameters.Add(New SqlParameter("@Depto_Recibe", SqlDbType.NVarChar, 50)).Value = Me.CB_Depto_Transferencia.Text
            conex1.Parameters.Add(New SqlParameter("@Responsable_Entrega", SqlDbType.NVarChar, 50)).Value = Me.CB_Responsable_Entrega.Text
            conex1.Parameters.Add(New SqlParameter("@Responsable_Recibe", SqlDbType.NVarChar, 50)).Value = Me.CB_Responsable_Recibe.Text
            conex1.Parameters.Add(New SqlParameter("@No_Activo", SqlDbType.Int, 4)).Value = Me.TB_CI_17.Text
            conex1.Parameters.Add(New SqlParameter("@Cve_Categoria", SqlDbType.NChar, 10)).Value = Me.TB_CAT17.Text
            conex1.Parameters.Add(New SqlParameter("@Cve_SubCategoria", SqlDbType.NChar, 10)).Value = Me.TB_Cve_A17.Text
            conex1.Parameters.Add(New SqlParameter("@Nombre_Articulo", SqlDbType.NVarChar, 50)).Value = Me.TB_Art17.Text
            conex1.Parameters.Add(New SqlParameter("@Marca", SqlDbType.NChar, 10)).Value = Me.TB_Marca17.Text
            conex1.Parameters.Add(New SqlParameter("@Modelo", SqlDbType.NVarChar, 50)).Value = Me.TB_Modelo17.Text
            conex1.Parameters.Add(New SqlParameter("@Serie", SqlDbType.NChar, 20)).Value = Me.TB_Serie17.Text
            conex1.Parameters.Add(New SqlParameter("@No_Factura", SqlDbType.NChar, 20)).Value = TB_NoFactura17.Text
            conex1.Parameters.Add(New SqlParameter("@Fecha_Factura", SqlDbType.SmallDateTime)).Value = DateTimePicker_Factura17.Text
            conex1.Parameters.Add(New SqlParameter("@Cantidad_Articulos", SqlDbType.Int)).Value = Val(NUpDown_CanArt17.Text)
            conex1.Parameters.Add(New SqlParameter("@Costo_Unitario", SqlDbType.Int)).Value = Val(TB_CostoUnit17.Text)
            conex1.Parameters.Add(New SqlParameter("@Costo_Total", SqlDbType.Int)).Value = Val(TB_CostoTotal17.Text)
            conex1.Parameters.Add(New SqlParameter("@Act_Transferencia", SqlDbType.NChar, 2)).Value = "17"
            conex1.CommandText = Insar17
            conex1.ExecuteNonQuery()
            Me.SqlConnection1.Close()
        Catch es As Exception
            MsgBox(es.ToString)
        End Try
    End Sub
    Sub Transferencia18()
        Try
            Me.SqlConnection1.Open()
            Dim Insar18 As String = "INSERT INTO Transferencia (Folio_Entrega,Folio_Recibe,Solicitud_Entrega,Solicitud_Transferencia,Fecha_Registro_Transferencia,Depto_Entrega,Depto_Recibe,Responsable_Entrega,Responsable_Recibe,No_Activo,Cve_Categoria,Cve_SubCategoria,Nombre_Articulo,Marca,Modelo,Serie,No_Factura,Fecha_Factura,Cantidad_Articulos,Costo_Unitario,Costo_Total,Act_Transferencia) values(@Folio_Entrega,@Folio_Recibe,@Solicitud_Entrega,@Solicitud_Transferencia,@Fecha_Registro_Transferencia,@Depto_Entrega,@Depto_Recibe,@Responsable_Entrega,@Responsable_Recibe,@No_Activo,@Cve_Categoria,@Cve_SubCategoria,@Nombre_Articulo,@Marca,@Modelo,@Serie,@No_Factura,@Fecha_Factura,@Cantidad_Articulos,@Costo_Unitario,@Costo_Total,@Act_Transferencia)"
            Dim conex1 As New SqlClient.SqlCommand(Insar18, Me.SqlConnection1)
            conex1.Parameters.Add(New SqlParameter("@Folio_Entrega", SqlDbType.Int, 4)).Value = Me.CB_Folio.Text
            conex1.Parameters.Add(New SqlParameter("@Folio_Recibe", SqlDbType.Int, 4)).Value = Me.TB_Folio_Transferencia.Text
            conex1.Parameters.Add(New SqlParameter("@Solicitud_Entrega", SqlDbType.NChar, 10)).Value = TB_Solicitud_Entrega.Text
            conex1.Parameters.Add(New SqlParameter("@Solicitud_Transferencia", SqlDbType.NChar, 10)).Value = TB_Solicitud_Transferencia.Text
            conex1.Parameters.Add(New SqlParameter("@Fecha_Registro_Transferencia", SqlDbType.SmallDateTime)).Value = DateTimePicker_Registro.Text
            conex1.Parameters.Add(New SqlParameter("@Depto_Entrega", SqlDbType.NVarChar, 50)).Value = Me.CB_Departamento.Text
            conex1.Parameters.Add(New SqlParameter("@Depto_Recibe", SqlDbType.NVarChar, 50)).Value = Me.CB_Depto_Transferencia.Text
            conex1.Parameters.Add(New SqlParameter("@Responsable_Entrega", SqlDbType.NVarChar, 50)).Value = Me.CB_Responsable_Entrega.Text
            conex1.Parameters.Add(New SqlParameter("@Responsable_Recibe", SqlDbType.NVarChar, 50)).Value = Me.CB_Responsable_Recibe.Text
            conex1.Parameters.Add(New SqlParameter("@No_Activo", SqlDbType.Int, 4)).Value = Me.TB_CI_18.Text
            conex1.Parameters.Add(New SqlParameter("@Cve_Categoria", SqlDbType.NChar, 10)).Value = Me.TB_CAT18.Text
            conex1.Parameters.Add(New SqlParameter("@Cve_SubCategoria", SqlDbType.NChar, 10)).Value = Me.TB_Cve_A18.Text
            conex1.Parameters.Add(New SqlParameter("@Nombre_Articulo", SqlDbType.NVarChar, 50)).Value = Me.TB_Art18.Text
            conex1.Parameters.Add(New SqlParameter("@Marca", SqlDbType.NChar, 10)).Value = Me.TB_Marca18.Text
            conex1.Parameters.Add(New SqlParameter("@Modelo", SqlDbType.NVarChar, 50)).Value = Me.TB_Modelo18.Text
            conex1.Parameters.Add(New SqlParameter("@Serie", SqlDbType.NChar, 20)).Value = Me.TB_Serie18.Text
            conex1.Parameters.Add(New SqlParameter("@No_Factura", SqlDbType.NChar, 20)).Value = TB_NoFactura18.Text
            conex1.Parameters.Add(New SqlParameter("@Fecha_Factura", SqlDbType.SmallDateTime)).Value = DateTimePicker_Factura18.Text
            conex1.Parameters.Add(New SqlParameter("@Cantidad_Articulos", SqlDbType.Int)).Value = Val(NUpDown_CanArt18.Text)
            conex1.Parameters.Add(New SqlParameter("@Costo_Unitario", SqlDbType.Int)).Value = Val(TB_CostoUnit18.Text)
            conex1.Parameters.Add(New SqlParameter("@Costo_Total", SqlDbType.Int)).Value = Val(TB_CostoTotal18.Text)
            conex1.Parameters.Add(New SqlParameter("@Act_Transferencia", SqlDbType.NChar, 2)).Value = "18"
            conex1.CommandText = Insar18
            conex1.ExecuteNonQuery()
            Me.SqlConnection1.Close()
        Catch es As Exception
            MsgBox(es.ToString)
        End Try
    End Sub
    Sub Transferencia19()
        Try
            Me.SqlConnection1.Open()
            Dim Insar19 As String = "INSERT INTO Transferencia (Folio_Entrega,Folio_Recibe,Solicitud_Entrega,Solicitud_Transferencia,Fecha_Registro_Transferencia,Depto_Entrega,Depto_Recibe,Responsable_Entrega,Responsable_Recibe,No_Activo,Cve_Categoria,Cve_SubCategoria,Nombre_Articulo,Marca,Modelo,Serie,No_Factura,Fecha_Factura,Cantidad_Articulos,Costo_Unitario,Costo_Total,Act_Transferencia) values(@Folio_Entrega,@Folio_Recibe,@Solicitud_Entrega,@Solicitud_Transferencia,@Fecha_Registro_Transferencia,@Depto_Entrega,@Depto_Recibe,@Responsable_Entrega,@Responsable_Recibe,@No_Activo,@Cve_Categoria,@Cve_SubCategoria,@Nombre_Articulo,@Marca,@Modelo,@Serie,@No_Factura,@Fecha_Factura,@Cantidad_Articulos,@Costo_Unitario,@Costo_Total,@Act_Transferencia)"
            Dim conex1 As New SqlClient.SqlCommand(Insar19, Me.SqlConnection1)
            conex1.Parameters.Add(New SqlParameter("@Folio_Entrega", SqlDbType.Int, 4)).Value = Me.CB_Folio.Text
            conex1.Parameters.Add(New SqlParameter("@Folio_Recibe", SqlDbType.Int, 4)).Value = Me.TB_Folio_Transferencia.Text
            conex1.Parameters.Add(New SqlParameter("@Solicitud_Entrega", SqlDbType.NChar, 10)).Value = TB_Solicitud_Entrega.Text
            conex1.Parameters.Add(New SqlParameter("@Solicitud_Transferencia", SqlDbType.NChar, 10)).Value = TB_Solicitud_Transferencia.Text
            conex1.Parameters.Add(New SqlParameter("@Fecha_Registro_Transferencia", SqlDbType.SmallDateTime)).Value = DateTimePicker_Registro.Text
            conex1.Parameters.Add(New SqlParameter("@Depto_Entrega", SqlDbType.NVarChar, 50)).Value = Me.CB_Departamento.Text
            conex1.Parameters.Add(New SqlParameter("@Depto_Recibe", SqlDbType.NVarChar, 50)).Value = Me.CB_Depto_Transferencia.Text
            conex1.Parameters.Add(New SqlParameter("@Responsable_Entrega", SqlDbType.NVarChar, 50)).Value = Me.CB_Responsable_Entrega.Text
            conex1.Parameters.Add(New SqlParameter("@Responsable_Recibe", SqlDbType.NVarChar, 50)).Value = Me.CB_Responsable_Recibe.Text
            conex1.Parameters.Add(New SqlParameter("@No_Activo", SqlDbType.Int, 4)).Value = Me.TB_CI_19.Text
            conex1.Parameters.Add(New SqlParameter("@Cve_Categoria", SqlDbType.NChar, 10)).Value = Me.TB_CAT19.Text
            conex1.Parameters.Add(New SqlParameter("@Cve_SubCategoria", SqlDbType.NChar, 10)).Value = Me.TB_Cve_A19.Text
            conex1.Parameters.Add(New SqlParameter("@Nombre_Articulo", SqlDbType.NVarChar, 50)).Value = Me.TB_Art19.Text
            conex1.Parameters.Add(New SqlParameter("@Marca", SqlDbType.NChar, 10)).Value = Me.TB_Marca19.Text
            conex1.Parameters.Add(New SqlParameter("@Modelo", SqlDbType.NVarChar, 50)).Value = Me.TB_Modelo19.Text
            conex1.Parameters.Add(New SqlParameter("@Serie", SqlDbType.NChar, 20)).Value = Me.TB_Serie19.Text
            conex1.Parameters.Add(New SqlParameter("@No_Factura", SqlDbType.NChar, 20)).Value = TB_NoFactura19.Text
            conex1.Parameters.Add(New SqlParameter("@Fecha_Factura", SqlDbType.SmallDateTime)).Value = DateTimePicker_Factura19.Text
            conex1.Parameters.Add(New SqlParameter("@Cantidad_Articulos", SqlDbType.Int)).Value = Val(NUpDown_CanArt19.Text)
            conex1.Parameters.Add(New SqlParameter("@Costo_Unitario", SqlDbType.Int)).Value = Val(TB_CostoUnit19.Text)
            conex1.Parameters.Add(New SqlParameter("@Costo_Total", SqlDbType.Int)).Value = Val(TB_CostoTotal19.Text)
            conex1.Parameters.Add(New SqlParameter("@Act_Transferencia", SqlDbType.NChar, 2)).Value = "19"
            conex1.CommandText = Insar19
            conex1.ExecuteNonQuery()
            Me.SqlConnection1.Close()
        Catch es As Exception
            MsgBox(es.ToString)
        End Try
    End Sub
    Sub Transferencia20()
        Try
            Me.SqlConnection1.Open()
            Dim Insar20 As String = "INSERT INTO Transferencia (Folio_Entrega,Folio_Recibe,Solicitud_Entrega,Solicitud_Transferencia,Fecha_Registro_Transferencia,Depto_Entrega,Depto_Recibe,Responsable_Entrega,Responsable_Recibe,No_Activo,Cve_Categoria,Cve_SubCategoria,Nombre_Articulo,Marca,Modelo,Serie,No_Factura,Fecha_Factura,Cantidad_Articulos,Costo_Unitario,Costo_Total,Act_Transferencia) values(@Folio_Entrega,@Folio_Recibe,@Solicitud_Entrega,@Solicitud_Transferencia,@Fecha_Registro_Transferencia,@Depto_Entrega,@Depto_Recibe,@Responsable_Entrega,@Responsable_Recibe,@No_Activo,@Cve_Categoria,@Cve_SubCategoria,@Nombre_Articulo,@Marca,@Modelo,@Serie,@No_Factura,@Fecha_Factura,@Cantidad_Articulos,@Costo_Unitario,@Costo_Total,@Act_Transferencia)"
            Dim conex1 As New SqlClient.SqlCommand(Insar20, Me.SqlConnection1)
            conex1.Parameters.Add(New SqlParameter("@Folio_Entrega", SqlDbType.Int, 4)).Value = Me.CB_Folio.Text
            conex1.Parameters.Add(New SqlParameter("@Folio_Recibe", SqlDbType.Int, 4)).Value = Me.TB_Folio_Transferencia.Text
            conex1.Parameters.Add(New SqlParameter("@Solicitud_Entrega", SqlDbType.NChar, 10)).Value = TB_Solicitud_Entrega.Text
            conex1.Parameters.Add(New SqlParameter("@Solicitud_Transferencia", SqlDbType.NChar, 10)).Value = TB_Solicitud_Transferencia.Text
            conex1.Parameters.Add(New SqlParameter("@Fecha_Registro_Transferencia", SqlDbType.SmallDateTime)).Value = DateTimePicker_Registro.Text
            conex1.Parameters.Add(New SqlParameter("@Depto_Entrega", SqlDbType.NVarChar, 50)).Value = Me.CB_Departamento.Text
            conex1.Parameters.Add(New SqlParameter("@Depto_Recibe", SqlDbType.NVarChar, 50)).Value = Me.CB_Depto_Transferencia.Text
            conex1.Parameters.Add(New SqlParameter("@Responsable_Entrega", SqlDbType.NVarChar, 50)).Value = Me.CB_Responsable_Entrega.Text
            conex1.Parameters.Add(New SqlParameter("@Responsable_Recibe", SqlDbType.NVarChar, 50)).Value = Me.CB_Responsable_Recibe.Text
            conex1.Parameters.Add(New SqlParameter("@No_Activo", SqlDbType.Int, 4)).Value = Me.TB_CI_20.Text
            conex1.Parameters.Add(New SqlParameter("@Cve_Categoria", SqlDbType.NChar, 10)).Value = Me.TB_CAT20.Text
            conex1.Parameters.Add(New SqlParameter("@Cve_SubCategoria", SqlDbType.NChar, 10)).Value = Me.TB_Cve_A20.Text
            conex1.Parameters.Add(New SqlParameter("@Nombre_Articulo", SqlDbType.NVarChar, 50)).Value = Me.TB_Art20.Text
            conex1.Parameters.Add(New SqlParameter("@Marca", SqlDbType.NChar, 10)).Value = Me.TB_Marca20.Text
            conex1.Parameters.Add(New SqlParameter("@Modelo", SqlDbType.NVarChar, 50)).Value = Me.TB_Modelo20.Text
            conex1.Parameters.Add(New SqlParameter("@Serie", SqlDbType.NChar, 20)).Value = Me.TB_Serie20.Text
            conex1.Parameters.Add(New SqlParameter("@No_Factura", SqlDbType.NChar, 20)).Value = TB_NoFactura20.Text
            conex1.Parameters.Add(New SqlParameter("@Fecha_Factura", SqlDbType.SmallDateTime)).Value = DateTimePicker_Factura20.Text
            conex1.Parameters.Add(New SqlParameter("@Cantidad_Articulos", SqlDbType.Int)).Value = Val(NUpDown_CanArt20.Text)
            conex1.Parameters.Add(New SqlParameter("@Costo_Unitario", SqlDbType.Int)).Value = Val(TB_CostoUnit20.Text)
            conex1.Parameters.Add(New SqlParameter("@Costo_Total", SqlDbType.Int)).Value = Val(TB_CostoTotal20.Text)
            conex1.Parameters.Add(New SqlParameter("@Act_Transferencia", SqlDbType.NChar, 2)).Value = "20"
            conex1.CommandText = Insar20
            conex1.ExecuteNonQuery()
            Me.SqlConnection1.Close()
        Catch es As Exception
            MsgBox(es.ToString)
        End Try
    End Sub
    Sub Eliminar_Art1()
        Try
            Me.SqlConnection1.Open()
            Dim sql_elimina_art1 As New SqlCommand
            Dim sqldr_elimina_art1 As SqlDataReader
            Dim Datos_Art1 As String = ("DELETE  FROM  Patrimonio  WHERE  Patrimonio.Folio = '" & CB_Folio.Text & "'" & "and Act = '" & 1 & "'")
            Dim Conex1 As New SqlClient.SqlCommand(Datos_Art1, Me.SqlConnection1)
            sqldr_elimina_art1 = Conex1.ExecuteReader()
            Me.SqlConnection1.Close()
        Catch es As Exception
            MsgBox(es.ToString)
        End Try
    End Sub
    Sub Eliminar_Art2()
        Try
            Me.SqlConnection1.Open()
            Dim sql_elimina_art2 As New SqlCommand
            Dim sqldr_elimina_art2 As SqlDataReader
            Dim Datos_Art2 As String = ("DELETE FROM  Patrimonio  WHERE  Patrimonio.Folio = '" & CB_Folio.Text & "'" & "and Act='" & 2 & "'")
            Dim Conex2 As New SqlClient.SqlCommand(Datos_Art2, Me.SqlConnection1)
            sqldr_elimina_art2 = Conex2.ExecuteReader()
            Me.SqlConnection1.Close()
        Catch es As Exception
            MsgBox(es.ToString)
        End Try
    End Sub
    Sub Eliminar_Art3()
        Try
            Me.SqlConnection1.Open()
            Dim sql_elimina_art3 As New SqlCommand
            Dim sqldr_elimina_art3 As SqlDataReader
            Dim Datos_Art3 As String = ("DELETE FROM  Patrimonio  WHERE  Patrimonio.Folio = '" & CB_Folio.Text & "'" & "and Act='" & 3 & "'")
            Dim Conex3 As New SqlClient.SqlCommand(Datos_Art3, Me.SqlConnection1)
            sqldr_elimina_art3 = Conex3.ExecuteReader()
            Me.SqlConnection1.Close()
        Catch es As Exception
            MsgBox(es.ToString)
        End Try
    End Sub
    Sub Eliminar_Art4()
        Try
            Me.SqlConnection1.Open()
            Dim sql_elimina_art4 As New SqlCommand
            Dim sqldr_elimina_art4 As SqlDataReader
            Dim Datos_Art4 As String = ("DELETE FROM  Patrimonio  WHERE  Patrimonio.Folio = '" & CB_Folio.Text & "'" & "and Act='" & 4 & "'")
            Dim Conex4 As New SqlClient.SqlCommand(Datos_Art4, Me.SqlConnection1)
            sqldr_elimina_art4 = Conex4.ExecuteReader()
            Me.SqlConnection1.Close()
        Catch es As Exception
            MsgBox(es.ToString)
        End Try
    End Sub
    Sub Eliminar_Art5()
        Try
            Me.SqlConnection1.Open()
            Dim sql_elimina_art5 As New SqlCommand
            Dim sqldr_elimina_art5 As SqlDataReader
            Dim Datos_Art5 As String = ("DELETE FROM  Patrimonio  WHERE  Patrimonio.Folio = '" & CB_Folio.Text & "'" & "and Act='" & 5 & "'")
            Dim Conex5 As New SqlClient.SqlCommand(Datos_Art5, Me.SqlConnection1)
            sqldr_elimina_art5 = Conex5.ExecuteReader()
            Me.SqlConnection1.Close()
        Catch es As Exception
            MsgBox(es.ToString)
        End Try
    End Sub
    Sub Eliminar_Art6()
        Try
            Me.SqlConnection1.Open()
            Dim sql_elimina_art6 As New SqlCommand
            Dim sqldr_elimina_art6 As SqlDataReader
            Dim Datos_Art6 As String = ("DELETE FROM  Patrimonio  WHERE  Patrimonio.Folio = '" & CB_Folio.Text & "'" & "and Act='" & 6 & "'")
            Dim Conex6 As New SqlClient.SqlCommand(Datos_Art6, Me.SqlConnection1)
            sqldr_elimina_art6 = Conex6.ExecuteReader()
            Me.SqlConnection1.Close()
        Catch es As Exception
            MsgBox(es.ToString)
        End Try
    End Sub
    Sub Eliminar_Art7()
        Try
            Me.SqlConnection1.Open()
            Dim sql_elimina_art7 As New SqlCommand
            Dim sqldr_elimina_art7 As SqlDataReader
            Dim Datos_Art7 As String = ("DELETE FROM  Patrimonio  WHERE  Patrimonio.Folio = '" & CB_Folio.Text & "'" & "and Act='" & 7 & "'")
            Dim Conex7 As New SqlClient.SqlCommand(Datos_Art7, Me.SqlConnection1)
            sqldr_elimina_art7 = Conex7.ExecuteReader()
            Me.SqlConnection1.Close()
        Catch es As Exception
            MsgBox(es.ToString)
        End Try
    End Sub
    Sub Eliminar_Art8()
        Try
            Me.SqlConnection1.Open()
            Dim sql_elimina_art8 As New SqlCommand
            Dim sqldr_elimina_art8 As SqlDataReader
            Dim Datos_Art8 As String = ("DELETE FROM  Patrimonio  WHERE  Patrimonio.Folio = '" & CB_Folio.Text & "'" & "and Act='" & 8 & "'")
            Dim Conex8 As New SqlClient.SqlCommand(Datos_Art8, Me.SqlConnection1)
            sqldr_elimina_art8 = Conex8.ExecuteReader()
            Me.SqlConnection1.Close()
        Catch es As Exception
            MsgBox(es.ToString)
        End Try
    End Sub
    Sub Eliminar_Art9()
        Try
            Me.SqlConnection1.Open()
            Dim sql_elimina_art9 As New SqlCommand
            Dim sqldr_elimina_art9 As SqlDataReader
            Dim Datos_Art9 As String = ("DELETE FROM  Patrimonio  WHERE  Patrimonio.Folio = '" & CB_Folio.Text & "'" & "and Act='" & 9 & "'")
            Dim Conex9 As New SqlClient.SqlCommand(Datos_Art9, Me.SqlConnection1)
            sqldr_elimina_art9 = Conex9.ExecuteReader()
            Me.SqlConnection1.Close()
        Catch es As Exception
            MsgBox(es.ToString)
        End Try
    End Sub
    Sub Eliminar_Art10()
        Try
            Me.SqlConnection1.Open()
            Dim sql_elimina_art10 As New SqlCommand
            Dim sqldr_elimina_art10 As SqlDataReader
            Dim Datos_Art10 As String = ("DELETE FROM  Patrimonio  WHERE  Patrimonio.Folio = '" & CB_Folio.Text & "'" & "and Act='" & 10 & "'")
            Dim Conex10 As New SqlClient.SqlCommand(Datos_Art10, Me.SqlConnection1)
            sqldr_elimina_art10 = Conex10.ExecuteReader()
            Me.SqlConnection1.Close()
        Catch es As Exception
            MsgBox(es.ToString)
        End Try
    End Sub
    Sub Eliminar_Art11()
        Try
            Me.SqlConnection1.Open()
            Dim sql_elimina_art11 As New SqlCommand
            Dim sqldr_elimina_art11 As SqlDataReader
            Dim Datos_Art11 As String = ("DELETE FROM  Patrimonio  WHERE  Patrimonio.Folio = '" & CB_Folio.Text & "'" & "and Act='" & 11 & "'")
            Dim Conex11 As New SqlClient.SqlCommand(Datos_Art11, Me.SqlConnection1)
            sqldr_elimina_art11 = Conex11.ExecuteReader()
            Me.SqlConnection1.Close()
        Catch es As Exception
            MsgBox(es.ToString)
        End Try
    End Sub
    Sub Eliminar_Art12()
        Try
            Me.SqlConnection1.Open()
            Dim sql_elimina_art12 As New SqlCommand
            Dim sqldr_elimina_art12 As SqlDataReader
            Dim Datos_Art12 As String = ("DELETE FROM  Patrimonio  WHERE  Patrimonio.Folio = '" & CB_Folio.Text & "'" & "and Act='" & 12 & "'")
            Dim Conex12 As New SqlClient.SqlCommand(Datos_Art12, Me.SqlConnection1)
            sqldr_elimina_art12 = Conex12.ExecuteReader()
            Me.SqlConnection1.Close()
        Catch es As Exception
            MsgBox(es.ToString)
        End Try
    End Sub
    Sub Eliminar_Art13()
        Try
            Me.SqlConnection1.Open()
            Dim sql_elimina_art13 As New SqlCommand
            Dim sqldr_elimina_art13 As SqlDataReader
            Dim Datos_Art13 As String = ("DELETE FROM  Patrimonio  WHERE  Patrimonio.Folio = '" & CB_Folio.Text & "'" & "and Act='" & 13 & "'")
            Dim Conex13 As New SqlClient.SqlCommand(Datos_Art13, Me.SqlConnection1)
            sqldr_elimina_art13 = Conex13.ExecuteReader()
            Me.SqlConnection1.Close()
        Catch es As Exception
            MsgBox(es.ToString)
        End Try
    End Sub
    Sub Eliminar_Art14()
        Try
            Me.SqlConnection1.Open()
            Dim sql_elimina_art14 As New SqlCommand
            Dim sqldr_elimina_art14 As SqlDataReader
            Dim Datos_Art14 As String = ("DELETE FROM  Patrimonio  WHERE  Patrimonio.Folio = '" & CB_Folio.Text & "'" & "and Act='" & 14 & "'")
            Dim Conex14 As New SqlClient.SqlCommand(Datos_Art14, Me.SqlConnection1)
            sqldr_elimina_art14 = Conex14.ExecuteReader()
            Me.SqlConnection1.Close()
        Catch es As Exception
            MsgBox(es.ToString)
        End Try
    End Sub
    Sub Eliminar_Art15()
        Try
            Me.SqlConnection1.Open()
            Dim sql_elimina_art15 As New SqlCommand
            Dim sqldr_elimina_art15 As SqlDataReader
            Dim Datos_Art15 As String = ("DELETE FROM  Patrimonio  WHERE  Patrimonio.Folio = '" & CB_Folio.Text & "'" & "and Act='" & 15 & "'")
            Dim Conex15 As New SqlClient.SqlCommand(Datos_Art15, Me.SqlConnection1)
            sqldr_elimina_art15 = Conex15.ExecuteReader()
            Me.SqlConnection1.Close()
        Catch es As Exception
            MsgBox(es.ToString)
        End Try
    End Sub
    Sub Eliminar_Art16()
        Try
            Me.SqlConnection1.Open()
            Dim sql_elimina_art16 As New SqlCommand
            Dim sqldr_elimina_art16 As SqlDataReader
            Dim Datos_Art16 As String = ("DELETE FROM  Patrimonio  WHERE  Patrimonio.Folio = '" & CB_Folio.Text & "'" & "and Act='" & 16 & "'")
            Dim Conex16 As New SqlClient.SqlCommand(Datos_Art16, Me.SqlConnection1)
            sqldr_elimina_art16 = Conex16.ExecuteReader()
            Me.SqlConnection1.Close()
        Catch es As Exception
            MsgBox(es.ToString)
        End Try
    End Sub
    Sub Eliminar_Art17()
        Try
            Me.SqlConnection1.Open()
            Dim sql_elimina_art17 As New SqlCommand
            Dim sqldr_elimina_art17 As SqlDataReader
            Dim Datos_Art17 As String = ("DELETE FROM  Patrimonio  WHERE  Patrimonio.Folio = '" & CB_Folio.Text & "'" & "and Act='" & 17 & "'")
            Dim Conex17 As New SqlClient.SqlCommand(Datos_Art17, Me.SqlConnection1)
            sqldr_elimina_art17 = Conex17.ExecuteReader()
            Me.SqlConnection1.Close()
        Catch es As Exception
            MsgBox(es.ToString)
        End Try
    End Sub
    Sub Eliminar_Art18()
        Try
            Me.SqlConnection1.Open()
            Dim sql_elimina_art18 As New SqlCommand
            Dim sqldr_elimina_art18 As SqlDataReader
            Dim Datos_Art18 As String = ("DELETE FROM  Patrimonio  WHERE  Patrimonio.Folio = '" & CB_Folio.Text & "'" & "and Act='" & 18 & "'")
            Dim Conex18 As New SqlClient.SqlCommand(Datos_Art18, Me.SqlConnection1)
            sqldr_elimina_art18 = Conex18.ExecuteReader()
            Me.SqlConnection1.Close()
        Catch es As Exception
            MsgBox(es.ToString)
        End Try
    End Sub
    Sub Eliminar_Art19()
        Try
            Me.SqlConnection1.Open()
            Dim sql_elimina_art19 As New SqlCommand
            Dim sqldr_elimina_art19 As SqlDataReader
            Dim Datos_Art19 As String = ("DELETE FROM  Patrimonio  WHERE  Patrimonio.Folio = '" & CB_Folio.Text & "'" & "and Act='" & 19 & "'")
            Dim Conex19 As New SqlClient.SqlCommand(Datos_Art19, Me.SqlConnection1)
            sqldr_elimina_art19 = Conex19.ExecuteReader()
            Me.SqlConnection1.Close()
        Catch es As Exception
            MsgBox(es.ToString)
        End Try
    End Sub
    Sub Eliminar_Art20()
        Try
            Me.SqlConnection1.Open()
            Dim sql_elimina_art20 As New SqlCommand
            Dim sqldr_elimina_art20 As SqlDataReader
            Dim Datos_Art20 As String = ("DELETE FROM  Patrimonio  WHERE  Patrimonio.Folio = '" & CB_Folio.Text & "'" & "and Act='" & 20 & "'")
            Dim Conex20 As New SqlClient.SqlCommand(Datos_Art20, Me.SqlConnection1)
            sqldr_elimina_art20 = Conex20.ExecuteReader()
            Me.SqlConnection1.Close()
        Catch es As Exception
            MsgBox(es.ToString)
        End Try
    End Sub
    Private Sub ChB_Status1_CheckedChanged(sender As Object, e As EventArgs) Handles ChB_Status1.CheckedChanged
        If ChB_Status1.Checked = True Then
            st1 = 1
        Else
            st1 = 0
        End If
    End Sub
    Private Sub ChB_Status2_CheckedChanged(sender As Object, e As EventArgs) Handles ChB_Status2.CheckedChanged
        If ChB_Status2.Checked = True Then
            st2 = 1
        Else
            st2 = 0
        End If
    End Sub
    Private Sub ChB_Status3_CheckedChanged(sender As Object, e As EventArgs) Handles ChB_Status3.CheckedChanged
        If ChB_Status3.Checked = True Then
            st3 = 1
        Else
            st3 = 0
        End If
    End Sub
    Private Sub ChB_Status4_CheckedChanged(sender As Object, e As EventArgs) Handles ChB_Status4.CheckedChanged
        If ChB_Status4.Checked = True Then
            st4 = 1
        Else
            st4 = 0
        End If
    End Sub
    Private Sub ChB_Status5_CheckedChanged(sender As Object, e As EventArgs) Handles ChB_Status5.CheckedChanged
        If ChB_Status5.Checked = True Then
            st5 = 1
        Else
            st5 = 0
        End If
    End Sub
    Private Sub ChB_Status6_CheckedChanged(sender As Object, e As EventArgs) Handles ChB_Status6.CheckedChanged
        If ChB_Status6.Checked = True Then
            st6 = 1
        Else
            st6 = 0
        End If
    End Sub
    Private Sub ChB_Status7_CheckedChanged(sender As Object, e As EventArgs) Handles ChB_Status7.CheckedChanged
        If ChB_Status7.Checked = True Then
            st7 = 1
        Else
            st7 = 0
        End If
    End Sub
    Private Sub ChB_Status8_CheckedChanged(sender As Object, e As EventArgs) Handles ChB_Status8.CheckedChanged
        If ChB_Status8.Checked = True Then
            st8 = 1
        Else
            st8 = 0
        End If
    End Sub
    Private Sub ChB_Status9_CheckedChanged(sender As Object, e As EventArgs) Handles ChB_Status9.CheckedChanged
        If ChB_Status9.Checked = True Then
            st9 = 1
        Else
            st9 = 0
        End If
    End Sub
    Private Sub ChB_Status10_CheckedChanged(sender As Object, e As EventArgs) Handles ChB_Status10.CheckedChanged
        If ChB_Status10.Checked = True Then
            st10 = 1
        Else
            st10 = 0
        End If
    End Sub
    Private Sub ChB_Status11_CheckedChanged(sender As Object, e As EventArgs) Handles ChB_Status11.CheckedChanged
        If ChB_Status11.Checked = True Then
            st11 = 1
        Else
            st11 = 0
        End If
    End Sub
    Private Sub ChB_Status12_CheckedChanged(sender As Object, e As EventArgs) Handles ChB_Status12.CheckedChanged
        If ChB_Status12.Checked = True Then
            st12 = 1
        Else
            st12 = 0
        End If
    End Sub
    Private Sub ChB_Status13_CheckedChanged(sender As Object, e As EventArgs) Handles ChB_Status13.CheckedChanged
        If ChB_Status13.Checked = True Then
            st13 = 1
        Else
            st13 = 0
        End If
    End Sub
    Private Sub ChB_Status14_CheckedChanged(sender As Object, e As EventArgs) Handles ChB_Status14.CheckedChanged
        If ChB_Status14.Checked = True Then
            st14 = 1
        Else
            st14 = 0
        End If
    End Sub
    Private Sub ChB_Status15_CheckedChanged(sender As Object, e As EventArgs) Handles ChB_Status15.CheckedChanged
        If ChB_Status15.Checked = True Then
            st15 = 1
        Else
            st15 = 0
        End If
    End Sub
    Private Sub ChB_Status16_CheckedChanged(sender As Object, e As EventArgs) Handles ChB_Status16.CheckedChanged
        If ChB_Status16.Checked = True Then
            st16 = 1
        Else
            st16 = 0
        End If
    End Sub
    Private Sub ChB_Status17_CheckedChanged(sender As Object, e As EventArgs) Handles ChB_Status17.CheckedChanged
        If ChB_Status17.Checked = True Then
            st17 = 1
        Else
            st17 = 0
        End If
    End Sub
    Private Sub ChB_Status18_CheckedChanged(sender As Object, e As EventArgs) Handles ChB_Status18.CheckedChanged
        If ChB_Status18.Checked = True Then
            st18 = 1
        Else
            st18 = 0
        End If
    End Sub
    Private Sub ChB_Status19_CheckedChanged(sender As Object, e As EventArgs) Handles ChB_Status19.CheckedChanged
        If ChB_Status19.Checked = True Then
            st19 = 1
        Else
            st19 = 0
        End If
    End Sub
    Private Sub ChB_Status20_CheckedChanged(sender As Object, e As EventArgs) Handles ChB_Status20.CheckedChanged
        If ChB_Status20.Checked = True Then
            st20 = 1
        Else
            st20 = 0
        End If
    End Sub
    Sub validar_checked_transferencia_SI()
        If st1 = 1 Or st2 = 1 Or st3 = 1 Or st4 = 1 Or st5 = 1 Or st6 = 1 Or st7 = 1 Or st8 = 1 Or st9 = 1 Or st10 = 1 Or st11 = 1 Or st12 = 1 Or st13 = 1 Or st14 = 1 Or st15 = 1 Or st16 = 1 Or st17 = 1 Or st18 = 1 Or st19 = 1 Or st20 = 1 Then
            MsgBox("Transferencia realizada correctamentemente.!")
        End If
    End Sub
    Sub validar_checked_transferencia_NO()
        If st1 = 0 And st2 = 0 And st3 = 0 And st4 = 0 And st5 = 0 And st6 = 0 And st7 = 0 And st8 = 0 And st9 = 0 And st10 = 0 And st11 = 0 And st12 = 0 And st13 = 0 And st14 = 0 And st15 = 0 And st16 = 0 And st17 = 0 And st18 = 0 And st19 = 0 And st20 = 0 Then
            MsgBox("No hay elementos marcadaos para transferir.!")
            Return

        End If
    End Sub

    Private Sub Btn_Transferir_Equipo_Click(sender As Object, e As EventArgs) Handles Btn_Transferir_Equipo.Click
        Dim Autoriza As String
        Autoriza = MsgBox("Esta seguro de realizar la transferencia?", MsgBoxStyle.YesNo + MsgBoxStyle.Information, "Guardar")
        If Autoriza = vbYes Then
            If st1 = 1 Then
                Call Transferencia1()
                Call Eliminar_Art1()
            End If
            If st2 = 1 Then
                Call Transferencia2()
                Call Eliminar_Art2()
            End If
            If st3 = 1 Then
                Call Transferencia3()
                Call Eliminar_Art3()
            End If
            If st4 = 1 Then
                Call Transferencia4()
                Call Eliminar_Art4()
            End If
            If st5 = 1 Then
                Call Transferencia5()
                Call Eliminar_Art5()
            End If
            If st6 = 1 Then
                Call Transferencia6()
                Call Eliminar_Art6()
            End If
            If st7 = 1 Then
                Call Transferencia7()
                Call Eliminar_Art7()
            End If
            If st8 = 1 Then
                Call Transferencia8()
                Call Eliminar_Art8()
            End If
            If st9 = 1 Then
                Call Transferencia9()
                Call Eliminar_Art9()
            End If
            If st10 = 1 Then
                Call Transferencia10()
                Call Eliminar_Art10()
            End If
            If st11 = 1 Then
                Call Transferencia11()
                Call Eliminar_Art11()
            End If
            If st12 = 1 Then
                Call Transferencia12()
                Call Eliminar_Art12()
            End If
            If st13 = 1 Then
                Call Transferencia13()
                Call Eliminar_Art13()
            End If
            If st14 = 1 Then
                Call Transferencia14()
                Call Eliminar_Art14()
            End If
            If st15 = 1 Then
                Call Transferencia15()
                Call Eliminar_Art15()
            End If
            If st16 = 1 Then
                Call Transferencia16()
                Call Eliminar_Art16()
            End If
            If st17 = 1 Then
                Call Transferencia17()
                Call Eliminar_Art17()
            End If
            If st18 = 1 Then
                Call Transferencia18()
                Call Eliminar_Art18()
            End If
            If st19 = 1 Then
                Call Transferencia19()
                Call Eliminar_Art19()
            End If
            If st20 = 1 Then
                Call Transferencia20()
                Call Eliminar_Art20()
            End If
            Call validar_checked_transferencia_SI()
            Call validar_checked_transferencia_NO()
            Call limpiar_formulario()
        End If
    End Sub
    Sub limpiar_formulario()

        TB_CI_1.Clear()
        TB_CI_2.Clear()
        TB_CI_3.Clear()
        TB_CI_4.Clear()
        TB_CI_5.Clear()
        TB_CI_6.Clear()
        TB_CI_7.Clear()
        TB_CI_8.Clear()
        TB_CI_9.Clear()
        TB_CI_10.Clear()
        TB_CI_11.Clear()
        TB_CI_12.Clear()
        TB_CI_13.Clear()
        TB_CI_14.Clear()
        TB_CI_15.Clear()
        TB_CI_16.Clear()
        TB_CI_17.Clear()
        TB_CI_18.Clear()
        TB_CI_19.Clear()
        TB_CI_19.Clear()

        TB_CAT1.Clear()
        TB_CAT2.Clear()
        TB_CAT3.Clear()
        TB_CAT4.Clear()
        TB_CAT5.Clear()
        TB_CAT6.Clear()
        TB_CAT7.Clear()
        TB_CAT8.Clear()
        TB_CAT9.Clear()
        TB_CAT10.Clear()
        TB_CAT11.Clear()
        TB_CAT12.Clear()
        TB_CAT13.Clear()
        TB_CAT14.Clear()
        TB_CAT15.Clear()
        TB_CAT16.Clear()
        TB_CAT17.Clear()
        TB_CAT18.Clear()
        TB_CAT19.Clear()
        TB_CAT20.Clear()


        TB_Cve_A1.Clear()
        TB_Cve_A2.Clear()
        TB_Cve_A3.Clear()
        TB_Cve_A4.Clear()
        TB_Cve_A5.Clear()
        TB_Cve_A6.Clear()
        TB_Cve_A7.Clear()
        TB_Cve_A8.Clear()
        TB_Cve_A9.Clear()
        TB_Cve_A10.Clear()
        TB_Cve_A11.Clear()
        TB_Cve_A12.Clear()
        TB_Cve_A13.Clear()
        TB_Cve_A14.Clear()
        TB_Cve_A15.Clear()
        TB_Cve_A16.Clear()
        TB_Cve_A17.Clear()
        TB_Cve_A18.Clear()
        TB_Cve_A19.Clear()
        TB_Cve_A20.Clear()


        TB_Art1.Clear()
        TB_Art2.Clear()
        TB_Art3.Clear()
        TB_Art4.Clear()
        TB_Art5.Clear()
        TB_Art6.Clear()
        TB_Art7.Clear()
        TB_Art8.Clear()
        TB_Art9.Clear()
        TB_Art10.Clear()
        TB_Art11.Clear()
        TB_Art12.Clear()
        TB_Art13.Clear()
        TB_Art14.Clear()
        TB_Art15.Clear()
        TB_Art16.Clear()
        TB_Art17.Clear()
        TB_Art18.Clear()
        TB_Art19.Clear()
        TB_Art20.Clear()

        TB_Marca1.Clear()
        TB_Marca2.Clear()
        TB_Marca3.Clear()
        TB_Marca4.Clear()
        TB_Marca5.Clear()
        TB_Marca6.Clear()
        TB_Marca7.Clear()
        TB_Marca8.Clear()
        TB_Marca9.Clear()
        TB_Marca10.Clear()
        TB_Marca11.Clear()
        TB_Marca12.Clear()
        TB_Marca13.Clear()
        TB_Marca14.Clear()
        TB_Marca15.Clear()
        TB_Marca16.Clear()
        TB_Marca17.Clear()
        TB_Marca18.Clear()
        TB_Marca19.Clear()
        TB_Marca20.Clear()

        'TB_Marca1.Enabled = False
        'TB_Marca2.Enabled = False
        'TB_Marca3.Enabled = False
        'TB_Marca4.Enabled = False
        'TB_Marca5.Enabled = False
        'TB_Marca6.Enabled = False
        'TB_Marca7.Enabled = False
        'TB_Marca8.Enabled = False
        'TB_Marca9.Enabled = False
        'TB_Marca10.Enabled = False

        TB_Modelo1.Clear()
        TB_Modelo2.Clear()
        TB_Modelo3.Clear()
        TB_Modelo4.Clear()
        TB_Modelo5.Clear()
        TB_Modelo6.Clear()
        TB_Modelo7.Clear()
        TB_Modelo8.Clear()
        TB_Modelo9.Clear()
        TB_Modelo10.Clear()
        TB_Modelo11.Clear()
        TB_Modelo12.Clear()
        TB_Modelo13.Clear()
        TB_Modelo14.Clear()
        TB_Modelo15.Clear()
        TB_Modelo16.Clear()
        TB_Modelo17.Clear()
        TB_Modelo18.Clear()
        TB_Modelo19.Clear()
        TB_Modelo20.Clear()

        'TB_Modelo1.Enabled = False
        'TB_Modelo2.Enabled = False
        'TB_Modelo3.Enabled = False
        'TB_Modelo4.Enabled = False
        'TB_Modelo5.Enabled = False
        'TB_Modelo6.Enabled = False
        'TB_Modelo7.Enabled = False
        'TB_Modelo8.Enabled = False
        'TB_Modelo9.Enabled = False
        'TB_Modelo10.Enabled = False

        TB_Serie1.Clear()
        TB_Serie2.Clear()
        TB_Serie3.Clear()
        TB_Serie4.Clear()
        TB_Serie5.Clear()
        TB_Serie6.Clear()
        TB_Serie7.Clear()
        TB_Serie8.Clear()
        TB_Serie9.Clear()
        TB_Serie10.Clear()

        TB_Serie11.Clear()
        TB_Serie12.Clear()
        TB_Serie13.Clear()
        TB_Serie14.Clear()
        TB_Serie15.Clear()
        TB_Serie16.Clear()
        TB_Serie17.Clear()
        TB_Serie18.Clear()
        TB_Serie19.Clear()
        TB_Serie20.Clear()
        'TB_Serie1.Enabled = False
        'TB_Serie2.Enabled = False
        'TB_Serie3.Enabled = False
        'TB_Serie4.Enabled = False
        'TB_Serie5.Enabled = False
        'TB_Serie6.Enabled = False
        'TB_Serie7.Enabled = False
        'TB_Serie8.Enabled = False
        'TB_Serie9.Enabled = False
        'TB_Serie10.Enabled = False

        TB_NoFactura1.Clear()
        TB_NoFactura2.Clear()
        TB_NoFactura3.Clear()
        TB_NoFactura4.Clear()
        TB_NoFactura5.Clear()
        TB_NoFactura6.Clear()
        TB_NoFactura7.Clear()
        TB_NoFactura8.Clear()
        TB_NoFactura9.Clear()
        TB_NoFactura10.Clear()
        TB_NoFactura11.Clear()
        TB_NoFactura12.Clear()
        TB_NoFactura13.Clear()
        TB_NoFactura14.Clear()
        TB_NoFactura15.Clear()
        TB_NoFactura16.Clear()
        TB_NoFactura17.Clear()
        TB_NoFactura18.Clear()
        TB_NoFactura19.Clear()
        TB_NoFactura20.Clear()

        'TB_NoFactura1.Enabled = False
        'TB_NoFactura2.Enabled = False
        'TB_NoFactura3.Enabled = False
        'TB_NoFactura4.Enabled = False
        'TB_NoFactura5.Enabled = False
        'TB_NoFactura6.Enabled = False
        'TB_NoFactura7.Enabled = False
        'TB_NoFactura8.Enabled = False
        'TB_NoFactura9.Enabled = False
        'TB_NoFactura10.Enabled = False

        'Me.NUpDown_CanArt1.Value = "0"
        'Me.NUpDown_CanArt2.Value = "0"
        'Me.NUpDown_CanArt3.Value = "0"
        'Me.NUpDown_CanArt4.Value = "0"
        'Me.NUpDown_CanArt5.Value = "0"
        'Me.NUpDown_CanArt6.Value = "0"
        'Me.NUpDown_CanArt7.Value = "0"
        'Me.NUpDown_CanArt8.Value = "0"
        'Me.NUpDown_CanArt9.Value = "0"
        'Me.NUpDown_CanArt10.Value = "0"

        'NUpDown_CanArt1.Enabled = False
        ' NUpDown_CanArt2.Enabled = False
        ' NUpDown_CanArt3.Enabled = False
        ' NUpDown_CanArt4.Enabled = False
        ' NUpDown_CanArt5.Enabled = False
        ' NUpDown_CanArt6.Enabled = False
        ' NUpDown_CanArt7.Enabled = False
        ' NUpDown_CanArt8.Enabled = False
        ' NUpDown_CanArt9.Enabled = False
        'NUpDown_CanArt10.Enabled = False

        TB_CostoUnit1.Clear()
        TB_CostoUnit2.Clear()
        TB_CostoUnit3.Clear()
        TB_CostoUnit4.Clear()
        TB_CostoUnit5.Clear()
        TB_CostoUnit6.Clear()
        TB_CostoUnit7.Clear()
        TB_CostoUnit8.Clear()
        TB_CostoUnit9.Clear()
        TB_CostoUnit10.Clear()
        TB_CostoUnit11.Clear()
        TB_CostoUnit12.Clear()
        TB_CostoUnit13.Clear()
        TB_CostoUnit14.Clear()
        TB_CostoUnit15.Clear()
        TB_CostoUnit16.Clear()
        TB_CostoUnit17.Clear()
        TB_CostoUnit18.Clear()
        TB_CostoUnit19.Clear()
        TB_CostoUnit20.Clear()

        'TB_CostoUnit1.Enabled = False
        'TB_CostoUnit2.Enabled = False
        'TB_CostoUnit3.Enabled = False
        'TB_CostoUnit4.Enabled = False
        'TB_CostoUnit5.Enabled = False
        'TB_CostoUnit6.Enabled = False
        'TB_CostoUnit7.Enabled = False
        'TB_CostoUnit8.Enabled = False
        'TB_CostoUnit9.Enabled = False
        'TB_CostoUnit10.Enabled = False


        TB_CostoTotal1.Clear()
        TB_CostoTotal2.Clear()
        TB_CostoTotal3.Clear()
        TB_CostoTotal4.Clear()
        TB_CostoTotal5.Clear()
        TB_CostoTotal6.Clear()
        TB_CostoTotal7.Clear()
        TB_CostoTotal8.Clear()
        TB_CostoTotal9.Clear()
        TB_CostoTotal10.Clear()
        TB_CostoTotal11.Clear()
        TB_CostoTotal12.Clear()
        TB_CostoTotal13.Clear()
        TB_CostoTotal14.Clear()
        TB_CostoTotal15.Clear()
        TB_CostoTotal16.Clear()
        TB_CostoTotal17.Clear()
        TB_CostoTotal18.Clear()
        TB_CostoTotal19.Clear()
        TB_CostoTotal20.Clear()
        'TB_CostoTotal1.Enabled = False
        'TB_CostoTotal2.Enabled = False
        'TB_CostoTotal3.Enabled = False
        'TB_CostoTotal4.Enabled = False
        'TB_CostoTotal5.Enabled = False
        'TB_CostoTotal6.Enabled = False
        'TB_CostoTotal7.Enabled = False
        'TB_CostoTotal8.Enabled = False
        'TB_CostoTotal9.Enabled = False
        'TB_CostoTotal10.Enabled = False

        ChB_Status1.Checked = False
        ChB_Status2.Checked = False
        ChB_Status3.Checked = False
        ChB_Status4.Checked = False
        ChB_Status5.Checked = False
        ChB_Status6.Checked = False
        ChB_Status7.Checked = False
        ChB_Status8.Checked = False
        ChB_Status9.Checked = False
        ChB_Status10.Checked = False
        ChB_Status11.Checked = False
        ChB_Status12.Checked = False
        ChB_Status13.Checked = False
        ChB_Status14.Checked = False
        ChB_Status15.Checked = False
        ChB_Status16.Checked = False
        ChB_Status17.Checked = False
        ChB_Status18.Checked = False
        ChB_Status19.Checked = False
        ChB_Status20.Checked = False
    End Sub

    
End Class
