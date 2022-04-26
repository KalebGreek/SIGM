Imports System.ComponentModel

Public Class ModPersona
    Public PersonaId As Integer = 0
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
    End Sub

    '###### GUI ##########################################################################################
    Private Sub ModPersona_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Me.Visible Then
            If PersonaId > 0 Then
                Me.Text = "MODIFICAR PERSONA"
            Else
                Me.Text = "NUEVA PERSONA"
            End If
            Cargar(TabPage1)
        End If

    End Sub

    Private Sub TabControl1_TabIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        'Enable and disable tabcontrol buttons based on position
        If Me.Visible Then
            lastPage.Enabled = TabControl1.SelectedIndex > 0
            nextPage.Enabled = TabControl1.SelectedIndex < TabControl1.TabCount - 1
            If TabControl1.SelectedIndex > -1 Then
                Label1.Text = TabControl1.SelectedTab.Text
            End If
            Cargar(TabControl1.TabPages.Item(TabControl1.SelectedIndex))
        End If
    End Sub
    Private Sub LastPage_Click(sender As Object, e As EventArgs) Handles lastPage.Click
        If TabControl1.SelectedIndex > 0 And Guardar(TabControl1.SelectedTab) Then
            TabControl1.SelectedIndex -= 1
        End If
    End Sub
    Private Sub NextPage_Click(sender As Object, e As EventArgs) Handles nextPage.Click
        If TabControl1.SelectedIndex < TabControl1.TabCount - 1 And Guardar(TabControl1.SelectedTab) Then
            TabControl1.SelectedIndex += 1
        End If
    End Sub

    '###### CARGAR ##########################################################################################

    '###### MODIFICAR ##########################################################################################
    Private Sub ModActas_Click(sender As Object, e As EventArgs)
        If PersonaId > 0 Then
            Using visor_acta As New ModActa(PersonaId)
                visor_acta.ShowDialog(Me)
            End Using
        Else
            MsgBox("Debe guardar el registro de la persona antes de continuar.")
        End If
    End Sub


    Private Sub Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles save.Click
        If Guardar(TabControl1.SelectedTab) Then
            Me.Close()
        End If
    End Sub

    Private Sub ModPersona_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        For Each CurrentTabPage As TabPage In TabControl1.TabPages
            For Each c As Control In CurrentTabPage.Controls
                If TypeOf (c) Is tabPersona1Datos Or
                   TypeOf (c) Is tabPersona2Domicilio Or
                   TypeOf (c) Is tabPersona3Contacto Or
                   TypeOf (c) Is tabPersona4Adicional Then
                    c.Dispose()
                End If
            Next
        Next

        If Me.MdiParent Is Nothing = False Then
            Dim cper As New ConsultaPersona With {.MdiParent = Me.MdiParent}
            cper.Show()
            cper.Focus()
        End If
    End Sub

    Private Sub Cargar(CurrentTabPage As TabPage)
        Me.SuspendLayout()
        With CurrentTabPage
            .Controls.Clear()
            If CurrentTabPage Is TabPage1 Then
                Dim TabPersona1Datos1 As New tabPersona1Datos(PersonaId) _
                With {.Dock = DockStyle.Fill, .Parent = Me.TabPage1}
                .Controls.Add(TabPersona1Datos1)
                TabPersona1Datos1.cargar()

            ElseIf CurrentTabPage Is TabPage2 Then
                Dim TabPersona2Domicilio1 As New tabPersona2Domicilio(PersonaId) _
                With {.Dock = DockStyle.Fill, .Parent = Me.TabPage2}
                .Controls.Add(TabPersona2Domicilio1)
                TabPersona2Domicilio1.cargar()

            ElseIf CurrentTabPage Is TabPage3 Then
                Dim TabPersona3Contacto1 As New tabPersona3Contacto(PersonaId) _
                With {.Dock = DockStyle.Fill, .Parent = Me.TabPage3}
                .Controls.Add(TabPersona3Contacto1)
                TabPersona3Contacto1.Cargar()

            ElseIf CurrentTabPage Is TabPage4 Then
                Dim tabPersona4Adicional1 As New tabPersona4Adicional(PersonaId) _
                    With {.Dock = DockStyle.Fill, .Parent = Me.TabPage4}
                .Controls.Add(tabPersona4Adicional1)
                tabPersona4Adicional1.cargar()

            End If
        End With
        Me.ResumeLayout()
    End Sub


    Private Function Guardar(CurrentTabPage As TabPage) As Boolean
        For Each c As Control In CurrentTabPage.Controls
            If TypeOf (c) Is tabPersona1Datos Then
                PersonaId = CType(c, tabPersona1Datos).guardar()
                c.Dispose()
            ElseIf TypeOf (c) Is tabPersona2Domicilio Then
                PersonaId = CType(c, tabPersona2Domicilio).guardar()
                c.Dispose()
            ElseIf TypeOf (c) Is tabPersona3Contacto Then
                PersonaId = CType(c, tabPersona3Contacto).Guardar()
                c.Dispose()
            ElseIf TypeOf (c) Is tabPersona4Adicional Then
                PersonaId = CType(c, tabPersona4Adicional).Guardar()
                c.Dispose()
            End If
        Next
        Return PersonaId > 0
    End Function


End Class