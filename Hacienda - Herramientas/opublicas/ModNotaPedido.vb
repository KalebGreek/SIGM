Public Class ModNotaPedido
	Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
		' Add any initialization after the InitializeComponent() call.
	End Sub
	'###### GUI ##########################################################################################
	Private Sub TabControl1_TabIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
		If Me.Visible Then
			lastPage.Enabled = TabControl1.SelectedIndex > 0
			nextPage.Enabled = TabControl1.SelectedIndex < TabControl1.TabCount - 1
			If TabControl1.SelectedIndex > -1 Then
				Label1.Text = TabControl1.SelectedTab.Text
			End If
		End If
	End Sub
	Private Sub lastPage_Click(sender As Object, e As EventArgs) Handles lastPage.Click
		If TabControl1.SelectedIndex > 0 Then
			TabControl1.SelectedIndex -= 1
		End If
	End Sub
	Private Sub nextPage_Click(sender As Object, e As EventArgs) Handles nextPage.Click
		If TabControl1.SelectedIndex < TabControl1.TabCount - 1 Then
			TabControl1.SelectedIndex += 1
		End If
	End Sub

	Private Sub cancel_Click(sender As Object, e As EventArgs)
		Me.Close()
	End Sub

    '###### CARGAR ##########################################################################################
    Sub cargar(id As Integer)
		If id > 0 Then

		End If
	End Sub

	Private Sub save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles save.Click

	End Sub
End Class