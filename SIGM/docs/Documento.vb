Class Documento
    Shared titulo As String = ""
    Shared destino As String = ""

    Shared ultima_ubicacion As String = Environment.SpecialFolder.Desktop
    'My.Settings.DocFolderHacienda As String = "\HACIENDA\"
    'My.Settings.DocFolderCatastro As String = "\CATASTRO\"
    'folder_com As String = "\COMERCIO\"
    'My.Settings.DocFolderOprivadas As String = "\OPRIVADAS\"
    'folder_gob As String = "\GOBIERNO\"
    'My.Settings.DocFolderOrdenanza As String = "\ORDENANZAS\"
    'My.Settings.DocFolderPersona As String = "\PERSONA\"

    Class Persona
        Shared Function BuscarDoc(PersonaId As Integer, Optional TipoArchivo As String = "", Optional SoloRuta As Boolean = False) As Object
            Dim sqlSelect As String
            sqlSelect = "SELECT id, descripcion, fecha, ruta"
            sqlSelect += " FROM per_documento"
            sqlSelect += " WHERE persona_id=" & PersonaId
            If TipoArchivo <> "" Then
                sqlSelect += " AND descripcion='" & TipoArchivo & "'"
            End If
            sqlSelect += " ORDER BY fecha ASC"

            Return ConsultarHistorial(sqlSelect, SoloRuta)
        End Function
        Shared Function CopiaCuil(ByVal cuil As Double) As String
            titulo = "Buscar Copia de DNI / CUIL | CUIL N° " & cuil
            destino = "\copia_dni_" & FileMan.DateToFilename(Date.Now) & ".pdf"
            'Muestra diálogo de búsqueda
            destino = Documento.Cargar(My.Settings.DocFolderPersona & cuil, destino, titulo, True)
            Return cuil & destino
        End Function
        Shared Function CopiaActa(ByVal persona_id As Integer, ByVal acta As String, ByVal libro As String) As String
            Dim dtab As DataTable = DbMan.ReadDB("SELECT cuil, razon FROM persona WHERE id=" & persona_id,
                                                 My.Settings.CurrentDB)

            If dtab.Rows.Count > 0 Then
                If acta > 0 And libro > 0 Then
                    Dim dtab_acta = DbMan.ReadDB("SELECT * FROM actas WHERE acta=" & acta & " And libro=" & libro, My.Settings.CurrentDB)
                    If dtab_acta.Rows.Count > 0 Then
                        If dtab_acta.Rows(0)("per_id").ToString <> persona_id Then
                            MsgBox("El acta N." & acta & " del libro N." & libro & " no corresponde a " & dtab.Rows(0)("razon").ToString)
                            Return ""
                        End If
                    End If
                    titulo = "Buscar Acta N° " & acta & " del libro N°" & libro & " | CUIL N° " & dtab.Rows(0)("cuil").ToString
                    destino = "\acta[" & acta & "]_libro[" & libro & "].pdf"
                    'Muestra diálogo de búsqueda
                    destino = Cargar(My.Settings.DocFolderPersona & dtab.Rows(0)("cuil").ToString, destino, titulo, True)
                    Return dtab.Rows(0)("cuil").ToString & "\ACTAS" & destino
                Else

                    MsgBox("Debe indicar número de acta y libro antes de continuar.")
                    Return ""
                End If
            Else
                MsgBox("No se encuentra la persona indicada.")
                Return ""
            End If
        End Function
        Shared Function CertificadoDefuncion(ByVal persona_id As Integer) As String
            titulo = "Buscar Certificado de Defuncion"
            destino = "\defuncion_" & FileMan.DateToFilename(Date.Now) & ".pdf"
            'Muestra diálogo de búsqueda
            destino = Cargar(My.Settings.DocFolderPersona & persona_id, destino, titulo, True)
            Return persona_id & destino
        End Function
    End Class
    Class Catastro
        Shared Function BuscarDoc(catastro_id As Integer, Optional tipo_archivo As String = "", Optional solo_ruta As Boolean = False) As Object
            Dim sqlSelect As String
            sqlSelect = "SELECT id, descripcion, fecha, ruta FROM cat_documento WHERE catastro_id=" & catastro_id
            If tipo_archivo <> "" Then
                sqlSelect &= " And descripcion='" & tipo_archivo & "'"
            End If
            sqlSelect &= " ORDER BY fecha ASC"

            Return ConsultarHistorial(sqlSelect, solo_ruta)
        End Function
        Shared Function CargarCopia(TipoArchivo As String, cat As String) As String
            Dim ruta As String = ""
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

                destino += "_" & FileMan.DateToFilename(Date.Now) & ".pdf"

                titulo = "Buscar Copia de Escritura | Partida: " & cat

                'Muestra diálogo de búsqueda
                If Cargar(My.Settings.DocFolderCatastro & cat, destino, titulo, False) Then
                    ruta = cat & destino
                End If
            End If
            Return ruta
        End Function
    End Class
    Class Comercio
        Shared Function BuscarDoc(id As Integer, Optional tipo_archivo As String = "", Optional solo_ruta As Boolean = False) As Object
            Dim sqlSelect As String
            sqlSelect = "SELECT id, descripcion, fecha, ruta"
            sqlSelect += " FROM com_documento"
            sqlSelect += " WHERE com_id=" & id
            If tipo_archivo <> "" Then
                sqlSelect += " AND descripcion='" & tipo_archivo & "'"
            End If
            sqlSelect += " ORDER BY fecha ASC"

            Return ConsultarHistorial(sqlSelect, solo_ruta)
        End Function
    End Class
    Class Gobierno
        Shared Function CopiaOrdenanza(ByVal codigo As Double) As String
            If codigo > 0 Then
                destino = "\CopiaOrdenanza_" & FileMan.DateToFilename(Date.Now) & ".pdf"
                titulo = "Buscar Copia de Ordenanza N° " & Microsoft.VisualBasic.Left(codigo, Len(codigo.ToString) - 4) & "/" & Microsoft.VisualBasic.Right(codigo, 4)
                'Muestra diálogo de búsqueda
                destino = Cargar(My.Settings.DocFolderOrdenanza & codigo, destino, titulo, True)
                Return codigo & destino
            End If
            Return "No se encuentra el archivo."
        End Function
    End Class
    Class Hacienda
        Shared Function BuscarDoc(id As Integer, Optional tipo_archivo As String = "", Optional solo_ruta As Boolean = False) As Object
            Dim sqlSelect As String
            sqlSelect = "SELECT id, descripcion, fecha, ruta"
            sqlSelect += " FROM hac_documento"
            sqlSelect += " WHERE =" & id
            If tipo_archivo <> "" Then
                sqlSelect += " AND descripcion='" & tipo_archivo & "'"
            End If
            sqlSelect += " ORDER BY fecha ASC"

            Return ConsultarHistorial(sqlSelect, solo_ruta)
        End Function
    End Class
    Class OPrivadas
        Shared Function BuscarDoc(opr_id As Integer, Optional tipo_archivo As String = "", Optional solo_ruta As Boolean = False) As Object
            Dim sqlSelect As String
            sqlSelect = "SELECT id, descripcion, fecha, ruta"
            sqlSelect += " FROM opr_documento"
            sqlSelect += " WHERE opr_id=" & opr_id
            If tipo_archivo <> "" Then
                sqlSelect += " AND descripcion='" & tipo_archivo & "'"
            End If
            sqlSelect += " ORDER BY fecha ASC"

            Return ConsultarHistorial(sqlSelect, solo_ruta)
        End Function

        Shared Function CargarFinalObra(opr_id As Integer, exp As String) As String
            'Muestra diálogo de búsqueda
            If Cargar(My.Settings.DocFolderOprivadas & exp, destino, titulo, False) Then
                destino = "\FinalObra_" & FileMan.DateToFilename(Date.Now) & ".pdf"
                titulo = "Buscar copia de Final de Obra | Expediente N° " & exp

                Guardar(Date.Today, "FINAL DE OBRA", destino, "opr_documento", "opr_id", opr_id)
                Return exp & destino
            End If
            Return ""
        End Function
    End Class

    Private Shared Function ConsultarHistorial(sql As String, RutaDoc As Boolean) As Object
        Dim dtab As DataTable = DbMan.ReadDB(sql, My.Settings.CurrentDB)

        If RutaDoc Then
            Return dtab.Rows(0)("ruta").ToString
        Else
            Return dtab
        End If
    End Function
    Private Shared Function Cargar(carpeta_raiz As String, destino As String, titulo As String, return_path As Boolean) As Object
        Dim accion As Integer
        Using load_dialog As New OpenFileDialog

            carpeta_raiz = root & carpeta_raiz

            With My.Computer.FileSystem
                If .DirectoryExists(carpeta_raiz) = False Then
                    System.IO.Directory.CreateDirectory(carpeta_raiz)
                End If
                If .DirectoryExists(ultima_ubicacion) = False Then
                    ultima_ubicacion = Nothing
                End If
            End With

            With load_dialog
                .Title = titulo
                .Filter = "Documento PDF|*.pdf"
                If ultima_ubicacion Is Nothing Then
                    .InitialDirectory = carpeta_raiz
                Else
                    .InitialDirectory = ultima_ubicacion
                End If
                accion = .ShowDialog() 'Mostramos diálogo de carga de archivo

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
                Else
                    destino = ""
                End If
            End With
        End Using

        If return_path Then
            Return destino
        Else
            Return destino <> ""
        End If
    End Function

    Overloads Shared Sub Guardar(fecha As Date, descripcion As String, ruta As String, tabla As String, col_id As String, id As Integer)
        'Guarda una ruta de documento en una tabla
        'Todas las tablas de documentos deben contener las mismas columnas:
        'FOO_ID, FECHA, DESCRIPCION, RUTA

        Dim dtab As DataTable = DbMan.ReadDB("SELECT * FROM " & tabla & " WHERE " & col_id & "=" & id & " And descripcion='" & descripcion & "'",
                                             My.Settings.CurrentDB)
        If dtab.Rows.Count > 0 Then
            Dim sqlUpdate(dtab.Rows.Count) As String
            For Each dr As DataRow In dtab.Rows
                sqlUpdate(dtab.Rows.IndexOf(dr)) = "UPDATE " & tabla & " 
                                                       SET fecha='" & fecha.ToShortDateString & "', ruta='" & ruta & "'
							                         WHERE " & col_id & "=" & id & " AND  descripcion='" & descripcion & "'"

            Next
            DbMan.EditDB(sqlUpdate, My.Settings.CurrentDB)
        Else
            DbMan.EditDB("INSERT INTO " & tabla & "(" & col_id & ", fecha, descripcion, ruta)
							   VALUES(" & id & ", #" & fecha & "# ,'" & descripcion & "', '" & ruta & "')",
                         My.Settings.CurrentDB)
        End If
    End Sub
    Overloads Shared Sub Guardar(lista As DataTable, tabla As String, col_id As String, id As Integer)
        'Guarda una lista de rutas de documento a una tabla
        If lista.Rows.Count > 0 Then
            Dim sqlInsert(lista.Rows.Count) As String
            For Each dr As DataRow In lista.Rows
                sqlInsert(lista.Rows.IndexOf(dr)) = "INSERT INTO " & tabla & "(" & col_id & ", fecha, descripcion, ruta)
                                                          VALUES(" & id & ", #" & dr("fecha").ToString & "# ,'" & dr("descripcion").ToString & "',
                                                                 '" & dr("ruta").ToString & "')"

            Next
            DbMan.EditDB(sqlInsert, My.Settings.CurrentDB)
        End If
    End Sub
    Shared Sub Limpiar(tabla As String, col_id As String, id As Integer, Optional tipo_archivo As String = "")
        Dim sqlDelete As String = "DELETE * FROM " & tabla & " WHERE " & col_id & "=" & id
        If tipo_archivo <> "" Then
            sqlDelete += " AND descripcion='" & tipo_archivo & "'"
        End If
        DbMan.EditDB(sqlDelete, My.Settings.CurrentDB)
    End Sub
End Class

