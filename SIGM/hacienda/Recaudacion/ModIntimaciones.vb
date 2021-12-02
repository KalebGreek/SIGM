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
        razon.Text = Trim(BuscarContribuyente(codigo.Text))
    End Sub

    Private Function BuscarContribuyente(codigo As Integer) As String
        tablas_fox(servicio.Text)
        Return DbMan.ReadDB("SELECT " & ext_persona & ".razon FROM " & ext_persona & " WHERE codigo=" & codigo,
                            My.Settings.foxConnection).Rows(0)("razon").ToString

    End Function

    Private Sub Buttons_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addNew.Click, delete.Click, cancel.Click, save.Click
        If sender Is addNew Then
            visor_intimaciones.Hide()
            TopMenu.Hide()
            BottomMenu.Show()
            wrapper.Show()
        ElseIf sender Is delete Then
            Dim intimacion As DataRowView = bs_intimaciones.Current
            If intimacion Is Nothing = False Then
                If DialogResult.Yes = MessageBox.Show("Desea eliminar este registro?", "Eliminar registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) Then
                    Dim ing As Date = intimacion("ingreso")
                    DbMan.EditDB("DELETE FROM hac_intimaciones
                                                WHERE codigo=" & codigo.Text & " AND servicio='" & servicio.Text & "'
                                                  AND ingreso={^" & ing.Year & "/" & ing.Month & "/" & ing.Day & "}
                                                  AND observacion='" & intimacion("observacion").ToString & "' AND estado='" & intimacion("estado").ToString & "'",
                                 My.Settings.foxConnection)

                End If
            End If
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
            razon.Text = Trim(BuscarContribuyente(codigo.Text))
        End If
    End Sub

    Private Function Guardar() As Boolean
        Dim ing As Date = ingreso.Value
        Return DbMan.EditDB("INSERT INTO hac_intimaciones(servicio, codigo, ingreso, observacion, estado)
                                  VALUES('" & servicio.Text & "'," & codigo.Text & ",{^" & ing.Year & "/" & ing.Month & "/" & ing.Day & "},
                                      '" & observacion.Text & "', '" & estado.Text & "')",
                            My.Settings.foxConnection)
    End Function

    Private Sub Listar(serv As String, cod As Integer)
        Dim dtab As DataTable
        Dim sqlSelect As String

        sqlSelect = "SELECT ingreso, observacion, estado
                            FROM hac_intimaciones 
                           WHERE servicio ='" & serv & "' AND codigo=" & cod & "
                        ORDER BY ingreso DESC"

        dtab = DbMan.ReadDB(sqlSelect, My.Settings.foxConnection)
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
        Dim source As DataRowView = bs_intimaciones.Current
        If source Is Nothing = False Then
            MsgBox("Ingreso:" & source("ingreso").ToString & Chr(13) _
                        & "Estado:" & source("estado").ToString & Chr(13) _
                        & source("observacion").ToString, MsgBoxStyle.Information, "Cuenta N°" & codigo.Text)

        End If

    End Sub

End Class