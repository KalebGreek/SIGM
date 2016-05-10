Imports System.ComponentModel

Public Class ConsultaGen
    Public tipo As String
    Public resultado As New BindingSource

    'Todos los eventos se traen desde el menu base
    Public Sub New(TipoBusqueda As String, user As Integer, Optional keyword As String = "BUSCAR..")
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        tipo = TipoBusqueda
        If tipo = "PERSONA" Or tipo = "PROFESIONAL" Then
            Me.Controls.Add(New ControlBusquedaPersona(resultado, tipo, keyword))
        ElseIf tipo = "EXPEDIENTE" Then
            Me.Controls.Add(New ControlBusquedaExpediente(user, resultado, tipo, keyword))
        End If
        Me.SuspendLayout()
        Me.ResumeLayout()
        Me.PerformLayout()
        Me.Text = "BUSCAR " & tipo
    End Sub
    Private Sub ConsultaGen_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Me.Visible Then
            If MdiParent Is Nothing = False Then
                Me.WindowState = FormWindowState.Maximized
            Else
                Me.WindowState = FormWindowState.Normal
            End If
        End If
    End Sub
    Private Sub ConsultaGen_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If resultado.Position = -1 Then
            If MsgBoxResult.Yes = MsgBox("No se seleccionó una persona.", MsgBoxStyle.YesNo) Then
                resultado.DataSource = Nothing
            End If
        ElseIf resultado.Current("cuil") < 20000000000 Then
            If MsgBoxResult.Yes = MsgBox("El CUIL de la persona seleccionada no es válido, no se guardarán los cambios.", MsgBoxStyle.YesNo) Then
                resultado.DataSource = Nothing
            End If
        End If
    End Sub


End Class