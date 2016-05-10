<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsultaCatastro
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConsultaCatastro))
        Me.bs_consulta = New System.Windows.Forms.BindingSource(Me.components)
        Me.tabla_consulta = New System.Windows.Forms.DataGridView()
        Me.grupo_inmueble = New System.Windows.Forms.FlowLayoutPanel()
        Me.Filtro1 = New System.Windows.Forms.ComboBox()
        Me.zona = New System.Windows.Forms.MaskedTextBox()
        Me.circ = New System.Windows.Forms.MaskedTextBox()
        Me.secc = New System.Windows.Forms.MaskedTextBox()
        Me.manz = New System.Windows.Forms.MaskedTextBox()
        Me.parc = New System.Windows.Forms.MaskedTextBox()
        Me.lote = New System.Windows.Forms.MaskedTextBox()
        Me.Keyword = New System.Windows.Forms.MaskedTextBox()
        Me.buscar = New System.Windows.Forms.Button()
        Me.reset = New System.Windows.Forms.Button()
        CType(Me.bs_consulta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tabla_consulta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grupo_inmueble.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabla_consulta
        '
        Me.tabla_consulta.AllowUserToAddRows = False
        Me.tabla_consulta.AllowUserToDeleteRows = False
        Me.tabla_consulta.AllowUserToResizeRows = False
        Me.tabla_consulta.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.tabla_consulta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabla_consulta.Location = New System.Drawing.Point(0, 67)
        Me.tabla_consulta.Margin = New System.Windows.Forms.Padding(2)
        Me.tabla_consulta.MultiSelect = False
        Me.tabla_consulta.Name = "tabla_consulta"
        Me.tabla_consulta.ReadOnly = True
        Me.tabla_consulta.RowHeadersVisible = False
        Me.tabla_consulta.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.tabla_consulta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.tabla_consulta.Size = New System.Drawing.Size(624, 294)
        Me.tabla_consulta.TabIndex = 353
        '
        'grupo_inmueble
        '
        Me.grupo_inmueble.AutoSize = True
        Me.grupo_inmueble.Controls.Add(Me.Filtro1)
        Me.grupo_inmueble.Controls.Add(Me.zona)
        Me.grupo_inmueble.Controls.Add(Me.circ)
        Me.grupo_inmueble.Controls.Add(Me.secc)
        Me.grupo_inmueble.Controls.Add(Me.manz)
        Me.grupo_inmueble.Controls.Add(Me.parc)
        Me.grupo_inmueble.Controls.Add(Me.lote)
        Me.grupo_inmueble.Controls.Add(Me.Keyword)
        Me.grupo_inmueble.Controls.Add(Me.buscar)
        Me.grupo_inmueble.Controls.Add(Me.reset)
        Me.grupo_inmueble.Dock = System.Windows.Forms.DockStyle.Top
        Me.grupo_inmueble.Location = New System.Drawing.Point(0, 0)
        Me.grupo_inmueble.Name = "grupo_inmueble"
        Me.grupo_inmueble.Size = New System.Drawing.Size(624, 67)
        Me.grupo_inmueble.TabIndex = 360
        '
        'Filtro1
        '
        Me.Filtro1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.Filtro1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Filtro1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Filtro1.FormattingEnabled = True
        Me.Filtro1.Items.AddRange(New Object() {"NRO. DE PARTIDA", "NOMBRE TITULAR", "CUIL TITULAR", "EXPEDIENTE ", "DIRECCION", "BARRIO"})
        Me.Filtro1.Location = New System.Drawing.Point(3, 3)
        Me.Filtro1.Name = "Filtro1"
        Me.Filtro1.Size = New System.Drawing.Size(162, 27)
        Me.Filtro1.TabIndex = 340
        Me.Filtro1.Text = "NRO. DE PARTIDA"
        '
        'zona
        '
        Me.zona.BackColor = System.Drawing.SystemColors.Info
        Me.zona.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite
        Me.zona.Location = New System.Drawing.Point(168, 3)
        Me.zona.Margin = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.zona.Mask = "\Z00"
        Me.zona.Name = "zona"
        Me.zona.PromptChar = Global.Microsoft.VisualBasic.ChrW(48)
        Me.zona.Size = New System.Drawing.Size(44, 27)
        Me.zona.TabIndex = 928
        Me.zona.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.zona.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt
        '
        'circ
        '
        Me.circ.BackColor = System.Drawing.SystemColors.Info
        Me.circ.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite
        Me.circ.Location = New System.Drawing.Point(212, 3)
        Me.circ.Margin = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.circ.Mask = "\C000"
        Me.circ.Name = "circ"
        Me.circ.PromptChar = Global.Microsoft.VisualBasic.ChrW(48)
        Me.circ.Size = New System.Drawing.Size(44, 27)
        Me.circ.TabIndex = 929
        Me.circ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.circ.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt
        '
        'secc
        '
        Me.secc.BackColor = System.Drawing.SystemColors.Info
        Me.secc.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite
        Me.secc.Location = New System.Drawing.Point(256, 3)
        Me.secc.Margin = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.secc.Mask = "\S000"
        Me.secc.Name = "secc"
        Me.secc.PromptChar = Global.Microsoft.VisualBasic.ChrW(48)
        Me.secc.Size = New System.Drawing.Size(44, 27)
        Me.secc.TabIndex = 930
        Me.secc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.secc.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt
        '
        'manz
        '
        Me.manz.BackColor = System.Drawing.SystemColors.Info
        Me.manz.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite
        Me.manz.Location = New System.Drawing.Point(300, 3)
        Me.manz.Margin = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.manz.Mask = "\M000"
        Me.manz.Name = "manz"
        Me.manz.PromptChar = Global.Microsoft.VisualBasic.ChrW(48)
        Me.manz.Size = New System.Drawing.Size(44, 27)
        Me.manz.TabIndex = 931
        Me.manz.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.manz.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt
        '
        'parc
        '
        Me.parc.BackColor = System.Drawing.SystemColors.Info
        Me.parc.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite
        Me.parc.Location = New System.Drawing.Point(344, 3)
        Me.parc.Margin = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.parc.Mask = "\P000"
        Me.parc.Name = "parc"
        Me.parc.PromptChar = Global.Microsoft.VisualBasic.ChrW(48)
        Me.parc.Size = New System.Drawing.Size(44, 27)
        Me.parc.TabIndex = 932
        Me.parc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.parc.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt
        '
        'lote
        '
        Me.lote.BackColor = System.Drawing.SystemColors.Info
        Me.lote.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite
        Me.lote.Location = New System.Drawing.Point(388, 3)
        Me.lote.Margin = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.lote.Mask = "\L000"
        Me.lote.Name = "lote"
        Me.lote.PromptChar = Global.Microsoft.VisualBasic.ChrW(48)
        Me.lote.Size = New System.Drawing.Size(44, 27)
        Me.lote.TabIndex = 933
        Me.lote.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.lote.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt
        '
        'Keyword
        '
        Me.Keyword.BackColor = System.Drawing.SystemColors.Window
        Me.Keyword.Location = New System.Drawing.Point(435, 3)
        Me.Keyword.Mask = "99-99999999-9"
        Me.Keyword.Name = "Keyword"
        Me.Keyword.Size = New System.Drawing.Size(137, 27)
        Me.Keyword.TabIndex = 934
        Me.Keyword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Keyword.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        Me.Keyword.Visible = False
        '
        'buscar
        '
        Me.buscar.BackColor = System.Drawing.Color.Transparent
        Me.buscar.FlatAppearance.BorderSize = 0
        Me.buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buscar.ForeColor = System.Drawing.Color.White
        Me.buscar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.buscar.Location = New System.Drawing.Point(0, 33)
        Me.buscar.Margin = New System.Windows.Forms.Padding(0)
        Me.buscar.Name = "buscar"
        Me.buscar.Size = New System.Drawing.Size(71, 34)
        Me.buscar.TabIndex = 935
        Me.buscar.Text = "BUSCAR"
        Me.buscar.UseVisualStyleBackColor = False
        '
        'reset
        '
        Me.reset.BackColor = System.Drawing.Color.Transparent
        Me.reset.FlatAppearance.BorderSize = 0
        Me.reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.reset.ForeColor = System.Drawing.Color.White
        Me.reset.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.reset.Location = New System.Drawing.Point(71, 33)
        Me.reset.Margin = New System.Windows.Forms.Padding(0)
        Me.reset.Name = "reset"
        Me.reset.Size = New System.Drawing.Size(84, 34)
        Me.reset.TabIndex = 936
        Me.reset.Text = "REINICIAR"
        Me.reset.UseVisualStyleBackColor = False
        '
        'ConsultaCatastro
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(624, 361)
        Me.Controls.Add(Me.tabla_consulta)
        Me.Controls.Add(Me.grupo_inmueble)
        Me.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(640, 400)
        Me.Name = "ConsultaCatastro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Consulta Catastro"
        CType(Me.bs_consulta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tabla_consulta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grupo_inmueble.ResumeLayout(False)
        Me.grupo_inmueble.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bs_consulta As System.Windows.Forms.BindingSource
    Friend WithEvents tabla_consulta As System.Windows.Forms.DataGridView
    Friend WithEvents grupo_inmueble As FlowLayoutPanel
    Friend WithEvents Filtro1 As ComboBox
    Friend WithEvents zona As MaskedTextBox
    Friend WithEvents circ As MaskedTextBox
    Friend WithEvents secc As MaskedTextBox
    Friend WithEvents manz As MaskedTextBox
    Friend WithEvents parc As MaskedTextBox
    Friend WithEvents lote As MaskedTextBox
    Friend WithEvents Keyword As MaskedTextBox
    Friend WithEvents buscar As Button
    Friend WithEvents reset As Button
End Class
