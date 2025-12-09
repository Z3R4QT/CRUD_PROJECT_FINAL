Imports MySql.Data.MySqlClient
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Optional: test or initialize DB connection here. Use DB.GetConnection() helper instead.
        ' Example (commented):
        Dim conn As New MySqlConnection("server=localhost;userid=root;password=root;database=crud_employees_db;port=3306")
        Try
            conn.Open()
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("DB connection failed: " & ex.Message)
        End Try
    End Sub

    Private Sub LoadControl(uc As UserControl)
        Panel4.Controls.Clear()
        uc.Dock = DockStyle.Fill
        Panel4.Controls.Add(uc)
    End Sub

    Private Sub btnAddEmployee_Click(sender As Object, e As EventArgs) Handles btnAddEmployee.Click
        LoadControl(New UC_AddEmployee())
    End Sub

    Private Sub btnManageEmployee_Click(sender As Object, e As EventArgs) Handles btnManageEmployee.Click
        LoadControl(New UC_ManageEmployees())
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        LoadControl(New UC_home())
    End Sub

    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
    End Sub
End Class

