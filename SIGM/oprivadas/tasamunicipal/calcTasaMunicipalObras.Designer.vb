<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class calcTasaMunicipalObras
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.costo = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.metrosFrente = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.metrosCalle = New System.Windows.Forms.NumericUpDown()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.descuento = New System.Windows.Forms.NumericUpDown()
        Me.montoDescuento = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cuotas = New System.Windows.Forms.NumericUpDown()
        Me.montoCuota = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.total = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.costo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.metrosFrente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.metrosCalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.descuento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cuotas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.Label2)
        Me.FlowLayoutPanel1.Controls.Add(Me.costo)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label3)
        Me.FlowLayoutPanel1.Controls.Add(Me.metrosFrente)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label4)
        Me.FlowLayoutPanel1.Controls.Add(Me.metrosCalle)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label42)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label43)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label7)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label9)
        Me.FlowLayoutPanel1.Controls.Add(Me.descuento)
        Me.FlowLayoutPanel1.Controls.Add(Me.montoDescuento)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label10)
        Me.FlowLayoutPanel1.Controls.Add(Me.cuotas)
        Me.FlowLayoutPanel1.Controls.Add(Me.montoCuota)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label13)
        Me.FlowLayoutPanel1.Controls.Add(Me.total)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(410, 187)
        Me.FlowLayoutPanel1.TabIndex = 51
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Margin = New System.Windows.Forms.Padding(0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(172, 20)
        Me.Label2.TabIndex = 55
        Me.Label2.Text = "Costo Frentista ($)"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'costo
        '
        Me.costo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.costo.DecimalPlaces = 2
        Me.costo.Location = New System.Drawing.Point(172, 0)
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
        Me.Label3.Location = New System.Drawing.Point(0, 26)
        Me.Label3.Margin = New System.Windows.Forms.Padding(0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(172, 20)
        Me.Label3.TabIndex = 57
        Me.Label3.Text = "Frente (Mts.)"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'metrosFrente
        '
        Me.metrosFrente.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.metrosFrente.DecimalPlaces = 2
        Me.metrosFrente.Location = New System.Drawing.Point(172, 26)
        Me.metrosFrente.Margin = New System.Windows.Forms.Padding(0)
        Me.metrosFrente.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.metrosFrente.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.metrosFrente.Name = "metrosFrente"
        Me.metrosFrente.Size = New System.Drawing.Size(209, 26)
        Me.metrosFrente.TabIndex = 58
        Me.metrosFrente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.metrosFrente.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(0, 52)
        Me.Label4.Margin = New System.Windows.Forms.Padding(0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(172, 20)
        Me.Label4.TabIndex = 59
        Me.Label4.Text = "Ancho Calle (Mts.)"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'metrosCalle
        '
        Me.metrosCalle.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.metrosCalle.Location = New System.Drawing.Point(172, 52)
        Me.metrosCalle.Margin = New System.Windows.Forms.Padding(0)
        Me.metrosCalle.Maximum = New Decimal(New Integer() {10000000, 0, 0, 0})
        Me.metrosCalle.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.metrosCalle.Name = "metrosCalle"
        Me.metrosCalle.Size = New System.Drawing.Size(209, 26)
        Me.metrosCalle.TabIndex = 60
        Me.metrosCalle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.metrosCalle.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label42
        '
        Me.Label42.Location = New System.Drawing.Point(0, 78)
        Me.Label42.Margin = New System.Windows.Forms.Padding(0)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(172, 20)
        Me.Label42.TabIndex = 376
        Me.Label42.Text = "Subtotal"
        Me.Label42.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'Label43
        '
        Me.Label43.Font = New System.Drawing.Font("PF DinDisplay Pro Medium", 14.0!)
        Me.Label43.Location = New System.Drawing.Point(172, 78)
        Me.Label43.Margin = New System.Windows.Forms.Padding(0)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(200, 20)
        Me.Label43.TabIndex = 377
        Me.Label43.Text = "$0,00"
        Me.Label43.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(0, 98)
        Me.Label7.Margin = New System.Windows.Forms.Padding(0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(305, 10)
        Me.Label7.TabIndex = 85
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(0, 108)
        Me.Label9.Margin = New System.Windows.Forms.Padding(0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(172, 20)
        Me.Label9.TabIndex = 373
        Me.Label9.Text = "Descuento (%)"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'descuento
        '
        Me.descuento.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.descuento.Location = New System.Drawing.Point(172, 108)
        Me.descuento.Margin = New System.Windows.Forms.Padding(0)
        Me.descuento.Name = "descuento"
        Me.descuento.Size = New System.Drawing.Size(72, 26)
        Me.descuento.TabIndex = 70
        '
        'montoDescuento
        '
        Me.montoDescuento.Font = New System.Drawing.Font("PF DinDisplay Pro Medium", 14.0!)
        Me.montoDescuento.Location = New System.Drawing.Point(244, 108)
        Me.montoDescuento.Margin = New System.Windows.Forms.Padding(0)
        Me.montoDescuento.Name = "montoDescuento"
        Me.montoDescuento.Size = New System.Drawing.Size(128, 20)
        Me.montoDescuento.TabIndex = 369
        Me.montoDescuento.Text = "$0,00"
        Me.montoDescuento.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(0, 134)
        Me.Label10.Margin = New System.Windows.Forms.Padding(0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(172, 20)
        Me.Label10.TabIndex = 374
        Me.Label10.Text = "Cuotas"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'cuotas
        '
        Me.cuotas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.cuotas.Location = New System.Drawing.Point(172, 134)
        Me.cuotas.Margin = New System.Windows.Forms.Padding(0)
        Me.cuotas.Maximum = New Decimal(New Integer() {120, 0, 0, 0})
        Me.cuotas.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.cuotas.Name = "cuotas"
        Me.cuotas.Size = New System.Drawing.Size(72, 26)
        Me.cuotas.TabIndex = 88
        Me.cuotas.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'montoCuota
        '
        Me.montoCuota.Font = New System.Drawing.Font("PF DinDisplay Pro Medium", 14.0!)
        Me.montoCuota.Location = New System.Drawing.Point(244, 134)
        Me.montoCuota.Margin = New System.Windows.Forms.Padding(0)
        Me.montoCuota.Name = "montoCuota"
        Me.montoCuota.Size = New System.Drawing.Size(128, 20)
        Me.montoCuota.TabIndex = 368
        Me.montoCuota.Text = "$0,00"
        Me.montoCuota.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("PF DinDisplay Pro", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label13.Location = New System.Drawing.Point(0, 160)
        Me.Label13.Margin = New System.Windows.Forms.Padding(0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(172, 20)
        Me.Label13.TabIndex = 80
        Me.Label13.Text = "TOTAL"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'total
        '
        Me.total.Font = New System.Drawing.Font("PF DinDisplay Pro Medium", 14.0!)
        Me.total.Location = New System.Drawing.Point(172, 160)
        Me.total.Margin = New System.Windows.Forms.Padding(0)
        Me.total.Name = "total"
        Me.total.Size = New System.Drawing.Size(200, 20)
        Me.total.TabIndex = 367
        Me.total.Text = "$0,00"
        Me.total.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'calcTasaMunicipalObras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Font = New System.Drawing.Font("PF DinDisplay Pro Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "calcTasaMunicipalObras"
        Me.Size = New System.Drawing.Size(410, 187)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        CType(Me.costo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.metrosFrente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.metrosCalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.descuento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cuotas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents costo As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents metrosFrente As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents metrosCalle As NumericUpDown
    Friend WithEvents Label42 As Label
    Friend WithEvents Label43 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents descuento As NumericUpDown
    Friend WithEvents montoDescuento As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents cuotas As NumericUpDown
    Friend WithEvents montoCuota As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents total As Label
End Class
