Imports System.Diagnostics.Eventing
Imports System.Security.Cryptography
Imports MySql.Data.MySqlClient
Imports MySqlConnector
Public Class Form3
    Dim con As MySqlConnection
    Dim cmd As MySqlCommand


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DisplayMovies()

    End Sub
    Private Sub DisplayMovies()
        con = New MySqlConnection("Server=localhost;Database=moncinema;Uid=root;Pwd=*******;")
        Dim SDA As New MySqlDataAdapter
        Dim t As New DataTable
        Dim Bs As New BindingSource
        Try
            con.Open()
            Dim query As String = "SELECT title, releaseyear, ticketprice FROM movies WHERE genre='" & genrebox.Text & "'"
            cmd = New MySqlCommand(query, con)

            SDA.SelectCommand = cmd
            SDA.Fill(t)
            Bs.DataSource = t
            DataGridView1.DataSource = Bs
            SDA.Update(t)




            con.Close()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub



    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            genrebox.Text = selectedRow.Cells("genre").Value.ToString()
        End If
    End Sub


    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Hide()
        Form4.Show()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Hide()
        Form5.Show()
    End Sub
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Hide()
        Form6.Show()
    End Sub

End Class
