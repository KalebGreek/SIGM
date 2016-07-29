Imports Sigm.Persona.sql
Public Class ControlBusquedaExpediente
    Inherits ControlBusquedaGen
    Public user_id As Integer
    Public WithEvents bs_consulta As New BindingSource

    Public Sub New(user As Integer, ByRef consulta As BindingSource,
                   Optional FiltroOprivadas As String = "EXPEDIENTE", Optional key As String = "BUSCAR..")
        MyBase.New()
        user_id = user
        Me.filtros.SuspendLayout()
        Me.PanelBusqueda.SuspendLayout()
        Me.SuspendLayout()
        '
        'Fondo de botones
        '
        For Each b As Control In Me.PanelBusqueda.Controls
            If TypeOf b Is Button Then
                CType(b, Button).BackColor = ColorOprivadas
            End If
        Next
        '
        'filtro1
        '
        Me.filtro1.Items.AddRange(New Object() {"EXPEDIENTE", "RESPONSABLE", "PROFESIONAL", "CUIL"})
        Me.filtro1.SelectedIndex = 0
        '
        'keyword
        '
        Me.keyword.Text = key
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

        Me.filtros.ResumeLayout(False)
        Me.filtros.PerformLayout()
        Me.PanelBusqueda.ResumeLayout(False)
        Me.PanelBusqueda.PerformLayout()
        Me.ResumeLayout(False)
    End Sub

    '###### VARIABLES Y RUTINAS #################################################################################
    Public Sub ConsultarExpedientes()
        keyword.Text = Trim(keyword.Text)
        With filtro1.Text
            If .Contains("EXPEDIENTE") Then
                visor = Data.ToDataGridView(visor, bs_consulta, Oprivadas.Expediente.Buscar(Val(keyword.Text)))
            ElseIf .Contains("RESPONSABLE") Then
                visor = Data.ToDataGridView(visor, bs_consulta, Oprivadas.Expediente.Buscar(, keyword.Text))
            ElseIf .Contains("PROFESIONAL") Then
                visor = Data.ToDataGridView(visor, bs_consulta, Oprivadas.Expediente.Buscar(, , keyword.Text))
            ElseIf .Contains("CUIL") Then
                visor = Data.ToDataGridView(visor, bs_consulta, Oprivadas.Expediente.Buscar(, , , Val(keyword.Text)))
            Else
                reset.PerformClick()
            End If
        End With
    End Sub
    '###### FIN VARIABLES Y RUTINAS #############################################################################

    '###### GUI #################################################################################################
    Private Sub NuevoExp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Nuevo.Click
        Dim NuevoExp As New ModExpediente(user_id)
        If NuevoExp.dtab_exp Is Nothing Then
            NuevoExp.Dispose()
        Else
            NuevoExp.ShowDialog()
        End If
    End Sub
    '###### END GUI #############################################################################################

    '###### BUSQUEDA ##########################################################################################
    Private Sub Keyword_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles keyword.KeyPress
        If e.KeyChar = Chr(13) Then
            ConsultarExpedientes()
        End If
    End Sub
    Private Sub filtro1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles filtro1.SelectedIndexChanged
        If filtro1.SelectedIndex > -1 Then
            reset.PerformClick()
            ConsultarExpedientes()
        End If
    End Sub

    '###### CAMBIOS ###############################################################################################
    Private Sub Modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Modificar.Click
        With bs_consulta
            If .Position > -1 Then
                Dim NuevoExp As New ModExpediente(user_id, .Current("expediente"))
                If NuevoExp.dtab_exp Is Nothing Then
                    NuevoExp.Dispose()
                Else
                    NuevoExp.ShowDialog()
                End If
                ConsultarExpedientes()
            End If
        End With
    End Sub
    Private Sub Eliminar_Click(sender As Object, e As EventArgs) Handles Eliminar.Click
        With bs_consulta
            If .Position > -1 Then
                'Oprivadas.EliminarExpediente("expediente_id")
            End If
        End With
    End Sub
End Class
