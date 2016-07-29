Imports Sigm.Persona.sql
Public Class ControlBusquedaPersona
    Inherits ControlBusquedaGen
    Public WithEvents difunto As CheckBox
    Public WithEvents fisica As CheckBox
    Public WithEvents bs_consulta As New BindingSource

    Public Sub New(ByRef consulta As BindingSource,
                   Optional FiltroPersona As String = "PERSONA", Optional key As String = "BUSCAR..")
        MyBase.New()
        Me.difunto = New System.Windows.Forms.CheckBox()
        Me.fisica = New System.Windows.Forms.CheckBox()
        Me.filtros.SuspendLayout()
        Me.PanelBusqueda.SuspendLayout()
        Me.SuspendLayout()
        '
        'Fondo de botones
        '
        For Each b As Control In Me.PanelBusqueda.Controls
            If TypeOf b Is Button Then
                CType(b, Button).BackColor = ColorPersona
            End If
        Next
        '
        'filtros
        '
        Me.filtros.Controls.Add(Me.fisica)
        Me.filtros.Controls.Add(Me.difunto)
        '
        'filtro1
        '
        Me.filtro1.Items.AddRange(New Object() {"PERSONA", "DIRECCION", "PROFESIONAL", "PROVEEDOR"})
        Me.filtro1.Text = FiltroPersona
        '
        'keyword
        '
        Me.keyword.Text = key
        '
        'difunto
        '
        Me.difunto.AutoSize = True
        Me.difunto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.difunto.ForeColor = System.Drawing.Color.White
        Me.difunto.Location = New System.Drawing.Point(159, 6)
        Me.difunto.Margin = New System.Windows.Forms.Padding(3, 6, 3, 3)
        Me.difunto.Name = "difunto"
        Me.difunto.Size = New System.Drawing.Size(76, 23)
        Me.difunto.TabIndex = 354
        Me.difunto.Text = "Difunto"
        Me.difunto.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.difunto.UseVisualStyleBackColor = True
        '
        'fisica
        '
        Me.fisica.AutoSize = True
        Me.fisica.Checked = True
        Me.fisica.CheckState = System.Windows.Forms.CheckState.Checked
        Me.fisica.Dock = System.Windows.Forms.DockStyle.Fill
        Me.fisica.ForeColor = System.Drawing.Color.White
        Me.fisica.Location = New System.Drawing.Point(241, 6)
        Me.fisica.Margin = New System.Windows.Forms.Padding(3, 6, 3, 3)
        Me.fisica.Name = "fisica"
        Me.fisica.Size = New System.Drawing.Size(66, 23)
        Me.fisica.TabIndex = 355
        Me.fisica.Text = "Fisica"
        Me.fisica.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.fisica.UseVisualStyleBackColor = True
        '
        'Nuevo
        '
        Me.Nuevo.Text = "NUEVA"
        '
        'ControlBusquedaPersona
        '
        Me.Controls.Add(Me.visor)
        Me.Controls.Add(Me.PanelBusqueda)
        Me.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Font = New System.Drawing.Font("PF DinText Pro", 12.0!)
        Me.Size = New System.Drawing.Size(834, 321)
        Me.TabIndex = 337

        consulta = bs_consulta


        Me.PanelBusqueda.ResumeLayout(False)
        Me.PanelBusqueda.PerformLayout()
        Me.filtros.ResumeLayout(False)
        Me.filtros.PerformLayout()
        Me.ResumeLayout(False)
    End Sub

    '###### VARIABLES Y RUTINAS #################################################################################
    Public Sub ConsultarPersonas()
        keyword.Text = Trim(keyword.Text)
        With filtro1.Text
            If .Contains("PERSONA") Then
                visor = Data.ToDataGridView(visor, bs_consulta, BuscarPorPersona(difunto.Checked, fisica.Checked,
                                                                    Val(keyword.Text), Val(keyword.Text), keyword.Text))
            ElseIf .Contains("DIRECCION") Then
                visor = Data.ToDataGridView(visor, bs_consulta, BuscarPorDireccion(keyword.Text, difunto.Checked, fisica.Checked))
            ElseIf .Contains("EMPLEADO") Then
                fisica.Enabled = False
                fisica.Checked = True
                visor = Data.ToDataGridView(visor, bs_consulta, Empleado.BuscarPorPersona(keyword.Text, difunto.Checked))
            ElseIf .Contains("PROVEEDOR") Then
                difunto.Enabled = False
                difunto.Checked = False
                visor = Data.ToDataGridView(visor, bs_consulta, Proveedor.BuscarPorPersona(keyword.Text, fisica.Checked))
            ElseIf .Contains("PROFESIONAL") Then
                fisica.Enabled = False
                fisica.Checked = True
                difunto.Enabled = False
                difunto.Checked = False
                visor = Data.ToDataGridView(visor, bs_consulta, Profesional.BuscarPorPersona(Val(keyword.Text), Val(keyword.Text),
                                                                                          Trim(keyword.Text)))
            Else
                reset.PerformClick()
            End If
        End With
    End Sub
    '###### FIN VARIABLES Y RUTINAS #############################################################################

    '###### GUI #################################################################################################
    Private Sub Nueva_Persona_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Nuevo.Click
        'La búsqueda se va a realizar automáticamente, para mostrar personas coincidentes con la razón
        'social o el cuil ingresado
        Dim agregar_per As New ModPersona
        With agregar_per
            .ShowDialog(Me)
        End With
    End Sub
    Private Sub Modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Modificar.Click
        With bs_consulta
            If .Position > -1 Then
                Dim edit_per As New ModPersona(.Current("persona_id"))
                With edit_per
                    .ShowDialog(Me)
                End With
                ConsultarPersonas()
            End If
        End With
    End Sub
    Private Sub Eliminar_Click(sender As Object, e As EventArgs) Handles Eliminar.Click
        With bs_consulta
            If .Position > -1 Then
                If Persona.sql.Eliminar(.Current("persona_id")) Then
                    .RemoveCurrent()
                    reset.PerformClick()
                    ConsultarPersonas()
                End If
            End If
        End With
    End Sub
    '###### END GUI #############################################################################################

    '###### BUSQUEDA ##########################################################################################
    Private Sub Keyword_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles keyword.KeyPress
        If e.KeyChar = Chr(13) Then
            ConsultarPersonas()
        End If
    End Sub
    Private Sub filtro1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles filtro1.SelectedIndexChanged
        If filtro1.SelectedIndex > -1 Then
            reset.PerformClick()
            difunto.Enabled = True
            fisica.Enabled = True
            ConsultarPersonas()
        End If
    End Sub

    '###### VALIDACION ##########################################################################################
    Private Sub fisica_CheckedChanged(sender As Object, e As EventArgs) Handles fisica.CheckedChanged
        difunto.Checked = False
        difunto.Enabled = fisica.Checked
    End Sub
    '###### CAMBIOS ###############################################################################################


End Class
