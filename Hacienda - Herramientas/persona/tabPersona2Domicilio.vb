Public Class tabPersona2Domicilio
	Inherits System.Windows.Forms.UserControl
	Public Sub New()
		' This call is required by the designer.
		InitializeComponent()

		' Add any initialization after the InitializeComponent() call.
	End Sub

	Public Sub cargar(persona_id As Integer)
		'Cargar domicilios
		Dim dtab As DataTable = Domicilio.Listar(persona_id)
		Dim principal As New DomicilioPage(0)
		For Each dr As DataRow In dtab.Rows
			Dim TabDom As New DomicilioPage(TabControl1.TabCount + 1)
			TabDom.cargar(dr)
			TabControl1.TabPages.Add(TabDom)
			If dr("principal") Then
				principal = TabDom
			End If
		Next
		TabControl1.SelectTab(principal)
	End Sub

	Public Sub guardar(persona_id As Integer)
		If CtrlMan.Validate(Me, ErrorInfo) Then
			For Each domicilio As DomicilioPage In TabControl1.TabPages
				domicilio.guardar(persona_id, TabControl1.SelectedTab Is domicilio)
			Next
		End If
	End Sub

	Private Sub AddDomicilio_Click(sender As Object, e As EventArgs) Handles AddDomicilio.Click
		Dim TabDom As New DomicilioPage(TabControl1.TabCount + 1)
		TabControl1.TabPages.Add(TabDom)
	End Sub

	Private Sub DelDomicilio_Click(sender As Object, e As EventArgs) Handles DelDomicilio.Click
		If MsgBoxResult.Yes = MsgBox("Desea eliminar el domicilio seleccionado?", MsgBoxStyle.YesNo) Then
			TabControl1.TabPages.Remove(TabControl1.SelectedTab)
			Dim TabIndex As Integer = 1
			For Each tab As DomicilioPage In TabControl1.TabPages
				tab.GenerateName(TabIndex)
				TabIndex += 1
			Next
		End If
	End Sub
End Class
