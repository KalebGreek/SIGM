Imports System.Collections.Generic
Module EnvInit
    ' CARPETAS
    Public root As String = Environment.CurrentDirectory

    'Variables de datagridview
    Public del_rows(99) As Integer
    Public ndel As Integer

    'Paleta
    Public ColorPersona, ColorOprivadas, ColorCatastro, ColorHacienda, ColorComercio,
           ColorFormulario, ColorOpublicas, ColorContratos, ColorAsocial, ColorTransito As System.Drawing.Color

    Public ext_persona, ext_cuenta, ext_vence, ext_historial, ext_variable,
           ext_actividad, ext_muerto, ext_tipo, ext_zona,
           col_tenedor, col_importe, col_pagado, col_periodo, col_vence As String

    Sub Tablas_Fox(ByVal impuesto As String)
        If impuesto.Contains("AGUA") Or impuesto.Contains("aguas") Then 'AGUA
            'Tablas puntuales
            ext_persona = "aguas"
            ext_cuenta = "agucue"
            ext_historial = "aguhis"
            ext_variable = "aguvar"
            ext_vence = "aguvence"
            ext_zona = "aguzona"
            'Columnas puntuales
            col_tenedor = ext_persona & ".tenedor"
            col_importe = ext_cuenta & ".original"
            col_pagado = ext_cuenta & ".pagado"
            col_periodo = ext_cuenta & ".periodo"
            col_vence = ext_cuenta & ".vencio"

        ElseIf impuesto.Contains("BARRIOS") Or impuesto.Contains("barrios") Then
            ext_persona = "barrios"
            ext_cuenta = "barcue"
            ext_historial = "barhis"
            col_tenedor = ext_persona & ".razon"
            col_importe = ext_cuenta & ".importe"
            col_pagado = ext_cuenta & ".pagado"
            col_periodo = ext_cuenta & ".periodo"
            col_vence = ext_cuenta & ".vencio"

        ElseIf impuesto.Contains("AUTO") Or impuesto.Contains("automovil") Then 'AUTO
            'Tablas puntuales
            ext_persona = "automovil"
            ext_cuenta = "autocue"
            ext_tipo = "tipauto"
            ext_vence = "autovence"
            'Columnas puntuales
            col_tenedor = ext_persona & ".tenedor"
            col_importe = ext_cuenta & ".apagar"
            col_pagado = ext_cuenta & ".apagado"
            col_periodo = ext_cuenta & ".ano"
            col_vence = ext_cuenta & ".vencimi1"

        ElseIf impuesto.Contains("CATA") Or impuesto.Contains("catastro") Then 'CATA
            'Tablas puntuales
            ext_persona = "catastro"
            ext_cuenta = "catcue"
            ext_historial = "cathis"
            ext_vence = "catvence"
            ext_zona = "catzona"
            'Columnas puntuales
            col_tenedor = ext_persona & ".tenedor"
            col_importe = ext_cuenta & ".original"
            col_pagado = ext_cuenta & ".pagado"
            col_periodo = ext_cuenta & ".periodo"
            col_vence = ext_cuenta & ".vencio"

        ElseIf impuesto.Contains("COME") Or impuesto.Contains("comercio") Then 'COME
            'Tablas puntuales
            ext_persona = "comercio"
            ext_cuenta = "comcue"
            ext_actividad = "comact"
            ext_historial = "comhis"
            ext_variable = "comvar"
            ext_vence = "comvence"
            'Columnas puntuales
            col_tenedor = ext_persona & ".razon"
            col_importe = ext_cuenta & ".importe"
            col_pagado = ext_cuenta & ".pagado"
            col_periodo = ext_cuenta & ".ano"
            col_vence = ext_cuenta & ".vence1"

        ElseIf impuesto.Contains("SEPE") Or impuesto.Contains("sepelio") Then 'SEPE
            'Tablas puntuales
            ext_persona = "sepelio"
            ext_cuenta = "sepecue"
            ext_historial = "sepehis"
            ext_muerto = "sepemuer"
            ext_variable = "sepevar"
            'Columnas puntuales
            col_tenedor = ext_persona & ".tenedor"
            col_importe = ext_cuenta & ".original"
            col_pagado = ext_cuenta & ".pagado"
            col_periodo = ext_cuenta & ".periodo"
            col_vence = ext_cuenta & ".vencio"
        End If
    End Sub

    ' CONFIGURACION
    Sub ConfigInit(instancia As Form)
        If instancia Is ConsultaImpuestoUI Then  'Cambiar decimales y fechas al formato yanqui para compatibilidad con Fox
            System.Windows.Forms.Application.CurrentCulture = New System.Globalization.CultureInfo("EN-US")
        Else
            System.Windows.Forms.Application.CurrentCulture = New System.Globalization.CultureInfo("ES-AR")
        End If
    End Sub
    Function ListDBConnections() As List(Of String)
        Dim ConnectionList As New List(Of String)
        Dim current_con As String = ""

        'Apenas termino de configurar bien postgres esto va a pasar a
        'cargar la conexión de Access y dejar Postgres como estándar

        For Each sp As Configuration.SettingsProperty In My.Settings.Properties
            If sp.Name.Contains("Connection") Then
                If sp.Name.Contains("Adb") Then
                    'ACCESS
                    'Set up root path
                    sp.DefaultValue = "Provider=Microsoft.ACE.OLEDB.16.0;Data Source=" & root & "\vrosas.accdb;OLE DB Services=-2"
                End If

                current_con = sp.DefaultValue
                If DbMan.ReadTableSchema(current_con) Is Nothing Then
                    current_con = ""
                Else
                    ConnectionList.Add(current_con)
                End If
            End If
        Next

        Return ConnectionList
    End Function


End Module
