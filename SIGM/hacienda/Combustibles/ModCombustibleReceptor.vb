Public Class ModCombustibleReceptor
    Inherits System.Windows.Forms.Form

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        alta.Value = Today
        alta.MaxDate = Today
        baja.Value = Today
        baja.MaxDate = Today
        modelo.value = Today.Year
        modelo.Maximum = Today.Year

        Hacienda.FillCuentasHacienda(bs_cuenta, cuenta, 2, "9", "1", "1", "2", "01")
        Combustible.Receptor.FillCategory(bs_categoria, categoria, vehiculo.Checked)
        Combustible.Responsable.Fill(bs_responsable, responsable, 0) 'Formats the bindingsource
    End Sub

    'LOAD
    Public Sub LoadReceptor(id As Integer)
        CtrlMan.LoadControlData(Combustible.Receptor.Seleccionar(id), Me)
        Combustible.Responsable.Fill(bs_responsable, responsable, receptor_id.Text)
    End Sub

    'RESPONSABLE
    Private Sub AddResponsable_Click(sender As Object, e As EventArgs) Handles AddResponsable.Click
        Dim source As DataRowView = Persona.Seleccionar(Me)
        If source Is Nothing = False Then
            Dim pos As Integer = bs_responsable.Find("persona_id", source("persona_id"))
            If pos < 0 Then

                DbMan.EditDB("INSERT INTO hac_combustible_responsable(receptor_id, persona_id) 
								      VALUES(" & receptor_id.Text & ", " & source("persona_id").ToString & ")",
                             My.Settings.CurrentDB)

                Combustible.Responsable.Fill(bs_responsable, responsable, receptor_id.Text)
                pos = bs_responsable.Find("persona_id", source("persona_id").ToString)
            End If
            bs_responsable.Position = pos
        End If

    End Sub
    Private Sub DelResponsable_Click(sender As Object, e As EventArgs) Handles DelResponsable.Click
        Dim source As DataRowView = bs_responsable.Current
        If source Is Nothing = False Then
            If MsgBoxResult.Yes = MsgBox("Desea eliminar el responsable seleccionado?.",
                                         MsgBoxStyle.YesNo) Then

                Dim delete_id As Integer = source("responsable_id")

                DbMan.EditDB("DELETE * FROM hac_combustible_responsable WHERE id=" & delete_id,
                             My.Settings.CurrentDB)

                Combustible.Responsable.Fill(bs_responsable, responsable, receptor_id.Text)
                source = bs_responsable.Current

                DbMan.EditDB("UPDATE hac_combustible_ticket
							         SET responsable_id=" & source("responsable_id").ToString & "
                                   WHERE responsable_id=" & delete_id,
                             My.Settings.CurrentDB)

            End If
        End If
    End Sub
    Private Sub bs_responsable_PositionChanged(sender As Object, e As EventArgs) Handles bs_responsable.PositionChanged,
                                                                                         bs_responsable.CurrentChanged
        If bs_responsable.Position > -1 Then
            cuil_responsable.Text = bs_responsable.Current("cuil").ToString
        Else
            cuil_responsable.Text = ""
        End If
    End Sub

    'CATEGORIA
    Private Sub AddCategoria_Click(sender As Object, e As EventArgs) Handles AddCategoria.Click
        Dim nueva_cat As String = ""
        Dim vehiculo As Boolean = True
        nueva_cat = InputBox("Ingrese nombre de nueva seccion.")
        If nueva_cat <> Nothing Then
            nueva_cat = Trim(nueva_cat)
            If Len(nueva_cat) > 2 Then
                vehiculo = MsgBoxResult.Yes = MsgBox("Esta categoria incluye vehiculos?", MsgBoxStyle.YesNo)
                DbMan.EditDB("INSERT INTO hac_combustible_categoria_receptor(detalle, vehiculo) 
					                   VALUES(" & nueva_cat & ", " & vehiculo & ")",
                             My.Settings.CurrentDB)
            End If
        End If
    End Sub

    Private Sub DelCategoria_Click(sender As Object, e As EventArgs) Handles DelCategoria.Click
        If bs_categoria.Position > -1 Then
            If categoria.Text <> "OTROS VEHICULOS" And categoria.Text <> "OTRAS HERRAMIENTAS" Then
                If MsgBoxResult.Yes = MsgBox("Desea eliminar esta categoria? Los receptores incluidos se moveran a la
											  categoria 'OTROS VEHICULOS' u 'OTRAS HERRAMIENTAS', segun su tipo.",
                                              MsgBoxStyle.YesNo) Then

                    Dim sqlMod(1) As String

                    If vehiculo.Checked Then
                        sqlMod(0) = "UPDATE hac_combustible_receptor SET categoria_id=1 
										   WHERE categoria_id=" & categoria.SelectedValue.ToString
                    Else
                        sqlMod(0) = "UPDATE hac_combustible_receptr SET categoria_id=9 
										   WHERE categoria_id=" & categoria.SelectedValue.ToString
                    End If

                    sqlMod(1) = "DELETE * FROM hac_combustible_categoria_receptor WHERE id=" & categoria.SelectedValue.ToString

                    DbMan.EditDB(sqlMod, My.Settings.CurrentDB)

                End If
            End If
        End If
    End Sub

    Private Sub vehiculo_CheckedChanged(sender As Object, e As EventArgs) Handles vehiculo.CheckedChanged
        Combustible.Receptor.FillCategory(bs_categoria, categoria, vehiculo.Checked)
    End Sub


    'SAVE RECEPTOR
    Private Function SaveReceptor() As Boolean
        Dim saved As Boolean = False
        'Solo Access
        Dim fecha_alta As String = Format(alta.Value, "MM/dd/yyyy") 'Access
        Dim fecha_baja As String = Format(baja.Value, "MM/dd/yyyy") 'Access
        marca.Text = Trim(marca.Text)
        dominio.Text = Trim(dominio.Text)
        observaciones.Text = Trim(observaciones.Text)

        If CtrlMan.Validate(Me) Then
            If MsgBoxResult.Yes = MsgBox("Desea guardar este receptor?", MsgBoxStyle.YesNo, "Guardar Ticket") Then
                If receptor_id.Text > 0 Then
                    DbMan.EditDB("UPDATE hac_combustible_receptor
								     SET cuenta=" & cuenta.SelectedValue.ToString & ", categoria_id=" & categoria.SelectedValue.ToString & ",
									     marca='" & marca.Text & "', mercosur=" & mercosur.Checked & ", 
									     dominio='" & dominio.Text & "', modelo=" & modelo.Value & ", 
									     alta=#" & fecha_alta & "#, baja=#" & fecha_baja & "#,
									     observaciones='" & observaciones.Text & "'
								   WHERE id=" & receptor_id.Text,
                                 My.Settings.CurrentDB)

                    saved = True
                ElseIf receptor_id.Text = 0 Then
                    DbMan.EditDB("INSERT INTO hac_combustible_receptor(cuenta, categoria_id, marca,
								    								  mercosur, dominio,
																	  modelo, alta,
																	  observaciones)
									   VALUES(" & cuenta.SelectedValue.ToString & ", 
											  " & categoria.SelectedValue.ToString & ", '" & marca.Text & "',
                                              " & mercosur.Checked & ", '" & dominio.Text & "', 
											  " & modelo.Value & ", #" & fecha_alta & "#,
											 '" & observaciones.Text & "')",
                                My.Settings.CurrentDB)

                    receptor_id.Text = DbMan.ReadDB("SELECT id FROM hac_combustible_receptor ORDER BY id ASC",
                                                    My.Settings.CurrentDB).Rows(0)("id")
                    saved = True
                End If
            End If
        End If

        Return saved
    End Function

    Private Sub SaveAdd_Click(sender As Object, e As EventArgs) Handles SaveAdd.Click
        If SaveReceptor() Then
            alta.Value = Today
            alta.MaxDate = Today
            baja.Value = Today
            baja.MaxDate = Today
            modelo.Value = Today.Year
            modelo.Maximum = Today.Year

            receptor_id.Text = 0
            cuenta.SelectedIndex = 0
            categoria.SelectedIndex = 0
            argentina.Checked = True

            Combustible.Responsable.Fill(bs_responsable, responsable, receptor_id.Text) 'Formats the bindingsource
        End If
    End Sub

    Private Sub Save_Click(sender As Object, e As EventArgs) Handles Save.Click
        SaveReceptor()
    End Sub

    Private Sub cerrar_Click(sender As Object, e As EventArgs) Handles cerrar.Click
        If MsgBoxResult.Yes = MsgBox("Desea guardar los cambios?", MsgBoxStyle.YesNo) Then
            If SaveReceptor() Then
                Me.Close()
            End If
        Else
            Me.Close()
        End If
    End Sub

    Private Sub mercosur_CheckedChanged(sender As Object, e As EventArgs) Handles mercosur.CheckedChanged
        If mercosur.Checked Then
            dominio.MaxLength = 9
        Else
            dominio.MaxLength = 7
        End If
    End Sub
End Class
