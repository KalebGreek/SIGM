Public Class tabDatosPersonales
	Inherits System.Windows.Forms.UserControl
	Public Sub New()
		' This call is required by the designer.
		InitializeComponent()

		' Add any initialization after the InitializeComponent() call.
	End Sub

	Private Sub dni_a_cuil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dni_a_cuil.Click
		With dni
			If .Visible = True And Len(.Text) >= 7 And Len(.Text) <= 8 And gen.SelectedIndex > -1 Then
				cuil.Text = Persona.calcular_cuil(dni.Text, gen.Text)
			End If
		End With
	End Sub

	Public Sub cargar(dr As DataRow, Optional sectionColor As System.Drawing.Color = Nothing)
		If sectionColor <> Nothing Then
			CtrlMan.SetFormStyle(Me, sectionColor)
		End If

		Dim genero As Integer = 0

		razon.Text = dr("razon").ToString

		If Len(dr("cuil").ToString) = 11 Then
			cuil.Text = dr("cuil").ToString
			dni.Text = Microsoft.VisualBasic.Mid(dr("cuil").ToString, 3, 8)
			genero = Val(Microsoft.VisualBasic.Left(cuil.Text, 2))
		Else
			dni.Text = dr("cuil").ToString
			cuil.Text = ""
		End If
		If genero > 27 Then
			gen.Text = "No Aplica"
		ElseIf genero > 23 Then
			gen.Text = "Femenino"
		ElseIf genero > 0 Then
			gen.Text = "Masculino"
		End If
	End Sub

	Public Function validar()
		If CtrlMan.Validate(Me) Then
			If razon.Text.Contains(",") = False Then
				Return False
			ElseIf Len(Val(cuil.Text)) <> 11 And Len(Val(dni.Text)) <> 8 Then
				Return False
			Else
				Dim dtab As New DataTable
				dtab = bd.read(My.Settings.foxcon, "SELECT * FROM persona
													WHERE cuil='" & cuil.Text & "'")
			End If
		End If
		Return True
	End Function

	Public Sub guardar()
		If validar() Then
			'If persona_id.Text Then

			'End if
		End If
    End Sub
End Class
