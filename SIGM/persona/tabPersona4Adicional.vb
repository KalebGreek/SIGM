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
		ruta_defuncion.Text = FileMan.Persona.CertificadoDefuncion(PersonaId)
	End Sub

	Private Sub add_actividad_Click(sender As Object, e As EventArgs) Handles add_actividad.Click
		Dim value As String = ""
		Dim vehiculo As Boolean = True
		value = InputBox("Indique la actividad comercial a continuacion.")
		If value <> Nothing Then
			value = UCase(Trim(value))
			If Len(value) > 2 Then
				DbMan.EditDB("INSERT INTO prov_actividad(actividad) 
								   VALUES('" & value & "')",
							 My.Settings.CurrentDB)

				bs_actividad.DataSource = DbMan.ReadDB("SELECT * FROM prov_actividad ORDER BY actividad",
													   My.Settings.CurrentDB)

				CtrlMan.Fill.SetAutoComplete(actividad, bs_actividad, "actividad", "id")
			End If
		End If
	End Sub

	Private Sub del_actividad_Click(sender As Object, e As EventArgs) Handles del_actividad.Click
		If bs_actividad.Position > -1 Then
			If MsgBoxResult.Yes = MsgBox("Desea eliminar esta actividad comercial?", MsgBoxStyle.YesNo) Then
				DbMan.EditDB("DELETE * FROM prov_actividad WHERE id=" & bs_actividad.Current("id").ToString, My.Settings.CurrentDB)
				bs_actividad.DataSource = DbMan.ReadDB("SELECT * FROM prov_actividad ORDER BY actividad", My.Settings.CurrentDB)

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
				DbMan.EditDB("INSERT INTO profesional_titulo(descripcion) 
								   VALUES('" & value & "')",
							 My.Settings.CurrentDB)

				bs_titulo.DataSource = DbMan.ReadDB("SELECT * FROM profesional_titulo ORDER BY descripcion",
													My.Settings.CurrentDB)

				CtrlMan.Fill.SetAutoComplete(titulo, bs_titulo, "descripcion", "id")
			End If
		End If
	End Sub
	Private Sub del_titulo_Click(sender As Object, e As EventArgs) Handles del_titulo.Click
		If bs_titulo.Position > -1 Then
			If MsgBoxResult.Yes = MsgBox("Desea eliminar este titulo?", MsgBoxStyle.YesNo) Then
				DbMan.EditDB("DELETE * FROM profesional_titulo WHERE id=" & bs_titulo.Current("id").ToString,
							 My.Settings.CurrentDB)
				bs_titulo.DataSource = DbMan.ReadDB("SELECT * FROM profesional_titulo ORDER BY descripcion",
													My.Settings.CurrentDB)

				CtrlMan.Fill.SetAutoComplete(titulo, bs_titulo, "descripcion", "id")
			End If
		End If
	End Sub

	'FUNCIONES
	Public Sub cargar()
		

		'Rellenar Responsable IVA
		bs_responsable_iva.DataSource = DbMan.ReadDB("SELECT * FROM responsable_iva ORDER BY descripcion",
													 My.Settings.CurrentDB)
		CtrlMan.Fill.SetAutoComplete(responsable_iva, bs_responsable_iva, "descripcion", "id")

		'Rellenar Actividad Comercial
		bs_actividad.DataSource = DbMan.ReadDB("SELECT actividad as id, detalle as actividad FROM comact ORDER BY detalle",
											   My.Settings.foxConnection)
		CtrlMan.Fill.SetAutoComplete(actividad, bs_actividad, "actividad", "id")

		'Rellenar Títulos Profesionales
		bs_titulo.DataSource = DbMan.ReadDB("SELECT * FROM profesional_titulo ORDER BY descripcion",
											My.Settings.CurrentDB)
		CtrlMan.Fill.SetAutoComplete(titulo, bs_titulo, "descripcion", "id")

		'Está morido? Is it pinning for the fjords?
		Dim drow As DataRow = DbMan.ReadDB("SELECT id as persona_id, difunto, ruta_defuncion, fisica
												FROM persona WHERE id=" & PersonaId,
											 My.Settings.CurrentDB, "", True)

		difunto.Enabled = drow("fisica") 'Para estar morido tiene que ser una persona real
		If difunto.Enabled Then
			CtrlMan.LoadControlData(drow, Me)
		Else
			difunto.Checked = False
			ruta_defuncion.Text = ""
		End If

		'Es empleado?
		drow = Empleado.Seleccionar(0, PersonaId)
		EsEmpleado.Checked = drow Is Nothing = False
		If drow Is Nothing = False Then
			EmpleadoId = drow("empleado_id")
			CtrlMan.LoadControlData(drow, FlowLayoutPanel4)
		End If

		'Es Proveedor?
		drow = Proveedor.Seleccionar(0, PersonaId)
		EsProveedor.Checked = drow Is Nothing = False
		If drow Is Nothing = False Then
			ProveedorId = drow("proveedor_id")
			CtrlMan.LoadControlData(drow, FlowLayoutPanel2)
		End If

		'Es profesional?
		drow = Profesional.Seleccionar(0, PersonaId)
		EsProfesional.Checked = drow Is Nothing = False
		If drow Is Nothing = False Then
			ProfesionalId = drow("profesional_id")
			CtrlMan.LoadControlData(drow, FlowLayoutPanel1)
		End If
	End Sub

	Public Function Guardar() As Integer
		If CtrlMan.Validate(Me) Then
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
			DbMan.EditDB("UPDATE persona SET difunto=" & difunto.Checked & ", ruta_defuncion='" & ruta_defuncion.Text & "'
						   WHERE id=" & PersonaId,
						 My.Settings.CurrentDB)
			Return PersonaId
		Else
			Return 0
		End If

	End Function


End Class
