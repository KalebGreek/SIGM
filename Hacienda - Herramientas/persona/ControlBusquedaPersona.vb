Public Class ControlBusquedaPersona
	Inherits Form

	Private components As System.ComponentModel.IContainer
	Friend WithEvents PanelFiltros As FlowLayoutPanel
	Friend WithEvents difunto As CheckBox
	Friend WithEvents fisica As CheckBox
	Shared item_busqueda As String = ""

	Public Sub New()
		MyBase.New()
		InitializeComponent()
	End Sub

	Public Overloads Sub InitializeComponent()
		Me.PanelFiltros = New System.Windows.Forms.FlowLayoutPanel()
		Me.difunto = New System.Windows.Forms.CheckBox()
		Me.fisica = New System.Windows.Forms.CheckBox()
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
		Me.Controls.SetChildIndex(Me.PanelFiltros, 0)
		Me.PanelFiltros.ResumeLayout(False)
		Me.PanelFiltros.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	'-- RUTINAS
	Private Sub Consultar()
		CtrlMan.LoadDataGridView(DataGridView1, bs_resultado,
								 Persona.Consultar(Vista.Text, filtro.Text,
													   keyword.Text, difunto.Checked,
													   fisica.Checked))
	End Sub

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
	Private Sub keyword_KeyUp(sender As Object, e As KeyEventArgs) Handles keyword.KeyUp, DataGridView1.KeyUp 'Key shortcuts
		If e.KeyValue = Keys.Enter Then
			Consultar()
		ElseIf e.KeyValue = Keys.F2 Then
			If bs_resultado.Position > -1 Then
				Dim mper As New ModPersona
				mper.cargar(bs_resultado.Current("persona_id"))
				mper.ShowDialog()
				Consultar()
			End If
		End If
	End Sub
End Class
