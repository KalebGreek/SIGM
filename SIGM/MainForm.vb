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

	Private Sub MainForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
		For Each f As Form In MdiChildren
			f.Dispose()
		Next
	End Sub

End Class


