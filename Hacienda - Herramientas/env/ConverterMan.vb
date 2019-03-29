Public Class ConverterMan
	Shared Function SIJCORToDataTable(path As String) As DataTable
		Dim dtab As New DataTable()
		Dim register As String()
		dtab.Columns.AddRange({New DataColumn("cuil"), New DataColumn("razon"), New DataColumn("seccion"), New DataColumn("categoria"),
							   New DataColumn("id"), New DataColumn("bruto"), New DataColumn("valor1"), New DataColumn("valor2"),
							   New DataColumn("valor3"), New DataColumn("valor4"), New DataColumn("valor5"), New DataColumn("valor6"),
							   New DataColumn("valor7"), New DataColumn("familiar")})

		Dim tfp As New FileIO.TextFieldParser(path, System.Text.Encoding.GetEncoding(1252))
		tfp.TextFieldType = FileIO.FieldType.FixedWidth
		tfp.SetFieldWidths(11, 30, 30, 30, 54, 9, 9, 9, 9, 9, 9, 12, 9, 9)

		While Not tfp.EndOfData
			register = tfp.ReadFields()
			dtab.Rows.Add({register(0), register(1), register(2), register(3), register(4), register(5), register(6), register(7),
						   register(8), register(9), register(10), register(11), register(12), register(13)})
		End While
		tfp.Close()
		Return dtab
	End Function
	Shared Function DataTableToSIJCOR(dtab As DataTable, path As String) As String
		'Dim example As String = "20270342435OVIEDO JORGE EDUARDO          MAESTRANZA Y SERVICIO GRALES  8                             000100010001003200030001001800240100010100000000000030 11184,10     0,00     0,00     0,00     0,00     0,00     0,00101     0,00   296,72"
		Dim output(dtab.Rows.Count - 1) As String
		'Replace with new file
		If System.IO.File.Exists(path) Then
			Kill(path)
		End If
		Dim destination As New System.IO.FileStream(path, IO.FileMode.CreateNew)
		Dim swriter As New System.IO.StreamWriter(destination, System.Text.Encoding.GetEncoding(1252))

		For Each dr As DataRow In dtab.Rows
			Dim builder As New System.Text.StringBuilder()
			Dim format As String
			'add all columns, format
			format = "{0,-11}{1,-30}{2,-30}{3,-30}{4,-54}{5,9}{6,9}"
			format &= "{7,9}{8,9}{9,9}{10,9}{11,12}{12,9}{13,9}"

			builder.AppendFormat(format, dr(0).ToString, dr(1).ToString, dr(2).ToString, dr(3).ToString, dr(4).ToString,
										 dr(5).ToString, dr(6).ToString, dr(7).ToString, dr(8).ToString, dr(9).ToString,
										 dr(10).ToString, dr(11).ToString, dr(12).ToString, dr(13).ToString)

			swriter.WriteLine(builder.ToString())
		Next
		swriter.Close()

		Return path
	End Function
	Shared Function NumberToDescString(n As Decimal) As String
		'Spanish
		Dim strout As String = ""
		Dim mill, thou, hundr, dec As Integer
		Dim dict As New BindingSource
		dict.DataSource = DbMan.readDB(Nothing, My.Settings.CurrentDB, "SELECT num, str FROM numtostr_dict")
		n = n.ToString("d2")

		mill = Val(n) \ Math.Pow(10, 6)
		If mill > 0 Then
			strout &= NumToStrDictSearch(dict, mill, True, False, False, False)
			n -= (mill * Math.Pow(10, 6))
		End If

		thou = Val(n) \ Math.Pow(10, 3)
		If thou > 0 Then
			strout &= NumToStrDictSearch(dict, thou, False, True, False, False)
			n -= (thou * Math.Pow(10, 3))
		End If
		hundr = Val(n)
		If hundr > 0 Then
			strout &= NumToStrDictSearch(dict, hundr, False, False, True, False)
			n -= hundr
		End If

		If mill = 0 And thou = 0 And hundr = 0 Then
			strout &= " CERO PESOS CON"
		ElseIf n = 1 Then
			strout &= " UN PESO CON"
		Else
			strout &= " PESOS CON"
		End If

		'CENTAVOS
		dec = Mid(n.ToString, 3, 2)
		strout &= NumToStrDictSearch(dict, dec, False, False, False, True)

		If dec = 1 Then
			strout &= " CENTAVO"
		Else
			strout &= " CENTAVOS"
		End If
		Return strout
	End Function
	Shared Function NumToStrDictSearch(dict As BindingSource, n As Integer, mill_pos As Boolean, thou_pos As Boolean, hundr_pos As Boolean, dec_pos As Boolean) As String
		Dim str As String = ""
		Dim hundreds, tens, singles As Integer
		hundreds = (n \ 100) * 100
		tens = (n \ 10) * 10
		singles = n - (hundreds + tens)

		If hundreds > 0 Then
			dict.Position = dict.Find("num", hundreds)
			str &= dict.Current("str")
			If hundreds = 1 Then
				If tens > 0 Or singles > 0 Then
					str &= "TO " 'CIENTO
				End If
			End If
		End If
		If tens > 0 Then
			dict.Position = dict.Find("num", tens)
			str &= " " & dict.Current("str")
		End If
		If singles > 0 Then
			dict.Position = dict.Find("num", singles)
			If hundreds = 0 And tens = 0 And singles = 1 Then
				If mill_pos Then
					str &= " UN MILLÓN"
				ElseIf thou_pos Then
					str = " MIL"
				ElseIf hundreds Then
					'UNO
				ElseIf dec_pos Then
					str = " UN"
				End If
			Else
				str &= " " & dict.Current("str")
			End If
		Else
			str &= " CERO"
		End If

		Return str
	End Function
End Class

