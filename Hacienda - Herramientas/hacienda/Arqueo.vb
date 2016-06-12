Public Class Arqueo
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        año.Value = Today.Year
        PanelColumnas.Visible = False
        TablaPersonalizada.Visible = False
        FiltroFecha.Visible = False
        Connection.Text = foxcon
    End Sub

    'MOVIMIENTOS
    Private Sub IngresosMovToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IngresosMovToolStripMenuItem.Click
        FiltroFecha.Visible = True
        sel_sql = "SELECT hacienda.nombre, movimis.orden, SUM(movimientos.pagado) as ingreso 
                    FROM movimientos INNER JOIN hacienda ON movimientos.orden=hacienda.orden
                    WHERE orden < 900000000000"

        If Anual.Checked Then
            sel_sql += " AND fecha LIKE '" & año.Value & "'"
        ElseIf PorFecha.Checked Then
            sel_sql += " AND fecha => '" & inicio.Value & "' AND fecha <= '" & final.Value & "'"
        End If

        sel_sql += " GROUP BY movimis.orden"

        MostrarTabla(True, sel_sql)
    End Sub
    Private Sub EgresosMovToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EgresosMovToolStripMenuItem.Click
        FiltroFecha.Visible = True
        sel_sql = "SELECT hacienda.nombre, movimis.orden, SUM(movimientos.pagado) as egreso
        FROM movimientos INNER JOIN hacienda ON movimientos.orden=hacienda.orden
        WHERE orden > 899999999999"

        If Anual.Checked Then
            sel_sql += " AND fecha LIKE '" & año.Value & "'"
        ElseIf PorFecha.Checked Then
            sel_sql += " AND fecha => '" & inicio.Value & "' AND fecha <= '" & final.Value & "'"
        End If

        sel_sql += " GROUP BY movimis.orden"

        MostrarTabla(True, sel_sql)
    End Sub
    'HACIENDA
    Private Sub IngresosYEgresosPorHaciendaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IngresosYEgresosPorHaciendaToolStripMenuItem.Click
        sel_sql = "SELECT  (SUM(enero) + SUM(febrero) + SUM(marzo) + SUM(abril) +
                            SUM(mayo) + SUM(junio) + SUM(julio) + SUM(agosto) +
                            SUM(septiembre) + SUM(octubre) + SUM(noviembre) + SUM(diciembre)) as total_ingreso,
                           (SUM(enero) + SUM(febrero) + SUM(marzo) + SUM(abril) +
                            SUM(mayo) + SUM(junio) + SUM(julio) + SUM(agosto) +
                            SUM(septiembre) + SUM(octubre) + SUM(noviembre) + SUM(diciembre)) as total_egreso
                    FROM hacienda   
                    GROUP BY total_ingreso, total_egreso"

        MostrarTabla(True, sel_sql)
    End Sub
    'BANCOS
    Private Sub SaldoDeCuentasBancosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaldoDeCuentasBancosToolStripMenuItem.Click
        FiltroFecha.Visible = True
        sel_sql = "SELECT banco, 
                                (SELECT SUM(importe) FROM banco WHERE tipo=2) - 
                                (SELECT SUM(importe) FROM banco WHERE tipo=1) as saldo"

        If Anual.Checked Then
            sel_sql += " AND fecha LIKE '" & año.Value & "'"
        ElseIf PorFecha.Checked Then
            sel_sql += " AND fecha => '" & inicio.Value & "' AND fecha <= '" & final.Value & "'"
        End If

        sel_sql += " FROM banco    
        GROUP BY banco"

        MostrarTabla(True, sel_sql)
    End Sub
    'CAJA
    Private Sub CierreDiarioDeCajaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CierreDiarioDeCajaToolStripMenuItem.Click
        FiltroFecha.Visible = True

        sel_sql = "SELECT * "

        If Anual.Checked Then
            sel_sql += " WHERE fecha LIKE '" & año.Value & "'"
        ElseIf PorFecha.Checked Then
            sel_sql += " WHERE fecha => '" & inicio.Value & "' AND fecha <= '" & final.Value & "'"
        End If

        sel_sql += " FROM caja"

        MostrarTabla(True, sel_sql)
    End Sub

    'RUTINAS
    Private Sub MostrarTabla(reset As Boolean, Optional CustomQuery As String = "Ninguno.")
        Dim sql As String = ""
        Dim dtab As New DataTable

        DataView.DataSource = Nothing
        bs.DataSource = Nothing

        CustomCriteria.Text = CustomQuery
        If CustomQuery <> "Ninguno." Then
            sql = CustomQuery
        Else
            If reset Then
                ListaColumnas.Items.Clear()
                For Each col As DataColumn In dtab.Columns
                    ListaColumnas.Items.Add(col.ToString, True)
                Next
            End If
            sql = FiltroColumna(sql)
        End If

        If Connection.Text <> "Sin datos." Then
            Query.Show(DataView, bs, bd.read(Connection.Text, sql))
        Else
            MsgBox("Seleccione una base de datos antes de continuar.")
        End If

    End Sub
    Private Function FiltroColumna(sql As String)
        If ListaColumnas.CheckedItems.Count > 0 Then
            sql = "SELECT "
            For Each item In ListaColumnas.CheckedItems
                sql += item.ToString & ", "
            Next
            sql = Microsoft.VisualBasic.Left(sel_sql, Len(sel_sql) - 2)
        Else
            sql = "SELECT *"
        End If
        sql += " FROM " & TablaPersonalizada.Text
        Return sql
    End Function

    Private Sub path_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles TablaPersonalizada.LinkClicked
        Dim name As String = ""
        Dim table As New DataTable

        If TablaPersonalizada.Text <> "Click para agregar tabla." Then
            name = TablaPersonalizada.Text
        End If

        Do
            name = InputBox("Ingrese nombre de tabla.", "Ingresar Tabla", "")
            If name <> "" Then
                table = bd.read(Connection.Text, "SELECT * FROM " & name)
            Else
                name = Nothing
            End If
        Loop Until name Is Nothing Or table Is Nothing = False

        If name <> "" Then
            MostrarTabla(True)
            If name <> TablaPersonalizada.Text Then
                TablaPersonalizada.Text = name
            End If
        Else
            TablaPersonalizada.Text = "Click para agregar tabla."
        End If

    End Sub

    Private Sub ColumnList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListaColumnas.SelectedIndexChanged
        MostrarTabla(False)
    End Sub
    Private Sub ColumnList_MouseUp(sender As Object, e As MouseEventArgs) Handles ListaColumnas.MouseUp
        MostrarTabla(False)
    End Sub
    Private Sub ColumnList_KeyUp(sender As Object, e As KeyEventArgs) Handles ListaColumnas.KeyUp
        MostrarTabla(False)
    End Sub

    Private Sub DBFoxMuniciToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DBFoxMuniciToolStripMenuItem.Click
        Connection.Text = foxcon
    End Sub
    Private Sub DBAccessToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DBAccessToolStripMenuItem.Click
        Connection.Text = adbcon
    End Sub
    Private Sub DBPostgreSQLToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles DBPostgreSQLToolStripMenuItem.Click
        Connection.Text = pgsqlcon
    End Sub
End Class