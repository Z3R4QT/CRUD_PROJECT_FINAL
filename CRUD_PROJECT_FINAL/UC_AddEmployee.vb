Imports MySql.Data.MySqlClient

Public Class UC_AddEmployee

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Dim con As New MySqlConnection("server=localhost;user=root;password=;database=yourdb")
        Dim cmd As New MySqlCommand("INSERT INTO employees (name, position, salary, department)
                                     VALUES (@name, @pos, @salary, @dept)", con)
        cmd.Parameters.AddWithValue("@name", txtName.Text)
        cmd.Parameters.AddWithValue("@pos", txtPosition.Text)
        cmd.Parameters.AddWithValue("@salary", txtSalary.Text)
        cmd.Parameters.AddWithValue("@dept", txtDepartment.Text)

        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
        MessageBox.Show("Employee added successfully!")
    End Sub

    Private Sub txtposition_Click(sender As Object, e As EventArgs) Handles txtposition.Click

    End Sub
End Class
