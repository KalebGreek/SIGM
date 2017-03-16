Imports System.ComponentModel
Public Class ModCombustibleReceptor
	Inherits System.Windows.Forms.Form
	Public receptor_id As Integer = 0
	Private responsable_id As Integer = 0

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

		Hacienda.FillCuenta(bs_cuenta, cuenta)
		Combustible.FillCategory(bs_categoria, categoria, vehiculo.Checked)
		Combustible.FillResponsable(bs_responsable, responsable, 0) 'Formats the bindingsource
	End Sub

	'LOAD
	Public Sub LoadReceptor(id As Integer)
		If id > 0 Then
			Dim dtab As DataTable = DbMan.read(My.Settings.DefaultCon, "SELECT * FROM hac_combustible_receptor WHERE id=" & id)
			If dtab.Rows.Count > 0 Then
				CtrlMan.LoadAllControls(dtab(0), Me)
				Combustible.FillResponsable(bs_responsable, responsable, id)
			End If
		End If
	End Sub

	'RESPONSABLE
	Private Sub AddResponsable_Click(sender As Object, e As EventArgs) Handles AddResponsable.Click
		Dim SelResp As New ControlBusquedaPersona
		SelResp.ShowDialog(Me)
		If SelResp.bs_resultado.Position > -1 Then
			Dim pos As Integer = bs_responsable.Find("persona_id", SelResp.bs_resultado.Current("persona_id"))
			If pos < 0 Then
				bs_responsable.AddNew()
				bs_responsable.Current("razon") = SelResp.bs_resultado.Current("razon")
				bs_responsable.Current("cuil") = SelResp.bs_resultado.Current("cuil")
				bs_responsable.Current("persona_id") = SelResp.bs_resultado.Current("persona_id")
				bs_responsable.EndEdit()

				cuil_responsable.Text = bs_responsable.Current("cuil").ToString
			Else
				bs_responsable.Position = pos
			End If
		End If
	End Sub
	Private Sub DelResponsable_Click(sender As Object, e As EventArgs) Handles DelResponsable.Click
		If bs_responsable.Position > -1 Then
			If MsgBoxResult.Yes = MsgBox("Desea eliminar el responsable seleccionado?", MsgBoxStyle.YesNo) Then
				bs_responsable.RemoveCurrent()
			End If
		End If
	End Sub
	Private Sub bs_responsable_PositionChanged(sender As Object, e As EventArgs) Handles bs_responsable.PositionChanged
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
				DbMan.edit(My.Settings.DefaultCon, "INSERT INTO hac_combustible_categoria_receptor(detalle, vehiculo) 
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
						DbMan.edit(My.Settings.DefaultCon, "UPDATE hac_combustible_receptor SET categoria_id=1 
															WHERE categoria_id=" & categoria.SelectedValue)
					Else
						DbMan.edit(My.Settings.DefaultCon, "UPDATE hac_combustible_receptor SET categoria_id=9 
															WHERE categoria_id=" & categoria.SelectedValue)
					End If

					DbMan.edit(My.Settings.DefaultCon, "DELETE * FROM hac_combustible_categoria_receptor WHERE id=" & categoria.SelectedValue)

				End If
			End If
		End If
	End Sub

	'SAVE RECEPTOR
	Private Function SaveReceptor() As Boolean
		'Solo Access
		Dim fecha_alta As String = Format(alta.Value, "MM/dd/yyyy") 'Access
		Dim fecha_baja As String = Format(baja.Value, "MM/dd/yyyy") 'Access
		marca.Text = Trim(marca.Text)
		dominio.Text = Trim(dominio.Text)
		observaciones.Text = Trim(observaciones.Text)

		If CtrlMan.Validate(Me) Then
			If MsgBoxResult.Yes = MsgBox("Desea guardar este receptor?", MsgBoxStyle.YesNo, "Guardar Ticket") Then
				If receptor_id > 0 Then
					DbMan.edit(My.Settings.DefaultCon, "UPDATE hac_combustible_receptor
														   SET cuenta_id=" & cuenta.SelectedValue & ", categoria_id=" & categoria.SelectedValue & ",
															   marca='" & marca.Text & "', mercosur=" & mercosur.Checked & ", 
															   dominio='" & dominio.Text & "', modelo=" & modelo.Value & ", 
															   alta=#" & fecha_alta & "#, baja=#" & fecha_baja & "#,
															   observaciones='" & observaciones.Text & "'")
				ElseIf receptor_id = 0 Then
					DbMan.edit(My.Settings.DefaultCon, "INSERT INTO hac_combustible_receptor(cuenta_id, 
																							 categoria_id, marca,
																							 mercosur, dominio,
																							 modelo, alta,
																							 observaciones)
																					  VALUES(" & cuenta.SelectedValue & ", 
																							 " & categoria.SelectedValue & ", '" & marca.Text & "',	
																							 " & mercosur.Checked & ", '" & dominio.Text & "', 
																							 " & modelo.Value & ", #" & fecha_alta & "#,
																							 '" & observaciones.Text & "')")

					Dim dtab As DataTable = DbMan.read(My.Settings.DefaultCon, "SELECT id FROM hac_combustible_receptor ORDER BY id ASC")
					receptor_id = dtab(0)("id")
				End If
				SaveResponsable()
			End If
		End If
	End Function
	Private Sub SaveResponsable()
		DbMan.edit(My.Settings.DefaultCon, "DELETE * FROM hac_combustible_responsable WHERE receptor_id=" & receptor_id)
		For row As Integer = 0 To bs_responsable.Count - 1
			DbMan.edit(My.Settings.DefaultCon, "INSERT INTO 
												hac_combustible_responsable(receptor_id, persona_id)
																	 VALUES(" & receptor_id & ", " & bs_responsable.Item(row)("persona_id") & ")")
		Next
	End Sub

	Private Sub SaveAdd_Click(sender As Object, e As EventArgs) Handles SaveAdd.Click
		If SaveReceptor() Then
			Me.SuspendLayout()
			Me.Refresh()
			Me.PerformLayout()
		End If
	End Sub

	Private Sub Save_Click(sender As Object, e As EventArgs) Handles Save.Click
		If SaveReceptor() Then
			Me.Parent.Focus()
			Me.Close()
		End If
	End Sub

	Private Sub cerrar_Click(sender As Object, e As EventArgs) Handles cerrar.Click
		If MsgBoxResult.Yes = MsgBox("No se guardaran los cambios, desea continuar?", MsgBoxStyle.YesNo) Then
			Me.Parent.Focus()
			Me.Close()
		End If
	End Sub

	Private Sub mercosur_CheckedChanged(sender As Object, e As EventArgs) Handles mercosur.CheckedChanged
		dominio.Clear()
		If mercosur.Checked Then
			dominio.Mask = "AA 000 AA"
		Else
			dominio.Mask = "AAA 000"
		End If
	End Sub


End Class
