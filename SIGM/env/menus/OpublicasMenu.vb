Public Class OpublicasMenu
	Private Sub me_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
		If e.KeyValue = Keys.F10 Then
			Dim console1 As New SQLConsole With {.MdiParent = Me.Parent}
			console1.Show()

		End If
	End Sub
	'OBRAS PUBLICAS

	'> empleados

	Private Sub AsistenciaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AsistenciaToolStripMenuItem.Click

	End Sub
	Private Sub BuscarEmpleadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarEmpleadoToolStripMenuItem.Click
		Dim buscar1 As New BusquedaPersona
		buscar1.genSearchControl1.vista.Text = "EMPLEADO"
		buscar1.Show()

	End Sub

	'>> contratos
	Private Sub ContratoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContratoToolStripMenuItem.Click

	End Sub

	Private Sub BuscarToolStripMenuItem_Click(sender As Object, e As EventArgs)
		'Dim buscar1 As New FormConsultaGen("CONTRATO", Nothing)
		'buscar1.MdiParent = Me
		'buscar1.Show()
	End Sub

	'>Proveedores
	Private Sub BuscarProveedorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarProveedorToolStripMenuItem.Click
		Dim buscar1 As New BusquedaPersona With {.MdiParent = Me.Parent}
		buscar1.genSearchControl1.vista.Text = "PROVEEDOR"
			buscar1.Show()

	End Sub

	'>Nota de pedido
	Private Sub NuevaNotaDePedidoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevaNotaDePedidoToolStripMenuItem.Click
		'Dim AddModNP As New ModNotaPedido

	End Sub
	Private Sub BuscarNotaDePedidoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarNotaDePedidoToolStripMenuItem.Click
		Dim buscarnp As New BusquedaOrdenTrabajo With {.MdiParent = Me.Parent}
		buscarnp.ControlBusqueda1.vista.SelectedIndex = 0
		buscarnp.Show()
	End Sub
End Class