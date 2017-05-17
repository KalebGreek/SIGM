Imports Sigm.Persona
Public Class ControlBusquedaExpediente
	Inherits ControlBusquedaGen

	Public Sub New(ByRef consulta As BindingSource,
				   Optional FiltroOprivadas As String = "EXPEDIENTE", Optional key As String = "BUSCAR..")
		MyBase.New()
		'Me.filtro1.SuspendLayout()
		Me.MenuStrip1.SuspendLayout()
		Me.SuspendLayout()
		'
		'filtro1
		'
		Me.filtro.Items.AddRange(New Object() {"EXPEDIENTE", "RESPONSABLE", "PROFESIONAL", "CUIL"})
		Me.filtro.SelectedIndex = 0
        '
        'keyword
        '
        Me.keyword.Text = key
		'
		'ControlBusquedaPersona
		'
		Me.Controls.Add(Me.MenuStrip1)
		Me.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Font = New System.Drawing.Font("PF DinText Pro", 12.0!)
		Me.Size = New System.Drawing.Size(834, 321)
		Me.TabIndex = 337

		'Me.filtros.ResumeLayout(False)
		'Me.filtros.PerformLayout()
		Me.MenuStrip1.ResumeLayout(False)
		Me.MenuStrip1.PerformLayout()
		Me.ResumeLayout(False)
	End Sub

    '###### VARIABLES Y RUTINAS #################################################################################
    Public Sub ConsultarExpedientes()
		keyword.Text = Trim(keyword.Text)
		With filtro.Text
			If .Contains("EXPEDIENTE") Then
				bs_resultado.DataSource = Oprivadas.Expediente.Buscar(Val(keyword.Text))
			ElseIf .Contains("RESPONSABLE") Then
				bs_resultado.DataSource = Oprivadas.Expediente.Buscar(, keyword.Text)
			ElseIf .Contains("PROFESIONAL") Then
				bs_resultado.DataSource = Oprivadas.Expediente.Buscar(, , keyword.Text)
			ElseIf .Contains("CUIL") Then
				bs_resultado.DataSource = Oprivadas.Expediente.Buscar(, , , Val(keyword.Text))
			Else
				reset.PerformClick()
			End If
		End With
	End Sub
    '###### FIN VARIABLES Y RUTINAS #############################################################################

    '###### GUI #################################################################################################
    Private Sub NuevoExp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
		Dim NuevoExp As New ModExpediente()
		If NuevoExp.dtab_exp Is Nothing Then
			NuevoExp.Dispose()
		Else
			NuevoExp.ShowDialog()
		End If
	End Sub
    '###### END GUI #############################################################################################

    '###### BUSQUEDA ##########################################################################################
    Private Sub Keyword_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles keyword.KeyPress
		If e.KeyChar = Chr(13) Then
			ConsultarExpedientes()
		End If
	End Sub
	Private Sub filtro1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles filtro.SelectedIndexChanged
		If filtro.SelectedIndex > -1 Then
			reset.PerformClick()
			ConsultarExpedientes()
		End If
	End Sub

    '###### CAMBIOS ###############################################################################################
    Private Sub Modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
		With bs_resultado
			If .Position > -1 Then
				Dim NuevoExp As New ModExpediente(.Current("expediente"))
				If NuevoExp.dtab_exp Is Nothing Then
					NuevoExp.Dispose()
				Else
					NuevoExp.ShowDialog()
				End If
				ConsultarExpedientes()
			End If
		End With
	End Sub
	Private Sub Eliminar_Click(sender As Object, e As EventArgs)
		With bs_resultado
			If .Position > -1 Then
                'Oprivadas.EliminarExpediente("expediente_id")
            End If
		End With
	End Sub
End Class
