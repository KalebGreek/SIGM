﻿Imports System.ComponentModel
Public Class ModCombustibleTicket
    Inherits System.Windows.Forms.Form

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        fecha.Value = Today
        fecha.MaxDate = Today

        'Cargar items de ejemplo
        TipoItem = Combustible.Item.FillTypeList(bs_tipo_item, TipoItem, "descripcion", "tipo_id")
    End Sub

    'Rutinas
    'TICKET
    Public Sub NewTicket(ReceptorID As Integer)
        receptor_id.Text = ReceptorID
        Combustible.Ticket.SaveTicket(0, proveedor_id.Text, responsable.SelectedValue, fecha.Value, ticket.Text)

        ticket_id.Text = Combustible.Ticket.ReturnLastTicketID()
        LoadTicket(ticket_id.Text)
    End Sub

    Public Sub LoadTicket(id As Integer)
        If id > 0 Then
            ticket_id.Text = id
            Using dtab As DataTable = Combustible.Ticket.SelectTicket(id)
                'Cargar ticket
                If dtab.Rows.Count > 0 Then
                    CtrlMan.LoadControlData(dtab, Me)
                    Combustible.Ticket.Detail(DetalleTicket, bs_item_ticket, ticket_id.Text)
                End If
            End Using
        End If
    End Sub

    'Eventos
    'GUI
    Private Sub Cerrar_Click(sender As Object, e As EventArgs) Handles cerrar.Click
        If MsgBoxResult.Yes = MsgBox("No se guardaran los cambios, desea continuar?", MsgBoxStyle.YesNo) Then
            Me.Close()
        End If
    End Sub

    'Receptor
    Private Sub Receptor_id_TextChanged(sender As Object, e As EventArgs) Handles receptor_id.TextChanged
        If receptor_id.Text > 0 Then
            Using dtab As DataTable = Combustible.Receptor.Seleccionar(receptor_id.Text)
                receptor_categoria.Text = dtab.Rows(0)("detalle")
                receptor_marca_observaciones.Text = dtab.Rows(0)("marca").ToString & " " & dtab.Rows(0)("observaciones").ToString
                receptor_modelo.Text = dtab.Rows(0)("modelo").ToString()
                receptor_dominio.Text = dtab.Rows(0)("dominio")
            End Using
            'Cargar responsable
            Combustible.Responsable.Fill(bs_responsable, responsable, receptor_id.Text)
        Else
            receptor_marca_observaciones.Text = ""
            responsable.DataSource = Nothing
        End If
    End Sub
    Private Sub SelectReceptor_Click(sender As Object, e As EventArgs) Handles SelectReceptor.Click

    End Sub

    'Proveedor
    Private Sub Proveedor_id_TextChanged(sender As Object, e As EventArgs) Handles proveedor_id.TextChanged
        Dim drow As DataRow
        If proveedor_id.Text > 0 Then
            drow = Proveedor.Seleccionar(proveedor_id.Text, 0)
            proveedor_razon.Text = drow("razon")
            proveedor_cuil.Text = drow("cuil")
        Else
            proveedor_razon.Clear()
            proveedor_cuil.Clear()
        End If
    End Sub
    Private Sub SelectProveedor_Click(sender As Object, e As EventArgs) Handles SelectProveedor.Click
        Dim source As DataRowView = Persona.Seleccionar(Me, "PROVEEDOR")
        If source Is Nothing Then
            proveedor_razon.Text = source("razon")
            proveedor_cuil.Text = source("cuil")
            proveedor_id.Text = source("proveedor_id")
        End If
    End Sub

    'Ticket
    Private Sub SaveTicket_Click(sender As Object, e As EventArgs) Handles Save.Click, SaveAdd.Click
        If MsgBoxResult.Yes = MsgBox("Desea guardar este ticket?", MsgBoxStyle.YesNo, "Guardar Ticket") Then
            If CtrlMan.Validate(Me) Then
                If bs_item_ticket.Count > 0 Then
                    'Save ticket
                    If Combustible.Ticket.SaveTicket(ticket_id.Text, proveedor_id.Text, responsable.SelectedValue,
                                                     fecha.Value, ticket.Text) Then
                        If sender Is SaveAdd Then
                            NewTicket(receptor_id.Text)
                        Else
                            Me.Close()
                        End If
                    End If
                Else
                    MsgBox("Ingrese un producto para continuar.", MsgBoxStyle.OkOnly)
                End If
            End If
        End If
    End Sub

    'ITEMS
    Private Sub Bs_item_ticket_ListChanged(sender As Object, e As ListChangedEventArgs) Handles bs_item_ticket.ListChanged
        Dim total As Decimal = 0
        If bs_item_ticket.Count > 0 Then
            For Each dr As DataRow In bs_item_ticket.DataSource.Rows
                total += CDec(dr("monto"))
            Next
        End If

        DbMan.EditDB("UPDATE hac_combustible_ticket 
						 SET total=" & Replace(total, ",", ".") & "
					   WHERE id=" & ticket_id.Text, My.Settings.CurrentDB)

        monto_total.Text = " $ " & total
    End Sub
    Private Sub Bs_tipo_item_CurrentChanged(sender As Object, e As EventArgs) Handles bs_tipo_item.CurrentChanged,
                                                                                      bs_tipo_item.PositionChanged
        If bs_tipo_item.Position > -1 Then
            If bs_tipo_item.Current("por_litro") Then
                et_litros_unidades.Text = "Litros"
            Else
                et_litros_unidades.Text = "Unidades"
            End If
        End If
    End Sub
    Private Sub NewItemType_Click(sender As Object, e As EventArgs) Handles NewItemType.Click
        Dim nuevo_tipo As String = ""
        Dim por_litro As Boolean = True

        nuevo_tipo = InputBox("Ingrese nombre de nuevo item.")
        If nuevo_tipo <> Nothing Then
            nuevo_tipo = Trim(nuevo_tipo)
            If Len(nuevo_tipo) > 2 Then
                If nuevo_tipo <> "OTRO POR LITRO" And nuevo_tipo <> "OTRO" Then
                    por_litro = (MsgBoxResult.Yes = MsgBox("Este item se cuantifica por litro?", MsgBoxStyle.YesNo))

                    DbMan.EditDB("INSERT INTO hac_combustible_tipo(descripcion, por_litro)
									   VALUES(" & nuevo_tipo & ", " & por_litro & ")",
                                 My.Settings.CurrentDB)

                    MsgBox("Item agregado.", MsgBoxStyle.OkOnly)
                End If
            End If
        End If
    End Sub
    Private Sub DelItemType_Click(sender As Object, e As EventArgs) Handles DelItemType.Click
        If bs_tipo_item.Position > -1 Then
            If TipoItem.Text <> "OTRO POR LITRO" And TipoItem.Text <> "OTRO" Then
                If MsgBoxResult.Yes = MsgBox("Desea eliminar este item? Los items incluidos se moveran a la
											  categoria 'OTRO POR LITRO' u 'OTRO', segun su tipo.",
                                              MsgBoxStyle.YesNo) Then

                    Dim sqlModify(1) As String
                    If bs_tipo_item.Current("por_litro") Then
                        sqlModify(0) = "UPDATE hac_combustible_items SET tipo_combustible_id=1 
										 WHERE tipo_combustible=" & TipoItem.SelectedValue.ToString
                    Else
                        sqlModify(0) = "UPDATE hac_combustible_items SET tipo_combustible_id=6 
										   WHERE tipo_combustible=" & TipoItem.SelectedValue.ToString
                    End If
                    sqlModify(1) = "DELETE * FROM hac_combustible_tipo WHERE id=" & TipoItem.SelectedValue.ToString

                    DbMan.EditDB(sqlModify, My.Settings.CurrentDB)

                    MsgBox("Item eliminado.", MsgBoxStyle.OkOnly)
                End If
            End If
        End If
    End Sub
    Private Sub AddNewItem_Click(sender As Object, e As EventArgs) Handles AddNewItem.Click
        Dim litros As Integer = 0
        Dim unidades As Integer = 0
        Dim unitario As String = Replace(MontoItem.Value, ",", ".")

        If bs_tipo_item.Position > -1 And MontoItem.Value > 0 And LitrosItem.Value > 0 Then
            If bs_tipo_item.Current("por_litro") Then
                litros = LitrosItem.Value
            Else
                unidades = LitrosItem.Value
            End If

            DbMan.EditDB("INSERT INTO hac_combustible_items(ticket_id, tipo_item_id, litros, unidades, monto, user_id)
							   VALUES(" & ticket_id.Text & "," & bs_tipo_item.Current("tipo_id").ToString & ",
									  " & litros & ", " & unidades & ", " & unitario & ",
									  " & My.Settings.UserId & ")",
                         My.Settings.CurrentDB)

            MontoItem.Value = 0
            LitrosItem.Value = 0
        End If
        Combustible.Ticket.Detail(DetalleTicket, bs_item_ticket, ticket_id.Text)
    End Sub
    Private Sub DelItem_Click(sender As Object, e As EventArgs)
        If bs_item_ticket.Position > -1 Then
            If MsgBoxResult.Yes = MsgBox("Desea eliminar este item?", MsgBoxStyle.YesNo, "Eliminar Item") Then
                DbMan.EditDB("DELETE * FROM hac_combustible_items WHERE id=" & bs_item_ticket.Current("item_id").ToString,
                             My.Settings.CurrentDB)
                Combustible.Ticket.Detail(DetalleTicket, bs_item_ticket, ticket_id.Text)
            End If
        End If
    End Sub

End Class
