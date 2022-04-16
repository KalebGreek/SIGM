Public Class ModContrato
	Public Sub New()
		' This call is required by the designer.
		InitializeComponent()
		' Add any initialization after the InitializeComponent() call.
		Label9.BackColor = My.Settings.CurrentMenuColor
		inicio.Value = Today
		inicio.MaxDate = Today

		Dim dtab As DataTable = Empleado.BuscarPorPersona("", False)
		If dtab.Rows.Count > 0 Then
			BSAutoridad1.DataSource = dtab
			CtrlMan.Fill.SetAutoComplete(autoridad1, BSAutoridad1, "razon", "cuil")
			autoridad1.SelectedIndex = -1

			BSAutoridad2.DataSource = dtab
			CtrlMan.Fill.SetAutoComplete(autoridad2, BSAutoridad2, "razon", "cuil")
			autoridad2.SelectedIndex = -1
		End If
		dtab.Dispose()
	End Sub


	'###### GUI ##########################################################################################
	Private Sub GuardarCambios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarCambios.Click
		Guardar()
	End Sub
	Private Sub cancelar_Click(sender As Object, e As EventArgs) Handles Cancelar.Click
		Me.Close()

	End Sub

	Private Sub autoridad1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles autoridad1.SelectedIndexChanged, autoridad1.TextChanged,
																						  autoridad2.SelectedIndexChanged, autoridad2.TextChanged
		If Me.Visible Then
			If BSAutoridad1.Position > -1 Then
				Aut1Cuil.Text = autoridad1.SelectedValue
			Else
				Aut1Cuil.Clear()
			End If
			If BSAutoridad2.Position > -1 Then
				Aut2Cuil.Text = autoridad2.SelectedValue
			Else
				Aut2Cuil.Clear()
			End If
		End If
	End Sub

	Private Sub seccion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles seccion.SelectedIndexChanged
		If seccion.Text <> "" And Me.Visible Then
			codigo.Value = SeekLastContract(codigo.Minimum)
		End If
	End Sub

	Private Sub Buscar_Click(sender As Object, e As EventArgs) Handles buscar.Click
		Dim source As DataRowView = Persona.Seleccionar(Me)
		If source Is Nothing Then
			razon.Text = ""
			cuil.Text = ""
		Else
			razon.Text = source("razon")
			cuil.Text = source("cuil")
			BSContratado.DataSource = source
		End If
	End Sub


	'FUNCTIONS
	Private Function SeekLastContract(contrato_id As Integer) As Integer
		Dim Sql(2) As String
		Sql(0) = "SELECT MAX(codigo) as ultimo"
		Sql(1) = " FROM contrato"
		Sql(2) = " WHERE seccion='" & seccion.Text & "'"
		Dim dr As DataRow = DbMan.ReadDB(Sql, My.Settings.CurrentDB, "", True)
		If dr("ultimo") Is DBNull.Value = False Then
			Return CInt(dr("ultimo"))
		Else
			Return 0
		End If
	End Function

	'###### VALIDAR ##########################################################################################
	Private Function ValidarCambios() As Boolean
		Dim valido As Boolean = False
		'Formatting
		descripcion.Text = Trim(descripcion.Text)
		descripcion.Text = Replace(descripcion.Text, vbCrLf, " • ")

		'Validation
		If CtrlMan.Validate(FlowLayoutPanel1) _
		And CtrlMan.Validate(FlowLayoutPanel2) _
		And CtrlMan.Validate(FlowLayoutPanel3) Then
			If SeekLastContract(codigo.Value) = codigo.Value Then
				codigo.BackColor = My.Settings.ErrorColorValue
			Else
				codigo.BackColor = My.Settings.DefaultColorValue
				If autoridad1.Text = autoridad2.Text Then
					autoridad2.BackColor = My.Settings.ErrorColorValue
				Else
					autoridad2.BackColor = My.Settings.DefaultColorValue
					valido = True
				End If
			End If

		End If
		Return valido
	End Function

	'###### GUARDAR ##########################################################################################
	Private Sub Guardar()
		If ValidarCambios() Then
			'Guardar contrato
			Dim answer As MsgBoxResult = MsgBox("¿Desea guardar este contrato?", MsgBoxStyle.YesNoCancel, "Guardar cambios")
			If answer = MsgBoxResult.Yes Or answer = MsgBoxResult.No Then
				If answer = MsgBoxResult.Yes Then
					Dim contratado, autoridad1, autoridad2 As Integer
					Dim fecha_inicio As String = Format(inicio.Value, "MM/dd/yyyy") 'Access
					contratado = BSContratado.Current("persona_id")
					autoridad1 = BSAutoridad1.Current("empleado_id")
					autoridad2 = BSAutoridad2.Current("empleado_id")

					Dim sqlInsert As String = "INSERT INTO contrato(codigo, contratado_id, inicio, 
																	dias, monto, descripcion,
																	autoridad1_id, autoridad2_id,
																	seccion, user_id)
													VALUES(" & codigo.Value & ", " & contratado & ", #" & fecha_inicio & "#,
														   " & dias.Value & ", '" & monto.Value & "', '" & descripcion.Text & "',
														   " & autoridad1 & ", " & autoridad2 & ",
														  '" & seccion.Text & "', " & My.Settings.UserId & ")"

					DbMan.EditDB(sqlInsert, My.Settings.CurrentDB)


					If SeekLastContract(codigo.Value) = codigo.Value Then
						Me.Close()
					Else
						MsgBox("No se guardaron los cambios.")
					End If
				End If

			End If
		End If
	End Sub
End Class
