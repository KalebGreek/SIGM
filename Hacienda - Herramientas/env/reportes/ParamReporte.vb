﻿Public Class ParamReporte

    'Genericos 
    Shared Function Persona(dr As DataRow, parametros As Generic.List(Of ReportParameter)) As Generic.List(Of ReportParameter)
		With parametros
			.Add(New ReportParameter("persona_id", dr("persona_id").ToString))
			.Add(New ReportParameter("razon", dr("razon").ToString))
			.Add(New ReportParameter("cuil", dr("cuil").ToString))
		End With
		Return parametros
	End Function
	Shared Function Domicilio(dr As DataRow, parametros As Generic.List(Of ReportParameter)) As Generic.List(Of ReportParameter)
		With parametros
			.Add(New ReportParameter("calle", dr("calle").ToString))
			.Add(New ReportParameter("altura", dr("altura").ToString))
			.Add(New ReportParameter("piso", dr("piso").ToString))
			.Add(New ReportParameter("dpto", dr("dpto").ToString))
			.Add(New ReportParameter("barrio", dr("barrio").ToString))
			.Add(New ReportParameter("localidad", dr("localidad").ToString))
			.Add(New ReportParameter("provincia", dr("provincia").ToString))
		End With
		Return parametros
	End Function
	Shared Function Contacto(dr As DataRow, parametros As Generic.List(Of ReportParameter))
		With parametros
			.Add(New ReportParameter("telefono", dr("telefono").ToString))
			.Add(New ReportParameter("email", dr("email").ToString))
		End With
		Return parametros
	End Function
	Shared Function Inmueble(dr As DataRow, parametros As Generic.List(Of ReportParameter))
		With parametros
			.Add(New ReportParameter("Catastro", dr("catastro").ToString))
			.Add(New ReportParameter("UbicacionInmueble", dr("ubicacion").ToString))
			.Add(New ReportParameter("BarrioInmueble", dr("barrio").ToString))
			.Add(New ReportParameter("LocalidadInmueble", dr("reparto").ToString))
		End With
		Return parametros
	End Function

	'Exclusivos
	Shared Function Agua(dr As DataRow, parametros As Generic.List(Of ReportParameter))
		With parametros
            'Persona
            .Add(New ReportParameter("Razon", dr("razon").ToString))
			.Add(New ReportParameter("Calle", dr("calle").ToString))
			.Add(New ReportParameter("Barrio", dr("barrio").ToString))
			.Add(New ReportParameter("Localidad", dr("localidad").ToString))
			.Add(New ReportParameter("Provincia", dr("provincia").ToString))
			.Add(New ReportParameter("Postal", dr("postal").ToString))
            'Servicio
            .Add(New ReportParameter("Cuenta", dr("codigo").ToString))
			Dim alta As Date = dr("alta")
			.Add(New ReportParameter("Alta", alta.ToShortDateString))
			.Add(New ReportParameter("Catastro", dr("catastro").ToString))
			.Add(New ReportParameter("UbicacionInmueble", dr("ubicacion").ToString))
			.Add(New ReportParameter("LocalidadInmueble", dr("reparto").ToString))
			.Add(New ReportParameter("LocalidadInmueble", dr("reparto").ToString))

			Dim TipoServicio As String
			If dr("potable") = 1 Then
				TipoServicio = "DOMICILIARIO"
			ElseIf dr("comercial") = 1 Then
				TipoServicio = "COMERCIAL"
			Else
				TipoServicio = "INDUSTRIAL"
			End If
			.Add(New ReportParameter("TipoServicio", TipoServicio))

		End With
		Return parametros
	End Function
	Shared Function Automotor(dr As DataRow, parametros As Generic.List(Of ReportParameter), SinBaja As Boolean)
		With parametros
			If SinBaja Then
				.Add(New ReportParameter("TITULO", "CERTIFICADO DE LIBRE DEUDA DE IMPUESTO AL AUTOMOTOR"))
			Else
				.Add(New ReportParameter("TITULO", "CERTIFICADO DE BAJA Y LIBRE DEUDA DE IMPUESTO AL AUTOMOTOR"))
			End If
            'Persona
            .Add(New ReportParameter("Razon", dr("razon").ToString))
			.Add(New ReportParameter("Calle", dr("calle").ToString))
			.Add(New ReportParameter("Barrio", dr("barrio").ToString))
			.Add(New ReportParameter("Localidad", dr("localidad").ToString))
			.Add(New ReportParameter("Provincia", dr("provincia").ToString))
			.Add(New ReportParameter("Postal", dr("postal").ToString))
            'Rodado
            .Add(New ReportParameter("Cuenta", dr("codigo").ToString))
			Dim alta, baja As Date
			alta = dr("incorpora")
			baja = dr("baja")
			.Add(New ReportParameter("Alta", alta.ToShortDateString))
			.Add(New ReportParameter("Baja", baja.ToShortDateString))
			.Add(New ReportParameter("Modelo", dr("modelo").ToString))
			.Add(New ReportParameter("Peso", dr("peso").ToString))
			.Add(New ReportParameter("PatenteMercosur", dr("anterior").ToString))
			.Add(New ReportParameter("PatenteArgentina", dr("letrahoy").ToString & " " & dr("numerohoy").ToString))
			.Add(New ReportParameter("Marca", dr("marca").ToString))
			.Add(New ReportParameter("Tipo", dr("describo").ToString))
			.Add(New ReportParameter("Motor", dr("motor").ToString))
			.Add(New ReportParameter("Chasis", dr("chassis").ToString))

		End With
		Return parametros
	End Function
	Shared Function Catastro(dr As DataRow, parametros As Generic.List(Of ReportParameter))
		With parametros
			'Persona
			.Add(New ReportParameter("Razon", dr("razon").ToString))
			.Add(New ReportParameter("Documento", dr("docume").ToString))
			.Add(New ReportParameter("Calle", dr("calle").ToString))
			.Add(New ReportParameter("Barrio", dr("barrio").ToString))
			.Add(New ReportParameter("Localidad", dr("localidad").ToString))
			.Add(New ReportParameter("Provincia", dr("provincia").ToString))
			.Add(New ReportParameter("Postal", dr("postal").ToString))
            'Servicio
            .Add(New ReportParameter("Cuenta", dr("codigo").ToString))
			Dim alta As Date = dr("alta")
			.Add(New ReportParameter("Alta", alta.ToShortDateString))
			.Add(New ReportParameter("Catastro", dr("catastro").ToString))
			.Add(New ReportParameter("UbicacionInmueble", dr("ubicacion").ToString))
			.Add(New ReportParameter("Frente1", dr("frente1").ToString))
			.Add(New ReportParameter("Frente2", dr("frente2").ToString))
			.Add(New ReportParameter("Frente3", dr("frente3").ToString))
			.Add(New ReportParameter("Frente4", dr("frente4").ToString))

			Dim jubilado, baldio As String
			If dr("jubilado") = 1 Then
				jubilado = "SI"
			Else
				jubilado = "NO"
			End If
			If dr("baldio") = 1 Then
				baldio = "SI"
			Else
				baldio = "NO"
			End If
			.Add(New ReportParameter("Jubilado", jubilado))
			.Add(New ReportParameter("Baldio", baldio))
		End With
		Return parametros
	End Function
	Shared Function Cementerio(dr As DataRow, parametros As Generic.List(Of ReportParameter))
		With parametros
            'Persona
            .Add(New ReportParameter("Razon", dr("razon").ToString))
			.Add(New ReportParameter("Calle", dr("calle").ToString))
			.Add(New ReportParameter("Barrio", dr("barrio").ToString))
			.Add(New ReportParameter("Localidad", dr("localidad").ToString))
			.Add(New ReportParameter("Provincia", dr("provincia").ToString))
			.Add(New ReportParameter("Postal", dr("postal").ToString))
            'Servicio
            Dim ubicacion As String
			If dr("ubicacion").ToString = 1 Then
				ubicacion = "Nicho"
			ElseIf dr("ubicacion").ToString = 2 Then
				ubicacion = "Panteón"
			ElseIf dr("ubicacion").ToString = 3 Then
				ubicacion = "Baldio"
			Else
				ubicacion = "Alquiler"
			End If

			.Add(New ReportParameter("Cuenta", dr("codigo").ToString))
			Dim alta As Date = dr("alta")
			.Add(New ReportParameter("Alta", alta.ToShortDateString))
			.Add(New ReportParameter("Ubicacion", ubicacion))
			.Add(New ReportParameter("Numero", dr("numero").ToString))
			.Add(New ReportParameter("Fila", dr("fila").ToString))
			.Add(New ReportParameter("Sector", dr("sector").ToString))
			.Add(New ReportParameter("Lugares", dr("lugares").ToString))
			.Add(New ReportParameter("Espacio", dr("espacio").ToString))
			.Add(New ReportParameter("Difunto1", dr("difunto1").ToString))
			.Add(New ReportParameter("Difunto2", dr("difunto2").ToString))
			.Add(New ReportParameter("Difunto3", dr("difunto3").ToString))
			.Add(New ReportParameter("Difunto4", dr("difunto4").ToString))
			.Add(New ReportParameter("Difunto5", dr("difunto5").ToString))
			.Add(New ReportParameter("Difunto6", dr("difunto6").ToString))
			.Add(New ReportParameter("Difunto7", dr("difunto7").ToString))
			.Add(New ReportParameter("Difunto8", dr("difunto8").ToString))
			.Add(New ReportParameter("Difunto9", dr("difunto9").ToString))
			.Add(New ReportParameter("Difunto10", dr("difunto10").ToString))

			Dim jubilado As String
			If dr("jubilado") = 1 Then
				jubilado = "SI"
			Else
				jubilado = "NO"
			End If
			.Add(New ReportParameter("Jubilado", jubilado))

		End With
		Return parametros
	End Function
	Shared Function Comercio(dr As DataRow, parametros As Generic.List(Of ReportParameter))
		With parametros
            'Persona
            .Add(New ReportParameter("Razon", dr("razon").ToString))
			.Add(New ReportParameter("Calle", dr("domicilio").ToString))
			.Add(New ReportParameter("Localidad", dr("localidad").ToString))
            'Rodado
            .Add(New ReportParameter("Cuenta", dr("codigo").ToString))
			.Add(New ReportParameter("Actividad", dr("detalle").ToString))
			.Add(New ReportParameter("Cuit", dr("cuit").ToString))
			.Add(New ReportParameter("Brutos", dr("brutos").ToString))
			Dim alta, baja As Date
			alta = dr("inscripto")
			baja = dr("baja")
			.Add(New ReportParameter("Alta", alta.ToShortDateString))
			.Add(New ReportParameter("Baja", baja.ToShortDateString))
			.Add(New ReportParameter("Acta", dr("acta").ToString))
		End With
		Return parametros
	End Function

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