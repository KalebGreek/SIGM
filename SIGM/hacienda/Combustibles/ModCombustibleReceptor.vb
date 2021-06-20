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
        Dim bs As BindingSource = Persona.Seleccionar(Me)
        With bs.DataSource
            If .Position > -1 Then
                Dim pos As Integer = bs_responsable.Find("persona_id", .Current("persona_id"))
                If pos < 0 Then

                    DbMan.editDB(Nothing, My.Settings.CurrentDB, "INSERT INTO hac_combustible_responsable(receptor_id, persona_id) 
															 VALUES(" & receptor_id.Text & ", 
																	" & .Current("persona_id") & ")")

                    Combustible.Responsable.Fill(bs_responsable, responsable, receptor_id.Text)
                    pos = bs_responsable.Find("persona_id", .Current("persona_id"))
                End If
                bs_responsable.Position = pos
            End If
        End With
    End Sub
    Private Sub DelResponsable_Click(sender As Object, e As EventArgs) Handles DelResponsable.Click
        If bs_responsable.Position > -1 And bs_responsable.Count > 1 Then
            If MsgBoxResult.Yes = MsgBox("Desea eliminar el responsable seleccionado?.",
                                         MsgBoxStyle.YesNo) Then

                Dim delete_id As Integer = bs_responsable.Current("responsable_id")

                DbMan.editDB(Nothing, My.Settings.CurrentDB, "DELETE * FROM hac_combustible_responsable WHERE id=" & delete_id)

                Combustible.Responsable.Fill(bs_responsable, responsable, receptor_id.Text)

                DbMan.editDB(Nothing, My.Settings.CurrentDB,
                           "UPDATE hac_combustible_ticket
							   SET responsable_id=" & bs_responsable(0)("responsable_id") &
                           " WHERE responsable_id=" & delete_id)

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
                vehiculo = (MsgBoxResult.Yes = MsgBox("Esta categoria incluye vehiculos?", MsgBoxStyle.YesNo))
                DbMan.editDB(Nothing, My.Settings.CurrentDB,
                "INSERT INTO hac_combustible_categoria_receptor(detalle, vehiculo) 
					  VALUES(" & nueva_cat & ", " & vehiculo & ")")
            End If
        End If
    End Sub

    Private Sub DelCategoria_Click(sender As Object, e As EventArgs) Handles DelCategoria.Click
        If bs_categoria.Position > -1 Then
            If categoria.Text <> "OTROS VEHICULOS" And categoria.Text <> "OTRAS HERRAMIENTAS" Then
                If MsgBoxResult.Yes = MsgBox("Desea eliminar esta categoria? Los receptores incluidos se moveran a la
											  categoria 'OTROS VEHICULOS' u 'OTRAS HERRAMIENTAS', segun su tipo.",
                                              MsgBoxStyle.YesNo) Then

                    If vehiculo.Checked Then
                        DbMan.editDB(Nothing, My.Settings.CurrentDB, "UPDATE hac_combustible_receptor SET categoria_id=1 
															WHERE categoria_id=" & categoria.SelectedValue)
                    Else
                        DbMan.editDB(Nothing, My.Settings.CurrentDB, "UPDATE hac_combustible_receptor SET categoria_id=9 
															WHERE categoria_id=" & categoria.SelectedValue)
                    End If

                    DbMan.editDB(Nothing, My.Settings.CurrentDB,
                                "DELETE * FROM hac_combustible_categoria_receptor WHERE id=" & categoria.SelectedValue)

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
                    DbMan.editDB(Nothing, My.Settings.CurrentDB,
                               "UPDATE hac_combustible_receptor
								   SET cuenta=" & cuenta.SelectedValue & ", categoria_id=" & categoria.SelectedValue & ",
									   marca='" & marca.Text & "', mercosur=" & mercosur.Checked & ", 
									   dominio='" & dominio.Text & "', modelo=" & modelo.Value & ", 
									   alta=#" & fecha_alta & "#, baja=#" & fecha_baja & "#,
									   observaciones='" & observaciones.Text & "'
								 WHERE id=" & receptor_id.Text)

                    saved = True
                ElseIf receptor_id.Text = 0 Then
                    DbMan.editDB(Nothing, My.Settings.CurrentDB,
                                "INSERT INTO hac_combustible_receptor(cuenta, categoria_id, marca,
																	  mercosur, dominio,
																	  modelo, alta,
																	  observaciones)
															  VALUES(" & cuenta.SelectedValue & ", 
																	 " & categoria.SelectedValue & ", '" & marca.Text & "',	
																	 " & mercosur.Checked & ", '" & dominio.Text & "', 
																	 " & modelo.Value & ", #" & fecha_alta & "#,
																	  '" & observaciones.Text & "')")

                    Dim sql(0) As String
                    sql(0) = "SELECT id FROM hac_combustible_receptor ORDER BY id ASC"
                    Dim dtab As DataTable = DbMan.ReadDB(Nothing, My.Settings.CurrentDB, sql)

                    receptor_id.Text = dtab.Rows(0)("id")
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
