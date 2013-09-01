Imports System.Data.SqlClient

Public Class Advanced_tools
    Dim cn As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=c:\users\phoenix\documents\visual studio 2010\Projects\Query\Query\Database1.mdf;Integrated Security=True;User Instance=True")
    Dim cmd As New SqlCommand
    Dim dr As SqlDataReader
    Dim MyCommand As System.Data.OleDb.OleDbDataAdapter
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnid.Click
        If txtid.Text = "" Then
            MessageBox.Show(" Please Enter the Email ID to be added ", "Message")
        Else
            Email.cmbto.Items.Add(txtid.Text)
            Email.cmbto.Sorted = True
            MessageBox.Show(" Successfully added", "Message")
        End If
    End Sub

    Private Sub btnadmin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadmin.Click
        If txtid.Text <> "" And txtpass.Text <> "" Then
            cn.Open()
            cmd.CommandText = " INSERT INTO admin(NAME,PASSWORD) values (' " & txtid.Text & " ', ' " & txtpass.Text & " ' )"
            cmd.ExecuteNonQuery()
            cn.Close()
            txtid.Text = ""
            txtpass.Text = ""

        Else
            MessageBox.Show("Please Enter the Fields!")
        End If
    End Sub

    Private Sub LinkLabel3_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        lstitems.Visible = True
        Dim i As Integer
        For i = 0 To Email.cmbto.Items.Count - 1
            lstitems.Items.Add(Email.cmbto.Items(i))
        Next


    End Sub

    Private Sub ListBox1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstitems.DoubleClick
        MsgBox("Are you sure that u want to delete the selected item?", MsgBoxStyle.Information + MsgBoxStyle.YesNoCancel, "Message")

        If MsgBoxResult.Yes Then
            lstitems.Items.Remove(lstitems.SelectedItem)
            Email.cmbto.Items.Remove(lstitems.SelectedItem)
        Else

        End If

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstitems.SelectedIndexChanged

    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        btnlist.Visible = True

        txtid.Visible = True
        txtpass.Visible = True
        lblid.Visible = True
        lblpass.Visible = True
        ListBox1.Visible = True
        ListBox2.Visible = True

        btnadmin.Visible = True

    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        txtid.Visible = True
        btnid.Visible = True

    End Sub

    Private Sub Advanced_tools_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmd.Connection = cn
    End Sub

    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        If txtpass.Text <> "" And txtid.Text <> "" Then
            cn.Open()
            cmd.CommandText = " update admin set NAME = ' " & txtid.Text & " ' , PASSWORD = ' " & txtpass.Text & " ' where Name= '" & ListBox1.SelectedItem & "' "
            cmd.ExecuteNonQuery()
            cn.Close()
            txtid.Text = ""
            txtpass.Text = ""

        Else
            MessageBox.Show(" Please Enter the Fields!")

        End If
    End Sub

    Private Sub btnlist_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlist.Click
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        ListBox1.Visible = True
        ListBox2.Visible = True

        txtid.Text = ""
        txtpass.Text = ""
        cn.Open()
        cmd.CommandText = "select NAME,PASSWORD from admin "
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            While (dr.Read())
                ListBox1.Items.Add(dr("NAME"))
                ListBox2.Items.Add(dr(1))

            End While
        End If
        cn.Close()
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click
        If txtid.Text <> "" Then
            cn.Open()
            cmd.CommandText = " delete from admin where NAME= ' " & txtid.Text & " ' "
            ''  cmd.CommandText = " delete from admin where  PASSWORD = '" & txtpass.Text & "' "
            cmd.ExecuteNonQuery()
            cn.Close()
            txtid.Text = ""
            txtpass.Text = ""

        Else
            MessageBox.Show("Please Enter the Fields!")
        End If

    End Sub

    Private Sub LinkLabel4_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        btnlist.Visible = True
        ListBox1.Visible = True
        ListBox2.Visible = True
        btnupdate.Visible = True

    End Sub

    Private Sub LinkLabel5_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel5.LinkClicked
        btnlist.Visible = True
        btndelete.Visible = True
        ListBox1.Visible = True
        ListBox2.Visible = True

    End Sub
End Class