Public Class EditorSijCor
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub
    'EVENTOS
    Private Sub CargarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CargarToolStripMenuItem.Click
        Using od As New OpenFileDialog
            Dim result As DialogResult
            od.CheckFileExists = True
            od.Filter = "txt|*.txt"
            od.DefaultExt = ".txt"
            od.InitialDirectory = Environment.SpecialFolder.Desktop
            result = od.ShowDialog()
            If result = DialogResult.OK Then
                If od.FileName <> "" And Len(od.FileName) > 4 Then
                    CtrlMan.DataGridViewTools.Load(DataView, ConverterMan.SIJCORToDataTable(od.FileName))
                    path.Text = od.FileName
                End If
            End If
        End Using
    End Sub

    Private Sub GuardarComoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarComoToolStripMenuItem.Click
        path.Focus() 'Takes away the focus from the dataview, so it saves itself before writing the file
        Using sd As New SaveFileDialog
            Dim result As DialogResult
            sd.Filter = "txt|*.txt"
            sd.DefaultExt = ".txt"
            sd.InitialDirectory = Environment.SpecialFolder.Desktop
            sd.OverwritePrompt = True
            result = sd.ShowDialog()
            If result = DialogResult.OK Then
                If sd.FileName <> "" And Len(sd.FileName) > 4 Then
                    path.Text = ConverterMan.DataTableToSIJCOR(bs.DataSource, sd.FileName)
                End If
            End If
        End Using
    End Sub

    Private Sub Browse_Click(sender As Object, e As EventArgs) Handles browse.Click
        If path.Text <> "" Then
            Process.Start(path.Text)
        End If
    End Sub
End Class