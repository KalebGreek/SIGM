Public Class tabPersona4Adicional
	Inherits System.Windows.Forms.UserControl
	Dim PersonaId, EmpleadoId, ProveedorId, ProfesionalId As Integer
	Dim bs_actividad As New BindingSource
	Dim bs_responsable_iva As New BindingSource
	Dim bs_titulo As New BindingSource

	Public Sub New(PerId As Integer)

		' This call is required by the designer.
		InitializeComponent()

		' Add any initialization after the InitializeComponent() call.
		PersonaId = PerId
	End Sub

	'Eventos
	Private Sub esProveedor_CheckedChanged(sender As Object, e As EventArgs) Handles EsEmpleado.CheckedChanged, EsProveedor.CheckedChanged, difunto.CheckedChanged, EsProfesional.CheckedChanged
		jerarquia.Visible = EsEmpleado.Checked
		alta.Visible = EsEmpleado.Checked
		Label1.Visible = EsEmpleado.Checked

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
		ruta_defuncion.Text = Documento.Persona.CertificadoDefuncion(PersonaId)
	End Sub

	Private Sub add_actividad_Click(sender As Object, e As EventArgs) Handles add_actividad.Click
		Dim value As String = ""
		Dim vehiculo As Boolean = True
		value = InputBox("Indique la actividad comercial a continuacion.")
		If value <> Nothing Then
			value = UCase(Trim(value))
			If Len(value) > 2 Then
				Dim sqlInsert, sqlSelect As String()

				sqlInsert.Append("INSERT INTO prov_actividad(actividad) 
									   VALUES('" & value & "')")
				DbMan.EditDB(Nothing, My.Settings.CurrentDB, sqlInsert)

				sqlSelect.Append("SELECT * FROM prov_actividad ORDER BY actividad")
				bs_actividad.DataSource = DbMan.ReadDB(Nothing, My.Settings.CurrentDB, sqlSelect)

				CtrlMan.Fill.SetAutoComplete(actividad, bs_actividad, "actividad", "id")
			End If
		End If
	End Sub

	Private Sub del_actividad_Click(sender As Object, e As EventArgs) Handles del_actividad.Click
		If bs_actividad.Position > -1 Then
			If MsgBoxResult.Yes = MsgBox("Desea eliminar esta actividad comercial?", MsgBoxStyle.YesNo) Then
				Dim sql(0) As String
				DbMan.editDB(Nothing, My.Settings.CurrentDB, "DELETE * FROM prov_actividad WHERE id=" & bs_actividad.Current("id"))

				sql(0) = "SELECT * FROM prov_actividad ORDER BY actividad"
				bs_actividad.DataSource = DbMan.ReadDB(Nothing, My.Settings.CurrentDB, sql)
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
				Dim sqlInsert, sqlSelect As String()

				sqlInsert.Append("INSERT INTO profesional_titulo(descripcion) 
								  VALUES('" & value & "')")
				DbMan.EditDB(Nothing, My.Settings.CurrentDB, sqlInsert)
				sqlSelect.Append("SELECT * FROM profesional_titulo ORDER BY descripcion")
				bs_titulo.DataSource = DbMan.ReadDB(Nothing, My.Settings.CurrentDB, sqlSelect)

				CtrlMan.Fill.SetAutoComplete(titulo, bs_titulo, "descripcion", "id")
			End If
		End If
	End Sub
	Private Sub del_titulo_Click(sender As Object, e As EventArgs) Handles del_titulo.Click
		If bs_titulo.Position > -1 Then
			If MsgBoxResult.Yes = MsgBox("Desea eliminar este titulo?", MsgBoxStyle.YesNo) Then
				Dim sqlDelete, sqlSelect As String()

				sqlDelete.Append("DELETE * FROM profesional_titulo WHERE id=" & bs_titulo.Current("id").ToString)
				DbMan.EditDB(Nothing, My.Settings.CurrentDB, sqlDelete)
				sqlSelect.Append("SELECT * FROM profesional_titulo ORDER BY descripcion")
				bs_titulo.DataSource = DbMan.ReadDB(Nothing, My.Settings.CurrentDB, sqlSelect)

				CtrlMan.Fill.SetAutoComplete(titulo, bs_titulo, "descripcion", "id")
			End If
		End If
	End Sub

	'FUNCIONES
	Public Sub cargar()
		Dim sqlSelect As String()
		Dim dtab As DataTable

		'Rellenar Responsable IVA
		sqlSelect(0) = "SELECT * FROM responsable_iva ORDER BY descripcion"
		bs_responsable_iva.DataSource = DbMan.ReadDB(Nothing, My.Settings.CurrentDB, sqlSelect)
		CtrlMan.Fill.SetAutoComplete(responsable_iva, bs_responsable_iva, "descripcion", "id")

		'Rellenar Actividad Comercial
		sqlSelect(0) = "SELECT actividad as id, detalle as actividad FROM comact ORDER BY detalle"
		bs_actividad.DataSource = DbMan.ReadDB(Nothing, My.Settings.foxConnection, sqlSelect)
		CtrlMan.Fill.SetAutoComplete(actividad, bs_actividad, "actividad", "id")

		'Rellenar Títulos Profesionales
		sqlSelect(0) = "SELECT * FROM profesional_titulo ORDER BY descripcion"
		bs_titulo.DataSource = DbMan.ReadDB(Nothing, My.Settings.CurrentDB, sqlSelect)
		CtrlMan.Fill.SetAutoComplete(titulo, bs_titulo, "descripcion", "id")

		'Está morido? Is it pinning for the fjords?
		sqlSelect(0) = "SELECT id as persona_id, difunto, ruta_defuncion, fisica
						 FROM persona WHERE id=" & PersonaId
		dtab = DbMan.ReadDB(Nothing, My.Settings.CurrentDB, sqlSelect)

		difunto.Enabled = dtab.Rows(0)("fisica") 'Para estar morido tiene que ser una persona real
		If difunto.Enabled Then
			CtrlMan.LoadControlData(dtab, Me)
		Else
			difunto.Checked = False
			ruta_defuncion.Text = ""
		End If

		'Es empleado?
		dtab = Empleado.Seleccionar(0, PersonaId)
		EsEmpleado.Checked = dtab.Rows.Count > 0
		If dtab.Rows.Count > 0 Then
			EmpleadoId = dtab.Rows(0)("empleado_id")
			CtrlMan.LoadControlData(dtab, FlowLayoutPanel4)
		End If

		'Es Proveedor?
		dtab = Proveedor.Seleccionar(0, PersonaId)
		EsProveedor.Checked = dtab.Rows.Count > 0
		If dtab.Rows.Count > 0 Then
			ProveedorId = dtab.Rows(0)("proveedor_id")
			CtrlMan.LoadControlData(dtab, FlowLayoutPanel2)
		End If

		'Es profesional?
		dtab = Profesional.Seleccionar(0, PersonaId)
		EsProfesional.Checked = dtab.Rows.Count > 0
		If dtab.Rows.Count > 0 Then
			ProfesionalId = dtab.Rows(0)("profesional_id")
			CtrlMan.LoadControlData(dtab, FlowLayoutPanel1)
		End If
	End Sub

	Public Function Guardar() As Integer
		If CtrlMan.Validate(Me) Then
			Dim sqlUpdate As String()
			'Empleado
			If EsEmpleado.Checked Then
				Empleado.guardar(EmpleadoId, PersonaId, alta.Value, jerarquia.Text)
			Else
				Empleado.eliminar(EmpleadoId)
			End If
			'Proveedor
			If EsProveedor.Checked Then
				ProveedorId = Proveedor.guardar(ProveedorId, PersonaId, actividad.SelectedValue, responsable_iva.SelectedValue)
			Else
				ProveedorId = Proveedor.eliminar(ProveedorId)
			End If
			'Profesional
			If EsProfesional.Checked Then
				ProfesionalId = Profesional.guardar(ProfesionalId, PersonaId, titulo.SelectedValue, matricula.Text)(0)
			Else
				ProfesionalId = Profesional.eliminar(ProfesionalId)
			End If

			'Difunto
			sqlUpdate.Append("UPDATE persona
								 SET difunto=" & difunto.Checked & ", ruta_defuncion='" & ruta_defuncion.Text & "'
							   WHERE id=" & PersonaId)
			DbMan.EditDB(Nothing, My.Settings.CurrentDB, sqlUpdate)
			Return PersonaId
		Else
			Return 0
		End If

	End Function


End Class
