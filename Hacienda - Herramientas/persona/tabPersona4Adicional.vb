Public Class tabPersona4Adicional
	Inherits System.Windows.Forms.UserControl
	Public Sub New()
		' This call is required by the designer.
		InitializeComponent()

		' Add any initialization after the InitializeComponent() call.
		'Proveedor
		bs_responsable_iva.DataSource = DbMan.read("SELECT * FROM responsable_iva ORDER BY descripcion", My.Settings.DefaultCon)
		CtrlMan.Fill.SetAutoComplete(responsable_iva, bs_responsable_iva, "descripcion", "id")
		bs_actividad.DataSource = DbMan.read("SELECT * FROM prov_actividad ORDER BY actividad", My.Settings.DefaultCon)
		CtrlMan.Fill.SetAutoComplete(actividad, bs_actividad, "actividad", "id")
		'Profesional
		bs_titulo.DataSource = DbMan.read("SELECT * FROM profesional_titulo ORDER BY descripcion", My.Settings.DefaultCon)
		CtrlMan.Fill.SetAutoComplete(titulo, bs_titulo, "descripcion", "id")
	End Sub

	'FUNCIONES
	Public Function cargar(id As Integer) As Boolean
		If id > 0 Then
			Dim dtab As DataTable = DbMan.read("SELECT id as persona_id,
													   difunto, ruta_defuncion, fisica
												  FROM persona WHERE id=" & id, My.Settings.DefaultCon)
			CtrlMan.LoadAllControls(dtab(0), Me)
			difunto.Enabled = dtab(0)("fisica")
			If difunto.Enabled = False Then
				difunto.Checked = False
				ruta_defuncion.Text = ""
			End If

			dtab = Proveedor.Seleccionar(proveedor_id.Text, id)
			EsProveedor.Checked = dtab.Rows.Count > 0
			If dtab.Rows.Count > 0 Then
				CtrlMan.LoadAllControls(dtab(0), FlowLayoutPanel2)
			End If

			dtab = Profesional.Seleccionar(profesional_id.Text, id)
			EsProfesional.Checked = dtab.Rows.Count > 0
			If dtab.Rows.Count > 0 Then
				CtrlMan.LoadAllControls(dtab(0), FlowLayoutPanel1)
			End If
		End If
		Return True
	End Function

	Public Function guardar(persona_id As Integer) As Boolean
		If CtrlMan.Validate(Me) Then
			'Difunto
			DbMan.edit("UPDATE persona SET difunto=" & difunto.Checked & ", 
											   ruta_defuncion='" & ruta_defuncion.Text & "'
										 WHERE id=" & persona_id)
			'Proveedor
			If EsProveedor.Checked Then
				proveedor_id.Text = Proveedor.guardar(proveedor_id.Text, persona_id, actividad.SelectedValue, responsable_iva.SelectedValue)
			Else
				proveedor_id.Text = Proveedor.eliminar(persona_id)
			End If
			'Profesional
			If EsProfesional.Checked Then
				profesional_id.Text = Profesional.guardar(profesional_id.Text, persona_id, titulo.SelectedValue, matricula.Text)
			Else
				profesional_id.Text = Profesional.eliminar(persona_id)
			End If
		End If
		Return True
	End Function

	'Eventos
	Private Sub esProveedor_CheckedChanged(sender As Object, e As EventArgs) Handles EsProveedor.CheckedChanged, difunto.CheckedChanged, EsProfesional.CheckedChanged
		responsable_iva.Visible = EsProveedor.Checked
		et_act.Visible = EsProveedor.Checked
		actividad.Visible = EsProveedor.Checked
		add_actividad.Visible = EsProveedor.Checked
		del_actividad.Visible = EsProveedor.Checked

		ruta_defuncion.Visible = difunto.Checked
		cargar_defu.Visible = difunto.Checked

		titulo.Visible = EsProfesional.Checked
		add_titulo.Visible = EsProfesional.Checked
		del_titulo.Visible = EsProfesional.Checked
		et_matr.Visible = EsProfesional.Checked
		matricula.Visible = EsProfesional.Checked

	End Sub

	'EVENTOS
	Private Sub ruta_defuncion_DoubleClick(sender As Object, e As EventArgs) Handles ruta_defuncion.DoubleClick
		If Len(ruta_defuncion.Text) > 0 Then
			Process.Start(root & My.Settings.DocFolderPersona & ruta_defuncion.Text)
		End If
	End Sub
	Private Sub cargar_defu_Click(sender As Object, e As EventArgs) Handles cargar_defu.Click
		ruta_defuncion.Text = Documento.Persona.CertificadoDefuncion(persona_id.Text)
	End Sub

	Private Sub add_actividad_Click(sender As Object, e As EventArgs) Handles add_actividad.Click
		Dim value As String = ""
		Dim vehiculo As Boolean = True
		value = InputBox("Indique la actividad comercial a continuacion.")
		If value <> Nothing Then
			value = UCase(Trim(value))
			If Len(value) > 2 Then
				DbMan.edit("INSERT INTO prov_actividad(actividad) 
												VALUES('" & value & "')")

				bs_actividad.DataSource = DbMan.read("SELECT * FROM prov_actividad ORDER BY actividad", My.Settings.DefaultCon)
				CtrlMan.Fill.SetAutoComplete(actividad, bs_actividad, "actividad", "id")
			End If
		End If
	End Sub

	Private Sub del_actividad_Click(sender As Object, e As EventArgs) Handles del_actividad.Click
		If bs_actividad.Position > -1 Then
			If MsgBoxResult.Yes = MsgBox("Desea eliminar esta actividad comercial?", MsgBoxStyle.YesNo) Then
				DbMan.edit("DELETE * FROM prov_actividad WHERE id=" & bs_actividad.Current("id"))

				bs_actividad.DataSource = DbMan.read("SELECT * FROM prov_actividad ORDER BY actividad", My.Settings.DefaultCon)
				CtrlMan.Fill.SetAutoComplete(actividad, bs_actividad, "actividad", "id")
			End If
		End If
	End Sub



	Private Sub add_titulo_Click(sender As Object, e As EventArgs) Handles add_titulo.Click
		Dim value As String = ""
		Dim vehiculo As Boolean = True
		value = InputBox("Indique el titulo a continuacion.")
		If value <> Nothing Then
			value = UCase(Trim(value))
			If Len(value) > 2 Then
				DbMan.edit("INSERT INTO profesional_titulo(descripcion) 
													VALUES('" & value & "')")

				bs_titulo.DataSource = DbMan.read("SELECT * FROM profesional_titulo ORDER BY descripcion", My.Settings.DefaultCon)
				CtrlMan.Fill.SetAutoComplete(titulo, bs_titulo, "descripcion", "id")
			End If
		End If
	End Sub
	Private Sub del_titulo_Click(sender As Object, e As EventArgs) Handles del_titulo.Click
		If bs_titulo.Position > -1 Then
			If MsgBoxResult.Yes = MsgBox("Desea eliminar este titulo?", MsgBoxStyle.YesNo) Then
				DbMan.edit("DELETE * FROM profesional_titulo WHERE id=" & bs_titulo.Current("id"))

				bs_titulo.DataSource = DbMan.read("SELECT * FROM profesional_titulo ORDER BY descripcion", My.Settings.DefaultCon)
				CtrlMan.Fill.SetAutoComplete(titulo, bs_titulo, "descripcion", "id")
			End If
		End If
	End Sub





End Class
