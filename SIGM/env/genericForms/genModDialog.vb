Public Class genModDialog

	Public pageCount As Integer = 1
	Public Event Csave()
	Public Event Ccancel()
	Public Event ClastPage()
	Public Event CnextPage()

	Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
		' Add any initialization after the InitializeComponent() call.
	End Sub

    ' GUI 
    Private Sub lastPage_Click(sender As Object, e As EventArgs) Handles lastPage.Click
		RaiseEvent ClastPage()
	End Sub
	Private Sub nextPage_Click(sender As Object, e As EventArgs) Handles nextPage.Click
		RaiseEvent CnextPage()
	End Sub

	Private Sub cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
		RaiseEvent Ccancel()
		Me.Close()
	End Sub

	Private Sub save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles save.Click
		RaiseEvent Csave()
	End Sub

End Class