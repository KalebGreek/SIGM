Imports Sigm.Persona.sql
Public Class ModPersona
    Public Sub New(Optional id As Integer = 0)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        titulo.DataSource = Profesional.ListarTitulos()
        titulo.DisplayMember = "titulo"
        titulo.ValueMember = "id"
        persona_id.Text = id
        If id > 0 Then
            Me.Text = "MODIFICAR PERSONA"
            cargar(Persona.sql.Cargar(persona_id.Text))
        End If
    End Sub
	'###### GUI ##########################################################################################
	Private Sub cancel_Click(sender As Object, e As EventArgs) Handles Cancelar.Click
		Me.Close()
	End Sub

    '###### CARGAR ##########################################################################################
    Sub cargar(registro As DataTable)
		Dim fisica As Boolean = registro(0)("fisica")
		tele.Text = registro(0)("telefono").ToString
		email.Text = registro(0)("email").ToString

		If registro(0)("difunto") Is DBNull.Value Then
			esDifunto.Checked = False
		Else
			esDifunto.Checked = registro(0)("difunto")
			If esDifunto.Checked Then
				If registro(0)("ruta_defuncion") Is DBNull.Value = False Then
					ruta_defuncion.Text = registro(0)("ruta_defuncion")
				End If
			End If
		End If

        'Cargar domicilios
        registro = Domicilio.sql.Listar(persona_id.Text)
		If registro.Rows.Count > 0 Then
			Dim principal As Domicilio.Tab
			For Each dr As DataRow In registro.Rows
				Dim TabDom As New Domicilio.Tab _
							 (TabControl1.TabCount + 1, dr("id").ToString, dr("calle").ToString,
							  Val(dr("altura").ToString),
							  Val(dr("piso").ToString), dr("dpto").ToString)
				TabControl1.TabPages.Add(TabDom)
				If dr("principal") Then
					principal = TabDom
				End If

				TabDom.provincia.DataSource = Domicilio.sql.RellenarProvincias()
				TabDom.provincia.ValueMember = "provincia_id"
				TabDom.provincia.DisplayMember = "provincia"
				TabDom.provincia.Text = dr("provincia").ToString

				TabDom.localidad.SelectedValue = Val(dr("localidad_id").ToString)

			Next
			TabControl1.SelectTab(principal)
		Else
			Dim TabDom As New Domicilio.Tab(TabControl1.TabCount + 1, 0)
			TabControl1.TabPages.Add(TabDom)
		End If

		registro = Profesional.BuscarPorPersona(persona_id.Text)
		If registro.Rows.Count > 0 Then
			If registro(0)("matricula") Is DBNull.Value Then
				esProfesional.Checked = False
			Else
				esProfesional.Checked = True
				prof_id.Text = registro(0)("prof_id")
				titulo.Text = registro(0)("titulo")
				matr.Text = registro(0)("matricula")
			End If
		End If

		registro = Proveedor.BuscarPorPersona(persona_id.Text, fisica)
		If registro.Rows.Count > 0 Then
			If registro(0)("responsable_iva") Is DBNull.Value Then
				esProveedor.Checked = False
			Else
				esProveedor.Checked = True
				responsable.Text = registro(0)("responsable_iva")
			End If
		End If
	End Sub


	Private Sub difunto_CheckedChanged(sender As Object, e As EventArgs) 
        et_defu.Visible = esDifunto.Checked
        ruta_defuncion.Visible = esDifunto.Checked
        cargar_defu.Visible = esDifunto.Checked
    End Sub
    Private Sub ruta_defuncion_Click(sender As Object, e As EventArgs) 
        If Len(ruta_defuncion.Text) > 0 Then
            Process.Start(root & My.Settings.DocFolderPersona & ruta_defuncion.Text)
        End If
    End Sub
    Private Sub cargar_defu_Click(sender As Object, e As EventArgs) 
		'If Len(cuil.Text) = 11 And Len(razon.Text) > 8 Then
		'ruta_defuncion.Text = Documento.Persona.CertificadoDefuncion(cuil.Text)
		'End If
	End Sub
    Private Sub profesional_CheckedChanged(sender As Object, e As EventArgs) 
        titulo.Visible = esProfesional.Checked
        et_matr.Visible = esProfesional.Checked
        matr.Visible = esProfesional.Checked
    End Sub
    Private Sub proveedor_CheckedChanged(sender As Object, e As EventArgs) 
        et_resp.Visible = esProveedor.Checked
        responsable.Visible = esProveedor.Checked
    End Sub

    '###### MODIFICAR ##########################################################################################
    Private Sub AddDomicilio_Click(sender As Object, e As EventArgs) 
        Dim TabDom As New Domicilio.Tab(TabControl1.TabCount + 1, 0)
        TabControl1.TabPages.Add(TabDom)
        TabDom.provincia.DataSource = Domicilio.sql.RellenarProvincias()
        TabDom.provincia.ValueMember = "provincia_id"
        TabDom.provincia.DisplayMember = "provincia"
        TabDom.provincia.Text = "CORDOBA"

        TabDom.localidad.Text = "VILLA DE LAS ROSAS"

        TabControl1.SelectTab(TabControl1.TabCount - 1)
    End Sub
    Private Sub DelDomicilio_Click(sender As Object, e As EventArgs) 
        If MsgBoxResult.Yes = MsgBox("Desea eliminar este domicilio?", MsgBoxStyle.YesNo, "Eliminar Domicilio") Then
            TabControl1.TabPages.RemoveAt(TabControl1.SelectedIndex)
        End If
    End Sub

    Private Sub ModActas_Click(sender As Object, e As EventArgs) 
        If persona_id.Text > 0 Then
            Dim visor_acta As New ModActa(persona_id.Text)
            visor_acta.ShowDialog(Me)
            visor_acta.Dispose()
        Else
            MsgBox("Debe guardar el registro de la persona antes de continuar.")
        End If
    End Sub

    Private Sub GuardarCambios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarCambios.Click
        'Según si se modifica un CUIL de persona o un profesional, hay que actualizar campos de distintas tablas
        'No correr el update de cuil al pedo si no cambió nada (comparar nuevo y viejo)
        'No actualizar cuil si no tiene 11 de largo, dejar valor anterior.
        Dim dtab_con As New DataTable
        Dim valido As Boolean = True
        Dim msg As String = ""
		validar(persona_id.Text, 0)
	End Sub
	Sub validar(persona_id As Integer, cuil As Double)
		Dim dtab_con As New DataTable
		Dim valido As Boolean = True
		Dim msg As String = ""
		'Normalizar cuil 
		If Val(cuil) < 20000000000 Then
			msg = "Revise el Nº de CUIL antes de continuar." & Chr(13)
			valido = False
		Else
			dtab_con = bd.read(My.Settings.DefaultCon, "SELECT id, cuil FROM persona WHERE cuil=" & cuil)
			If dtab_con.Rows.Count > 1 Then
				For fila As Integer = 0 To dtab_con.Rows.Count - 1
					If dtab_con(fila)("id") <> persona_id Then
						MsgBox("N° de CUIL duplicado.")
						valido = False
					End If
				Next
			End If
		End If

        'Normalizar Profesional
        If matr.Text = "" And esProfesional.Checked Then
			msg += "No se ingresó N° de Matrícula profesional."
			valido = False
		End If

        'Normalizar difunto
        If ruta_defuncion.Text = "" And esDifunto.Checked Then
			msg += "No se ingresó copia del Acta de Defunción."
			valido = False
		ElseIf esDifunto.Checked = False Then
			ruta_defuncion.Clear()
		End If

        'Normalizar proveedor
        If responsable.SelectedIndex = -1 And esProveedor.Checked Then
			msg += "Debe seleccionar responsabilidad de proveedor ante AFIP."
			valido = False
		End If

        'Guardar
        If valido Then
			Dim answer As MsgBoxResult = MsgBox("¿Desea guardar los cambios?", MsgBoxStyle.YesNoCancel, "Guardar cambios")
			If answer = MsgBoxResult.Yes Or answer = MsgBoxResult.No Then
				If answer = MsgBoxResult.Yes Then
					guardar(Val(persona_id), 0, "")
				End If
				Me.Close()
			End If
		Else
			MsgBox(msg, MsgBoxStyle.Exclamation, "Errores")
		End If
	End Sub

	Sub guardar(persona_id As Integer, cuil As Double, razon As String)
		Dim dtab As DataTable
		Dim fisica As New Boolean

		If Microsoft.VisualBasic.Left(cuil, 2) > 29 Then
			fisica = False
		Else
			fisica = True
		End If
        'CREAR/EDITAR PERSONA
        If persona_id > 0 Then
			bd.edit(My.Settings.DefaultCon, Modificar(persona_id, razon, CDbl(cuil), fisica,
									  email.Text, tele.Text, esDifunto.Checked, ruta_defuncion.Text))
		Else
			bd.edit(My.Settings.DefaultCon, Nueva(razon, CDbl(cuil), fisica,
							  email.Text, tele.Text, esDifunto.Checked, ruta_defuncion.Text))

			dtab = bd.read(My.Settings.DefaultCon, "SELECT MAX(id) as persona_id FROM persona WHERE razon='" & razon & "'")
			persona_id = dtab(0)("persona_id")
		End If
        'CREAR DOMICILIO/S
        bd.edit(My.Settings.DefaultCon, Domicilio.sql.Eliminar(persona_id))
		For Each tab As Domicilio.Tab In TabControl1.TabPages
			With tab
				bd.edit(My.Settings.DefaultCon, Domicilio.sql.Nuevo(persona_id, .calle.Text, .altura.Value,
						  .piso.Value, .dpto.Text, .localidad.SelectedValue, TabControl1.SelectedTab Is tab))
			End With
		Next
        'CREAR PROF
        If esProfesional.Checked Then
			prof_id.Text = Profesional.guardar(prof_id.Text, persona_id, titulo.SelectedValue, matr.Text)
		Else
			prof_id.Text = Profesional.eliminar(persona_id)
		End If
        'CREAR PROV
        If esProveedor.Checked Then
			proveedor_id.Text = Proveedor.guardar(persona_id, proveedor_id.Text, responsable.Text)
		Else
			proveedor_id.Text = Proveedor.eliminar(persona_id)
		End If
	End Sub


End Class