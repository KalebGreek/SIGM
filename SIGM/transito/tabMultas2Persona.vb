﻿Public Class tabMultas2Persona
	Inherits System.Windows.Forms.UserControl
	Public Sub New()
		' This call is required by the designer.
		InitializeComponent()

		' Add any initialization after the InitializeComponent() call.
	End Sub
	Public Sub InitMe()
		propietario_id.Text = 0
		propietario_razon.Text = ""
		propietario_cuil.Text = ""

		conductor_id.Text = 0
		conductor_razon.Text = ""
		conductor_cuil.Text = ""
	End Sub

	Public Function LoadMe(drow As DataRow) As Boolean
		CtrlMan.LoadControls(drow, Me)
		Return True
	End Function

	Private Sub seleccionar_persona_Click(sender As Object, e As EventArgs) Handles cargar_prop.Click, cargar_cond.Click
		Dim bs As BindingSource = Persona.Seleccionar(Me.ParentForm)
		If sender Is cargar_prop Then
			propietario_id.Text = bs.Current("persona_id")
			propietario_razon.Text = bs.Current("razon")
			propietario_cuil.Text = bs.Current("cuil")
		ElseIf sender Is cargar_cond Then
			conductor_id.Text = bs.Current("persona_id")
			conductor_razon.Text = bs.Current("razon")
			conductor_cuil.Text = bs.Current("cuil")
		End If
	End Sub


End Class
