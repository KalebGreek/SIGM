Public Class ParamReporte

    'Genericos 
    Shared Function Persona(dtab As DataTable, parametros As Generic.List(Of ReportParameter)) As Generic.List(Of ReportParameter)
        With parametros
            .Add(New ReportParameter("persona_id", dtab(0)("persona_id").ToString))
            .Add(New ReportParameter("razon", dtab(0)("razon").ToString))
            .Add(New ReportParameter("cuil", dtab(0)("cuil").ToString))
        End With
        Return parametros
    End Function
    Shared Function Domicilio(dtab As DataTable, parametros As Generic.List(Of ReportParameter)) As Generic.List(Of ReportParameter)
        With parametros
            .Add(New ReportParameter("calle", dtab(0)("calle").ToString))
            .Add(New ReportParameter("altura", dtab(0)("altura").ToString))
            .Add(New ReportParameter("piso", dtab(0)("piso").ToString))
            .Add(New ReportParameter("dpto", dtab(0)("dpto").ToString))
            .Add(New ReportParameter("barrio", dtab(0)("barrio").ToString))
            .Add(New ReportParameter("localidad", dtab(0)("localidad").ToString))
            .Add(New ReportParameter("provincia", dtab(0)("provincia").ToString))
        End With
        Return parametros
    End Function
    Shared Function Contacto(dtab As DataTable, parametros As Generic.List(Of ReportParameter))
        With parametros
            .Add(New ReportParameter("telefono", dtab(0)("telefono").ToString))
            .Add(New ReportParameter("email", dtab(0)("email").ToString))
        End With
        Return parametros
    End Function
    Shared Function Inmueble(dtab As DataTable, parametros As Generic.List(Of ReportParameter))
        With parametros
            .Add(New ReportParameter("Catastro", dtab(0)("catastro").ToString))
            .Add(New ReportParameter("UbicacionInmueble", dtab(0)("ubicacion").ToString))
            .Add(New ReportParameter("BarrioInmueble", dtab(0)("barrio").ToString))
            .Add(New ReportParameter("LocalidadInmueble", dtab(0)("reparto").ToString))
        End With
        Return parametros
    End Function

    'Exclusivos
    'Certificado Libre Deuda sobre tablas FOX
    Public Class LibreDeuda
        Shared Function DetalleVencimiento(parametros As Generic.List(Of ReportParameter), Creado As DateTimePicker,
                             Vence As DateTimePicker, Exento As Boolean, OpcionMes As Boolean, Mes As DateTimePicker,
                             OpcionTrim As Boolean, Trimestre As String)
            Dim Detalle As String = ""

            If Exento = False Then
                If OpcionMes Then
                    If Mes.Value <= Vence.Value Then
                        Detalle = "hasta " & Mes.Text & ", valido hasta el dia " & Vence.Text & "."
                    End If
                ElseIf OpcionTrim Then
                    Detalle = "hasta el " & Trimestre & " de " & Vence.Value.Year &
                                         ", valido hasta el dia " & Vence.Text & "."
                End If
            Else
                Detalle = "del cual se encuentra EXENTO POR MODELO."
            End If

            With parametros
                .Add(New ReportParameter("FechaCertificado", Creado.Value.ToLongDateString))
                .Add(New ReportParameter("DetalleVencimiento", Detalle))
            End With
            Return parametros
        End Function
        Shared Function DetalleAuto(parametros As Generic.List(Of ReportParameter), OpcionBaja As Integer, FechaBaja As DateTimePicker)

            Dim DetalleBaja As String = ""
            Dim DetalleVencimiento As String = ""

            If OpcionBaja > 0 Then
                DetalleBaja = "El automotor segun datos precedentes ha sido dado de baja de este municipio por"
                If OpcionBaja = 1 Then
                    DetalleBaja += " cambio de radicacion a partir del " & FechaBaja.Text & "."
                ElseIf OpcionBaja = 2 Then
                    DetalleBaja += " denuncia por robo a partir del " & FechaBaja.Text & "."
                ElseIf OpcionBaja = 3 Then
                    DetalleBaja += " destruccion del vehiculo a partir del " & FechaBaja.Text & "."
                End If
            End If

            With parametros
                .Add(New ReportParameter("DetalleBaja", DetalleBaja))
            End With
            Return parametros
        End Function
    End Class


    Shared Function Agua(dtab As DataTable, parametros As Generic.List(Of ReportParameter))
        With parametros
            'Persona
            .Add(New ReportParameter("Razon", dtab(0)("razon").ToString))
            .Add(New ReportParameter("Calle", dtab(0)("calle").ToString))
            .Add(New ReportParameter("Barrio", dtab(0)("barrio").ToString))
            .Add(New ReportParameter("Localidad", dtab(0)("localidad").ToString))
            .Add(New ReportParameter("Provincia", dtab(0)("provincia").ToString))
            .Add(New ReportParameter("Postal", dtab(0)("postal").ToString))
            'Servicio
            .Add(New ReportParameter("Cuenta", dtab(0)("codigo").ToString))
            Dim alta As Date = dtab(0)("alta")
            .Add(New ReportParameter("Alta", alta.ToShortDateString))
            .Add(New ReportParameter("Catastro", dtab(0)("catastro").ToString))
            .Add(New ReportParameter("UbicacionInmueble", dtab(0)("ubicacion").ToString))
            .Add(New ReportParameter("LocalidadInmueble", dtab(0)("reparto").ToString))
            .Add(New ReportParameter("LocalidadInmueble", dtab(0)("reparto").ToString))

            Dim TipoServicio As String
            If dtab(0)("potable") = 1 Then
                TipoServicio = "DOMICILIARIO"
            ElseIf dtab(0)("comercial") = 1 Then
                TipoServicio = "COMERCIAL"
            Else
                TipoServicio = "INDUSTRIAL"
            End If
            .Add(New ReportParameter("TipoServicio", TipoServicio))

        End With
        Return parametros
        End Function
    Shared Function Automotor(dtab As DataTable, parametros As Generic.List(Of ReportParameter), SinBaja As Boolean)
        With parametros
            If SinBaja Then
                .Add(New ReportParameter("TITULO", "CERTIFICADO DE LIBRE DEUDA DE IMPUESTO AL AUTOMOTOR"))
            Else
                .Add(New ReportParameter("TITULO", "CERTIFICADO DE BAJA Y LIBRE DEUDA DE IMPUESTO AL AUTOMOTOR"))
            End If
            'Persona
            .Add(New ReportParameter("Razon", dtab(0)("razon").ToString))
            .Add(New ReportParameter("Calle", dtab(0)("calle").ToString))
            .Add(New ReportParameter("Barrio", dtab(0)("barrio").ToString))
            .Add(New ReportParameter("Localidad", dtab(0)("localidad").ToString))
            .Add(New ReportParameter("Provincia", dtab(0)("provincia").ToString))
            .Add(New ReportParameter("Postal", dtab(0)("postal").ToString))
            'Rodado
            .Add(New ReportParameter("Cuenta", dtab(0)("codigo").ToString))
            Dim alta, baja As Date
            alta = dtab(0)("incorpora")
            baja = dtab(0)("baja")
            .Add(New ReportParameter("Alta", alta.ToShortDateString))
            .Add(New ReportParameter("Baja", baja.ToShortDateString))
            .Add(New ReportParameter("Modelo", dtab(0)("modelo").ToString))
            .Add(New ReportParameter("Peso", dtab(0)("peso").ToString))
            .Add(New ReportParameter("Patente", dtab(0)("letrahoy").ToString & " " & dtab(0)("numerohoy").ToString))
            .Add(New ReportParameter("Marca", dtab(0)("marca").ToString))
            .Add(New ReportParameter("Tipo", dtab(0)("describo").ToString))
            .Add(New ReportParameter("Motor", dtab(0)("motor").ToString))
            .Add(New ReportParameter("Chasis", dtab(0)("chassis").ToString))

        End With
        Return parametros
    End Function
    Shared Function Catastro(dtab As DataTable, parametros As Generic.List(Of ReportParameter))
        With parametros
            Dim tipodoc As String
            If dtab(0)("tipodoc") = 1 Then
                tipodoc = "Libreta Enrolamiento"
            ElseIf dtab(0)("tipodoc") = 2 Then
                tipodoc = "Libreta Cívica"
            ElseIf dtab(0)("tipodoc") = 3 Then
                tipodoc = "D.N.I."
            Else
                tipodoc = "Cédula de Identidad"
            End If
            'Persona
            .Add(New ReportParameter("Razon", dtab(0)("razon").ToString))
            .Add(New ReportParameter("Documento", tipodoc & " Nº " & dtab(0)("docume").ToString))
            .Add(New ReportParameter("Calle", dtab(0)("calle").ToString))
            .Add(New ReportParameter("Barrio", dtab(0)("barrio").ToString))
            .Add(New ReportParameter("Localidad", dtab(0)("localidad").ToString))
            .Add(New ReportParameter("Provincia", dtab(0)("provincia").ToString))
            .Add(New ReportParameter("Postal", dtab(0)("postal").ToString))
            'Servicio
            .Add(New ReportParameter("Cuenta", dtab(0)("codigo").ToString))
            Dim alta As Date = dtab(0)("alta")
            .Add(New ReportParameter("Alta", alta.ToShortDateString))
            .Add(New ReportParameter("Catastro", dtab(0)("catastro").ToString))
            .Add(New ReportParameter("UbicacionInmueble", dtab(0)("ubicacion").ToString))
            .Add(New ReportParameter("Frente1", dtab(0)("frente1").ToString))
            .Add(New ReportParameter("Frente2", dtab(0)("frente2").ToString))
            .Add(New ReportParameter("Frente3", dtab(0)("frente3").ToString))
            .Add(New ReportParameter("Frente4", dtab(0)("frente4").ToString))

            Dim jubilado, baldio As String
            If dtab(0)("jubilado") = 1 Then
                jubilado = "SI"
            Else
                jubilado = "NO"
            End If
            If dtab(0)("baldio") = 1 Then
                baldio = "SI"
            Else
                baldio = "NO"
            End If
            .Add(New ReportParameter("Jubilado", jubilado))
            .Add(New ReportParameter("Baldio", baldio))
        End With
        Return parametros
    End Function
    Shared Function Cementerio(dtab As DataTable, parametros As Generic.List(Of ReportParameter))
        With parametros
            'Persona
            .Add(New ReportParameter("Razon", dtab(0)("razon").ToString))
            .Add(New ReportParameter("Calle", dtab(0)("calle").ToString))
            .Add(New ReportParameter("Barrio", dtab(0)("barrio").ToString))
            .Add(New ReportParameter("Localidad", dtab(0)("localidad").ToString))
            .Add(New ReportParameter("Provincia", dtab(0)("provincia").ToString))
            .Add(New ReportParameter("Postal", dtab(0)("postal").ToString))
            'Servicio
            Dim ubicacion As String
            If dtab(0)("ubicacion").ToString = 1 Then
                ubicacion = "Nicho"
            ElseIf dtab(0)("ubicacion").ToString = 2 Then
                ubicacion = "Panteón"
            ElseIf dtab(0)("ubicacion").ToString = 3 Then
                ubicacion = "Baldio"
            Else
                ubicacion = "Alquiler"
            End If

            .Add(New ReportParameter("Cuenta", dtab(0)("codigo").ToString))
            Dim alta As Date = dtab(0)("alta")
            .Add(New ReportParameter("Alta", alta.ToShortDateString))
            .Add(New ReportParameter("Ubicacion", ubicacion))
            .Add(New ReportParameter("Numero", dtab(0)("numero").ToString))
            .Add(New ReportParameter("Fila", dtab(0)("fila").ToString))
            .Add(New ReportParameter("Sector", dtab(0)("sector").ToString))
            .Add(New ReportParameter("Lugares", dtab(0)("lugares").ToString))
            .Add(New ReportParameter("Espacio", dtab(0)("espacio").ToString))
            .Add(New ReportParameter("Difunto1", dtab(0)("difunto1").ToString))
            .Add(New ReportParameter("Difunto2", dtab(0)("difunto2").ToString))
            .Add(New ReportParameter("Difunto3", dtab(0)("difunto3").ToString))
            .Add(New ReportParameter("Difunto4", dtab(0)("difunto4").ToString))
            .Add(New ReportParameter("Difunto5", dtab(0)("difunto5").ToString))
            .Add(New ReportParameter("Difunto6", dtab(0)("difunto6").ToString))
            .Add(New ReportParameter("Difunto7", dtab(0)("difunto7").ToString))
            .Add(New ReportParameter("Difunto8", dtab(0)("difunto8").ToString))
            .Add(New ReportParameter("Difunto9", dtab(0)("difunto9").ToString))
            .Add(New ReportParameter("Difunto10", dtab(0)("difunto10").ToString))

            Dim jubilado As String
            If dtab(0)("jubilado") = 1 Then
                jubilado = "SI"
            Else
                jubilado = "NO"
            End If
            .Add(New ReportParameter("Jubilado", jubilado))

        End With
        Return parametros
    End Function
    Shared Function Comercio(dtab As DataTable, parametros As Generic.List(Of ReportParameter))
        With parametros
            'Persona
            .Add(New ReportParameter("Razon", dtab(0)("razon").ToString))
            .Add(New ReportParameter("Calle", dtab(0)("domicilio").ToString))
            .Add(New ReportParameter("Localidad", dtab(0)("localidad").ToString))
            'Rodado
            .Add(New ReportParameter("Cuenta", dtab(0)("codigo").ToString))
            .Add(New ReportParameter("Actividad", dtab(0)("detalle").ToString))
            .Add(New ReportParameter("Cuit", dtab(0)("cuit").ToString))
            .Add(New ReportParameter("Brutos", dtab(0)("brutos").ToString))
            Dim alta, baja As Date
            alta = dtab(0)("inscripto")
            baja = dtab(0)("baja")
            .Add(New ReportParameter("Alta", alta.ToShortDateString))
            .Add(New ReportParameter("Baja", baja.ToShortDateString))
            .Add(New ReportParameter("Acta", dtab(0)("acta").ToString))
        End With
        Return parametros
    End Function

    'OPR
    Shared Function BaseExpediente(parametros As Generic.List(Of ReportParameter),
                                   expediente As String, fecha As Date, tarea As String)

        expediente = Microsoft.VisualBasic.Left(expediente, 4) & " - " & Microsoft.VisualBasic.Right(expediente, 4)

        With parametros
            .Add(New ReportParameter("Expediente", expediente))
            .Add(New ReportParameter("Inicio", fecha.ToShortDateString))
            .Add(New ReportParameter("Tarea", tarea))
        End With

        Return parametros
    End Function
    Shared Function DetalleExpediente(parametros As Generic.List(Of ReportParameter),
                                      profesional As String, recibido As String,
                                      observacion As String, visado As Boolean,
                                      finalizado As Boolean, final As Date)

        With parametros
            .Add(New ReportParameter("Profesional", profesional))
            .Add(New ReportParameter("Recibido", recibido))
            .Add(New ReportParameter("Observacion", observacion))

            If visado Then
                .Add(New ReportParameter("Visado", "SI"))
            Else
                .Add(New ReportParameter("Visado", "NO"))
            End If

            If finalizado Then
                .Add(New ReportParameter("Final", final.ToShortDateString))
            Else
                .Add(New ReportParameter("Final", "NO DECLARADO"))
            End If


        End With

        Return parametros
    End Function

    'Modulos
    Shared Function ListarResponsables(parametros As Generic.List(Of ReportParameter),
                                       registro As BindingSource)
        Dim responsable As String = ""
        Dim cuil As String = ""
        Dim difunto As String = ""

        For fila As Integer = 0 To registro.Count - 1
            registro.Position = fila

            cuil = Microsoft.VisualBasic.Left(registro.Current("cuil"), 2) &
                   "-" & Mid(registro.Current("cuil"), 3, 8) & "-" &
                   Microsoft.VisualBasic.Right(registro.Current("cuil"), 1)
            If registro.Current("difunto") Then
                difunto = "SI"
            Else
                difunto = "NO"
            End If

            responsable += fila + 1 & ") " & registro.Current("razon") & System.Environment.NewLine &
                           "CUIL: " & cuil & " | Difunto: " & difunto & System.Environment.NewLine

        Next

        With parametros
            .Add(New ReportParameter("Responsable", responsable))
        End With

        Return parametros
    End Function
    Shared Function ListarInmuebles(parametros As Generic.List(Of ReportParameter),
                                    registro As BindingSource)
        Dim inmueble As String = ""
        With registro
            For fila As Integer = 0 To .Count - 1
                .Position = fila
                inmueble += fila + 1 & ") Partida: " &
                           " Z" & .Current("zona") & " C" & .Current("circ") & " S" & .Current("secc") &
                           " M" & .Current("manz") & " P" & .Current("parc") & " L" & .Current("lote") &
                            System.Environment.NewLine &
                           " Ubicacion: " & .Current("calle") & " " & .Current("altura") & ", " & .Current("barrio") &
                            System.Environment.NewLine
            Next
        End With

        With parametros
            .Add(New ReportParameter("Inmueble", inmueble))
        End With

        Return parametros
    End Function
End Class
