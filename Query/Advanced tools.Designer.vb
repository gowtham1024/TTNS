<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Advanced_tools
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
        Me.btnid = New System.Windows.Forms.Button()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.txtpass = New System.Windows.Forms.TextBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel()
        Me.btnadmin = New System.Windows.Forms.Button()
        Me.lblid = New System.Windows.Forms.Label()
        Me.lblpass = New System.Windows.Forms.Label()
        Me.lstitems = New System.Windows.Forms.ListBox()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.LinkLabel4 = New System.Windows.Forms.LinkLabel()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnlist = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.LinkLabel5 = New System.Windows.Forms.LinkLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnid
        '
        Me.btnid.Location = New System.Drawing.Point(522, 324)
        Me.btnid.Name = "btnid"
        Me.btnid.Size = New System.Drawing.Size(168, 49)
        Me.btnid.TabIndex = 0
        Me.btnid.Text = "Add Email ID of new faculty"
        Me.btnid.UseVisualStyleBackColor = True
        Me.btnid.Visible = False
        '
        'txtid
        '
        Me.txtid.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtid.Location = New System.Drawing.Point(678, 141)
        Me.txtid.Multiline = True
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(176, 24)
        Me.txtid.TabIndex = 1
        '
        'txtpass
        '
        Me.txtpass.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpass.Location = New System.Drawing.Point(678, 194)
        Me.txtpass.Multiline = True
        Me.txtpass.Name = "txtpass"
        Me.txtpass.Size = New System.Drawing.Size(176, 24)
        Me.txtpass.TabIndex = 2
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Elephant", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(14, 114)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(394, 27)
        Me.LinkLabel1.TabIndex = 3
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Add New faculty to the Email List"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Font = New System.Drawing.Font("Elephant", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel2.Location = New System.Drawing.Point(921, 191)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(281, 27)
        Me.LinkLabel2.TabIndex = 4
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Add New Administrator" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'LinkLabel3
        '
        Me.LinkLabel3.AutoSize = True
        Me.LinkLabel3.Font = New System.Drawing.Font("Elephant", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel3.Location = New System.Drawing.Point(14, 201)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(472, 27)
        Me.LinkLabel3.TabIndex = 5
        Me.LinkLabel3.TabStop = True
        Me.LinkLabel3.Text = "Delete  Existing Faculty from Email List"
        '
        'btnadmin
        '
        Me.btnadmin.Location = New System.Drawing.Point(522, 394)
        Me.btnadmin.Name = "btnadmin"
        Me.btnadmin.Size = New System.Drawing.Size(168, 49)
        Me.btnadmin.TabIndex = 6
        Me.btnadmin.Text = "Add Administrator"
        Me.btnadmin.UseVisualStyleBackColor = True
        Me.btnadmin.Visible = False
        '
        'lblid
        '
        Me.lblid.AutoSize = True
        Me.lblid.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblid.Location = New System.Drawing.Point(555, 141)
        Me.lblid.Name = "lblid"
        Me.lblid.Size = New System.Drawing.Size(29, 24)
        Me.lblid.TabIndex = 7
        Me.lblid.Text = "ID"
        '
        'lblpass
        '
        Me.lblpass.AutoSize = True
        Me.lblpass.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpass.Location = New System.Drawing.Point(555, 194)
        Me.lblpass.Name = "lblpass"
        Me.lblpass.Size = New System.Drawing.Size(100, 24)
        Me.lblpass.TabIndex = 8
        Me.lblpass.Text = "Password"
        '
        'lstitems
        '
        Me.lstitems.FormattingEnabled = True
        Me.lstitems.Location = New System.Drawing.Point(19, 430)
        Me.lstitems.Name = "lstitems"
        Me.lstitems.Size = New System.Drawing.Size(209, 264)
        Me.lstitems.Sorted = True
        Me.lstitems.TabIndex = 9
        Me.lstitems.Visible = False
        '
        'btnupdate
        '
        Me.btnupdate.Location = New System.Drawing.Point(522, 472)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(168, 49)
        Me.btnupdate.TabIndex = 10
        Me.btnupdate.Text = "Update"
        Me.btnupdate.UseVisualStyleBackColor = True
        Me.btnupdate.Visible = False
        '
        'LinkLabel4
        '
        Me.LinkLabel4.AutoSize = True
        Me.LinkLabel4.Font = New System.Drawing.Font("Elephant", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel4.Location = New System.Drawing.Point(921, 114)
        Me.LinkLabel4.Name = "LinkLabel4"
        Me.LinkLabel4.Size = New System.Drawing.Size(273, 27)
        Me.LinkLabel4.TabIndex = 11
        Me.LinkLabel4.TabStop = True
        Me.LinkLabel4.Text = "Update  Administrator "
        '
        'btndelete
        '
        Me.btndelete.Location = New System.Drawing.Point(522, 551)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(168, 49)
        Me.btndelete.TabIndex = 12
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = True
        Me.btndelete.Visible = False
        '
        'btnlist
        '
        Me.btnlist.Location = New System.Drawing.Point(522, 645)
        Me.btnlist.Name = "btnlist"
        Me.btnlist.Size = New System.Drawing.Size(168, 49)
        Me.btnlist.TabIndex = 13
        Me.btnlist.Text = "List "
        Me.btnlist.UseVisualStyleBackColor = True
        Me.btnlist.Visible = False
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(829, 454)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(168, 225)
        Me.ListBox1.TabIndex = 14
        Me.ListBox1.Visible = False
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(1032, 454)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(168, 225)
        Me.ListBox2.TabIndex = 15
        Me.ListBox2.Visible = False
        '
        'LinkLabel5
        '
        Me.LinkLabel5.AutoSize = True
        Me.LinkLabel5.Font = New System.Drawing.Font("Elephant", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel5.Location = New System.Drawing.Point(921, 269)
        Me.LinkLabel5.Name = "LinkLabel5"
        Me.LinkLabel5.Size = New System.Drawing.Size(360, 27)
        Me.LinkLabel5.TabIndex = 16
        Me.LinkLabel5.TabStop = True
        Me.LinkLabel5.Text = "Delete Existing Administrator "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Algerian", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(50, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(408, 54)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Email Settings"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Algerian", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(917, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(410, 54)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Admin Settings"
        '
        'Advanced_tools
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1314, 691)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LinkLabel5)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.btnlist)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.LinkLabel4)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.lstitems)
        Me.Controls.Add(Me.lblpass)
        Me.Controls.Add(Me.lblid)
        Me.Controls.Add(Me.btnadmin)
        Me.Controls.Add(Me.LinkLabel3)
        Me.Controls.Add(Me.LinkLabel2)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.txtpass)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.btnid)
        Me.Name = "Advanced_tools"
        Me.Text = "Advanced_tools"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnid As System.Windows.Forms.Button
    Friend WithEvents txtid As System.Windows.Forms.TextBox
    Friend WithEvents txtpass As System.Windows.Forms.TextBox
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel3 As System.Windows.Forms.LinkLabel
    Friend WithEvents btnadmin As System.Windows.Forms.Button
    Friend WithEvents lblid As System.Windows.Forms.Label
    Friend WithEvents lblpass As System.Windows.Forms.Label
    Friend WithEvents lstitems As System.Windows.Forms.ListBox
    Friend WithEvents btnupdate As System.Windows.Forms.Button
    Friend WithEvents LinkLabel4 As System.Windows.Forms.LinkLabel
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents btnlist As System.Windows.Forms.Button
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents LinkLabel5 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
