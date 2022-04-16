<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ConsultaContrato
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Me.bs_contrato = New System.Windows.Forms.BindingSource(Me.components)
        Me.resultado = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.nuevoCont = New System.Windows.Forms.Button()
        Me.printCont = New System.Windows.Forms.Button()
        Me.GenSearchControl1 = New Sigm.genSearchControl()
        CType(Me.bs_contrato, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.resultado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'resultado
        '
        Me.resultado.AllowUserToAddRows = False
        Me.resultado.AllowUserToDeleteRows = False
        Me.resultado.AllowUserToResizeRows = False
        Me.resultado.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.resultado.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.resultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.resultado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.resultado.Location = New System.Drawing.Point(0, 33)
        Me.resultado.Margin = New System.Windows.Forms.Padding(0)
        Me.resultado.Name = "resultado"
        Me.resultado.ReadOnly = True
        Me.resultado.RowHeadersVisible = False
        Me.resultado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.resultado.Size = New System.Drawing.Size(439, 328)
        Me.resultado.TabIndex = 368
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightGray
        Me.Panel2.Controls.Add(Me.FlowLayoutPanel2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(439, 33)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(145, 328)
        Me.Panel2.TabIndex = 369
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Controls.Add(Me.nuevoCont)
        Me.FlowLayoutPanel2.Controls.Add(Me.printCont)
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(145, 328)
        Me.FlowLayoutPanel2.TabIndex = 9
        '
        'nuevoCont
        '
        Me.nuevoCont.Location = New System.Drawing.Point(3, 3)
        Me.nuevoCont.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.nuevoCont.Name = "nuevoCont"
        Me.nuevoCont.Size = New System.Drawing.Size(139, 26)
        Me.nuevoCont.TabIndex = 1
        Me.nuevoCont.Text = "Nuevo Contrato"
        Me.nuevoCont.UseVisualStyleBackColor = True
        '
        'printCont
        '
        Me.printCont.Location = New System.Drawing.Point(3, 32)
        Me.printCont.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.printCont.Name = "printCont"
        Me.printCont.Size = New System.Drawing.Size(139, 26)
        Me.printCont.TabIndex = 3
        Me.printCont.Text = "Imprimir Contrato"
        Me.printCont.UseVisualStyleBackColor = True
        '
        'GenSearchControl1
        '
        Me.GenSearchControl1.AutoSize = True
        Me.GenSearchControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GenSearchControl1.BackColor = System.Drawing.Color.DarkGray
        Me.GenSearchControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GenSearchControl1.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GenSearchControl1.Location = New System.Drawing.Point(0, 0)
        Me.GenSearchControl1.MinimumSize = New System.Drawing.Size(520, 33)
        Me.GenSearchControl1.Name = "GenSearchControl1"
        Me.GenSearchControl1.Size = New System.Drawing.Size(584, 33)
        Me.GenSearchControl1.TabIndex = 0
        '
        'ConsultaContrato
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(584, 361)
        Me.Controls.Add(Me.resultado)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.GenSearchControl1)
        Me.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Name = "ConsultaContrato"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Contratos | SIGM"
        CType(Me.bs_contrato, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.resultado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GenSearchControl1 As genSearchControl
    Friend WithEvents bs_contrato As BindingSource
    Friend WithEvents Panel2 As Panel
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents nuevoCont As Button
    Friend WithEvents printCont As Button
    Friend WithEvents resultado As DataGridView
End Class
