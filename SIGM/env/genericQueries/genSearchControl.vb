Public Class genSearchControl
	Inherits System.Windows.Forms.UserControl

	'Custom Events
	Public RowSelected As Boolean = False
	Public bsCustomFilter As String
    Public Event CSearch_Click(sender As Object)
    Public Event CReset_Click(sender As Object)
    Public Event CFilter()
    Public Event CVista_IndexTextChanged()
	Public Event CFiltro_IndexTextChanged()
	Public Event CKeyword_KeyUp(sender As Object, e As KeyEventArgs)
	Public Event CSelect(sender As Object, e As EventArgs)
    Public Event CCancel(sender As Object, e As EventArgs)
    Public Event CPrint()

    'Events
    Public Sub New()

		' This call is required by the designer.
		InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        DateValue.Value = Today
    End Sub

    Private Sub Vista_Events(sender As Object, e As EventArgs) Handles vista.SelectedIndexChanged
        'Avoid seeing this control if there are no options
        vista.Visible = vista.Items.Count > 1
        RaiseEvent CVista_IndexTextChanged() 'Load items
    End Sub

    'Visibility events
    Private Sub filtro_SelectedIndexnTextChanged(sender As Object, e As EventArgs) Handles filtro.SelectedIndexChanged, filtro.TextChanged
		bsCustomFilter = ""

        If filtro.Visible And filtro.SelectedIndex > -1 Then
            'String
            keyword.Visible = (filtro.SelectedValue.ToString = GetType(String).ToString)

            'Int and dec
            NumValue.Visible = (filtro.SelectedValue.ToString = GetType(Decimal).ToString) Or (filtro.SelectedValue.ToString = GetType(Integer).ToString)

            MaxNumValue.Visible = (NumValue.Visible) And (Condition.Text = "<->")

            'Date
            DateValue.Visible = (filtro.SelectedValue.ToString = GetType(Date).ToString)
            MaxDateValue.Visible = (DateValue.Visible) And (Condition.Text = "<->")

            If filtro.SelectedValue.ToString = GetType(Decimal).ToString Then
                NumValue.DecimalPlaces = 2
                MaxNumValue.DecimalPlaces = 2
            Else
                NumValue.DecimalPlaces = 0
                NumValue.DecimalPlaces = 0
            End If
            RaiseEvent CFiltro_IndexTextChanged()
        End If
        filtro.Visible = filtro.Items.Count > 0

	End Sub

    Private Sub NumValue_MaxNumValue_VisibleChanged(sender As Object, e As EventArgs) Handles NumValue.VisibleChanged, MaxNumValue.VisibleChanged
        If NumValue.Visible = False Or MaxNumValue.Visible = False Then
            Condition.SelectedIndex = -1
            If NumValue.Visible = False Then
                NumValue.Minimum = 0
                NumValue.Value = 0
                NumValue.Maximum = 1
            End If
            If MaxNumValue.Visible = False Then
                MaxNumValue.Minimum = 0
                MaxNumValue.Value = 0
                MaxNumValue.Maximum = 1
            End If
        End If
    End Sub
    Private Sub DateValue_MaxDateValue_VisibleChanged(sender As Object, e As EventArgs) Handles DateValue.VisibleChanged, MaxDateValue.VisibleChanged
        If DateValue.Visible = False Or MaxDateValue.Visible = False Then
            Condition.SelectedIndex = -1
            If DateValue.Visible = False Then
                DateValue.MinDate = "1/1/1899"
                DateValue.MaxDate = "1/1/2038"
                DateValue.Value = Today
            End If
            If MaxDateValue.Visible = False Then
                MaxDateValue.MinDate = "1/1/1899"
                MaxDateValue.MaxDate = "1/1/2038"
                MaxDateValue.Value = Today
            End If
        End If
    End Sub
	Private Sub keyword_VisibleChanged(sender As Object, e As EventArgs) Handles keyword.VisibleChanged
		Condition.SelectedIndex = -1
		If keyword.Visible = False Then
			keyword.ResetText()
			keyword.Items.Clear()
		End If
	End Sub

	Private Sub keyword_KeyUp(sender As Object, e As KeyEventArgs) Handles keyword.KeyUp
		If e.KeyValue = Keys.Enter Or e.KeyValue = Keys.F3 Then
			search.PerformClick()
		End If
	End Sub

    Private Sub keyword_ClicknFocus(sender As Object, e As EventArgs) Handles keyword.DoubleClick
        If keyword.Visible Then
            keyword.SelectAll()
        End If
    End Sub

    Public Sub FilterSearch()
        bsCustomFilter = ""
        If Len(filtro.Text) > 1 Then
            If keyword.Visible Then

                Trim(keyword.Text)
                If Len(keyword.Text) > 0 Then
                    bsCustomFilter = filtro.Text & " LIKE '%" & keyword.Text & "%'"
                End If
            ElseIf NumValue.Visible Then

                If filtro.SelectedValue = "System.Decimal" Or filtro.SelectedValue = "System.Integer" Then 'Dec or Int
                    If NumValue.Value <> Nothing Then

                        Dim NumValueString As String
                        NumValueString = Replace(NumValue.Value, ",", ".").ToString()
                        If Condition.Text = "<->" And MaxNumValue.Value <> Nothing Then

                            Dim maxValueString As String
                            maxValueString = Replace(MaxNumValue.Value, ",", ".").ToString()
                            bsCustomFilter = filtro.Text & "=>" & NumValueString & " AND " & filtro.Text & "<=" & maxValueString
                        Else
                            'bsCustomFilter = filtro.Text & Condition.Text & NumValueString
                            bsCustomFilter = filtro.Text & "=" & NumValueString
                        End If
                    End If
                End If
            ElseIf DateValue.Visible Then

                If filtro.SelectedValue = "System.DateTime" Or filtro.SelectedValue = "System.Date" Then 'Date
                    'Filter by full date
                    If last_connection = My.Settings.foxConnection Then 'Foxpro needs the en-US date format
                        If Condition.Text = "<->" Then
                            bsCustomFilter = filtro.Text & " => '" & DateValue.Value.ToShortDateString & "'
											 AND " & filtro.Text & " <= '" & MaxDateValue.Value.ToShortDateString & "'"
                        Else
                            bsCustomFilter = filtro.Text & Condition.Text & "='" & DateValue.Value.ToShortDateString & "'"
                        End If
                    Else
                        If Condition.Text = "<->" Then
                            bsCustomFilter = filtro.Text & " => '" & DateValue.Value.ToShortDateString & "'" &
                                                     " AND " & filtro.Text & " <= '" & MaxDateValue.Value.ToShortDateString & "'"
                        Else
                            'bsCustomFilter = filtro.Text & Condition.Text & "'" & DateValue.Value.ToShortDateString & "'"
                            bsCustomFilter = filtro.Text & "='" & DateValue.Value.ToShortDateString & "'"
                        End If
                    End If
                End If
            End If
            RaiseEvent CFilter()
        End If
    End Sub

    Private Sub search_Click(sender As Object, e As EventArgs) Handles search.Click
        RaiseEvent CSearch_Click(sender)
    End Sub

    Private Sub reset_search_Click(sender As Object, e As EventArgs) Handles reset_search.Click
        bsCustomFilter = ""
        filtro.SelectedIndex = -1
        vista.SelectedIndex = -1

        DateValue.MinDate = "1/1/1899"
        DateValue.MaxDate = "1/1/2038"
        DateValue.Value = Today
        MaxDateValue.MinDate = "1/1/1899"
        MaxDateValue.MaxDate = "1/1/2038"
        MaxDateValue.Value = Today

        keyword.Items.Clear()
        keyword.ResetText()

        NumValue.Minimum = 0
        NumValue.Value = 0
        NumValue.Maximum = 1
        MaxNumValue.Minimum = 0
        MaxNumValue.Value = 0
        MaxNumValue.Maximum = 1

        RaiseEvent CReset_Click(sender)
    End Sub

    Private Sub print_Click(sender As Object, e As EventArgs) Handles print.Click
        RaiseEvent CPrint()
    End Sub

    Private Sub selectRow_Click(sender As Object, e As EventArgs) Handles selectRow.Click
		RowSelected = True
		RaiseEvent CSelect(sender, e)
	End Sub

	Private Sub cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
		RaiseEvent CCancel(sender, e)
	End Sub

	'Routines and functions
	Private Sub Condition_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Condition.SelectedIndexChanged
		Condition.Visible = keyword.Visible.CompareTo(True)
		If Condition.Visible = False Then
			Condition.SelectedIndex = 0
		End If
		If Condition.Visible Then
			MaxDateValue.Visible = DateValue.Visible And Condition.Text.Contains("<->")
			MaxNumValue.Visible = NumValue.Visible And Condition.Text.Contains("<->")
		End If
		RaiseEvent CFiltro_IndexTextChanged()
	End Sub

End Class
