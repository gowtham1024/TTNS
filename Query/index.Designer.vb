<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class index
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(index))
        Me.btnemail = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btnmore = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnemail
        '
        Me.btnemail.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnemail.Font = New System.Drawing.Font("Lucida Calligraphy", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnemail.Location = New System.Drawing.Point(127, 125)
        Me.btnemail.Name = "btnemail"
        Me.btnemail.Size = New System.Drawing.Size(199, 67)
        Me.btnemail.TabIndex = 0
        Me.btnemail.Text = "Email"
        Me.btnemail.UseVisualStyleBackColor = False
        '
        'btn2
        '
        Me.btn2.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btn2.Font = New System.Drawing.Font("Lucida Calligraphy", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn2.Location = New System.Drawing.Point(1000, 125)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(199, 67)
        Me.btn2.TabIndex = 1
        Me.btn2.Text = "Automatic Email " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btn2.UseVisualStyleBackColor = False
        '
        'btnmore
        '
        Me.btnmore.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnmore.Font = New System.Drawing.Font("Lucida Calligraphy", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmore.Location = New System.Drawing.Point(127, 509)
        Me.btnmore.Name = "btnmore"
        Me.btnmore.Size = New System.Drawing.Size(199, 65)
        Me.btnmore.TabIndex = 2
        Me.btnmore.Text = "Advanced"
        Me.btnmore.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Button4.Font = New System.Drawing.Font("Lucida Calligraphy", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(1000, 529)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(199, 65)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Exit"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Button1.Font = New System.Drawing.Font("Lucida Calligraphy", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(506, 287)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(199, 67)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Exam "
        Me.Button1.UseVisualStyleBackColor = False
        '
        'index
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Query.My.Resources.Resources.sending_e_mail_template_backgrounds
        Me.ClientSize = New System.Drawing.Size(1211, 640)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.btnmore)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.btnemail)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "index"
        Me.Text = "index"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnemail As System.Windows.Forms.Button
    Friend WithEvents btn2 As System.Windows.Forms.Button
    Friend WithEvents btnmore As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
