Public Class index

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()

    End Sub

    Private Sub btnemail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnemail.Click
        Email.Show()


    End Sub

    Private Sub btnmore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmore.Click
        subindex.Show()


    End Sub

    Private Sub btn2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn2.Click
        automail.Show()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Exam.Show()

    End Sub
End Class