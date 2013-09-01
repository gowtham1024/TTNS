<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Query
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
        Me.btnins = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtname1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtid1 = New System.Windows.Forms.TextBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.txtname2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtid2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnupd = New System.Windows.Forms.Button()
        Me.btndel = New System.Windows.Forms.Button()
        Me.btnshow = New System.Windows.Forms.Button()
        Me.lbllistname = New System.Windows.Forms.Label()
        Me.lbllistid = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnins
        '
        Me.btnins.Location = New System.Drawing.Point(155, 132)
        Me.btnins.Name = "btnins"
        Me.btnins.Size = New System.Drawing.Size(75, 23)
        Me.btnins.TabIndex = 0
        Me.btnins.Text = "Insert"
        Me.btnins.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(56, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Name :"
        '
        'txtname1
        '
        Me.txtname1.Location = New System.Drawing.Point(130, 37)
        Me.txtname1.Name = "txtname1"
        Me.txtname1.Size = New System.Drawing.Size(100, 20)
        Me.txtname1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(56, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(18, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "ID"
        '
        'txtid1
        '
        Me.txtid1.Location = New System.Drawing.Point(130, 82)
        Me.txtid1.Name = "txtid1"
        Me.txtid1.Size = New System.Drawing.Size(100, 20)
        Me.txtid1.TabIndex = 4
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(526, 28)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(145, 407)
        Me.ListBox1.TabIndex = 5
        Me.ListBox1.Visible = False
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(677, 28)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(127, 407)
        Me.ListBox2.TabIndex = 6
        Me.ListBox2.Visible = False
        '
        'txtname2
        '
        Me.txtname2.Location = New System.Drawing.Point(130, 205)
        Me.txtname2.Name = "txtname2"
        Me.txtname2.Size = New System.Drawing.Size(100, 20)
        Me.txtname2.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(56, 205)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Name :"
        '
        'txtid2
        '
        Me.txtid2.Location = New System.Drawing.Point(130, 255)
        Me.txtid2.Name = "txtid2"
        Me.txtid2.Size = New System.Drawing.Size(100, 20)
        Me.txtid2.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(56, 255)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(18, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "ID"
        '
        'btnupd
        '
        Me.btnupd.Location = New System.Drawing.Point(45, 319)
        Me.btnupd.Name = "btnupd"
        Me.btnupd.Size = New System.Drawing.Size(75, 23)
        Me.btnupd.TabIndex = 11
        Me.btnupd.Text = "Update"
        Me.btnupd.UseVisualStyleBackColor = True
        '
        'btndel
        '
        Me.btndel.Location = New System.Drawing.Point(168, 319)
        Me.btndel.Name = "btndel"
        Me.btndel.Size = New System.Drawing.Size(75, 23)
        Me.btndel.TabIndex = 12
        Me.btndel.Text = "Delete"
        Me.btndel.UseVisualStyleBackColor = True
        '
        'btnshow
        '
        Me.btnshow.Location = New System.Drawing.Point(302, 319)
        Me.btnshow.Name = "btnshow"
        Me.btnshow.Size = New System.Drawing.Size(75, 23)
        Me.btnshow.TabIndex = 13
        Me.btnshow.Text = "Show Items"
        Me.btnshow.UseVisualStyleBackColor = True
        '
        'lbllistname
        '
        Me.lbllistname.AutoSize = True
        Me.lbllistname.Location = New System.Drawing.Point(577, 9)
        Me.lbllistname.Name = "lbllistname"
        Me.lbllistname.Size = New System.Drawing.Size(35, 13)
        Me.lbllistname.TabIndex = 14
        Me.lbllistname.Text = "Name"
        Me.lbllistname.Visible = False
        '
        'lbllistid
        '
        Me.lbllistid.AutoSize = True
        Me.lbllistid.Location = New System.Drawing.Point(723, 9)
        Me.lbllistid.Name = "lbllistid"
        Me.lbllistid.Size = New System.Drawing.Size(18, 13)
        Me.lbllistid.TabIndex = 15
        Me.lbllistid.Text = "ID"
        Me.lbllistid.Visible = False
        '
        'Query
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(816, 436)
        Me.Controls.Add(Me.lbllistid)
        Me.Controls.Add(Me.lbllistname)
        Me.Controls.Add(Me.btnshow)
        Me.Controls.Add(Me.btndel)
        Me.Controls.Add(Me.btnupd)
        Me.Controls.Add(Me.txtname2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtid2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.txtid1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtname1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnins)
        Me.Name = "Query"
        Me.Text = "Query"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnins As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtname1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtid1 As System.Windows.Forms.TextBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents txtname2 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtid2 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnupd As System.Windows.Forms.Button
    Friend WithEvents btndel As System.Windows.Forms.Button
    Friend WithEvents btnshow As System.Windows.Forms.Button
    Friend WithEvents lbllistname As System.Windows.Forms.Label
    Friend WithEvents lbllistid As System.Windows.Forms.Label

End Class
