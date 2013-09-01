<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login))
        Me.btnlogin = New System.Windows.Forms.Button()
        Me.btnreset = New System.Windows.Forms.Button()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.lbluname = New System.Windows.Forms.Label()
        Me.lblpass = New System.Windows.Forms.Label()
        Me.txtloginname = New System.Windows.Forms.TextBox()
        Me.txtloginpass = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnlogin
        '
        Me.btnlogin.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnlogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlogin.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnlogin.Location = New System.Drawing.Point(506, 662)
        Me.btnlogin.Name = "btnlogin"
        Me.btnlogin.Size = New System.Drawing.Size(89, 32)
        Me.btnlogin.TabIndex = 0
        Me.btnlogin.Text = "Login"
        Me.btnlogin.UseVisualStyleBackColor = False
        '
        'btnreset
        '
        Me.btnreset.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnreset.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreset.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnreset.Location = New System.Drawing.Point(649, 661)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Size = New System.Drawing.Size(87, 32)
        Me.btnreset.TabIndex = 1
        Me.btnreset.Text = "Reset"
        Me.btnreset.UseVisualStyleBackColor = False
        '
        'btnexit
        '
        Me.btnexit.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnexit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexit.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnexit.Location = New System.Drawing.Point(779, 661)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(86, 33)
        Me.btnexit.TabIndex = 2
        Me.btnexit.Text = "Exit"
        Me.btnexit.UseVisualStyleBackColor = False
        '
        'lbluname
        '
        Me.lbluname.AutoSize = True
        Me.lbluname.BackColor = System.Drawing.Color.Transparent
        Me.lbluname.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbluname.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbluname.Location = New System.Drawing.Point(26, 228)
        Me.lbluname.Name = "lbluname"
        Me.lbluname.Size = New System.Drawing.Size(113, 18)
        Me.lbluname.TabIndex = 3
        Me.lbluname.Text = "Administrator ID"
        '
        'lblpass
        '
        Me.lblpass.AutoSize = True
        Me.lblpass.BackColor = System.Drawing.Color.Transparent
        Me.lblpass.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpass.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblpass.Location = New System.Drawing.Point(61, 293)
        Me.lblpass.Name = "lblpass"
        Me.lblpass.Size = New System.Drawing.Size(78, 20)
        Me.lblpass.TabIndex = 4
        Me.lblpass.Text = "Password"
        '
        'txtloginname
        '
        Me.txtloginname.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtloginname.Location = New System.Drawing.Point(166, 221)
        Me.txtloginname.Multiline = True
        Me.txtloginname.Name = "txtloginname"
        Me.txtloginname.Size = New System.Drawing.Size(191, 29)
        Me.txtloginname.TabIndex = 5
        '
        'txtloginpass
        '
        Me.txtloginpass.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtloginpass.Location = New System.Drawing.Point(166, 286)
        Me.txtloginpass.Multiline = True
        Me.txtloginpass.Name = "txtloginpass"
        Me.txtloginpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(95)
        Me.txtloginpass.Size = New System.Drawing.Size(191, 27)
        Me.txtloginpass.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tempus Sans ITC", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(199, -5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1069, 126)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Time Table Notification "
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.BackgroundImage = Global.Query.My.Resources.Resources.blue_dragon_wallpaper
        Me.ClientSize = New System.Drawing.Size(898, 587)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtloginpass)
        Me.Controls.Add(Me.txtloginname)
        Me.Controls.Add(Me.lblpass)
        Me.Controls.Add(Me.lbluname)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.btnreset)
        Me.Controls.Add(Me.btnlogin)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "login"
        Me.Text = "Login "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnlogin As System.Windows.Forms.Button
    Friend WithEvents btnreset As System.Windows.Forms.Button
    Friend WithEvents btnexit As System.Windows.Forms.Button
    Friend WithEvents lbluname As System.Windows.Forms.Label
    Friend WithEvents lblpass As System.Windows.Forms.Label
    Friend WithEvents txtloginname As System.Windows.Forms.TextBox
    Friend WithEvents txtloginpass As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
