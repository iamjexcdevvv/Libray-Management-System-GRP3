Imports MySql.Data.MySqlClient
Module sqlcon
    Public conn As MySqlConnection = New MySqlConnection
    Public connectionString As String = New String("server=localhost;userid=root;password='';database=library-management")
End Module
