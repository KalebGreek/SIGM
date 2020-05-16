<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctrlAddInmuebleEdificacion
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.categoria = New System.Windows.Forms.ComboBox()
        Me.superficie = New System.Windows.Forms.NumericUpDown()
        Me.agregar = New System.Windows.Forms.Button()
        Me.eliminar = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.superficie, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.categoria)
        Me.FlowLayoutPanel1.Controls.Add(Me.superficie)
        Me.FlowLayoutPanel1.Controls.Add(Me.agregar)
        Me.FlowLayoutPanel1.Controls.Add(Me.eliminar)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(460, 35)
        Me.FlowLayoutPanel1.TabIndex = 433
        '
        'categoria
        '
        Me.categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.categoria.FormattingEnabled = True
        Me.categoria.Location = New System.Drawing.Point(0, 2)
        Me.categoria.Margin = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.categoria.Name = "categoria"
        Me.categoria.Size = New System.Drawing.Size(318, 30)
        Me.categoria.TabIndex = 435
        '
        'superficie
        '
        Me.superficie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.superficie.DecimalPlaces = 2
        Me.superficie.Location = New System.Drawing.Point(318, 2)
        Me.superficie.Margin = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.superficie.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.superficie.Name = "superficie"
        Me.superficie.Size = New System.Drawing.Size(105, 30)
        Me.superficie.TabIndex = 433
        Me.superficie.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'agregar
        '
        Me.agregar.FlatAppearance.BorderSize = 0
        Me.agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.agregar.Font = New System.Drawing.Font("Segoe MDL2 Assets", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agregar.Location = New System.Drawing.Point(426, 3)
        Me.agregar.Name = "agregar"
        Me.agregar.Size = New System.Drawing.Size(25, 29)
        Me.agregar.TabIndex = 436
        Me.agregar.Text = ""
        Me.agregar.UseVisualStyleBackColor = True
        '
        'eliminar
        '
        Me.eliminar.FlatAppearance.BorderSize = 0
        Me.eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.eliminar.Font = New System.Drawing.Font("Segoe MDL2 Assets", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.eliminar.Location = New System.Drawing.Point(3, 38)
        Me.eliminar.Name = "eliminar"
        Me.eliminar.Size = New System.Drawing.Size(25, 29)
        Me.eliminar.TabIndex = 437
        Me.eliminar.Text = ""
        Me.eliminar.UseVisualStyleBackColor = True
        Me.eliminar.Visible = False
        '
        'ctrlAddInmuebleEdificacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Font = New System.Drawing.Font("PF DinDisplay Pro Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "ctrlAddInmuebleEdificacion"
        Me.Size = New System.Drawing.Size(460, 35)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        CType(Me.superficie, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents categoria As ComboBox
    Friend WithEvents superficie As NumericUpDown
    Friend WithEvents agregar As Button
    Friend WithEvents eliminar As Button
End Class
