<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsultaOrdenanza
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.resultado = New System.Windows.Forms.DataGridView()
        Me.grupo_mod = New System.Windows.Forms.FlowLayoutPanel()
        Me.eliminar = New System.Windows.Forms.Button()
        Me.modificar = New System.Windows.Forms.Button()
        Me.ver = New System.Windows.Forms.Button()
        Me.GenSearchControl1 = New Sigm.genSearchControl()
        CType(Me.resultado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grupo_mod.SuspendLayout()
        Me.SuspendLayout()
        '
        'resultado
        '
        Me.resultado.AllowUserToAddRows = False
        Me.resultado.AllowUserToDeleteRows = False
        Me.resultado.AllowUserToResizeRows = False
        Me.resultado.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.resultado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.resultado.Location = New System.Drawing.Point(0, 33)
        Me.resultado.Margin = New System.Windows.Forms.Padding(2)
        Me.resultado.MultiSelect = False
        Me.resultado.Name = "resultado"
        Me.resultado.ReadOnly = True
        Me.resultado.RowHeadersVisible = False
        Me.resultado.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        Me.resultado.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.resultado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.resultado.Size = New System.Drawing.Size(489, 367)
        Me.resultado.TabIndex = 337
        '
        'grupo_mod
        '
        Me.grupo_mod.BackColor = System.Drawing.Color.DimGray
        Me.grupo_mod.Controls.Add(Me.modificar)
        Me.grupo_mod.Controls.Add(Me.eliminar)
        Me.grupo_mod.Controls.Add(Me.ver)
        Me.grupo_mod.Dock = System.Windows.Forms.DockStyle.Right
        Me.grupo_mod.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.grupo_mod.Location = New System.Drawing.Point(489, 33)
        Me.grupo_mod.Name = "grupo_mod"
        Me.grupo_mod.Padding = New System.Windows.Forms.Padding(5, 4, 0, 0)
        Me.grupo_mod.Size = New System.Drawing.Size(111, 367)
        Me.grupo_mod.TabIndex = 339
        '
        'eliminar
        '
        Me.eliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.eliminar.FlatAppearance.BorderSize = 0
        Me.eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.eliminar.Font = New System.Drawing.Font("PF DinText Pro", 12.0!)
        Me.eliminar.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.eliminar.Location = New System.Drawing.Point(7, 39)
        Me.eliminar.Name = "eliminar"
        Me.eliminar.Size = New System.Drawing.Size(96, 26)
        Me.eliminar.TabIndex = 345
        Me.eliminar.Text = "ELIMINAR"
        Me.eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.eliminar.UseVisualStyleBackColor = False
        '
        'modificar
        '
        Me.modificar.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.modificar.FlatAppearance.BorderSize = 0
        Me.modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.modificar.Font = New System.Drawing.Font("PF DinText Pro", 12.0!)
        Me.modificar.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.modificar.Location = New System.Drawing.Point(7, 7)
        Me.modificar.Name = "modificar"
        Me.modificar.Size = New System.Drawing.Size(96, 26)
        Me.modificar.TabIndex = 344
        Me.modificar.Text = "MODIFICAR"
        Me.modificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.modificar.UseVisualStyleBackColor = False
        '
        'ver
        '
        Me.ver.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.ver.FlatAppearance.BorderSize = 0
        Me.ver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ver.Font = New System.Drawing.Font("PF DinText Pro", 12.0!)
        Me.ver.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.ver.Location = New System.Drawing.Point(7, 71)
        Me.ver.Name = "ver"
        Me.ver.Size = New System.Drawing.Size(96, 26)
        Me.ver.TabIndex = 346
        Me.ver.Text = "VER COPIA"
        Me.ver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ver.UseVisualStyleBackColor = False
        '
        'GenSearchControl1
        '
        Me.GenSearchControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GenSearchControl1.BackColor = System.Drawing.Color.DimGray
        Me.GenSearchControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GenSearchControl1.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GenSearchControl1.Location = New System.Drawing.Point(0, 0)
        Me.GenSearchControl1.Margin = New System.Windows.Forms.Padding(0)
        Me.GenSearchControl1.Name = "GenSearchControl1"
        Me.GenSearchControl1.Size = New System.Drawing.Size(600, 33)
        Me.GenSearchControl1.TabIndex = 341
        '
        'ConsultaOrdenanza
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(600, 400)
        Me.Controls.Add(Me.resultado)
        Me.Controls.Add(Me.grupo_mod)
        Me.Controls.Add(Me.GenSearchControl1)
        Me.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(600, 400)
        Me.Name = "ConsultaOrdenanza"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Buscar Ordenanza"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.resultado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grupo_mod.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents resultado As System.Windows.Forms.DataGridView
    Friend WithEvents grupo_mod As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents modificar As System.Windows.Forms.Button
    Friend WithEvents eliminar As System.Windows.Forms.Button
    Friend WithEvents ver As System.Windows.Forms.Button
    Friend WithEvents GenSearchControl1 As genSearchControl
End Class
