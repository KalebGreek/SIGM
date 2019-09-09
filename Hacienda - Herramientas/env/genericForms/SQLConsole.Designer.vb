<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SQLConsole
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SQLConsole))
        Me.QueryResult = New System.Windows.Forms.DataGridView()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.nav_result = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.bs_result = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.QueryLog = New System.Windows.Forms.ListBox()
        Me.TableList = New System.Windows.Forms.ListBox()
        Me.query = New System.Windows.Forms.ComboBox()
        Me.connection = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.AddScript = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.QueryResult, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.nav_result, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.nav_result.SuspendLayout()
        CType(Me.bs_result, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'QueryResult
        '
        Me.QueryResult.AllowUserToAddRows = False
        Me.QueryResult.AllowUserToDeleteRows = False
        Me.QueryResult.AllowUserToOrderColumns = True
        Me.QueryResult.AllowUserToResizeRows = False
        Me.QueryResult.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.QueryResult.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.QueryResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.QueryResult.Dock = System.Windows.Forms.DockStyle.Fill
        Me.QueryResult.Location = New System.Drawing.Point(0, 0)
        Me.QueryResult.Margin = New System.Windows.Forms.Padding(0)
        Me.QueryResult.Name = "QueryResult"
        Me.QueryResult.ReadOnly = True
        Me.QueryResult.RowHeadersVisible = False
        Me.QueryResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.QueryResult.ShowEditingIcon = False
        Me.QueryResult.Size = New System.Drawing.Size(616, 206)
        Me.QueryResult.TabIndex = 2
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.QueryResult)
        Me.SplitContainer1.Panel1.Controls.Add(Me.nav_result)
        Me.SplitContainer1.Panel1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.QueryLog)
        Me.SplitContainer1.Panel2.Controls.Add(Me.TableList)
        Me.SplitContainer1.Size = New System.Drawing.Size(616, 347)
        Me.SplitContainer1.SplitterDistance = 224
        Me.SplitContainer1.TabIndex = 3
        '
        'nav_result
        '
        Me.nav_result.AddNewItem = Nothing
        Me.nav_result.AutoSize = False
        Me.nav_result.BindingSource = Me.bs_result
        Me.nav_result.CountItem = Me.BindingNavigatorCountItem
        Me.nav_result.DeleteItem = Nothing
        Me.nav_result.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.nav_result.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nav_result.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.nav_result.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.nav_result.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2})
        Me.nav_result.Location = New System.Drawing.Point(0, 206)
        Me.nav_result.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.nav_result.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.nav_result.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.nav_result.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.nav_result.Name = "nav_result"
        Me.nav_result.PositionItem = Me.BindingNavigatorPositionItem
        Me.nav_result.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.nav_result.ShowItemToolTips = False
        Me.nav_result.Size = New System.Drawing.Size(616, 18)
        Me.nav_result.TabIndex = 4
        Me.nav_result.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(49, 15)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(24, 15)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(24, 15)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 18)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 22)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 18)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(24, 15)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(24, 15)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 18)
        '
        'QueryLog
        '
        Me.QueryLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.QueryLog.Dock = System.Windows.Forms.DockStyle.Fill
        Me.QueryLog.FormattingEnabled = True
        Me.QueryLog.Location = New System.Drawing.Point(0, 0)
        Me.QueryLog.Margin = New System.Windows.Forms.Padding(0)
        Me.QueryLog.Name = "QueryLog"
        Me.QueryLog.ScrollAlwaysVisible = True
        Me.QueryLog.Size = New System.Drawing.Size(456, 119)
        Me.QueryLog.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.QueryLog, "Info")
        '
        'TableList
        '
        Me.TableList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TableList.Dock = System.Windows.Forms.DockStyle.Right
        Me.TableList.FormattingEnabled = True
        Me.TableList.Location = New System.Drawing.Point(456, 0)
        Me.TableList.Margin = New System.Windows.Forms.Padding(0)
        Me.TableList.Name = "TableList"
        Me.TableList.ScrollAlwaysVisible = True
        Me.TableList.Size = New System.Drawing.Size(160, 119)
        Me.TableList.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.TableList, "Info")
        '
        'query
        '
        Me.query.Dock = System.Windows.Forms.DockStyle.Fill
        Me.query.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.query.FormattingEnabled = True
        Me.query.Location = New System.Drawing.Point(0, 0)
        Me.query.Margin = New System.Windows.Forms.Padding(0)
        Me.query.Name = "query"
        Me.query.Size = New System.Drawing.Size(456, 23)
        Me.query.TabIndex = 6
        '
        'connection
        '
        Me.connection.Dock = System.Windows.Forms.DockStyle.Right
        Me.connection.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.connection.FormattingEnabled = True
        Me.connection.Location = New System.Drawing.Point(456, 0)
        Me.connection.Margin = New System.Windows.Forms.Padding(0)
        Me.connection.Name = "connection"
        Me.connection.Size = New System.Drawing.Size(160, 23)
        Me.connection.TabIndex = 7
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.AddScript)
        Me.Panel1.Controls.Add(Me.query)
        Me.Panel1.Controls.Add(Me.connection)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 347)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(616, 24)
        Me.Panel1.TabIndex = 8
        '
        'AddScript
        '
        Me.AddScript.Dock = System.Windows.Forms.DockStyle.Right
        Me.AddScript.FlatAppearance.BorderSize = 0
        Me.AddScript.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddScript.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddScript.Location = New System.Drawing.Point(437, 0)
        Me.AddScript.Margin = New System.Windows.Forms.Padding(0)
        Me.AddScript.Name = "AddScript"
        Me.AddScript.Size = New System.Drawing.Size(19, 24)
        Me.AddScript.TabIndex = 5
        Me.AddScript.Text = "+"
        Me.ToolTip1.SetToolTip(Me.AddScript, "Add Script File")
        Me.AddScript.UseVisualStyleBackColor = True
        '
        'ToolTip1
        '
        Me.ToolTip1.AutomaticDelay = 200
        Me.ToolTip1.AutoPopDelay = 10000
        Me.ToolTip1.InitialDelay = 200
        Me.ToolTip1.ReshowDelay = 40
        Me.ToolTip1.UseAnimation = False
        Me.ToolTip1.UseFading = False
        '
        'SQLConsole
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(616, 371)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "SQLConsole"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SQLConsole"
        CType(Me.QueryResult, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.nav_result, System.ComponentModel.ISupportInitialize).EndInit()
        Me.nav_result.ResumeLayout(False)
        Me.nav_result.PerformLayout()
        CType(Me.bs_result, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents QueryResult As DataGridView
	Friend WithEvents SplitContainer1 As SplitContainer
	Friend WithEvents nav_result As BindingNavigator
	Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
	Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
	Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
	Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
	Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
	Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
	Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
	Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
	Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
	Friend WithEvents bs_result As BindingSource
	Friend WithEvents query As ComboBox
	Friend WithEvents connection As ComboBox
	Friend WithEvents Panel1 As Panel
	Friend WithEvents QueryLog As ListBox
	Friend WithEvents ToolTip1 As ToolTip
	Friend WithEvents TableList As ListBox
	Friend WithEvents AddScript As Button
End Class
