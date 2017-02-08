Public Class BusquedaCombustible
	Public bs_registro As New BindingSource
	Public bs_responsable As New BindingSource
	Private Sub Me_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
		If Me.Visible Then

		End If
	End Sub
    '###### GUI ##########################################################################################
    Private Sub GuardarCambios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
		'Según si se modifica un CUIL de persona o un profesional, hay que actualizar campos de distintas tablas
		'No correr el update de cuil al pedo si no cambió nada (comparar nuevo y viejo)
		'No actualizar cuil si no tiene 11 de largo, dejar valor anterior.
		If ValidarCambios() Then
			Dim answer As MsgBoxResult = MsgBox("¿Desea guardar los cambios?", MsgBoxStyle.YesNoCancel, "Guardar cambios")
			If answer = MsgBoxResult.Yes Or answer = MsgBoxResult.No Then
				If answer = MsgBoxResult.Yes Then
					Guardar()
				End If
				Me.Close()
			End If
		End If
	End Sub
	Private Sub cancelar_Click(sender As Object, e As EventArgs)
		Me.Close()
	End Sub

	'###### CARGAR ##########################################################################################
	Private Sub seleccionar_Click(sender As Object, e As EventArgs)
		Dim buscar1 As New ControlBusquedaPersona()
		buscar1.ShowDialog(Me)
	End Sub
	Private Sub razon_TextChanged(sender As Object, e As EventArgs)

	End Sub


	'###### VALIDAR ##########################################################################################
	Private Function ValidarCambios() As Boolean

		Return True
	End Function

    '###### GUARDAR ##########################################################################################
    Private Sub Guardar()

	End Sub



End Class