Public Class ControlBusqueda
	Inherits System.Windows.Forms.UserControl

	'Custom Events
	Public Event CSearch_Click(vista As String, filtro As String, keyword As String, DateValue As String)
	Public Event CReset_Click()
	Public Event CVista_IndexTextChanged()
	Public Event CFiltro_IndexTextChanged()
	Public Event CKeyword_KeyUp(sender As Object, e As KeyEventArgs)

	'Events
	Public Sub New()

		' This call is required by the designer.
		InitializeComponent()

		' Add any initialization after the InitializeComponent() call.
		DateValue.MaxDate = Today
		DateValue.Value = Today
	End Sub

	Private Sub Vista_indextext(sender As Object, e As EventArgs) Handles vista.SelectedIndexChanged, vista.TextChanged
		vista.Visible = vista.Items.Count > 0
		RaiseEvent CVista_IndexTextChanged()
	End Sub

	Private Sub filtro_indextext(sender As Object, e As EventArgs) Handles filtro.SelectedIndexChanged, filtro.TextChanged
		filtro.Visible = filtro.Items.Count > 0
		If filtro.Text.Contains("ALTA") Or filtro.Text.Contains("BAJA") Or filtro.Text.Contains("fecha") Then
			DateValue.Visible = True
			keyword.Visible = False
		Else
			DateValue.Visible = False
			keyword.Visible = True
		End If
		reset.PerformClick()
		RaiseEvent CFiltro_IndexTextChanged()
	End Sub

	Private Sub DateValue_ValueChanged(sender As Object, e As EventArgs) Handles DateValue.ValueChanged, DateValue.TextChanged
		If DateValue.Visible Then
			keyword.Text = DateValue.Text
		End If
	End Sub

	Private Sub keyword_KeyUp(sender As Object, e As KeyEventArgs) Handles keyword.KeyUp, DateValue.KeyUp
		If e.KeyValue = Keys.Enter Then
			search.PerformClick()
		End If
	End Sub
	Private Sub keyword_ClicknFocus(sender As Object, e As EventArgs) Handles keyword.Click, keyword.GotFocus
		If keyword.Visible Then
			keyword.SelectAll()
		End If
	End Sub

	Private Sub search_Click(sender As Object, e As EventArgs) Handles search.Click
		RaiseEvent CSearch_Click(vista.Text, filtro.Text, keyword.Text, DateValue.Text)
	End Sub

	Private Sub reset_Click(sender As Object, e As EventArgs) Handles reset.Click
		filtro.SelectedIndex = 0
		keyword.Clear()
		DateValue.Value = Today
		RaiseEvent CReset_Click()
		RaiseEvent CSearch_Click(vista.Text, filtro.Text, keyword.Text, DateValue.Text)
	End Sub

	'Routines and functions
	Private Sub FullReset() 'Dangerous
		vista.Items.Clear()
		filtro.Items.Clear()
		keyword.Clear()
	End Sub
End Class
