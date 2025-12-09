Imports MySql.Data.MySqlClient

Public NotInheritable Class DB
    Private Sub New()
    End Sub

    Public Shared Function GetConnection() As MySqlConnection
        ' Connection string set to the database and credentials provided by the user
        Return New MySqlConnection("server=localhost;userid=root;password=root;database=crud_employees_db;SslMode=none")
    End Function
End Class