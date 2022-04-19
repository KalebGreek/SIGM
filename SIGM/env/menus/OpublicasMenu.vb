Public Class OpublicasMenu
	Public Sub New()
		' Esta llamada es exigida por el diseñador.
		InitializeComponent()
		' Agregue cualquier inicialización después de la llamada a InitializeComponent().
		CtrlMan.AddMenuEvents(BaseMenu, AddressOf Menu_Events)
	End Sub
	Private Sub Menu_Events(sender As Object, e As EventArgs)
		Dim f1 As Form = Nothing
		'OBRAS PUBLICAS

		'> empleados
		If sender Is AsistenciaToolStripMenuItem Then

		ElseIf sender Is BuscarEmpleadoToolStripMenuItem Then
			f1 = New ConsultaPersona
			CType(f1, ConsultaPersona).genSearchControl1.vista.Text = "EMPLEADO"

			'>> contratos
		ElseIf sender Is ContratoToolStripMenuItem Then
			f1 = New ConsultaContrato
			CType(f1, ConsultaContrato).GenSearchControl1.filtro.Text = "RAZON"

			'>Proveedores
		ElseIf sender Is BuscarProveedorToolStripMenuItem Then
			f1 = New ConsultaPersona
			CType(f1, ConsultaPersona).genSearchControl1.vista.Text = "PROVEEDOR"

			'>Nota de pedido
		ElseIf sender Is NuevaNotaDePedidoToolStripMenuItem Then
			f1 = New ModOrdenTrabajo

		ElseIf sender Is BuscarNotaDePedidoToolStripMenuItem Then
			f1 = New ConsultaOrdenTrabajo
			CType(f1, ConsultaOrdenTrabajo).ControlBusqueda1.vista.SelectedIndex = 0
		End If

		If f1 Is Nothing = False Then
			f1.MdiParent = Me.Parent
			f1.Show()
		End If

	End Sub
End Class