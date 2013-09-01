Imports System.Net.Mail
Imports System.Data.SqlClient
Imports System.Timers
Public Class automail
    Private main_tmr As New Timers.Timer
    Private NextSend As DateTime
    Dim ArrayIDEMP(0 To 100) As String
    Dim strname As String
    Dim strid As String
    Dim day As String
    Dim arr1(0 To 10) As String
    Dim arr(0 To 100) As String
    Dim regDate As Date = Date.Now()
    Dim disppath As String
    Dim xlid As String
    Dim arr2(0 To 100) As String
    Dim arryfiles(0 To 100) As String
    Dim key As String
    Dim itemcount1 As Integer = 0
    Dim itemcount2 As Integer = 0
    Dim count As Integer = 0
    Dim it As Integer
    Public Function sendmail()

        Dim message As New Net.Mail.MailMessage(txtuser.Text.ToString, cmbto.Text.ToString, txtsub.Text.ToString.ToString, txtbody.Text.ToString)
        Dim smtp As New Net.Mail.SmtpClient("smtp.gmail.com")
        Dim cred As New Net.NetworkCredential(txtuser.Text.ToString, txtpass.Text.ToString)
        smtp.EnableSsl = True
        smtp.Credentials = cred
        smtp.Port = 587
        smtp.Host = "smtp.gmail.com"
        smtp.Send(message)
        ' MsgBox("Message sent successfully!")
        '  If MsgBoxResult.Yes Then
        txtbody.Clear()
        txtpass.Clear()
        txtsub.Clear()
        cmbto.Text = ""
        txtuser.Clear()

        'ElseIf MsgBoxResult.No Then

        '' End If
    End Function
    Private Function getidname()
        Dim MyConnection As System.Data.OleDb.OleDbConnection
        Dim DtSet As System.Data.DataSet
        Dim MyCommand As System.Data.OleDb.OleDbDataAdapter
        MyConnection = New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='c:\ttable1.xlsx';Extended Properties=Excel 12.0")
        MyCommand = New System.Data.OleDb.OleDbDataAdapter("select NAME,ID from [Sheet1$]  ", MyConnection)
        DtSet = New System.Data.DataSet
        MyCommand.Fill(DtSet)
        DGV1.DataSource = DtSet.Tables(0)
        ' txtdisplay.Text = ""
        arr1(0) = DtSet.Tables(0).Rows(0).Item(0)
        '  txtdisplay.Text = txtdisplay.Text + arr1(0) & vbTab
        MyConnection.Close()
    End Function
    Private Function genauto()
        '  TextBox2.Text = it

        Dim pass As String
        Dim temp As String
        Dim temp2 As String
        Dim i As Integer
        Dim k As Integer
        Dim j As Integer
        Dim day As String
        Dim weekday As String
        Dim name As String
        Dim flag As Integer = 0
        Dim MyConnection As System.Data.OleDb.OleDbConnection
        Dim DtSet As System.Data.DataSet
        Dim MyCommand As System.Data.OleDb.OleDbDataAdapter

        xlid = 1

        'Try

        ' Dim i As Integer
        ' Dim parts() As String = cmbto.Text.Split(".")
        day = regDate.DayOfWeek

        If day = 1 Then
            weekday = "MONDAY"
        ElseIf day = 2 Then
            weekday = " TUESDAY"
        ElseIf day = 3 Then
            weekday = "WEDNESDAY"
        ElseIf day = 4 Then
            weekday = "THURSDAY"
        ElseIf day = 5 Then
            weekday = "FRIDAY"
        ElseIf day = 6 Then
            weekday = "SATURDAY"

        Else
            weekday = "SUNDAY"
        End If
        'For j = 0 To it - 1

        For i = 0 To it - 1
            txtuser.Text = "super.user1009@gmail.com"
            pass = "superadmin1"
            txtpass.Text = pass.ToString
            txtsub.Text = " SCHEDULE FOR TODAY "
            disppath = lstinput.Items(i).ToString
            ' TextBox3.Text = TextBox3.Text + disppath
            arr(i) = lstinput.Items(i)
            temp = arr(i)
            Dim parts() As String = temp.ToString.Split("\")
            TextBox1.Text = parts(2)
            Dim parts2() As String = TextBox1.Text.Split(".")
            temp = parts2(0)
            name = temp.ToString
            temp2 = cmbto.Items(i)
            Dim split() As String = temp2.ToString.Split(".")
            temp2 = split(0)
            If temp.ToString.Contains(temp2.ToString) Then
                ' disppath = arr(i)
                '  TextBox2.Text = TextBox2.Text + disppath.ToString
            End If
            cmbto.Text = cmbto.Items(i)
            MyConnection = New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" & disppath & "';Extended Properties=Excel 12.0")
            MyCommand = New System.Data.OleDb.OleDbDataAdapter("select *  from [Sheet1$] WHERE  DAY = '" & weekday.ToString & "'   ", MyConnection)
            DtSet = New System.Data.DataSet
            MyCommand.Fill(DtSet)
            DGV1.DataSource = DtSet.Tables(0)
            txtbody.Text = " The Following Details Are The Schedule for Today (" & Date.Today & ")" & vbNewLine & vbNewLine
            txtbody.Text = txtbody.Text + name.ToUpper & vbTab
            If day = 6 Then
                Try
                    arr1(k) = DtSet.Tables(0).Rows(0).Item(k)
                    txtbody.Text = txtbody.Text + arr1(k) & vbTab
                Catch ex As Exception
                    txtbody.Text = txtbody.Text + arr1(k - 1) & vbTab
                End Try
                For k = 0 To 5
                   
                Next


            Else
                For k = 0 To 6
                    Try
                        arr1(k) = DtSet.Tables(0).Rows(0).Item(k)
                        txtbody.Text = txtbody.Text + arr1(k) & vbTab
                    Catch ex As Exception
                        txtbody.Text = txtbody.Text + arr1(k - 1) & vbTab
                    End Try

                Next

            End If
            cmbto.Text = cmbto.Items(i).ToString
            sendmail()
            DtSet.Clear()
            DGV1.ClearSelection()
            MyConnection.Close()
        Next


        '    Next
    End Function
    Private Function getfilenames()

        itemcount1 = 0
        itemcount2 = 0
        Dim i As Integer
        Dim tst As String
        Dim filenam(0 To 100) As String
        '  OFdialog.Multiselect = True
        ' OFdialog.ShowDialog()
        lstinput.Items.AddRange(OFdialog.FileNames)
        it = lstinput.Items.Count

        For i = 0 To it - 1
            arr(i) = lstinput.Items(i)
            tst = arr(i)
        Next
        itemcount1 = lstinput.Items.Count
        'TextBox3.Text = itemcount1
        itemcount2 = cmbto.Items.Count
        ' TextBox4.Text = itemcount2
        If itemcount1 <> itemcount2 Then
            MessageBox.Show(" Please Make sure that you have imported all files ")
        ElseIf itemcount1 = itemcount2 Then

        End If
    End Function
    Private Function putidname()
        Dim valor As String
        For i = 0 To DGV1.RowCount - 2
            valor = DGV1.Rows(i).Cells(0).Value
            ArrayIDEMP(i) = valor
            lstinput.Items.Add(ArrayIDEMP(i).ToString)
            valor = DGV1.Rows(i).Cells(1).Value
            ArrayIDEMP(i) = valor
            ' ListBox2.Items.Add(ArrayIDEMP(i).ToString)
        Next
    End Function
    Private Function storeidname()
        Dim valor As String
        Dim MyConnection As System.Data.OleDb.OleDbConnection
        Dim DtSet As System.Data.DataSet
        Dim MyCommand As System.Data.OleDb.OleDbDataAdapter
        MyConnection = New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='c:\ttable1.xlsx';Extended Properties=Excel 12.0")
        MyCommand = New System.Data.OleDb.OleDbDataAdapter("select NAME,ID from [Sheet1$]  ", MyConnection)

        DtSet = New System.Data.DataSet
        MyCommand.Fill(DtSet)
        DGV1.DataSource = DtSet.Tables(0)
        ' txtdisplay.Text = ""
        'For i = 0 To 1
        arr1(0) = DtSet.Tables(0).Rows(0).Item(0)
        ' txtdisplay.Text = txtdisplay.Text + arr1(0) & vbTab

        '   arr2(0) = DtSet.Tables(0).Columns(0)

        'ListBox1.Items.Add(arr2(0))


        ' Next

        MyConnection.Close()

        For i = 0 To DGV1.RowCount - 2
            valor = DGV1.Rows(i).Cells(0).Value
            ArrayIDEMP(i) = valor
            ' ListBox1.Items.Add(ArrayIDEMP(i).ToString)
        Next
        For i = 0 To DGV1.RowCount - 2
            valor = DGV1.Rows(i).Cells(1).Value
            ArrayIDEMP(i) = valor
            ' ListBox2.Items.Add(ArrayIDEMP(i).ToString)
        Next
    End Function
  

    Private Sub main_tmr_Elapsed(ByVal sender As Object, ByVal e As ElapsedEventArgs)

        If DateTime.Now.ToShortTimeString >= NextSend Then
            genauto()
            count = count + 1
            Label2.Text = count
            NextSend = NextSend.AddDays(1)
        End If
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim itemcount As Integer = 0
        Dim c As Integer = 0
        For c = 0 To Email.cmbto.Items.Count - 1
            cmbto.Items.Add(Email.cmbto.Items(c))
        Next
        
        btnimport.Select()
        Label2.Text = count.ToString
        AddHandler main_tmr.Elapsed, New ElapsedEventHandler(AddressOf main_tmr_Elapsed)
        With main_tmr
            .SynchronizingObject = Me
            .Interval = 60000
            .Enabled = True
        End With
        NextSend = New DateTime(Now.Year, Now.Month, Now.Day, 14, 0, 0).ToShortTimeString

    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub OpenFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OFdialog.FileOk
        Try
            Dim strm As System.IO.Stream
            strm = OFdialog.OpenFile()
            disppath = OFdialog.FileName.ToString()
            If Not (strm Is Nothing) Then
                'insert code to read the file data
                strm.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(" Error  Opening File")
        End Try


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try


        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub btncsef_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        cmbto.Text = "cse@christuniversity.in"
    End Sub

    Private Sub btnecef_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        cmbto.Text = "ece@christuniversity.in"
    End Sub

    Private Sub btneeef_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        cmbto.Text = "eee@christuniversity.in"
    End Sub

    Private Sub btnitf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        cmbto.Text = "it@christuniversity.in"
    End Sub

    Private Sub btnmechf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        cmbto.Text = "mech@christuniversity.in"
    End Sub

    Private Sub btncivilf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        cmbto.Text = "civil@christuniversity.in"
    End Sub


    Private Sub btntest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DGV1.Visible = False
        storeidname()

    End Sub



    Private Sub btnadmin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim pass As String

        

    End Sub

    Private Sub cmbto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbto.KeyPress

        

    End Sub

    Private Sub cmbto_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles cmbto.PreviewKeyDown

    End Sub

    Private Sub cmbto_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbto.SelectedIndexChanged
       
    End Sub


    Private Sub cmbto_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbto.TextChanged


    End Sub

    Private Sub Button1_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        getfilenames()

    End Sub

    Private Sub Button1_Click_3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        genauto()


    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnimport.Click
        Try
            OFdialog.Title = "Please Select a File"
            OFdialog.InitialDirectory = "C:\"
            OFdialog.FileName = ""
            OFdialog.Multiselect = True

            OFdialog.DefaultExt = ".xlsx" ' Default file extension
            '  OFdialog.Filter = "Excel Documents *.XLSX|(*.XLS)"
            OFdialog.ShowDialog()
            getfilenames()


            If Windows.Forms.DialogResult.Cancel Then
            Else
                MessageBox.Show(" Imoprted!")
            End If
        Catch ex As Exception
            MessageBox.Show(" Error Opening file ")
        End Try

    End Sub

    Private Sub txthh_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txthh.TextChanged
        
    End Sub

    Private Sub txtmm_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtmm.TextChanged
        
    End Sub
End Class