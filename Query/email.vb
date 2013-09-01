Imports System.Net.Mail
Imports System.Data.SqlClient
Public Class Email
    
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
    Dim it As Integer


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
    Private Function getfilenames()


        Dim i As Integer
        Dim tst As String
        Dim cout As Integer
        Dim filenam(0 To 100) As String
        Dim name As String
        Dim flag As Integer


        '    OFdialog.Multiselect = True
        '   OFdialog.ShowDialog()
        lstinput.Items.AddRange(OFdialog.FileNames)
        it = lstinput.Items.Count

        For i = 0 To it - 1
            arr(i) = lstinput.Items(i)
            tst = arr(i)
        Next
       

        For i = 0 To cout - 1

        Next
        ' name = txtentrname.Text

        For i = 0 To it - 1
            If cmbto.SelectedIndex = i Then
                key = i

            End If
        Next

        For i = 0 To it - 1
            If arr(i).Contains(cmbto.Text.ToString) = False Then
                flag = 1

            End If
            

        Next
        
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
        MyConnection = New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='c:\ttable.xlsx';Extended Properties=Excel 12.0")
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
    Private Function generatett()

        txtsub.Text = " SCHEDULE FOR TODAY"
        xlid = 1

        '   Try
        Dim i As Integer
        Dim parts() As String = cmbto.Text.Split(".")
        Dim day As String
        Dim weekday As String
        Dim name As String
        Dim flag As Integer = 0
        name = parts(0)
        For i = 0 To it - 1
            If arr(i).Contains(name.ToString) Then
                disppath = arr(i)

            Else

            End If

        Next


        day = regDate.DayOfWeek

        If day = 1 Then
            weekday = "MONDAY"
        ElseIf day = 2 Then
            weekday = "TUESDAY"
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
        Dim MyConnection As System.Data.OleDb.OleDbConnection
        Dim DtSet As System.Data.DataSet
        Dim MyCommand As System.Data.OleDb.OleDbDataAdapter


        MyConnection = New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" & disppath & "';Extended Properties=Excel 12.0")
        ' MyCommand = New System.Data.OleDb.OleDbDataAdapter("select * from [Sheet2$] WHERE DAY = '" & TextBox1.Text.ToString & "'  ", MyConnection)
        'MyCommand = New System.Data.OleDb.OleDbDataAdapter("select * from [Sheet1$] WHERE NAME = '" & TextBox2.Text.ToString & "'  ", MyConnection)
        MyCommand = New System.Data.OleDb.OleDbDataAdapter("select *  from [Sheet1$] WHERE  DAY = '" & weekday.ToString & "'   ", MyConnection)
        ' MyCommand = New System.Data.OleDb.OleDbDataAdapter("select *  from [Sheet1$] natural join [Sheet2$] WHERE NAME = '" & txtentrname.Text.ToString & "'and DAY = '" & weekday.ToString & "'   ", MyConnection)
        '  MyCommand = New System.Data.OleDb.OleDbDataAdapter("select [Sheet2$].ID,NAME,DAY,PERIOD1,PERIOD2,PERIOD3,PERIOD4,PERIOD5,PERIOD6  from [Sheet1$],[Sheet2$] WHERE [Sheet1$].ID = [Sheet2$].ID and NAME = '" & txtentrname.Text.ToString & "' AND DAY = '" & weekday.ToString & "' ", MyConnection)
        '  MyCommand = New System.Data.OleDb.OleDbDataAdapter("select * from [Sheet2$] WHERE DAY='monday'  ", MyConnection)
        DtSet = New System.Data.DataSet
        MyCommand.Fill(DtSet)
        Dim rowcount As Integer
        Dim dt As New DataTable()
        Dim ds As New OleDb.OleDbDataAdapter("select *  from [Sheet1$] WHERE  DAY = '" & weekday.ToString & "'   ", MyConnection)
        ds.Fill(dt)
        rowcount = dt.Columns.Count 
        DGV1.DataSource = DtSet.Tables(0)
        ' rowcount = DGV1.Rows.Count


        '   txtbody.Text = "NAME " & vbTab & vbTab & "DAY          " & vbTab & "PERD1" & vbTab & "PERD2" & vbTab & "PERD3" & vbTab & "PERD4" & vbTab & "PERD5" & vbTab & "PERD6" & vbNewLine & ""
        '  txtbody.Text = txtbody.Text + "--------------------------------------------------------------------------------------------------------------------" & vbNewLine
        txtbody.Text = " The Following Details Are The Schedule for Today (" & Date.Today & ")" & vbNewLine & vbNewLine


        txtbody.Text = txtbody.Text + name.ToUpper & vbTab

        ' txtbody.Text = txtbody.Text + name.ToUpper & vbTab & vbTab


        If day = 7 Then
            Try

            Catch ex As Exception

            End Try
        ElseIf day = 6 Then
            For i = 0 To 4

                Try
                    arr1(i) = DtSet.Tables(0).Rows(0).Item(i)
                    txtbody.Text = txtbody.Text + arr1(i) & vbTab & vbTab
                Catch ex As Exception
                    txtbody.Text = txtbody.Text + arr1(i - 1) & vbTab
                End Try

            Next


        Else

            For i = 0 To 6
                Try
                    arr1(i) = DtSet.Tables(0).Rows(0).Item(i)
                    txtbody.Text = txtbody.Text + arr1(i) & vbTab + "--  "
                Catch ex As Exception
                    txtbody.Text = txtbody.Text + arr1(i - 1) & vbTab
                End Try


            Next
        End If

        MyConnection.Close()
        '    Catch ex As Exception
        '  MessageBox.Show(" Error Generating Time Table. Please make sure that you have imported the necessary files. ", "E Mail")
        '   End Try
    End Function
    

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnimport.Select()

    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnimport.Click
        Try
            OFdialog.Title = "Please Select a File"
            OFdialog.InitialDirectory = "C:\"
            OFdialog.FileName = ""
            OFdialog.Multiselect = True

            OFdialog.DefaultExt = ".xlsx"
            '  OFdialog.Filter = "Excel Documents (*.XLS)|*.XLS"
            OFdialog.ShowDialog()
            getfilenames()


            If Windows.Forms.DialogResult.Cancel Then
            Else
                MessageBox.Show(" Imoprted!")
            End If
        Catch ex As Exception
            '  MessageBox.Show(" Error Opening file ")
        End Try

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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsend.Click

        Try
            btnsend.Text = " Sending.. Please Wait.. "
            btnsend.Enabled = False

            If txtuser.Text = "" Then
                MessageBox.Show(" Error! Please Enter your Mail ID")
                txtuser.Select()

            ElseIf txtpass.Text = "" Then
                MessageBox.Show(" Error! Please Enter your Password")
                txtpass.Select()
            End If
            Dim message As New Net.Mail.MailMessage(txtuser.Text.ToString, cmbto.Text.ToString, txtsub.Text.ToString.ToString, txtbody.Text.ToString + vbNewLine + txtreminder.Text)
            Dim smtp As New Net.Mail.SmtpClient("smtp.gmail.com")
            Dim cred As New Net.NetworkCredential(txtuser.Text.ToString, txtpass.Text.ToString)
            smtp.EnableSsl = True
            smtp.Credentials = cred
            smtp.Port = 587
            smtp.Host = "smtp.gmail.com"
            smtp.Send(message)
            btnsend.Text = " Send "
            btnsend.Enabled = True

            MsgBox("Message sent successfully! Do u want to clear fields?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Message")
            btnsend.Text = "Send"
            If MsgBoxResult.Yes Then
                txtbody.Clear()
                txtpass.Clear()
                txtsub.Clear()
                cmbto.Text = ""
                txtuser.Clear()
                txtreminder.Clear()

            ElseIf MsgBoxResult.No Then

            End If
        Catch ex As Exception
            ' MsgBox("Error!! Check internet settings")
            MsgBox(ex.ToString)

        End Try

    End Sub

    Private Sub btncsef_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncsef.Click

        cmbto.Text = "cse@christuniversity.in"
    End Sub

    Private Sub btnecef_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnecef.Click
        cmbto.Text = "ece@christuniversity.in"
    End Sub

    Private Sub btneeef_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneeef.Click
        cmbto.Text = "eee@christuniversity.in"
    End Sub

    Private Sub btnitf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnitf.Click
        cmbto.Text = "it@christuniversity.in"
    End Sub

    Private Sub btnmechf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmechf.Click
        cmbto.Text = "mech@christuniversity.in"
    End Sub

    Private Sub btncivilf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncivilf.Click
        cmbto.Text = "civil@christuniversity.in"
    End Sub

    
    Private Sub btntest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DGV1.Visible = False
        storeidname()

    End Sub

    

    Private Sub btnadmin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadmin.Click
        Dim pass As String

        txtuser.Text = "super.user1009@gmail.com"
        pass = "superadmin1"
        txtpass.Text = pass

    End Sub

    Private Sub cmbto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbto.KeyPress
        Dim flag As Integer = 0
        If (e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter)) Then

            Dim split() As String = cmbto.Text.Split(".")
            Dim temp As String
            Dim flag1 As Integer = 0
            Dim flag2 As Integer = 0


            For i = 0 To it - 1

                arr(i) = lstinput.Items(i)
                Dim parts() As String = arr(i).ToString.Split("\")
                temp = parts(2)
                Dim split2() As String = temp.ToString.Split(".")
                ' TextBox1.Text = split(0)
                ' TextBox2.Text = split2(0)
                If split(0).ToString.Contains(split2(0).ToString) = True Then
                    flag1 = 1
                Else
                    flag2 = 1
                End If
            Next
            If flag1 = 1 Then
                generatett()
            ElseIf flag1 = 0 Then
                MsgBox("The timetable for  username " & cmbto.Text & " does not exist. Send custom message  ?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Message")

                If MsgBoxResult.Yes Then


                ElseIf MsgBoxResult.No Then
                    txtbody.Clear()
                    txtpass.Clear()
                    txtsub.Clear()
                    cmbto.Text = ""
                    txtuser.Clear()
                    Me.Close()

                End If
            End If
            'generatett()
        End If

    End Sub

    Private Sub cmbto_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles cmbto.PreviewKeyDown

    End Sub

    Private Sub cmbto_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbto.SelectedIndexChanged


        Dim split() As String = cmbto.Text.Split(".")
        Dim temp As String
        Dim flag1 As Integer = 0
        Dim flag2 As Integer = 0


        For i = 0 To it - 1

            arr(i) = lstinput.Items(i)
            Dim parts() As String = arr(i).ToString.Split("\")
            temp = parts(2)
            Dim split2() As String = temp.ToString.Split(".")
          
            If split(0).ToString.Contains(split2(0).ToString) = True Then
                flag1 = 1
            Else
                flag2 = 1
            End If
        Next
        If flag1 = 1 Then
            generatett()
        ElseIf flag1 = 0 Then
            MsgBox("The timetable for  username " & cmbto.Text & " does not exist. Send custom message  ?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Message")

            If MsgBoxResult.Yes Then
                

            ElseIf MsgBoxResult.No Then
                txtbody.Clear()
                txtpass.Clear()
                txtsub.Clear()
                cmbto.Text = ""
                txtuser.Clear()
                Me.Close()

            End If
        End If
        

    End Sub


    Private Sub cmbto_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbto.TextChanged

        
    End Sub

    Private Sub Button1_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        getfilenames()

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        Dim x As Integer
        If CheckBox1.Checked = True Then
            For x = 0 To cmbto.Items.Count - 1

                cmbto.Text = cmbto.Text + cmbto.Items(x)
                If x < cmbto.Items.Count - 1 Then
                    cmbto.Text = cmbto.Text + ","
                End If

            Next
            txtsub.Clear()
            txtbody.Clear()

        ElseIf CheckBox1.Checked = False Then
            cmbto.Text = ""
        End If
    End Sub

    Private Sub txtbody_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbody.TextChanged

    End Sub
End Class
