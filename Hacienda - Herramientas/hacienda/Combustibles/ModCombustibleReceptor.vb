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

		Combustible.FillSeccion(bs_seccion, seccion)
		Combustible.FillCategory(bs_categoria, categoria, vehiculo.Checked)
	End Sub

	'LOAD
	Private Sub LoadReceptor(id As Integer)
		receptor_id = id
		If id > 0 Then
			Dim dtab As DataTable = DbMan.read(My.Settings.DefaultCon, "SELECT * FROM hac_combustible_receptor WHERE id=" & id)
			If dtab.Rows.Count > 0 Then
				CtrlMan.LoadAllControls(dtab(0), Me)
			End If
		End If
	End Sub

	'SELECTORES
	Private Sub SelectResponsable_Click(sender As Object, e As EventArgs) Handles SelectResponsable.Click
		Dim SelResp As New ControlBusquedaPersona
		SelResp.ShowDialog(Me)
		If SelResp.bs_resultado.Position > -1 Then
			responsable_id = SelResp.bs_resultado.Current("persona_id")
			responsable.Text = SelResp.bs_resultado.Current("razon")
			cuil_responsable.Text = SelResp.bs_resultado.Current("cuil")
		End If
	End Sub
	Private Sub AddSeccion_Click(sender As Object, e As EventArgs) Handles AddSeccion.Click
		Dim nueva_seccion As String = ""
		nueva_seccion = InputBox("Ingrese nombre de nueva seccion.")
		If nueva_seccion <> Nothing Then
			nueva_seccion = Trim(nueva_seccion)
			If Len(nueva_seccion) > 2 Then
				DbMan.edit(My.Settings.DefaultCon, "INSERT INTO seccion(descripcion) VALUES(" & nueva_seccion & ")")
			End If
		End If
	End Sub

	Private Sub DelSeccion_Click(sender As Object, e As EventArgs) Handles DelSeccion.Click
		If bs_seccion.Position > -1 Then
			If seccion.Text <> "OTROS" Then
				If MsgBoxResult.Yes = MsgBox("Desea eliminar esta seccion? Los receptores incluidos se moveran a la seccion 'OTROS'", MsgBoxStyle.YesNo) Then
					DbMan.edit(My.Settings.DefaultCon, "UPDATE hac_combustible_receptor SET seccion_id=1 
														WHERE seccion_id=" & seccion.SelectedValue)
					DbMan.edit(My.Settings.DefaultCon, "DELETE * FROM seccion WHERE id=" & seccion.SelectedValue)
				End If
			End If
		End If
	End Sub

	Private Sub AddCategoria_Click(sender As Object, e As EventArgs) Handles AddCategoria.Click
		Dim nueva_cat As String = ""
		Dim vehiculo As Boolean = True
		nueva_cat = InputBox("Ingrese nombre de nueva seccion.")
		If nueva_cat <> Nothing Then
			nueva_cat = Trim(nueva_cat)
			If Len(nueva_cat) > 2 Then
				vehiculo = (MsgBoxResult.Yes = MsgBox("Esta categoria engloba vehiculos?", MsgBoxStyle.YesNo))
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

					DbMan.edit(My.Settings.DefaultCon, "DELETE * FROM seccion WHERE id=" & categoria.SelectedValue)

				End If
			End If
		End If
	End Sub

	'SAVE RECEPTOR
	Private Function SaveReceptor() As Boolean
		'Solo Access
		Dim fecha_alta As String = Format(alta.Value, "MM/dd/yyyy") 'Access
		Dim fecha_baja As String = Format(baja.Value, "MM/dd/yyyy") 'Access
		Dim monto_autorizado As String = Replace(autorizado.Value, ",", ".")
		marca.Text = Trim(marca.Text)
		dominio.Text = Trim(dominio.Text)
		observaciones.Text = Trim(observaciones.Text)

		If CtrlMan.Validate(Me) Then
			If MsgBoxResult.Yes = MsgBox("Desea guardar este receptor?", MsgBoxStyle.YesNo, "Guardar Ticket") Then
				If receptor_id > 0 Then
					DbMan.edit(My.Settings.DefaultCon, "UPDATE hac_combustible_receptor
														   SET seccion_id=" & seccion.SelectedValue & ", categoria_id=" & categoria.SelectedValue & ",
															   responsable_id=" & responsable_id & ", marca='" & marca.Text & "', 
															   mercosur=" & mercosur.Checked & ", dominio='" & dominio.Text & "', 
															   modelo=" & modelo.Text & ", 
															   alta=#" & fecha_alta & "#, baja=#" & fecha_baja & "#,
															   observaciones='" & observaciones.Text & "', 
															   autorizado=" & monto_autorizado & "")
				ElseIf receptor_id = 0 Then
					DbMan.edit(My.Settings.DefaultCon, "INSERT INTO hac_combustible_receptor(seccion_id, categoria_id,
																							 responsable_id, marca,
																							 mercosur, dominio,
																							 modelo, alta, baja,
																							 observaciones, autorizado)
																					  VALUES(" & seccion.SelectedValue & ", 
																							 " & categoria.SelectedValue & ",
																							 " & responsable_id & ", '" & marca.Text & "',
																							 " & mercosur.Checked & ", '" & dominio.Text & "', 
																							 " & modelo.Text & ",
																							 #" & fecha_alta & "#, #" & fecha_baja & "#,
																							 '" & observaciones.Text & "', 
																							 " & monto_autorizado & ")")
				End If
			End If
		End If
	End Function

	Private Sub SaveAddTicket_Click(sender As Object, e As EventArgs) Handles SaveAdd.Click
		If SaveReceptor() Then
			Me.SuspendLayout()
			Me.Refresh()
			Me.PerformLayout()
		End If
	End Sub

	Private Sub SaveTicket_Click(sender As Object, e As EventArgs) Handles Save.Click
		If SaveReceptor() Then
			Me.Parent.Focus()
			Me.Close()
		End If
	End Sub

	Private Sub cerrar_Click(sender As Object, e As EventArgs) Handles cerrar.Click
		If MsgBoxResult.Ok = MsgBox("No se guardaran los cambios, desea continuar?", MsgBoxStyle.YesNo) Then
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
