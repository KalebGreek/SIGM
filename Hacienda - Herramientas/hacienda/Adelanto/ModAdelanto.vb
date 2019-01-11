Public Class ModAdelanto

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

	Public Sub save()
		For Each c As Control In wrapper.Controls
			If TypeOf c Is adelanto_page1 Then
				CType(c, adelanto_page1).save()
			End If
		Next
	End Sub

	'###### GUI ##########################################################################################
	Private Sub newAd_Click(sender As Object, e As EventArgs) Handles newAd.Click
		save()
		For Each c As Control In wrapper.Controls
			wrapper.Controls.Remove(c)
		Next
		wrapper.Controls.Add(New adelanto_page1)
	End Sub

	Private Sub print_Click(sender As Object, e As EventArgs) Handles print.Click
		'Reporte diseñado en A5
	End Sub

	Private Sub saveAd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles saveAd.Click
		save()
	End Sub

End Class