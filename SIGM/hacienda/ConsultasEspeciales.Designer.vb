﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ConsultasEspeciales
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConsultasEspeciales))
        Me.QueryView = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripDropDownButton2 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.DBFoxMuniciToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DBAccessToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DBPostgreSQLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Connection = New System.Windows.Forms.ToolStripLabel()
        Me.CustomQuery = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.CustomTable = New System.Windows.Forms.LinkLabel()
        Me.bs_query = New System.Windows.Forms.BindingSource(Me.components)
        Me.GenSearchControl1 = New Sigm.genSearchControl()
        CType(Me.QueryView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.bs_query, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'QueryView
        '
        Me.QueryView.AllowUserToAddRows = False
        Me.QueryView.AllowUserToDeleteRows = False
        Me.QueryView.AllowUserToResizeRows = False
        Me.QueryView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.QueryView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.QueryView.Location = New System.Drawing.Point(0, 0)
        Me.QueryView.Name = "QueryView"
        Me.QueryView.ReadOnly = True
        Me.QueryView.RowHeadersVisible = False
        Me.QueryView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.QueryView.Size = New System.Drawing.Size(484, 381)
        Me.QueryView.TabIndex = 24
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.BindingNavigator1)
        Me.Panel2.Controls.Add(Me.QueryView)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 33)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(484, 381)
        Me.Panel2.TabIndex = 30
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Nothing
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator1.DeleteItem = Nothing
        Me.BindingNavigator1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 356)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator1.Size = New System.Drawing.Size(484, 25)
        Me.BindingNavigator1.TabIndex = 25
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.Font = New System.Drawing.Font("PF DinDisplay Pro Medium", 10.0!)
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripDropDownButton2, Me.Connection, Me.CustomQuery, Me.ToolStripLabel1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 435)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Padding = New System.Windows.Forms.Padding(0)
        Me.ToolStrip1.Size = New System.Drawing.Size(484, 26)
        Me.ToolStrip1.TabIndex = 31
        '
        'ToolStripDropDownButton2
        '
        Me.ToolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripDropDownButton2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DBFoxMuniciToolStripMenuItem, Me.DBAccessToolStripMenuItem, Me.DBPostgreSQLToolStripMenuItem})
        Me.ToolStripDropDownButton2.Image = CType(resources.GetObject("ToolStripDropDownButton2.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton2.Name = "ToolStripDropDownButton2"
        Me.ToolStripDropDownButton2.Size = New System.Drawing.Size(89, 23)
        Me.ToolStripDropDownButton2.Text = "Conexiones"
        '
        'DBFoxMuniciToolStripMenuItem
        '
        Me.DBFoxMuniciToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.DBFoxMuniciToolStripMenuItem.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
        Me.DBFoxMuniciToolStripMenuItem.Name = "DBFoxMuniciToolStripMenuItem"
        Me.DBFoxMuniciToolStripMenuItem.Size = New System.Drawing.Size(179, 24)
        Me.DBFoxMuniciToolStripMenuItem.Text = "DB Fox (Munici)"
        '
        'DBAccessToolStripMenuItem
        '
        Me.DBAccessToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.DBAccessToolStripMenuItem.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
        Me.DBAccessToolStripMenuItem.Name = "DBAccessToolStripMenuItem"
        Me.DBAccessToolStripMenuItem.Size = New System.Drawing.Size(179, 24)
        Me.DBAccessToolStripMenuItem.Text = "DB Access"
        '
        'DBPostgreSQLToolStripMenuItem
        '
        Me.DBPostgreSQLToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.DBPostgreSQLToolStripMenuItem.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
        Me.DBPostgreSQLToolStripMenuItem.Name = "DBPostgreSQLToolStripMenuItem"
        Me.DBPostgreSQLToolStripMenuItem.Size = New System.Drawing.Size(179, 24)
        Me.DBPostgreSQLToolStripMenuItem.Text = "DB PostgreSQL"
        '
        'Connection
        '
        Me.Connection.Font = New System.Drawing.Font("PF DinDisplay Pro Medium", 10.0!)
        Me.Connection.Margin = New System.Windows.Forms.Padding(3)
        Me.Connection.Name = "Connection"
        Me.Connection.Size = New System.Drawing.Size(292, 20)
        Me.Connection.Text = "Seleccione una base de datos antes de continuar."
        '
        'CustomQuery
        '
        Me.CustomQuery.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.CustomQuery.AutoSize = False
        Me.CustomQuery.DropDownWidth = 150
        Me.CustomQuery.Font = New System.Drawing.Font("PF DinDisplay Pro", 9.749999!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustomQuery.Name = "CustomQuery"
        Me.CustomQuery.Size = New System.Drawing.Size(121, 23)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel1.AutoSize = False
        Me.ToolStripLabel1.Font = New System.Drawing.Font("PF DinDisplay Pro", 10.0!, System.Drawing.FontStyle.Italic)
        Me.ToolStripLabel1.Margin = New System.Windows.Forms.Padding(3)
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(80, 20)
        Me.ToolStripLabel1.Text = "Consulta"
        Me.ToolStripLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CustomTable
        '
        Me.CustomTable.ActiveLinkColor = System.Drawing.Color.Blue
        Me.CustomTable.DisabledLinkColor = System.Drawing.Color.Blue
        Me.CustomTable.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.CustomTable.Enabled = False
        Me.CustomTable.Location = New System.Drawing.Point(0, 414)
        Me.CustomTable.Name = "CustomTable"
        Me.CustomTable.Size = New System.Drawing.Size(484, 21)
        Me.CustomTable.TabIndex = 33
        Me.CustomTable.TabStop = True
        Me.CustomTable.Text = "Seleccionar tabla.."
        Me.CustomTable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CustomTable.VisitedLinkColor = System.Drawing.Color.Blue
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
        Me.GenSearchControl1.Size = New System.Drawing.Size(520, 33)
        Me.GenSearchControl1.TabIndex = 34
        '
        'ConsultasEspeciales
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(484, 461)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.GenSearchControl1)
        Me.Controls.Add(Me.CustomTable)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MinimumSize = New System.Drawing.Size(500, 500)
        Me.Name = "ConsultasEspeciales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Otras Consultas"
        CType(Me.QueryView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.bs_query, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents QueryView As DataGridView
	Friend WithEvents Panel2 As Panel
	Friend WithEvents ToolStrip1 As ToolStrip
	Friend WithEvents ToolStripDropDownButton2 As ToolStripDropDownButton
	Friend WithEvents DBFoxMuniciToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents DBAccessToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents DBPostgreSQLToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents Connection As ToolStripLabel
	Friend WithEvents CustomTable As LinkLabel
	Friend WithEvents RadioButton1 As RadioButton
	Friend WithEvents bs_query As BindingSource
	Friend WithEvents ToolStripLabel1 As ToolStripLabel
	Friend WithEvents CustomQuery As ToolStripComboBox
	Friend WithEvents GenSearchControl1 As genSearchControl
    Friend WithEvents BindingNavigator1 As BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
End Class
