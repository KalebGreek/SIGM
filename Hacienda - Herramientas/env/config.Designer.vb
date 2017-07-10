<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class config
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(config))
		Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
		Me.OpcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ImportarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
		Me.RestablecerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.CerrarSinGuardarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.conexion_acc = New System.Windows.Forms.TextBox()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.conexion_pgsql = New System.Windows.Forms.TextBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.conexion_std = New System.Windows.Forms.TextBox()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.conexion_fox = New System.Windows.Forms.TextBox()
		Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
		Me.TabControl1 = New System.Windows.Forms.TabControl()
		Me.TabAgua = New System.Windows.Forms.TabPage()
		Me.et_agua6 = New System.Windows.Forms.Label()
		Me.agua_variables = New System.Windows.Forms.TextBox()
		Me.et_agua5 = New System.Windows.Forms.Label()
		Me.agua_zonas = New System.Windows.Forms.TextBox()
		Me.et_agua4 = New System.Windows.Forms.Label()
		Me.agua_vencimientos = New System.Windows.Forms.TextBox()
		Me.et_agua3 = New System.Windows.Forms.Label()
		Me.agua_historial = New System.Windows.Forms.TextBox()
		Me.et_agua2 = New System.Windows.Forms.Label()
		Me.agua_cuentas = New System.Windows.Forms.TextBox()
		Me.et_agua1 = New System.Windows.Forms.Label()
		Me.agua_personas = New System.Windows.Forms.TextBox()
		Me.TabAuto = New System.Windows.Forms.TabPage()
		Me.et_vehi4 = New System.Windows.Forms.Label()
		Me.auto_tipo = New System.Windows.Forms.TextBox()
		Me.et_vehi3 = New System.Windows.Forms.Label()
		Me.auto_vencimientos = New System.Windows.Forms.TextBox()
		Me.et_vehi2 = New System.Windows.Forms.Label()
		Me.auto_cuentas = New System.Windows.Forms.TextBox()
		Me.et_vehi1 = New System.Windows.Forms.Label()
		Me.auto_personas = New System.Windows.Forms.TextBox()
		Me.TabCata = New System.Windows.Forms.TabPage()
		Me.et_cata5 = New System.Windows.Forms.Label()
		Me.cata_zonas = New System.Windows.Forms.TextBox()
		Me.et_cata4 = New System.Windows.Forms.Label()
		Me.cata_vencimientos = New System.Windows.Forms.TextBox()
		Me.et_cata3 = New System.Windows.Forms.Label()
		Me.cata_historial = New System.Windows.Forms.TextBox()
		Me.et_cata2 = New System.Windows.Forms.Label()
		Me.cata_cuentas = New System.Windows.Forms.TextBox()
		Me.et_cata1 = New System.Windows.Forms.Label()
		Me.cata_personas = New System.Windows.Forms.TextBox()
		Me.TabCome = New System.Windows.Forms.TabPage()
		Me.et_come6 = New System.Windows.Forms.Label()
		Me.come_variables = New System.Windows.Forms.TextBox()
		Me.et_come5 = New System.Windows.Forms.Label()
		Me.come_actividades = New System.Windows.Forms.TextBox()
		Me.et_come4 = New System.Windows.Forms.Label()
		Me.come_vencimientos = New System.Windows.Forms.TextBox()
		Me.et_come3 = New System.Windows.Forms.Label()
		Me.come_historial = New System.Windows.Forms.TextBox()
		Me.et_come2 = New System.Windows.Forms.Label()
		Me.come_cuentas = New System.Windows.Forms.TextBox()
		Me.et_come1 = New System.Windows.Forms.Label()
		Me.come_personas = New System.Windows.Forms.TextBox()
		Me.TabSepe = New System.Windows.Forms.TabPage()
		Me.et_sepe5 = New System.Windows.Forms.Label()
		Me.sepe_variables = New System.Windows.Forms.TextBox()
		Me.et_sepe4 = New System.Windows.Forms.Label()
		Me.sepe_muertos = New System.Windows.Forms.TextBox()
		Me.et_sepe3 = New System.Windows.Forms.Label()
		Me.sepe_historial = New System.Windows.Forms.TextBox()
		Me.et_sepe2 = New System.Windows.Forms.Label()
		Me.sepe_cuentas = New System.Windows.Forms.TextBox()
		Me.et_sepe1 = New System.Windows.Forms.Label()
		Me.sepe_personas = New System.Windows.Forms.TextBox()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.rutina_fecha_null = New System.Windows.Forms.Button()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.MenuStrip1.SuspendLayout()
		Me.FlowLayoutPanel1.SuspendLayout()
		Me.FlowLayoutPanel2.SuspendLayout()
		Me.TabControl1.SuspendLayout()
		Me.TabAgua.SuspendLayout()
		Me.TabAuto.SuspendLayout()
		Me.TabCata.SuspendLayout()
		Me.TabCome.SuspendLayout()
		Me.TabSepe.SuspendLayout()
		Me.GroupBox1.SuspendLayout()
		Me.SuspendLayout()
		'
		'MenuStrip1
		'
		Me.MenuStrip1.BackColor = System.Drawing.Color.DarkGray
		Me.MenuStrip1.Font = New System.Drawing.Font("PF DinDisplay Pro", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpcionesToolStripMenuItem})
		Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
		Me.MenuStrip1.Name = "MenuStrip1"
		Me.MenuStrip1.Size = New System.Drawing.Size(594, 26)
		Me.MenuStrip1.TabIndex = 14
		Me.MenuStrip1.Text = "MenuStrip1"
		'
		'OpcionesToolStripMenuItem
		'
		Me.OpcionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImportarToolStripMenuItem, Me.ToolStripSeparator1, Me.RestablecerToolStripMenuItem, Me.CerrarSinGuardarToolStripMenuItem})
		Me.OpcionesToolStripMenuItem.Name = "OpcionesToolStripMenuItem"
		Me.OpcionesToolStripMenuItem.Size = New System.Drawing.Size(76, 22)
		Me.OpcionesToolStripMenuItem.Text = "Opciones"
		'
		'ImportarToolStripMenuItem
		'
		Me.ImportarToolStripMenuItem.Name = "ImportarToolStripMenuItem"
		Me.ImportarToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
		Me.ImportarToolStripMenuItem.Text = "Importar BD"
		'
		'ToolStripSeparator1
		'
		Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
		Me.ToolStripSeparator1.Size = New System.Drawing.Size(148, 6)
		'
		'RestablecerToolStripMenuItem
		'
		Me.RestablecerToolStripMenuItem.Enabled = False
		Me.RestablecerToolStripMenuItem.Name = "RestablecerToolStripMenuItem"
		Me.RestablecerToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
		Me.RestablecerToolStripMenuItem.Text = "Restablecer"
		'
		'CerrarSinGuardarToolStripMenuItem
		'
		Me.CerrarSinGuardarToolStripMenuItem.Name = "CerrarSinGuardarToolStripMenuItem"
		Me.CerrarSinGuardarToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
		Me.CerrarSinGuardarToolStripMenuItem.Text = "Cerrar"
		'
		'FlowLayoutPanel1
		'
		Me.FlowLayoutPanel1.Controls.Add(Me.Label2)
		Me.FlowLayoutPanel1.Controls.Add(Me.conexion_std)
		Me.FlowLayoutPanel1.Controls.Add(Me.Label6)
		Me.FlowLayoutPanel1.Controls.Add(Me.conexion_acc)
		Me.FlowLayoutPanel1.Controls.Add(Me.Label5)
		Me.FlowLayoutPanel1.Controls.Add(Me.conexion_pgsql)
		Me.FlowLayoutPanel1.Controls.Add(Me.Label4)
		Me.FlowLayoutPanel1.Controls.Add(Me.conexion_fox)
		Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
		Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 49)
		Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
		Me.FlowLayoutPanel1.Size = New System.Drawing.Size(594, 98)
		Me.FlowLayoutPanel1.TabIndex = 25
		'
		'Label6
		'
		Me.Label6.Font = New System.Drawing.Font("PF DinDisplay Pro", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label6.Location = New System.Drawing.Point(0, 23)
		Me.Label6.Margin = New System.Windows.Forms.Padding(0)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(115, 18)
		Me.Label6.TabIndex = 33
		Me.Label6.Text = "MS Access"
		Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'conexion_acc
		'
		Me.conexion_acc.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.conexion_acc.Location = New System.Drawing.Point(115, 23)
		Me.conexion_acc.Margin = New System.Windows.Forms.Padding(0)
		Me.conexion_acc.Name = "conexion_acc"
		Me.conexion_acc.Size = New System.Drawing.Size(473, 23)
		Me.conexion_acc.TabIndex = 28
		Me.conexion_acc.Text = "No hay datos."
		'
		'Label5
		'
		Me.Label5.Font = New System.Drawing.Font("PF DinDisplay Pro", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.Location = New System.Drawing.Point(0, 46)
		Me.Label5.Margin = New System.Windows.Forms.Padding(0)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(115, 18)
		Me.Label5.TabIndex = 32
		Me.Label5.Text = "PostgreSQL"
		Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'conexion_pgsql
		'
		Me.conexion_pgsql.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.conexion_pgsql.Location = New System.Drawing.Point(115, 46)
		Me.conexion_pgsql.Margin = New System.Windows.Forms.Padding(0)
		Me.conexion_pgsql.Name = "conexion_pgsql"
		Me.conexion_pgsql.Size = New System.Drawing.Size(473, 23)
		Me.conexion_pgsql.TabIndex = 27
		Me.conexion_pgsql.Text = "No hay datos."
		'
		'Label2
		'
		Me.Label2.Font = New System.Drawing.Font("PF DinDisplay Pro", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(0, 0)
		Me.Label2.Margin = New System.Windows.Forms.Padding(0)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(115, 18)
		Me.Label2.TabIndex = 31
		Me.Label2.Text = "Conexión Actual"
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'conexion_std
		'
		Me.conexion_std.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.conexion_std.Location = New System.Drawing.Point(115, 0)
		Me.conexion_std.Margin = New System.Windows.Forms.Padding(0)
		Me.conexion_std.Name = "conexion_std"
		Me.conexion_std.Size = New System.Drawing.Size(473, 23)
		Me.conexion_std.TabIndex = 25
		Me.conexion_std.Text = "No hay datos."
		'
		'Label4
		'
		Me.Label4.Font = New System.Drawing.Font("PF DinDisplay Pro", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.Location = New System.Drawing.Point(0, 69)
		Me.Label4.Margin = New System.Windows.Forms.Padding(0)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(115, 18)
		Me.Label4.TabIndex = 29
		Me.Label4.Text = "Fox"
		Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'conexion_fox
		'
		Me.conexion_fox.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.conexion_fox.Location = New System.Drawing.Point(115, 69)
		Me.conexion_fox.Margin = New System.Windows.Forms.Padding(0)
		Me.conexion_fox.Name = "conexion_fox"
		Me.conexion_fox.Size = New System.Drawing.Size(473, 23)
		Me.conexion_fox.TabIndex = 26
		Me.conexion_fox.Text = "No hay datos."
		'
		'FlowLayoutPanel2
		'
		Me.FlowLayoutPanel2.Controls.Add(Me.TabControl1)
		Me.FlowLayoutPanel2.Controls.Add(Me.GroupBox1)
		Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
		Me.FlowLayoutPanel2.Location = New System.Drawing.Point(0, 170)
		Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
		Me.FlowLayoutPanel2.Size = New System.Drawing.Size(594, 222)
		Me.FlowLayoutPanel2.TabIndex = 27
		'
		'TabControl1
		'
		Me.TabControl1.Controls.Add(Me.TabAgua)
		Me.TabControl1.Controls.Add(Me.TabAuto)
		Me.TabControl1.Controls.Add(Me.TabCata)
		Me.TabControl1.Controls.Add(Me.TabCome)
		Me.TabControl1.Controls.Add(Me.TabSepe)
		Me.TabControl1.Location = New System.Drawing.Point(3, 3)
		Me.TabControl1.Name = "TabControl1"
		Me.TabControl1.SelectedIndex = 0
		Me.TabControl1.Size = New System.Drawing.Size(271, 211)
		Me.TabControl1.TabIndex = 27
		'
		'TabAgua
		'
		Me.TabAgua.BackColor = System.Drawing.Color.WhiteSmoke
		Me.TabAgua.Controls.Add(Me.et_agua6)
		Me.TabAgua.Controls.Add(Me.agua_variables)
		Me.TabAgua.Controls.Add(Me.et_agua5)
		Me.TabAgua.Controls.Add(Me.agua_zonas)
		Me.TabAgua.Controls.Add(Me.et_agua4)
		Me.TabAgua.Controls.Add(Me.agua_vencimientos)
		Me.TabAgua.Controls.Add(Me.et_agua3)
		Me.TabAgua.Controls.Add(Me.agua_historial)
		Me.TabAgua.Controls.Add(Me.et_agua2)
		Me.TabAgua.Controls.Add(Me.agua_cuentas)
		Me.TabAgua.Controls.Add(Me.et_agua1)
		Me.TabAgua.Controls.Add(Me.agua_personas)
		Me.TabAgua.Location = New System.Drawing.Point(4, 24)
		Me.TabAgua.Name = "TabAgua"
		Me.TabAgua.Padding = New System.Windows.Forms.Padding(3)
		Me.TabAgua.Size = New System.Drawing.Size(263, 183)
		Me.TabAgua.TabIndex = 0
		Me.TabAgua.Text = "Agua"
		'
		'et_agua6
		'
		Me.et_agua6.AutoSize = True
		Me.et_agua6.Font = New System.Drawing.Font("PF DinDisplay Pro", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.et_agua6.Location = New System.Drawing.Point(8, 155)
		Me.et_agua6.Name = "et_agua6"
		Me.et_agua6.Size = New System.Drawing.Size(66, 16)
		Me.et_agua6.TabIndex = 24
		Me.et_agua6.Text = "Variables"
		'
		'agua_variables
		'
		Me.agua_variables.Font = New System.Drawing.Font("PF DinDisplay Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.agua_variables.Location = New System.Drawing.Point(99, 152)
		Me.agua_variables.Name = "agua_variables"
		Me.agua_variables.Size = New System.Drawing.Size(88, 23)
		Me.agua_variables.TabIndex = 23
		'
		'et_agua5
		'
		Me.et_agua5.AutoSize = True
		Me.et_agua5.Font = New System.Drawing.Font("PF DinDisplay Pro", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.et_agua5.Location = New System.Drawing.Point(8, 126)
		Me.et_agua5.Name = "et_agua5"
		Me.et_agua5.Size = New System.Drawing.Size(46, 16)
		Me.et_agua5.TabIndex = 22
		Me.et_agua5.Text = "Zonas"
		'
		'agua_zonas
		'
		Me.agua_zonas.Font = New System.Drawing.Font("PF DinDisplay Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.agua_zonas.Location = New System.Drawing.Point(99, 123)
		Me.agua_zonas.Name = "agua_zonas"
		Me.agua_zonas.Size = New System.Drawing.Size(88, 23)
		Me.agua_zonas.TabIndex = 21
		'
		'et_agua4
		'
		Me.et_agua4.AutoSize = True
		Me.et_agua4.Font = New System.Drawing.Font("PF DinDisplay Pro", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.et_agua4.Location = New System.Drawing.Point(8, 97)
		Me.et_agua4.Name = "et_agua4"
		Me.et_agua4.Size = New System.Drawing.Size(90, 16)
		Me.et_agua4.TabIndex = 20
		Me.et_agua4.Text = "Vencimientos"
		'
		'agua_vencimientos
		'
		Me.agua_vencimientos.Font = New System.Drawing.Font("PF DinDisplay Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.agua_vencimientos.Location = New System.Drawing.Point(99, 94)
		Me.agua_vencimientos.Name = "agua_vencimientos"
		Me.agua_vencimientos.Size = New System.Drawing.Size(88, 23)
		Me.agua_vencimientos.TabIndex = 19
		'
		'et_agua3
		'
		Me.et_agua3.AutoSize = True
		Me.et_agua3.Font = New System.Drawing.Font("PF DinDisplay Pro", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.et_agua3.Location = New System.Drawing.Point(8, 68)
		Me.et_agua3.Name = "et_agua3"
		Me.et_agua3.Size = New System.Drawing.Size(62, 16)
		Me.et_agua3.TabIndex = 18
		Me.et_agua3.Text = "Historial"
		'
		'agua_historial
		'
		Me.agua_historial.Font = New System.Drawing.Font("PF DinDisplay Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.agua_historial.Location = New System.Drawing.Point(99, 65)
		Me.agua_historial.Name = "agua_historial"
		Me.agua_historial.Size = New System.Drawing.Size(88, 23)
		Me.agua_historial.TabIndex = 17
		'
		'et_agua2
		'
		Me.et_agua2.AutoSize = True
		Me.et_agua2.Font = New System.Drawing.Font("PF DinDisplay Pro", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.et_agua2.Location = New System.Drawing.Point(8, 39)
		Me.et_agua2.Name = "et_agua2"
		Me.et_agua2.Size = New System.Drawing.Size(58, 16)
		Me.et_agua2.TabIndex = 16
		Me.et_agua2.Text = "Cuentas"
		'
		'agua_cuentas
		'
		Me.agua_cuentas.Font = New System.Drawing.Font("PF DinDisplay Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.agua_cuentas.Location = New System.Drawing.Point(99, 36)
		Me.agua_cuentas.Name = "agua_cuentas"
		Me.agua_cuentas.Size = New System.Drawing.Size(88, 23)
		Me.agua_cuentas.TabIndex = 15
		'
		'et_agua1
		'
		Me.et_agua1.AutoSize = True
		Me.et_agua1.Font = New System.Drawing.Font("PF DinDisplay Pro", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.et_agua1.Location = New System.Drawing.Point(8, 10)
		Me.et_agua1.Name = "et_agua1"
		Me.et_agua1.Size = New System.Drawing.Size(67, 16)
		Me.et_agua1.TabIndex = 14
		Me.et_agua1.Text = "Personas"
		'
		'agua_personas
		'
		Me.agua_personas.Font = New System.Drawing.Font("PF DinDisplay Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.agua_personas.Location = New System.Drawing.Point(99, 7)
		Me.agua_personas.Name = "agua_personas"
		Me.agua_personas.Size = New System.Drawing.Size(88, 23)
		Me.agua_personas.TabIndex = 13
		'
		'TabAuto
		'
		Me.TabAuto.BackColor = System.Drawing.Color.WhiteSmoke
		Me.TabAuto.Controls.Add(Me.et_vehi4)
		Me.TabAuto.Controls.Add(Me.auto_tipo)
		Me.TabAuto.Controls.Add(Me.et_vehi3)
		Me.TabAuto.Controls.Add(Me.auto_vencimientos)
		Me.TabAuto.Controls.Add(Me.et_vehi2)
		Me.TabAuto.Controls.Add(Me.auto_cuentas)
		Me.TabAuto.Controls.Add(Me.et_vehi1)
		Me.TabAuto.Controls.Add(Me.auto_personas)
		Me.TabAuto.Location = New System.Drawing.Point(4, 24)
		Me.TabAuto.Name = "TabAuto"
		Me.TabAuto.Padding = New System.Windows.Forms.Padding(3)
		Me.TabAuto.Size = New System.Drawing.Size(263, 183)
		Me.TabAuto.TabIndex = 1
		Me.TabAuto.Text = "Auto"
		'
		'et_vehi4
		'
		Me.et_vehi4.AutoSize = True
		Me.et_vehi4.Font = New System.Drawing.Font("PF DinDisplay Pro", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.et_vehi4.Location = New System.Drawing.Point(6, 98)
		Me.et_vehi4.Name = "et_vehi4"
		Me.et_vehi4.Size = New System.Drawing.Size(35, 16)
		Me.et_vehi4.TabIndex = 18
		Me.et_vehi4.Text = "Tipo"
		'
		'auto_tipo
		'
		Me.auto_tipo.Font = New System.Drawing.Font("PF DinDisplay Pro", 9.749999!)
		Me.auto_tipo.Location = New System.Drawing.Point(100, 95)
		Me.auto_tipo.Name = "auto_tipo"
		Me.auto_tipo.Size = New System.Drawing.Size(88, 23)
		Me.auto_tipo.TabIndex = 17
		'
		'et_vehi3
		'
		Me.et_vehi3.AutoSize = True
		Me.et_vehi3.Font = New System.Drawing.Font("PF DinDisplay Pro", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.et_vehi3.Location = New System.Drawing.Point(6, 69)
		Me.et_vehi3.Name = "et_vehi3"
		Me.et_vehi3.Size = New System.Drawing.Size(90, 16)
		Me.et_vehi3.TabIndex = 16
		Me.et_vehi3.Text = "Vencimientos"
		'
		'auto_vencimientos
		'
		Me.auto_vencimientos.Font = New System.Drawing.Font("PF DinDisplay Pro", 9.749999!)
		Me.auto_vencimientos.Location = New System.Drawing.Point(100, 66)
		Me.auto_vencimientos.Name = "auto_vencimientos"
		Me.auto_vencimientos.Size = New System.Drawing.Size(88, 23)
		Me.auto_vencimientos.TabIndex = 15
		'
		'et_vehi2
		'
		Me.et_vehi2.AutoSize = True
		Me.et_vehi2.Font = New System.Drawing.Font("PF DinDisplay Pro", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.et_vehi2.Location = New System.Drawing.Point(6, 41)
		Me.et_vehi2.Name = "et_vehi2"
		Me.et_vehi2.Size = New System.Drawing.Size(58, 16)
		Me.et_vehi2.TabIndex = 14
		Me.et_vehi2.Text = "Cuentas"
		'
		'auto_cuentas
		'
		Me.auto_cuentas.Font = New System.Drawing.Font("PF DinDisplay Pro", 9.749999!)
		Me.auto_cuentas.Location = New System.Drawing.Point(100, 38)
		Me.auto_cuentas.Name = "auto_cuentas"
		Me.auto_cuentas.Size = New System.Drawing.Size(88, 23)
		Me.auto_cuentas.TabIndex = 13
		'
		'et_vehi1
		'
		Me.et_vehi1.AutoSize = True
		Me.et_vehi1.Font = New System.Drawing.Font("PF DinDisplay Pro", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.et_vehi1.Location = New System.Drawing.Point(6, 12)
		Me.et_vehi1.Name = "et_vehi1"
		Me.et_vehi1.Size = New System.Drawing.Size(67, 16)
		Me.et_vehi1.TabIndex = 12
		Me.et_vehi1.Text = "Personas"
		'
		'auto_personas
		'
		Me.auto_personas.Font = New System.Drawing.Font("PF DinDisplay Pro", 9.749999!)
		Me.auto_personas.Location = New System.Drawing.Point(100, 9)
		Me.auto_personas.Name = "auto_personas"
		Me.auto_personas.Size = New System.Drawing.Size(88, 23)
		Me.auto_personas.TabIndex = 11
		'
		'TabCata
		'
		Me.TabCata.BackColor = System.Drawing.Color.WhiteSmoke
		Me.TabCata.Controls.Add(Me.et_cata5)
		Me.TabCata.Controls.Add(Me.cata_zonas)
		Me.TabCata.Controls.Add(Me.et_cata4)
		Me.TabCata.Controls.Add(Me.cata_vencimientos)
		Me.TabCata.Controls.Add(Me.et_cata3)
		Me.TabCata.Controls.Add(Me.cata_historial)
		Me.TabCata.Controls.Add(Me.et_cata2)
		Me.TabCata.Controls.Add(Me.cata_cuentas)
		Me.TabCata.Controls.Add(Me.et_cata1)
		Me.TabCata.Controls.Add(Me.cata_personas)
		Me.TabCata.Location = New System.Drawing.Point(4, 24)
		Me.TabCata.Name = "TabCata"
		Me.TabCata.Size = New System.Drawing.Size(263, 183)
		Me.TabCata.TabIndex = 2
		Me.TabCata.Text = "Catastro"
		'
		'et_cata5
		'
		Me.et_cata5.AutoSize = True
		Me.et_cata5.Font = New System.Drawing.Font("PF DinDisplay Pro", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.et_cata5.Location = New System.Drawing.Point(3, 126)
		Me.et_cata5.Name = "et_cata5"
		Me.et_cata5.Size = New System.Drawing.Size(46, 16)
		Me.et_cata5.TabIndex = 32
		Me.et_cata5.Text = "Zonas"
		'
		'cata_zonas
		'
		Me.cata_zonas.Font = New System.Drawing.Font("PF DinDisplay Pro", 9.749999!)
		Me.cata_zonas.Location = New System.Drawing.Point(95, 123)
		Me.cata_zonas.Name = "cata_zonas"
		Me.cata_zonas.Size = New System.Drawing.Size(88, 23)
		Me.cata_zonas.TabIndex = 31
		'
		'et_cata4
		'
		Me.et_cata4.AutoSize = True
		Me.et_cata4.Font = New System.Drawing.Font("PF DinDisplay Pro", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.et_cata4.Location = New System.Drawing.Point(3, 97)
		Me.et_cata4.Name = "et_cata4"
		Me.et_cata4.Size = New System.Drawing.Size(90, 16)
		Me.et_cata4.TabIndex = 30
		Me.et_cata4.Text = "Vencimientos"
		'
		'cata_vencimientos
		'
		Me.cata_vencimientos.Font = New System.Drawing.Font("PF DinDisplay Pro", 9.749999!)
		Me.cata_vencimientos.Location = New System.Drawing.Point(95, 94)
		Me.cata_vencimientos.Name = "cata_vencimientos"
		Me.cata_vencimientos.Size = New System.Drawing.Size(88, 23)
		Me.cata_vencimientos.TabIndex = 29
		'
		'et_cata3
		'
		Me.et_cata3.AutoSize = True
		Me.et_cata3.Font = New System.Drawing.Font("PF DinDisplay Pro", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.et_cata3.Location = New System.Drawing.Point(3, 68)
		Me.et_cata3.Name = "et_cata3"
		Me.et_cata3.Size = New System.Drawing.Size(62, 16)
		Me.et_cata3.TabIndex = 28
		Me.et_cata3.Text = "Historial"
		'
		'cata_historial
		'
		Me.cata_historial.Font = New System.Drawing.Font("PF DinDisplay Pro", 9.749999!)
		Me.cata_historial.Location = New System.Drawing.Point(95, 65)
		Me.cata_historial.Name = "cata_historial"
		Me.cata_historial.Size = New System.Drawing.Size(88, 23)
		Me.cata_historial.TabIndex = 27
		'
		'et_cata2
		'
		Me.et_cata2.AutoSize = True
		Me.et_cata2.Font = New System.Drawing.Font("PF DinDisplay Pro", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.et_cata2.Location = New System.Drawing.Point(3, 39)
		Me.et_cata2.Name = "et_cata2"
		Me.et_cata2.Size = New System.Drawing.Size(58, 16)
		Me.et_cata2.TabIndex = 26
		Me.et_cata2.Text = "Cuentas"
		'
		'cata_cuentas
		'
		Me.cata_cuentas.Font = New System.Drawing.Font("PF DinDisplay Pro", 9.749999!)
		Me.cata_cuentas.Location = New System.Drawing.Point(95, 36)
		Me.cata_cuentas.Name = "cata_cuentas"
		Me.cata_cuentas.Size = New System.Drawing.Size(88, 23)
		Me.cata_cuentas.TabIndex = 25
		'
		'et_cata1
		'
		Me.et_cata1.AutoSize = True
		Me.et_cata1.Font = New System.Drawing.Font("PF DinDisplay Pro", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.et_cata1.Location = New System.Drawing.Point(3, 10)
		Me.et_cata1.Name = "et_cata1"
		Me.et_cata1.Size = New System.Drawing.Size(67, 16)
		Me.et_cata1.TabIndex = 24
		Me.et_cata1.Text = "Personas"
		'
		'cata_personas
		'
		Me.cata_personas.Font = New System.Drawing.Font("PF DinDisplay Pro", 9.749999!)
		Me.cata_personas.Location = New System.Drawing.Point(95, 7)
		Me.cata_personas.Name = "cata_personas"
		Me.cata_personas.Size = New System.Drawing.Size(88, 23)
		Me.cata_personas.TabIndex = 23
		'
		'TabCome
		'
		Me.TabCome.BackColor = System.Drawing.Color.WhiteSmoke
		Me.TabCome.Controls.Add(Me.et_come6)
		Me.TabCome.Controls.Add(Me.come_variables)
		Me.TabCome.Controls.Add(Me.et_come5)
		Me.TabCome.Controls.Add(Me.come_actividades)
		Me.TabCome.Controls.Add(Me.et_come4)
		Me.TabCome.Controls.Add(Me.come_vencimientos)
		Me.TabCome.Controls.Add(Me.et_come3)
		Me.TabCome.Controls.Add(Me.come_historial)
		Me.TabCome.Controls.Add(Me.et_come2)
		Me.TabCome.Controls.Add(Me.come_cuentas)
		Me.TabCome.Controls.Add(Me.et_come1)
		Me.TabCome.Controls.Add(Me.come_personas)
		Me.TabCome.Location = New System.Drawing.Point(4, 24)
		Me.TabCome.Name = "TabCome"
		Me.TabCome.Size = New System.Drawing.Size(263, 183)
		Me.TabCome.TabIndex = 3
		Me.TabCome.Text = "Comercio"
		'
		'et_come6
		'
		Me.et_come6.AutoSize = True
		Me.et_come6.Font = New System.Drawing.Font("PF DinDisplay Pro", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.et_come6.Location = New System.Drawing.Point(7, 156)
		Me.et_come6.Name = "et_come6"
		Me.et_come6.Size = New System.Drawing.Size(66, 16)
		Me.et_come6.TabIndex = 36
		Me.et_come6.Text = "Variables"
		'
		'come_variables
		'
		Me.come_variables.Font = New System.Drawing.Font("PF DinDisplay Pro", 9.749999!)
		Me.come_variables.Location = New System.Drawing.Point(101, 153)
		Me.come_variables.Name = "come_variables"
		Me.come_variables.Size = New System.Drawing.Size(88, 23)
		Me.come_variables.TabIndex = 35
		'
		'et_come5
		'
		Me.et_come5.AutoSize = True
		Me.et_come5.Font = New System.Drawing.Font("PF DinDisplay Pro", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.et_come5.Location = New System.Drawing.Point(7, 127)
		Me.et_come5.Name = "et_come5"
		Me.et_come5.Size = New System.Drawing.Size(80, 16)
		Me.et_come5.TabIndex = 34
		Me.et_come5.Text = "Actividades"
		'
		'come_actividades
		'
		Me.come_actividades.Font = New System.Drawing.Font("PF DinDisplay Pro", 9.749999!)
		Me.come_actividades.Location = New System.Drawing.Point(101, 124)
		Me.come_actividades.Name = "come_actividades"
		Me.come_actividades.Size = New System.Drawing.Size(88, 23)
		Me.come_actividades.TabIndex = 33
		'
		'et_come4
		'
		Me.et_come4.AutoSize = True
		Me.et_come4.Font = New System.Drawing.Font("PF DinDisplay Pro", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.et_come4.Location = New System.Drawing.Point(7, 98)
		Me.et_come4.Name = "et_come4"
		Me.et_come4.Size = New System.Drawing.Size(90, 16)
		Me.et_come4.TabIndex = 32
		Me.et_come4.Text = "Vencimientos"
		'
		'come_vencimientos
		'
		Me.come_vencimientos.Font = New System.Drawing.Font("PF DinDisplay Pro", 9.749999!)
		Me.come_vencimientos.Location = New System.Drawing.Point(101, 95)
		Me.come_vencimientos.Name = "come_vencimientos"
		Me.come_vencimientos.Size = New System.Drawing.Size(88, 23)
		Me.come_vencimientos.TabIndex = 31
		'
		'et_come3
		'
		Me.et_come3.AutoSize = True
		Me.et_come3.Font = New System.Drawing.Font("PF DinDisplay Pro", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.et_come3.Location = New System.Drawing.Point(7, 69)
		Me.et_come3.Name = "et_come3"
		Me.et_come3.Size = New System.Drawing.Size(62, 16)
		Me.et_come3.TabIndex = 30
		Me.et_come3.Text = "Historial"
		'
		'come_historial
		'
		Me.come_historial.Font = New System.Drawing.Font("PF DinDisplay Pro", 9.749999!)
		Me.come_historial.Location = New System.Drawing.Point(101, 66)
		Me.come_historial.Name = "come_historial"
		Me.come_historial.Size = New System.Drawing.Size(88, 23)
		Me.come_historial.TabIndex = 29
		'
		'et_come2
		'
		Me.et_come2.AutoSize = True
		Me.et_come2.Font = New System.Drawing.Font("PF DinDisplay Pro", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.et_come2.Location = New System.Drawing.Point(7, 40)
		Me.et_come2.Name = "et_come2"
		Me.et_come2.Size = New System.Drawing.Size(58, 16)
		Me.et_come2.TabIndex = 28
		Me.et_come2.Text = "Cuentas"
		'
		'come_cuentas
		'
		Me.come_cuentas.Font = New System.Drawing.Font("PF DinDisplay Pro", 9.749999!)
		Me.come_cuentas.Location = New System.Drawing.Point(101, 37)
		Me.come_cuentas.Name = "come_cuentas"
		Me.come_cuentas.Size = New System.Drawing.Size(88, 23)
		Me.come_cuentas.TabIndex = 27
		'
		'et_come1
		'
		Me.et_come1.AutoSize = True
		Me.et_come1.Font = New System.Drawing.Font("PF DinDisplay Pro", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.et_come1.Location = New System.Drawing.Point(7, 11)
		Me.et_come1.Name = "et_come1"
		Me.et_come1.Size = New System.Drawing.Size(67, 16)
		Me.et_come1.TabIndex = 26
		Me.et_come1.Text = "Personas"
		'
		'come_personas
		'
		Me.come_personas.Font = New System.Drawing.Font("PF DinDisplay Pro", 9.749999!)
		Me.come_personas.Location = New System.Drawing.Point(101, 8)
		Me.come_personas.Name = "come_personas"
		Me.come_personas.Size = New System.Drawing.Size(88, 23)
		Me.come_personas.TabIndex = 25
		'
		'TabSepe
		'
		Me.TabSepe.BackColor = System.Drawing.Color.WhiteSmoke
		Me.TabSepe.Controls.Add(Me.et_sepe5)
		Me.TabSepe.Controls.Add(Me.sepe_variables)
		Me.TabSepe.Controls.Add(Me.et_sepe4)
		Me.TabSepe.Controls.Add(Me.sepe_muertos)
		Me.TabSepe.Controls.Add(Me.et_sepe3)
		Me.TabSepe.Controls.Add(Me.sepe_historial)
		Me.TabSepe.Controls.Add(Me.et_sepe2)
		Me.TabSepe.Controls.Add(Me.sepe_cuentas)
		Me.TabSepe.Controls.Add(Me.et_sepe1)
		Me.TabSepe.Controls.Add(Me.sepe_personas)
		Me.TabSepe.Location = New System.Drawing.Point(4, 24)
		Me.TabSepe.Name = "TabSepe"
		Me.TabSepe.Size = New System.Drawing.Size(263, 183)
		Me.TabSepe.TabIndex = 4
		Me.TabSepe.Text = "Sepelio"
		'
		'et_sepe5
		'
		Me.et_sepe5.AutoSize = True
		Me.et_sepe5.Font = New System.Drawing.Font("PF DinDisplay Pro", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.et_sepe5.Location = New System.Drawing.Point(7, 127)
		Me.et_sepe5.Name = "et_sepe5"
		Me.et_sepe5.Size = New System.Drawing.Size(66, 16)
		Me.et_sepe5.TabIndex = 20
		Me.et_sepe5.Text = "Variables"
		'
		'sepe_variables
		'
		Me.sepe_variables.Font = New System.Drawing.Font("PF DinDisplay Pro", 9.749999!)
		Me.sepe_variables.Location = New System.Drawing.Point(96, 124)
		Me.sepe_variables.Name = "sepe_variables"
		Me.sepe_variables.Size = New System.Drawing.Size(88, 23)
		Me.sepe_variables.TabIndex = 19
		Me.sepe_variables.Text = "sepevar"
		'
		'et_sepe4
		'
		Me.et_sepe4.AutoSize = True
		Me.et_sepe4.Font = New System.Drawing.Font("PF DinDisplay Pro", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.et_sepe4.Location = New System.Drawing.Point(7, 98)
		Me.et_sepe4.Name = "et_sepe4"
		Me.et_sepe4.Size = New System.Drawing.Size(59, 16)
		Me.et_sepe4.TabIndex = 18
		Me.et_sepe4.Text = "Muertos"
		'
		'sepe_muertos
		'
		Me.sepe_muertos.Font = New System.Drawing.Font("PF DinDisplay Pro", 9.749999!)
		Me.sepe_muertos.Location = New System.Drawing.Point(96, 95)
		Me.sepe_muertos.Name = "sepe_muertos"
		Me.sepe_muertos.Size = New System.Drawing.Size(88, 23)
		Me.sepe_muertos.TabIndex = 17
		'
		'et_sepe3
		'
		Me.et_sepe3.AutoSize = True
		Me.et_sepe3.Font = New System.Drawing.Font("PF DinDisplay Pro", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.et_sepe3.Location = New System.Drawing.Point(7, 69)
		Me.et_sepe3.Name = "et_sepe3"
		Me.et_sepe3.Size = New System.Drawing.Size(62, 16)
		Me.et_sepe3.TabIndex = 16
		Me.et_sepe3.Text = "Historial"
		'
		'sepe_historial
		'
		Me.sepe_historial.Font = New System.Drawing.Font("PF DinDisplay Pro", 9.749999!)
		Me.sepe_historial.Location = New System.Drawing.Point(96, 66)
		Me.sepe_historial.Name = "sepe_historial"
		Me.sepe_historial.Size = New System.Drawing.Size(88, 23)
		Me.sepe_historial.TabIndex = 15
		'
		'et_sepe2
		'
		Me.et_sepe2.AutoSize = True
		Me.et_sepe2.Font = New System.Drawing.Font("PF DinDisplay Pro", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.et_sepe2.Location = New System.Drawing.Point(7, 40)
		Me.et_sepe2.Name = "et_sepe2"
		Me.et_sepe2.Size = New System.Drawing.Size(58, 16)
		Me.et_sepe2.TabIndex = 14
		Me.et_sepe2.Text = "Cuentas"
		'
		'sepe_cuentas
		'
		Me.sepe_cuentas.Font = New System.Drawing.Font("PF DinDisplay Pro", 9.749999!)
		Me.sepe_cuentas.Location = New System.Drawing.Point(96, 37)
		Me.sepe_cuentas.Name = "sepe_cuentas"
		Me.sepe_cuentas.Size = New System.Drawing.Size(88, 23)
		Me.sepe_cuentas.TabIndex = 13
		'
		'et_sepe1
		'
		Me.et_sepe1.AutoSize = True
		Me.et_sepe1.Font = New System.Drawing.Font("PF DinDisplay Pro", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.et_sepe1.Location = New System.Drawing.Point(7, 11)
		Me.et_sepe1.Name = "et_sepe1"
		Me.et_sepe1.Size = New System.Drawing.Size(67, 16)
		Me.et_sepe1.TabIndex = 12
		Me.et_sepe1.Text = "Personas"
		'
		'sepe_personas
		'
		Me.sepe_personas.Font = New System.Drawing.Font("PF DinDisplay Pro", 9.749999!)
		Me.sepe_personas.Location = New System.Drawing.Point(96, 8)
		Me.sepe_personas.Name = "sepe_personas"
		Me.sepe_personas.Size = New System.Drawing.Size(88, 23)
		Me.sepe_personas.TabIndex = 11
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.rutina_fecha_null)
		Me.GroupBox1.Font = New System.Drawing.Font("PF DinDisplay Pro", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.GroupBox1.Location = New System.Drawing.Point(280, 3)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(155, 55)
		Me.GroupBox1.TabIndex = 28
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Rutinas"
		'
		'rutina_fecha_null
		'
		Me.rutina_fecha_null.Font = New System.Drawing.Font("PF DinDisplay Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.rutina_fecha_null.Location = New System.Drawing.Point(12, 22)
		Me.rutina_fecha_null.Name = "rutina_fecha_null"
		Me.rutina_fecha_null.Size = New System.Drawing.Size(138, 22)
		Me.rutina_fecha_null.TabIndex = 0
		Me.rutina_fecha_null.Text = "Reparar fechas NULL"
		Me.rutina_fecha_null.UseVisualStyleBackColor = True
		'
		'Label1
		'
		Me.Label1.BackColor = System.Drawing.Color.WhiteSmoke
		Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
		Me.Label1.Font = New System.Drawing.Font("PF DinText Pro", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(0, 26)
		Me.Label1.Margin = New System.Windows.Forms.Padding(0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(594, 23)
		Me.Label1.TabIndex = 31
		Me.Label1.Text = "CONEXIONES"
		'
		'Label3
		'
		Me.Label3.BackColor = System.Drawing.Color.WhiteSmoke
		Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
		Me.Label3.Font = New System.Drawing.Font("PF DinText Pro", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(0, 147)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(594, 23)
		Me.Label3.TabIndex = 32
		Me.Label3.Text = "TABLAS EXTERNAS"
		'
		'config
		'
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.BackColor = System.Drawing.Color.Gainsboro
		Me.ClientSize = New System.Drawing.Size(594, 392)
		Me.ControlBox = False
		Me.Controls.Add(Me.FlowLayoutPanel2)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.FlowLayoutPanel1)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.MenuStrip1)
		Me.Font = New System.Drawing.Font("PF DinDisplay Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MainMenuStrip = Me.MenuStrip1
		Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.Name = "config"
		Me.ShowInTaskbar = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "config"
		Me.MenuStrip1.ResumeLayout(False)
		Me.MenuStrip1.PerformLayout()
		Me.FlowLayoutPanel1.ResumeLayout(False)
		Me.FlowLayoutPanel1.PerformLayout()
		Me.FlowLayoutPanel2.ResumeLayout(False)
		Me.TabControl1.ResumeLayout(False)
		Me.TabAgua.ResumeLayout(False)
		Me.TabAgua.PerformLayout()
		Me.TabAuto.ResumeLayout(False)
		Me.TabAuto.PerformLayout()
		Me.TabCata.ResumeLayout(False)
		Me.TabCata.PerformLayout()
		Me.TabCome.ResumeLayout(False)
		Me.TabCome.PerformLayout()
		Me.TabSepe.ResumeLayout(False)
		Me.TabSepe.PerformLayout()
		Me.GroupBox1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
	Friend WithEvents OpcionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents RestablecerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents CerrarSinGuardarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents ImportarToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
	Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
	Friend WithEvents Label2 As Label
	Friend WithEvents conexion_std As TextBox
	Friend WithEvents Label6 As Label
	Friend WithEvents conexion_acc As TextBox
	Friend WithEvents Label5 As Label
	Friend WithEvents conexion_pgsql As TextBox
	Friend WithEvents Label4 As Label
	Friend WithEvents conexion_fox As TextBox
	Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
	Friend WithEvents TabControl1 As TabControl
	Friend WithEvents TabAgua As TabPage
	Friend WithEvents et_agua6 As Label
	Friend WithEvents agua_variables As TextBox
	Friend WithEvents et_agua5 As Label
	Friend WithEvents agua_zonas As TextBox
	Friend WithEvents et_agua4 As Label
	Friend WithEvents agua_vencimientos As TextBox
	Friend WithEvents et_agua3 As Label
	Friend WithEvents agua_historial As TextBox
	Friend WithEvents et_agua2 As Label
	Friend WithEvents agua_cuentas As TextBox
	Friend WithEvents et_agua1 As Label
	Friend WithEvents agua_personas As TextBox
	Friend WithEvents TabAuto As TabPage
	Friend WithEvents et_vehi4 As Label
	Friend WithEvents auto_tipo As TextBox
	Friend WithEvents et_vehi3 As Label
	Friend WithEvents auto_vencimientos As TextBox
	Friend WithEvents et_vehi2 As Label
	Friend WithEvents auto_cuentas As TextBox
	Friend WithEvents et_vehi1 As Label
	Friend WithEvents auto_personas As TextBox
	Friend WithEvents TabCata As TabPage
	Friend WithEvents et_cata5 As Label
	Friend WithEvents cata_zonas As TextBox
	Friend WithEvents et_cata4 As Label
	Friend WithEvents cata_vencimientos As TextBox
	Friend WithEvents et_cata3 As Label
	Friend WithEvents cata_historial As TextBox
	Friend WithEvents et_cata2 As Label
	Friend WithEvents cata_cuentas As TextBox
	Friend WithEvents et_cata1 As Label
	Friend WithEvents cata_personas As TextBox
	Friend WithEvents TabCome As TabPage
	Friend WithEvents et_come6 As Label
	Friend WithEvents come_variables As TextBox
	Friend WithEvents et_come5 As Label
	Friend WithEvents come_actividades As TextBox
	Friend WithEvents et_come4 As Label
	Friend WithEvents come_vencimientos As TextBox
	Friend WithEvents et_come3 As Label
	Friend WithEvents come_historial As TextBox
	Friend WithEvents et_come2 As Label
	Friend WithEvents come_cuentas As TextBox
	Friend WithEvents et_come1 As Label
	Friend WithEvents come_personas As TextBox
	Friend WithEvents TabSepe As TabPage
	Friend WithEvents et_sepe5 As Label
	Friend WithEvents sepe_variables As TextBox
	Friend WithEvents et_sepe4 As Label
	Friend WithEvents sepe_muertos As TextBox
	Friend WithEvents et_sepe3 As Label
	Friend WithEvents sepe_historial As TextBox
	Friend WithEvents et_sepe2 As Label
	Friend WithEvents sepe_cuentas As TextBox
	Friend WithEvents et_sepe1 As Label
	Friend WithEvents sepe_personas As TextBox
	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents rutina_fecha_null As Button
	Friend WithEvents Label1 As Label
	Friend WithEvents Label3 As Label
End Class
