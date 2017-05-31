Imports Sigm.Persona
Public Class ControlBusquedaExpediente
	Inherits Form

	Public Sub New()
		InitializeComponent()

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

	'###### FIN VARIABLES Y RUTINAS #############################################################################

	'###### GUI #################################################################################################
	Private Sub NuevoExp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

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
		With resul
			If .Position > -1 Then
                'Oprivadas.EliminarExpediente("expediente_id")
            End If
		End With
	End Sub

	Private Sub InitializeComponent()
		Me.SuspendLayout()
		'
		'ControlBusquedaExpediente
		'
		Me.ClientSize = New System.Drawing.Size(655, 426)
		Me.Name = "ControlBusquedaExpediente"
		Me.ResumeLayout(False)

	End Sub
End Class
