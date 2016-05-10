Public Class ComparadorTablas

    'CONEXIONES
    Private Sub fox_CheckedChanged(sender As Object, e As EventArgs) Handles fox.CheckedChanged
        If fox.Checked Then
            conexion.Text = foxcon
        End If
    End Sub
    Private Sub access_CheckedChanged(sender As Object, e As EventArgs) Handles access.CheckedChanged
        If access.Checked Then
            conexion.Text = defcon
        End If
    End Sub

    'GUI
    Private Sub par1_CheckedChanged(sender As Object, e As EventArgs) Handles par1.CheckedChanged
        campo1a.Enabled = par1.Checked
        campo1b.Enabled = par1.Checked
    End Sub
    Private Sub par2_CheckedChanged(sender As Object, e As EventArgs) Handles par2.CheckedChanged
        campo2a.Enabled = par2.Checked
        campo2b.Enabled = par2.Checked
    End Sub
    Private Sub par3_CheckedChanged(sender As Object, e As EventArgs) Handles par3.CheckedChanged
        campo3a.Enabled = par3.Checked
        campo3b.Enabled = par3.Checked
    End Sub

    'TABLA ALFA
    Private Sub ruta_alfa_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles ruta_alfa.LinkClicked
        cargar_tabla(ruta_alfa, visor_alfa, bs_alfa)
    End Sub
    Private Sub bs_alfa_DataSourceChanged(sender As Object, e As EventArgs) Handles bs_alfa.DataSourceChanged
        campo1a.DataSource = Nothing
        campo2a.DataSource = Nothing
        campo3a.DataSource = Nothing
        clavea.Items.Clear()
        agregar_columnas(bs_alfa)
    End Sub

    'TABLA BETA
    Private Sub ruta_beta_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles ruta_beta.LinkClicked
        cargar_tabla(ruta_beta, visor_beta, bs_beta)
    End Sub
    Private Sub bs_beta_DataSourceChanged(sender As Object, e As EventArgs) Handles bs_beta.DataSourceChanged
        campo1b.DataSource = Nothing
        campo2b.DataSource = Nothing
        campo3b.DataSource = Nothing
        claveb.Items.Clear()
        agregar_columnas(bs_beta)
    End Sub

    'BUSQUEDA
    Private Sub buscar_Click(sender As Object, e As EventArgs) Handles buscar.Click
        Dim operacion As Integer
        Dim columna1 As String = ""
        Dim columna2 As String = ""
        Dim dtab As DataTable
        If igual.Checked Then
            operacion = 1
        ElseIf diff.Checked Then
            operacion = 2
        End If
        If par1.Checked Then
            columna1 = campo1a.Text
            columna2 = campo1b.Text
        ElseIf par2.Checked Then
            columna1 = campo2a.Text
            columna2 = campo2b.Text
        ElseIf par3.Checked Then
            columna1 = campo3a.Text
            columna2 = campo3b.Text
        End If
        dtab = comparar(operacion, clavea.Text, claveb.Text, ruta_alfa.Text, ruta_beta.Text, columna1, columna2)
        If dtab Is Nothing Then
            MsgBox("No hay resultados.")
            resultados.DataSource = Nothing
            bs_result.DataSource = Nothing
        Else
            resultados = Consulta.Mostrar(resultados, bs_result, dtab)
        End If
    End Sub

    Private Sub reiniciar_Click(sender As Object, e As EventArgs) Handles reiniciar.Click

    End Sub
    'RUTINAS
    Private Sub cargar_tabla(origen As LinkLabel, visor As DataGridView, bs As BindingSource)
        Dim nombre As String
        Dim tabla As New DataTable
        Do
            nombre = InputBox("Ingrese nombre de tabla.", "Ingresar Tabla", "")
            If nombre <> "" Then
                tabla = bd.leer(conexion.Text, "SELECT * FROM " & nombre)
            Else
                nombre = Nothing
            End If
        Loop Until nombre Is Nothing Or tabla Is Nothing = False

        If nombre = "" Then
            origen.Text = "Click para agregar tabla."
            visor.DataSource = Nothing
            bs.DataSource = Nothing
        Else
            origen.Text = nombre
            Consulta.Mostrar(visor, bs, tabla)
        End If
    End Sub
    Private Sub agregar_columnas(bs As BindingSource)
        With bs
            If .Count > 0 Then
                If bs Is bs_alfa Then
                    For Each dc As DataColumn In bs.DataSource.Columns
                        clavea.Items.Add(dc.ColumnName)
                    Next
                    clavea.SelectedIndex = 0
                    campo1a.DataSource = clavea.Items
                    campo2a.DataSource = clavea.Items
                    campo3a.DataSource = clavea.Items
                ElseIf bs Is bs_beta Then
                    For Each dc As DataColumn In bs.DataSource.Columns
                        claveb.Items.Add(dc.ColumnName)
                    Next
                    claveb.SelectedIndex = 0
                    campo1b.DataSource = claveb.Items
                    campo2b.DataSource = claveb.Items
                    campo3b.DataSource = claveb.Items
                End If
            End If
        End With
    End Sub
    Private Function comparar(operacion As Integer, clave1 As String, clave2 As String, tabla1 As String, tabla2 As String, _
                                    Optional columna1 As String = "", Optional columna2 As String = "") As DataTable
        If clave1 <> "" And clave2 <> "" And tabla1 <> "" And tabla2 <> "" Then
            sel_sql = "SELECT " & tabla1 & "." & columna1 & ", " & tabla2 & "." & columna2 & _
                      " FROM " & tabla1 & " INNER JOIN " & tabla2 & _
                      " ON " & tabla1 & "." & clave1 & " = " & tabla2 & "." & clave2
            If operacion = 1 Then
                sel_sql += " WHERE " & tabla1 & "." & columna1 & " = " & tabla2 & "." & columna2
            ElseIf operacion = 2 Then
                sel_sql += " WHERE " & tabla1 & "." & columna1 & " <> " & tabla2 & "." & columna2
            End If

            Return bd.leer(conexion.Text, sel_sql)
        Else
            Return Nothing
        End If
    End Function
    Private Sub validar_columnas(columna As ComboBox)
        'With columna
        'For Each c As Control In panel_busqueda.Controls
        'If TypeOf c Is ComboBox And c Is columna = False Then
        'If CType(c, ComboBox).SelectedIndex = columna.SelectedIndex Then
        'CType(c, ComboBox).SelectedIndex = -1
        'End If
        'End If
        'Next
        'End With
    End Sub

    Private Sub clavea_SelectedIndexChanged(sender As Object, e As EventArgs)
        validar_columnas(sender)
        If clavea.SelectedIndex = campo1a.SelectedIndex Then
            campo1a.SelectedIndex = -1
        End If
        If clavea.SelectedIndex = campo2a.SelectedIndex Then
            campo1a.SelectedIndex = -1
        End If
        If clavea.SelectedIndex = campo3a.SelectedIndex Then
            campo1a.SelectedIndex = -1
        End If
    End Sub
    Private Sub claveb_SelectedIndexChanged(sender As Object, e As EventArgs)
        validar_columnas(sender)
        If claveb.SelectedIndex = campo1b.SelectedIndex Then
            campo1b.SelectedIndex = -1
        End If
        If claveb.SelectedIndex = campo2b.SelectedIndex Then
            campo1b.SelectedIndex = -1
        End If
        If claveb.SelectedIndex = campo3b.SelectedIndex Then
            campo1b.SelectedIndex = -1
        End If
    End Sub
    Private Sub campo1a_SelectedIndexChanged(sender As Object, e As EventArgs)
        validar_columnas(sender)
        If campo1a.SelectedIndex = clavea.SelectedIndex Then
            campo1a.SelectedIndex = -1
        End If
        If campo1a.SelectedIndex = campo2a.SelectedIndex Then
            campo2a.SelectedIndex = -1
        End If
        If campo1a.SelectedIndex = campo3a.SelectedIndex Then
            campo3a.SelectedIndex = -1
        End If
    End Sub
    Private Sub campo1b_SelectedIndexChanged(sender As Object, e As EventArgs)
        validar_columnas(sender)
        If campo1b.SelectedIndex = claveb.SelectedIndex Then
            campo1b.SelectedIndex = -1
        End If
        If campo1b.SelectedIndex = campo2b.SelectedIndex Then
            campo2b.SelectedIndex = -1
        End If
        If claveb.SelectedIndex = campo3b.SelectedIndex Then
            campo3b.SelectedIndex = -1
        End If
    End Sub
    Private Sub campo2a_SelectedIndexChanged(sender As Object, e As EventArgs)
        validar_columnas(sender)
        If campo2a.SelectedIndex = clavea.SelectedIndex Or campo2a.SelectedIndex = campo1a.SelectedIndex Then
            campo2a.SelectedIndex = -1
        End If
        If campo2a.SelectedIndex = campo3a.SelectedIndex Then
            campo3a.SelectedIndex = -1
        End If
    End Sub
    Private Sub campo2b_SelectedIndexChanged(sender As Object, e As EventArgs)
        validar_columnas(sender)
        If campo2b.SelectedIndex = claveb.SelectedIndex Or campo2b.SelectedIndex = campo1b.SelectedIndex Then
            campo2b.SelectedIndex = -1
        End If
        If campo2b.SelectedIndex = campo3b.SelectedIndex Then
            campo3b.SelectedIndex = -1
        End If
    End Sub
    Private Sub campo3a_SelectedIndexChanged(sender As Object, e As EventArgs)
        validar_columnas(sender)
        If campo3a.SelectedIndex = clavea.SelectedIndex Or campo3a.SelectedIndex = campo1a.SelectedIndex _
        Or campo3a.SelectedIndex = campo2a.SelectedIndex Then
            campo3a.SelectedIndex = -1
        End If
    End Sub
    Private Sub campo3b_SelectedIndexChanged(sender As Object, e As EventArgs)
        validar_columnas(sender)
        If campo3b.SelectedIndex = claveb.SelectedIndex Or campo3b.SelectedIndex = campo1b.SelectedIndex _
        Or campo3b.SelectedIndex = campo2b.SelectedIndex Then
            campo3b.SelectedIndex = -1
        End If
    End Sub
End Class