Imports MySql.Data.MySqlClient

Public Class UC_AddEmployee

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' Basic validation
        Dim name = txtName.Text.Trim()
        Dim position = txtposition.Text.Trim()
        Dim salaryText = txtSalary.Text.Trim()
        Dim dept = txtDepartment.Text.Trim()

        If String.IsNullOrWhiteSpace(name) Or String.IsNullOrWhiteSpace(position) Or String.IsNullOrWhiteSpace(salaryText) Or String.IsNullOrWhiteSpace(dept) Then
            MessageBox.Show("Please fill in all fields.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim salary As Decimal
        If Not Decimal.TryParse(salaryText, salary) Then
            MessageBox.Show("Please enter a valid salary.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Using con = DB.GetConnection()
                Using cmd As New MySqlCommand("INSERT INTO employees (name, position, salary, department) VALUES (@name, @pos, @salary, @dept)", con)
                    cmd.Parameters.AddWithValue("@name", name)
                    cmd.Parameters.AddWithValue("@pos", position)
                    cmd.Parameters.AddWithValue("@salary", salary)
                    cmd.Parameters.AddWithValue("@dept", dept)
                    con.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Employee added successfully!")
            ' Clear fields
            txtName.Text = ""
            txtposition.Text = ""
            txtSalary.Text = ""
            txtDepartment.Text = ""
        Catch ex As Exception
            MessageBox.Show("Error adding employee: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtposition_Click(sender As Object, e As EventArgs) Handles txtposition.Click

    End Sub
End Class
