<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CtrlVenceImpuesto
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.todo = New System.Windows.Forms.RadioButton()
        Me.cuota1 = New System.Windows.Forms.RadioButton()
        Me.vence1 = New System.Windows.Forms.TextBox()
        Me.cuota2 = New System.Windows.Forms.RadioButton()
        Me.vence2 = New System.Windows.Forms.TextBox()
        Me.cuota3 = New System.Windows.Forms.RadioButton()
        Me.vence3 = New System.Windows.Forms.TextBox()
        Me.cuota4 = New System.Windows.Forms.RadioButton()
        Me.vence4 = New System.Windows.Forms.TextBox()
        Me.cuota5 = New System.Windows.Forms.RadioButton()
        Me.vence5 = New System.Windows.Forms.TextBox()
        Me.cuota6 = New System.Windows.Forms.RadioButton()
        Me.vence6 = New System.Windows.Forms.TextBox()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.FlowLayoutPanel1.Controls.Add(Me.Label1)
        Me.FlowLayoutPanel1.Controls.Add(Me.todo)
        Me.FlowLayoutPanel1.Controls.Add(Me.cuota1)
        Me.FlowLayoutPanel1.Controls.Add(Me.vence1)
        Me.FlowLayoutPanel1.Controls.Add(Me.cuota2)
        Me.FlowLayoutPanel1.Controls.Add(Me.vence2)
        Me.FlowLayoutPanel1.Controls.Add(Me.cuota3)
        Me.FlowLayoutPanel1.Controls.Add(Me.vence3)
        Me.FlowLayoutPanel1.Controls.Add(Me.cuota4)
        Me.FlowLayoutPanel1.Controls.Add(Me.vence4)
        Me.FlowLayoutPanel1.Controls.Add(Me.cuota5)
        Me.FlowLayoutPanel1.Controls.Add(Me.vence5)
        Me.FlowLayoutPanel1.Controls.Add(Me.cuota6)
        Me.FlowLayoutPanel1.Controls.Add(Me.vence6)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(200, 240)
        Me.FlowLayoutPanel1.TabIndex = 72
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(197, 25)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = " Vencimientos"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'todo
        '
        Me.todo.Checked = True
        Me.todo.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.todo.Location = New System.Drawing.Point(2, 27)
        Me.todo.Margin = New System.Windows.Forms.Padding(2)
        Me.todo.Name = "todo"
        Me.todo.Size = New System.Drawing.Size(195, 23)
        Me.todo.TabIndex = 31
        Me.todo.TabStop = True
        Me.todo.Text = "Todas las cuotas"
        Me.todo.UseVisualStyleBackColor = True
        '
        'cuota1
        '
        Me.cuota1.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cuota1.Location = New System.Drawing.Point(2, 54)
        Me.cuota1.Margin = New System.Windows.Forms.Padding(2)
        Me.cuota1.Name = "cuota1"
        Me.cuota1.Size = New System.Drawing.Size(77, 25)
        Me.cuota1.TabIndex = 25
        Me.cuota1.Text = "Cuota 1"
        Me.cuota1.UseVisualStyleBackColor = True
        '
        'vence1
        '
        Me.vence1.Enabled = False
        Me.vence1.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vence1.Location = New System.Drawing.Point(83, 54)
        Me.vence1.Margin = New System.Windows.Forms.Padding(2)
        Me.vence1.Name = "vence1"
        Me.vence1.Size = New System.Drawing.Size(113, 27)
        Me.vence1.TabIndex = 22
        Me.vence1.Text = "No hay datos"
        '
        'cuota2
        '
        Me.cuota2.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cuota2.Location = New System.Drawing.Point(2, 85)
        Me.cuota2.Margin = New System.Windows.Forms.Padding(2)
        Me.cuota2.Name = "cuota2"
        Me.cuota2.Size = New System.Drawing.Size(77, 25)
        Me.cuota2.TabIndex = 26
        Me.cuota2.Text = "Cuota 2"
        Me.cuota2.UseVisualStyleBackColor = True
        '
        'vence2
        '
        Me.vence2.Enabled = False
        Me.vence2.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vence2.Location = New System.Drawing.Point(83, 85)
        Me.vence2.Margin = New System.Windows.Forms.Padding(2)
        Me.vence2.Name = "vence2"
        Me.vence2.Size = New System.Drawing.Size(113, 27)
        Me.vence2.TabIndex = 21
        Me.vence2.Text = "No hay datos"
        '
        'cuota3
        '
        Me.cuota3.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cuota3.Location = New System.Drawing.Point(2, 116)
        Me.cuota3.Margin = New System.Windows.Forms.Padding(2)
        Me.cuota3.Name = "cuota3"
        Me.cuota3.Size = New System.Drawing.Size(77, 25)
        Me.cuota3.TabIndex = 27
        Me.cuota3.Text = "Cuota 3"
        Me.cuota3.UseVisualStyleBackColor = True
        '
        'vence3
        '
        Me.vence3.Enabled = False
        Me.vence3.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vence3.Location = New System.Drawing.Point(83, 116)
        Me.vence3.Margin = New System.Windows.Forms.Padding(2)
        Me.vence3.Name = "vence3"
        Me.vence3.Size = New System.Drawing.Size(113, 27)
        Me.vence3.TabIndex = 23
        Me.vence3.Text = "No hay datos"
        '
        'cuota4
        '
        Me.cuota4.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cuota4.Location = New System.Drawing.Point(2, 147)
        Me.cuota4.Margin = New System.Windows.Forms.Padding(2)
        Me.cuota4.Name = "cuota4"
        Me.cuota4.Size = New System.Drawing.Size(76, 25)
        Me.cuota4.TabIndex = 28
        Me.cuota4.Text = "Cuota 4"
        Me.cuota4.UseVisualStyleBackColor = True
        '
        'vence4
        '
        Me.vence4.Enabled = False
        Me.vence4.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vence4.Location = New System.Drawing.Point(82, 147)
        Me.vence4.Margin = New System.Windows.Forms.Padding(2)
        Me.vence4.Name = "vence4"
        Me.vence4.Size = New System.Drawing.Size(113, 27)
        Me.vence4.TabIndex = 19
        Me.vence4.Text = "No hay datos"
        '
        'cuota5
        '
        Me.cuota5.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cuota5.Location = New System.Drawing.Point(2, 178)
        Me.cuota5.Margin = New System.Windows.Forms.Padding(2)
        Me.cuota5.Name = "cuota5"
        Me.cuota5.Size = New System.Drawing.Size(77, 25)
        Me.cuota5.TabIndex = 29
        Me.cuota5.Text = "Cuota 5"
        Me.cuota5.UseVisualStyleBackColor = True
        '
        'vence5
        '
        Me.vence5.Enabled = False
        Me.vence5.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vence5.Location = New System.Drawing.Point(83, 178)
        Me.vence5.Margin = New System.Windows.Forms.Padding(2)
        Me.vence5.Name = "vence5"
        Me.vence5.Size = New System.Drawing.Size(113, 27)
        Me.vence5.TabIndex = 24
        Me.vence5.Text = "No hay datos"
        '
        'cuota6
        '
        Me.cuota6.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cuota6.Location = New System.Drawing.Point(2, 209)
        Me.cuota6.Margin = New System.Windows.Forms.Padding(2)
        Me.cuota6.Name = "cuota6"
        Me.cuota6.Size = New System.Drawing.Size(77, 25)
        Me.cuota6.TabIndex = 30
        Me.cuota6.Text = "Cuota 6"
        Me.cuota6.UseVisualStyleBackColor = True
        '
        'vence6
        '
        Me.vence6.Enabled = False
        Me.vence6.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vence6.Location = New System.Drawing.Point(83, 209)
        Me.vence6.Margin = New System.Windows.Forms.Padding(2)
        Me.vence6.Name = "vence6"
        Me.vence6.Size = New System.Drawing.Size(113, 27)
        Me.vence6.TabIndex = 20
        Me.vence6.Text = "No hay datos"
        '
        'ControlVencimiento
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Font = New System.Drawing.Font("PF DinDisplay Pro", 12.0!)
        Me.Name = "ControlVencimiento"
        Me.Size = New System.Drawing.Size(200, 240)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents todo As RadioButton
    Friend WithEvents cuota6 As RadioButton
    Friend WithEvents cuota1 As RadioButton
    Friend WithEvents cuota5 As RadioButton
    Friend WithEvents cuota4 As RadioButton
    Friend WithEvents cuota2 As RadioButton
    Friend WithEvents vence5 As TextBox
    Friend WithEvents vence1 As TextBox
    Friend WithEvents vence2 As TextBox
    Friend WithEvents vence6 As TextBox
    Friend WithEvents vence4 As TextBox
    Friend WithEvents cuota3 As RadioButton
    Friend WithEvents vence3 As TextBox
    Friend WithEvents Label1 As Label
End Class
