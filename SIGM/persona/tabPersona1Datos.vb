Public Class tabPersona1Datos
    Inherits System.Windows.Forms.UserControl
    Dim PersonaId As Integer

    Public Sub New(PerId As Integer)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        PersonaId = PerId
    End Sub

    Public Sub cargar()
        If PersonaId > 0 Then
            Dim genero As Integer = 0
            Dim valor_cuil As Double = 0
            Dim drow As DataRow = DbMan.ReadDB("SELECT id as persona_id, razon, cuil  FROM persona WHERE id=" & PersonaId,
                                                My.Settings.CurrentDB, "", True)

            If drow Is Nothing = False Then
                razon.Text = drow("razon").ToString
                valor_cuil = CDbl(drow("cuil").ToString)
                If valor_cuil > 20000000000 Then
                    genero = Val(Microsoft.VisualBasic.Left(valor_cuil, 2))
                    If genero > 27 Then
                        gen.Text = "N/A"
                    ElseIf genero > 23 Then
                        gen.Text = "Femenino"
                    ElseIf genero > 0 Then
                        gen.Text = "Masculino"
                    End If
                    dni.Text = Microsoft.VisualBasic.Mid(drow("cuil").ToString, 3, 8)
                    cuil.Text = valor_cuil
                Else
                    dni.Text = valor_cuil
                End If
            End If
        End If
    End Sub

    Public Function guardar() As Integer
        'Buscar duplicado de CUIL/CUIT
        Dim dtab As DataTable = DbMan.ReadDB("SELECT id, razon FROM persona WHERE cuil=" & cuil.Text, My.Settings.CurrentDB)

        If dtab.Rows.Count > 0 Then
            ErrorInfo.SetToolTip(cuil, "Este CUIL/CUIT pertenece a " & dtab.Rows(0)("id").ToString & "-" & dtab.Rows(0)("razon").ToString)
            cuil.BackColor = Color.MistyRose
        Else
            ErrorInfo.RemoveAll()
            cuil.BackColor = SystemColors.Window
        End If
        If CtrlMan.Validate(Me, ErrorInfo) Then
            Dim fisica As Boolean = gen.Text <> "N/A"
            If PersonaId > 0 Then
                DbMan.EditDB("UPDATE persona 
                                 SET razon='" & razon.Text & "', cuil=" & cuil.Text & ", fisica=" & fisica & "
							   WHERE id=" & PersonaId,
                             My.Settings.CurrentDB)
            Else
                DbMan.EditDB("INSERT INTO persona(razon, cuil, fisica)
					               VALUES('" & razon.Text & "','" & cuil.Text & "'," & fisica & ")",
                             My.Settings.CurrentDB)
                'Next query could be replaced by OUTPUT insert.id

                PersonaId = DbMan.ReadDB("SELECT MAX(id) as id FROM persona", My.Settings.CurrentDB).Rows(0)("id") 'Last insert
            End If
        End If
        Return PersonaId
    End Function

    Private Sub gen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles gen.SelectedIndexChanged, gen.SelectedValueChanged, gen.TextChanged
        If gen.SelectedIndex > -1 And Me.Visible Then
            If Len(dni.Text) >= 7 And Len(dni.Text) <= 8 Then
                cuil.Text = Persona.CalcularCuil(dni.Text, Microsoft.VisualBasic.Left(gen.Text, 1))
            End If
        End If
    End Sub

    Private Sub dni_KeyUp(sender As Object, e As KeyEventArgs) Handles dni.KeyUp, cuil.KeyUp
        If sender Is dni Then
            If e.KeyValue = Keys.Enter Then
                If Len(dni.Text) >= 7 And Len(dni.Text) <= 8 And gen.SelectedIndex > -1 Then
                    cuil.Text = Persona.CalcularCuil(dni.Text, Microsoft.VisualBasic.Left(gen.Text, 1))
                End If
            End If
        End If
    End Sub


End Class
