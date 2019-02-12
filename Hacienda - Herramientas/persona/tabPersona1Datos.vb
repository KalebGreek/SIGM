Public Class tabPersona1Datos
	Inherits System.Windows.Forms.UserControl
	Public Sub New()
		' This call is required by the designer.
		InitializeComponent()

		' Add any initialization after the InitializeComponent() call.
	End Sub

	Public Sub cargar(persona_id As Integer)
		Dim genero As Integer = 0

		Dim dtab As DataTable = DbMan.read(Nothing, My.Settings.DefaultCon, "SELECT id as persona_id, razon, cuil 
									 		  FROM persona WHERE id=" & persona_id)

		razon.Text = dtab(0)("razon").ToString

		If dtab(0)("cuil") > 20000000000 Then
			genero = Val(Microsoft.VisualBasic.Left(dtab(0)("cuil"), 2))
			If genero > 27 Then
				gen.Text = "N/A"
			ElseIf genero > 23 Then
				gen.Text = "Femenino"
			ElseIf genero > 0 Then
				gen.Text = "Masculino"
			End If
			dni.Text = Microsoft.VisualBasic.Mid(dtab(0)("cuil"), 3, 8)
			cuil.Text = dtab(0)("cuil")
		Else
			dni.Text = dtab(0)("cuil").ToString
		End If

	End Sub

	Public Function guardar(persona_id As Integer) As Integer
		If CtrlMan.Validate(Me, ErrorInfo) Then
			Dim fisica As Boolean = gen.Text <> "N/A"
			If persona_id > 0 Then
				DbMan.edit(Nothing, My.Settings.DefaultCon,
							"UPDATE persona SET razon='" & razon.Text & "', cuil=" & cuil.Text & ", 
									fisica=" & fisica & "
							  WHERE id=" & persona_id)
			Else
				DbMan.edit(Nothing, My.Settings.DefaultCon,
					   "INSERT INTO persona(razon, cuil, fisica)
							 VALUES('" & razon.Text & "','" & cuil.Text & "'," & fisica & ")")
				'Next query could be replaced by OUTPUT insert.id
				Dim dtab As DataTable = DbMan.read(Nothing, My.Settings.DefaultCon, "SELECT MAX(id) as id FROM persona") 'Last insert
				MsgBox(dtab(0)("id"))
				persona_id = dtab(0)("id")
			End If
		End If
		Return persona_id
	End Function

	Private Sub gen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles gen.SelectedIndexChanged, gen.TextChanged
		If gen.SelectedIndex > -1 And Me.Visible Then
			If Len(dni.Text) >= 7 And Len(dni.Text) <= 8 Then
				cuil.Text = Persona.CalcularCuil(dni.Text, Microsoft.VisualBasic.Left(gen.Text, 1))
				dni.Enabled = gen.Text.Contains("N/A")
			End If
			If gen.Text = "N/A" Then
				cuil.Text = ""
			End If
		End If
	End Sub

	Private Sub dni_TextChanged(sender As Object, e As EventArgs) Handles dni.TextChanged
		If Len(dni.Text) >= 7 And Len(dni.Text) <= 8 And gen.SelectedIndex > -1 And Me.Visible Then
			cuil.Text = Persona.CalcularCuil(dni.Text, Microsoft.VisualBasic.Left(gen.Text, 1))
		End If
	End Sub


End Class
