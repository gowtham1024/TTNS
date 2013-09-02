Public Class subindex

    Private Sub btndisplayidname_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndisplayidname.Click
        DGV1.Visible = True
        Dim MyConnection As System.Data.OleDb.OleDbConnection
        Dim DtSet As System.Data.DataSet
        Dim MyCommand As System.Data.OleDb.OleDbDataAdapter
        MyConnection = New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='d:\ttable1.xlsx';Extended Properties=Excel 12.0")
        MyCommand = New System.Data.OleDb.OleDbDataAdapter("select NAME,ID from [Sheet1$]  ", MyConnection)
        DtSet = New System.Data.DataSet
        MyCommand.Fill(DtSet)
        DGV1.DataSource = DtSet.Tables(0)
        MyConnection.Close()

    End Sub

    Private Sub btndisplayexcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndisplayexcel.Click

        showdata.Show()



    End Sub

    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        Me.Close()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Advanced_tools.Show()

    End Sub
End Class