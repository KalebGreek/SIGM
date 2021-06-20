Class ModIntimaciones

    Public pageCount As Integer = 1

    Public Sub New(serv As String, cod As Integer)
        ' This call is required by the designer.
        ' Add any initialization after the InitializeComponent() call.
        InitializeComponent()
        'servicio.Items.AddRange(New Object() {"aguas", "automovil", "barrios", "catastro", "comercio", "sepelio"})
        estado.Items.AddRange(New Object() {"PLAN DE PAGO", "CONTACTADO", "EN MORA", "CARTA DOCUMENTO", "PRE-JUDICIAL", "JUDICIAL"})

        servicio.Text = serv
        codigo.Text = cod
    End Sub

    ' GUI
    Private Sub buscar_Click(sender As Object, e As EventArgs) Handles buscar.Click
        BuscarContribuyente()
    End Sub

    Private Sub BuscarContribuyente()
        Dim sql(0) As String
        Dim dtab As DataTable
        tablas_fox(servicio.Text)
        sql(0) = "SELECT " & ext_persona & ".razon FROM " & ext_persona & " WHERE codigo=" & codigo.Text
        dtab = DbMan.ReadDB(Nothing, My.Settings.foxConnection, sql)
        If dtab.Rows.Count > 0 Then
            razon.Text = Trim(dtab.Rows(0)("razon"))
        End If
    End Sub

    Private Sub Buttons_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addNew.Click, delete.Click, cancel.Click, save.Click
        If sender Is addNew Then
            visor_intimaciones.Hide()
            TopMenu.Hide()
            BottomMenu.Show()
            wrapper.Show()
        ElseIf sender Is delete Then
            With bs_intimaciones
                If .DataSource Is Nothing = False Then
                    If .Position > -1 Then
                        If DialogResult.Yes = MessageBox.Show("Desea eliminar este registro?", "Eliminar registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) Then
                            Dim ing As Date = .Current("ingreso")
                            DbMan.EditDB(Nothing, My.Settings.foxConnection,
                                         "DELETE FROM hac_intimaciones
                                           WHERE codigo=" & codigo.Text & " AND servicio='" & servicio.Text & "'
                                             AND ingreso={^" & ing.Year & "/" & ing.Month & "/" & ing.Day & "}
                                             AND observacion='" & .Current("observacion") & "' AND estado='" & .Current("estado") & "'")

                        End If
                    End If
                End If
            End With
        ElseIf sender Is cancel Then
            visor_intimaciones.Show()
            TopMenu.Show()
            BottomMenu.Hide()
            wrapper.Hide()
        ElseIf sender Is save Then
            If CtrlMan.Validate(wrapper) Then
                If Guardar() Then
                    visor_intimaciones.Show()
                    TopMenu.Show()
                    BottomMenu.Hide()
                    wrapper.Hide()
                End If
            End If
        End If
        Listar(servicio.Text, codigo.Text)
    End Sub

    Private Sub codigo_KeyUp(sender As Object, e As KeyEventArgs) Handles codigo.KeyUp
        If e.KeyValue = Keys.Enter Then
            BuscarContribuyente()
        End If
    End Sub

    Private Function Guardar() As Boolean
        Dim sql As String
        Dim ing As Date = ingreso.Value

        sql = "INSERT INTO hac_intimaciones(servicio, codigo, ingreso, observacion, estado)
                    VALUES('" & servicio.Text & "'," & codigo.Text & ",{^" & ing.Year & "/" & ing.Month & "/" & ing.Day & "},
                           '" & observacion.Text & "', '" & estado.Text & "')"
        Return DbMan.EditDB(Nothing, My.Settings.foxConnection, sql)
    End Function

    Private Sub Listar(serv As String, cod As Integer)
        Dim dtab As DataTable
        Dim sql(3) As String

        sql(0) = "SELECT ingreso, observacion, estado"
        sql(1) = "FROM hac_intimaciones"
        sql(2) = "WHERE servicio='" & serv & "' AND codigo=" & cod
        sql(3) = "ORDER BY ingreso DESC"

        dtab = DbMan.ReadDB(Nothing, My.Settings.foxConnection, sql)
        If dtab Is Nothing = False Then
            CtrlMan.DataGridViewTools.Load(visor_intimaciones, bs_intimaciones, dtab)
        End If
    End Sub

    Private Sub ModIntimaciones_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        'Mostrar diálogo correcto
        If Me.Visible Then
            If codigo.Text > 0 Then
                Listar(servicio.Text, codigo.Text)
            Else
                Buttons_Click(addNew, Nothing)
            End If
        End If
    End Sub

    Private Sub visor_intimaciones_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles visor_intimaciones.CellContentDoubleClick
        With bs_intimaciones
            If .Position > -1 Then
                MsgBox("Ingreso:" & .Current("ingreso") & Chr(13) _
                        & "Estado:" & .Current("estado") & Chr(13) _
                        & .Current("observacion"), MsgBoxStyle.Information, "Cuenta N°" & codigo.Text)

            End If
        End With
    End Sub

End Class