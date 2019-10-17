Public Class ModPago
    Public Sub New(opr As Integer, deuda As Boolean)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        opr_id.Text = opr
        add_deuda.Visible = deuda
        solo_deuda.Checked = deuda
        cuota.Enabled = deuda
        If deuda = False Then
            titulo.Text = "> AGREGAR PAGO"
            desc.Enabled = False
            et_fecha.Text = "Fecha de Pago"
            et_monto.Text = "Monto   $ "
            et_cuota.Text = "Cuota N°"
        End If
    End Sub
    Private Sub Me_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        ConsultarDeudas()
    End Sub
    Private Sub ConsultarDeudas()
        If Me.Visible Then
            visor = CtrlMan.DataGridViewTools.Load(visor, bs_pago, "", Pagos.Consultar(opr_id.Text, solo_deuda.Checked))
        End If
    End Sub


    Private Sub bs_pago_positionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bs_pago.PositionChanged
        With visor
            If bs_pago.Count > 0 And add_deuda.Visible = False Then 'Activa o desactiva la lista según el bindingsource
                .DataSource = bs_pago
                'Dar formato a DataGridView

                .Columns("id").Width = 1
                .Columns("tipo_deuda").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                .Columns("cuota").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader
                .Columns("deuda").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns("fecha_pago").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader
                .Columns("pago").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

                '# Agregar deuda
                '# Cancelar deuda
                desc.Text = bs_pago.Current("tipo_deuda").ToString
                monto.Minimum = bs_pago.Current("deuda").ToString
                cuota.Value = bs_pago.Current("cuota").ToString
                add_pago.Enabled = False
                If bs_pago.Current("fecha_pago").ToString = "" Then
                    add_pago.Enabled = True
                End If
            End If
        End With
    End Sub
    Private Sub consulta_KeyUp(sender As Object, e As KeyEventArgs) Handles visor.KeyUp
        With bs_pago
            If e.KeyValue = Keys.Delete And bs_pago.Position > -1 Then
                If .Current("fecha_pago").ToString = "" Then
                    If MsgBoxResult.Yes = MsgBox("¿Desea eliminar esta deuda?", MsgBoxStyle.YesNo) Then
                        Pagos.EliminarDeuda(.Current("id"), opr_id.Text)
                        ConsultarDeudas()
                    End If
                Else
                    MsgBox("No se pueden eliminar deudas ya canceladas.")
                End If
            End If
        End With
    End Sub
    Private Sub solo_deuda_CheckedChanged(sender As Object, e As EventArgs) Handles solo_deuda.CheckedChanged
        ConsultarDeudas()
    End Sub
    Private Sub cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
        Me.Close()
    End Sub


    Private Sub add_deuda_Click(sender As Object, e As EventArgs) Handles add_deuda.Click
        If Len(desc.Text) > 4 And monto.Value > 0 And cuota.Value >= 1 Then
            Pagos.AgregarDeuda(opr_id.Text, desc.Text, monto.Value, cuota.Value,
                                               fecha.Value)
            fecha.Value = Date.Today
            ConsultarDeudas()
        End If
    End Sub
    Private Sub add_pago_Click(sender As Object, e As EventArgs) Handles add_pago.Click
        With visor.DataSource
            If Len(desc.Text) > 0 And monto.Value > 0 And fecha.Value.Date <= Date.Today Then
                If .Current("fecha_pago").ToString = "" And .Current("pago").ToString = "0,00" Then
                    'Agregar Pago
                    Pagos.AgregarPago(.Current("id"), opr_id.Text, fecha.Value, monto.Value)
                    'Generar recibo
                    Dim parametros As New Generic.List(Of ReportParameter)

                    'Crear informe
                    'Dim formPAGO As New VisorReporte("Recibo de pago por " & .current("tipo_deuda"), "OPR\REC", parametros, False)
                    'With formPAGO
                    '.ShowDialog()
                    '.Dispose()
                    'End With

                    ConsultarDeudas()
                End If
            End If
        End With
        Me.Close()
    End Sub
End Class