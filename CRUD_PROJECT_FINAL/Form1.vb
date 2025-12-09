Imports MySql.Data.MySqlClient
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Disable buttons until connection is made
        btnAddEmployee.Enabled = False
        btnManageEmployee.Enabled = False

        LoadControl(New UC_home())
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
        Dim conn As New MySqlConnection("server=localhost;userid=root;password=root;database=crud_employee_db;port=3306")
        Try
            conn.Open()
            MessageBox.Show("Connected to MySQL successfully!")

            btnAddEmployee.Enabled = True
            btnManageEmployee.Enabled = True
        Catch ex As Exception
            MessageBox.Show("DB connection failed: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

End Class
