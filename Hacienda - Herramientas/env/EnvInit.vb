Module EnvInit
    '####### CARPETAS
    Public root As String = Environment.CurrentDirectory

	'Variables de datagridview
	Public del_rows(99) As Integer
	Public ndel As Integer

    'Paleta
    Public ColorPersona, ColorOprivadas, ColorCatastro, ColorHacienda, ColorComercio,
		   ColorFormulario, ColorOpublicas, ColorGobierno, ColorAsocial As System.Drawing.Color

	Public ext_persona, ext_cuenta, ext_vence, ext_historial, ext_variable,
		   ext_actividad, ext_muerto, ext_tipo, ext_zona,
		   col_tenedor, col_importe, col_pagado, col_periodo, col_vence As String

	Sub tablas_fox(ByVal impuesto As String)
        'Las tablas correspondientes a personas tienen los nombres correctos
        Dim dtab _
		As DataTable = DbMan.read("SELECT * FROM tablas_externas WHERE personas='" & impuesto & "'")

        'Tablas generales
        ext_persona = dtab(0)("personas").ToString
		ext_cuenta = dtab(0)("cuentas").ToString

		If impuesto.Contains("AGUA") Then 'AGUA
            'Tablas puntuales
            ext_historial = dtab(0)("historial").ToString
			ext_variable = dtab(0)("variables").ToString
			ext_vence = dtab(0)("vencimientos").ToString
			ext_zona = dtab(0)("zona").ToString
            'Columnas puntuales
            col_tenedor = ext_persona & ".tenedor"
			col_importe = ext_cuenta & ".original"
			col_pagado = ext_cuenta & ".pagado"
			col_periodo = ext_cuenta & ".periodo"
			col_vence = ext_cuenta & ".vencio"
		ElseIf impuesto.Contains("AUTO") Then 'AUTO
            'Tablas puntuales
            ext_tipo = dtab(0)("tipo").ToString
			ext_vence = dtab(0)("vencimientos").ToString
            'Columnas puntuales
            col_tenedor = ext_persona & ".tenedor"
			col_importe = ext_cuenta & ".apagar"
			col_pagado = ext_cuenta & ".apagado"
			col_periodo = ext_cuenta & ".ano"
			col_vence = ext_cuenta & ".vencimi1"
		ElseIf impuesto.Contains("CATA") Then 'CATA
            'Tablas puntuales
            ext_historial = dtab(0)("historial").ToString
			ext_vence = dtab(0)("vencimientos").ToString
			ext_zona = dtab(0)("zona").ToString
            'Columnas puntuales
            col_tenedor = ext_persona & ".tenedor"
			col_importe = ext_cuenta & ".original"
			col_pagado = ext_cuenta & ".pagado"
			col_periodo = ext_cuenta & ".periodo"
			col_vence = ext_cuenta & ".vencio"
		ElseIf impuesto.Contains("COME") Then 'COME
            'Tablas puntuales
            ext_actividad = dtab(0)("actividad").ToString
			ext_historial = dtab(0)("historial").ToString
			ext_variable = dtab(0)("variables").ToString
			ext_vence = dtab(0)("vencimientos").ToString
            'Columnas puntuales
            col_tenedor = ext_persona & ".razon"
			col_importe = ext_cuenta & ".importe"
			col_pagado = ext_cuenta & ".pagado"
			col_periodo = ext_cuenta & ".ano"
			col_vence = ext_cuenta & ".vence1"
		ElseIf impuesto.Contains("SEPE") Then 'SEPE
            'Tablas puntuales
            ext_historial = dtab(0)("historial").ToString
			ext_muerto = dtab(0)("muertos").ToString
			ext_variable = dtab(0)("variables").ToString
            'Columnas puntuales
            col_tenedor = ext_persona & ".tenedor"
			col_importe = ext_cuenta & ".original"
			col_pagado = ext_cuenta & ".pagado"
			col_periodo = ext_cuenta & ".periodo"
			col_vence = ext_cuenta & ".vencio"
		End If
	End Sub

	'###### CONFIGURACION
	Sub ConfigInit(instancia As Form)
		If instancia Is ConsultaImpuesto Then  'Cambiar decimales y fechas al formato yanqui para compatibilidad con Fox
            System.Windows.Forms.Application.CurrentCulture = New System.Globalization.CultureInfo("EN-US")
		Else
			System.Windows.Forms.Application.CurrentCulture = New System.Globalization.CultureInfo("ES-AR")
		End If
        'Agregar usuario a contenedor
        If instancia.IsMdiContainer Then
			If TypeOf instancia Is MainForm Then
				'CType(instancia, FormContenedorGen).user_id.Text = user_id
			End If
		End If
        'Apenas termino de configurar bien postgres esto va a pasar a
        'cargar la conexión de Access y dejar Postgres como estándar

        Dim dtab_con As New DataTable
        '### CONEXION FOX
        dtab_con = DbMan.read("SELECT * FROM opciones WHERE opcion='conexion_fox'")

		If dtab_con.Rows.Count > 0 Then
			My.Settings.foxcon = dtab_con(0)("valor")
		End If
        '### CONEXION PSQL
        dtab_con = DbMan.read("SELECT * FROM opciones WHERE opcion='conexion_sql'")
		If dtab_con.Rows.Count > 0 Then
			My.Settings.pgsqlcon = dtab_con(0)("valor")
		End If

	End Sub

End Module
