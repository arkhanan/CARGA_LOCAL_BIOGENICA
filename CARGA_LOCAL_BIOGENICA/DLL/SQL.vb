Imports System.Data.SqlClient
Imports System.IO.Ports

Public Class SQL

    Public sConexionx As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DB_Proyecto.mdf;Integrated Security=True"
    Public sClue As String '= "19"
    Public cConnect As New SqlConnection()
    Public TipoConexionX As TipoConexion
    Public cCommand As New SqlCommand  'OleDbCommand
    Private _Error As String
    Public dtsucursal As New DataTable
    Public ParametersX_Global() As System.Data.SqlClient.SqlParameter

    Function Conectar()


        Try
            If cConnect.State = ConnectionState.Closed Then
                cConnect.ConnectionString = sConexionx
                cConnect.Open()
            End If
            Return "OK"
        Catch ex As SystemException
            Return ex.Message

        End Try
    End Function

    Function Conectar_prueba()
        sConexionx = TipoConexionX.sNombreServidor
        Try
            If cConnect.State = ConnectionState.Closed Then
                cConnect.ConnectionString = sConexionx
                cConnect.Open()

            End If
            Return "Conectado"
        Catch ex As SystemException
            Return ex.Message
        End Try

    End Function

    Sub Desconectar()

        Try
            If cConnect.State <> ConnectionState.Closed Then
                cConnect.Close()
            End If
        Catch ex As SystemException
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    'Public Function puerto_com(equipo As String)
    '    Dim s As String
    '    Dim dt As New DataTable
    '    Conectar()
    '    Dim Csql As New SqlCommand("pCAT_EQUIPOS_B", cConnect)
    '    cCommand.CommandType = CommandType.StoredProcedure
    '    Dim adap As SqlDataAdapter
    '    adap = New SqlDataAdapter(cCommand)
    '    adap.Fill(dt)
    '    adap.Dispose()
    '    For i As Integer = 0 To dt.Rows.Count - 1
    '        If dt.Rows(i).Item("Cve_Equipo") = equipo Then
    '            s = dt.Rows(i).Item("PUERTOS")
    '            Exit For
    '        End If
    '    Next
    '    Return s
    'End Function




    'Public Sub InsertHist(ByVal sFolio As String, ByVal sElementoInterfaz As String, ByVal sCve_Equipo As String, ByVal sResultado As String)
    '    Dim conectar As New SqlConnection
    '    conectar.ConnectionString = Conexion_SQL
    '    Dim sqlComm As New SqlCommand()
    '    sqlComm.Connection = conectar
    '    sqlComm.CommandText = "pHistorial_Interface"
    '    sqlComm.CommandType = CommandType.StoredProcedure
    '    sqlComm.Parameters.AddWithValue("@Folio", sFolio)
    '    sqlComm.Parameters.AddWithValue("@Subestudio", sElementoInterfaz)
    '    sqlComm.Parameters.AddWithValue("@Equipo", sCve_Equipo)
    '    sqlComm.Parameters.AddWithValue("@Resultado", sResultado)
    '    conectar.Open()
    '    sqlComm.ExecuteNonQuery()
    '    conectar.Close()
    'End Sub



    Public Function fGuardar_O_EliminarXProcedure_DevuelveId(ByVal sProcedureName As String, ByVal sNombreCampoRetornar As String, Optional ByVal cParams As SqlParameter() = Nothing, Optional ByVal bMostrarMensaje As Boolean = True, Optional ByVal dbtype As System.Data.SqlDbType = SqlDbType.Int, Optional ByVal sSize As Integer = 0) As String
        Dim functionReturnValue As String = Nothing
        Dim i As Integer = 0
        Dim MENSAJE As String = Conectar()
        If Conectar() = "OK" Then



            Try
                Dim cCommand As New SqlCommand(sProcedureName, cConnect)
                cCommand.CommandType = CommandType.StoredProcedure
                If Not (cParams Is Nothing) Then
                    For i = 0 To cParams.GetLength(0) - 1
                        If cParams(i) Is Nothing = False Then
                            cCommand.Parameters.Add(cParams(i))
                        End If
                    Next
                End If
                '***********************************************************
                Dim parameterConsecutivo As New SqlParameter(sNombreCampoRetornar, dbtype, sSize)
                parameterConsecutivo.Direction = ParameterDirection.Output
                cCommand.Parameters.Add(parameterConsecutivo)
                '***********************************************************
                ' Open the database connection and execute the command
                cCommand.ExecuteNonQuery()
                If (parameterConsecutivo.Value IsNot Nothing) And (Not Object.ReferenceEquals(parameterConsecutivo.Value, System.DBNull.Value)) Then
                    functionReturnValue = "Ok"
                Else
                    functionReturnValue = Nothing
                End If
            Catch ex As Exception

                Return ex.Message
            Finally
                Desconectar()
            End Try
            Return functionReturnValue
        Else
            Return MENSAJE
        End If
    End Function

    Function tablas(procedure As String, Optional ByVal cParams() As SqlParameter = Nothing) As DataTable
        Conectar()
        Dim adapter As New SqlDataAdapter(procedure, cConnect)
        adapter.SelectCommand.CommandType = CommandType.StoredProcedure

        If Not (cParams Is Nothing) Then
            For i = 0 To cParams.GetLength(0) - 1
                If cParams(i) Is Nothing = False Then
                    adapter.SelectCommand.Parameters.Add(cParams(i))
                End If
            Next
        End If
        Dim ds As New DataTable
        adapter.Fill(ds)
        Return ds
    End Function

    Public Sub datagrid(datagrid As DataSet, dataset As Object, procedure As String, Optional ByVal cParams() As SqlParameter = Nothing)
        Try
            Conectar()
            datagrid.Clear()
            Dim ADAP As SqlDataAdapter = New SqlDataAdapter(procedure, sConexionx)
            ADAP.SelectCommand.CommandType = CommandType.StoredProcedure
            If cParams Is Nothing = False Then
                For i = 0 To cParams.GetLength(0) - 1
                    If cParams(i) Is Nothing = False Then
                        ADAP.SelectCommand.Parameters.Add(cParams(i))
                    End If
                Next
            End If
            ADAP.Fill(dataset)
            ADAP.Dispose()
            Desconectar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub dataset(dataset As Object, procedure As String, Optional ByVal cParams() As SqlParameter = Nothing)
        Try
            Conectar()
            dataset.Clear()
            Dim ADAP As SqlDataAdapter = New SqlDataAdapter(procedure, sConexionx)
            ADAP.SelectCommand.CommandType = CommandType.StoredProcedure
            If cParams Is Nothing = False Then
                For i = 0 To cParams.GetLength(0) - 1
                    If cParams(i) Is Nothing = False Then
                        ADAP.SelectCommand.Parameters.Add(cParams(i))
                    End If
                Next
            End If
            ADAP.Fill(dataset)
            ADAP.Dispose()
            Desconectar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Public Sub LLENAR_CBX(CB As DevExpress.XtraEditors.ComboBoxEdit, OBTENER As String, PROCEDURE As String, Optional ByVal cParams() As SqlParameter = Nothing)
        Conectar()
        Dim cmd As New SqlCommand(PROCEDURE, cConnect)
        cmd.CommandType = CommandType.StoredProcedure
        If cParams Is Nothing = False Then
            For i = 0 To cParams.GetLength(0) - 1
                If cParams(i) Is Nothing = False Then
                    cmd.Parameters.Add(cParams(i))
                End If
            Next
        End If
        Dim adapter As Data.SqlClient.SqlDataReader = Nothing
        adapter = cmd.ExecuteReader(CommandBehavior.CloseConnection)
        If adapter.HasRows Then
            While adapter.Read
                CB.Properties.Items.Add(adapter.Item(OBTENER))
            End While
        End If
        Desconectar()
        adapter.Close()
    End Sub


    Public Function llenar_dt(procedure As String, Optional ByVal cParams() As SqlParameter = Nothing) As DataTable
        Try
            Dim dt As New DataTable
            Conectar()
            Dim cmd As New SqlCommand(procedure, cConnect)
            cmd.CommandType = CommandType.StoredProcedure
            If cParams Is Nothing = False Then
                For i = 0 To cParams.GetLength(0) - 1
                    If cParams(i) Is Nothing = False Then
                        cmd.Parameters.Add(cParams(i))
                    End If
                Next
            End If
            Dim adapter As New Data.SqlClient.SqlDataAdapter
            adapter.SelectCommand = cmd
            adapter.Fill(dt)
            Desconectar()
            Return dt
        Catch ex As Exception

        End Try
    End Function




    Public Structure TipoConexion
        Friend sNombreServidor As String
        Friend sTipoConexion As String
        Friend sNombreBaseDatos As String
        Friend sHostBackup As String
        Friend swebactive As Boolean
    End Structure

    'Sub CARGAR_DATASET()
    '    Try


    '        Dim RETORNAR As String
    '        Dim M As New Miselaneo
    '        DATASET_EQUIPO = New DataSet

    '        Dim DT As New DataTable
    '        Dim DT2 As New DataTable
    '        Dim DT3 As New DataTable
    '        Dim DT4 As New DataTable
    '        ReDim ParametersX_Global(1)
    '        ParametersX_Global(0) = New SqlClient.SqlParameter("@ID_PC", id_HDD)
    '        'ParametersX_Global(1) = New SqlClient.SqlParameter("@CVE_SUCURSAL", M.RegistryKey_Leer(0, "SUCURSAL"))
    '        DT = llenar_dt("[pEquipos_B]", ParametersX_Global)
    '        DT.TableName = "EQUIPO"
    '        DATASET_EQUIPO.Tables.Add(DT)
    '        If DATASET_EQUIPO.Tables("EQUIPO").Rows.Count > 0 Then

    '            ReDim ParametersX_Global(1)
    '            'ParametersX_Global(0) = New SqlClient.SqlParameter("@Equipo", id_HDD)
    '            DT2 = llenar_dt("pConfiguracion_RS232_B")
    '            DT2.TableName = "CONFIGURACION_RS232"

    '            DATASET_EQUIPO.Tables.Add(DT2)


    '            'ReDim ParametersX_Global(1)
    '            'ParametersX_Global(0) = New SqlClient.SqlParameter("@HDD", id_HDD)
    '            DT3 = llenar_dt("pEquipos_Division_B", ParametersX_Global)
    '            DT3.TableName = "SEPARACION"

    '            DATASET_EQUIPO.Tables.Add(DT3)

    '            DT4 = llenar_dt("pConfiguracion_Equipo_B")
    '            DT4.TableName = "CONFIGURACION"
    '            DATASET_EQUIPO.Tables.Add(DT4)


    '        End If

    '    Catch ex As Exception

    '    End Try



    'End Sub

    'Public Function comprobarDato(ByVal valor As String, ByVal camp As String, ByVal dt As DataTable) As Boolean
    '    For Each r1 As DataRow In dt.Rows
    '        If valor = r1(camp) Then
    '            Return True
    '        End If
    '    Next
    '    Return False
    'End Function

    'Public Function InsertData(ByVal sFolio As String, ByVal sClue As String, ByVal sElementoInterfaz As String, ByVal sCve_Equipo As String, ByVal sResultado As String) As String
    '    Dim retrieved As String, ret As Boolean
    '    Try

    '        Dim cParams As System.Data.SqlClient.SqlParameter() = New System.Data.SqlClient.SqlParameter(4) {}

    '        cParams(0) = New System.Data.SqlClient.SqlParameter("@Folio", sFolio)
    '        cParams(1) = New System.Data.SqlClient.SqlParameter("@Clue", sClue)
    '        cParams(2) = New System.Data.SqlClient.SqlParameter("@Elemento_Interfaz", sElementoInterfaz)
    '        cParams(3) = New System.Data.SqlClient.SqlParameter("@Cve_Equipo", sCve_Equipo)
    '        cParams(4) = New System.Data.SqlClient.SqlParameter("@Resultado", sResultado)

    '        retrieved = fGuardar_O_EliminarXProcedure_DevuelveId("pPACIENTES_SOLICITUDES_RESULTADOS_OBTIENE_INTERFACE", "@Parametro", cParams, False, SqlDbType.VarChar, 50)

    '        If retrieved = "OK" Then
    '            Return "OK"
    '        Else
    '            Return retrieved
    '        End If

    '    Catch ex As Exception
    '        Return ex.Message
    '    End Try

    'End Function

    'Public Function loadEstudios(ByVal proc As String, ByVal id As String, ByVal data As String, Optional ByVal pass As String = "") As DataTable
    '    Dim t As New DataTable
    '    Dim r As DataRow

    '    Conectar()

    '    Dim cDataReader As Data.SqlClient.SqlDataReader
    '    Try
    '        Dim com = New SqlClient.SqlCommand(proc, cConnect)
    '        com.CommandType = CommandType.StoredProcedure

    '        If pass <> "" Then cCommand.Parameters.AddWithValue("@PassphraseEnteredByUser", pass)

    '        com.Parameters.AddWithValue("@cve_equipo", data)

    '        cDataReader = com.ExecuteReader(CommandBehavior.CloseConnection)

    '        t = New DataTable

    '        With t.Columns
    '            .Add(id)
    '        End With

    '        If cDataReader.HasRows Then
    '            While (cDataReader.Read)
    '                r = t.NewRow()
    '                r.Item(0) = cDataReader.Item(id)
    '                t.Rows.Add(r)
    '            End While
    '        End If

    '    Catch ex As SystemException

    '    Finally
    '        Desconectar()
    '    End Try
    '    Return t
    'End Function


    'Function DATA_SET_ELEMENTOS(STR As String)
    '    Dim M As New Miselaneo
    '    Dim EQX As String
    '    Dim DT_ELEMENTOS = New DataTable

    '    ReDim ParametersX_Global(1)
    '    ParametersX_Global(0) = New SqlClient.SqlParameter("@EQUIPO", STR)
    '    DT_ELEMENTOS = llenar_dt("pElemento_Interfaz_B", ParametersX_Global)

    '    Return DT_ELEMENTOS
    'End Function

End Class
