Public Class ConsultasEspeciales
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Connection.Text = My.Settings.foxConnection

        GenSearchControl1.vista.Items.AddRange(New Object() {"HACIENDA - INGRESOS", "HACIENDA - EGRESOS",
                                                             "INGRESOS CONSOLIDADOS", "EGRESOS CONSOLIDADOS",
                                                             "BANCOS - SALDO", "CAJA",
                                                             "COMPARAR INGRESOS", "COMPARAR EGRESOS",
                                                             "PERSONALIZADA"})

    End Sub

    'EVENTOS
    Private Sub Search() Handles GenSearchControl1.CSearchClick
        GenSearchControl1.FilterSearch()
    End Sub

    Private Sub FilterResults() Handles GenSearchControl1.CFilter
        bs_query.Filter = GenSearchControl1.bsCustomFilter
    End Sub

    Private Sub BuildFilter() Handles GenSearchControl1.CFiltroIndexTextChanged
        With GenSearchControl1
            If .filtro.SelectedIndex > -1 And bs_query.Count > 0 And
           .filtro.Text <> "System.Data.DataRowView" Then

                Dim filter As String = .filtro.Text
                Dim ordered_bs As BindingSource = bs_query
                ordered_bs.Sort = filter
                ordered_bs.MoveFirst()
                Dim FirstRow As DataRowView = ordered_bs.Current
                ordered_bs.MoveLast()
                Dim LastRow As DataRowView = ordered_bs.Current

                'TODO filtrar valores nulos
                If .filtro.SelectedValue.ToString = "System.Decimal" _
                Or .filtro.SelectedValue.ToString = "System.Integer" Then
                    If FirstRow(filter) Is DBNull.Value Then
                        .NumValue.Minimum = 0
                        .MaxNumValue.Minimum = 0
                    Else
                        .NumValue.Minimum = FirstRow(filter)
                        .MaxNumValue.Minimum = FirstRow(filter)
                    End If

                    If LastRow(filter) Is DBNull.Value Then
                        .NumValue.Maximum = 999999
                        .MaxNumValue.Maximum = 999999
                    Else
                        .NumValue.Maximum = LastRow(filter)
                        .MaxNumValue.Maximum = LastRow(filter)
                    End If
                ElseIf GenSearchControl1.filtro.SelectedValue.ToString = "System.DateTime" Then
                    If FirstRow(filter) Is DBNull.Value Then
                        .DateValue.MinDate = "1/1/1900"
                        .MaxDateValue.MinDate = "1/1/1900"
                    Else
                        .DateValue.MinDate = CDate(FirstRow(filter))
                        .MaxDateValue.MinDate = CDate(FirstRow(filter))
                    End If

                    If LastRow(filter) Is DBNull.Value Then
                        .DateValue.MaxDate = "31/12/2037"
                        .MaxDateValue.MaxDate = "31/12/2037"
                    Else
                        .DateValue.MaxDate = CDate(LastRow(filter))
                        .MaxDateValue.MaxDate = CDate(LastRow(filter))
                    End If
                End If
            End If
        End With
    End Sub

    Private Sub vista_n_customtable_events() Handles GenSearchControl1.CVistaIndexTextChanged, CustomTable.LinkClicked
        ExecuteQuery(GenSearchControl1.vista.Text)
    End Sub

    'CUSTOM QUERY
    Private Sub CustomQuery_KeyUp(sender As Object, e As KeyEventArgs) Handles CustomQuery.KeyUp
        CustomQuery.Text = Trim(CustomQuery.Text)
        If e.KeyValue = Keys.Enter And Len(CustomQuery.Text) > 5 Then
            Dim dtab As DataTable = DbMan.ReadDB(CustomQuery.Text, Connection.Text)
            CtrlMan.DataGridViewTools.Load(QueryView, dtab)
            CustomQuery.Items.Insert(0, CustomQuery.Text)
            CustomQuery.Text = ""
        End If
    End Sub

    'Connections
    Private Sub DBFoxMuniciToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DBFoxMuniciToolStripMenuItem.Click
        Connection.Text = My.Settings.foxConnection
    End Sub
    Private Sub DBAccessToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DBAccessToolStripMenuItem.Click
        Connection.Text = My.Settings.AdbConnection
    End Sub
    Private Sub DBPostgreSQLToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles DBPostgreSQLToolStripMenuItem.Click
        Connection.Text = My.Settings.pgsqlCon_disabled
    End Sub

    'RUTINAS

    Private Sub ExecuteQuery(vista As String)
        Dim sql(5) As String

        If vista = "PERSONALIZADA" Then
            Dim TableName As String
            CustomTable.Enabled = True
            Dim dtab As New DataTable
            Do
                TableName = InputBox("Ingrese nombre de tabla.", "Ingresar Tabla")
                TableName = Trim(TableName)

                If Len(TableName) > 0 Then
                    dtab = DbMan.ReadDB("SELECT * FROM " & TableName, Connection.Text)
                Else
                    TableName = Nothing
                End If
            Loop Until TableName Is Nothing Or dtab Is Nothing = False
            dtab.Dispose()

            If TableName <> "" Then
                sql(0) = "SELECT * FROM " & TableName
                CustomTable.Text = TableName
            Else
                CustomTable.Text = "Seleccionar tabla.."
            End If
        ElseIf vista <> "" Then
            sql = Hacienda.BuildQuery(Connection.Text, vista)
        End If
        If sql(0) <> "" Then
            Dim LastQueryView As DataGridView = QueryView
            Dim LastQueryBS As BindingSource = bs_query
            Dim dtab As DataTable

            bs_query = New BindingSource
            dtab = DbMan.ReadDB(sql, Connection.Text)

            If dtab.Rows.Count > 0 Then
                bs_query.DataSource = dtab
                'Create filter with columns
                Dim ColumnList_bs As New BindingSource
                GenSearchControl1.filtro.Visible = False
                ColumnList_bs.DataSource = CtrlMan.Fill.GetColumnList(dtab.Columns)
                GenSearchControl1.filtro = CtrlMan.Fill.SetAutoComplete(GenSearchControl1.filtro, ColumnList_bs, "ColumnName", "DataType")
                'Fill with data
                CtrlMan.DataGridViewTools.Load(QueryView, bs_query)
                For Each str As String In sql
                    CustomQuery.Text &= " " & str
                Next
            Else
                'Retrieves last search
                CtrlMan.DataGridViewTools.Load(LastQueryView, LastQueryBS)
            End If
        Else
            GenSearchControl1.reset_search.PerformClick()
        End If
    End Sub

    Private Sub Search(sender As Object) Handles GenSearchControl1.CSearchClick

    End Sub
End Class