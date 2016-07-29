Imports Sigm.Persona.sql
Public Class ModPersona
    Public Sub New(Optional id As Integer = 0)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        titulo.DataSource = Profesional.ListarTitulos()
        titulo.DisplayMember = "titulo"
        titulo.ValueMember = "id"
        persona_id.Text = id
        If id > 0 Then
            Me.Text = "MODIFICAR PERSONA"
            cargar(Persona.sql.Cargar(persona_id.Text))
        End If
    End Sub
    '###### GUI ##########################################################################################
    Private Sub SwitchGrupos(sender As Object, e As EventArgs) _
        Handles SwitchDO.Click, SwitchDP.Click, SwitchDA.Click, SwitchMC.Click, SwitchAC.Click
        If sender Is SwitchDP Then
            With GrupoDP
                .Visible = .Visible.CompareTo(True)
                If .Visible Then
                    sender.Text = "[-] DATOS PERSONALES"
                Else
                    sender.Text = "[+] DATOS PERSONALES"
                End If
            End With
        ElseIf sender Is SwitchDO Then
            With GrupoDO
                .Visible = .Visible.CompareTo(True)
                If .Visible Then
                    sender.Text = "[-] DOMICILIO"
                Else
                    sender.Text = "[+] DOMICILIO"
                End If
            End With
        ElseIf sender Is SwitchMC Then
            With GrupoMC
                .Visible = .Visible.CompareTo(True)
                If .Visible Then
                    sender.Text = "[-] MEDIOS DE CONTACTO"
                Else
                    sender.Text = "[+] MEDIOS DE CONTACTO"
                End If
            End With
        ElseIf sender Is SwitchDA Then
            With GrupoDA
                .Visible = .Visible.CompareTo(True)
                If .Visible Then
                    sender.Text = "[-] DATOS ADICIONALES"
                Else
                    sender.Text = "[+] DATOS ADICIONALES"
                End If
            End With
        ElseIf sender Is SwitchAC Then
            With GrupoAC
                .Visible = .Visible.CompareTo(True)
                If .Visible Then
                    sender.Text = "[-] ACTAS"
                Else
                    sender.Text = "[+] ACTAS"
                End If
            End With
        End If



    End Sub
    Private Sub cancel_Click(sender As Object, e As EventArgs) Handles Cancelar.Click
        Me.Close()
    End Sub

    '###### CARGAR ##########################################################################################
    Sub cargar(registro As DataTable)
        Dim fisica As Boolean = registro(0)("fisica")
        Dim genero As Integer = 0
        razon.Text = registro(0)("razon").ToString

        If Len(registro(0)("cuil").ToString) = 11 Then
            cuil.Text = registro(0)("cuil").ToString
            dni.Text = Microsoft.VisualBasic.Mid(registro(0)("cuil").ToString, 3, 8)
            genero = Val(Microsoft.VisualBasic.Left(cuil.Text, 2))
        Else
            dni.Text = registro(0)("cuil").ToString
            cuil.Text = ""
            cuil_switch.Text = "Mostrar DNI"
            cuil_switch.PerformClick()
        End If
        If genero > 27 Then
            gen.Text = "N"
        ElseIf genero > 23 Then
            gen.Text = "F"
        ElseIf genero > 0 Then
            gen.Text = "M"
        End If

        tele.Text = registro(0)("telefono").ToString
        email.Text = registro(0)("email").ToString

        If registro(0)("difunto") Is DBNull.Value Then
            esDifunto.Checked = False
        Else
            esDifunto.Checked = registro(0)("difunto")
            If esDifunto.Checked Then
                If registro(0)("ruta_defuncion") Is DBNull.Value = False Then
                    ruta_defuncion.Text = registro(0)("ruta_defuncion")
                End If
            End If
        End If

        'Cargar domicilios
        registro = Domicilio.sql.Listar(persona_id.Text)
        If registro.Rows.Count > 0 Then
            Dim principal As Integer
            For fila As Integer = 0 To registro.Rows.Count - 1
                Dim TabDom As New Domicilio.Tab _
                             (fila + 1, registro(fila)("id").ToString, registro(fila)("calle").ToString,
                              Val(registro(fila)("altura").ToString),
                              Val(registro(fila)("piso").ToString), registro(fila)("dpto").ToString)
                TabControl1.TabPages.Add(TabDom)
                If registro(fila)("principal") Then
                    principal = fila
                End If

                TabDom.provincia.DataSource = Domicilio.sql.RellenarProvincias()
                TabDom.provincia.ValueMember = "provincia_id"
                TabDom.provincia.DisplayMember = "provincia"
                TabDom.provincia.Text = registro(fila)("provincia").ToString

                TabDom.localidad.SelectedValue = Val(registro(fila)("localidad_id").ToString)

            Next
            TabControl1.SelectTab(principal)
        Else
            Dim TabDom As New Domicilio.Tab(TabControl1.TabCount + 1, 0)
            TabControl1.TabPages.Add(TabDom)
        End If

        registro = Profesional.BuscarPorPersona(persona_id.Text)
        If registro.Rows.Count > 0 Then
            If registro(0)("matricula") Is DBNull.Value Then
                esProfesional.Checked = False
            Else
                esProfesional.Checked = True
                prof_id.Text = registro(0)("prof_id")
                titulo.Text = registro(0)("titulo")
                matr.Text = registro(0)("matricula")
            End If
        End If

        registro = Proveedor.BuscarPorPersona(persona_id.Text, fisica)
        If registro.Rows.Count > 0 Then
            If registro(0)("responsable_iva") Is DBNull.Value Then
                esProveedor.Checked = False
            Else
                esProveedor.Checked = True
                responsable.Text = registro(0)("responsable_iva")
            End If
        End If
    End Sub

    Private Sub cuil_switch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cuil_switch.Click
        If cuil_switch.Text.Contains("CUIL") Then
            cuil.BringToFront()
            cuil_switch.Text = "Ver DNI"
        Else
            dni.BringToFront()
            cuil_switch.Text = "Ver CUIL"
        End If
    End Sub
    Private Sub cuil_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cuil.TextChanged
        If Len(cuil.Text) = 11 Then
            dni.Text = Microsoft.VisualBasic.Mid(cuil.Text, 3, 8)
        Else
            cuil_switch.Text = "Mostrar DNI"
            cuil_switch.PerformClick()
        End If
    End Sub
    Private Sub dni_a_cuil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dni_a_cuil.Click
        With dni
            If .Visible = True And Len(.Text) >= 7 And Len(.Text) <= 8 And gen.SelectedIndex > -1 Then
                cuil.Text = Persona.calcular_cuil(dni.Text, gen.Text)
                cuil_switch.Text = "Mostrar CUIL"
                cuil_switch.PerformClick()
            End If
        End With
    End Sub

    Private Sub difunto_CheckedChanged(sender As Object, e As EventArgs) Handles esDifunto.Click
        et_defu.Visible = esDifunto.Checked
        ruta_defuncion.Visible = esDifunto.Checked
        cargar_defu.Visible = esDifunto.Checked
    End Sub
    Private Sub ruta_defuncion_Click(sender As Object, e As EventArgs) Handles ruta_defuncion.Click
        If Len(ruta_defuncion.Text) > 0 Then
            Process.Start(root & My.Settings.DocFolderPersona & ruta_defuncion.Text)
        End If
    End Sub
    Private Sub cargar_defu_Click(sender As Object, e As EventArgs) Handles cargar_defu.Click
        If Len(cuil.Text) = 11 And Len(razon.Text) > 8 Then
            ruta_defuncion.Text = Documento.Persona.CertificadoDefuncion(cuil.Text)
        End If
    End Sub
    Private Sub profesional_CheckedChanged(sender As Object, e As EventArgs) Handles esProfesional.CheckedChanged
        titulo.Visible = esProfesional.Checked
        et_matr.Visible = esProfesional.Checked
        matr.Visible = esProfesional.Checked
    End Sub
    Private Sub proveedor_CheckedChanged(sender As Object, e As EventArgs) Handles esProveedor.CheckedChanged
        et_resp.Visible = esProveedor.Checked
        responsable.Visible = esProveedor.Checked
    End Sub

    '###### MODIFICAR ##########################################################################################
    Private Sub AddDomicilio_Click(sender As Object, e As EventArgs) Handles AddDomicilio.Click
        Dim TabDom As New Domicilio.Tab(TabControl1.TabCount + 1, 0)
        TabControl1.TabPages.Add(TabDom)
        TabDom.provincia.DataSource = Domicilio.sql.RellenarProvincias()
        TabDom.provincia.ValueMember = "provincia_id"
        TabDom.provincia.DisplayMember = "provincia"
        TabDom.provincia.Text = "CORDOBA"

        TabDom.localidad.Text = "VILLA DE LAS ROSAS"

        TabControl1.SelectTab(TabControl1.TabCount - 1)
    End Sub
    Private Sub DelDomicilio_Click(sender As Object, e As EventArgs) Handles DelDomicilio.Click
        If MsgBoxResult.Yes = MsgBox("Desea eliminar este domicilio?", MsgBoxStyle.YesNo, "Eliminar Domicilio") Then
            TabControl1.TabPages.RemoveAt(TabControl1.SelectedIndex)
        End If
    End Sub

    Private Sub ModActas_Click(sender As Object, e As EventArgs) Handles ModActas.Click
        If persona_id.Text > 0 Then
            Dim visor_acta As New ModActa(persona_id.Text)
            visor_acta.ShowDialog(Me)
            visor_acta.Dispose()
        Else
            MsgBox("Debe guardar el registro de la persona antes de continuar.")
        End If
    End Sub

    Private Sub GuardarCambios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarCambios.Click
        'Según si se modifica un CUIL de persona o un profesional, hay que actualizar campos de distintas tablas
        'No correr el update de cuil al pedo si no cambió nada (comparar nuevo y viejo)
        'No actualizar cuil si no tiene 11 de largo, dejar valor anterior.
        Dim dtab_con As New DataTable
        Dim valido As Boolean = True
        Dim msg As String = ""

        'Normalizar cuil 
        If Val(cuil.Text) < 20000000000 Then
            msg = "Revise el Nº de CUIL antes de continuar." & Chr(13)
            valido = False
        Else
            dtab_con = bd.read(my.settings.DefaultCon, "SELECT id, cuil FROM persona WHERE cuil=" & cuil.Text)
            If dtab_con.Rows.Count > 1 Then
                For fila As Integer = 0 To dtab_con.Rows.Count - 1
                    If dtab_con(fila)("id") <> persona_id.Text Then
                        MsgBox("N° de CUIL duplicado.")
                        valido = False
                    End If
                Next
            End If
        End If

        'Normalizar Profesional
        If matr.Text = "" And esProfesional.Checked Then
            msg += "No se ingresó N° de Matrícula profesional."
            valido = False
        End If

        'Normalizar difunto
        If ruta_defuncion.Text = "" And esDifunto.Checked Then
            msg += "No se ingresó copia del Acta de Defunción."
            valido = False
        ElseIf esDifunto.Checked = False Then
            ruta_defuncion.Clear()
        End If

        'Normalizar proveedor
        If responsable.SelectedIndex = -1 And esProveedor.Checked Then
            msg += "Debe seleccionar responsabilidad de proveedor ante AFIP."
            valido = False
        End If

        'Guardar
        If valido Then
            Dim answer As MsgBoxResult = MsgBox("¿Desea guardar los cambios?", MsgBoxStyle.YesNoCancel, "Guardar cambios")
            If answer = MsgBoxResult.Yes Or answer = MsgBoxResult.No Then
                If answer = MsgBoxResult.Yes Then
                    guardar(Val(persona_id.Text))
                End If
                Me.Close()
            End If
        Else
            MsgBox(msg, MsgBoxStyle.Exclamation, "Errores")
        End If
    End Sub

    Sub guardar(persona_id As Integer)
        Dim dtab As DataTable
        Dim fisica As New Boolean

        If Microsoft.VisualBasic.Left(cuil.Text, 2) > 29 Then
            fisica = False
        Else
            fisica = True
        End If
        'CREAR/EDITAR PERSONA
        If persona_id > 0 Then
            bd.edit(my.settings.DefaultCon, Modificar(persona_id, razon.Text, CDbl(cuil.Text), fisica,
                                      email.Text, tele.Text, esDifunto.Checked, ruta_defuncion.Text))
        Else
            bd.edit(my.settings.DefaultCon, Nueva(razon.Text, CDbl(cuil.Text), fisica,
                              email.Text, tele.Text, esDifunto.Checked, ruta_defuncion.Text))

            dtab = bd.read(my.settings.DefaultCon, "SELECT MAX(id) as persona_id FROM persona WHERE razon='" & razon.Text & "'")
            persona_id = dtab(0)("persona_id")
        End If
        'CREAR DOMICILIO/S
        bd.edit(my.settings.DefaultCon, Domicilio.sql.Eliminar(persona_id))
        For Each tab As Domicilio.Tab In TabControl1.TabPages
            With tab
                bd.edit(my.settings.DefaultCon, Domicilio.sql.Nuevo(persona_id, .calle.Text, .altura.Value,
                          .piso.Value, .dpto.Text, .localidad.SelectedValue, TabControl1.SelectedTab Is tab))
            End With
        Next
        'CREAR PROF
        If esProfesional.Checked Then
            prof_id.Text = Profesional.guardar(prof_id.Text, persona_id, titulo.SelectedValue, matr.Text)
        Else
            prof_id.Text = Profesional.eliminar(persona_id)
        End If
        'CREAR PROV
        If esProveedor.Checked Then
            proveedor_id.Text = Proveedor.guardar(persona_id, proveedor_id.Text, responsable.Text)
        Else
            proveedor_id.Text = Proveedor.eliminar(persona_id)
        End If
    End Sub


End Class