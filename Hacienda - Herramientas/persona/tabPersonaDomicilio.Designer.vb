﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class tabPersonaDomicilio
	'UserControl overrides dispose to clean up the component list.
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
		Me.TabControl1 = New System.Windows.Forms.TabControl()
		Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
		Me.DelDomicilio = New System.Windows.Forms.Button()
		Me.AddDomicilio = New System.Windows.Forms.Button()
		Me.FlowLayoutPanel1.SuspendLayout()
		Me.SuspendLayout()
		'
		'TabControl1
		'
		Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.TabControl1.Location = New System.Drawing.Point(0, 0)
		Me.TabControl1.Margin = New System.Windows.Forms.Padding(0)
		Me.TabControl1.Name = "TabControl1"
		Me.TabControl1.SelectedIndex = 0
		Me.TabControl1.Size = New System.Drawing.Size(547, 295)
		Me.TabControl1.TabIndex = 407
		'
		'FlowLayoutPanel1
		'
		Me.FlowLayoutPanel1.Controls.Add(Me.AddDomicilio)
		Me.FlowLayoutPanel1.Controls.Add(Me.DelDomicilio)
		Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 295)
		Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
		Me.FlowLayoutPanel1.Size = New System.Drawing.Size(547, 30)
		Me.FlowLayoutPanel1.TabIndex = 411
		'
		'DelDomicilio
		'
		Me.DelDomicilio.FlatAppearance.BorderSize = 0
		Me.DelDomicilio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.DelDomicilio.Font = New System.Drawing.Font("PF DinDisplay Pro", 10.0!)
		Me.DelDomicilio.ForeColor = System.Drawing.Color.White
		Me.DelDomicilio.Location = New System.Drawing.Point(129, 3)
		Me.DelDomicilio.Name = "DelDomicilio"
		Me.DelDomicilio.Size = New System.Drawing.Size(120, 23)
		Me.DelDomicilio.TabIndex = 409
		Me.DelDomicilio.Text = "Eliminar Domicilio"
		Me.DelDomicilio.UseVisualStyleBackColor = False
		'
		'AddDomicilio
		'
		Me.AddDomicilio.FlatAppearance.BorderSize = 0
		Me.AddDomicilio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.AddDomicilio.Font = New System.Drawing.Font("PF DinDisplay Pro", 10.0!)
		Me.AddDomicilio.ForeColor = System.Drawing.Color.White
		Me.AddDomicilio.Location = New System.Drawing.Point(3, 3)
		Me.AddDomicilio.Name = "AddDomicilio"
		Me.AddDomicilio.Size = New System.Drawing.Size(120, 23)
		Me.AddDomicilio.TabIndex = 408
		Me.AddDomicilio.Text = "Nuevo Domicilio"
		Me.AddDomicilio.UseVisualStyleBackColor = False
		'
		'tabDomicilio
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.ControlDark
		Me.Controls.Add(Me.TabControl1)
		Me.Controls.Add(Me.FlowLayoutPanel1)
		Me.Font = New System.Drawing.Font("PF DinDisplay Pro", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Margin = New System.Windows.Forms.Padding(0)
		Me.Name = "tabDomicilio"
		Me.Size = New System.Drawing.Size(547, 325)
		Me.FlowLayoutPanel1.ResumeLayout(False)
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents TabControl1 As TabControl
	Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
	Friend WithEvents AddDomicilio As Button
	Friend WithEvents DelDomicilio As Button
End Class