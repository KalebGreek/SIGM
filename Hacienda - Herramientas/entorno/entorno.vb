Module entorno
    '####### CARPETAS
    Public root As String = Environment.CurrentDirectory

    'Variables de datagridview
    Public del_rows(99) As Integer
    Public ndel As Integer

    'Paleta
    Public ColorPersona, ColorOprivadas, ColorCatastro, ColorHacienda, ColorComercio,
		   ColorFormulario, ColorOpublicas, ColorGobierno, ColorAsocial As System.Drawing.Color

    '###### VENTANAS
    'Impedir creación de ventanas que deben abrirse una sola vez en el formulario MDI
    Function UniqueWindow(instance As Form) As Boolean
        If TypeOf instance Is ContenedorGen Then
            For Each f As Form In instance.MdiChildren
                If TypeOf f Is ModInmueble Then
                    Return True
                End If
                If TypeOf f Is ConsultaCuentaAgrupada Then
                    Return True
                End If
                If TypeOf f Is ModExpediente Then
                    Return True
                End If
                If TypeOf f Is ModOrdenanza Then
                    Return True
                End If
            Next
        End If
        Return False
    End Function

    '###### CONFIGURACION
    Sub ConfigInit(instancia As Form, user_id As Integer)
        If instancia Is ConsultaImpuesto Then  'Cambiar decimales y fechas al formato yanqui para compatibilidad con Fox
            System.Windows.Forms.Application.CurrentCulture = New System.Globalization.CultureInfo("EN-US")
        Else
            System.Windows.Forms.Application.CurrentCulture = New System.Globalization.CultureInfo("ES-AR")
        End If
        'Agregar usuario a contenedor
        If instancia.IsMdiContainer Then
            If TypeOf instancia Is ContenedorGen Then
                CType(instancia, ContenedorGen).user_id.Text = user_id
            End If
        End If
        'Apenas termino de configurar bien postgres esto va a pasar a
        'cargar la conexión de Access y dejar Postgres como estándar

        Dim dtab_con As New DataTable
        '### CONEXION FOX
        dtab_con = bd.read(my.settings.DefaultCon, "SELECT * FROM opciones WHERE opcion='conexion_fox'")

        If dtab_con.Rows.Count > 0 Then
            my.settings.foxcon = dtab_con(0)("valor")
        End If
        '### CONEXION PSQL
        dtab_con = bd.read(my.settings.DefaultCon, "SELECT * FROM opciones WHERE opcion='conexion_sql'")
        If dtab_con.Rows.Count > 0 Then
            my.settings.pgsqlcon = dtab_con(0)("valor")
        End If

    End Sub

    '###### MISC
    Sub ResetControls(ByVal campo As Object)
        For Each c As Control In campo.Controls
            If TypeOf c Is DateTimePicker Then
                CType(c, DateTimePicker).Value = Date.Today
            ElseIf TypeOf c Is TextBox Then
                CType(c, TextBox).Clear()
            ElseIf TypeOf c Is MaskedTextBox Then
                CType(c, MaskedTextBox).Text = Nothing
            ElseIf TypeOf c Is ComboBox Then
                CType(c, ComboBox).SelectedIndex = -1
            ElseIf TypeOf c Is DataGridView Then
                CType(c, DataGridView).DataSource = Nothing
            ElseIf TypeOf c Is NumericUpDown Then
                CType(c, NumericUpDown).Value = CType(c, NumericUpDown).Minimum
            ElseIf TypeOf c Is CheckBox Then
                CType(c, CheckBox).Checked = False
            End If
        Next
    End Sub
    Function DateToFilename(fecha_hora As Date) As String
        Dim texto As String = fecha_hora.Year.ToString
        If fecha_hora.Month < 10 Then
            texto += "0"
        End If
        texto += fecha_hora.Month.ToString

        If fecha_hora.Day < 10 Then
            texto += "0"
        End If
        texto += fecha_hora.Day.ToString

        If fecha_hora.Hour < 10 Then
            texto += "0"
        End If
        texto += fecha_hora.Hour.ToString

        If fecha_hora.Minute < 10 Then
            texto += "0"
        End If
        texto += fecha_hora.Minute.ToString

        If fecha_hora.Second < 10 Then
            texto += "0"
        End If
        texto += fecha_hora.Second.ToString

        Return texto
    End Function


End Module
