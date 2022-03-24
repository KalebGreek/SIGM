<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class calcTMuniObrasVarias
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.costo = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.metros_frente = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.metros_calle = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.monto_subtotal = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.desc_porcentaje = New System.Windows.Forms.NumericUpDown()
        Me.monto_descuento = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cuotas = New System.Windows.Forms.NumericUpDown()
        Me.monto_cuota = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.total = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.costo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.metros_frente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.metros_calle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.desc_porcentaje, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cuotas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.Label1)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label2)
        Me.FlowLayoutPanel1.Controls.Add(Me.costo)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label3)
        Me.FlowLayoutPanel1.Controls.Add(Me.metros_frente)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label4)
        Me.FlowLayoutPanel1.Controls.Add(Me.metros_calle)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label7)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label32)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label42)
        Me.FlowLayoutPanel1.Controls.Add(Me.monto_subtotal)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label9)
        Me.FlowLayoutPanel1.Controls.Add(Me.desc_porcentaje)
        Me.FlowLayoutPanel1.Controls.Add(Me.monto_descuento)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label10)
        Me.FlowLayoutPanel1.Controls.Add(Me.cuotas)
        Me.FlowLayoutPanel1.Controls.Add(Me.monto_cuota)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label13)
        Me.FlowLayoutPanel1.Controls.Add(Me.total)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(480, 240)
        Me.FlowLayoutPanel1.TabIndex = 51
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Gray
        Me.Label1.Font = New System.Drawing.Font("PF DinDisplay Pro", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(480, 25)
        Me.Label1.TabIndex = 418
        Me.Label1.Text = "OBRAS VARIAS"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(0, 25)
        Me.Label2.Margin = New System.Windows.Forms.Padding(0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(244, 20)
        Me.Label2.TabIndex = 55
        Me.Label2.Text = "Costo Frentista ($)"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'costo
        '
        Me.costo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.costo.DecimalPlaces = 2
        Me.costo.Location = New System.Drawing.Point(244, 25)
        Me.costo.Margin = New System.Windows.Forms.Padding(0)
        Me.costo.Maximum = New Decimal(New Integer() {10000000, 0, 0, 0})
        Me.costo.Name = "costo"
        Me.costo.Size = New System.Drawing.Size(209, 26)
        Me.costo.TabIndex = 56
        Me.costo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.costo.ThousandsSeparator = True
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(0, 51)
        Me.Label3.Margin = New System.Windows.Forms.Padding(0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(244, 20)
        Me.Label3.TabIndex = 57
        Me.Label3.Text = "Frente (Mts.)"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'metros_frente
        '
        Me.metros_frente.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.metros_frente.DecimalPlaces = 2
        Me.metros_frente.Location = New System.Drawing.Point(244, 51)
        Me.metros_frente.Margin = New System.Windows.Forms.Padding(0)
        Me.metros_frente.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.metros_frente.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.metros_frente.Name = "metros_frente"
        Me.metros_frente.Size = New System.Drawing.Size(209, 26)
        Me.metros_frente.TabIndex = 58
        Me.metros_frente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.metros_frente.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(0, 77)
        Me.Label4.Margin = New System.Windows.Forms.Padding(0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(244, 20)
        Me.Label4.TabIndex = 59
        Me.Label4.Text = "Ancho Calle (Mts.)"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'metros_calle
        '
        Me.metros_calle.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.metros_calle.Location = New System.Drawing.Point(244, 77)
        Me.metros_calle.Margin = New System.Windows.Forms.Padding(0)
        Me.metros_calle.Maximum = New Decimal(New Integer() {10000000, 0, 0, 0})
        Me.metros_calle.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.metros_calle.Name = "metros_calle"
        Me.metros_calle.Size = New System.Drawing.Size(209, 26)
        Me.metros_calle.TabIndex = 60
        Me.metros_calle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.metros_calle.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(0, 103)
        Me.Label7.Margin = New System.Windows.Forms.Padding(0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(405, 4)
        Me.Label7.TabIndex = 85
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'Label32
        '
        Me.Label32.BackColor = System.Drawing.Color.Gray
        Me.Label32.Font = New System.Drawing.Font("PF DinDisplay Pro", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.White
        Me.Label32.Location = New System.Drawing.Point(0, 107)
        Me.Label32.Margin = New System.Windows.Forms.Padding(0)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(480, 25)
        Me.Label32.TabIndex = 419
        Me.Label32.Text = "FINANCIACIÓN"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label42
        '
        Me.Label42.Location = New System.Drawing.Point(0, 132)
        Me.Label42.Margin = New System.Windows.Forms.Padding(0)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(244, 20)
        Me.Label42.TabIndex = 376
        Me.Label42.Text = "Subtotal"
        Me.Label42.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'monto_subtotal
        '
        Me.monto_subtotal.Font = New System.Drawing.Font("PF DinDisplay Pro Medium", 14.0!)
        Me.monto_subtotal.Location = New System.Drawing.Point(244, 132)
        Me.monto_subtotal.Margin = New System.Windows.Forms.Padding(0)
        Me.monto_subtotal.Name = "monto_subtotal"
        Me.monto_subtotal.Size = New System.Drawing.Size(200, 20)
        Me.monto_subtotal.TabIndex = 377
        Me.monto_subtotal.Text = "$0,00"
        Me.monto_subtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(0, 152)
        Me.Label9.Margin = New System.Windows.Forms.Padding(0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(244, 20)
        Me.Label9.TabIndex = 373
        Me.Label9.Text = "Descuento (%)"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'desc_porcentaje
        '
        Me.desc_porcentaje.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.desc_porcentaje.Location = New System.Drawing.Point(244, 152)
        Me.desc_porcentaje.Margin = New System.Windows.Forms.Padding(0)
        Me.desc_porcentaje.Name = "desc_porcentaje"
        Me.desc_porcentaje.Size = New System.Drawing.Size(72, 26)
        Me.desc_porcentaje.TabIndex = 70
        '
        'monto_descuento
        '
        Me.monto_descuento.Font = New System.Drawing.Font("PF DinDisplay Pro Medium", 14.0!)
        Me.monto_descuento.Location = New System.Drawing.Point(316, 152)
        Me.monto_descuento.Margin = New System.Windows.Forms.Padding(0)
        Me.monto_descuento.Name = "monto_descuento"
        Me.monto_descuento.Size = New System.Drawing.Size(128, 20)
        Me.monto_descuento.TabIndex = 369
        Me.monto_descuento.Text = "$0,00"
        Me.monto_descuento.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(0, 178)
        Me.Label10.Margin = New System.Windows.Forms.Padding(0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(244, 20)
        Me.Label10.TabIndex = 374
        Me.Label10.Text = "Cuotas"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'cuotas
        '
        Me.cuotas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.cuotas.Location = New System.Drawing.Point(244, 178)
        Me.cuotas.Margin = New System.Windows.Forms.Padding(0)
        Me.cuotas.Maximum = New Decimal(New Integer() {120, 0, 0, 0})
        Me.cuotas.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.cuotas.Name = "cuotas"
        Me.cuotas.Size = New System.Drawing.Size(72, 26)
        Me.cuotas.TabIndex = 88
        Me.cuotas.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'monto_cuota
        '
        Me.monto_cuota.Font = New System.Drawing.Font("PF DinDisplay Pro Medium", 14.0!)
        Me.monto_cuota.Location = New System.Drawing.Point(316, 178)
        Me.monto_cuota.Margin = New System.Windows.Forms.Padding(0)
        Me.monto_cuota.Name = "monto_cuota"
        Me.monto_cuota.Size = New System.Drawing.Size(128, 20)
        Me.monto_cuota.TabIndex = 368
        Me.monto_cuota.Text = "$0,00"
        Me.monto_cuota.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("PF DinDisplay Pro", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label13.Location = New System.Drawing.Point(0, 204)
        Me.Label13.Margin = New System.Windows.Forms.Padding(0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(244, 20)
        Me.Label13.TabIndex = 80
        Me.Label13.Text = "TOTAL"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'total
        '
        Me.total.Font = New System.Drawing.Font("PF DinDisplay Pro Medium", 14.0!)
        Me.total.Location = New System.Drawing.Point(244, 204)
        Me.total.Margin = New System.Windows.Forms.Padding(0)
        Me.total.Name = "total"
        Me.total.Size = New System.Drawing.Size(200, 20)
        Me.total.TabIndex = 367
        Me.total.Text = "$0,00"
        Me.total.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'calcTMuniObrasVarias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Font = New System.Drawing.Font("PF DinDisplay Pro Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.MaximumSize = New System.Drawing.Size(480, 240)
        Me.MinimumSize = New System.Drawing.Size(480, 240)
        Me.Name = "calcTMuniObrasVarias"
        Me.Size = New System.Drawing.Size(480, 240)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        CType(Me.costo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.metros_frente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.metros_calle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.desc_porcentaje, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cuotas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents costo As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents metros_frente As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents metros_calle As NumericUpDown
    Friend WithEvents Label42 As Label
    Friend WithEvents monto_subtotal As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents desc_porcentaje As NumericUpDown
    Friend WithEvents monto_descuento As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents cuotas As NumericUpDown
    Friend WithEvents monto_cuota As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents total As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label32 As Label
End Class
