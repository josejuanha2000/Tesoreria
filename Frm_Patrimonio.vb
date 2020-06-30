Imports System.Data
Imports System.IO
Imports System.Text
Imports System.Data.OleDb
Imports System.Data.Odbc
Imports System.Data.SqlClient
Public Class Frm_Patrimonio
    Inherits System.Windows.Forms.Form
    Dim cbprod1 As New SqlCommand
    Dim cbprod2 As New SqlCommand
    Dim cbprod3 As New SqlCommand
    Dim daproducto1 As SqlDataReader
    Dim daproducto2 As SqlDataReader
    Dim cve_categoria As String
    Dim cbdepartamento As New SqlCommand
    Dim dadepartamento As SqlDataReader

    Dim CTO_TOTAL_SIN_IVA1 As Integer = 0
    Dim CALCULAR_IVA1 As Integer = 0
    Dim COSTO_TOTAL1 As Integer = 0

    Dim CTO_TOTAL_SIN_IVA2 As Integer = 0
    Dim CALCULAR_IVA2 As Integer = 0
    Dim COSTO_TOTAL2 As Integer = 0

    Dim CTO_TOTAL_SIN_IVA3 As Integer = 0
    Dim CALCULAR_IVA3 As Integer = 0
    Dim COSTO_TOTAL3 As Integer = 0

    Dim CTO_TOTAL_SIN_IVA4 As Integer = 0
    Dim CALCULAR_IVA4 As Integer = 0
    Dim COSTO_TOTAL4 As Integer = 0

    Dim CTO_TOTAL_SIN_IVA5 As Integer = 0
    Dim CALCULAR_IVA5 As Integer = 0
    Dim COSTO_TOTAL5 As Integer = 0

    Dim CTO_TOTAL_SIN_IVA6 As Integer = 0
    Dim CALCULAR_IVA6 As Integer = 0
    Dim COSTO_TOTAL6 As Integer = 0
    
    Dim CTO_TOTAL_SIN_IVA7 As Integer = 0
    Dim CALCULAR_IVA7 As Integer = 0
    Dim COSTO_TOTAL7 As Integer = 0

    Dim CTO_TOTAL_SIN_IVA8 As Integer = 0
    Dim CALCULAR_IVA8 As Integer = 0
    Dim COSTO_TOTAL8 As Integer = 0

    Dim CTO_TOTAL_SIN_IVA9 As Integer = 0
    Dim CALCULAR_IVA9 As Integer = 0
    Dim COSTO_TOTAL9 As Integer = 0

    Dim CTO_TOTAL_SIN_IVA10 As Integer = 0
    Dim CALCULAR_IVA10 As Integer = 0
    Dim COSTO_TOTAL10 As Integer = 0

    Dim CTO_TOTAL_SIN_IVA11 As Integer = 0
    Dim CALCULAR_IVA11 As Integer = 0
    Dim COSTO_TOTAL11 As Integer = 0

    Dim CTO_TOTAL_SIN_IVA12 As Integer = 0
    Dim CALCULAR_IVA12 As Integer = 0
    Dim COSTO_TOTAL12 As Integer = 0

    Dim CTO_TOTAL_SIN_IVA13 As Integer = 0
    Dim CALCULAR_IVA13 As Integer = 0
    Dim COSTO_TOTAL13 As Integer = 0

    Dim CTO_TOTAL_SIN_IVA14 As Integer = 0
    Dim CALCULAR_IVA14 As Integer = 0
    Dim COSTO_TOTAL14 As Integer = 0

    Dim CTO_TOTAL_SIN_IVA15 As Integer = 0
    Dim CALCULAR_IVA15 As Integer = 0
    Dim COSTO_TOTAL15 As Integer = 0

    Dim CTO_TOTAL_SIN_IVA16 As Integer = 0
    Dim CALCULAR_IVA16 As Integer = 0
    Dim COSTO_TOTAL16 As Integer = 0

    Dim CTO_TOTAL_SIN_IVA17 As Integer = 0
    Dim CALCULAR_IVA17 As Integer = 0
    Dim COSTO_TOTAL17 As Integer = 0

    Dim CTO_TOTAL_SIN_IVA18 As Integer = 0
    Dim CALCULAR_IVA18 As Integer = 0
    Dim COSTO_TOTAL18 As Integer = 0

    Dim CTO_TOTAL_SIN_IVA19 As Integer = 0
    Dim CALCULAR_IVA19 As Integer = 0
    Dim COSTO_TOTAL19 As Integer = 0

    Dim CTO_TOTAL_SIN_IVA20 As Integer = 0
    Dim CALCULAR_IVA20 As Integer = 0
    Dim COSTO_TOTAL20 As Integer = 0

    Dim CTResponsable As New SqlCommand
    Dim DAAResponsable As SqlDataReader

    Dim CTArt1 As New SqlCommand
    Dim CTArt2 As New SqlCommand
    Dim CTArt3 As New SqlCommand
    Dim CTArt4 As New SqlCommand
    Dim CTArt5 As New SqlCommand
    Dim CTArt6 As New SqlCommand
    Dim CTArt7 As New SqlCommand
    Dim CTArt8 As New SqlCommand
    Dim CTArt9 As New SqlCommand
    Dim CTArt10 As New SqlCommand
    Dim CTArt11 As New SqlCommand
    Dim CTArt12 As New SqlCommand
    Dim CTArt13 As New SqlCommand
    Dim CTArt14 As New SqlCommand
    Dim CTArt15 As New SqlCommand
    Dim CTArt16 As New SqlCommand
    Dim CTArt17 As New SqlCommand
    Dim CTArt18 As New SqlCommand
    Dim CTArt19 As New SqlCommand
    Dim CTArt20 As New SqlCommand

    Dim CTBTArt1 As New SqlCommand
    Dim CTBTArt2 As New SqlCommand
    Dim CTBTArt3 As New SqlCommand
    Dim CTBTArt4 As New SqlCommand
    Dim CTBTArt5 As New SqlCommand
    Dim CTBTArt6 As New SqlCommand
    Dim CTBTArt7 As New SqlCommand
    Dim CTBTArt8 As New SqlCommand
    Dim CTBTArt9 As New SqlCommand
    Dim CTBTArt10 As New SqlCommand
    Dim CTBTArt11 As New SqlCommand
    Dim CTBTArt12 As New SqlCommand
    Dim CTBTArt13 As New SqlCommand
    Dim CTBTArt14 As New SqlCommand
    Dim CTBTArt15 As New SqlCommand
    Dim CTBTArt16 As New SqlCommand
    Dim CTBTArt17 As New SqlCommand
    Dim CTBTArt18 As New SqlCommand
    Dim CTBTArt19 As New SqlCommand
    Dim CTBTArt20 As New SqlCommand

    Dim DAARTICULO1 As SqlDataReader
    Dim DAARTICULO2 As SqlDataReader
    Dim DAARTICULO3 As SqlDataReader
    Dim DAARTICULO4 As SqlDataReader
    Dim DAARTICULO5 As SqlDataReader
    Dim DAARTICULO6 As SqlDataReader
    Dim DAARTICULO7 As SqlDataReader
    Dim DAARTICULO8 As SqlDataReader
    Dim DAARTICULO9 As SqlDataReader
    Dim DAARTICULO10 As SqlDataReader
    Dim DAARTICULO11 As SqlDataReader
    Dim DAARTICULO12 As SqlDataReader
    Dim DAARTICULO13 As SqlDataReader
    Dim DAARTICULO14 As SqlDataReader
    Dim DAARTICULO15 As SqlDataReader
    Dim DAARTICULO16 As SqlDataReader
    Dim DAARTICULO17 As SqlDataReader
    Dim DAARTICULO18 As SqlDataReader
    Dim DAARTICULO19 As SqlDataReader
    Dim DAARTICULO20 As SqlDataReader

    Dim mov_alta1 As Integer = 0
    Dim mov_alta2 As Integer = 0
    Dim mov_alta3 As Integer = 0
    Dim mov_alta4 As Integer = 0
    Dim mov_alta5 As Integer = 0
    Dim mov_alta6 As Integer = 0
    Dim mov_alta7 As Integer = 0
    Dim mov_alta8 As Integer = 0
    Dim mov_alta9 As Integer = 0
    Dim mov_alta10 As Integer = 0
    Dim mov_alta11 As Integer = 0
    Dim mov_alta12 As Integer = 0
    Dim mov_alta13 As Integer = 0
    Dim mov_alta14 As Integer = 0
    Dim mov_alta15 As Integer = 0
    Dim mov_alta16 As Integer = 0
    Dim mov_alta17 As Integer = 0
    Dim mov_alta18 As Integer = 0
    Dim mov_alta19 As Integer = 0
    Dim mov_alta20 As Integer = 0
    Dim SW As Integer = 0
    Public PrimerosDosCveCategoria As String
    Private Sub Frm_Patrimonio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call cargar_categoria()
        Call cargar_departamentos()
        Call buscar_No_Activo()
        Call buscar_ultimo_folio()
        'Call CALCUALR_TOTAL()
        'Call limpiar_costo_articulo()
    End Sub
    Sub buscar_ultimo_folio()
        Try
            Me.SqlConnection1.Open()
            Dim comsql As New SqlClient.SqlCommand
            comsql.Connection = Me.SqlConnection1
            comsql.CommandText = ("select top 1 * from Patrimonio order by Folio desc")
            Dim DRFolio As SqlClient.SqlDataReader
            DRFolio = comsql.ExecuteReader(CommandBehavior.CloseConnection)
            DRFolio.Read()
            TBFolio.Text = DRFolio("Folio") + 1
            DRFolio.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Me.SqlConnection1.Close()
    End Sub
    Sub buscar_No_Activo()
        Try
            Me.SqlConnection1.Open()
            Dim comsql2 As New SqlClient.SqlCommand
            comsql2.Connection = Me.SqlConnection1
            comsql2.CommandText = ("select top 1 * from Patrimonio order by No_Activo desc")
            Dim DRActivo As SqlClient.SqlDataReader
            DRActivo = comsql2.ExecuteReader(CommandBehavior.CloseConnection)
            DRActivo.Read()
            Label_Activo1.Text = DRActivo("No_Activo") + 1
            Label_Activo2.Text = Label_Activo1.Text + 1
            Label_Activo3.Text = Label_Activo2.Text + 1
            Label_Activo4.Text = Label_Activo3.Text + 1
            Label_Activo5.Text = Label_Activo4.Text + 1
            Label_Activo6.Text = Label_Activo5.Text + 1
            Label_Activo7.Text = Label_Activo6.Text + 1
            Label_Activo8.Text = Label_Activo7.Text + 1
            Label_Activo9.Text = Label_Activo8.Text + 1
            Label_Activo10.Text = Label_Activo9.Text + 1
            Label_Activo11.Text = Label_Activo10.Text + 1
            Label_Activo12.Text = Label_Activo11.Text + 1
            Label_Activo13.Text = Label_Activo12.Text + 1
            Label_Activo14.Text = Label_Activo13.Text + 1
            Label_Activo15.Text = Label_Activo14.Text + 1
            Label_Activo16.Text = Label_Activo15.Text + 1
            Label_Activo17.Text = Label_Activo16.Text + 1
            Label_Activo18.Text = Label_Activo17.Text + 1
            Label_Activo19.Text = Label_Activo18.Text + 1
            Label_Activo20.Text = Label_Activo19.Text + 1
            DRActivo.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Me.SqlConnection1.Close()
    End Sub
    Sub cargar_departamentos()
        Try
            Me.SqlConnection1.Open()
            cbdepartamento.CommandType = CommandType.Text
            cbdepartamento.CommandText = ("select  Departamento,Titular,Id  from Departamentos")
            cbdepartamento.Connection = Me.SqlConnection1
            dadepartamento = cbdepartamento.ExecuteReader()
            While dadepartamento.Read = True
                CB_Departamento.Items.Add(dadepartamento.Item(0))
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        cbdepartamento.CommandType = CommandType.StoredProcedure
        cbdepartamento.Connection = Me.SqlConnection1
        cbdepartamento.CommandText = ("Buscar_Titular_Depto")
        cbdepartamento.Parameters.Add("var_nombre_departamento", SqlDbType.NVarChar, 50)
        dadepartamento.Close()
        Me.SqlConnection1.Close()
    End Sub
    Private Sub CB_Departamento_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_Departamento.SelectedIndexChanged
        SW = 1
        Try
            Me.SqlConnection1.Open()
            cbdepartamento.Parameters("var_nombre_departamento").Value = CB_Departamento.SelectedItem.ToString
            dadepartamento = cbdepartamento.ExecuteReader()
            If dadepartamento.Read = True Then
                TB_Id.Text = CStr(dadepartamento("Id").ToString)
            End If
            'Dim cadena As String = TBCveCategoria.Text
            'PrimerosDosCveCategoria = cadena.Substring(0, 2)
            'MsgBox(PrimerosDosCveCategoria)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        dadepartamento.Close()
        Me.SqlConnection1.Close()
        Call cargar_Responsable_Equipo()

    End Sub
    Sub cargar_Responsable_Equipo()
        Try
            Me.SqlConnection1.Open()
            CB_Responsable.Items.Clear()
            CTResponsable.CommandType = CommandType.Text
            'CTArt1.CommandText = ("Select Nombre_SubCategoria, Cve_SubCategoria from SubCategorias where SubCategrias.Cve_SubCategoria ='" & TBCveCategoria.Text & "'order by Nombre_SubCategoria")
            CTResponsable.CommandText = ("Select Nombre_Empleado from Empleados where Empleados.Id_Departamento='" & TB_Id.Text & "'")
            CTResponsable.Connection = Me.SqlConnection1
            DAAResponsable = CTResponsable.ExecuteReader()
            While DAAResponsable.Read = True
                CB_Responsable.Items.Add(DAAResponsable.Item(0))
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        DAAResponsable.Close()
        Me.SqlConnection1.Close()
    End Sub
    Sub cargar_categoria()
        Try
            Me.SqlConnection1.Open()
            cbprod1.CommandType = CommandType.Text
            cbprod1.CommandText = ("select  Nombre_Categoria,Cve_Categoria  from Categorias")
            cbprod1.Connection = Me.SqlConnection1
            daproducto1 = cbprod1.ExecuteReader()
            While daproducto1.Read = True
                CBCategorias.Items.Add(daproducto1.Item(0))
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        cbprod2.CommandType = CommandType.StoredProcedure
        cbprod2.Connection = Me.SqlConnection1
        cbprod2.CommandText = ("Buscar_articulo_Patrimonio")
        cbprod2.Parameters.Add("var_nombre_categoria", SqlDbType.NChar, 50)
        daproducto1.Close()
        Me.SqlConnection1.Close()
    End Sub
    Private Sub CBCategorias_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBCategorias.SelectedIndexChanged
        Try
            Me.SqlConnection1.Open()
            cbprod2.Parameters("var_nombre_categoria").Value = CBCategorias.SelectedItem.ToString
            daproducto2 = cbprod2.ExecuteReader()
            If daproducto2.Read = True Then
                ' TextBoxPrueba.Text = CStr(daproducto("Cve_Categoria").toupper)
                TBCveCategoria.Text = CStr(daproducto2("Cve_Categoria").ToString)
            End If
            Dim cadena As String = TBCveCategoria.Text
            PrimerosDosCveCategoria = cadena.Substring(0, 2)
            'MsgBox(PrimerosDosCveCategoria)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        daproducto2.Close()
        Me.SqlConnection1.Close()
        'Call clave_categoria()
    End Sub
    Sub cargar_Art1()
        'PrimerosDosCveCategoria = "10"
        'MsgBox(PrimerosDosCveCategoria)
        Try
            Me.SqlConnection1.Open()
            CB_A1.Items.Clear()
            CTArt1.CommandType = CommandType.Text
            'CTArt1.CommandText = ("Select Nombre_SubCategoria, Cve_SubCategoria from SubCategorias where SubCategrias.Cve_SubCategoria ='" & TBCveCategoria.Text & "'order by Nombre_SubCategoria")
            CTArt1.CommandText = ("Select Nombre_SubCategoria from SubCategorias where Cve_SubCategoria like '%" + PrimerosDosCveCategoria + "%'" + "order by Nombre_SubCategoria")
            CTArt1.Connection = Me.SqlConnection1
            DAARTICULO1 = CTArt1.ExecuteReader()
            While DAARTICULO1.Read = True
                CB_A1.Items.Add(DAARTICULO1.Item(0))
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        DAARTICULO1.Close()
        Me.SqlConnection1.Close()
    End Sub
    Sub cargar_Art2()
        Try
            Me.SqlConnection1.Open()
            CB_A2.Items.Clear()
            CTArt2.CommandType = CommandType.Text
            'CTArt1.CommandText = ("Select Nombre_SubCategoria, Cve_SubCategoria from SubCategorias where SubCategrias.Cve_SubCategoria ='" & TBCveCategoria.Text & "'order by Nombre_SubCategoria")
            CTArt2.CommandText = ("Select Nombre_SubCategoria from SubCategorias where Cve_SubCategoria like '%" + PrimerosDosCveCategoria + "%'" + "order by Nombre_SubCategoria")
            CTArt2.Connection = Me.SqlConnection1
            DAARTICULO2 = CTArt2.ExecuteReader()
            While DAARTICULO2.Read = True
                CB_A2.Items.Add(DAARTICULO2.Item(0))
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        DAARTICULO2.Close()
        Me.SqlConnection1.Close()
    End Sub
    Sub cargar_Art3()
        Try
            Me.SqlConnection1.Open()
            CB_A3.Items.Clear()
            CTArt3.CommandType = CommandType.Text
            'CTArt1.CommandText = ("Select Nombre_SubCategoria, Cve_SubCategoria from SubCategorias where SubCategrias.Cve_SubCategoria ='" & TBCveCategoria.Text & "'order by Nombre_SubCategoria")
            CTArt3.CommandText = ("Select Nombre_SubCategoria from SubCategorias where Cve_SubCategoria like '%" + PrimerosDosCveCategoria + "%'" + "order by Nombre_SubCategoria")
            CTArt3.Connection = Me.SqlConnection1
            DAARTICULO3 = CTArt3.ExecuteReader()
            While DAARTICULO3.Read = True
                CB_A3.Items.Add(DAARTICULO3.Item(0))
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        DAARTICULO3.Close()
        Me.SqlConnection1.Close()
    End Sub
    Sub cargar_Art4()
        Try
            Me.SqlConnection1.Open()
            CB_A4.Items.Clear()
            CTArt4.CommandType = CommandType.Text
            'CTArt1.CommandText = ("Select Nombre_SubCategoria, Cve_SubCategoria from SubCategorias where SubCategrias.Cve_SubCategoria ='" & TBCveCategoria.Text & "'order by Nombre_SubCategoria")
            CTArt4.CommandText = ("Select Nombre_SubCategoria from SubCategorias where Cve_SubCategoria like '%" + PrimerosDosCveCategoria + "%'" + "order by Nombre_SubCategoria")
            CTArt4.Connection = Me.SqlConnection1
            DAARTICULO4 = CTArt4.ExecuteReader()
            While DAARTICULO4.Read = True
                CB_A4.Items.Add(DAARTICULO4.Item(0))
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        DAARTICULO4.Close()
        Me.SqlConnection1.Close()
    End Sub
    Sub cargar_Art5()
        Try
            Me.SqlConnection1.Open()
            CB_A5.Items.Clear()
            CTArt5.CommandType = CommandType.Text
            'CTArt1.CommandText = ("Select Nombre_SubCategoria, Cve_SubCategoria from SubCategorias where SubCategrias.Cve_SubCategoria ='" & TBCveCategoria.Text & "'order by Nombre_SubCategoria")
            CTArt5.CommandText = ("Select Nombre_SubCategoria from SubCategorias where Cve_SubCategoria like '%" + PrimerosDosCveCategoria + "%'" + "order by Nombre_SubCategoria")
            CTArt5.Connection = Me.SqlConnection1
            DAARTICULO5 = CTArt5.ExecuteReader()
            While DAARTICULO5.Read = True
                CB_A5.Items.Add(DAARTICULO5.Item(0))
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        DAARTICULO5.Close()
        Me.SqlConnection1.Close()
    End Sub
    Sub cargar_Art6()
        Try
            Me.SqlConnection1.Open()
            CB_A6.Items.Clear()
            CTArt6.CommandType = CommandType.Text
            CTArt6.CommandText = ("Select Nombre_SubCategoria from SubCategorias where Cve_SubCategoria like '%" + PrimerosDosCveCategoria + "%'" + "order by Nombre_SubCategoria")
            CTArt6.Connection = Me.SqlConnection1
            DAARTICULO6 = CTArt6.ExecuteReader()
            While DAARTICULO6.Read = True
                CB_A6.Items.Add(DAARTICULO6.Item(0))
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        DAARTICULO6.Close()
        Me.SqlConnection1.Close()
    End Sub
    Sub cargar_Art7()
        Try
            Me.SqlConnection1.Open()
            CB_A7.Items.Clear()
            CTArt7.CommandType = CommandType.Text
            CTArt7.CommandText = ("Select Nombre_SubCategoria from SubCategorias where Cve_SubCategoria like '%" + PrimerosDosCveCategoria + "%'" + "order by Nombre_SubCategoria")
            CTArt7.Connection = Me.SqlConnection1
            DAARTICULO7 = CTArt7.ExecuteReader()
            While DAARTICULO7.Read = True
                CB_A7.Items.Add(DAARTICULO7.Item(0))
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        DAARTICULO7.Close()
        Me.SqlConnection1.Close()
    End Sub
    Sub cargar_Art8()
        Try
            Me.SqlConnection1.Open()
            CB_A8.Items.Clear()
            CTArt8.CommandType = CommandType.Text
            CTArt8.CommandText = ("Select Nombre_SubCategoria from SubCategorias where Cve_SubCategoria like '%" + PrimerosDosCveCategoria + "%'" + "order by Nombre_SubCategoria")
            CTArt8.Connection = Me.SqlConnection1
            DAARTICULO8 = CTArt8.ExecuteReader()
            While DAARTICULO8.Read = True
                CB_A8.Items.Add(DAARTICULO8.Item(0))
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        DAARTICULO8.Close()
        Me.SqlConnection1.Close()
    End Sub
    Sub cargar_Art9()
        Try
            Me.SqlConnection1.Open()
            CB_A9.Items.Clear()
            CTArt9.CommandType = CommandType.Text
            CTArt9.CommandText = ("Select Nombre_SubCategoria from SubCategorias where Cve_SubCategoria like '%" + PrimerosDosCveCategoria + "%'" + "order by Nombre_SubCategoria")
            CTArt9.Connection = Me.SqlConnection1
            DAARTICULO9 = CTArt9.ExecuteReader()
            While DAARTICULO9.Read = True
                CB_A9.Items.Add(DAARTICULO9.Item(0))
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        DAARTICULO9.Close()
        Me.SqlConnection1.Close()
    End Sub
    Sub cargar_Art10()
        Try
            Me.SqlConnection1.Open()
            CB_A10.Items.Clear()
            CTArt10.CommandType = CommandType.Text
            CTArt10.CommandText = ("Select Nombre_SubCategoria from SubCategorias where Cve_SubCategoria like '%" + PrimerosDosCveCategoria + "%'" + "order by Nombre_SubCategoria")
            CTArt10.Connection = Me.SqlConnection1
            DAARTICULO10 = CTArt10.ExecuteReader()
            While DAARTICULO10.Read = True
                CB_A10.Items.Add(DAARTICULO10.Item(0))
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        DAARTICULO10.Close()
        Me.SqlConnection1.Close()
    End Sub
    Sub cargar_Art11()
        Try
            Me.SqlConnection1.Open()
            CB_A11.Items.Clear()
            CTArt11.CommandType = CommandType.Text
            CTArt11.CommandText = ("Select Nombre_SubCategoria from SubCategorias where Cve_SubCategoria like '%" + PrimerosDosCveCategoria + "%'" + "order by Nombre_SubCategoria")
            CTArt11.Connection = Me.SqlConnection1
            DAARTICULO11 = CTArt11.ExecuteReader()
            While DAARTICULO11.Read = True
                CB_A11.Items.Add(DAARTICULO11.Item(0))
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        DAARTICULO11.Close()
        Me.SqlConnection1.Close()
    End Sub
    Sub cargar_Art12()
        Try
            Me.SqlConnection1.Open()
            CB_A12.Items.Clear()
            CTArt12.CommandType = CommandType.Text
            CTArt12.CommandText = ("Select Nombre_SubCategoria from SubCategorias where Cve_SubCategoria like '%" + PrimerosDosCveCategoria + "%'" + "order by Nombre_SubCategoria")
            CTArt12.Connection = Me.SqlConnection1
            DAARTICULO12 = CTArt12.ExecuteReader()
            While DAARTICULO12.Read = True
                CB_A12.Items.Add(DAARTICULO12.Item(0))
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        DAARTICULO12.Close()
        Me.SqlConnection1.Close()
    End Sub
    Sub cargar_Art13()
        Try
            Me.SqlConnection1.Open()
            CB_A13.Items.Clear()
            CTArt13.CommandType = CommandType.Text
            CTArt13.CommandText = ("Select Nombre_SubCategoria from SubCategorias where Cve_SubCategoria like '%" + PrimerosDosCveCategoria + "%'" + "order by Nombre_SubCategoria")
            CTArt13.Connection = Me.SqlConnection1
            DAARTICULO13 = CTArt13.ExecuteReader()
            While DAARTICULO13.Read = True
                CB_A13.Items.Add(DAARTICULO13.Item(0))
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        DAARTICULO13.Close()
        Me.SqlConnection1.Close()
    End Sub
    Sub cargar_Art14()
        Try
            Me.SqlConnection1.Open()
            CB_A14.Items.Clear()
            CTArt14.CommandType = CommandType.Text
            CTArt14.CommandText = ("Select Nombre_SubCategoria from SubCategorias where Cve_SubCategoria like '%" + PrimerosDosCveCategoria + "%'" + "order by Nombre_SubCategoria")
            CTArt14.Connection = Me.SqlConnection1
            DAARTICULO14 = CTArt14.ExecuteReader()
            While DAARTICULO14.Read = True
                CB_A14.Items.Add(DAARTICULO14.Item(0))
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        DAARTICULO14.Close()
        Me.SqlConnection1.Close()
    End Sub
    Sub cargar_Art15()
        Try
            Me.SqlConnection1.Open()
            CB_A15.Items.Clear()
            CTArt15.CommandType = CommandType.Text
            CTArt15.CommandText = ("Select Nombre_SubCategoria from SubCategorias where Cve_SubCategoria like '%" + PrimerosDosCveCategoria + "%'" + "order by Nombre_SubCategoria")
            CTArt15.Connection = Me.SqlConnection1
            DAARTICULO15 = CTArt15.ExecuteReader()
            While DAARTICULO15.Read = True
                CB_A15.Items.Add(DAARTICULO15.Item(0))
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        DAARTICULO15.Close()
        Me.SqlConnection1.Close()
    End Sub
    Sub cargar_Art16()
        Try
            Me.SqlConnection1.Open()
            CB_A16.Items.Clear()
            CTArt16.CommandType = CommandType.Text
            CTArt16.CommandText = ("Select Nombre_SubCategoria from SubCategorias where Cve_SubCategoria like '%" + PrimerosDosCveCategoria + "%'" + "order by Nombre_SubCategoria")
            CTArt16.Connection = Me.SqlConnection1
            DAARTICULO16 = CTArt16.ExecuteReader()
            While DAARTICULO16.Read = True
                CB_A16.Items.Add(DAARTICULO16.Item(0))
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        DAARTICULO16.Close()
        Me.SqlConnection1.Close()
    End Sub
    Sub cargar_Art17()
        Try
            Me.SqlConnection1.Open()
            CB_A17.Items.Clear()
            CTArt17.CommandType = CommandType.Text
            CTArt17.CommandText = ("Select Nombre_SubCategoria from SubCategorias where Cve_SubCategoria like '%" + PrimerosDosCveCategoria + "%'" + "order by Nombre_SubCategoria")
            CTArt17.Connection = Me.SqlConnection1
            DAARTICULO17 = CTArt17.ExecuteReader()
            While DAARTICULO17.Read = True
                CB_A17.Items.Add(DAARTICULO17.Item(0))
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        DAARTICULO17.Close()
        Me.SqlConnection1.Close()
    End Sub
    Sub cargar_Art18()
        Try
            Me.SqlConnection1.Open()
            CB_A18.Items.Clear()
            CTArt18.CommandType = CommandType.Text
            CTArt18.CommandText = ("Select Nombre_SubCategoria from SubCategorias where Cve_SubCategoria like '%" + PrimerosDosCveCategoria + "%'" + "order by Nombre_SubCategoria")
            CTArt18.Connection = Me.SqlConnection1
            DAARTICULO18 = CTArt18.ExecuteReader()
            While DAARTICULO18.Read = True
                CB_A18.Items.Add(DAARTICULO18.Item(0))
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        DAARTICULO18.Close()
        Me.SqlConnection1.Close()
    End Sub
    Sub cargar_Art19()
        Try
            Me.SqlConnection1.Open()
            CB_A19.Items.Clear()
            CTArt19.CommandType = CommandType.Text
            CTArt19.CommandText = ("Select Nombre_SubCategoria from SubCategorias where Cve_SubCategoria like '%" + PrimerosDosCveCategoria + "%'" + "order by Nombre_SubCategoria")
            CTArt19.Connection = Me.SqlConnection1
            DAARTICULO19 = CTArt19.ExecuteReader()
            While DAARTICULO19.Read = True
                CB_A19.Items.Add(DAARTICULO19.Item(0))
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        DAARTICULO19.Close()
        Me.SqlConnection1.Close()
    End Sub
    Sub cargar_Art20()
        Try
            Me.SqlConnection1.Open()
            CB_A20.Items.Clear()
            CTArt20.CommandType = CommandType.Text
            CTArt20.CommandText = ("Select Nombre_SubCategoria from SubCategorias where Cve_SubCategoria like '%" + PrimerosDosCveCategoria + "%'" + "order by Nombre_SubCategoria")
            CTArt20.Connection = Me.SqlConnection1
            DAARTICULO20 = CTArt19.ExecuteReader()
            While DAARTICULO20.Read = True
                CB_A20.Items.Add(DAARTICULO20.Item(0))
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        DAARTICULO20.Close()
        Me.SqlConnection1.Close()
    End Sub
    Private Sub ChB_Status1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChB_Status1.CheckedChanged
        If ChB_Status1.Checked = True Then
            Call cargar_Art1()
            mov_alta1 = 1
            CB_A1.Enabled = True
            TB_Marca1.Enabled = True
            TB_Modelo1.Enabled = True
            TB_Serie1.Enabled = True
            TB_NoFactura1.Enabled = True
            DateTimePicker_Factura1.Enabled = True
            NUpDown_CanArt1.Enabled = True
            TB_CostoUnit1.Enabled = True
            TB_CostoTotal1.Enabled = True
        Else
            mov_alta1 = 0
            CB_A1.Enabled = False
            TB_Marca1.Enabled = False
            TB_Modelo1.Enabled = False
            TB_Serie1.Enabled = False
            TB_NoFactura1.Enabled = False
            DateTimePicker_Factura1.Enabled = False
            NUpDown_CanArt1.Enabled = False
            TB_CostoUnit1.Enabled = False
            TB_CostoTotal1.Enabled = False
        End If
    End Sub
    Private Sub ChB_Status2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChB_Status2.CheckedChanged
        If ChB_Status2.Checked = True Then
            Call cargar_Art2()
            mov_alta2 = 2
            CB_A2.Enabled = True
            TB_Marca2.Enabled = True
            TB_Modelo2.Enabled = True
            TB_Serie2.Enabled = True
            TB_NoFactura2.Enabled = True
            DateTimePicker_Factura2.Enabled = True
            NUpDown_CanArt2.Enabled = True
            TB_CostoUnit2.Enabled = True
            TB_CostoTotal2.Enabled = True
        Else
            mov_alta2 = 0
            CB_A2.Enabled = False
            TB_Marca2.Enabled = False
            TB_Modelo2.Enabled = False
            TB_Serie2.Enabled = False
            TB_NoFactura2.Enabled = False
            DateTimePicker_Factura2.Enabled = False
            NUpDown_CanArt2.Enabled = False
            TB_CostoUnit2.Enabled = False
            TB_CostoTotal2.Enabled = False
        End If
    End Sub
    Private Sub ChB_Status3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChB_Status3.CheckedChanged
        If ChB_Status3.Checked = True Then
            Call cargar_Art3()
            mov_alta3 = 3
            CB_A3.Enabled = True
            TB_Marca3.Enabled = True
            TB_Modelo3.Enabled = True
            TB_Serie3.Enabled = True
            TB_NoFactura3.Enabled = True
            DateTimePicker_Factura3.Enabled = True
            NUpDown_CanArt3.Enabled = True
            TB_CostoUnit3.Enabled = True
            TB_CostoTotal3.Enabled = True
        Else
            mov_alta3 = 0
            CB_A3.Enabled = False
            TB_Marca3.Enabled = False
            TB_Modelo3.Enabled = False
            TB_Serie3.Enabled = False
            TB_NoFactura3.Enabled = False
            DateTimePicker_Factura3.Enabled = False
            NUpDown_CanArt3.Enabled = False
            TB_CostoUnit3.Enabled = False
            TB_CostoTotal3.Enabled = False
        End If
    End Sub
    Private Sub ChB_Status4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChB_Status4.CheckedChanged
        If ChB_Status4.Checked = True Then
            Call cargar_Art4()
            mov_alta4 = 4
            CB_A4.Enabled = True
            TB_Marca4.Enabled = True
            TB_Modelo4.Enabled = True
            TB_Serie4.Enabled = True
            TB_NoFactura4.Enabled = True
            DateTimePicker_Factura4.Enabled = True
            NUpDown_CanArt4.Enabled = True
            TB_CostoUnit4.Enabled = True
            TB_CostoTotal4.Enabled = True
        Else
            mov_alta4 = 0
            CB_A4.Enabled = False
            TB_Marca4.Enabled = False
            TB_Modelo4.Enabled = False
            TB_Serie4.Enabled = False
            TB_NoFactura4.Enabled = False
            DateTimePicker_Factura4.Enabled = False
            NUpDown_CanArt4.Enabled = False
            TB_CostoUnit4.Enabled = False
            TB_CostoTotal4.Enabled = False
        End If
    End Sub
    Private Sub ChB_Status5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChB_Status5.CheckedChanged
        If ChB_Status5.Checked = True Then
            Call cargar_Art5()
            mov_alta5 = 5
            CB_A5.Enabled = True
            TB_Marca5.Enabled = True
            TB_Modelo5.Enabled = True
            TB_Serie5.Enabled = True
            TB_NoFactura5.Enabled = True
            DateTimePicker_Factura5.Enabled = True
            NUpDown_CanArt5.Enabled = True
            TB_CostoUnit5.Enabled = True
            TB_CostoTotal5.Enabled = True
        Else
            mov_alta5 = 0
            CB_A5.Enabled = False
            TB_Marca5.Enabled = False
            TB_Modelo5.Enabled = False
            TB_Serie5.Enabled = False
            TB_NoFactura5.Enabled = False
            DateTimePicker_Factura5.Enabled = False
            NUpDown_CanArt5.Enabled = False
            TB_CostoUnit5.Enabled = False
            TB_CostoTotal5.Enabled = False
        End If
    End Sub
    Private Sub ChB_Status6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChB_Status6.CheckedChanged
        If ChB_Status6.Checked = True Then
            Call cargar_Art6()
            mov_alta6 = 6
            CB_A6.Enabled = True
            TB_Marca6.Enabled = True
            TB_Modelo6.Enabled = True
            TB_Serie6.Enabled = True
            TB_NoFactura6.Enabled = True
            NUpDown_CanArt6.Enabled = True
            DateTimePicker_Factura6.Enabled = True
            TB_CostoUnit6.Enabled = True
            TB_CostoTotal6.Enabled = True
        Else
            mov_alta6 = 0
            CB_A6.Enabled = False
            TB_Marca6.Enabled = False
            TB_Modelo6.Enabled = False
            TB_Serie6.Enabled = False
            TB_NoFactura6.Enabled = False
            NUpDown_CanArt6.Enabled = False
            DateTimePicker_Factura6.Enabled = False
            NUpDown_CanArt6.Enabled = False
            TB_CostoUnit6.Enabled = False
            TB_CostoTotal6.Enabled = False
        End If
    End Sub
    Private Sub ChB_Status7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChB_Status7.CheckedChanged
        If ChB_Status7.Checked = True Then
            Call cargar_Art7()
            mov_alta7 = 7
            CB_A7.Enabled = True
            TB_Marca7.Enabled = True
            TB_Modelo7.Enabled = True
            TB_Serie7.Enabled = True
            TB_NoFactura7.Enabled = True
            NUpDown_CanArt7.Enabled = True
            DateTimePicker_Factura7.Enabled = True
            DateTimePicker_Factura7.Enabled = True
            TB_CostoUnit7.Enabled = True
            TB_CostoTotal7.Enabled = True
        Else
            mov_alta7 = 0
            CB_A7.Enabled = False
            TB_Marca7.Enabled = False
            TB_Modelo7.Enabled = False
            TB_Serie7.Enabled = False
            TB_NoFactura7.Enabled = False
            NUpDown_CanArt7.Enabled = False
            DateTimePicker_Factura7.Enabled = False
            NUpDown_CanArt7.Enabled = False
            TB_CostoUnit7.Enabled = False
            TB_CostoTotal7.Enabled = False
        End If
    End Sub
    Private Sub ChB_Status8_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChB_Status8.CheckedChanged
        If ChB_Status8.Checked = True Then
            Call cargar_Art8()
            mov_alta8 = 8
            CB_A8.Enabled = True
            TB_Marca8.Enabled = True
            TB_Modelo8.Enabled = True
            TB_Serie8.Enabled = True
            TB_NoFactura8.Enabled = True
            NUpDown_CanArt8.Enabled = True
            DateTimePicker_Factura8.Enabled = True
            DateTimePicker_Factura8.Enabled = True
            TB_CostoUnit8.Enabled = True
            TB_CostoTotal8.Enabled = True
        Else
            mov_alta8 = 0
            CB_A8.Enabled = False
            TB_Marca8.Enabled = False
            TB_Modelo8.Enabled = False
            TB_Serie8.Enabled = False
            TB_NoFactura8.Enabled = False
            NUpDown_CanArt8.Enabled = False
            DateTimePicker_Factura8.Enabled = False
            NUpDown_CanArt8.Enabled = False
            TB_CostoUnit8.Enabled = False
            TB_CostoTotal8.Enabled = False
        End If
    End Sub
    Private Sub ChB_Status9_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChB_Status9.CheckedChanged
        If ChB_Status9.Checked = True Then
            Call cargar_Art9()
            mov_alta9 = 9
            CB_A9.Enabled = True
            TB_Marca9.Enabled = True
            TB_Modelo9.Enabled = True
            TB_Serie9.Enabled = True
            TB_NoFactura9.Enabled = True
            NUpDown_CanArt9.Enabled = True
            DateTimePicker_Factura9.Enabled = True
            DateTimePicker_Factura9.Enabled = True
            TB_CostoUnit9.Enabled = True
            TB_CostoTotal9.Enabled = True
        Else
            mov_alta9 = 0
            CB_A9.Enabled = False
            TB_Marca9.Enabled = False
            TB_Modelo9.Enabled = False
            TB_Serie9.Enabled = False
            TB_NoFactura9.Enabled = False
            NUpDown_CanArt9.Enabled = False
            DateTimePicker_Factura9.Enabled = False
            NUpDown_CanArt9.Enabled = False
            TB_CostoUnit9.Enabled = False
            TB_CostoTotal9.Enabled = False
        End If
    End Sub
    Private Sub ChB_Status10_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChB_Status10.CheckedChanged
        If ChB_Status10.Checked = True Then
            Call cargar_Art10()
            mov_alta10 = 10
            CB_A10.Enabled = True
            TB_Marca10.Enabled = True
            TB_Modelo10.Enabled = True
            TB_Serie10.Enabled = True
            TB_NoFactura10.Enabled = True
            NUpDown_CanArt10.Enabled = True
            DateTimePicker_Factura10.Enabled = True
            DateTimePicker_Factura10.Enabled = True
            TB_CostoUnit10.Enabled = True
            TB_CostoTotal10.Enabled = True
        Else
            mov_alta10 = 0
            CB_A10.Enabled = False
            TB_Marca10.Enabled = False
            TB_Modelo10.Enabled = False
            TB_Serie10.Enabled = False
            TB_NoFactura10.Enabled = False
            NUpDown_CanArt10.Enabled = False
            DateTimePicker_Factura10.Enabled = False
            NUpDown_CanArt10.Enabled = False
            TB_CostoUnit10.Enabled = False
            TB_CostoTotal10.Enabled = False
        End If
    End Sub
    Private Sub ChB_Status11_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChB_Status11.CheckedChanged
        If ChB_Status11.Checked = True Then
            Call cargar_Art11()
            mov_alta11 = 11
            CB_A11.Enabled = True
            TB_Marca11.Enabled = True
            TB_Modelo11.Enabled = True
            TB_Serie11.Enabled = True
            TB_NoFactura11.Enabled = True
            NUpDown_CanArt11.Enabled = True
            DateTimePicker_Factura11.Enabled = True
            DateTimePicker_Factura11.Enabled = True
            TB_CostoUnit11.Enabled = True
            TB_CostoTotal11.Enabled = True
        Else
            mov_alta11 = 0
            CB_A11.Enabled = False
            TB_Marca11.Enabled = False
            TB_Modelo11.Enabled = False
            TB_Serie11.Enabled = False
            TB_NoFactura11.Enabled = False
            NUpDown_CanArt11.Enabled = False
            DateTimePicker_Factura11.Enabled = False
            NUpDown_CanArt11.Enabled = False
            TB_CostoUnit11.Enabled = False
            TB_CostoTotal11.Enabled = False
        End If
    End Sub
    Private Sub ChB_Status12_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChB_Status12.CheckedChanged
        If ChB_Status12.Checked = True Then
            Call cargar_Art12()
            mov_alta12 = 12
            CB_A12.Enabled = True
            TB_Marca12.Enabled = True
            TB_Modelo12.Enabled = True
            TB_Serie12.Enabled = True
            TB_NoFactura12.Enabled = True
            NUpDown_CanArt12.Enabled = True
            DateTimePicker_Factura12.Enabled = True
            TB_CostoUnit12.Enabled = True
            TB_CostoTotal12.Enabled = True
        Else
            mov_alta12 = 0
            CB_A12.Enabled = False
            TB_Marca12.Enabled = False
            TB_Modelo12.Enabled = False
            TB_Serie12.Enabled = False
            TB_NoFactura12.Enabled = False
            NUpDown_CanArt12.Enabled = False
            DateTimePicker_Factura12.Enabled = False
            NUpDown_CanArt12.Enabled = False
            TB_CostoUnit12.Enabled = False
            TB_CostoTotal12.Enabled = False
        End If
    End Sub
    Private Sub ChB_Status13_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChB_Status13.CheckedChanged
        If ChB_Status13.Checked = True Then
            Call cargar_Art13()
            mov_alta13 = 13
            CB_A13.Enabled = True
            TB_Marca13.Enabled = True
            TB_Modelo13.Enabled = True
            TB_Serie13.Enabled = True
            TB_NoFactura13.Enabled = True
            NUpDown_CanArt13.Enabled = True
            DateTimePicker_Factura13.Enabled = True
            DateTimePicker_Factura13.Enabled = True
            TB_CostoUnit13.Enabled = True
            TB_CostoTotal13.Enabled = True
        Else
            mov_alta13 = 0
            CB_A13.Enabled = False
            TB_Marca13.Enabled = False
            TB_Modelo13.Enabled = False
            TB_Serie13.Enabled = False
            TB_NoFactura13.Enabled = False
            NUpDown_CanArt13.Enabled = False
            DateTimePicker_Factura13.Enabled = False
            NUpDown_CanArt13.Enabled = False
            TB_CostoUnit13.Enabled = False
            TB_CostoTotal13.Enabled = False
        End If
    End Sub
    Private Sub ChB_Status14_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChB_Status14.CheckedChanged
        If ChB_Status14.Checked = True Then
            Call cargar_Art14()
            mov_alta14 = 14
            CB_A14.Enabled = True
            TB_Marca14.Enabled = True
            TB_Modelo14.Enabled = True
            TB_Serie14.Enabled = True
            TB_NoFactura14.Enabled = True
            NUpDown_CanArt14.Enabled = True
            DateTimePicker_Factura14.Enabled = True
            DateTimePicker_Factura14.Enabled = True
            TB_CostoUnit14.Enabled = True
            TB_CostoTotal14.Enabled = True
        Else
            mov_alta14 = 0
            CB_A14.Enabled = False
            TB_Marca14.Enabled = False
            TB_Modelo14.Enabled = False
            TB_Serie14.Enabled = False
            TB_NoFactura14.Enabled = False
            NUpDown_CanArt14.Enabled = False
            DateTimePicker_Factura14.Enabled = False
            NUpDown_CanArt14.Enabled = False
            TB_CostoUnit14.Enabled = False
            TB_CostoTotal14.Enabled = False
        End If
    End Sub
    Private Sub ChB_Status15_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChB_Status15.CheckedChanged
        If ChB_Status15.Checked = True Then
            Call cargar_Art15()
            mov_alta15 = 15
            CB_A15.Enabled = True
            TB_Marca15.Enabled = True
            TB_Modelo15.Enabled = True
            TB_Serie15.Enabled = True
            TB_NoFactura15.Enabled = True
            NUpDown_CanArt15.Enabled = True
            DateTimePicker_Factura15.Enabled = True
            DateTimePicker_Factura15.Enabled = True
            TB_CostoUnit15.Enabled = True
            TB_CostoTotal15.Enabled = True
        Else
            mov_alta15 = 0
            CB_A15.Enabled = False
            TB_Marca15.Enabled = False
            TB_Modelo15.Enabled = False
            TB_Serie15.Enabled = False
            TB_NoFactura15.Enabled = False
            NUpDown_CanArt15.Enabled = False
            DateTimePicker_Factura15.Enabled = False
            NUpDown_CanArt15.Enabled = False
            TB_CostoUnit15.Enabled = False
            TB_CostoTotal15.Enabled = False
        End If
    End Sub
    Private Sub ChB_Status16_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChB_Status16.CheckedChanged
        If ChB_Status16.Checked = True Then
            Call cargar_Art16()
            mov_alta16 = 16
            CB_A16.Enabled = True
            TB_Marca16.Enabled = True
            TB_Modelo16.Enabled = True
            TB_Serie16.Enabled = True
            TB_NoFactura16.Enabled = True
            NUpDown_CanArt16.Enabled = True
            DateTimePicker_Factura16.Enabled = True
            DateTimePicker_Factura16.Enabled = True
            TB_CostoUnit16.Enabled = True
            TB_CostoTotal16.Enabled = True
        Else
            mov_alta16 = 0
            CB_A16.Enabled = False
            TB_Marca16.Enabled = False
            TB_Modelo16.Enabled = False
            TB_Serie16.Enabled = False
            TB_NoFactura16.Enabled = False
            NUpDown_CanArt16.Enabled = False
            DateTimePicker_Factura16.Enabled = False
            NUpDown_CanArt16.Enabled = False
            TB_CostoUnit16.Enabled = False
            TB_CostoTotal16.Enabled = False
        End If
    End Sub
    Private Sub ChB_Status17_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChB_Status17.CheckedChanged
        If ChB_Status17.Checked = True Then
            Call cargar_Art17()
            mov_alta17 = 17
            CB_A17.Enabled = True
            TB_Marca17.Enabled = True
            TB_Modelo17.Enabled = True
            TB_Serie17.Enabled = True
            TB_NoFactura17.Enabled = True
            NUpDown_CanArt17.Enabled = True
            DateTimePicker_Factura17.Enabled = True
            DateTimePicker_Factura17.Enabled = True
            TB_CostoUnit17.Enabled = True
            TB_CostoTotal17.Enabled = True
        Else
            mov_alta17 = 0
            CB_A17.Enabled = False
            TB_Marca17.Enabled = False
            TB_Modelo17.Enabled = False
            TB_Serie17.Enabled = False
            TB_NoFactura17.Enabled = False
            NUpDown_CanArt17.Enabled = False
            DateTimePicker_Factura17.Enabled = False
            NUpDown_CanArt17.Enabled = False
            TB_CostoUnit17.Enabled = False
            TB_CostoTotal17.Enabled = False
        End If
    End Sub
    Private Sub ChB_Status18_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChB_Status18.CheckedChanged
        If ChB_Status18.Checked = True Then
            Call cargar_Art18()
            mov_alta18 = 18
            CB_A18.Enabled = True
            TB_Marca18.Enabled = True
            TB_Modelo18.Enabled = True
            TB_Serie18.Enabled = True
            TB_NoFactura18.Enabled = True
            NUpDown_CanArt18.Enabled = True
            DateTimePicker_Factura18.Enabled = True
            DateTimePicker_Factura18.Enabled = True
            TB_CostoUnit18.Enabled = True
            TB_CostoTotal18.Enabled = True
        Else
            mov_alta18 = 0
            CB_A18.Enabled = False
            TB_Marca18.Enabled = False
            TB_Modelo18.Enabled = False
            TB_Serie18.Enabled = False
            TB_NoFactura18.Enabled = False
            NUpDown_CanArt18.Enabled = False
            DateTimePicker_Factura18.Enabled = False
            NUpDown_CanArt18.Enabled = False
            TB_CostoUnit18.Enabled = False
            TB_CostoTotal18.Enabled = False
        End If
    End Sub
    Private Sub ChB_Status19_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChB_Status19.CheckedChanged
        If ChB_Status19.Checked = True Then
            Call cargar_Art19()
            mov_alta19 = 19
            CB_A19.Enabled = True
            TB_Marca19.Enabled = True
            TB_Modelo19.Enabled = True
            TB_Serie19.Enabled = True
            TB_NoFactura19.Enabled = True
            NUpDown_CanArt19.Enabled = True
            DateTimePicker_Factura19.Enabled = True
            DateTimePicker_Factura19.Enabled = True
            TB_CostoUnit19.Enabled = True
            TB_CostoTotal19.Enabled = True
        Else
            mov_alta19 = 0
            CB_A19.Enabled = False
            TB_Marca19.Enabled = False
            TB_Modelo19.Enabled = False
            TB_Serie19.Enabled = False
            TB_NoFactura19.Enabled = False
            NUpDown_CanArt19.Enabled = False
            DateTimePicker_Factura19.Enabled = False
            NUpDown_CanArt19.Enabled = False
            TB_CostoUnit19.Enabled = False
            TB_CostoTotal19.Enabled = False
        End If
    End Sub
    Private Sub ChB_Status20_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChB_Status20.CheckedChanged
        If ChB_Status19.Checked = True Then
            Call cargar_Art20()
            mov_alta20 = 20
            CB_A20.Enabled = True
            TB_Marca20.Enabled = True
            TB_Modelo20.Enabled = True
            TB_Serie20.Enabled = True
            TB_NoFactura20.Enabled = True
            NUpDown_CanArt20.Enabled = True
            DateTimePicker_Factura20.Enabled = True
            DateTimePicker_Factura20.Enabled = True
            TB_CostoUnit20.Enabled = True
            TB_CostoTotal20.Enabled = True
        Else
            mov_alta20 = 0
            CB_A20.Enabled = False
            TB_Marca20.Enabled = False
            TB_Modelo20.Enabled = False
            TB_Serie20.Enabled = False
            TB_NoFactura20.Enabled = False
            NUpDown_CanArt20.Enabled = False
            DateTimePicker_Factura20.Enabled = False
            NUpDown_CanArt20.Enabled = False
            TB_CostoUnit20.Enabled = False
            TB_CostoTotal20.Enabled = False
        End If
    End Sub
    Private Sub CB_A1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_A1.SelectedIndexChanged
        Try
            Me.SqlConnection1.Open()
            CTBTArt1.CommandType = CommandType.Text
            CTBTArt1.CommandText = ("Select Cve_SubCategoria from SubCategorias where SubCategorias.Nombre_SubCategoria =  '" & CB_A1.Text & "'")
            CTBTArt1.Connection = Me.SqlConnection1
            DAARTICULO1 = CTBTArt1.ExecuteReader()
            While DAARTICULO1.Read
                Me.TB_SubCategoria_A1.Text = (DAARTICULO1("Cve_SubCategoria"))
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        DAARTICULO1.Close()
        Me.SqlConnection1.Close()
    End Sub
    Private Sub CB_A2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_A2.SelectedIndexChanged
        Try
            Me.SqlConnection1.Open()
            CTBTArt2.CommandType = CommandType.Text
            CTBTArt2.CommandText = ("Select Cve_SubCategoria from SubCategorias where SubCategorias.Nombre_SubCategoria =  '" & CB_A2.Text & "'")
            CTBTArt2.Connection = Me.SqlConnection1
            DAARTICULO2 = CTBTArt2.ExecuteReader()
            While DAARTICULO2.Read
                Me.TB_SubCategoria_A2.Text = (DAARTICULO2("Cve_SubCategoria"))
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        DAARTICULO2.Close()
        Me.SqlConnection1.Close()
    End Sub
    Private Sub CB_A3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_A3.SelectedIndexChanged
        Try
            Me.SqlConnection1.Open()
            CTBTArt3.CommandType = CommandType.Text
            CTBTArt3.CommandText = ("Select Cve_SubCategoria from SubCategorias where SubCategorias.Nombre_SubCategoria =  '" & CB_A3.Text & "'")
            CTBTArt3.Connection = Me.SqlConnection1
            DAARTICULO3 = CTBTArt3.ExecuteReader()
            While DAARTICULO3.Read
                Me.TB_SubCategoria_A3.Text = (DAARTICULO3("Cve_SubCategoria"))
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        DAARTICULO3.Close()
        Me.SqlConnection1.Close()
    End Sub
    Private Sub CB_A4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_A4.SelectedIndexChanged
        Try
            Me.SqlConnection1.Open()
            CTBTArt4.CommandType = CommandType.Text
            CTBTArt4.CommandText = ("Select Cve_SubCategoria from SubCategorias where SubCategorias.Nombre_SubCategoria =  '" & CB_A4.Text & "'")
            CTBTArt4.Connection = Me.SqlConnection1
            DAARTICULO4 = CTBTArt4.ExecuteReader()
            While DAARTICULO4.Read
                Me.TB_SubCategoria_A4.Text = (DAARTICULO4("Cve_SubCategoria"))
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        DAARTICULO4.Close()
        Me.SqlConnection1.Close()
    End Sub
    Private Sub CB_A5_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_A5.SelectedIndexChanged
        Try
            Me.SqlConnection1.Open()
            CTBTArt5.CommandType = CommandType.Text
            CTBTArt5.CommandText = ("Select Cve_SubCategoria from SubCategorias where SubCategorias.Nombre_SubCategoria =  '" & CB_A5.Text & "'")
            CTBTArt5.Connection = Me.SqlConnection1
            DAARTICULO5 = CTBTArt5.ExecuteReader()
            While DAARTICULO5.Read
                Me.TB_SubCategoria_A5.Text = (DAARTICULO5("Cve_SubCategoria"))
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        DAARTICULO5.Close()
        Me.SqlConnection1.Close()
    End Sub
    Private Sub CB_A6_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_A6.SelectedIndexChanged
        Try
            Me.SqlConnection1.Open()
            CTBTArt6.CommandType = CommandType.Text
            CTBTArt6.CommandText = ("Select Cve_SubCategoria from SubCategorias where SubCategorias.Nombre_SubCategoria =  '" & CB_A6.Text & "'")
            CTBTArt6.Connection = Me.SqlConnection1
            DAARTICULO6 = CTBTArt6.ExecuteReader()
            While DAARTICULO6.Read
                Me.TB_SubCategoria_A6.Text = (DAARTICULO6("Cve_SubCategoria"))
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        DAARTICULO6.Close()
        Me.SqlConnection1.Close()
    End Sub
    Private Sub CB_A7_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_A7.SelectedIndexChanged
        Try
            Me.SqlConnection1.Open()
            CTBTArt7.CommandType = CommandType.Text
            CTBTArt7.CommandText = ("Select Cve_SubCategoria from SubCategorias where SubCategorias.Nombre_SubCategoria =  '" & CB_A7.Text & "'")
            CTBTArt7.Connection = Me.SqlConnection1
            DAARTICULO7 = CTBTArt7.ExecuteReader()
            While DAARTICULO7.Read
                Me.TB_SubCategoria_A7.Text = (DAARTICULO7("Cve_SubCategoria"))
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        DAARTICULO7.Close()
        Me.SqlConnection1.Close()
    End Sub
    Private Sub CB_A8_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_A8.SelectedIndexChanged
        Try
            Me.SqlConnection1.Open()
            CTBTArt8.CommandType = CommandType.Text
            CTBTArt8.CommandText = ("Select Cve_SubCategoria from SubCategorias where SubCategorias.Nombre_SubCategoria =  '" & CB_A8.Text & "'")
            CTBTArt8.Connection = Me.SqlConnection1
            DAARTICULO8 = CTBTArt8.ExecuteReader()
            While DAARTICULO8.Read
                Me.TB_SubCategoria_A8.Text = (DAARTICULO8("Cve_SubCategoria"))
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        DAARTICULO8.Close()
        Me.SqlConnection1.Close()
    End Sub
    Private Sub CB_A9_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_A9.SelectedIndexChanged
        Try
            Me.SqlConnection1.Open()
            CTBTArt9.CommandType = CommandType.Text
            CTBTArt9.CommandText = ("Select Cve_SubCategoria from SubCategorias where SubCategorias.Nombre_SubCategoria =  '" & CB_A9.Text & "'")
            CTBTArt9.Connection = Me.SqlConnection1
            DAARTICULO9 = CTBTArt9.ExecuteReader()
            While DAARTICULO9.Read
                Me.TB_SubCategoria_A9.Text = (DAARTICULO9("Cve_SubCategoria"))
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        DAARTICULO9.Close()
        Me.SqlConnection1.Close()
    End Sub
    Private Sub CB_A10_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_A10.SelectedIndexChanged
        Try
            Me.SqlConnection1.Open()
            CTBTArt10.CommandType = CommandType.Text
            CTBTArt10.CommandText = ("Select Cve_SubCategoria from SubCategorias where SubCategorias.Nombre_SubCategoria =  '" & CB_A10.Text & "'")
            CTBTArt10.Connection = Me.SqlConnection1
            DAARTICULO10 = CTBTArt10.ExecuteReader()
            While DAARTICULO10.Read
                Me.TB_SubCategoria_A10.Text = (DAARTICULO10("Cve_SubCategoria"))
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        DAARTICULO10.Close()
        Me.SqlConnection1.Close()
    End Sub
    Private Sub CB_A11_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_A11.SelectedIndexChanged
        Try
            Me.SqlConnection1.Open()
            CTBTArt11.CommandType = CommandType.Text
            CTBTArt11.CommandText = ("Select Cve_SubCategoria from SubCategorias where SubCategorias.Nombre_SubCategoria =  '" & CB_A11.Text & "'")
            CTBTArt11.Connection = Me.SqlConnection1
            DAARTICULO11 = CTBTArt11.ExecuteReader()
            While DAARTICULO11.Read
                Me.TB_SubCategoria_A11.Text = (DAARTICULO11("Cve_SubCategoria"))
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        DAARTICULO11.Close()
        Me.SqlConnection1.Close()
    End Sub
    Private Sub CB_A12_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_A12.SelectedIndexChanged
        Try
            Me.SqlConnection1.Open()
            CTBTArt12.CommandType = CommandType.Text
            CTBTArt12.CommandText = ("Select Cve_SubCategoria from SubCategorias where SubCategorias.Nombre_SubCategoria =  '" & CB_A12.Text & "'")
            CTBTArt12.Connection = Me.SqlConnection1
            DAARTICULO12 = CTBTArt12.ExecuteReader()
            While DAARTICULO12.Read
                Me.TB_SubCategoria_A12.Text = (DAARTICULO12("Cve_SubCategoria"))
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        DAARTICULO12.Close()
        Me.SqlConnection1.Close()
    End Sub
    Private Sub CB_A13_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_A13.SelectedIndexChanged
        Try
            Me.SqlConnection1.Open()
            CTBTArt13.CommandType = CommandType.Text
            CTBTArt13.CommandText = ("Select Cve_SubCategoria from SubCategorias where SubCategorias.Nombre_SubCategoria =  '" & CB_A13.Text & "'")
            CTBTArt13.Connection = Me.SqlConnection1
            DAARTICULO13 = CTBTArt13.ExecuteReader()
            While DAARTICULO13.Read
                Me.TB_SubCategoria_A13.Text = (DAARTICULO13("Cve_SubCategoria"))
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        DAARTICULO13.Close()
        Me.SqlConnection1.Close()
    End Sub
    Private Sub CB_A14_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_A14.SelectedIndexChanged
        Try
            Me.SqlConnection1.Open()
            CTBTArt14.CommandType = CommandType.Text
            CTBTArt14.CommandText = ("Select Cve_SubCategoria from SubCategorias where SubCategorias.Nombre_SubCategoria =  '" & CB_A14.Text & "'")
            CTBTArt14.Connection = Me.SqlConnection1
            DAARTICULO14 = CTBTArt14.ExecuteReader()
            While DAARTICULO14.Read
                Me.TB_SubCategoria_A14.Text = (DAARTICULO14("Cve_SubCategoria"))
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        DAARTICULO14.Close()
        Me.SqlConnection1.Close()
    End Sub
    Private Sub CB_A15_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_A15.SelectedIndexChanged
        Try
            Me.SqlConnection1.Open()
            CTBTArt15.CommandType = CommandType.Text
            CTBTArt15.CommandText = ("Select Cve_SubCategoria from SubCategorias where SubCategorias.Nombre_SubCategoria =  '" & CB_A15.Text & "'")
            CTBTArt15.Connection = Me.SqlConnection1
            DAARTICULO15 = CTBTArt15.ExecuteReader()
            While DAARTICULO15.Read
                Me.TB_SubCategoria_A15.Text = (DAARTICULO15("Cve_SubCategoria"))
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        DAARTICULO15.Close()
        Me.SqlConnection1.Close()
    End Sub
    Private Sub CB_A16_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_A16.SelectedIndexChanged
        Try
            Me.SqlConnection1.Open()
            CTBTArt16.CommandType = CommandType.Text
            CTBTArt16.CommandText = ("Select Cve_SubCategoria from SubCategorias where SubCategorias.Nombre_SubCategoria =  '" & CB_A16.Text & "'")
            CTBTArt16.Connection = Me.SqlConnection1
            DAARTICULO16 = CTBTArt16.ExecuteReader()
            While DAARTICULO16.Read
                Me.TB_SubCategoria_A16.Text = (DAARTICULO16("Cve_SubCategoria"))
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        DAARTICULO16.Close()
        Me.SqlConnection1.Close()
    End Sub
    Private Sub CB_A17_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_A17.SelectedIndexChanged
        Try
            Me.SqlConnection1.Open()
            CTBTArt17.CommandType = CommandType.Text
            CTBTArt17.CommandText = ("Select Cve_SubCategoria from SubCategorias where SubCategorias.Nombre_SubCategoria =  '" & CB_A17.Text & "'")
            CTBTArt17.Connection = Me.SqlConnection1
            DAARTICULO17 = CTBTArt17.ExecuteReader()
            While DAARTICULO17.Read
                Me.TB_SubCategoria_A17.Text = (DAARTICULO17("Cve_SubCategoria"))
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        DAARTICULO17.Close()
        Me.SqlConnection1.Close()
    End Sub
    Private Sub CB_A18_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_A18.SelectedIndexChanged
        Try
            Me.SqlConnection1.Open()
            CTBTArt18.CommandType = CommandType.Text
            CTBTArt18.CommandText = ("Select Cve_SubCategoria from SubCategorias where SubCategorias.Nombre_SubCategoria =  '" & CB_A18.Text & "'")
            CTBTArt18.Connection = Me.SqlConnection1
            DAARTICULO18 = CTBTArt18.ExecuteReader()
            While DAARTICULO18.Read
                Me.TB_SubCategoria_A18.Text = (DAARTICULO18("Cve_SubCategoria"))
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        DAARTICULO18.Close()
        Me.SqlConnection1.Close()
    End Sub
    Private Sub CB_A19_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_A19.SelectedIndexChanged
        Try
            Me.SqlConnection1.Open()
            CTBTArt19.CommandType = CommandType.Text
            CTBTArt19.CommandText = ("Select Cve_SubCategoria from SubCategorias where SubCategorias.Nombre_SubCategoria =  '" & CB_A19.Text & "'")
            CTBTArt19.Connection = Me.SqlConnection1
            DAARTICULO19 = CTBTArt19.ExecuteReader()
            While DAARTICULO19.Read
                Me.TB_SubCategoria_A19.Text = (DAARTICULO19("Cve_SubCategoria"))
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        DAARTICULO19.Close()
        Me.SqlConnection1.Close()
    End Sub
    Private Sub CB_A20_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_A20.SelectedIndexChanged
        Try
            Me.SqlConnection1.Open()
            CTBTArt20.CommandType = CommandType.Text
            CTBTArt20.CommandText = ("Select Cve_SubCategoria from SubCategorias where SubCategorias.Nombre_SubCategoria =  '" & CB_A20.Text & "'")
            CTBTArt20.Connection = Me.SqlConnection1
            DAARTICULO20 = CTBTArt20.ExecuteReader()
            While DAARTICULO20.Read
                Me.TB_SubCategoria_A20.Text = (DAARTICULO20("Cve_SubCategoria"))
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        DAARTICULO20.Close()
        Me.SqlConnection1.Close()
    End Sub
    Sub movimiento_alta1()
        Try
            Me.SqlConnection1.Open()
            Dim Insar1 As String = "INSERT INTO Patrimonio (Folio,Fecha_Registro,Solicitud,No_Activo,Cve_Categoria,Cve_SubCategoria,Descripcion,Marca,Modelo,Serie,No_Factura,Fecha_Factura,Cantidad_Articulos,Costo_Unitario,Costo_Total,Departamento,Titular,Act) values(@Folio,@Fecha_Registro,@Solicitud,@No_Activo,@Cve_Categoria,@Cve_SubCategoria,@Descripcion,@Marca,@Modelo,@Serie,@No_Factura,@Fecha_Factura,@Cantidad_Articulos,@Costo_Unitario,@Costo_Total,@Departamento,@Titular,@Act)"
            Dim conex1 As New SqlClient.SqlCommand(Insar1, Me.SqlConnection1)
            conex1.Parameters.Add(New SqlParameter("@Folio", SqlDbType.Int, 4)).Value = Me.TBFolio.Text
            conex1.Parameters.Add(New SqlParameter("@Departamento", SqlDbType.NVarChar, 50)).Value = Me.CB_Departamento.Text
            conex1.Parameters.Add(New SqlParameter("@Titular", SqlDbType.NVarChar, 50)).Value = Me.CB_Responsable.Text
            conex1.Parameters.Add(New SqlParameter("@Fecha_Registro", SqlDbType.SmallDateTime)).Value = DateTimePicker_Registro.Text
            conex1.Parameters.Add(New SqlParameter("@Solicitud", SqlDbType.NChar, 10)).Value = Me.TB_Solicitud.Text
            conex1.Parameters.Add(New SqlParameter("@No_Activo", SqlDbType.NVarChar, 5)).Value = Me.Label_Activo1.Text
            conex1.Parameters.Add(New SqlParameter("@Cve_Categoria", SqlDbType.NChar, 10)).Value = Me.TBCveCategoria.Text
            conex1.Parameters.Add(New SqlParameter("@Cve_SubCategoria", SqlDbType.NChar, 10)).Value = Me.TB_SubCategoria_A1.Text
            'conex1.Parameters.Add(New SqlParameter("@Cve_Pro", SqlDbType.NVarChar, 2)).Value = Mid(Me.Label21.Text, 1, 2)
            conex1.Parameters.Add(New SqlParameter("@Descripcion", SqlDbType.NVarChar, 50)).Value = Me.CB_A1.Text
            conex1.Parameters.Add(New SqlParameter("@Marca", SqlDbType.NChar, 10)).Value = Me.TB_Marca1.Text
            conex1.Parameters.Add(New SqlParameter("@Modelo", SqlDbType.NVarChar, 50)).Value = Me.TB_Modelo1.Text
            conex1.Parameters.Add(New SqlParameter("@Serie", SqlDbType.NChar, 20)).Value = Me.TB_Serie1.Text
            conex1.Parameters.Add(New SqlParameter("@No_Factura", SqlDbType.NChar, 20)).Value = Me.TB_NoFactura1.Text
            conex1.Parameters.Add(New SqlParameter("@Fecha_Factura", SqlDbType.SmallDateTime)).Value = DateTimePicker_Factura1.Text
            conex1.Parameters.Add(New SqlParameter("@Cantidad_Articulos", SqlDbType.Int)).Value = Val(NUpDown_CanArt1.Text)
            conex1.Parameters.Add(New SqlParameter("@Costo_Unitario", SqlDbType.Int)).Value = Val(TB_CostoUnit1.Text)
            conex1.Parameters.Add(New SqlParameter("@Costo_Total", SqlDbType.Int)).Value = Val(TB_CostoTotal1.Text)
            conex1.Parameters.Add(New SqlParameter("@Act", SqlDbType.NChar, 2)).Value = "1"
            conex1.CommandText = Insar1
            conex1.ExecuteNonQuery()
            'MsgBox("Datos guardados correctamente", , "Guardar")
            Me.SqlConnection1.Close()
            'Call mostrar()
        Catch es As Exception
            MsgBox(es.ToString)
        End Try
    End Sub
    Sub movimiento_alta2()
        Try
            Me.SqlConnection1.Open()
            Dim Insar2 As String = "INSERT INTO Patrimonio (Folio,Fecha_Registro,Solicitud,No_Activo,Cve_Categoria,Cve_SubCategoria,Descripcion,Marca,Modelo,Serie,No_Factura,Fecha_Factura,Cantidad_Articulos,Costo_Unitario,Costo_Total,Departamento,Titular,Act) values(@Folio,@Fecha_Registro,@Solicitud,@No_Activo,@Cve_Categoria,@Cve_SubCategoria,@Descripcion,@Marca,@Modelo,@Serie,@No_Factura,@Fecha_Factura,@Cantidad_Articulos,@Costo_Unitario,@Costo_Total,@Departamento,@Titular,@Act)"
            Dim conex2 As New SqlClient.SqlCommand(Insar2, Me.SqlConnection1)
            conex2.Parameters.Add(New SqlParameter("@Folio", SqlDbType.Int, 4)).Value = Me.TBFolio.Text
            conex2.Parameters.Add(New SqlParameter("@Departamento", SqlDbType.NVarChar, 50)).Value = Me.CB_Departamento.Text
            conex2.Parameters.Add(New SqlParameter("@Titular", SqlDbType.NVarChar, 50)).Value = Me.CB_Responsable.Text
            conex2.Parameters.Add(New SqlParameter("@Fecha_Registro", SqlDbType.SmallDateTime)).Value = DateTimePicker_Registro.Text
            conex2.Parameters.Add(New SqlParameter("@Solicitud", SqlDbType.NChar, 10)).Value = Me.TB_Solicitud.Text
            conex2.Parameters.Add(New SqlParameter("@No_Activo", SqlDbType.NVarChar, 5)).Value = Me.Label_Activo2.Text
            conex2.Parameters.Add(New SqlParameter("@Cve_Categoria", SqlDbType.NChar, 10)).Value = Me.TBCveCategoria.Text
            conex2.Parameters.Add(New SqlParameter("@Cve_SubCategoria", SqlDbType.NChar, 10)).Value = Me.TB_SubCategoria_A2.Text
            conex2.Parameters.Add(New SqlParameter("@Descripcion", SqlDbType.NVarChar, 50)).Value = Me.CB_A2.Text
            conex2.Parameters.Add(New SqlParameter("@Marca", SqlDbType.NChar, 10)).Value = Me.TB_Marca2.Text
            conex2.Parameters.Add(New SqlParameter("@Modelo", SqlDbType.NVarChar, 50)).Value = Me.TB_Modelo2.Text
            conex2.Parameters.Add(New SqlParameter("@Serie", SqlDbType.NChar, 20)).Value = Me.TB_Serie2.Text
            conex2.Parameters.Add(New SqlParameter("@No_Factura", SqlDbType.NChar, 20)).Value = Me.TB_NoFactura2.Text
            conex2.Parameters.Add(New SqlParameter("@Fecha_Factura", SqlDbType.SmallDateTime)).Value = DateTimePicker_Factura2.Text
            conex2.Parameters.Add(New SqlParameter("@Cantidad_Articulos", SqlDbType.Int)).Value = Val(NUpDown_CanArt2.Text)
            conex2.Parameters.Add(New SqlParameter("@Costo_Unitario", SqlDbType.Int)).Value = Val(TB_CostoUnit2.Text)
            conex2.Parameters.Add(New SqlParameter("@Costo_Total", SqlDbType.Int)).Value = Val(TB_CostoTotal2.Text)
            conex2.Parameters.Add(New SqlParameter("@Act", SqlDbType.NChar, 2)).Value = "2"
            conex2.CommandText = Insar2
            conex2.ExecuteNonQuery()
            Me.SqlConnection1.Close()
        Catch es As Exception
            MsgBox(es.ToString)
        End Try
    End Sub
    Sub movimiento_alta3()
        Try
            Me.SqlConnection1.Open()
            Dim Insar3 As String = "INSERT INTO Patrimonio (Folio,Fecha_Registro,Solicitud,No_Activo,Cve_Categoria,Cve_SubCategoria,Descripcion,Marca,Modelo,Serie,No_Factura,Fecha_Factura,Cantidad_Articulos,Costo_Unitario,Costo_Total,Departamento,Titular,Act) values(@Folio,@Fecha_Registro,@Solicitud,@No_Activo,@Cve_Categoria,@Cve_SubCategoria,@Descripcion,@Marca,@Modelo,@Serie,@No_Factura,@Fecha_Factura,@Cantidad_Articulos,@Costo_Unitario,@Costo_Total,@Departamento,@Titular,@Act)"
            Dim conex3 As New SqlClient.SqlCommand(Insar3, Me.SqlConnection1)
            conex3.Parameters.Add(New SqlParameter("@Folio", SqlDbType.Int, 4)).Value = Me.TBFolio.Text
            conex3.Parameters.Add(New SqlParameter("@Departamento", SqlDbType.NVarChar, 50)).Value = Me.CB_Departamento.Text
            conex3.Parameters.Add(New SqlParameter("@Titular", SqlDbType.NVarChar, 50)).Value = Me.CB_Responsable.Text
            conex3.Parameters.Add(New SqlParameter("@Fecha_Registro", SqlDbType.SmallDateTime)).Value = DateTimePicker_Registro.Text
            conex3.Parameters.Add(New SqlParameter("@Solicitud", SqlDbType.NChar, 10)).Value = Me.TB_Solicitud.Text
            conex3.Parameters.Add(New SqlParameter("@No_Activo", SqlDbType.NVarChar, 5)).Value = Me.Label_Activo3.Text
            conex3.Parameters.Add(New SqlParameter("@Cve_Categoria", SqlDbType.NChar, 10)).Value = Me.TBCveCategoria.Text
            conex3.Parameters.Add(New SqlParameter("@Cve_SubCategoria", SqlDbType.NChar, 10)).Value = Me.TB_SubCategoria_A3.Text
            conex3.Parameters.Add(New SqlParameter("@Descripcion", SqlDbType.NVarChar, 50)).Value = Me.CB_A3.Text
            conex3.Parameters.Add(New SqlParameter("@Marca", SqlDbType.NChar, 10)).Value = Me.TB_Marca3.Text
            conex3.Parameters.Add(New SqlParameter("@Modelo", SqlDbType.NVarChar, 50)).Value = Me.TB_Modelo3.Text
            conex3.Parameters.Add(New SqlParameter("@Serie", SqlDbType.NChar, 20)).Value = Me.TB_Serie3.Text
            conex3.Parameters.Add(New SqlParameter("@No_Factura", SqlDbType.NChar, 20)).Value = Me.TB_NoFactura3.Text
            conex3.Parameters.Add(New SqlParameter("@Fecha_Factura", SqlDbType.SmallDateTime)).Value = DateTimePicker_Factura3.Text
            conex3.Parameters.Add(New SqlParameter("@Cantidad_Articulos", SqlDbType.Int)).Value = Val(NUpDown_CanArt3.Text)
            conex3.Parameters.Add(New SqlParameter("@Costo_Unitario", SqlDbType.Int)).Value = Val(TB_CostoUnit3.Text)
            conex3.Parameters.Add(New SqlParameter("@Costo_Total", SqlDbType.Int)).Value = Val(TB_CostoTotal3.Text)
            conex3.Parameters.Add(New SqlParameter("@Act", SqlDbType.NChar, 2)).Value = "3"
            conex3.CommandText = Insar3
            conex3.ExecuteNonQuery()
            Me.SqlConnection1.Close()
        Catch es As Exception
            MsgBox(es.ToString)
        End Try
    End Sub
    Sub movimiento_alta4()
        Try
            Me.SqlConnection1.Open()
            Dim Insar4 As String = "INSERT INTO Patrimonio (Folio,Fecha_Registro,Solicitud,No_Activo,Cve_Categoria,Cve_SubCategoria,Descripcion,Marca,Modelo,Serie,No_Factura,Fecha_Factura,Cantidad_Articulos,Costo_Unitario,Costo_Total,Departamento,Titular,Act) values(@Folio,@Fecha_Registro,@Solicitud,@No_Activo,@Cve_Categoria,@Cve_SubCategoria,@Descripcion,@Marca,@Modelo,@Serie,@No_Factura,@Fecha_Factura,@Cantidad_Articulos,@Costo_Unitario,@Costo_Total,@Departamento,@Titular,@Act)"
            Dim conex4 As New SqlClient.SqlCommand(Insar4, Me.SqlConnection1)
            conex4.Parameters.Add(New SqlParameter("@Folio", SqlDbType.Int, 4)).Value = Me.TBFolio.Text
            conex4.Parameters.Add(New SqlParameter("@Departamento", SqlDbType.NVarChar, 50)).Value = Me.CB_Departamento.Text
            conex4.Parameters.Add(New SqlParameter("@Titular", SqlDbType.NVarChar, 50)).Value = Me.CB_Responsable.Text
            conex4.Parameters.Add(New SqlParameter("@Fecha_Registro", SqlDbType.SmallDateTime)).Value = DateTimePicker_Registro.Text
            conex4.Parameters.Add(New SqlParameter("@Solicitud", SqlDbType.NChar, 10)).Value = Me.TB_Solicitud.Text
            conex4.Parameters.Add(New SqlParameter("@No_Activo", SqlDbType.NVarChar, 5)).Value = Me.Label_Activo4.Text
            conex4.Parameters.Add(New SqlParameter("@Cve_Categoria", SqlDbType.NChar, 10)).Value = Me.TBCveCategoria.Text
            conex4.Parameters.Add(New SqlParameter("@Cve_SubCategoria", SqlDbType.NChar, 10)).Value = Me.TB_SubCategoria_A4.Text
            conex4.Parameters.Add(New SqlParameter("@Descripcion", SqlDbType.NVarChar, 50)).Value = Me.CB_A4.Text
            conex4.Parameters.Add(New SqlParameter("@Marca", SqlDbType.NChar, 10)).Value = Me.TB_Marca4.Text
            conex4.Parameters.Add(New SqlParameter("@Modelo", SqlDbType.NVarChar, 50)).Value = Me.TB_Modelo4.Text
            conex4.Parameters.Add(New SqlParameter("@Serie", SqlDbType.NChar, 20)).Value = Me.TB_Serie4.Text
            conex4.Parameters.Add(New SqlParameter("@No_Factura", SqlDbType.NChar, 20)).Value = Me.TB_NoFactura4.Text
            conex4.Parameters.Add(New SqlParameter("@Fecha_Factura", SqlDbType.SmallDateTime)).Value = DateTimePicker_Factura4.Text
            conex4.Parameters.Add(New SqlParameter("@Cantidad_Articulos", SqlDbType.Int)).Value = Val(NUpDown_CanArt4.Text)
            conex4.Parameters.Add(New SqlParameter("@Costo_Unitario", SqlDbType.Int)).Value = Val(TB_CostoUnit4.Text)
            conex4.Parameters.Add(New SqlParameter("@Costo_Total", SqlDbType.Int)).Value = Val(TB_CostoTotal4.Text)
            conex4.Parameters.Add(New SqlParameter("@Act", SqlDbType.NChar, 2)).Value = "4"
            conex4.CommandText = Insar4
            conex4.ExecuteNonQuery()
            Me.SqlConnection1.Close()
        Catch es As Exception
            MsgBox(es.ToString)
        End Try
    End Sub
    Sub movimiento_alta5()
        Try
            Me.SqlConnection1.Open()
            Dim Insar5 As String = "INSERT INTO Patrimonio (Folio,Fecha_Registro,Solicitud,No_Activo,Cve_Categoria,Cve_SubCategoria,Descripcion,Marca,Modelo,Serie,No_Factura,Fecha_Factura,Cantidad_Articulos,Costo_Unitario,Costo_Total,Departamento,Titular,Act) values(@Folio,@Fecha_Registro,@Solicitud,@No_Activo,@Cve_Categoria,@Cve_SubCategoria,@Descripcion,@Marca,@Modelo,@Serie,@No_Factura,@Fecha_Factura,@Cantidad_Articulos,@Costo_Unitario,@Costo_Total,@Departamento,@Titular,@Act)"
            Dim conex5 As New SqlClient.SqlCommand(Insar5, Me.SqlConnection1)
            conex5.Parameters.Add(New SqlParameter("@Folio", SqlDbType.Int, 4)).Value = Me.TBFolio.Text
            conex5.Parameters.Add(New SqlParameter("@Departamento", SqlDbType.NVarChar, 50)).Value = Me.CB_Departamento.Text
            conex5.Parameters.Add(New SqlParameter("@Titular", SqlDbType.NVarChar, 50)).Value = Me.CB_Responsable.Text
            conex5.Parameters.Add(New SqlParameter("@Fecha_Registro", SqlDbType.SmallDateTime)).Value = DateTimePicker_Registro.Text
            conex5.Parameters.Add(New SqlParameter("@Solicitud", SqlDbType.NChar, 10)).Value = Me.TB_Solicitud.Text
            conex5.Parameters.Add(New SqlParameter("@No_Activo", SqlDbType.NVarChar, 5)).Value = Me.Label_Activo5.Text
            conex5.Parameters.Add(New SqlParameter("@Cve_Categoria", SqlDbType.NChar, 10)).Value = Me.TBCveCategoria.Text
            conex5.Parameters.Add(New SqlParameter("@Cve_SubCategoria", SqlDbType.NChar, 10)).Value = Me.TB_SubCategoria_A5.Text
            conex5.Parameters.Add(New SqlParameter("@Descripcion", SqlDbType.NVarChar, 50)).Value = Me.CB_A5.Text
            conex5.Parameters.Add(New SqlParameter("@Marca", SqlDbType.NChar, 10)).Value = Me.TB_Marca5.Text
            conex5.Parameters.Add(New SqlParameter("@Modelo", SqlDbType.NVarChar, 50)).Value = Me.TB_Modelo5.Text
            conex5.Parameters.Add(New SqlParameter("@Serie", SqlDbType.NChar, 20)).Value = Me.TB_Serie5.Text
            conex5.Parameters.Add(New SqlParameter("@No_Factura", SqlDbType.NChar, 20)).Value = Me.TB_NoFactura5.Text
            conex5.Parameters.Add(New SqlParameter("@Fecha_Factura", SqlDbType.SmallDateTime)).Value = DateTimePicker_Factura5.Text
            conex5.Parameters.Add(New SqlParameter("@Cantidad_Articulos", SqlDbType.Int)).Value = Val(NUpDown_CanArt5.Text)
            conex5.Parameters.Add(New SqlParameter("@Costo_Unitario", SqlDbType.Int)).Value = Val(TB_CostoUnit5.Text)
            conex5.Parameters.Add(New SqlParameter("@Costo_Total", SqlDbType.Int)).Value = Val(TB_CostoTotal5.Text)
            conex5.Parameters.Add(New SqlParameter("@Act", SqlDbType.NChar, 2)).Value = "5"
            conex5.CommandText = Insar5
            conex5.ExecuteNonQuery()
            Me.SqlConnection1.Close()
        Catch es As Exception
            MsgBox(es.ToString)
        End Try
    End Sub
    Sub movimiento_alta6()
        Try
            Me.SqlConnection1.Open()
            Dim Insar6 As String = "INSERT INTO Patrimonio (Folio,Fecha_Registro,Solicitud,No_Activo,Cve_Categoria,Cve_SubCategoria,Descripcion,Marca,Modelo,Serie,No_Factura,Fecha_Factura,Cantidad_Articulos,Costo_Unitario,Costo_Total,Departamento,Titular,Act) values(@Folio,@Fecha_Registro,@Solicitud,@No_Activo,@Cve_Categoria,@Cve_SubCategoria,@Descripcion,@Marca,@Modelo,@Serie,@No_Factura,@Fecha_Factura,@Cantidad_Articulos,@Costo_Unitario,@Costo_Total,@Departamento,@Titular,@Act)"
            Dim conex6 As New SqlClient.SqlCommand(Insar6, Me.SqlConnection1)
            conex6.Parameters.Add(New SqlParameter("@Folio", SqlDbType.Int, 4)).Value = Me.TBFolio.Text
            conex6.Parameters.Add(New SqlParameter("@Departamento", SqlDbType.NVarChar, 50)).Value = Me.CB_Departamento.Text
            conex6.Parameters.Add(New SqlParameter("@Titular", SqlDbType.NVarChar, 50)).Value = Me.CB_Responsable.Text
            conex6.Parameters.Add(New SqlParameter("@Fecha_Registro", SqlDbType.SmallDateTime)).Value = DateTimePicker_Registro.Text
            conex6.Parameters.Add(New SqlParameter("@Solicitud", SqlDbType.NChar, 10)).Value = Me.TB_Solicitud.Text
            conex6.Parameters.Add(New SqlParameter("@No_Activo", SqlDbType.NVarChar, 5)).Value = Me.Label_Activo6.Text
            conex6.Parameters.Add(New SqlParameter("@Cve_Categoria", SqlDbType.NChar, 10)).Value = Me.TBCveCategoria.Text
            conex6.Parameters.Add(New SqlParameter("@Cve_SubCategoria", SqlDbType.NChar, 10)).Value = Me.TB_SubCategoria_A6.Text
            conex6.Parameters.Add(New SqlParameter("@Descripcion", SqlDbType.NVarChar, 50)).Value = Me.CB_A6.Text
            conex6.Parameters.Add(New SqlParameter("@Marca", SqlDbType.NChar, 10)).Value = Me.TB_Marca6.Text
            conex6.Parameters.Add(New SqlParameter("@Modelo", SqlDbType.NVarChar, 50)).Value = Me.TB_Modelo6.Text
            conex6.Parameters.Add(New SqlParameter("@Serie", SqlDbType.NChar, 20)).Value = Me.TB_Serie6.Text
            conex6.Parameters.Add(New SqlParameter("@No_Factura", SqlDbType.NChar, 20)).Value = Me.TB_NoFactura6.Text
            conex6.Parameters.Add(New SqlParameter("@Fecha_Factura", SqlDbType.SmallDateTime)).Value = DateTimePicker_Factura6.Text
            conex6.Parameters.Add(New SqlParameter("@Cantidad_Articulos", SqlDbType.Int)).Value = Val(NUpDown_CanArt6.Text)
            conex6.Parameters.Add(New SqlParameter("@Costo_Unitario", SqlDbType.Int)).Value = Val(TB_CostoUnit6.Text)
            conex6.Parameters.Add(New SqlParameter("@Costo_Total", SqlDbType.Int)).Value = Val(TB_CostoTotal6.Text)
            conex6.Parameters.Add(New SqlParameter("@Act", SqlDbType.NChar, 2)).Value = "6"
            conex6.CommandText = Insar6
            conex6.ExecuteNonQuery()
            Me.SqlConnection1.Close()
        Catch es As Exception
            MsgBox(es.ToString)
        End Try
    End Sub
    Sub movimiento_alta7()
        Try
            Me.SqlConnection1.Open()
            Dim Insar7 As String = "INSERT INTO Patrimonio (Folio,Fecha_Registro,Solicitud,No_Activo,Cve_Categoria,Cve_SubCategoria,Descripcion,Marca,Modelo,Serie,No_Factura,Fecha_Factura,Cantidad_Articulos,Costo_Unitario,Costo_Total,Departamento,Titular,Act) values(@Folio,@Fecha_Registro,@Solicitud,@No_Activo,@Cve_Categoria,@Cve_SubCategoria,@Descripcion,@Marca,@Modelo,@Serie,@No_Factura,@Fecha_Factura,@Cantidad_Articulos,@Costo_Unitario,@Costo_Total,@Departamento,@Titular,@Act)"
            Dim conex7 As New SqlClient.SqlCommand(Insar7, Me.SqlConnection1)
            conex7.Parameters.Add(New SqlParameter("@Folio", SqlDbType.Int, 4)).Value = Me.TBFolio.Text
            conex7.Parameters.Add(New SqlParameter("@Departamento", SqlDbType.NVarChar, 50)).Value = Me.CB_Departamento.Text
            conex7.Parameters.Add(New SqlParameter("@Titular", SqlDbType.NVarChar, 50)).Value = Me.CB_Responsable.Text
            conex7.Parameters.Add(New SqlParameter("@Fecha_Registro", SqlDbType.SmallDateTime)).Value = DateTimePicker_Registro.Text
            conex7.Parameters.Add(New SqlParameter("@Solicitud", SqlDbType.NChar, 10)).Value = Me.TB_Solicitud.Text
            conex7.Parameters.Add(New SqlParameter("@No_Activo", SqlDbType.NVarChar, 5)).Value = Me.Label_Activo7.Text
            conex7.Parameters.Add(New SqlParameter("@Cve_Categoria", SqlDbType.NChar, 10)).Value = Me.TBCveCategoria.Text
            conex7.Parameters.Add(New SqlParameter("@Cve_SubCategoria", SqlDbType.NChar, 10)).Value = Me.TB_SubCategoria_A7.Text
            conex7.Parameters.Add(New SqlParameter("@Descripcion", SqlDbType.NVarChar, 50)).Value = Me.CB_A7.Text
            conex7.Parameters.Add(New SqlParameter("@Marca", SqlDbType.NChar, 10)).Value = Me.TB_Marca7.Text
            conex7.Parameters.Add(New SqlParameter("@Modelo", SqlDbType.NVarChar, 50)).Value = Me.TB_Modelo7.Text
            conex7.Parameters.Add(New SqlParameter("@Serie", SqlDbType.NChar, 20)).Value = Me.TB_Serie7.Text
            conex7.Parameters.Add(New SqlParameter("@No_Factura", SqlDbType.NChar, 20)).Value = Me.TB_NoFactura7.Text
            conex7.Parameters.Add(New SqlParameter("@Fecha_Factura", SqlDbType.SmallDateTime)).Value = DateTimePicker_Factura7.Text
            conex7.Parameters.Add(New SqlParameter("@Cantidad_Articulos", SqlDbType.Int)).Value = Val(NUpDown_CanArt7.Text)
            conex7.Parameters.Add(New SqlParameter("@Costo_Unitario", SqlDbType.Int)).Value = Val(TB_CostoUnit7.Text)
            conex7.Parameters.Add(New SqlParameter("@Costo_Total", SqlDbType.Int)).Value = Val(TB_CostoTotal7.Text)
            conex7.Parameters.Add(New SqlParameter("@Act", SqlDbType.NChar, 2)).Value = "7"
            conex7.CommandText = Insar7
            conex7.ExecuteNonQuery()
            Me.SqlConnection1.Close()
        Catch es As Exception
            MsgBox(es.ToString)
        End Try
    End Sub
    Sub movimiento_alta8()
        Try
            Me.SqlConnection1.Open()
            Dim Insar8 As String = "INSERT INTO Patrimonio (Folio,Fecha_Registro,Solicitud,No_Activo,Cve_Categoria,Cve_SubCategoria,Descripcion,Marca,Modelo,Serie,No_Factura,Fecha_Factura,Cantidad_Articulos,Costo_Unitario,Costo_Total,Departamento,Titular,Act) values(@Folio,@Fecha_Registro,@Solicitud,@No_Activo,@Cve_Categoria,@Cve_SubCategoria,@Descripcion,@Marca,@Modelo,@Serie,@No_Factura,@Fecha_Factura,@Cantidad_Articulos,@Costo_Unitario,@Costo_Total,@Departamento,@Titular,@Act)"
            Dim conex8 As New SqlClient.SqlCommand(Insar8, Me.SqlConnection1)
            conex8.Parameters.Add(New SqlParameter("@Folio", SqlDbType.Int, 4)).Value = Me.TBFolio.Text
            conex8.Parameters.Add(New SqlParameter("@Departamento", SqlDbType.NVarChar, 50)).Value = Me.CB_Departamento.Text
            conex8.Parameters.Add(New SqlParameter("@Titular", SqlDbType.NVarChar, 50)).Value = Me.CB_Responsable.Text
            conex8.Parameters.Add(New SqlParameter("@Fecha_Registro", SqlDbType.SmallDateTime)).Value = DateTimePicker_Registro.Text
            conex8.Parameters.Add(New SqlParameter("@Solicitud", SqlDbType.NChar, 10)).Value = Me.TB_Solicitud.Text
            conex8.Parameters.Add(New SqlParameter("@No_Activo", SqlDbType.NVarChar, 5)).Value = Me.Label_Activo8.Text
            conex8.Parameters.Add(New SqlParameter("@Cve_Categoria", SqlDbType.NChar, 10)).Value = Me.TBCveCategoria.Text
            conex8.Parameters.Add(New SqlParameter("@Cve_SubCategoria", SqlDbType.NChar, 10)).Value = Me.TB_SubCategoria_A8.Text
            conex8.Parameters.Add(New SqlParameter("@Descripcion", SqlDbType.NVarChar, 50)).Value = Me.CB_A8.Text
            conex8.Parameters.Add(New SqlParameter("@Marca", SqlDbType.NChar, 10)).Value = Me.TB_Marca8.Text
            conex8.Parameters.Add(New SqlParameter("@Modelo", SqlDbType.NVarChar, 50)).Value = Me.TB_Modelo8.Text
            conex8.Parameters.Add(New SqlParameter("@Serie", SqlDbType.NChar, 20)).Value = Me.TB_Serie8.Text
            conex8.Parameters.Add(New SqlParameter("@No_Factura", SqlDbType.NChar, 20)).Value = Me.TB_NoFactura8.Text
            conex8.Parameters.Add(New SqlParameter("@Fecha_Factura", SqlDbType.SmallDateTime)).Value = DateTimePicker_Factura8.Text
            conex8.Parameters.Add(New SqlParameter("@Cantidad_Articulos", SqlDbType.Int)).Value = Val(NUpDown_CanArt8.Text)
            conex8.Parameters.Add(New SqlParameter("@Costo_Unitario", SqlDbType.Int)).Value = Val(TB_CostoUnit8.Text)
            conex8.Parameters.Add(New SqlParameter("@Costo_Total", SqlDbType.Int)).Value = Val(TB_CostoTotal8.Text)
            conex8.Parameters.Add(New SqlParameter("@Act", SqlDbType.NChar, 2)).Value = "8"
            conex8.CommandText = Insar8
            conex8.ExecuteNonQuery()
            Me.SqlConnection1.Close()
        Catch es As Exception
            MsgBox(es.ToString)
        End Try
    End Sub
    Sub movimiento_alta9()
        Try
            Me.SqlConnection1.Open()
            Dim Insar9 As String = "INSERT INTO Patrimonio (Folio,Fecha_Registro,Solicitud,No_Activo,Cve_Categoria,Cve_SubCategoria,Descripcion,Marca,Modelo,Serie,No_Factura,Fecha_Factura,Cantidad_Articulos,Costo_Unitario,Costo_Total,Departamento,Titular,Act) values(@Folio,@Fecha_Registro,@Solicitud,@No_Activo,@Cve_Categoria,@Cve_SubCategoria,@Descripcion,@Marca,@Modelo,@Serie,@No_Factura,@Fecha_Factura,@Cantidad_Articulos,@Costo_Unitario,@Costo_Total,@Departamento,@Titular,@Act)"
            Dim conex9 As New SqlClient.SqlCommand(Insar9, Me.SqlConnection1)
            conex9.Parameters.Add(New SqlParameter("@Folio", SqlDbType.Int, 4)).Value = Me.TBFolio.Text
            conex9.Parameters.Add(New SqlParameter("@Departamento", SqlDbType.NVarChar, 50)).Value = Me.CB_Departamento.Text
            conex9.Parameters.Add(New SqlParameter("@Titular", SqlDbType.NVarChar, 50)).Value = Me.CB_Responsable.Text
            conex9.Parameters.Add(New SqlParameter("@Fecha_Registro", SqlDbType.SmallDateTime)).Value = DateTimePicker_Registro.Text
            conex9.Parameters.Add(New SqlParameter("@Solicitud", SqlDbType.NChar, 10)).Value = Me.TB_Solicitud.Text
            conex9.Parameters.Add(New SqlParameter("@No_Activo", SqlDbType.NVarChar, 5)).Value = Me.Label_Activo9.Text
            conex9.Parameters.Add(New SqlParameter("@Cve_Categoria", SqlDbType.NChar, 10)).Value = Me.TBCveCategoria.Text
            conex9.Parameters.Add(New SqlParameter("@Cve_SubCategoria", SqlDbType.NChar, 10)).Value = Me.TB_SubCategoria_A9.Text
            conex9.Parameters.Add(New SqlParameter("@Descripcion", SqlDbType.NVarChar, 50)).Value = Me.CB_A9.Text
            conex9.Parameters.Add(New SqlParameter("@Marca", SqlDbType.NChar, 10)).Value = Me.TB_Marca9.Text
            conex9.Parameters.Add(New SqlParameter("@Modelo", SqlDbType.NVarChar, 50)).Value = Me.TB_Modelo9.Text
            conex9.Parameters.Add(New SqlParameter("@Serie", SqlDbType.NChar, 20)).Value = Me.TB_Serie9.Text
            conex9.Parameters.Add(New SqlParameter("@No_Factura", SqlDbType.NChar, 20)).Value = Me.TB_NoFactura9.Text
            conex9.Parameters.Add(New SqlParameter("@Fecha_Factura", SqlDbType.SmallDateTime)).Value = DateTimePicker_Factura9.Text
            conex9.Parameters.Add(New SqlParameter("@Cantidad_Articulos", SqlDbType.Int)).Value = Val(NUpDown_CanArt9.Text)
            conex9.Parameters.Add(New SqlParameter("@Costo_Unitario", SqlDbType.Int)).Value = Val(TB_CostoUnit9.Text)
            conex9.Parameters.Add(New SqlParameter("@Costo_Total", SqlDbType.Int)).Value = Val(TB_CostoTotal9.Text)
            conex9.Parameters.Add(New SqlParameter("@Act", SqlDbType.NChar, 2)).Value = "9"
            conex9.CommandText = Insar9
            conex9.ExecuteNonQuery()
            Me.SqlConnection1.Close()
        Catch es As Exception
            MsgBox(es.ToString)
        End Try
    End Sub
    Sub movimiento_alta10()
        Try
            Me.SqlConnection1.Open()
            Dim Insar10 As String = "INSERT INTO Patrimonio (Folio,Fecha_Registro,Solicitud,No_Activo,Cve_Categoria,Cve_SubCategoria,Descripcion,Marca,Modelo,Serie,No_Factura,Fecha_Factura,Cantidad_Articulos,Costo_Unitario,Costo_Total,Departamento,Titular,Act) values(@Folio,@Fecha_Registro,@Solicitud,@No_Activo,@Cve_Categoria,@Cve_SubCategoria,@Descripcion,@Marca,@Modelo,@Serie,@No_Factura,@Fecha_Factura,@Cantidad_Articulos,@Costo_Unitario,@Costo_Total,@Departamento,@Titular,@Act)"
            Dim conex10 As New SqlClient.SqlCommand(Insar10, Me.SqlConnection1)
            conex10.Parameters.Add(New SqlParameter("@Folio", SqlDbType.Int, 4)).Value = Me.TBFolio.Text
            conex10.Parameters.Add(New SqlParameter("@Departamento", SqlDbType.NVarChar, 50)).Value = Me.CB_Departamento.Text
            conex10.Parameters.Add(New SqlParameter("@Titular", SqlDbType.NVarChar, 50)).Value = Me.CB_Responsable.Text
            conex10.Parameters.Add(New SqlParameter("@Fecha_Registro", SqlDbType.SmallDateTime)).Value = DateTimePicker_Registro.Text
            conex10.Parameters.Add(New SqlParameter("@Solicitud", SqlDbType.NChar, 10)).Value = Me.TB_Solicitud.Text
            conex10.Parameters.Add(New SqlParameter("@No_Activo", SqlDbType.NVarChar, 5)).Value = Me.Label_Activo10.Text
            conex10.Parameters.Add(New SqlParameter("@Cve_Categoria", SqlDbType.NChar, 10)).Value = Me.TBCveCategoria.Text
            conex10.Parameters.Add(New SqlParameter("@Cve_SubCategoria", SqlDbType.NChar, 10)).Value = Me.TB_SubCategoria_A10.Text
            conex10.Parameters.Add(New SqlParameter("@Descripcion", SqlDbType.NVarChar, 50)).Value = Me.CB_A10.Text
            conex10.Parameters.Add(New SqlParameter("@Marca", SqlDbType.NChar, 10)).Value = Me.TB_Marca10.Text
            conex10.Parameters.Add(New SqlParameter("@Modelo", SqlDbType.NVarChar, 50)).Value = Me.TB_Modelo10.Text
            conex10.Parameters.Add(New SqlParameter("@Serie", SqlDbType.NChar, 20)).Value = Me.TB_Serie10.Text
            conex10.Parameters.Add(New SqlParameter("@No_Factura", SqlDbType.NChar, 20)).Value = Me.TB_NoFactura10.Text
            conex10.Parameters.Add(New SqlParameter("@Fecha_Factura", SqlDbType.SmallDateTime)).Value = DateTimePicker_Factura10.Text
            conex10.Parameters.Add(New SqlParameter("@Cantidad_Articulos", SqlDbType.Int)).Value = Val(NUpDown_CanArt10.Text)
            conex10.Parameters.Add(New SqlParameter("@Costo_Unitario", SqlDbType.Int)).Value = Val(TB_CostoUnit10.Text)
            conex10.Parameters.Add(New SqlParameter("@Costo_Total", SqlDbType.Int)).Value = Val(TB_CostoTotal10.Text)
            conex10.Parameters.Add(New SqlParameter("@Act", SqlDbType.NChar, 2)).Value = "10"
            conex10.CommandText = Insar10
            conex10.ExecuteNonQuery()
            Me.SqlConnection1.Close()
        Catch es As Exception
            MsgBox(es.ToString)
        End Try
    End Sub
    Sub movimiento_alta11()
        Try
            Me.SqlConnection1.Open()
            Dim Insar11 As String = "INSERT INTO Patrimonio (Folio,Fecha_Registro,Solicitud,No_Activo,Cve_Categoria,Cve_SubCategoria,Descripcion,Marca,Modelo,Serie,No_Factura,Fecha_Factura,Cantidad_Articulos,Costo_Unitario,Costo_Total,Departamento,Titular,Act) values(@Folio,@Fecha_Registro,@Solicitud,@No_Activo,@Cve_Categoria,@Cve_SubCategoria,@Descripcion,@Marca,@Modelo,@Serie,@No_Factura,@Fecha_Factura,@Cantidad_Articulos,@Costo_Unitario,@Costo_Total,@Departamento,@Titular,@Act)"
            Dim conex11 As New SqlClient.SqlCommand(Insar11, Me.SqlConnection1)
            conex11.Parameters.Add(New SqlParameter("@Folio", SqlDbType.Int, 4)).Value = Me.TBFolio.Text
            conex11.Parameters.Add(New SqlParameter("@Departamento", SqlDbType.NVarChar, 50)).Value = Me.CB_Departamento.Text
            conex11.Parameters.Add(New SqlParameter("@Titular", SqlDbType.NVarChar, 50)).Value = Me.CB_Responsable.Text
            conex11.Parameters.Add(New SqlParameter("@Fecha_Registro", SqlDbType.SmallDateTime)).Value = DateTimePicker_Registro.Text
            conex11.Parameters.Add(New SqlParameter("@Solicitud", SqlDbType.NChar, 10)).Value = Me.TB_Solicitud.Text
            conex11.Parameters.Add(New SqlParameter("@No_Activo", SqlDbType.NVarChar, 5)).Value = Me.Label_Activo11.Text
            conex11.Parameters.Add(New SqlParameter("@Cve_Categoria", SqlDbType.NChar, 10)).Value = Me.TBCveCategoria.Text
            conex11.Parameters.Add(New SqlParameter("@Cve_SubCategoria", SqlDbType.NChar, 10)).Value = Me.TB_SubCategoria_A11.Text
            conex11.Parameters.Add(New SqlParameter("@Descripcion", SqlDbType.NVarChar, 50)).Value = Me.CB_A11.Text
            conex11.Parameters.Add(New SqlParameter("@Marca", SqlDbType.NChar, 10)).Value = Me.TB_Marca11.Text
            conex11.Parameters.Add(New SqlParameter("@Modelo", SqlDbType.NVarChar, 50)).Value = Me.TB_Modelo11.Text
            conex11.Parameters.Add(New SqlParameter("@Serie", SqlDbType.NChar, 20)).Value = Me.TB_Serie11.Text
            conex11.Parameters.Add(New SqlParameter("@No_Factura", SqlDbType.NChar, 20)).Value = Me.TB_NoFactura11.Text
            conex11.Parameters.Add(New SqlParameter("@Fecha_Factura", SqlDbType.SmallDateTime)).Value = DateTimePicker_Factura11.Text
            conex11.Parameters.Add(New SqlParameter("@Cantidad_Articulos", SqlDbType.Int)).Value = Val(NUpDown_CanArt11.Text)
            conex11.Parameters.Add(New SqlParameter("@Costo_Unitario", SqlDbType.Int)).Value = Val(TB_CostoUnit11.Text)
            conex11.Parameters.Add(New SqlParameter("@Costo_Total", SqlDbType.Int)).Value = Val(TB_CostoTotal11.Text)
            conex11.Parameters.Add(New SqlParameter("@Act", SqlDbType.NChar, 2)).Value = "11"
            conex11.CommandText = Insar11
            conex11.ExecuteNonQuery()
            Me.SqlConnection1.Close()
        Catch es As Exception
            MsgBox(es.ToString)
        End Try
    End Sub
    Sub movimiento_alta12()
        Try
            Me.SqlConnection1.Open()
            Dim Insar12 As String = "INSERT INTO Patrimonio (Folio,Fecha_Registro,Solicitud,No_Activo,Cve_Categoria,Cve_SubCategoria,Descripcion,Marca,Modelo,Serie,No_Factura,Fecha_Factura,Cantidad_Articulos,Costo_Unitario,Costo_Total,Departamento,Titular,Act) values(@Folio,@Fecha_Registro,@Solicitud,@No_Activo,@Cve_Categoria,@Cve_SubCategoria,@Descripcion,@Marca,@Modelo,@Serie,@No_Factura,@Fecha_Factura,@Cantidad_Articulos,@Costo_Unitario,@Costo_Total,@Departamento,@Titular,@Act)"
            Dim conex12 As New SqlClient.SqlCommand(Insar12, Me.SqlConnection1)
            conex12.Parameters.Add(New SqlParameter("@Folio", SqlDbType.Int, 4)).Value = Me.TBFolio.Text
            conex12.Parameters.Add(New SqlParameter("@Departamento", SqlDbType.NVarChar, 50)).Value = Me.CB_Departamento.Text
            conex12.Parameters.Add(New SqlParameter("@Titular", SqlDbType.NVarChar, 50)).Value = Me.CB_Responsable.Text
            conex12.Parameters.Add(New SqlParameter("@Fecha_Registro", SqlDbType.SmallDateTime)).Value = DateTimePicker_Registro.Text
            conex12.Parameters.Add(New SqlParameter("@Solicitud", SqlDbType.NChar, 10)).Value = Me.TB_Solicitud.Text
            conex12.Parameters.Add(New SqlParameter("@No_Activo", SqlDbType.NVarChar, 5)).Value = Me.Label_Activo12.Text
            conex12.Parameters.Add(New SqlParameter("@Cve_Categoria", SqlDbType.NChar, 10)).Value = Me.TBCveCategoria.Text
            conex12.Parameters.Add(New SqlParameter("@Cve_SubCategoria", SqlDbType.NChar, 10)).Value = Me.TB_SubCategoria_A12.Text
            conex12.Parameters.Add(New SqlParameter("@Descripcion", SqlDbType.NVarChar, 50)).Value = Me.CB_A12.Text
            conex12.Parameters.Add(New SqlParameter("@Marca", SqlDbType.NChar, 10)).Value = Me.TB_Marca12.Text
            conex12.Parameters.Add(New SqlParameter("@Modelo", SqlDbType.NVarChar, 50)).Value = Me.TB_Modelo12.Text
            conex12.Parameters.Add(New SqlParameter("@Serie", SqlDbType.NChar, 20)).Value = Me.TB_Serie12.Text
            conex12.Parameters.Add(New SqlParameter("@No_Factura", SqlDbType.NChar, 20)).Value = Me.TB_NoFactura12.Text
            conex12.Parameters.Add(New SqlParameter("@Fecha_Factura", SqlDbType.SmallDateTime)).Value = DateTimePicker_Factura12.Text
            conex12.Parameters.Add(New SqlParameter("@Cantidad_Articulos", SqlDbType.Int)).Value = Val(NUpDown_CanArt12.Text)
            conex12.Parameters.Add(New SqlParameter("@Costo_Unitario", SqlDbType.Int)).Value = Val(TB_CostoUnit12.Text)
            conex12.Parameters.Add(New SqlParameter("@Costo_Total", SqlDbType.Int)).Value = Val(TB_CostoTotal12.Text)
            conex12.Parameters.Add(New SqlParameter("@Act", SqlDbType.NChar, 2)).Value = "12"
            conex12.CommandText = Insar12
            conex12.ExecuteNonQuery()
            Me.SqlConnection1.Close()
        Catch es As Exception
            MsgBox(es.ToString)
        End Try
    End Sub
    Sub movimiento_alta13()
        Try
            Me.SqlConnection1.Open()
            Dim Insar13 As String = "INSERT INTO Patrimonio (Folio,Fecha_Registro,Solicitud,No_Activo,Cve_Categoria,Cve_SubCategoria,Descripcion,Marca,Modelo,Serie,No_Factura,Fecha_Factura,Cantidad_Articulos,Costo_Unitario,Costo_Total,Departamento,Titular,Act) values(@Folio,@Fecha_Registro,@Solicitud,@No_Activo,@Cve_Categoria,@Cve_SubCategoria,@Descripcion,@Marca,@Modelo,@Serie,@No_Factura,@Fecha_Factura,@Cantidad_Articulos,@Costo_Unitario,@Costo_Total,@Departamento,@Titular,@Act)"
            Dim conex13 As New SqlClient.SqlCommand(Insar13, Me.SqlConnection1)
            conex13.Parameters.Add(New SqlParameter("@Folio", SqlDbType.Int, 4)).Value = Me.TBFolio.Text
            conex13.Parameters.Add(New SqlParameter("@Departamento", SqlDbType.NVarChar, 50)).Value = Me.CB_Departamento.Text
            conex13.Parameters.Add(New SqlParameter("@Titular", SqlDbType.NVarChar, 50)).Value = Me.CB_Responsable.Text
            conex13.Parameters.Add(New SqlParameter("@Fecha_Registro", SqlDbType.SmallDateTime)).Value = DateTimePicker_Registro.Text
            conex13.Parameters.Add(New SqlParameter("@Solicitud", SqlDbType.NChar, 10)).Value = Me.TB_Solicitud.Text
            conex13.Parameters.Add(New SqlParameter("@No_Activo", SqlDbType.NVarChar, 5)).Value = Me.Label_Activo13.Text
            conex13.Parameters.Add(New SqlParameter("@Cve_Categoria", SqlDbType.NChar, 10)).Value = Me.TBCveCategoria.Text
            conex13.Parameters.Add(New SqlParameter("@Cve_SubCategoria", SqlDbType.NChar, 10)).Value = Me.TB_SubCategoria_A13.Text
            conex13.Parameters.Add(New SqlParameter("@Descripcion", SqlDbType.NVarChar, 50)).Value = Me.CB_A13.Text
            conex13.Parameters.Add(New SqlParameter("@Marca", SqlDbType.NChar, 10)).Value = Me.TB_Marca13.Text
            conex13.Parameters.Add(New SqlParameter("@Modelo", SqlDbType.NVarChar, 50)).Value = Me.TB_Modelo13.Text
            conex13.Parameters.Add(New SqlParameter("@Serie", SqlDbType.NChar, 20)).Value = Me.TB_Serie12.Text
            conex13.Parameters.Add(New SqlParameter("@No_Factura", SqlDbType.NChar, 20)).Value = Me.TB_NoFactura13.Text
            conex13.Parameters.Add(New SqlParameter("@Fecha_Factura", SqlDbType.SmallDateTime)).Value = DateTimePicker_Factura13.Text
            conex13.Parameters.Add(New SqlParameter("@Cantidad_Articulos", SqlDbType.Int)).Value = Val(NUpDown_CanArt13.Text)
            conex13.Parameters.Add(New SqlParameter("@Costo_Unitario", SqlDbType.Int)).Value = Val(TB_CostoUnit13.Text)
            conex13.Parameters.Add(New SqlParameter("@Costo_Total", SqlDbType.Int)).Value = Val(TB_CostoTotal13.Text)
            conex13.Parameters.Add(New SqlParameter("@Act", SqlDbType.NChar, 2)).Value = "13"
            conex13.CommandText = Insar13
            conex13.ExecuteNonQuery()
            Me.SqlConnection1.Close()
        Catch es As Exception
            MsgBox(es.ToString)
        End Try
    End Sub
    Sub movimiento_alta14()
        Try
            Me.SqlConnection1.Open()
            Dim Insar14 As String = "INSERT INTO Patrimonio (Folio,Fecha_Registro,Solicitud,No_Activo,Cve_Categoria,Cve_SubCategoria,Descripcion,Marca,Modelo,Serie,No_Factura,Fecha_Factura,Cantidad_Articulos,Costo_Unitario,Costo_Total,Departamento,Titular,Act) values(@Folio,@Fecha_Registro,@Solicitud,@No_Activo,@Cve_Categoria,@Cve_SubCategoria,@Descripcion,@Marca,@Modelo,@Serie,@No_Factura,@Fecha_Factura,@Cantidad_Articulos,@Costo_Unitario,@Costo_Total,@Departamento,@Titular,@Act)"
            Dim conex14 As New SqlClient.SqlCommand(Insar14, Me.SqlConnection1)
            conex14.Parameters.Add(New SqlParameter("@Folio", SqlDbType.Int, 4)).Value = Me.TBFolio.Text
            conex14.Parameters.Add(New SqlParameter("@Departamento", SqlDbType.NVarChar, 50)).Value = Me.CB_Departamento.Text
            conex14.Parameters.Add(New SqlParameter("@Titular", SqlDbType.NVarChar, 50)).Value = Me.CB_Responsable.Text
            conex14.Parameters.Add(New SqlParameter("@Fecha_Registro", SqlDbType.SmallDateTime)).Value = DateTimePicker_Registro.Text
            conex14.Parameters.Add(New SqlParameter("@Solicitud", SqlDbType.NChar, 10)).Value = Me.TB_Solicitud.Text
            conex14.Parameters.Add(New SqlParameter("@No_Activo", SqlDbType.NVarChar, 5)).Value = Me.Label_Activo14.Text
            conex14.Parameters.Add(New SqlParameter("@Cve_Categoria", SqlDbType.NChar, 10)).Value = Me.TBCveCategoria.Text
            conex14.Parameters.Add(New SqlParameter("@Cve_SubCategoria", SqlDbType.NChar, 10)).Value = Me.TB_SubCategoria_A14.Text
            conex14.Parameters.Add(New SqlParameter("@Descripcion", SqlDbType.NVarChar, 50)).Value = Me.CB_A14.Text
            conex14.Parameters.Add(New SqlParameter("@Marca", SqlDbType.NChar, 10)).Value = Me.TB_Marca14.Text
            conex14.Parameters.Add(New SqlParameter("@Modelo", SqlDbType.NVarChar, 50)).Value = Me.TB_Modelo14.Text
            conex14.Parameters.Add(New SqlParameter("@Serie", SqlDbType.NChar, 20)).Value = Me.TB_Serie14.Text
            conex14.Parameters.Add(New SqlParameter("@No_Factura", SqlDbType.NChar, 20)).Value = Me.TB_NoFactura14.Text
            conex14.Parameters.Add(New SqlParameter("@Fecha_Factura", SqlDbType.SmallDateTime)).Value = DateTimePicker_Factura14.Text
            conex14.Parameters.Add(New SqlParameter("@Cantidad_Articulos", SqlDbType.Int)).Value = Val(NUpDown_CanArt14.Text)
            conex14.Parameters.Add(New SqlParameter("@Costo_Unitario", SqlDbType.Int)).Value = Val(TB_CostoUnit14.Text)
            conex14.Parameters.Add(New SqlParameter("@Costo_Total", SqlDbType.Int)).Value = Val(TB_CostoTotal14.Text)
            conex14.Parameters.Add(New SqlParameter("@Act", SqlDbType.NChar, 2)).Value = "14"
            conex14.CommandText = Insar14
            conex14.ExecuteNonQuery()
            Me.SqlConnection1.Close()
        Catch es As Exception
            MsgBox(es.ToString)
        End Try
    End Sub
    Sub movimiento_alta15()
        Try
            Me.SqlConnection1.Open()
            Dim Insar15 As String = "INSERT INTO Patrimonio (Folio,Fecha_Registro,Solicitud,No_Activo,Cve_Categoria,Cve_SubCategoria,Descripcion,Marca,Modelo,Serie,No_Factura,Fecha_Factura,Cantidad_Articulos,Costo_Unitario,Costo_Total,Departamento,Titular,Act) values(@Folio,@Fecha_Registro,@Solicitud,@No_Activo,@Cve_Categoria,@Cve_SubCategoria,@Descripcion,@Marca,@Modelo,@Serie,@No_Factura,@Fecha_Factura,@Cantidad_Articulos,@Costo_Unitario,@Costo_Total,@Departamento,@Titular,@Act)"
            Dim conex15 As New SqlClient.SqlCommand(Insar15, Me.SqlConnection1)
            conex15.Parameters.Add(New SqlParameter("@Folio", SqlDbType.Int, 4)).Value = Me.TBFolio.Text
            conex15.Parameters.Add(New SqlParameter("@Departamento", SqlDbType.NVarChar, 50)).Value = Me.CB_Departamento.Text
            conex15.Parameters.Add(New SqlParameter("@Titular", SqlDbType.NVarChar, 50)).Value = Me.CB_Responsable.Text
            conex15.Parameters.Add(New SqlParameter("@Fecha_Registro", SqlDbType.SmallDateTime)).Value = DateTimePicker_Registro.Text
            conex15.Parameters.Add(New SqlParameter("@Solicitud", SqlDbType.NChar, 10)).Value = Me.TB_Solicitud.Text
            conex15.Parameters.Add(New SqlParameter("@No_Activo", SqlDbType.NVarChar, 5)).Value = Me.Label_Activo15.Text
            conex15.Parameters.Add(New SqlParameter("@Cve_Categoria", SqlDbType.NChar, 10)).Value = Me.TBCveCategoria.Text
            conex15.Parameters.Add(New SqlParameter("@Cve_SubCategoria", SqlDbType.NChar, 10)).Value = Me.TB_SubCategoria_A15.Text
            conex15.Parameters.Add(New SqlParameter("@Descripcion", SqlDbType.NVarChar, 50)).Value = Me.CB_A15.Text
            conex15.Parameters.Add(New SqlParameter("@Marca", SqlDbType.NChar, 10)).Value = Me.TB_Marca15.Text
            conex15.Parameters.Add(New SqlParameter("@Modelo", SqlDbType.NVarChar, 50)).Value = Me.TB_Modelo15.Text
            conex15.Parameters.Add(New SqlParameter("@Serie", SqlDbType.NChar, 20)).Value = Me.TB_Serie15.Text
            conex15.Parameters.Add(New SqlParameter("@No_Factura", SqlDbType.NChar, 20)).Value = Me.TB_NoFactura15.Text
            conex15.Parameters.Add(New SqlParameter("@Fecha_Factura", SqlDbType.SmallDateTime)).Value = DateTimePicker_Factura15.Text
            conex15.Parameters.Add(New SqlParameter("@Cantidad_Articulos", SqlDbType.Int)).Value = Val(NUpDown_CanArt15.Text)
            conex15.Parameters.Add(New SqlParameter("@Costo_Unitario", SqlDbType.Int)).Value = Val(TB_CostoUnit15.Text)
            conex15.Parameters.Add(New SqlParameter("@Costo_Total", SqlDbType.Int)).Value = Val(TB_CostoTotal15.Text)
            conex15.Parameters.Add(New SqlParameter("@Act", SqlDbType.NChar, 2)).Value = "15"
            conex15.CommandText = Insar15
            conex15.ExecuteNonQuery()
            Me.SqlConnection1.Close()
        Catch es As Exception
            MsgBox(es.ToString)
        End Try
    End Sub
    Sub movimiento_alta16()
        Try
            Me.SqlConnection1.Open()
            Dim Insar16 As String = "INSERT INTO Patrimonio (Folio,Fecha_Registro,Solicitud,No_Activo,Cve_Categoria,Cve_SubCategoria,Descripcion,Marca,Modelo,Serie,No_Factura,Fecha_Factura,Cantidad_Articulos,Costo_Unitario,Costo_Total,Departamento,Titular,Act) values(@Folio,@Fecha_Registro,@Solicitud,@No_Activo,@Cve_Categoria,@Cve_SubCategoria,@Descripcion,@Marca,@Modelo,@Serie,@No_Factura,@Fecha_Factura,@Cantidad_Articulos,@Costo_Unitario,@Costo_Total,@Departamento,@Titular,@Act)"
            Dim conex16 As New SqlClient.SqlCommand(Insar16, Me.SqlConnection1)
            conex16.Parameters.Add(New SqlParameter("@Folio", SqlDbType.Int, 4)).Value = Me.TBFolio.Text
            conex16.Parameters.Add(New SqlParameter("@Departamento", SqlDbType.NVarChar, 50)).Value = Me.CB_Departamento.Text
            conex16.Parameters.Add(New SqlParameter("@Titular", SqlDbType.NVarChar, 50)).Value = Me.CB_Responsable.Text
            conex16.Parameters.Add(New SqlParameter("@Fecha_Registro", SqlDbType.SmallDateTime)).Value = DateTimePicker_Registro.Text
            conex16.Parameters.Add(New SqlParameter("@Solicitud", SqlDbType.NChar, 10)).Value = Me.TB_Solicitud.Text
            conex16.Parameters.Add(New SqlParameter("@No_Activo", SqlDbType.NVarChar, 5)).Value = Me.Label_Activo16.Text
            conex16.Parameters.Add(New SqlParameter("@Cve_Categoria", SqlDbType.NChar, 10)).Value = Me.TBCveCategoria.Text
            conex16.Parameters.Add(New SqlParameter("@Cve_SubCategoria", SqlDbType.NChar, 10)).Value = Me.TB_SubCategoria_A16.Text
            conex16.Parameters.Add(New SqlParameter("@Descripcion", SqlDbType.NVarChar, 50)).Value = Me.CB_A16.Text
            conex16.Parameters.Add(New SqlParameter("@Marca", SqlDbType.NChar, 10)).Value = Me.TB_Marca16.Text
            conex16.Parameters.Add(New SqlParameter("@Modelo", SqlDbType.NVarChar, 50)).Value = Me.TB_Modelo16.Text
            conex16.Parameters.Add(New SqlParameter("@Serie", SqlDbType.NChar, 20)).Value = Me.TB_Serie16.Text
            conex16.Parameters.Add(New SqlParameter("@No_Factura", SqlDbType.NChar, 20)).Value = Me.TB_NoFactura16.Text
            conex16.Parameters.Add(New SqlParameter("@Fecha_Factura", SqlDbType.SmallDateTime)).Value = DateTimePicker_Factura16.Text
            conex16.Parameters.Add(New SqlParameter("@Cantidad_Articulos", SqlDbType.Int)).Value = Val(NUpDown_CanArt16.Text)
            conex16.Parameters.Add(New SqlParameter("@Costo_Unitario", SqlDbType.Int)).Value = Val(TB_CostoUnit16.Text)
            conex16.Parameters.Add(New SqlParameter("@Costo_Total", SqlDbType.Int)).Value = Val(TB_CostoTotal16.Text)
            conex16.Parameters.Add(New SqlParameter("@Act", SqlDbType.NChar, 2)).Value = "16"
            conex16.CommandText = Insar16
            conex16.ExecuteNonQuery()
            Me.SqlConnection1.Close()
        Catch es As Exception
            MsgBox(es.ToString)
        End Try
    End Sub
    Sub movimiento_alta17()
        Try
            Me.SqlConnection1.Open()
            Dim Insar17 As String = "INSERT INTO Patrimonio (Folio,Fecha_Registro,Solicitud,No_Activo,Cve_Categoria,Cve_SubCategoria,Descripcion,Marca,Modelo,Serie,No_Factura,Fecha_Factura,Cantidad_Articulos,Costo_Unitario,Costo_Total,Departamento,Titular,Act) values(@Folio,@Fecha_Registro,@Solicitud,@No_Activo,@Cve_Categoria,@Cve_SubCategoria,@Descripcion,@Marca,@Modelo,@Serie,@No_Factura,@Fecha_Factura,@Cantidad_Articulos,@Costo_Unitario,@Costo_Total,@Departamento,@Titular,@Act)"
            Dim conex17 As New SqlClient.SqlCommand(Insar17, Me.SqlConnection1)
            conex17.Parameters.Add(New SqlParameter("@Folio", SqlDbType.Int, 4)).Value = Me.TBFolio.Text
            conex17.Parameters.Add(New SqlParameter("@Departamento", SqlDbType.NVarChar, 50)).Value = Me.CB_Departamento.Text
            conex17.Parameters.Add(New SqlParameter("@Titular", SqlDbType.NVarChar, 50)).Value = Me.CB_Responsable.Text
            conex17.Parameters.Add(New SqlParameter("@Fecha_Registro", SqlDbType.SmallDateTime)).Value = DateTimePicker_Registro.Text
            conex17.Parameters.Add(New SqlParameter("@Solicitud", SqlDbType.NChar, 10)).Value = Me.TB_Solicitud.Text
            conex17.Parameters.Add(New SqlParameter("@No_Activo", SqlDbType.NVarChar, 5)).Value = Me.Label_Activo17.Text
            conex17.Parameters.Add(New SqlParameter("@Cve_Categoria", SqlDbType.NChar, 10)).Value = Me.TBCveCategoria.Text
            conex17.Parameters.Add(New SqlParameter("@Cve_SubCategoria", SqlDbType.NChar, 10)).Value = Me.TB_SubCategoria_A17.Text
            conex17.Parameters.Add(New SqlParameter("@Descripcion", SqlDbType.NVarChar, 50)).Value = Me.CB_A17.Text
            conex17.Parameters.Add(New SqlParameter("@Marca", SqlDbType.NChar, 10)).Value = Me.TB_Marca17.Text
            conex17.Parameters.Add(New SqlParameter("@Modelo", SqlDbType.NVarChar, 50)).Value = Me.TB_Modelo17.Text
            conex17.Parameters.Add(New SqlParameter("@Serie", SqlDbType.NChar, 20)).Value = Me.TB_Serie17.Text
            conex17.Parameters.Add(New SqlParameter("@No_Factura", SqlDbType.NChar, 20)).Value = Me.TB_NoFactura17.Text
            conex17.Parameters.Add(New SqlParameter("@Fecha_Factura", SqlDbType.SmallDateTime)).Value = DateTimePicker_Factura17.Text
            conex17.Parameters.Add(New SqlParameter("@Cantidad_Articulos", SqlDbType.Int)).Value = Val(NUpDown_CanArt17.Text)
            conex17.Parameters.Add(New SqlParameter("@Costo_Unitario", SqlDbType.Int)).Value = Val(TB_CostoUnit17.Text)
            conex17.Parameters.Add(New SqlParameter("@Costo_Total", SqlDbType.Int)).Value = Val(TB_CostoTotal17.Text)
            conex17.Parameters.Add(New SqlParameter("@Act", SqlDbType.NChar, 2)).Value = "17"
            conex17.CommandText = Insar17
            conex17.ExecuteNonQuery()
            Me.SqlConnection1.Close()
        Catch es As Exception
            MsgBox(es.ToString)
        End Try
    End Sub
    Sub movimiento_alta18()
        Try
            Me.SqlConnection1.Open()
            Dim Insar18 As String = "INSERT INTO Patrimonio (Folio,Fecha_Registro,Solicitud,No_Activo,Cve_Categoria,Cve_SubCategoria,Descripcion,Marca,Modelo,Serie,No_Factura,Fecha_Factura,Cantidad_Articulos,Costo_Unitario,Costo_Total,Departamento,Titular,Act) values(@Folio,@Fecha_Registro,@Solicitud,@No_Activo,@Cve_Categoria,@Cve_SubCategoria,@Descripcion,@Marca,@Modelo,@Serie,@No_Factura,@Fecha_Factura,@Cantidad_Articulos,@Costo_Unitario,@Costo_Total,@Departamento,@Titular,@Act)"
            Dim conex18 As New SqlClient.SqlCommand(Insar18, Me.SqlConnection1)
            conex18.Parameters.Add(New SqlParameter("@Folio", SqlDbType.Int, 4)).Value = Me.TBFolio.Text
            conex18.Parameters.Add(New SqlParameter("@Departamento", SqlDbType.NVarChar, 50)).Value = Me.CB_Departamento.Text
            conex18.Parameters.Add(New SqlParameter("@Titular", SqlDbType.NVarChar, 50)).Value = Me.CB_Responsable.Text
            conex18.Parameters.Add(New SqlParameter("@Fecha_Registro", SqlDbType.SmallDateTime)).Value = DateTimePicker_Registro.Text
            conex18.Parameters.Add(New SqlParameter("@Solicitud", SqlDbType.NChar, 10)).Value = Me.TB_Solicitud.Text
            conex18.Parameters.Add(New SqlParameter("@No_Activo", SqlDbType.NVarChar, 5)).Value = Me.Label_Activo18.Text
            conex18.Parameters.Add(New SqlParameter("@Cve_Categoria", SqlDbType.NChar, 10)).Value = Me.TBCveCategoria.Text
            conex18.Parameters.Add(New SqlParameter("@Cve_SubCategoria", SqlDbType.NChar, 10)).Value = Me.TB_SubCategoria_A18.Text
            conex18.Parameters.Add(New SqlParameter("@Descripcion", SqlDbType.NVarChar, 50)).Value = Me.CB_A18.Text
            conex18.Parameters.Add(New SqlParameter("@Marca", SqlDbType.NChar, 10)).Value = Me.TB_Marca18.Text
            conex18.Parameters.Add(New SqlParameter("@Modelo", SqlDbType.NVarChar, 50)).Value = Me.TB_Modelo18.Text
            conex18.Parameters.Add(New SqlParameter("@Serie", SqlDbType.NChar, 20)).Value = Me.TB_Serie18.Text
            conex18.Parameters.Add(New SqlParameter("@No_Factura", SqlDbType.NChar, 20)).Value = Me.TB_NoFactura18.Text
            conex18.Parameters.Add(New SqlParameter("@Fecha_Factura", SqlDbType.SmallDateTime)).Value = DateTimePicker_Factura18.Text
            conex18.Parameters.Add(New SqlParameter("@Cantidad_Articulos", SqlDbType.Int)).Value = Val(NUpDown_CanArt18.Text)
            conex18.Parameters.Add(New SqlParameter("@Costo_Unitario", SqlDbType.Int)).Value = Val(TB_CostoUnit18.Text)
            conex18.Parameters.Add(New SqlParameter("@Costo_Total", SqlDbType.Int)).Value = Val(TB_CostoTotal18.Text)
            conex18.Parameters.Add(New SqlParameter("@Act", SqlDbType.NChar, 2)).Value = "18"
            conex18.CommandText = Insar18
            conex18.ExecuteNonQuery()
            Me.SqlConnection1.Close()
        Catch es As Exception
            MsgBox(es.ToString)
        End Try
    End Sub
    Sub movimiento_alta19()
        Try
            Me.SqlConnection1.Open()
            Dim Insar19 As String = "INSERT INTO Patrimonio (Folio,Fecha_Registro,Solicitud,No_Activo,Cve_Categoria,Cve_SubCategoria,Descripcion,Marca,Modelo,Serie,No_Factura,Fecha_Factura,Cantidad_Articulos,Costo_Unitario,Costo_Total,Departamento,Titular,Act) values(@Folio,@Fecha_Registro,@Solicitud,@No_Activo,@Cve_Categoria,@Cve_SubCategoria,@Descripcion,@Marca,@Modelo,@Serie,@No_Factura,@Fecha_Factura,@Cantidad_Articulos,@Costo_Unitario,@Costo_Total,@Departamento,@Titular,@Act)"
            Dim conex19 As New SqlClient.SqlCommand(Insar19, Me.SqlConnection1)
            conex19.Parameters.Add(New SqlParameter("@Folio", SqlDbType.Int, 4)).Value = Me.TBFolio.Text
            conex19.Parameters.Add(New SqlParameter("@Departamento", SqlDbType.NVarChar, 50)).Value = Me.CB_Departamento.Text
            conex19.Parameters.Add(New SqlParameter("@Titular", SqlDbType.NVarChar, 50)).Value = Me.CB_Responsable.Text
            conex19.Parameters.Add(New SqlParameter("@Fecha_Registro", SqlDbType.SmallDateTime)).Value = DateTimePicker_Registro.Text
            conex19.Parameters.Add(New SqlParameter("@Solicitud", SqlDbType.NChar, 10)).Value = Me.TB_Solicitud.Text
            conex19.Parameters.Add(New SqlParameter("@No_Activo", SqlDbType.NVarChar, 5)).Value = Me.Label_Activo19.Text
            conex19.Parameters.Add(New SqlParameter("@Cve_Categoria", SqlDbType.NChar, 10)).Value = Me.TBCveCategoria.Text
            conex19.Parameters.Add(New SqlParameter("@Cve_SubCategoria", SqlDbType.NChar, 10)).Value = Me.TB_SubCategoria_A19.Text
            conex19.Parameters.Add(New SqlParameter("@Descripcion", SqlDbType.NVarChar, 50)).Value = Me.CB_A19.Text
            conex19.Parameters.Add(New SqlParameter("@Marca", SqlDbType.NChar, 10)).Value = Me.TB_Marca19.Text
            conex19.Parameters.Add(New SqlParameter("@Modelo", SqlDbType.NVarChar, 50)).Value = Me.TB_Modelo19.Text
            conex19.Parameters.Add(New SqlParameter("@Serie", SqlDbType.NChar, 20)).Value = Me.TB_Serie19.Text
            conex19.Parameters.Add(New SqlParameter("@No_Factura", SqlDbType.NChar, 20)).Value = Me.TB_NoFactura19.Text
            conex19.Parameters.Add(New SqlParameter("@Fecha_Factura", SqlDbType.SmallDateTime)).Value = DateTimePicker_Factura19.Text
            conex19.Parameters.Add(New SqlParameter("@Cantidad_Articulos", SqlDbType.Int)).Value = Val(NUpDown_CanArt19.Text)
            conex19.Parameters.Add(New SqlParameter("@Costo_Unitario", SqlDbType.Int)).Value = Val(TB_CostoUnit19.Text)
            conex19.Parameters.Add(New SqlParameter("@Costo_Total", SqlDbType.Int)).Value = Val(TB_CostoTotal19.Text)
            conex19.Parameters.Add(New SqlParameter("@Act", SqlDbType.NChar, 2)).Value = "19"
            conex19.CommandText = Insar19
            conex19.ExecuteNonQuery()
            Me.SqlConnection1.Close()
        Catch es As Exception
            MsgBox(es.ToString)
        End Try
    End Sub
    Sub movimiento_alta20()
        Try
            Me.SqlConnection1.Open()
            Dim Insar20 As String = "INSERT INTO Patrimonio (Folio,Fecha_Registro,Solicitud,No_Activo,Cve_Categoria,Cve_SubCategoria,Descripcion,Marca,Modelo,Serie,No_Factura,Fecha_Factura,Cantidad_Articulos,Costo_Unitario,Costo_Total,Departamento,Titular,Act) values(@Folio,@Fecha_Registro,@Solicitud,@No_Activo,@Cve_Categoria,@Cve_SubCategoria,@Descripcion,@Marca,@Modelo,@Serie,@No_Factura,@Fecha_Factura,@Cantidad_Articulos,@Costo_Unitario,@Costo_Total,@Departamento,@Titular,@Act)"
            Dim conex20 As New SqlClient.SqlCommand(Insar20, Me.SqlConnection1)
            conex20.Parameters.Add(New SqlParameter("@Folio", SqlDbType.Int, 4)).Value = Me.TBFolio.Text
            conex20.Parameters.Add(New SqlParameter("@Departamento", SqlDbType.NVarChar, 50)).Value = Me.CB_Departamento.Text
            conex20.Parameters.Add(New SqlParameter("@Titular", SqlDbType.NVarChar, 50)).Value = Me.CB_Responsable.Text
            conex20.Parameters.Add(New SqlParameter("@Fecha_Registro", SqlDbType.SmallDateTime)).Value = DateTimePicker_Registro.Text
            conex20.Parameters.Add(New SqlParameter("@Solicitud", SqlDbType.NChar, 10)).Value = Me.TB_Solicitud.Text
            conex20.Parameters.Add(New SqlParameter("@No_Activo", SqlDbType.NVarChar, 5)).Value = Me.Label_Activo20.Text
            conex20.Parameters.Add(New SqlParameter("@Cve_Categoria", SqlDbType.NChar, 10)).Value = Me.TBCveCategoria.Text
            conex20.Parameters.Add(New SqlParameter("@Cve_SubCategoria", SqlDbType.NChar, 10)).Value = Me.TB_SubCategoria_A20.Text
            conex20.Parameters.Add(New SqlParameter("@Descripcion", SqlDbType.NVarChar, 50)).Value = Me.CB_A20.Text
            conex20.Parameters.Add(New SqlParameter("@Marca", SqlDbType.NChar, 10)).Value = Me.TB_Marca20.Text
            conex20.Parameters.Add(New SqlParameter("@Modelo", SqlDbType.NVarChar, 50)).Value = Me.TB_Modelo20.Text
            conex20.Parameters.Add(New SqlParameter("@Serie", SqlDbType.NChar, 20)).Value = Me.TB_Serie20.Text
            conex20.Parameters.Add(New SqlParameter("@No_Factura", SqlDbType.NChar, 20)).Value = Me.TB_NoFactura20.Text
            conex20.Parameters.Add(New SqlParameter("@Fecha_Factura", SqlDbType.SmallDateTime)).Value = DateTimePicker_Factura20.Text
            conex20.Parameters.Add(New SqlParameter("@Cantidad_Articulos", SqlDbType.Int)).Value = Val(NUpDown_CanArt20.Text)
            conex20.Parameters.Add(New SqlParameter("@Costo_Unitario", SqlDbType.Int)).Value = Val(TB_CostoUnit20.Text)
            conex20.Parameters.Add(New SqlParameter("@Costo_Total", SqlDbType.Int)).Value = Val(TB_CostoTotal20.Text)
            conex20.Parameters.Add(New SqlParameter("@Act", SqlDbType.NChar, 2)).Value = "20"
            conex20.CommandText = Insar20
            conex20.ExecuteNonQuery()
            Me.SqlConnection1.Close()
        Catch es As Exception
            MsgBox(es.ToString)
        End Try
    End Sub
    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Dim guardar As String
        guardar = MsgBox("Esta seguro de guardar los datos ?", MsgBoxStyle.YesNo + MsgBoxStyle.Information, "Guardar")
        If guardar = vbYes Then
            'Call buscar_ultimo_folio_ocupado()
            If mov_alta1 = 1 Then
                Call movimiento_alta1()
            End If
            If mov_alta2 = 2 Then
                Call movimiento_alta2()
            End If
            If mov_alta3 = 3 Then
                Call movimiento_alta3()
            End If
            If mov_alta4 = 4 Then
                Call movimiento_alta4()
            End If
            If mov_alta5 = 5 Then
                Call movimiento_alta5()
            End If
            If mov_alta6 = 6 Then
                Call movimiento_alta6()
            End If
            If mov_alta7 = 7 Then
                Call movimiento_alta7()
            End If
            If mov_alta8 = 8 Then
                Call movimiento_alta8()
            End If
            If mov_alta9 = 9 Then
                Call movimiento_alta9()
            End If
            If mov_alta10 = 10 Then
                Call movimiento_alta10()
            End If
            If mov_alta11 = 11 Then
                Call movimiento_alta11()
            End If
            If mov_alta12 = 12 Then
                Call movimiento_alta12()
            End If
            If mov_alta13 = 13 Then
                Call movimiento_alta13()
            End If
            If mov_alta14 = 14 Then
                Call movimiento_alta14()
            End If
            If mov_alta15 = 15 Then
                Call movimiento_alta15()
            End If
            If mov_alta16 = 16 Then
                Call movimiento_alta16()
            End If
            If mov_alta17 = 17 Then
                Call movimiento_alta17()
            End If
            If mov_alta18 = 18 Then
                Call movimiento_alta18()
            End If
            If mov_alta19 = 19 Then
                Call movimiento_alta19()
            End If
            If mov_alta20 = 20 Then
                Call movimiento_alta20()
            End If
            MsgBox("Datos guardados correctamente..!", , "Guardar")
        Else
            Me.SqlConnection1.Close()
            Me.CB_Departamento.Focus()
        End If
        Call limpiar_formulario()
        Call buscar_ultimo_folio()
        Call buscar_No_Activo()

        'CBProducto.Focus()
    End Sub
    Sub limpiar_formulario()
        CB_A1.Items.Clear()
        CB_A2.Items.Clear()
        CB_A3.Items.Clear()
        CB_A4.Items.Clear()
        CB_A5.Items.Clear()
        CB_A6.Items.Clear()
        CB_A7.Items.Clear()
        CB_A8.Items.Clear()
        CB_A9.Items.Clear()
        CB_A10.Items.Clear()

        'CB_A1.Text = ""


        CB_A1.Enabled = False
        CB_A2.Enabled = False
        CB_A3.Enabled = False
        CB_A4.Enabled = False
        CB_A5.Enabled = False
        CB_A6.Enabled = False
        CB_A7.Enabled = False
        CB_A8.Enabled = False
        CB_A9.Enabled = False
        CB_A10.Enabled = False

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

        TB_Marca1.Enabled = False
        TB_Marca2.Enabled = False
        TB_Marca3.Enabled = False
        TB_Marca4.Enabled = False
        TB_Marca5.Enabled = False
        TB_Marca6.Enabled = False
        TB_Marca7.Enabled = False
        TB_Marca8.Enabled = False
        TB_Marca9.Enabled = False
        TB_Marca10.Enabled = False

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

        TB_Modelo1.Enabled = False
        TB_Modelo2.Enabled = False
        TB_Modelo3.Enabled = False
        TB_Modelo4.Enabled = False
        TB_Modelo5.Enabled = False
        TB_Modelo6.Enabled = False
        TB_Modelo7.Enabled = False
        TB_Modelo8.Enabled = False
        TB_Modelo9.Enabled = False
        TB_Modelo10.Enabled = False

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

        TB_Serie1.Enabled = False
        TB_Serie2.Enabled = False
        TB_Serie3.Enabled = False
        TB_Serie4.Enabled = False
        TB_Serie5.Enabled = False
        TB_Serie6.Enabled = False
        TB_Serie7.Enabled = False
        TB_Serie8.Enabled = False
        TB_Serie9.Enabled = False
        TB_Serie10.Enabled = False

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

        TB_NoFactura1.Enabled = False
        TB_NoFactura2.Enabled = False
        TB_NoFactura3.Enabled = False
        TB_NoFactura4.Enabled = False
        TB_NoFactura5.Enabled = False
        TB_NoFactura6.Enabled = False
        TB_NoFactura7.Enabled = False
        TB_NoFactura8.Enabled = False
        TB_NoFactura9.Enabled = False
        TB_NoFactura10.Enabled = False



        'Me.NUpDown_CanArt1.Value = 0
        'Me.NUpDown_CanArt2.Value = 0
        'Me.NUpDown_CanArt3.Value = 0
        'Me.NUpDown_CanArt4.Value = 0
        'Me.NUpDown_CanArt5.Value = 0
        'Me.NUpDown_CanArt6.Value = 0
        'Me.NUpDown_CanArt7.Value = 0
        'Me.NUpDown_CanArt8.Value = 0
        'Me.NUpDown_CanArt9.Value = 0
        'Me.NUpDown_CanArt10.Value = 0

        NUpDown_CanArt1.Enabled = False
        NUpDown_CanArt2.Enabled = False
        NUpDown_CanArt3.Enabled = False
        NUpDown_CanArt4.Enabled = False
        NUpDown_CanArt5.Enabled = False
        NUpDown_CanArt6.Enabled = False
        NUpDown_CanArt7.Enabled = False
        NUpDown_CanArt8.Enabled = False
        NUpDown_CanArt9.Enabled = False
        NUpDown_CanArt10.Enabled = False

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

        TB_CostoUnit1.Enabled = False
        TB_CostoUnit2.Enabled = False
        TB_CostoUnit3.Enabled = False
        TB_CostoUnit4.Enabled = False
        TB_CostoUnit5.Enabled = False
        TB_CostoUnit6.Enabled = False
        TB_CostoUnit7.Enabled = False
        TB_CostoUnit8.Enabled = False
        TB_CostoUnit9.Enabled = False
        TB_CostoUnit10.Enabled = False


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

        TB_CostoTotal1.Enabled = False
        TB_CostoTotal2.Enabled = False
        TB_CostoTotal3.Enabled = False
        TB_CostoTotal4.Enabled = False
        TB_CostoTotal5.Enabled = False
        TB_CostoTotal6.Enabled = False
        TB_CostoTotal7.Enabled = False
        TB_CostoTotal8.Enabled = False
        TB_CostoTotal9.Enabled = False
        TB_CostoTotal10.Enabled = False

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

    End Sub
    Sub limpiar_costo_articulo()
        'Me.NUpDown_CanArt1.Value = 0
        'Me.NUpDown_CanArt2.Value = 0
        'Me.NUpDown_CanArt3.Value = 0
        'Me.NUpDown_CanArt4.Value = 0
        'Me.NUpDown_CanArt5.Value = 0
        'Me.NUpDown_CanArt6.Value = 0
        'Me.NUpDown_CanArt7.Value = 0
        'Me.NUpDown_CanArt8.Value = 0
        'Me.NUpDown_CanArt9.Value = 0
        'Me.NUpDown_CanArt10.Value = 0
    End Sub
    Sub CALCUALAR_TOTAL_A1()
        If Val(NUpDown_CanArt1.UpDownAlign) <> 0 Then
            CTO_TOTAL_SIN_IVA1 = NUpDown_CanArt1.Value * Val(TB_CostoUnit1.Text)
            CALCULAR_IVA1 = (CTO_TOTAL_SIN_IVA1 * 0.16)
            COSTO_TOTAL1 = CTO_TOTAL_SIN_IVA1 + CALCULAR_IVA1
            TB_CostoTotal1.Text = CStr(COSTO_TOTAL1.ToString)
            ' MsgBox(CStr(COSTO_TOTAL1))
        End If
    End Sub
    Sub CALCUALAR_TOTAL_A2()
        If Val(NUpDown_CanArt2.UpDownAlign) <> 0 Then
            CTO_TOTAL_SIN_IVA2 = NUpDown_CanArt2.Value * Val(TB_CostoUnit2.Text)
            CALCULAR_IVA2 = (CTO_TOTAL_SIN_IVA2 * 0.16)
            COSTO_TOTAL2 = CTO_TOTAL_SIN_IVA2 + CALCULAR_IVA2
            TB_CostoTotal2.Text = CStr(COSTO_TOTAL2.ToString)
            ' MsgBox(CStr(COSTO_TOTAL2))
        End If
    End Sub
    Sub CALCUALAR_TOTAL_A3()
        If Val(NUpDown_CanArt3.UpDownAlign) <> 0 Then
            CTO_TOTAL_SIN_IVA3 = NUpDown_CanArt3.Value * Val(TB_CostoUnit3.Text)
            CALCULAR_IVA3 = (CTO_TOTAL_SIN_IVA3 * 0.16)
            COSTO_TOTAL3 = CTO_TOTAL_SIN_IVA3 + CALCULAR_IVA3
            TB_CostoTotal3.Text = CStr(COSTO_TOTAL3.ToString)
            ' MsgBox(CStr(COSTO_TOTAL3))
        End If
    End Sub
    Sub CALCUALAR_TOTAL_A4()
        If Val(NUpDown_CanArt4.UpDownAlign) <> 0 Then
            CTO_TOTAL_SIN_IVA4 = NUpDown_CanArt4.Value * Val(TB_CostoUnit4.Text)
            CALCULAR_IVA4 = (CTO_TOTAL_SIN_IVA4 * 0.16)
            COSTO_TOTAL4 = CTO_TOTAL_SIN_IVA4 + CALCULAR_IVA4
            TB_CostoTotal4.Text = CStr(COSTO_TOTAL4.ToString)
            ' MsgBox(CStr(COSTO_TOTAL4))
        End If
    End Sub
    Sub CALCUALAR_TOTAL_A5()
        If Val(NUpDown_CanArt5.UpDownAlign) <> 0 Then
            CTO_TOTAL_SIN_IVA5 = NUpDown_CanArt5.Value * Val(TB_CostoUnit5.Text)
            CALCULAR_IVA5 = (CTO_TOTAL_SIN_IVA5 * 0.16)
            COSTO_TOTAL5 = CTO_TOTAL_SIN_IVA5 + CALCULAR_IVA5
            TB_CostoTotal5.Text = CStr(COSTO_TOTAL5.ToString)
            ' MsgBox(CStr(COSTO_TOTAL5))
        End If
    End Sub

    Sub CALCUALAR_TOTAL_A6()
        If Val(NUpDown_CanArt6.UpDownAlign) <> 0 Then
            CTO_TOTAL_SIN_IVA6 = NUpDown_CanArt6.Value * Val(TB_CostoUnit6.Text)
            CALCULAR_IVA6 = (CTO_TOTAL_SIN_IVA6 * 0.16)
            COSTO_TOTAL6 = CTO_TOTAL_SIN_IVA6 + CALCULAR_IVA6
            TB_CostoTotal6.Text = CStr(COSTO_TOTAL6.ToString)
            ' MsgBox(CStr(COSTO_TOTAL5))
        End If
    End Sub
    Sub CALCUALAR_TOTAL_A7()
        If Val(NUpDown_CanArt7.UpDownAlign) <> 0 Then
            CTO_TOTAL_SIN_IVA7 = NUpDown_CanArt7.Value * Val(TB_CostoUnit7.Text)
            CALCULAR_IVA7 = (CTO_TOTAL_SIN_IVA7 * 0.16)
            COSTO_TOTAL7 = CTO_TOTAL_SIN_IVA7 + CALCULAR_IVA7
            TB_CostoTotal7.Text = CStr(COSTO_TOTAL7.ToString)
            ' MsgBox(CStr(COSTO_TOTAL5))
        End If
    End Sub
    Sub CALCUALAR_TOTAL_A8()
        If Val(NUpDown_CanArt8.UpDownAlign) <> 0 Then
            CTO_TOTAL_SIN_IVA8 = NUpDown_CanArt8.Value * Val(TB_CostoUnit8.Text)
            CALCULAR_IVA8 = (CTO_TOTAL_SIN_IVA8 * 0.16)
            COSTO_TOTAL8 = CTO_TOTAL_SIN_IVA8 + CALCULAR_IVA8
            TB_CostoTotal8.Text = CStr(COSTO_TOTAL8.ToString)
            ' MsgBox(CStr(COSTO_TOTAL5))
        End If
    End Sub
    Sub CALCUALAR_TOTAL_A9()
        If Val(NUpDown_CanArt9.UpDownAlign) <> 0 Then
            CTO_TOTAL_SIN_IVA9 = NUpDown_CanArt9.Value * Val(TB_CostoUnit9.Text)
            CALCULAR_IVA9 = (CTO_TOTAL_SIN_IVA9 * 0.16)
            COSTO_TOTAL9 = CTO_TOTAL_SIN_IVA9 + CALCULAR_IVA9
            TB_CostoTotal9.Text = CStr(COSTO_TOTAL9.ToString)
            ' MsgBox(CStr(COSTO_TOTAL5))
        End If
    End Sub
    Sub CALCUALAR_TOTAL_A10()
        If Val(NUpDown_CanArt10.UpDownAlign) <> 0 Then
            CTO_TOTAL_SIN_IVA10 = NUpDown_CanArt10.Value * Val(TB_CostoUnit10.Text)
            CALCULAR_IVA10 = (CTO_TOTAL_SIN_IVA10 * 0.16)
            COSTO_TOTAL10 = CTO_TOTAL_SIN_IVA10 + CALCULAR_IVA10
            TB_CostoTotal10.Text = CStr(COSTO_TOTAL10.ToString)
            ' MsgBox(CStr(COSTO_TOTAL5))
        End If
    End Sub

    Sub CALCUALAR_TOTAL_A11()
        If Val(NUpDown_CanArt11.UpDownAlign) <> 0 Then
            CTO_TOTAL_SIN_IVA11 = NUpDown_CanArt11.Value * Val(TB_CostoUnit11.Text)
            CALCULAR_IVA11 = (CTO_TOTAL_SIN_IVA11 * 0.16)
            COSTO_TOTAL11 = CTO_TOTAL_SIN_IVA11 + CALCULAR_IVA11
            TB_CostoTotal11.Text = CStr(COSTO_TOTAL11.ToString)
            ' MsgBox(CStr(COSTO_TOTAL5))
        End If
    End Sub
    Sub CALCUALAR_TOTAL_A12()
        If Val(NUpDown_CanArt12.UpDownAlign) <> 0 Then
            CTO_TOTAL_SIN_IVA12 = NUpDown_CanArt12.Value * Val(TB_CostoUnit12.Text)
            CALCULAR_IVA12 = (CTO_TOTAL_SIN_IVA12 * 0.16)
            COSTO_TOTAL12 = CTO_TOTAL_SIN_IVA12 + CALCULAR_IVA12
            TB_CostoTotal12.Text = CStr(COSTO_TOTAL12.ToString)
            ' MsgBox(CStr(COSTO_TOTAL5))
        End If
    End Sub
    Sub CALCUALAR_TOTAL_A13()
        If Val(NUpDown_CanArt13.UpDownAlign) <> 0 Then
            CTO_TOTAL_SIN_IVA13 = NUpDown_CanArt13.Value * Val(TB_CostoUnit13.Text)
            CALCULAR_IVA13 = (CTO_TOTAL_SIN_IVA13 * 0.16)
            COSTO_TOTAL13 = CTO_TOTAL_SIN_IVA13 + CALCULAR_IVA13
            TB_CostoTotal13.Text = CStr(COSTO_TOTAL13.ToString)
            ' MsgBox(CStr(COSTO_TOTAL5))
        End If
    End Sub
    Sub CALCUALAR_TOTAL_A14()
        If Val(NUpDown_CanArt14.UpDownAlign) <> 0 Then
            CTO_TOTAL_SIN_IVA14 = NUpDown_CanArt14.Value * Val(TB_CostoUnit14.Text)
            CALCULAR_IVA14 = (CTO_TOTAL_SIN_IVA14 * 0.16)
            COSTO_TOTAL14 = CTO_TOTAL_SIN_IVA14 + CALCULAR_IVA14
            TB_CostoTotal14.Text = CStr(COSTO_TOTAL14.ToString)
            ' MsgBox(CStr(COSTO_TOTAL5))
        End If
    End Sub
    Sub CALCUALAR_TOTAL_A15()
        If Val(NUpDown_CanArt15.UpDownAlign) <> 0 Then
            CTO_TOTAL_SIN_IVA15 = NUpDown_CanArt15.Value * Val(TB_CostoUnit15.Text)
            CALCULAR_IVA15 = (CTO_TOTAL_SIN_IVA15 * 0.16)
            COSTO_TOTAL15 = CTO_TOTAL_SIN_IVA15 + CALCULAR_IVA15
            TB_CostoTotal15.Text = CStr(COSTO_TOTAL15.ToString)
            ' MsgBox(CStr(COSTO_TOTAL5))
        End If
    End Sub
    Sub CALCUALAR_TOTAL_A16()
        If Val(NUpDown_CanArt16.UpDownAlign) <> 0 Then
            CTO_TOTAL_SIN_IVA16 = NUpDown_CanArt16.Value * Val(TB_CostoUnit16.Text)
            CALCULAR_IVA16 = (CTO_TOTAL_SIN_IVA16 * 0.16)
            COSTO_TOTAL16 = CTO_TOTAL_SIN_IVA16 + CALCULAR_IVA16
            TB_CostoTotal16.Text = CStr(COSTO_TOTAL16.ToString)
            ' MsgBox(CStr(COSTO_TOTAL5))
        End If
    End Sub
    Sub CALCUALAR_TOTAL_A17()
        If Val(NUpDown_CanArt17.UpDownAlign) <> 0 Then
            CTO_TOTAL_SIN_IVA17 = NUpDown_CanArt17.Value * Val(TB_CostoUnit17.Text)
            CALCULAR_IVA17 = (CTO_TOTAL_SIN_IVA17 * 0.16)
            COSTO_TOTAL17 = CTO_TOTAL_SIN_IVA17 + CALCULAR_IVA17
            TB_CostoTotal17.Text = CStr(COSTO_TOTAL17.ToString)
            ' MsgBox(CStr(COSTO_TOTAL5))
        End If
    End Sub
    Sub CALCUALAR_TOTAL_A18()
        If Val(NUpDown_CanArt18.UpDownAlign) <> 0 Then
            CTO_TOTAL_SIN_IVA18 = NUpDown_CanArt18.Value * Val(TB_CostoUnit18.Text)
            CALCULAR_IVA18 = (CTO_TOTAL_SIN_IVA18 * 0.16)
            COSTO_TOTAL18 = CTO_TOTAL_SIN_IVA18 + CALCULAR_IVA18
            TB_CostoTotal18.Text = CStr(COSTO_TOTAL18.ToString)
            ' MsgBox(CStr(COSTO_TOTAL5))
        End If
    End Sub
    Sub CALCUALAR_TOTAL_A19()
        If Val(NUpDown_CanArt19.UpDownAlign) <> 0 Then
            CTO_TOTAL_SIN_IVA19 = NUpDown_CanArt19.Value * Val(TB_CostoUnit19.Text)
            CALCULAR_IVA19 = (CTO_TOTAL_SIN_IVA19 * 0.16)
            COSTO_TOTAL19 = CTO_TOTAL_SIN_IVA19 + CALCULAR_IVA19
            TB_CostoTotal19.Text = CStr(COSTO_TOTAL19.ToString)
            ' MsgBox(CStr(COSTO_TOTAL5))
        End If
    End Sub
    Sub CALCUALAR_TOTAL_A20()
        If Val(NUpDown_CanArt20.UpDownAlign) <> 0 Then
            CTO_TOTAL_SIN_IVA20 = NUpDown_CanArt20.Value * Val(TB_CostoUnit20.Text)
            CALCULAR_IVA20 = (CTO_TOTAL_SIN_IVA20 * 0.16)
            COSTO_TOTAL20 = CTO_TOTAL_SIN_IVA20 + CALCULAR_IVA20
            TB_CostoTotal20.Text = CStr(COSTO_TOTAL20.ToString)
            ' MsgBox(CStr(COSTO_TOTAL5))
        End If
    End Sub



    Private Sub NUpDown_CanArt1_ValueChanged(sender As Object, e As EventArgs) Handles NUpDown_CanArt1.ValueChanged
        Call CALCUALAR_TOTAL_A1()
    End Sub
    Private Sub NUpDown_CanArt2_ValueChanged(sender As Object, e As EventArgs) Handles NUpDown_CanArt2.ValueChanged
        Call CALCUALAR_TOTAL_A2()
    End Sub
    Private Sub NUpDown_CanArt3_ValueChanged(sender As Object, e As EventArgs) Handles NUpDown_CanArt3.ValueChanged
        Call CALCUALAR_TOTAL_A3()
    End Sub
    Private Sub NUpDown_CanArt4_ValueChanged(sender As Object, e As EventArgs) Handles NUpDown_CanArt4.ValueChanged
        Call CALCUALAR_TOTAL_A4()
    End Sub
    Private Sub NUpDown_CanArt5_ValueChanged(sender As Object, e As EventArgs) Handles NUpDown_CanArt5.ValueChanged
        Call CALCUALAR_TOTAL_A5()
    End Sub
    Private Sub NUpDown_CanArt6_ValueChanged(sender As Object, e As EventArgs) Handles NUpDown_CanArt6.ValueChanged
        Call CALCUALAR_TOTAL_A6()
    End Sub
    Private Sub NUpDown_CanArt7_ValueChanged(sender As Object, e As EventArgs) Handles NUpDown_CanArt7.ValueChanged
        Call CALCUALAR_TOTAL_A7()
    End Sub
    Private Sub NUpDown_CanArt8_ValueChanged(sender As Object, e As EventArgs) Handles NUpDown_CanArt8.ValueChanged
        Call CALCUALAR_TOTAL_A8()
    End Sub
    Private Sub NUpDown_CanArt9_ValueChanged(sender As Object, e As EventArgs) Handles NUpDown_CanArt9.ValueChanged
        Call CALCUALAR_TOTAL_A9()
    End Sub
    Private Sub NUpDown_CanArt10_ValueChanged(sender As Object, e As EventArgs) Handles NUpDown_CanArt10.ValueChanged
        Call CALCUALAR_TOTAL_A10()
    End Sub
    Private Sub NUpDown_CanArt11_ValueChanged(sender As Object, e As EventArgs) Handles NUpDown_CanArt11.ValueChanged
        Call CALCUALAR_TOTAL_A11()
    End Sub
    Private Sub NUpDown_CanArt12_ValueChanged(sender As Object, e As EventArgs) Handles NUpDown_CanArt12.ValueChanged
        Call CALCUALAR_TOTAL_A12()
    End Sub
    Private Sub NUpDown_CanArt13_ValueChanged(sender As Object, e As EventArgs) Handles NUpDown_CanArt13.ValueChanged
        Call CALCUALAR_TOTAL_A13()
    End Sub
    Private Sub NUpDown_CanArt14_ValueChanged(sender As Object, e As EventArgs) Handles NUpDown_CanArt14.ValueChanged
        Call CALCUALAR_TOTAL_A14()
    End Sub
    Private Sub NUpDown_CanArt15_ValueChanged(sender As Object, e As EventArgs) Handles NUpDown_CanArt15.ValueChanged
        Call CALCUALAR_TOTAL_A15()
    End Sub
    Private Sub NUpDown_CanArt16_ValueChanged(sender As Object, e As EventArgs) Handles NUpDown_CanArt16.ValueChanged
        Call CALCUALAR_TOTAL_A16()
    End Sub
    Private Sub NUpDown_CanArt17_ValueChanged(sender As Object, e As EventArgs) Handles NUpDown_CanArt17.ValueChanged
        Call CALCUALAR_TOTAL_A17()
    End Sub
    Private Sub NUpDown_CanArt18_ValueChanged(sender As Object, e As EventArgs) Handles NUpDown_CanArt18.ValueChanged
        Call CALCUALAR_TOTAL_A18()
    End Sub
    Private Sub NUpDown_CanArt19_ValueChanged(sender As Object, e As EventArgs) Handles NUpDown_CanArt19.ValueChanged
        Call CALCUALAR_TOTAL_A19()
    End Sub
    Private Sub NUpDown_CanArt20_ValueChanged(sender As Object, e As EventArgs) Handles NUpDown_CanArt20.ValueChanged
        Call CALCUALAR_TOTAL_A20()
    End Sub
   
   
End Class
