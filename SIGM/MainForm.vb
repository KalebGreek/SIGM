Imports System.ComponentModel

Class MainForm
	Public Sub New(menu As UserControl)
		' This call is required by the designer.
		InitializeComponent()
		' Add any initialization after the InitializeComponent() call.
		ConfigInit(Me)

		Me.Controls.Add(menu)
		menu.Height = 25
		menu.Dock = DockStyle.Top
		menu.BackColor = My.Settings.CurrentMenuColor

	End Sub
	Private Sub Me_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
		If e.KeyValue = Keys.F10 Then
			Dim console1 As New SQLConsole With {.MdiParent = Me.Parent}
			console1.Show()
		End If
	End Sub

	Private Sub MainForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
		For Each f As Form In MdiChildren
			f.Dispose()
		Next
		Dim ParentForm As Form = Nothing
		If Me.Owner Is Nothing = False Then
			ParentForm = Me.Owner
		ElseIf Me.Parent Is Nothing = False Then
			ParentForm = Me.Parent
		End If
		If ParentForm Is Nothing = False Then
			ParentForm.Show()
			ParentForm.Focus()
		End If
	End Sub

End Class


