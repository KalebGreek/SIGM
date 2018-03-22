Public Class ControlBusqueda
	Inherits System.Windows.Forms.UserControl

	'Custom Events
	Public Event CSearch_Click(vista As String, filtro As String, keyword As String)
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
		RaiseEvent CVista_IndexTextChanged() 'Load items
		vista.Visible = vista.Items.Count > 0
	End Sub

	Private Sub filtro_indextext(sender As Object, e As EventArgs) Handles filtro.SelectedIndexChanged, filtro.TextChanged
		filtro.Visible = filtro.Items.Count > 0
		If filtro.Text.Contains("ALTA") Or filtro.Text.Contains("BAJA") Or filtro.Text.Contains("FECHA") Then
			DateValue.Visible = True
			keyword.Visible = False
		Else
			DateValue.Visible = False
			keyword.Visible = True
		End If
		RaiseEvent CFiltro_IndexTextChanged()
	End Sub

	Private Sub DateValue_ValueChanged(sender As Object, e As EventArgs) Handles DateValue.ValueChanged,
																			DateValue.TextChanged,
																			DateValue.VisibleChanged
		If DateValue.Visible Then
			keyword.Text = DateValue.Text
		Else
			keyword.Text = ""
		End If
	End Sub

	Private Sub keyword_KeyUp(sender As Object, e As KeyEventArgs) Handles keyword.KeyUp, DateValue.KeyUp
		search.PerformClick()
	End Sub

	Private Sub keyword_ClicknFocus(sender As Object, e As EventArgs) Handles keyword.Click, keyword.GotFocus
		If keyword.Visible Then
			keyword.SelectAll()
		End If
	End Sub

	Private Sub search_Click(sender As Object, e As EventArgs) Handles search.Click
		RaiseEvent CSearch_Click(vista.Text, filtro.Text, keyword.Text)
	End Sub

	Private Sub reset_Click(sender As Object, e As EventArgs) Handles reset.Click
		filtro.SelectedIndex = 0
		keyword.Clear()
		DateValue.Value = Today

		RaiseEvent CReset_Click()
		'RaiseEvent CSearch_Click(vista.Text, filtro.Text, keyword.Text)
	End Sub

	'Routines and functions
	Private Sub FullReset() 'Dangerous
		vista.Items.Clear()
		filtro.Items.Clear()
		keyword.Clear()
	End Sub
End Class
