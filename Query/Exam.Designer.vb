<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Exam
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
        Me.txtreminder = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.btnadmin = New System.Windows.Forms.Button()
        Me.OFdialog = New System.Windows.Forms.OpenFileDialog()
        Me.lstinput = New System.Windows.Forms.ListBox()
        Me.cmbto = New System.Windows.Forms.ComboBox()
        Me.DGV1 = New System.Windows.Forms.DataGridView()
        Me.btnimport = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btncivils = New System.Windows.Forms.Button()
        Me.btnmechs = New System.Windows.Forms.Button()
        Me.btnits = New System.Windows.Forms.Button()
        Me.btneees = New System.Windows.Forms.Button()
        Me.btneces = New System.Windows.Forms.Button()
        Me.btncses = New System.Windows.Forms.Button()
        Me.btncivilf = New System.Windows.Forms.Button()
        Me.btnmechf = New System.Windows.Forms.Button()
        Me.btnitf = New System.Windows.Forms.Button()
        Me.btneeef = New System.Windows.Forms.Button()
        Me.btnecef = New System.Windows.Forms.Button()
        Me.btncsef = New System.Windows.Forms.Button()
        Me.txtbody = New System.Windows.Forms.TextBox()
        Me.txtsub = New System.Windows.Forms.TextBox()
        Me.txtpass = New System.Windows.Forms.TextBox()
        Me.txtuser = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnsend = New System.Windows.Forms.Button()
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtreminder
        '
        Me.txtreminder.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtreminder.Location = New System.Drawing.Point(119, 512)
        Me.txtreminder.Multiline = True
        Me.txtreminder.Name = "txtreminder"
        Me.txtreminder.Size = New System.Drawing.Size(622, 90)
        Me.txtreminder.TabIndex = 73
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label8.Location = New System.Drawing.Point(9, 512)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 13)
        Me.Label8.TabIndex = 72
        Me.Label8.Text = "Reminder:"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.CheckBox1.Location = New System.Drawing.Point(119, 239)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(185, 17)
        Me.CheckBox1.TabIndex = 71
        Me.CheckBox1.Text = "Send custom mail to all Faculties?"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'btnadmin
        '
        Me.btnadmin.Location = New System.Drawing.Point(119, 121)
        Me.btnadmin.Name = "btnadmin"
        Me.btnadmin.Size = New System.Drawing.Size(184, 23)
        Me.btnadmin.TabIndex = 70
        Me.btnadmin.Text = "Use Admin Credential  "
        Me.btnadmin.UseVisualStyleBackColor = True
        '
        'OFdialog
        '
        Me.OFdialog.FileName = "OpenFileDialog1"
        '
        'lstinput
        '
        Me.lstinput.FormattingEnabled = True
        Me.lstinput.Location = New System.Drawing.Point(1098, 293)
        Me.lstinput.Name = "lstinput"
        Me.lstinput.Size = New System.Drawing.Size(10, 4)
        Me.lstinput.TabIndex = 69
        Me.lstinput.Visible = False
        '
        'cmbto
        '
        Me.cmbto.FormattingEnabled = True
        Me.cmbto.Items.AddRange(New Object() {"ajith.thomas@cse.christuniversity.in", "gowtham.s@cse.christuniversity.in", "joseph.emmaluel@cse.christuniversity.in"})
        Me.cmbto.Location = New System.Drawing.Point(119, 262)
        Me.cmbto.Name = "cmbto"
        Me.cmbto.Size = New System.Drawing.Size(184, 21)
        Me.cmbto.Sorted = True
        Me.cmbto.TabIndex = 68
        '
        'DGV1
        '
        Me.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV1.Location = New System.Drawing.Point(396, 138)
        Me.DGV1.Name = "DGV1"
        Me.DGV1.Size = New System.Drawing.Size(609, 166)
        Me.DGV1.TabIndex = 67
        Me.DGV1.Visible = False
        '
        'btnimport
        '
        Me.btnimport.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnimport.Location = New System.Drawing.Point(433, 12)
        Me.btnimport.Name = "btnimport"
        Me.btnimport.Size = New System.Drawing.Size(379, 63)
        Me.btnimport.TabIndex = 66
        Me.btnimport.Text = "Import  Files"
        Me.btnimport.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(1216, -2)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 13)
        Me.Label7.TabIndex = 65
        Me.Label7.Text = "Faculty"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(1111, -2)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 64
        Me.Label6.Text = "Student"
        '
        'btncivils
        '
        Me.btncivils.Location = New System.Drawing.Point(1098, 354)
        Me.btncivils.Name = "btncivils"
        Me.btncivils.Size = New System.Drawing.Size(75, 23)
        Me.btncivils.TabIndex = 63
        Me.btncivils.Text = "Civil"
        Me.btncivils.UseVisualStyleBackColor = True
        '
        'btnmechs
        '
        Me.btnmechs.Location = New System.Drawing.Point(1098, 293)
        Me.btnmechs.Name = "btnmechs"
        Me.btnmechs.Size = New System.Drawing.Size(75, 23)
        Me.btnmechs.TabIndex = 62
        Me.btnmechs.Text = "Mech"
        Me.btnmechs.UseVisualStyleBackColor = True
        '
        'btnits
        '
        Me.btnits.Location = New System.Drawing.Point(1098, 231)
        Me.btnits.Name = "btnits"
        Me.btnits.Size = New System.Drawing.Size(75, 23)
        Me.btnits.TabIndex = 61
        Me.btnits.Text = "IT"
        Me.btnits.UseVisualStyleBackColor = True
        '
        'btneees
        '
        Me.btneees.Location = New System.Drawing.Point(1098, 169)
        Me.btneees.Name = "btneees"
        Me.btneees.Size = New System.Drawing.Size(75, 23)
        Me.btneees.TabIndex = 60
        Me.btneees.Text = "EEE"
        Me.btneees.UseVisualStyleBackColor = True
        '
        'btneces
        '
        Me.btneces.Location = New System.Drawing.Point(1098, 100)
        Me.btneces.Name = "btneces"
        Me.btneces.Size = New System.Drawing.Size(75, 23)
        Me.btneces.TabIndex = 59
        Me.btneces.Text = "ECE"
        Me.btneces.UseVisualStyleBackColor = True
        '
        'btncses
        '
        Me.btncses.Location = New System.Drawing.Point(1098, 33)
        Me.btncses.Name = "btncses"
        Me.btncses.Size = New System.Drawing.Size(75, 23)
        Me.btncses.TabIndex = 58
        Me.btncses.Text = "CSE"
        Me.btncses.UseVisualStyleBackColor = True
        '
        'btncivilf
        '
        Me.btncivilf.Location = New System.Drawing.Point(1204, 354)
        Me.btncivilf.Name = "btncivilf"
        Me.btncivilf.Size = New System.Drawing.Size(75, 23)
        Me.btncivilf.TabIndex = 57
        Me.btncivilf.Text = "Civil"
        Me.btncivilf.UseVisualStyleBackColor = True
        '
        'btnmechf
        '
        Me.btnmechf.Location = New System.Drawing.Point(1204, 293)
        Me.btnmechf.Name = "btnmechf"
        Me.btnmechf.Size = New System.Drawing.Size(75, 23)
        Me.btnmechf.TabIndex = 56
        Me.btnmechf.Text = "Mech"
        Me.btnmechf.UseVisualStyleBackColor = True
        '
        'btnitf
        '
        Me.btnitf.Location = New System.Drawing.Point(1204, 231)
        Me.btnitf.Name = "btnitf"
        Me.btnitf.Size = New System.Drawing.Size(75, 23)
        Me.btnitf.TabIndex = 55
        Me.btnitf.Text = "IT"
        Me.btnitf.UseVisualStyleBackColor = True
        '
        'btneeef
        '
        Me.btneeef.Location = New System.Drawing.Point(1204, 169)
        Me.btneeef.Name = "btneeef"
        Me.btneeef.Size = New System.Drawing.Size(75, 23)
        Me.btneeef.TabIndex = 54
        Me.btneeef.Text = "EEE"
        Me.btneeef.UseVisualStyleBackColor = True
        '
        'btnecef
        '
        Me.btnecef.Location = New System.Drawing.Point(1204, 100)
        Me.btnecef.Name = "btnecef"
        Me.btnecef.Size = New System.Drawing.Size(75, 23)
        Me.btnecef.TabIndex = 53
        Me.btnecef.Text = "ECE"
        Me.btnecef.UseVisualStyleBackColor = True
        '
        'btncsef
        '
        Me.btncsef.Location = New System.Drawing.Point(1204, 33)
        Me.btncsef.Name = "btncsef"
        Me.btncsef.Size = New System.Drawing.Size(75, 23)
        Me.btncsef.TabIndex = 52
        Me.btncsef.Text = "CSE "
        Me.btncsef.UseVisualStyleBackColor = True
        '
        'txtbody
        '
        Me.txtbody.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbody.Location = New System.Drawing.Point(119, 399)
        Me.txtbody.Multiline = True
        Me.txtbody.Name = "txtbody"
        Me.txtbody.Size = New System.Drawing.Size(1160, 90)
        Me.txtbody.TabIndex = 51
        '
        'txtsub
        '
        Me.txtsub.Location = New System.Drawing.Point(119, 320)
        Me.txtsub.Name = "txtsub"
        Me.txtsub.Size = New System.Drawing.Size(184, 20)
        Me.txtsub.TabIndex = 50
        '
        'txtpass
        '
        Me.txtpass.Location = New System.Drawing.Point(119, 53)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpass.Size = New System.Drawing.Size(184, 20)
        Me.txtpass.TabIndex = 49
        '
        'txtuser
        '
        Me.txtuser.Location = New System.Drawing.Point(119, 12)
        Me.txtuser.Name = "txtuser"
        Me.txtuser.Size = New System.Drawing.Size(184, 20)
        Me.txtuser.TabIndex = 48
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(7, 399)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 47
        Me.Label5.Text = "Body :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(7, 320)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "Subject :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(7, 262)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 13)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "To :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(7, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 13)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "E-Mail Password :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(7, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 13)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "E-Mail Username :"
        '
        'btnsend
        '
        Me.btnsend.Font = New System.Drawing.Font("Castellar", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsend.Location = New System.Drawing.Point(524, 615)
        Me.btnsend.Name = "btnsend"
        Me.btnsend.Size = New System.Drawing.Size(217, 31)
        Me.btnsend.TabIndex = 42
        Me.btnsend.Text = "Send Mail"
        Me.btnsend.UseVisualStyleBackColor = True
        '
        'Exam
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Query.My.Resources.Resources.background_loginpage1
        Me.ClientSize = New System.Drawing.Size(876, 661)
        Me.Controls.Add(Me.txtreminder)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.btnadmin)
        Me.Controls.Add(Me.lstinput)
        Me.Controls.Add(Me.cmbto)
        Me.Controls.Add(Me.DGV1)
        Me.Controls.Add(Me.btnimport)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btncivils)
        Me.Controls.Add(Me.btnmechs)
        Me.Controls.Add(Me.btnits)
        Me.Controls.Add(Me.btneees)
        Me.Controls.Add(Me.btneces)
        Me.Controls.Add(Me.btncses)
        Me.Controls.Add(Me.btncivilf)
        Me.Controls.Add(Me.btnmechf)
        Me.Controls.Add(Me.btnitf)
        Me.Controls.Add(Me.btneeef)
        Me.Controls.Add(Me.btnecef)
        Me.Controls.Add(Me.btncsef)
        Me.Controls.Add(Me.txtbody)
        Me.Controls.Add(Me.txtsub)
        Me.Controls.Add(Me.txtpass)
        Me.Controls.Add(Me.txtuser)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnsend)
        Me.Name = "Exam"
        Me.Text = "Exam"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtreminder As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents btnadmin As System.Windows.Forms.Button
    Friend WithEvents OFdialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents lstinput As System.Windows.Forms.ListBox
    Friend WithEvents cmbto As System.Windows.Forms.ComboBox
    Friend WithEvents DGV1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnimport As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btncivils As System.Windows.Forms.Button
    Friend WithEvents btnmechs As System.Windows.Forms.Button
    Friend WithEvents btnits As System.Windows.Forms.Button
    Friend WithEvents btneees As System.Windows.Forms.Button
    Friend WithEvents btneces As System.Windows.Forms.Button
    Friend WithEvents btncses As System.Windows.Forms.Button
    Friend WithEvents btncivilf As System.Windows.Forms.Button
    Friend WithEvents btnmechf As System.Windows.Forms.Button
    Friend WithEvents btnitf As System.Windows.Forms.Button
    Friend WithEvents btneeef As System.Windows.Forms.Button
    Friend WithEvents btnecef As System.Windows.Forms.Button
    Friend WithEvents btncsef As System.Windows.Forms.Button
    Friend WithEvents txtbody As System.Windows.Forms.TextBox
    Friend WithEvents txtsub As System.Windows.Forms.TextBox
    Friend WithEvents txtpass As System.Windows.Forms.TextBox
    Friend WithEvents txtuser As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnsend As System.Windows.Forms.Button
End Class
