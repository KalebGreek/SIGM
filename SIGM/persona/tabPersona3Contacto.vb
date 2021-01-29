﻿Public Class tabPersona3Contacto
	Inherits System.Windows.Forms.UserControl
	Dim PersonaId As Integer

	Public Sub New(PerId As Integer)
		' This call is required by the designer.
		InitializeComponent()

		' Add any initialization after the InitializeComponent() call.
		PersonaId = PerId
	End Sub

	Public Sub Cargar()
		Dim registro As New DataTable
		Dim sql(0) As String
		sql(0) = "SELECT * FROM persona WHERE id=" & PersonaId
		registro = DbMan.ReadDB(Nothing, My.Settings.CurrentDB, sql)

		tele.Text = registro(0)("telefono").ToString
		email.Text = registro(0)("email").ToString
	End Sub

	Public Function Guardar() As Integer
		If CtrlMan.Validate(Me, ErrorInfo) Then
			DbMan.editDB(Nothing, My.Settings.CurrentDB,
						"UPDATE persona SET telefono=" & tele.Text & ", email='" & email.Text & "'
						  WHERE id=" & PersonaId)
		End If
		Return PersonaId
	End Function


End Class