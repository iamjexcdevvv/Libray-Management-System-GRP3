Imports System.Net
Imports MySql.Data.MySqlClient
Public Class borrow_request_list
    Private Async Sub DisplayBorrowRequestList()
        Try
            Dim query As String = "SELECT * FROM borrow_request"
            Using conn As New MySqlConnection(connectionString)
                Await conn.OpenAsync()

                Using cmd = New MySqlCommand(query, conn)
                    Await cmd.ExecuteNonQueryAsync()

                    Dim dataTable As New DataTable()
                    Dim dataAdapter As New MySqlDataAdapter(cmd)

                    dataAdapter.Fill(dataTable)
                    DataGridView1.DataSource = dataTable
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub borrow_request_list_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayBorrowRequestList()
    End Sub
    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        admin_dashboard.Show()
        Me.Close()
    End Sub
End Class