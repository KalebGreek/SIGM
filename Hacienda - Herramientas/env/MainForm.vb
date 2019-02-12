Public Class MainForm
	Public Sub New(menu As UserControl)
        ' This call is required by the designer.
        InitializeComponent()
		' Add any initialization after the InitializeComponent() call.
		ConfigInit(Me)

		Me.Controls.Add(menu)
		menu.Height = 25
		menu.Dock = DockStyle.Top
		menu.BackColor = Color.FromArgb(My.Settings.CurrentMenuColor)

	End Sub


End Class


