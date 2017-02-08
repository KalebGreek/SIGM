Public Class tabPersonaAdicional
	Inherits System.Windows.Forms.UserControl
	Public Sub New()
		' This call is required by the designer.
		InitializeComponent()

		' Add any initialization after the InitializeComponent() call.
	End Sub

	Public Sub cargar(dr As DataRow, Optional sectionColor As System.Drawing.Color = Nothing)
		If sectionColor <> Nothing Then
			CtrlMan.SetFormColor(Me, sectionColor)
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
End Class
