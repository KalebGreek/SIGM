﻿Public Class tabContacto
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

		Dim registro As DataTable = DbMan.read("SELECT * FROM persona WHERE id=" & persona_id)

		tele.Text = registro(0)("telefono").ToString
		email.Text = registro(0)("email").ToString

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
