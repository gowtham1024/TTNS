Imports System.Data.SqlClient

Public Class Query
    Dim cn As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=c:\users\phoenix\documents\visual studio 2010\Projects\Query\Query\Database1.mdf;Integrated Security=True;User Instance=True")
    Dim cmd As New SqlCommand
    Dim dr As SqlDataReader


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmd.Connection = cn
        loadlistbox()



    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnins.Click
        If txtname1.Text <> "" And txtid1.Text <> "" Then
            cn.open()
            cmd.CommandText = " INSERT INTO admin(NAME,PASSWORD) values (' " & txtname1.Text & " ', ' " & txtid1.Text & " ' )"
            cmd.ExecuteNonQuery()
            cn.close()
            txtname1.Text = ""
            txtid1.Text = ""
            loadlistbox()
            MessageBox.Show(" Added ")
        End If
    End Sub
    Private Sub loadlistbox()
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        txtname2.Text = ""
        txtid2.Text = ""
        cn.Open()
        cmd.CommandText = "select NAME,PASSWORD from admin "
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            While (dr.Read())
                ListBox1.Items.Add(dr("NAME"))
                ListBox2.Items.Add(dr(1))

            End While
        End If
        cn.close()

    End Sub
    Private Sub ListBox1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBox1.MouseClick
        Dim lb As New ListBox
        lb = sender

        If lb.SelectedIndex <> -1 Then
            ListBox1.SelectedIndex = lb.SelectedIndex
            ListBox2.SelectedIndex = lb.SelectedIndex
            txtname2.Text = ListBox1.SelectedItem
            txtid2.Text = ListBox2.SelectedItem


        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupd.Click
        If txtname2.Text <> "" And txtid2.Text <> "" Then
            cn.Open()
            cmd.CommandText = " update admin set NAME = ' " & txtname2.Text & " ' , PASSWORD = ' " & txtid2.Text & " ' where Name= '" & ListBox1.SelectedItem & "' "
            cmd.ExecuteNonQuery()
            cn.Close()
            txtname2.Text = ""
            txtid2.Text = ""
            loadlistbox()
        Else
            MessageBox.Show(" Error!")

        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndel.Click
        If txtname2.Text <> "" And txtid2.Text <> "" Then
            cn.Open()
            cmd.CommandText = " delete from admin where NAME= ' " & txtname2.Text & " ' "
            cmd.CommandText = " delete from admin where  PASSWORD = '" & txtid2.Text & "' "
            cmd.ExecuteNonQuery()
            cn.Close()
            txtname2.Text = ""
            txtid2.Text = ""
            loadlistbox()
        Else
            MessageBox.Show("Error!")


        End If
    End Sub

    Private Sub ListBox2_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBox2.MouseClick
        Dim lb As New ListBox
        lb = sender

        If lb.SelectedIndex <> -1 Then
            ListBox1.SelectedIndex = lb.SelectedIndex
            ListBox2.SelectedIndex = lb.SelectedIndex
            txtname2.Text = ListBox1.SelectedItem
            txtid2.Text = ListBox2.SelectedItem
        End If
    End Sub

    Private Sub ListBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox2.SelectedIndexChanged

    End Sub

    Private Sub btnshow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnshow.Click
        lbllistid.Visible = True
        lbllistname.Visible = True

        ListBox1.Visible = True
        ListBox2.Visible = True

    End Sub

    Private Sub txtname2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtname2.TextChanged

    End Sub
End Class
