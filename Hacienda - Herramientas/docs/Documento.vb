Public Class Documento
    Shared titulo As String = ""
    Shared destino As String = ""
    Shared ultima_ubicacion As String = Environment.SpecialFolder.Desktop
    Public Shared folder_hac As String = root & "\HACIENDA\"
    Public Shared folder_cat As String = root & "\CATASTRO\"
    Public Shared folder_com As String = root & "\COMERCIO\"
    Public Shared folder_opr As String = root & "\OPRIVADAS\"
    Public Shared folder_gob As String = root & "\GOBIERNO\"
    Public Shared folder_ord As String = folder_gob & "ORDENANZAS\"
    Public Shared folder_per As String = root & "\PERSONA\"

    Public Class Persona
        Shared Function BuscarHistorial(persona_id As Integer, Optional tipo_archivo As String = "", Optional solo_ruta As Boolean = False)
            sel_sql = "SELECT id,"
            If tipo_archivo = "" Then
                sel_sql += " descripcion,"
            End If

            sel_sql += " fecha, ruta FROM per_documento WHERE persona_id=" & persona_id

            If tipo_archivo <> "" Then
                sel_sql += " AND descripcion='" & tipo_archivo & "'"
            End If

            sel_sql += " ORDER BY fecha ASC"

            If solo_ruta Then
                Dim dtab As DataTable = bd.read(defcon, sel_sql)
                Return dtab(0)("ruta").ToString
            Else
                Return bd.read(defcon, sel_sql)
            End If
        End Function
        Shared Function CopiaCuil(ByVal cuil As Double) As String
            titulo = "Buscar Copia de DNI / CUIL | CUIL N° " & cuil
            destino = "\copia_dni_" & fecha_a_archivo(Date.Now) & ".pdf"
            'Muestra diálogo de búsqueda
            destino = Documento.cargar(folder_per & cuil, destino, titulo)
            Return cuil & destino
        End Function
        Shared Function CopiaActa(ByVal persona_id As Integer, ByVal acta As String, ByVal libro As String) As String
            Dim dtab As DataTable = bd.read(defcon, "SELECT cuil, razon FROM persona WHERE id=" & persona_id)
            If dtab.Rows.Count > 0 Then
                If acta > 0 And libro > 0 Then
                    Dim dtab_acta = bd.read(defcon, "SELECT * FROM actas WHERE acta=" & acta & " AND libro=" & libro)
                    If dtab.Rows.Count > 0 Then
                        If dtab_acta(0)("per_id") <> persona_id Then
                            MsgBox("El acta N." & acta & " del libro N." & libro & " no corresponde a " & dtab(0)("razon"))
                            Return ""
                        End If
                    End If
                    titulo = "Buscar Acta N° " & acta & " del libro N°" & libro & " | CUIL N° " & dtab(0)("cuil")
                    destino = "\acta[" & acta & "]_libro[" & libro & "].pdf"
                    'Muestra diálogo de búsqueda
                    destino = cargar(folder_per & dtab(0)("cuil"), destino, titulo)
                    Return dtab(0)("cuil") & "\ACTAS" & destino
                Else
                    MsgBox("Debe indicar número de acta y libro antes de continuar.")
                    Return ""
                End If
            Else
                MsgBox("No se encuentra la persona indicada.")
                Return ""
            End If
        End Function
        Shared Function CertificadoDefuncion(ByVal cuil As Double) As String
            titulo = "Buscar Certificado de Defuncion | CUIL N° " & cuil
            destino = "\defuncion_" & fecha_a_archivo(Date.Now) & ".pdf"
            'Muestra diálogo de búsqueda
            destino = cargar(folder_per & cuil, destino, titulo)
            Return cuil & destino
        End Function
    End Class
    Public Class Catastro
        Shared Function BuscarHistorial(catastro_id As Integer, Optional tipo_archivo As String = "", Optional solo_ruta As Boolean = False)
            sel_sql = "SELECT id,"
            If tipo_archivo = "" Then
                sel_sql += " descripcion,"
            End If

            sel_sql += " fecha, ruta FROM cat_documento WHERE catastro_id=" & catastro_id

            If tipo_archivo <> "" Then
                sel_sql += " AND descripcion='" & tipo_archivo & "'"
            End If

            sel_sql += " ORDER BY fecha ASC"

            If solo_ruta Then
                Dim dtab As DataTable = bd.read(defcon, sel_sql)
                Return dtab(0)("ruta").ToString
            Else
                Return bd.read(defcon, sel_sql)
            End If
        End Function
        Shared Function CargarCopia(TipoArchivo As String, cat As String)
            If Len(cat) > 0 Then 'Catastro
                If TipoArchivo = "DONACION DE CALLE" Then
                    destino = "\donacion_calle"
                ElseIf TipoArchivo = "DONACION DE ESPACIO MUNICIPAL" Then
                    destino = "\donacion_municipal"
                ElseIf TipoArchivo = "ESCRITURA O POSESION" Then
                    destino = "\escritura"
                ElseIf TipoArchivo = "FACTIBILIDAD DE LUZ" Then
                    destino = "\fact_luz"
                ElseIf TipoArchivo = "FACTIBILIDAD DE AGUA" Then
                    destino = "\fact_agua"
                ElseIf TipoArchivo = "PLANO COLEGIADO" Then
                    destino = "\plano"
                ElseIf TipoArchivo = "PREVIA DE CATASTRO" Then
                    destino = "\previa_catastro"
                ElseIf TipoArchivo = "PREVIA MUNICIPAL" Then
                    destino = "\previa_municipal"
                ElseIf TipoArchivo = "SOLICITUD LINEA MUNICIPAL" Then
                    destino = "\linea_municipal"
                End If

                destino += "_" & fecha_a_archivo(Date.Now) & ".pdf"

                titulo = "Buscar Copia de Escritura | Partida: " & cat

                'Muestra diálogo de búsqueda
                cargar(folder_cat & cat, destino, titulo)

                Return cat & destino
            Else
                Return MsgBox("Nro. de partida invalido")
            End If
        End Function
    End Class
    Public Class OPrivadas
        Shared Function BuscarHistorial(opr_id As Integer, Optional tipo_archivo As String = "", Optional solo_ruta As Boolean = False)
            sel_sql = "SELECT id,"
            If tipo_archivo = "" Then
                sel_sql += " descripcion,"
            End If

            sel_sql += " fecha, ruta FROM opr_documento WHERE opr_id=" & opr_id

            If tipo_archivo <> "" Then
                sel_sql += " And descripcion='" & tipo_archivo & "'"
            End If

            sel_sql += " ORDER BY fecha ASC"

            If solo_ruta Then
                Dim dtab As DataTable = bd.read(defcon, sel_sql)
                Return dtab(0)("ruta").ToString
            Else
                Return bd.read(defcon, sel_sql)
            End If
        End Function
        Shared Function CargarCaratulaExp(exp As String) As String
            destino = "\Caratula_" & fecha_a_archivo(Date.Now) & ".pdf"
            titulo = "Buscar Caratula de Expediente | Expediente N° " & exp

            'Muestra diálogo de búsqueda
            destino = cargar(folder_opr & exp, destino, titulo)
            Return exp & destino
        End Function
        Shared Function CargarFinalObra(exp As String) As String
            destino = "\FinalObra_" & fecha_a_archivo(Date.Now) & ".pdf"
            titulo = "Buscar copia de Final de Obra | Expediente N° " & exp

            'Muestra diálogo de búsqueda
            destino = cargar(folder_opr & exp, destino, titulo)
            Return exp & destino
        End Function
    End Class
    Public Class Gobierno
        Shared Function CopiaOrdenanza(ventana As Form, ByVal codigo As Double) As String
            If codigo > 0 Then
                destino = "\CopiaOrdenanza_" & fecha_a_archivo(Date.Now) & ".pdf"
                titulo = "Buscar Copia de Ordenanza N° " & Microsoft.VisualBasic.Left(codigo, Len(codigo.ToString) - 4) & "/" & Microsoft.VisualBasic.Right(codigo, 4)
                'Muestra diálogo de búsqueda
                destino = cargar(folder_ord & codigo, destino, titulo)
                Return codigo & destino
            End If
            Return "No se encuentra el archivo."
        End Function
    End Class
    Public Class Hacienda
        Shared Function BuscarHistorial(tabla As String, id As Integer, Optional tipo_archivo As String = "", Optional solo_ruta As Boolean = False)
            sel_sql = "SELECT id,"
            If tipo_archivo = "" Then
                sel_sql += " descripcion,"
            End If

            sel_sql += " fecha, ruta FROM hac_documento WHERE =" & id

            If tipo_archivo <> "" Then
                sel_sql += " AND descripcion='" & tipo_archivo & "'"
            End If

            sel_sql += " ORDER BY fecha ASC"

            If solo_ruta Then
                Dim dtab As DataTable = bd.read(defcon, sel_sql)
                Return dtab(0)("ruta").ToString
            Else
                Return bd.read(defcon, sel_sql)
            End If
        End Function
    End Class
    Public Class Comercio
        Shared Function BuscarHistorial(tabla As String, col_id As String, id As Integer, Optional tipo_archivo As String = "", Optional solo_ruta As Boolean = False)
            sel_sql = "SELECT id,"
            If tipo_archivo = "" Then
                sel_sql += " descripcion,"
            End If

            sel_sql += " fecha, ruta FROM " & tabla & " WHERE " & col_id & "=" & id

            If tipo_archivo <> "" Then
                sel_sql += " AND descripcion='" & tipo_archivo & "'"
            End If

            sel_sql += " ORDER BY fecha ASC"

            If solo_ruta Then
                Dim dtab As DataTable = bd.read(defcon, sel_sql)
                Return dtab(0)("ruta").ToString
            Else
                Return bd.read(defcon, sel_sql)
            End If
        End Function
    End Class

    Private Shared Function cargar(carpeta_raiz As String, destino As String, titulo As String, Optional ventana As Form = Nothing) As String
        Dim accion As Integer
        Dim load_dialog As New OpenFileDialog

        With My.Computer.FileSystem
            If .DirectoryExists(carpeta_raiz) = False Then
                System.IO.Directory.CreateDirectory(carpeta_raiz)
            End If
            If .DirectoryExists(ultima_ubicacion) = False Then
                ultima_ubicacion = Environment.SpecialFolder.Desktop
            End If
        End With

        With load_dialog
            .Title = titulo
            .Filter = "Documento PDF|*.pdf"
            .FileName = ""
            .InitialDirectory = ultima_ubicacion
            accion = .ShowDialog(ventana) 'Mostramos diálogo de carga de archivo

            'Si es mayor a 4 caracteres (1.jpg) es váido
            'Bajar todo a LCase para evitar problemas
            'Puede que no sea necesario hacer backups acá con el sistema de versiones
            If accion = 1 Then
                ultima_ubicacion = Microsoft.VisualBasic.Left(.FileName, Len(.FileName) - Len(.SafeFileName))
                .FileName = LCase(load_dialog.FileName)
                If Len(load_dialog.FileName) > 4 Then
                    If My.Computer.FileSystem.FileExists(carpeta_raiz & destino) Then
                        If MsgBoxResult.Yes = MsgBox("¿Este archivo ya existe, desea reemplazarlo?", MsgBoxStyle.YesNo) Then
                            Kill(carpeta_raiz & destino)
                            FileCopy(load_dialog.FileName, carpeta_raiz & destino)
                        End If
                    Else
                        FileCopy(load_dialog.FileName, carpeta_raiz & destino)
                    End If
                Else
                    destino = ""
                End If
            End If
        End With
        Return destino
    End Function
    Shared Sub guardar(registro As BindingSource, descripcion As String, tabla As String, col_id As String, id As Integer) 'Se usa solo al final cuando se guarda el expediente
        With registro
            For fila As Integer = 0 To .Count - 1
                .Position = fila
                mod_sql = "INSERT INTO " & tabla & "(" & col_id & ", fecha, descripcion, ruta)" &
                          " VALUES(" & id & ", #" & .Current("fecha") & "# ,'" & descripcion & "'," &
                          " '" & .Current("ruta") & "')"
                bd.edit(defcon, mod_sql)
            Next
        End With
    End Sub
    Shared Sub limpiar(tabla As String, col_id As String, id As Integer, Optional tipo_archivo As String = "")
        del_sql = "DELETE * FROM " & tabla & " WHERE " & col_id & "=" & id
        If tipo_archivo <> "" Then
            del_sql += " AND descripcion='" & tipo_archivo & "'"
        End If
        bd.edit(defcon, del_sql)
    End Sub
End Class
