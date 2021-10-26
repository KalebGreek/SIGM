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
		Using SelPersona As New BusquedaPersona(True) With {.Owner = Me}
			SelPersona.ShowDialog()
			BSContratado = SelPersona.bs_resultado
		End Using
		If BSContratado.Position > -1 Then
			razon.Text = BSContratado.Current("razon").ToString
			cuil.Text = BSContratado.Current("cuil").ToString
		End If

	End Sub


	'FUNCTIONS
	Private Function SeekLastContract(contrato_id As Integer) As Integer
		Dim Sql(2) As String
		Sql(0) = "SELECT MAX(codigo) as ultimo"
		Sql(1) = "FROM contrato"
		Sql(2) = "WHERE seccion='" & seccion.Text & "'"
		Dim dr As DataRow = DbMan.ReadDB(Sql, My.Settings.CurrentDB).Rows(0)
		If dr("ultimo") Is DBNull.Value = False Then
			contrato_id = CInt(dr("ultimo")) + 1
		End If
		Return contrato_id
	End Function

	'###### VALIDAR ##########################################################################################
	Private Function ValidarCambios() As Boolean
		Dim valido As Boolean = False
		'Formatting
		descripcion.Text = Trim(descripcion.Text)
		descripcion.Text = Replace(descripcion.Text, vbCrLf, " • ")

		'Validation
		If CtrlMan.Validate(FlowLayoutPanel1) And CtrlMan.Validate(FlowLayoutPanel2) _
	   And CtrlMan.Validate(FlowLayoutPanel3) Then
			If autoridad1.Text = autoridad2.Text Then
				autoridad2.BackColor = My.Settings.ErrorColorValue
			Else
				autoridad2.BackColor = My.Settings.DefaultColorValue
				valido = True
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
					Dim sqlInsert As String()
					sqlInsert.Append("INSERT INTO contrato(codigo, contratado_id, inicio, 
												dias, monto, descripcion,
												autoridad1_id, autoridad2_id,
												seccion, user_id)
										 VALUES(" & codigo.Value & ", " & CInt(BSContratado.Current("persona_id").ToString) & ", '" & inicio.Value & "',
												 " & dias.Value & ", " & monto.Value & ", '" & descripcion.Text & "',
												 " & BSAutoridad1.Current("empleado_id").ToString & ", " & BSAutoridad2.Current("empleado_id").ToString & ",
												'" & seccion.Text & "', " & My.Settings.UserId & ")")

					DbMan.EditDB(sqlInsert, My.Settings.CurrentDB)
				End If
				Me.Close()
			End If
		End If
	End Sub
End Class
