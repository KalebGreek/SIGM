Public Class ControlBusquedaPersona
	Inherits ControlBusquedaGen

	Private components As System.ComponentModel.IContainer
	Friend WithEvents PanelFiltros As FlowLayoutPanel
	Friend WithEvents difunto As CheckBox
	Friend WithEvents fisica As CheckBox
	Shared item_busqueda As String = ""

	Public Sub New()
		MyBase.New()
		InitializeComponent()
		'
		'Vista
		'
		If item_busqueda <> "" Then
			Vista.Items.AddRange(New Object() {item_busqueda})
			Vista.Text = item_busqueda
		Else
			Vista.Items.AddRange(New Object() {"PERSONA", "EMPLEADO", "PROFESIONAL", "PROVEEDOR"})
			Vista.Text = "PERSONA"
		End If
		'
		'Color Set
		'
		CtrlMan.SetFormColor(Me, ColorPersona)

	End Sub

	Public Overloads Sub InitializeComponent()
		Me.PanelFiltros = New System.Windows.Forms.FlowLayoutPanel()
		Me.difunto = New System.Windows.Forms.CheckBox()
		Me.fisica = New System.Windows.Forms.CheckBox()
		CType(Me.bs_resultado, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.PanelFiltros.SuspendLayout()
		Me.SuspendLayout()
		'
		'PanelFiltros
		'
		Me.PanelFiltros.Controls.Add(Me.difunto)
		Me.PanelFiltros.Controls.Add(Me.fisica)
		Me.PanelFiltros.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.PanelFiltros.Location = New System.Drawing.Point(0, 311)
		Me.PanelFiltros.Name = "PanelFiltros"
		Me.PanelFiltros.Size = New System.Drawing.Size(570, 26)
		Me.PanelFiltros.TabIndex = 363
		'
		'difunto
		'
		Me.difunto.AutoSize = True
		Me.difunto.Location = New System.Drawing.Point(3, 3)
		Me.difunto.Name = "difunto"
		Me.difunto.Size = New System.Drawing.Size(76, 23)
		Me.difunto.TabIndex = 0
		Me.difunto.Text = "Difunto"
		Me.difunto.UseVisualStyleBackColor = True
		'
		'fisica
		'
		Me.fisica.AutoSize = True
		Me.fisica.Checked = True
		Me.fisica.CheckState = System.Windows.Forms.CheckState.Checked
		Me.fisica.Location = New System.Drawing.Point(85, 3)
		Me.fisica.Name = "fisica"
		Me.fisica.Size = New System.Drawing.Size(66, 23)
		Me.fisica.TabIndex = 1
		Me.fisica.Text = "Fisica"
		Me.fisica.UseVisualStyleBackColor = True
		'
		'ControlBusquedaPersona
		'
		Me.ClientSize = New System.Drawing.Size(570, 337)
		Me.Controls.Add(Me.PanelFiltros)
		Me.Name = "ControlBusquedaPersona"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Controls.SetChildIndex(Me.PanelFiltros, 0)
		CType(Me.bs_resultado, System.ComponentModel.ISupportInitialize).EndInit()
		Me.PanelFiltros.ResumeLayout(False)
		Me.PanelFiltros.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	'-- RUTINAS
	Private Sub Consultar()
		CtrlMan.LoadDataGridView(DataGridView1, bs_resultado,
								 Persona.sql.Consultar(Vista.Text, filtro.Text,
													   keyword.Text, difunto.Checked,
													   fisica.Checked))
	End Sub

	Private Overloads Sub resetForm()
		difunto.Checked = False
		fisica.Checked = True
		keyword.Text = ""
		bs_resultado.DataSource = Nothing
	End Sub

	'Private Sub Nueva_Persona_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoToolStripMenuItem.Click
	'La búsqueda se va a realizar automáticamente, para mostrar personas coincidentes con la razón
	'social o el cuil ingresado
	'Dim agregar_per As New ModPersona
	'With agregar_per
	'.ShowDialog(Me)
	'End With
	'End Sub
	'Private Sub Modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificarToolStripMenuItem.Click
	'With bs_resultado
	'If .Position > -1 Then
	'Dim edit_per As New ModPersona(.Current("persona_id"))
	'With edit_per
	'.ShowDialog(Me)
	'End With
	'Consultar(keyword.Text)
	'End If
	'End With
	'End Sub
	'Private Sub Eliminar_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
	'With bs_resultado
	'If .Position > -1 Then
	'If Persona.sql.Eliminar(.Current("persona_id")) Then
	'.RemoveCurrent()
	'reset.PerformClick()
	'Consultar(keyword.Text)
	'End If
	'End If
	'End With
	'End Sub

	'-- EVENTOS UNICOS

	Private Sub search_Click(sender As Object, e As EventArgs) Handles search.Click
		Consultar()
	End Sub
	Private Overloads Sub reset_Click(sender As Object, e As EventArgs) Handles reset.Click
		resetForm()
		Consultar()
	End Sub
	Private Sub filtrospersona_CheckedChanged(sender As Object, e As EventArgs) Handles fisica.CheckedChanged, difunto.CheckedChanged
		If sender.Enabled Then
			Consultar()
		End If
	End Sub
	Private Sub filtro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles filtro.SelectedIndexChanged
		Consultar()
	End Sub
	Private Sub vista_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Vista.SelectedIndexChanged
		If Vista.SelectedIndex > -1 Then
			filtro.Items.Clear()
			If Vista.Text = "PERSONA" Then
				fisica.Enabled = True
				fisica.Checked = True
				difunto.Enabled = True
				difunto.Checked = False

				filtro.Items.AddRange(New Object() {"RAZON SOCIAL", "CUIL/DNI", "DIRECCION", "LOCALIDAD", "ID"})
				filtro.Text = "RAZON SOCIAL"

			ElseIf Vista.Text = "EMPLEADO" Then
				fisica.Enabled = False
				fisica.Checked = True
				difunto.Enabled = True
				difunto.Checked = False

				filtro.Items.AddRange(New Object() {"RAZON SOCIAL", "CUIL/DNI", "DIRECCION", "LOCALIDAD", "ALTA / BAJA"})
				filtro.Text = "RAZON SOCIAL"

			ElseIf Vista.Text = "PROFESIONAL" Then
				fisica.Enabled = True
				fisica.Checked = True
				difunto.Enabled = True
				difunto.Checked = False

				filtro.Items.AddRange(New Object() {"RAZON SOCIAL", "CUIL/DNI", "DIRECCION", "LOCALIDAD", "TITULO"})
				filtro.Text = "RAZON SOCIAL"

			ElseIf Vista.Text = "PROVEEDOR" Then
				fisica.Enabled = True
				fisica.Checked = False
				difunto.Enabled = False
				difunto.Checked = False

				filtro.Items.AddRange(New Object() {"RAZON SOCIAL", "CUIT", "DIRECCION", "LOCALIDAD", "ACTIVIDAD"})
				filtro.Text = "RAZON SOCIAL"
			End If
			Consultar()
		Else
			resetForm()
		End If
	End Sub
	Private Sub keyword_KeyUp(sender As Object, e As KeyEventArgs) Handles keyword.KeyUp
		If e.KeyValue = Keys.Enter Then
			Consultar()
		End If
	End Sub
End Class
