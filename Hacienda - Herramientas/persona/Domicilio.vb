Public Class Domicilio
    Public Class sql
        Shared Function RellenarProvincias() As BindingSource
            Dim bs As New BindingSource
            sel_sql = "Select provincia_id, provincia FROM provincias ORDER BY provincia"
            bs.DataSource = bd.leer(defcon, sel_sql)
            Return bs
        End Function
        Shared Function RellenarLocalidades(provincia_id As Integer) As BindingSource
            Dim bs As New BindingSource
            sel_sql = "Select id, localidad, cp" &
                      " FROM provincias INNER JOIN localidades On provincias.provincia_id = localidades.provincia_id" &
                      " WHERE localidades.provincia_id=" & provincia_id & " ORDER BY localidad"
            bs.DataSource = bd.leer(defcon, sel_sql)
            Return bs
        End Function
        Shared Function Listar(persona_id As Integer) As DataTable
            sel_sql = "SELECT per_domicilio.id, per_domicilio.calle, per_domicilio.altura," &
                     " per_domicilio.piso, per_domicilio.dpto, per_domicilio.principal," &
                     " per_domicilio.localidad_id, localidades.localidad, provincias.provincia" &
                     " FROM provincias INNER JOIN (per_domicilio" &
                     " INNER JOIN localidades ON per_domicilio.localidad_id = localidades.id)" &
                     " ON provincias.provincia_id = localidades.provincia_id"

            sel_sql += " WHERE per_domicilio.per_id=" & persona_id & " ORDER BY per_domicilio.id"
            Return bd.leer(defcon, sel_sql)
        End Function
        Shared Function Nuevo(persona_id As Integer, calle As String, altura As Integer, piso As Integer,
                              dpto As String, localidad_id As Integer, principal As Boolean) As String
            Dim sql _
                As String = "INSERT INTO per_domicilio(per_id, calle, altura, piso, dpto, localidad_id, principal)" &
                           " VALUES(" & persona_id & ", '" & calle & "', " & altura & ", " & piso & "," &
                           " '" & dpto & "', " & localidad_id & ", " & principal & ")"
            Return sql
        End Function
        Shared Function Eliminar(persona_id As Integer, Optional domicilio_id As Integer = 0) As String
            Dim sql As String = "DELETE * FROM per_domicilio WHERE per_id=" & persona_id
            If domicilio_id > 0 Then
                mod_sql += " AND id=" & domicilio_id
            End If
            Return sql
        End Function
    End Class
    Public Class Tab
        Inherits TabPage
        Public Label2 As New Label()
        Public Label3 As New Label()
        Public Label4 As New Label()
        Public Label6 As New Label()
        Public Label9 As New Label()
        Public Label10 As New Label()
        Public Label12 As New Label()
        Public calle As New TextBox()
        Public altura As New NumericUpDown()
        Public piso As New NumericUpDown()
        Public dpto As New TextBox()
        Public cp As New TextBox()
        Public WithEvents provincia As New ComboBox
        Public WithEvents localidad As New ComboBox

        Public Sub localidad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles localidad.SelectedIndexChanged
            With localidad
                If .DataSource Is Nothing = False And .SelectedIndex > -1 Then
                    cp.Text = .DataSource(.SelectedIndex)("cp")
                Else
                    cp.Text = ""
                End If
            End With
        End Sub
        Public Sub provincia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles provincia.SelectedIndexChanged
            If provincia.DataSource Is Nothing = False And provincia.SelectedIndex > -1 Then
                localidad.DataSource = Domicilio.sql.RellenarLocalidades(Val(provincia.SelectedValue.ToString))
                localidad.DisplayMember = "localidad"
                localidad.ValueMember = "id"
            End If
        End Sub

        Public Sub New(contador As Integer, id As Integer, Optional ValorCalle As String = "",
                       Optional ValorAltura As Integer = 0, Optional ValorPiso As Integer = 0,
                       Optional ValorDpto As String = "0")
            '
            'Label12
            '
            Label12.AutoSize = True
            Label12.Font = New Font("PF DinDisplay Pro", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Label12.Location = New Point(43, 15)
            Label12.Margin = New Padding(4, 0, 4, 0)
            Label12.Size = New Size(41, 19)
            Label12.TabIndex = 247
            Label12.Text = "Calle"
            Label12.Name = "Label12" & contador
            '
            'calle
            '
            calle.CharacterCasing = CharacterCasing.Upper
            calle.Font = New Font("PF DinDisplay Pro", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            calle.Location = New Point(87, 14)
            calle.Margin = New Padding(4)
            calle.MaxLength = 64
            calle.Name = "calle"
            calle.Size = New Size(302, 27)
            calle.TabIndex = 248
            calle.Text = ValorCalle
            '
            'Label10
            '
            Label10.Font = New Font("PF DinDisplay Pro", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Label10.Location = New Point(392, 12)
            Label10.Margin = New Padding(4, 0, 4, 0)
            Label10.Name = "Label10"
            Label10.Size = New Size(50, 31)
            Label10.TabIndex = 257
            Label10.Text = "Altura"
            Label10.TextAlign = ContentAlignment.MiddleCenter
            '
            'altura
            '
            altura.Font = New Font("PF DinDisplay Pro", 13.0!)
            altura.Location = New Point(425, 14)
            altura.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
            altura.Name = "altura"
            altura.Size = New Size(81, 28)
            altura.TabIndex = 258
            altura.TextAlign = HorizontalAlignment.Right
            altura.UpDownAlign = LeftRightAlignment.Left
            altura.Value = ValorAltura
            '
            'Label9
            '
            Label9.AutoSize = True
            Label9.Font = New Font("PF DinDisplay Pro", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Label9.Location = New Point(297, 86)
            Label9.Margin = New Padding(4, 0, 4, 0)
            Label9.Name = "Label9"
            Label9.Size = New Size(34, 19)
            Label9.TabIndex = 256
            Label9.Text = "C. P."
            '
            'cp
            '
            cp.Enabled = False
            cp.Font = New Font("PF DinDisplay Pro", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            cp.Location = New Point(333, 82)
            cp.Margin = New Padding(4)
            cp.MaxLength = 2
            cp.Name = "cp"
            cp.Size = New Size(56, 27)
            cp.TabIndex = 255
            '
            'provincia
            '
            provincia.AutoCompleteMode = AutoCompleteMode.Suggest
            provincia.AutoCompleteSource = AutoCompleteSource.ListItems
            provincia.DropDownStyle = ComboBoxStyle.DropDownList
            provincia.Font = New Font("PF DinDisplay Pro", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            provincia.Location = New Point(87, 82)
            provincia.Margin = New Padding(4)
            provincia.Name = "provincia"
            provincia.Size = New Size(199, 27)
            provincia.TabIndex = 254
            '
            'Label4
            '
            Label4.AutoSize = True
            Label4.Font = New Font("PF DinDisplay Pro", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Label4.Location = New Point(11, 52)
            Label4.Margin = New Padding(4, 0, 4, 0)
            Label4.Name = "Label4"
            Label4.Size = New Size(73, 19)
            Label4.TabIndex = 250
            Label4.Text = "Localidad"
            '
            'localidad
            '
            localidad.AutoCompleteMode = AutoCompleteMode.Suggest
            localidad.AutoCompleteSource = AutoCompleteSource.ListItems
            localidad.DropDownStyle = ComboBoxStyle.DropDownList
            localidad.Font = New Font("PF DinDisplay Pro", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            localidad.Location = New Point(87, 48)
            localidad.Margin = New Padding(4)
            localidad.Name = "localidad"
            localidad.Size = New Size(199, 27)
            localidad.TabIndex = 246
            '
            'dpto
            '
            dpto.Font = New Font("PF DinDisplay Pro", 13.0!)
            dpto.Location = New Point(441, 50)
            dpto.Margin = New Padding(4)
            dpto.MaxLength = 2
            dpto.Name = "dpto"
            dpto.Size = New Size(64, 28)
            dpto.TabIndex = 253
            dpto.Text = ValorDpto
            dpto.TextAlign = HorizontalAlignment.Right
            '
            'Label2
            '
            Label2.AutoSize = True
            Label2.Font = New Font("PF DinDisplay Pro", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Label2.Location = New Point(396, 52)
            Label2.Margin = New Padding(4, 0, 4, 0)
            Label2.Name = "Label2"
            Label2.Size = New Size(43, 19)
            Label2.TabIndex = 252
            Label2.Text = "Dpto."
            '
            'Label3
            '
            Label3.Font = New Font("PF DinDisplay Pro", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Label3.Location = New Point(297, 45)
            Label3.Margin = New Padding(4, 0, 4, 0)
            Label3.Name = "Label3"
            Label3.Size = New Size(37, 33)
            Label3.TabIndex = 251
            Label3.Text = "Piso"
            Label3.TextAlign = ContentAlignment.MiddleCenter
            '
            'Label6
            '
            Label6.AutoSize = True
            Label6.Font = New Font("PF DinDisplay Pro", 12.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Label6.Location = New Point(15, 86)
            Label6.Margin = New Padding(4, 0, 4, 0)
            Label6.Name = "Label6"
            Label6.Size = New Size(69, 19)
            Label6.TabIndex = 249
            Label6.Text = "Provincia"

            '
            'piso
            '
            piso.Anchor = AnchorStyles.None
            piso.Font = New Font("PF DinDisplay Pro", 13.0!)
            piso.Location = New Point(178, 38)
            piso.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
            piso.Name = "piso"
            piso.Size = New Size(56, 27)
            piso.TabIndex = 259
            piso.TextAlign = HorizontalAlignment.Center
            piso.UpDownAlign = LeftRightAlignment.Right
            '
            BackColor = Color.Silver
            Controls.Add(Label10)
            Controls.Add(altura)
            Controls.Add(Label9)
            Controls.Add(cp)
            Controls.Add(provincia)
            Controls.Add(localidad)
            Controls.Add(dpto)
            Controls.Add(Label2)
            Controls.Add(Label3)
            Controls.Add(Label4)
            Controls.Add(Label6)
            Controls.Add(calle)
            Controls.Add(Label12)
            Controls.Add(piso)
            Location = New Point(4, 28)
            Name = "TabDomicilio" & contador
            Padding = New Padding(3)
            Size = New Size(511, 120)
            TabIndex = 0
            Text = "Domicilio " & contador
        End Sub
    End Class
End Class