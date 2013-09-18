<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class automail
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
        Me.lstinput = New System.Windows.Forms.ListBox()
        Me.cmbto = New System.Windows.Forms.ComboBox()
        Me.DGV1 = New System.Windows.Forms.DataGridView()
        Me.OFdialog = New System.Windows.Forms.OpenFileDialog()
        Me.txtbody = New System.Windows.Forms.TextBox()
        Me.txtsub = New System.Windows.Forms.TextBox()
        Me.txtpass = New System.Windows.Forms.TextBox()
        Me.txtuser = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.btnimport = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DTP1 = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txthh = New System.Windows.Forms.TextBox()
        Me.txtmm = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lstinput
        '
        Me.lstinput.FormattingEnabled = True
        Me.lstinput.Location = New System.Drawing.Point(712, 637)
        Me.lstinput.Name = "lstinput"
        Me.lstinput.Size = New System.Drawing.Size(10, 4)
        Me.lstinput.TabIndex = 66
        Me.lstinput.Visible = False
        '
        'cmbto
        '
        Me.cmbto.FormattingEnabled = True
        Me.cmbto.Location = New System.Drawing.Point(666, 600)
        Me.cmbto.Name = "cmbto"
        Me.cmbto.Size = New System.Drawing.Size(10, 21)
        Me.cmbto.TabIndex = 65
        Me.cmbto.Visible = False
        '
        'DGV1
        '
        Me.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV1.Location = New System.Drawing.Point(712, 600)
        Me.DGV1.Name = "DGV1"
        Me.DGV1.Size = New System.Drawing.Size(10, 10)
        Me.DGV1.TabIndex = 64
        Me.DGV1.Visible = False
        '
        'OFdialog
        '
        Me.OFdialog.FileName = "OpenFileDialog1"
        '
        'txtbody
        '
        Me.txtbody.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbody.Location = New System.Drawing.Point(682, 578)
        Me.txtbody.Multiline = True
        Me.txtbody.Name = "txtbody"
        Me.txtbody.Size = New System.Drawing.Size(10, 10)
        Me.txtbody.TabIndex = 48
        Me.txtbody.Visible = False
        '
        'txtsub
        '
        Me.txtsub.Location = New System.Drawing.Point(682, 600)
        Me.txtsub.Name = "txtsub"
        Me.txtsub.Size = New System.Drawing.Size(10, 20)
        Me.txtsub.TabIndex = 47
        Me.txtsub.Visible = False
        '
        'txtpass
        '
        Me.txtpass.Location = New System.Drawing.Point(649, 601)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpass.Size = New System.Drawing.Size(10, 20)
        Me.txtpass.TabIndex = 46
        Me.txtpass.Visible = False
        '
        'txtuser
        '
        Me.txtuser.Location = New System.Drawing.Point(649, 574)
        Me.txtuser.Name = "txtuser"
        Me.txtuser.Size = New System.Drawing.Size(10, 20)
        Me.txtuser.TabIndex = 45
        Me.txtuser.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(696, 590)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(10, 20)
        Me.TextBox1.TabIndex = 69
        Me.TextBox1.Visible = False
        '
        'Timer1
        '
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(666, 574)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(10, 20)
        Me.TextBox2.TabIndex = 70
        Me.TextBox2.Visible = False
        '
        'btnimport
        '
        Me.btnimport.BackColor = System.Drawing.Color.LightGray
        Me.btnimport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnimport.Font = New System.Drawing.Font("Virtual DJ", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnimport.Location = New System.Drawing.Point(478, 559)
        Me.btnimport.Name = "btnimport"
        Me.btnimport.Size = New System.Drawing.Size(376, 107)
        Me.btnimport.TabIndex = 71
        Me.btnimport.Text = "Import Files"
        Me.btnimport.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Berlin Sans FB Demi", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(214, 24)
        Me.Label1.TabIndex = 72
        Me.Label1.Text = "Number of Days Sent:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Berlin Sans FB Demi", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(222, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 24)
        Me.Label2.TabIndex = 73
        '
        'DTP1
        '
        Me.DTP1.Location = New System.Drawing.Point(1074, 21)
        Me.DTP1.Name = "DTP1"
        Me.DTP1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DTP1.Size = New System.Drawing.Size(194, 20)
        Me.DTP1.TabIndex = 74
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(956, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(205, 25)
        Me.Label3.TabIndex = 75
        Me.Label3.Text = "Set Time (HH:MM)"
        '
        'txthh
        '
        Me.txthh.Location = New System.Drawing.Point(1193, 70)
        Me.txthh.Name = "txthh"
        Me.txthh.Size = New System.Drawing.Size(22, 20)
        Me.txthh.TabIndex = 76
        Me.txthh.Text = "09"
        '
        'txtmm
        '
        Me.txtmm.Location = New System.Drawing.Point(1241, 70)
        Me.txtmm.Name = "txtmm"
        Me.txtmm.Size = New System.Drawing.Size(22, 20)
        Me.txtmm.TabIndex = 77
        Me.txtmm.Text = "00"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(1219, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(19, 25)
        Me.Label4.TabIndex = 78
        Me.Label4.Text = ":"
        '
        'automail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Query.My.Resources.Resources.email_icon
        Me.ClientSize = New System.Drawing.Size(1320, 699)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtmm)
        Me.Controls.Add(Me.txthh)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DTP1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnimport)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lstinput)
        Me.Controls.Add(Me.cmbto)
        Me.Controls.Add(Me.DGV1)
        Me.Controls.Add(Me.txtbody)
        Me.Controls.Add(Me.txtsub)
        Me.Controls.Add(Me.txtpass)
        Me.Controls.Add(Me.txtuser)
        Me.Name = "automail"
        Me.Text = "automail"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstinput As System.Windows.Forms.ListBox
    Friend WithEvents cmbto As System.Windows.Forms.ComboBox
    Friend WithEvents DGV1 As System.Windows.Forms.DataGridView
    Friend WithEvents OFdialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents txtbody As System.Windows.Forms.TextBox
    Friend WithEvents txtsub As System.Windows.Forms.TextBox
    Friend WithEvents txtpass As System.Windows.Forms.TextBox
    Friend WithEvents txtuser As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents btnimport As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DTP1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txthh As System.Windows.Forms.TextBox
    Friend WithEvents txtmm As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
