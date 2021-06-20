Class FileMan
	' CARPETAS
	'Dim root As String = Environment.CurrentDirectory

	Shared Function DateToFilename(DateTime As Date) As String
		Dim texto As String = DateTime.Year.ToString
		If DateTime.Month < 10 Then
			texto += "0"
		End If
		texto += DateTime.Month.ToString

		If DateTime.Day < 10 Then
			texto += "0"
		End If
		texto += DateTime.Day.ToString

		texto += "_"

		If DateTime.Hour < 10 Then
			texto += "0"
		End If
		texto += DateTime.Hour.ToString

		If DateTime.Minute < 10 Then
			texto += "0"
		End If
		texto += DateTime.Minute.ToString

		If DateTime.Second < 10 Then
			texto += "0"
		End If
		texto += DateTime.Second.ToString

		Return texto
	End Function

End Class
