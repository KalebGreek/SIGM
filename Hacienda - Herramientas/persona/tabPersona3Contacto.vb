﻿Public Class tabPersona3Contacto
	Inherits System.Windows.Forms.UserControl
	Public Sub New()
		' This call is required by the designer.
		InitializeComponent()

		' Add any initialization after the InitializeComponent() call.
	End Sub

    Public Sub cargar(persona_id As Integer)

        Dim registro As New DataTable
        Dim sql(0) As String
        sql(0) = "SELECT * FROM persona WHERE id=" & persona_id
        registro = DbMan.ReadDB(Nothing, My.Settings.CurrentDB, sql)

        tele.Text = registro(0)("telefono").ToString
        email.Text = registro(0)("email").ToString
    End Sub

    Public Sub guardar(persona_id As Integer)
		If CtrlMan.Validate(Me, ErrorInfo) Then
			DbMan.editDB(Nothing, My.Settings.CurrentDB,
						"UPDATE persona SET telefono=" & tele.Text & ", email='" & email.Text & "'
						  WHERE id=" & persona_id)
		End If
	End Sub
End Class
