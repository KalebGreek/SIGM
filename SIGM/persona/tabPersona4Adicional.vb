Public Class tabPersona4Adicional
    Inherits System.Windows.Forms.UserControl
    Dim sql(0) As String

    Private Sub tabPersona4Adicional_ParentChanged(sender As Object, e As EventArgs) Handles Me.ParentChanged
        If Me.Parent Is Nothing = False And My.Settings.CurrentDB <> "" Then
            'Proveedor
            sql(0) = "SELECT * FROM responsable_iva ORDER BY descripcion"
            bs_responsable_iva.DataSource = DbMan.ReadDB(Nothing, My.Settings.CurrentDB, sql)
            CtrlMan.Fill.SetAutoComplete(responsable_iva, bs_responsable_iva, "descripcion", "id")
            sql(0) = "SELECT * FROM prov_actividad ORDER BY actividad"
            bs_actividad.DataSource = DbMan.ReadDB(Nothing, My.Settings.CurrentDB, sql)
            CtrlMan.Fill.SetAutoComplete(actividad, bs_actividad, "actividad", "id")
            'Profesional
            sql(0) = "SELECT * FROM profesional_titulo ORDER BY descripcion"
            bs_titulo.DataSource = DbMan.ReadDB(Nothing, My.Settings.CurrentDB, sql)
            CtrlMan.Fill.SetAutoComplete(titulo, bs_titulo, "descripcion", "id")
        End If
    End Sub

    Private Sub tabPersona4Adicional_Load(sender As Object, e As EventArgs) Handles Me.Load
    End Sub

    Private Sub tabPersona4Adicional_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged

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
		ruta_defuncion.Text = Documento.Persona.CertificadoDefuncion(persona_id.Text)
	End Sub

	Private Sub add_actividad_Click(sender As Object, e As EventArgs) Handles add_actividad.Click
		Dim value As String = ""
        Dim vehiculo As Boolean = True
        Dim sql(0) As String
        value = InputBox("Indique la actividad comercial a continuacion.")
		If value <> Nothing Then
			value = UCase(Trim(value))
			If Len(value) > 2 Then
				DbMan.editDB(Nothing, My.Settings.CurrentDB, "INSERT INTO prov_actividad(actividad) 
												VALUES('" & value & "')")

                sql(0) = "SELECT * FROM prov_actividad ORDER BY actividad"
                bs_actividad.DataSource = DbMan.ReadDB(Nothing, My.Settings.CurrentDB, sql)
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
        Dim sql(0) As String
        value = InputBox("Indique el titulo a continuacion.")
		If value <> Nothing Then
			value = UCase(Trim(value))
			If Len(value) > 2 Then
				DbMan.editDB(Nothing, My.Settings.CurrentDB,
							"INSERT INTO profesional_titulo(descripcion) 
							      VALUES('" & value & "')")

                sql(0) = "SELECT * FROM profesional_titulo ORDER BY descripcion"
                bs_titulo.DataSource = DbMan.ReadDB(Nothing, My.Settings.CurrentDB, sql)
                CtrlMan.Fill.SetAutoComplete(titulo, bs_titulo, "descripcion", "id")
			End If
		End If
	End Sub
	Private Sub del_titulo_Click(sender As Object, e As EventArgs) Handles del_titulo.Click
        Dim sql(0) As String
        If bs_titulo.Position > -1 Then
            If MsgBoxResult.Yes = MsgBox("Desea eliminar este titulo?", MsgBoxStyle.YesNo) Then
                DbMan.editDB(Nothing, My.Settings.CurrentDB, "DELETE * FROM profesional_titulo WHERE id=" & bs_titulo.Current("id"))

                sql(0) = "SELECT * FROM profesional_titulo ORDER BY descripcion"
                bs_titulo.DataSource = DbMan.ReadDB(Nothing, My.Settings.CurrentDB, )
                CtrlMan.Fill.SetAutoComplete(titulo, bs_titulo, "descripcion", "id")
            End If
        End If
    End Sub



    'FUNCIONES
    Public Function cargar(persona_id As Integer) As Boolean
        If persona_id > 0 Then
            Dim sql(0) As String
            sql(0) = "SELECT id as persona_id, difunto, ruta_defuncion, fisica
												  FROM persona WHERE id=" & persona_id
            Dim dtab As DataTable = DbMan.ReadDB(Nothing, My.Settings.CurrentDB, sql)
            CtrlMan.LoadAllControls(dtab(0), Me)

            difunto.Enabled = dtab(0)("fisica")
            If difunto.Enabled = False Then
                difunto.Checked = False
                ruta_defuncion.Text = ""
            End If

            dtab = Empleado.Seleccionar(empleado_id.Text, persona_id)
            EsEmpleado.Checked = dtab.Rows.Count > 0
            If dtab.Rows.Count > 0 Then
                CtrlMan.LoadAllControls(dtab(0), FlowLayoutPanel4)
            End If

            dtab = Proveedor.Seleccionar(proveedor_id.Text, persona_id)
            EsProveedor.Checked = dtab.Rows.Count > 0
            If dtab.Rows.Count > 0 Then
                CtrlMan.LoadAllControls(dtab(0), FlowLayoutPanel2)
            End If

            dtab = Profesional.Seleccionar(profesional_id.Text, persona_id)
            EsProfesional.Checked = dtab.Rows.Count > 0
            If dtab.Rows.Count > 0 Then
                CtrlMan.LoadAllControls(dtab(0), FlowLayoutPanel1)
            End If
        End If
        Return True
    End Function

    Public Function guardar(persona_id As Integer) As Boolean
        If CtrlMan.Validate(Me) Then
            'Empleado
            If EsEmpleado.Checked Then
                Empleado.guardar(empleado_id.Text, persona_id, alta.Value, jerarquia.Text)
            Else
                Empleado.eliminar(empleado_id.Text)
            End If
            'Proveedor
            If EsProveedor.Checked Then
                proveedor_id.Text = Proveedor.guardar(proveedor_id.Text, persona_id, actividad.SelectedValue, responsable_iva.SelectedValue)
            Else
                proveedor_id.Text = Proveedor.eliminar(persona_id)
            End If
            'Profesional
            If EsProfesional.Checked Then
                profesional_id.Text = Profesional.guardar(profesional_id.Text, persona_id, titulo.SelectedValue, matricula.Text)(0)
            Else
                profesional_id.Text = Profesional.eliminar(persona_id)
            End If
            'Difunto
            DbMan.editDB(Nothing, My.Settings.CurrentDB,
                        "UPDATE persona SET difunto=" & difunto.Checked & ", 
							    ruta_defuncion='" & ruta_defuncion.Text & "'
						  WHERE id=" & persona_id)

        End If
        Return True
    End Function


End Class
