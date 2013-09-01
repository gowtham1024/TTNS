Public Class showdata

    Private Sub btnimportt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnimportt.Click
        Dim fname As String
        OpenFileDialog1.Multiselect = False
        'OpenFileDialog1.DefaultExt = ".xlsx" ' Default file extension
        OpenFileDialog1.Title = ""

        OpenFileDialog1.Filter = "Excel Documents (*.XLSX)|*.XLSX"

        OpenFileDialog1.ShowDialog()
        fname = OpenFileDialog1.FileName
        Dim MyConnection As System.Data.OleDb.OleDbConnection
        Dim DtSet As System.Data.DataSet
        Dim MyCommand As System.Data.OleDb.OleDbDataAdapter
        MyConnection = New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" & fname & "';Extended Properties=Excel 12.0")
        MyCommand = New System.Data.OleDb.OleDbDataAdapter("select * from [Sheet1$]", MyConnection)
        ' MyCommand.TableMappings.Add("Table", "EXCEL")
        DtSet = New System.Data.DataSet
        MyCommand.Fill(DtSet)
        DataGridView1.DataSource = DtSet.Tables(0)
        MyConnection.Close()
       
    End Sub

End Class