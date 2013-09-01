Imports System.Data.SqlClient

Public Class login
    Dim cn As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=c:\users\phoenix\documents\visual studio 2010\Projects\Query\Query\Database1.mdf;Integrated Security=True;User Instance=True")
    Dim cmd As New SqlCommand
    Dim adap As New SqlDataAdapter
    Dim dr As SqlDataReader
    Dim dset As New DataSet

    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        Me.Close()

    End Sub

    Private Sub btnreset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreset.Click
        txtloginname.Clear()
        txtloginpass.Clear()

    End Sub

    Private Sub btnlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogin.Click
        Dim cn As New SqlConnection
        Dim cmd As New SqlCommand
        Dim adap As New SqlDataAdapter
        Dim dr As SqlDataReader
        Dim dset As New DataSet
        cn.ConnectionString = ("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\PHOENIX\Documents\Visual Studio 2010\Projects\query\Query\Database1.mdf;Integrated Security=True;User Instance=True")
        cmd.CommandText = "SELECT * FROM [admin] WHERE NAME= ' " & txtloginname.Text & " ' OR PASSWORD = '" & txtloginpass.Text & "'"

        cn.Open()
        cmd.Connection = cn
        adap.SelectCommand = cmd
        adap.Fill(dset, "0")

        Dim count = dset.Tables(0).Rows.Count

        If count > 0 Then
            index.Show()
        Else
            MessageBox.Show(" Incorrect Username or Password ", "Message")
        End If
        txtloginname.Clear()
        txtloginpass.Clear()

        cn.Close()


    End Sub

    Private Sub txtloginpass_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtloginpass.Enter


    End Sub

    Private Sub txtloginpass_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtloginpass.KeyPress
        If Asc(e.KeyChar) = 13 Then
            btnlogin.PerformClick()

        End If
    End Sub

    Private Sub txtloginpass_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtloginpass.TextChanged

    End Sub

    Private Sub login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtloginname.Select()

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
End Class
