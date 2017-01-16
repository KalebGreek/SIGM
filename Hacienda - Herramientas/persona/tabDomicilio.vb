Public Class tabDomicilio
	Inherits System.Windows.Forms.UserControl
	Public Sub New()
		' This call is required by the designer.
		InitializeComponent()

		' Add any initialization after the InitializeComponent() call.
	End Sub

	Public Sub cargar(persona_id As Integer, Optional sectionColor As System.Drawing.Color = Nothing)
		If sectionColor <> Nothing Then
			CtrlMan.SetFormStyle(Me, sectionColor)
		End If

		'Cargar domicilios
		Dim registro As DataTable = Domicilio.sql.Listar(persona_id)
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




	End Sub

	Public Function validar()
		If CtrlMan.Validate(Me) Then

		End If
		Return True
	End Function

	Public Sub guardar(persona_id As Integer)
		If validar() Then
			If persona_id Then

			End If
		End If
	End Sub

	Private Sub AddDomicilio_Click(sender As Object, e As EventArgs) Handles AddDomicilio.Click

	End Sub
End Class
