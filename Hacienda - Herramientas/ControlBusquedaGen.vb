Imports Sigm.Persona.sql
Public Class ControlBusquedaGen
    Inherits Panel
    Public WithEvents PanelBusqueda As FlowLayoutPanel
    Public WithEvents reset As Button
    Public WithEvents keyword As TextBox
    Public WithEvents filtros As FlowLayoutPanel
    Public WithEvents filtro1 As ComboBox
    Public WithEvents Nuevo As Button
    Public WithEvents Modificar As Button
    Public WithEvents Eliminar As Button
    Private components As System.ComponentModel.IContainer
    Public WithEvents visor As DataGridView

    Public Sub InitializeComponent()
        Me.visor = New System.Windows.Forms.DataGridView()
        Me.PanelBusqueda = New System.Windows.Forms.FlowLayoutPanel()
        Me.reset = New System.Windows.Forms.Button()
        Me.keyword = New System.Windows.Forms.TextBox()
        Me.filtros = New System.Windows.Forms.FlowLayoutPanel()
        Me.filtro1 = New System.Windows.Forms.ComboBox()
        Me.Nuevo = New System.Windows.Forms.Button()
        Me.Modificar = New System.Windows.Forms.Button()
        Me.Eliminar = New System.Windows.Forms.Button()
        CType(Me.visor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelBusqueda.SuspendLayout()
        Me.filtros.SuspendLayout()
        Me.SuspendLayout()
        '
        'visor
        '
        Me.visor.AllowUserToAddRows = False
        Me.visor.AllowUserToDeleteRows = False
        Me.visor.AllowUserToResizeRows = False
        Me.visor.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.visor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.visor.Location = New System.Drawing.Point(0, 0)
        Me.visor.Margin = New System.Windows.Forms.Padding(2)
        Me.visor.MultiSelect = False
        Me.visor.Name = "visor"
        Me.visor.ReadOnly = True
        Me.visor.RowHeadersVisible = False
        Me.visor.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.visor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.visor.Size = New System.Drawing.Size(834, 287)
        Me.visor.TabIndex = 337
        '
        'PanelBusqueda
        '
        Me.PanelBusqueda.BackColor = System.Drawing.Color.Transparent
        Me.PanelBusqueda.Controls.Add(Me.reset)
        Me.PanelBusqueda.Controls.Add(Me.keyword)
        Me.PanelBusqueda.Controls.Add(Me.filtros)
        Me.PanelBusqueda.Controls.Add(Me.Nuevo)
        Me.PanelBusqueda.Controls.Add(Me.Modificar)
        Me.PanelBusqueda.Controls.Add(Me.Eliminar)
        Me.PanelBusqueda.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelBusqueda.Location = New System.Drawing.Point(0, 287)
        Me.PanelBusqueda.Name = "PanelBusqueda"
        Me.PanelBusqueda.Size = New System.Drawing.Size(834, 34)
        Me.PanelBusqueda.TabIndex = 339
        '
        'reset
        '
        Me.reset.BackColor = System.Drawing.Color.DarkGray
        Me.reset.FlatAppearance.BorderSize = 0
        Me.reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.reset.ForeColor = System.Drawing.Color.White
        Me.reset.Location = New System.Drawing.Point(5, 3)
        Me.reset.Margin = New System.Windows.Forms.Padding(5, 3, 3, 3)
        Me.reset.Name = "reset"
        Me.reset.Size = New System.Drawing.Size(96, 26)
        Me.reset.TabIndex = 349
        Me.reset.Text = "REINICIAR"
        Me.reset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.reset.UseVisualStyleBackColor = False
        '
        'keyword
        '
        Me.keyword.BackColor = System.Drawing.SystemColors.Window
        Me.keyword.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.keyword.Dock = System.Windows.Forms.DockStyle.Left
        Me.keyword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.keyword.Location = New System.Drawing.Point(107, 3)
        Me.keyword.Name = "keyword"
        Me.keyword.Size = New System.Drawing.Size(150, 27)
        Me.keyword.TabIndex = 346
        Me.keyword.Text = "BUSCAR.."
        '
        'filtros
        '
        Me.filtros.AutoSize = True
        Me.filtros.BackColor = System.Drawing.Color.Gray
        Me.filtros.Controls.Add(Me.filtro1)
        Me.filtros.Font = New System.Drawing.Font("PF DinText Pro", 12.0!)
        Me.filtros.Location = New System.Drawing.Point(260, 0)
        Me.filtros.Margin = New System.Windows.Forms.Padding(0)
        Me.filtros.Name = "filtros"
        Me.filtros.Size = New System.Drawing.Size(156, 27)
        Me.filtros.TabIndex = 351
        '
        'filtro1
        '
        Me.filtro1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.filtro1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.filtro1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.filtro1.FormattingEnabled = True
        Me.filtro1.Location = New System.Drawing.Point(3, 3)
        Me.filtro1.Name = "filtro1"
        Me.filtro1.Size = New System.Drawing.Size(150, 21)
        Me.filtro1.TabIndex = 353
        '
        'Nuevo
        '
        Me.Nuevo.BackColor = System.Drawing.Color.DarkGray
        Me.Nuevo.FlatAppearance.BorderSize = 0
        Me.Nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Nuevo.Font = New System.Drawing.Font("PF DinText Pro", 12.0!)
        Me.Nuevo.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Nuevo.Location = New System.Drawing.Point(421, 3)
        Me.Nuevo.Margin = New System.Windows.Forms.Padding(5, 3, 3, 3)
        Me.Nuevo.Name = "Nuevo"
        Me.Nuevo.Size = New System.Drawing.Size(77, 26)
        Me.Nuevo.TabIndex = 350
        Me.Nuevo.Text = "NUEVO"
        Me.Nuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Nuevo.UseVisualStyleBackColor = False
        '
        'Modificar
        '
        Me.Modificar.BackColor = System.Drawing.Color.DarkGray
        Me.Modificar.FlatAppearance.BorderSize = 0
        Me.Modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Modificar.Font = New System.Drawing.Font("PF DinText Pro", 12.0!)
        Me.Modificar.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Modificar.Location = New System.Drawing.Point(504, 3)
        Me.Modificar.Name = "Modificar"
        Me.Modificar.Size = New System.Drawing.Size(97, 26)
        Me.Modificar.TabIndex = 347
        Me.Modificar.Text = "MODIFICAR"
        Me.Modificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Modificar.UseVisualStyleBackColor = False
        '
        'Eliminar
        '
        Me.Eliminar.BackColor = System.Drawing.Color.DarkGray
        Me.Eliminar.FlatAppearance.BorderSize = 0
        Me.Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Eliminar.Font = New System.Drawing.Font("PF DinText Pro", 12.0!)
        Me.Eliminar.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Eliminar.Location = New System.Drawing.Point(607, 3)
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.Size = New System.Drawing.Size(97, 26)
        Me.Eliminar.TabIndex = 348
        Me.Eliminar.Text = "ELIMINAR"
        Me.Eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Eliminar.UseVisualStyleBackColor = False
        '
        'ControlBusquedaGen
        '
        Me.Controls.Add(Me.visor)
        Me.Controls.Add(Me.PanelBusqueda)
        Me.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Font = New System.Drawing.Font("PF DinText Pro", 12.0!)
        Me.Size = New System.Drawing.Size(834, 321)
        Me.TabIndex = 337
        CType(Me.visor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelBusqueda.ResumeLayout(False)
        Me.PanelBusqueda.PerformLayout()
        Me.filtros.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Public Sub New()
        InitializeComponent()
    End Sub

    '###### BUSQUEDA ##########################################################################################
    Public Sub keyword_ClicknFocus(sender As Object, e As EventArgs) Handles keyword.Click, keyword.GotFocus
        keyword.SelectAll()
    End Sub
    Public Sub keyword_LostFocus(sender As Object, e As EventArgs) Handles keyword.LostFocus
        If Trim(keyword.Text) = "" Then
            keyword.Text = "Buscar.."
        End If
    End Sub
    Public Sub reset_Click(sender As Object, e As EventArgs) Handles reset.Click
        keyword.Text = "Buscar.."
        visor.DataSource = Nothing
    End Sub
End Class
