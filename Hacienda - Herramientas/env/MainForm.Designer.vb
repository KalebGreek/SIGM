<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
		Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
		Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
		Me.progreso = New System.Windows.Forms.ToolStripProgressBar()
		Me.StatusStrip1.SuspendLayout()
		Me.SuspendLayout()
		'
		'StatusStrip1
		'
		Me.StatusStrip1.Font = New System.Drawing.Font("PF DinDisplay Pro", 11.0!)
		Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel2, Me.progreso})
		Me.StatusStrip1.Location = New System.Drawing.Point(0, 415)
		Me.StatusStrip1.Name = "StatusStrip1"
		Me.StatusStrip1.Size = New System.Drawing.Size(990, 22)
		Me.StatusStrip1.SizingGrip = False
		Me.StatusStrip1.TabIndex = 386
		Me.StatusStrip1.Text = "StatusStrip1"
		'
		'ToolStripStatusLabel2
		'
		Me.ToolStripStatusLabel2.BackColor = System.Drawing.Color.Transparent
		Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
		Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(975, 17)
		Me.ToolStripStatusLabel2.Spring = True
		'
		'progreso
		'
		Me.progreso.Name = "progreso"
		Me.progreso.Size = New System.Drawing.Size(150, 17)
		Me.progreso.Step = 1
		Me.progreso.Visible = False
		'
		'MainForm
		'
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.ClientSize = New System.Drawing.Size(990, 437)
		Me.Controls.Add(Me.StatusStrip1)
		Me.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.IsMdiContainer = True
		Me.Margin = New System.Windows.Forms.Padding(4)
		Me.MinimumSize = New System.Drawing.Size(625, 425)
		Me.Name = "MainForm"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "SIGM"
		Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
		Me.StatusStrip1.ResumeLayout(False)
		Me.StatusStrip1.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
	Friend WithEvents progreso As System.Windows.Forms.ToolStripProgressBar
End Class
