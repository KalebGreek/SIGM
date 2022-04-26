Class ModMulta
    Public multa_id As Integer

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub Seleccionar()
        Dim nroBoleta As Double = CDbl(boleta.Text)
        boleta.Text = ""
        boleta.Enabled = True
        TabControl1.Enabled = False
        TabMultas1Boleta1.InitMe()
        TabMultas2Persona1.InitMe()
        TabMultas3Vehiculo1.InitMe()

        If nroBoleta > 2000000000 Then
            multa_id = Transito.Multas.VerificarBoleta(nroBoleta)
            If multa_id = 0 Then
                If MsgBoxResult.Yes = MsgBox("Desea generar una nueva boleta?", MsgBoxStyle.YesNo) Then
                    multa_id = Transito.Multas.Nueva(nroBoleta)
                    boleta.Text = nroBoleta
                End If
            Else
                Using dtab As DataTable = Transito.Multas.SeleccionarMulta(multa_id)
                    boleta.Text = dtab.Rows(0)("boleta")
                    TabMultas1Boleta1.LoadMe(dtab.Rows(0))
                    TabMultas2Persona1.LoadMe(dtab.Rows(0))
                    TabMultas3Vehiculo1.LoadMe(dtab.Rows(0))
                End Using
            End If
        End If

        TabControl1.Enabled = (multa_id > 0)
    End Sub

    ' GUI
    Private Sub BuscarMulta_Click(sender As Object, e As EventArgs) Handles BuscarMulta.Click
        Seleccionar()
    End Sub

    Private Sub Boleta_KeyUp(sender As Object, e As KeyEventArgs) Handles boleta.KeyUp
        If e.KeyValue = Keys.Enter Then
            Seleccionar()
        End If
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
        If MsgBoxResult.Yes = MsgBox("Se perderán los cambios, desea continuar?", MsgBoxStyle.YesNo) Then
            Me.Close()
        End If
    End Sub

    Private Sub LastPage_Click(sender As Object, e As EventArgs) Handles lastPage.Click
        With TabControl1
            Transito.Multas.Actualizar(TabMultas1Boleta1, TabMultas2Persona1, TabMultas3Vehiculo1,
                                       multa_id, boleta.Text, True)

            If .SelectedIndex > 0 Then
                .SelectTab(.SelectedIndex - 1)
            End If
        End With
    End Sub

    Private Sub NextPage_Click(sender As Object, e As EventArgs) Handles nextPage.Click
        With TabControl1
            Dim valid As Boolean = Transito.Multas.Actualizar(TabMultas1Boleta1, TabMultas2Persona1, TabMultas3Vehiculo1,
                                                              multa_id, boleta.Text, .SelectedIndex < .TabCount - 1)

            If .SelectedIndex < .TabCount - 1 Then
                .SelectTab(.SelectedIndex + 1)
            ElseIf valid Then
                Me.Close()
            End If
        End With
    End Sub

    Private Sub TabControl1_EnabledChanged(sender As Object, e As EventArgs) Handles TabControl1.EnabledChanged
        FlowLayoutPanel2.Enabled = TabControl1.Enabled.CompareTo(True)
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        subtitulo.Text = TabControl1.SelectedTab.Text
        lastPage.Enabled = TabControl1.SelectedIndex > 0

        If TabControl1.SelectedIndex = TabControl1.TabCount - 1 Then
            nextPage.Text = "Guardar"
        Else
            nextPage.Text = "Siguiente >"
        End If
    End Sub

End Class