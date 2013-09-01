<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class subindex
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(subindex))
        Me.btndisplayidname = New System.Windows.Forms.Button()
        Me.btndisplayexcel = New System.Windows.Forms.Button()
        Me.DGV1 = New System.Windows.Forms.DataGridView()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btndisplayidname
        '
        Me.btndisplayidname.Font = New System.Drawing.Font("Consolas", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndisplayidname.Location = New System.Drawing.Point(25, 29)
        Me.btndisplayidname.Name = "btndisplayidname"
        Me.btndisplayidname.Size = New System.Drawing.Size(230, 177)
        Me.btndisplayidname.TabIndex = 0
        Me.btndisplayidname.Text = "Display All Names of Faculty"
        Me.btndisplayidname.UseVisualStyleBackColor = True
        '
        'btndisplayexcel
        '
        Me.btndisplayexcel.Font = New System.Drawing.Font("Consolas", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndisplayexcel.Location = New System.Drawing.Point(25, 323)
        Me.btndisplayexcel.Name = "btndisplayexcel"
        Me.btndisplayexcel.Size = New System.Drawing.Size(230, 177)
        Me.btndisplayexcel.TabIndex = 1
        Me.btndisplayexcel.Text = "Display Timetable of Particular Teacher"
        Me.btndisplayexcel.UseVisualStyleBackColor = True
        '
        'DGV1
        '
        Me.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV1.Location = New System.Drawing.Point(433, 122)
        Me.DGV1.Name = "DGV1"
        Me.DGV1.Size = New System.Drawing.Size(212, 271)
        Me.DGV1.TabIndex = 2
        Me.DGV1.Visible = False
        '
        'btnexit
        '
        Me.btnexit.Font = New System.Drawing.Font("Consolas", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexit.Location = New System.Drawing.Point(811, 29)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(230, 177)
        Me.btnexit.TabIndex = 3
        Me.btnexit.Text = "Exit"
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Consolas", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(811, 323)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(230, 177)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Settings"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'subindex
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1053, 492)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.DGV1)
        Me.Controls.Add(Me.btndisplayexcel)
        Me.Controls.Add(Me.btndisplayidname)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "subindex"
        Me.Text = "subindex"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btndisplayidname As System.Windows.Forms.Button
    Friend WithEvents btndisplayexcel As System.Windows.Forms.Button
    Friend WithEvents DGV1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnexit As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
