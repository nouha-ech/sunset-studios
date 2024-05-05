Imports MySql.Data.MySqlClient
Imports MySqlConnector
Public Class Form5
    Dim con As MySqlConnection
    Dim cmd As MySqlCommand


    Dim SDA As New MySqlDataAdapter
    Dim t As New DataTable
    Dim Bs As New BindingSource
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con = New MySqlConnection
        con.ConnectionString =
            "Server=localhost;Database=moncinema;Uid=root;Pwd=Dashboard@2024;"
        Try
            con.Open()
            Dim query As String
            query = "SELECT * FROM movies"
            cmd = New MySqlCommand(query, con)

            SDA.SelectCommand = cmd
            SDA.Fill(t)
            Bs.DataSource = t
            DataGridView1.DataSource = Bs
            SDA.Update(t)




            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            con.Dispose()
        End Try
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Hide()
        Form2.Show()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Hide()
        Form4.Show()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Hide()
        Form3.Show()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Me.Hide()
        Form6.Show()
    End Sub
End Class