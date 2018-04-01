Public Class ConvMan
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
End Class
