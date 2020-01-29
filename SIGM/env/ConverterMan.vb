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
        'Example: "20270342435OVIEDO JORGE EDUARDO          MAESTRANZA Y SERVICIO GRALES  8                             000100010001003200030001001800240100010100000000000030 11184,10     0,00     0,00     0,00     0,00     0,00     0,00101     0,00   296,72"
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

    Shared Function ConvertirNum(Numero As Decimal, Optional CentimosEnLetra As Boolean = True) As String

        Dim Moneda As String
        Dim Monedas As String
        Dim Centimo As String
        Dim Centimos As String
        Dim Preposicion As String
        Dim NumCentimos As Double
        Dim Letra As String
        Dim Maximo As Decimal = 1999999999.99

        '************************************************************
        ' Parámetros
        '************************************************************
        Moneda = "Peso"         'Nombre de Moneda (Singular)
        Monedas = "Pesos"       'Nombre de Moneda (Plural)
        Centimo = "Centavo"     'Nombre de Céntimos (Singular)
        Centimos = "Centavos"   'Nombre de Céntimos (Plural)
        Preposicion = "Con"     'Preposición entre Moneda y Céntimos
        '************************************************************

        'Validar que el Numero está dentro de los límites
        If (Numero >= 0) And (Numero <= Maximo) Then


            Letra = NumeroRecursivo((Fix(Numero)))              'Convertir el Numero en letras

            'Si Numero = 1 agregar leyenda Moneda (Singular)
            If (Numero = 1) Then
                Letra = Letra & " " & Moneda
                'De lo contrario agregar leyenda Monedas (Plural)
            Else
                Letra = Letra & " " & Monedas
            End If


            NumCentimos = Math.Round((Numero - Fix(Numero)) * 100)   'Obtener los centimos del Numero

            'Si NumCentimos es mayor a cero inicar la conversión
            If NumCentimos >= 0 Then
                'Si el parámetro CentimosEnLetra es VERDADERO obtener letras para los céntimos
                If CentimosEnLetra Then
                    Letra = Letra & " " & Preposicion & " " & NumeroRecursivo(Fix(NumCentimos)) 'Convertir los céntimos en letra

                    'Si NumCentimos = 1 agregar leyenda Centimos (Singular)
                    If (NumCentimos = 1) Then
                        Letra = Letra & " " & Centimo
                        'De lo contrario agregar leyenda Centimos (Plural)
                    Else
                        Letra = Letra & " " & Centimos
                    End If
                    'De lo contrario mostrar los céntimos como número
                Else
                    If NumCentimos < 10 Then
                        Letra = Letra & " 0" & NumCentimos & "/100"
                    Else
                        Letra = Letra & " " & NumCentimos & "/100"
                    End If
                End If
            End If

        Else
            'Si el Numero no está dentro de los límites, entivar un mensaje de error
            Letra = "ERROR: El número excede los límites."
        End If
        Return Letra
    End Function

    Shared Function NumeroRecursivo(Numero As Long) As String

        Dim Resultado As String = 0

        '**************************************************
        ' Nombre de los números
        '**************************************************
        Dim Unidades() As String
        Unidades = {"", "Un", "Dos", "Tres", "Cuatro", "Cinco", "Seis", "Siete", "Ocho", "Nueve", "Diez",
                    "Once", "Doce", "Trece", "Catorce", "Quince", "Dieciséis", "Diecisiete", "Dieciocho",
                    "Diecinueve", "Veinte", "Veintiuno", "Veintidos", "Veintitres", "Veinticuatro",
                    "Veinticinco", "Veintiseis", "Veintisiete", "Veintiocho", "Veintinueve"}

        Dim Decenas() As String
        Decenas = {"", "Diez", "Veinte", "Treinta", "Cuarenta", "Cincuenta", "Sesenta", "Setenta", "Ochenta", "Noventa", "Cien"}

        Dim centenas() As String
        centenas = {"", "Ciento", "Doscientos", "Trescientos", "Cuatrocientos", "Quinientos", "Seiscientos", "Setecientos", "Ochocientos", "Novecientos"}
        '**************************************************

        Select Case Numero
            Case 0
                'Resultado por defecto
            Case 1 To 29
                Resultado = Unidades(Numero)
            Case 30 To 100
                Resultado = Decenas(Numero \ 10) + IIf(Numero Mod 10 <> 0, " y " + NumeroRecursivo(Numero Mod 10), "")
            Case 101 To 999
                Resultado = Centenas(Numero \ 100) + IIf(Numero Mod 100 <> 0, " " + NumeroRecursivo(Numero Mod 100), "")
            Case 1000 To 1999
                Resultado = "Mil" + IIf(Numero Mod 1000 <> 0, " " + NumeroRecursivo(Numero Mod 1000), "")
            Case 2000 To 999999
                Resultado = NumeroRecursivo(Numero \ 1000) + " Mil" + IIf(Numero Mod 1000 <> 0, " " + NumeroRecursivo(Numero Mod 1000), "")
            Case 1000000 To 1999999
                Resultado = "Un Millón" + IIf(Numero Mod 1000000 <> 0, " " + NumeroRecursivo(Numero Mod 1000000), "")
            Case 2000000 To 1999999999
                Resultado = NumeroRecursivo(Numero \ 1000000) + " Millones" + IIf(Numero Mod 1000000 <> 0, " " + NumeroRecursivo(Numero Mod 1000000), "")
        End Select

        NumeroRecursivo = Resultado

    End Function
End Class


