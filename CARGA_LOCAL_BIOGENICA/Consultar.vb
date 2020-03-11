Public Class Consultar
    Dim SQL As New SQL
    Dim Varios As New Miselaneo







    Function fCalcular_FechaNacimiento() As DateTime
        Dim nFecha As DateTime
        If CDbl(TxtAno.Text) <> 0 And TxtAno.Text <> "" Then
            nFecha = DateAdd(DateInterval.Year, -(CDbl(TxtAno.Text)), Now)

        ElseIf TxtMes.Text <> 0 And TxtMes.Text <> "" Then
            nFecha = DateAdd(DateInterval.Month, -(Val(TxtMes.Text)), Now)

        ElseIf CDbl(TxtDia.Text) <> 0 And TxtDia.Text <> "" Then
            nFecha = DateAdd(DateInterval.Day, -(CDbl(TxtDia.Text)), Now)

        End If
        If CDbl(TxtAno.Text) = 0 And CDbl(TxtMes.Text) = 0 And CDbl(TxtDia.Text) = 0 And TxtAno.Text <> "" And TxtMes.Text <> "" And TxtDia.Text <> "" Then
            nFecha = Now

        End If
        Return nFecha
    End Function

    Private Sub Consultar_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        SQL.LLENAR_CBX(cbbEstado, "DESCRIPCION", "pCAT_ESTADOS_B")

        SQL.dataset(Cat_Estados.pCAT_ESTADOS_B, "pCAT_ESTADOS_B")





    End Sub




    Private Sub cPACIENTE_FECHA_NAC_LostFocus(sender As Object, e As EventArgs) Handles cPACIENTE_FECHA_NAC.LostFocus
        calcular_edad_datetime()
    End Sub


    Sub calcular_edad_datetime()
        Try
            Dim ldtFecha1 As Date
            Dim ldtFecha2 As Date
            Dim ldtMesAnterior As Date
            Dim liDias As Integer
            Dim liMeses As Integer
            Dim liAños As Integer
            '
            ldtFecha1 = Now
            ldtMesAnterior = DateAdd("M", -1, ldtFecha1)
            ldtFecha2 = Date.Parse(cPACIENTE_FECHA_NAC.Value)
            '
            liAños = DatePart("yyyy", ldtFecha1) - DatePart("yyyy", ldtFecha2)
            liMeses = DatePart("m", ldtFecha1) - DatePart("m", ldtFecha2)
            liDias = DatePart("d", ldtFecha1) - DatePart("d", ldtFecha2)
            Do While liDias < 0
                If liMeses = 0 Then
                    liDias = liDias + DateAndTime.Day(DateSerial(Year(ldtFecha1), Month(ldtFecha1) + 1, 0)) - 1
                Else
                    liDias = liDias + DateAndTime.Day(DateSerial(Year(ldtMesAnterior), Month(ldtMesAnterior) + 1, 0))
                End If
                liMeses = liMeses - 1
                ldtMesAnterior = DateAdd("M", -1, ldtMesAnterior)
            Loop
            If liMeses < 0 Then
                liMeses = liMeses + 12
                liAños = liAños - 1
            End If





            TxtAno.Text = liAños
            TxtMes.Text = liMeses
            TxtDia.Text = liDias

        Catch ex As Exception

        End Try
    End Sub

    Private Sub cbbEstado_SelectedIndexChanged(sender As Object, e As EventArgs)
        'If cbbEstado.SelectedIndex = -1 Then Exit Sub


        'SQL.ParametersX_Global(0) = New SqlClient.SqlParameter("@Cve_Estado", cbbEstado.)

        'SQL.LLENAR_CBX(cbbMunicipio, "DESCRIPCION", "pCAT_MUNICIPIOS_B", SQL.ParametersX_Global)
    End Sub

    Private Sub LookUpEdit1_EditValueChanged(sender As Object, e As EventArgs) Handles LookUpEdit1.EditValueChanged


        If LookUpEdit1.SelectedText <> Nothing Then Exit Sub

        ReDim SQL.ParametersX_Global(0)
        SQL.ParametersX_Global(0) = New SqlClient.SqlParameter("@Cve_Estado", LookUpEdit1.EditValue)

        SQL.LLENAR_CBX(cbbMunicipio, "DESCRIPCION", "pCAT_MUNICIPIOS_B", SQL.ParametersX_Global)

    End Sub
End Class
