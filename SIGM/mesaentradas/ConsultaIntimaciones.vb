﻿Imports Microsoft.Reporting.WinForms
Public Class ConsultaIntimaciones
    Property PaletaIntimaciones As New List(Of Color)

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        PaletaIntimaciones.AddRange({visor_contribuyente.DefaultCellStyle.BackColor, Color.Firebrick, Color.Tomato, Color.Goldenrod, Color.Plum, Color.CornflowerBlue, Color.DarkSeaGreen})

        estado6.BackColor = PaletaIntimaciones(1) 'JUDICIAL
        estado5.BackColor = PaletaIntimaciones(2) 'PRE-JUDICIAL
        estado4.BackColor = PaletaIntimaciones(3) 'CARTA DOCUMENTO
        estado3.BackColor = PaletaIntimaciones(4) 'EN MORA
        estado2.BackColor = PaletaIntimaciones(5) 'CONTACTADO
        estado1.BackColor = PaletaIntimaciones(6) 'PLAN DE PAGOS

        GenSearchControl1.vista.Items.AddRange(New Object() {"aguas", "automovil", "barrios", "catastro", "comercio", "sepelio"})
    End Sub
    'Routines
    Private Sub Consultar(clearFilter As Boolean)
        With GenSearchControl1
            Dim sql(4) As String
            Dim tabla_persona, tabla_deuda As String
            Dim dtab As New DataTable
            Dim bs_ColumnList As New BindingSource

            tablas_fox(GenSearchControl1.vista.Text)
            tabla_persona = ext_persona
            tabla_deuda = ext_cuenta

            'aguas, barrios, catastro, sepelio posee "Razón" y "Tenedor"
            If .vista.Text <> "comercio" And .vista.Text <> "automovil" Then
                sql(0) = "SELECT " & tabla_persona & ".codigo as codigo, 
                         " & tabla_persona & ".razon as titular,
                         " & tabla_persona & ".tenedor as tenedor,
                         docume, telefono, mail, 
                         calle, localidad, provincia,
                         SUM(" & col_importe & ") as deuda, intima2.estado"

            ElseIf .vista.Text = "automovil" Then
                sql(0) = "SELECT " & tabla_persona & ".codigo as codigo , 
                         " & tabla_persona & ".razon as titular, 
                         letrahoy, numerohoy, anterior, 
                         docume, telefono, mail, 
                         calle, localidad, provincia,
                         SUM(" & col_importe & ") as deuda, intima2.estado"
            ElseIf .vista.Text = "comercio" Then
                sql(0) = "SELECT " & tabla_persona & ".codigo as codigo , 
                         " & tabla_persona & ".razon as titular, 
                         docume, telefono, mail, 
                         domicilio as calle, localidad,
                         SUM(" & col_importe & ") as deuda, intima2.estado"
            End If

            sql(1) = " FROM (" & tabla_persona & " 
                         INNER JOIN " & tabla_deuda & " ON " & tabla_persona & ".codigo = " & tabla_deuda & ".codigo) 
                         LEFT JOIN (SELECT codigo, ingreso, estado
	                                   FROM (SELECT codigo as codigo1, MAX(ingreso) as ingreso1 
			                                   FROM hac_intimaciones GROUP BY codigo) AS intima1 
                                 INNER JOIN hac_intimaciones ON intima1.codigo1=hac_intimaciones.codigo AND intima1.ingreso1=hac_intimaciones.ingreso
                                      WHERE servicio='" & tabla_persona & "') as intima2 
                                 ON " & tabla_persona & ".codigo=intima2.codigo"

            sql(2) = "WHERE " & col_pagado & "=0"

            If .vista.Text <> "comercio" And .vista.Text <> "automovil" Then
                sql(3) = "GROUP BY " & tabla_persona & ".codigo, " & tabla_persona & ".razon, 
                                       " & tabla_persona & ".tenedor, 
                                       docume, telefono, mail,  
                                       calle, localidad, provincia, postal,
                                       intima2.estado"

            ElseIf .vista.Text = "automovil" Then
                sql(3) = "GROUP BY " & tabla_persona & ".codigo, " & tabla_persona & ".razon, 
                                       letrahoy, numerohoy, anterior, 
                                       docume, telefono, mail,  
                                       calle, localidad, provincia, postal, intima2.estado"

            Else 'comercio
                sql(3) = "GROUP BY " & tabla_persona & ".codigo, " & tabla_persona & ".razon, 
                                       docume, telefono, mail,
                                       domicilio, localidad,
                                       intima2.estado"
            End If

            sql(4) = "ORDER BY " & tabla_persona & ".razon"

            dtab = DbMan.ReadDB(sql, My.Settings.foxConnection)

            visor_contribuyente.DataSource = Nothing
            bs_contribuyente = New BindingSource
            If clearFilter Then
                .bsCustomFilter = ""
            End If

            If dtab.Rows.Count > 0 Then
                bs_contribuyente.DataSource = dtab

                bs_ColumnList.DataSource = CtrlMan.Fill.GetColumnList(dtab.Columns)
                .filtro.DataSource = Nothing
                .filtro = CtrlMan.Fill.SetAutoComplete(.filtro, bs_ColumnList, "ColumnName", "DataType")
                .filtro.Text = "titular"
                .FilterSearch()
                bs_contribuyente.Filter = .bsCustomFilter

                CtrlMan.DataGridViewTools.Load(visor_contribuyente, bs_contribuyente)
            Else
                bs_contribuyente.DataSource = Nothing
            End If
        End With
    End Sub
    'Search Box events

    Sub Buscar() Handles GenSearchControl1.CSearchClick, GenSearchControl1.CFiltroIndexTextChanged
        GenSearchControl1.FilterSearch()
        bs_contribuyente.Filter = GenSearchControl1.bsCustomFilter
    End Sub


    Private Sub Vista_SelectedIndexChanged() Handles GenSearchControl1.CVistaIndexTextChanged

        If Me.Visible And GenSearchControl1.vista.SelectedIndex > -1 Then
            Consultar(True)
        Else
            GenSearchControl1.reset_search.PerformClick()
        End If
    End Sub

    Private Sub FlowLayoutPanel2_VisibleChanged(sender As Object, e As EventArgs) Handles FlowLayoutPanel2.VisibleChanged
        opcion_aviso.SelectedIndex = 0
    End Sub


    'BS and DGV Events
    Private Sub Bs_contribuyente_CurrentChanged(sender As Object, e As EventArgs) Handles bs_contribuyente.CurrentChanged,
                                                                                          bs_contribuyente.PositionChanged,
                                                                                          bs_contribuyente.DataSourceChanged

        FlowLayoutPanel2.Enabled = GenSearchControl1.vista.SelectedIndex > -1 And bs_contribuyente.Count > 0 And bs_contribuyente.Position > -1
    End Sub
    Private Sub Visor_contribuyente_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles visor_contribuyente.RowsAdded
        If bs_contribuyente Is Nothing = False And visor_contribuyente.Rows.Count = bs_contribuyente.Count Then
            With bs_contribuyente
                Dim ColorValue(bs_contribuyente.Count - 1) As Color
                Dim count As Integer = 0
                progreso.Value = 0
                progreso.Maximum = bs_contribuyente.Count + 1

                For Each drv As DataRowView In bs_contribuyente.List
                    Dim state As String = ""
                    If drv("estado") Is DBNull.Value = False Then
                        state = Trim(drv("estado"))
                    End If
                    If state = "JUDICIAL" Then
                        ColorValue(count) = PaletaIntimaciones(1)
                    ElseIf state = "PRE-JUDICIAL" Then
                        ColorValue(count) = PaletaIntimaciones(2)
                    ElseIf state = "CARTA DOCUMENTO" Then
                        ColorValue(count) = PaletaIntimaciones(3)
                    ElseIf state = "EN MORA" Then
                        ColorValue(count) = PaletaIntimaciones(4)
                    ElseIf state = "CONTACTADO" Then
                        ColorValue(count) = PaletaIntimaciones(5)
                    ElseIf state = "PLAN DE PAGO" Then
                        ColorValue(count) = PaletaIntimaciones(6)
                    End If

                    count += 1
                    progreso.Value = count
                Next

                CtrlMan.DataGridViewTools.Paint(visor_contribuyente, bs_contribuyente, Nothing, ColorValue)
                progreso.Value += 1
            End With
        End If
    End Sub
    'DGView Events
    Private Sub Visor_Contribuyente_KeyUp(sender As Object, e As KeyEventArgs) Handles visor_contribuyente.KeyUp
        If e.KeyValue = Keys.F2 Then
            historialInt.PerformClick()
        End If
    End Sub

    'GUI
    Private Sub NuevaInt_Click(sender As Object, e As EventArgs) Handles nuevaInt.Click
        If GenSearchControl1.vista.SelectedIndex > -1 Then
            Using modInt As New ModIntimaciones(GenSearchControl1.vista.Text, 0) _
                With {.Text = "Nueva Intimación"}

                modInt.ShowDialog(Me)
            End Using
            Consultar(False)
        End If
    End Sub

    Private Sub HistorialInt_Click(sender As Object, e As EventArgs) Handles historialInt.Click
        Dim source As DataRowView = bs_contribuyente.Current
        If source Is Nothing = False And GenSearchControl1.vista.SelectedIndex > -1 Then
            Using modInt As New ModIntimaciones(GenSearchControl1.vista.Text, Val(source("codigo"))) _
               With {.Text = "Historial para Cta. " & source("codigo").ToString & " 
                                | " & source("titular").ToString}

                modInt.ShowDialog(Me)
            End Using
            Consultar(False)
        End If

    End Sub

    Private Sub Print_Click(sender As Object, e As EventArgs) Handles print.Click
        Dim source As DataRowView = bs_contribuyente.Current
        If source Is Nothing = False And GenSearchControl1.vista.SelectedIndex > -1 Then
            Dim parametros As New List(Of ReportParameter)
            Dim tenedor As String = ""
            Dim direccion As String = Trim(source("calle")) & ", " & Trim(source("localidad"))
            If GenSearchControl1.vista.Text <> "comercio" And
                GenSearchControl1.vista.Text <> "automovil" Then
                tenedor = Trim(source("tenedor"))
                direccion &= ", " & Trim(source("provincia"))
            End If

            parametros = ParametrosReporte.Intimaciones.DetalleIntimacion(parametros, GenSearchControl1.vista.Text,
                                                                     source("codigo"), opcion_aviso.SelectedIndex, Trim(source("titular")),
                                                                     tenedor, direccion, Today)

            Dim titulo_reporte As String = "Intimación " & GenSearchControl1.vista.Text & " - Cta. N° " & source("codigo").ToString
            Dim ruta_acceso As String = "REPORTES\HACIENDA\INTIMA"
            Using certificado As New Formularios(titulo_reporte)
                certificado.Mostrar(ruta_acceso, parametros)
                certificado.ShowDialog()
            End Using
        End If

    End Sub


End Class