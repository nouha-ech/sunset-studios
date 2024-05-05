Public Class Form4
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Hide()
        Form2.Show()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Me.Hide()
        Form6.Show()
    End Sub
End Class