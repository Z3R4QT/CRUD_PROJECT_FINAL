Imports MySql.Data.MySqlClient
Imports System.Globalization

Public Class UC_AddEmployee

    Dim connString As String = "server=localhost;userid=root;password=root;database=crud_employee_db;"

    Private Sub UC_AddEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize textboxes with prefixes
        txtName.Text = "NAME: "
        txtName.SelectionStart = txtName.Text.Length

        txtposition.Text = "POSITION: "
        txtposition.SelectionStart = txtposition.Text.Length

        txtSalary.Text = "SALARY: "
        txtSalary.SelectionStart = txtSalary.Text.Length

        txtDepartment.Text = "DEPARTMENT: "
        txtDepartment.SelectionStart = txtDepartment.Text.Length
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' Remove prefixes when validating and saving
        Dim nameText As String = txtName.Text.Substring(6).Trim()
        Dim positionText As String = txtposition.Text.Substring(9).Trim()
        Dim salaryText As String = txtSalary.Text.Substring(7).Trim()
        Dim departmentText As String = txtDepartment.Text.Substring(11).Trim()

        If nameText = "" Or positionText = "" Or salaryText = "" Or departmentText = "" Then
            MessageBox.Show("All fields are required!")
            Exit Sub
        End If

        Dim salaryValue As Decimal
        If Not Decimal.TryParse(salaryText, NumberStyles.Number Or NumberStyles.AllowCurrencySymbol, CultureInfo.CurrentCulture, salaryValue) Then
            MessageBox.Show("Salary must be a valid number.")
            Exit Sub
        End If

        Dim query As String = "INSERT INTO employees (name, position, salary, department)
                               VALUES (@name, @position, @salary, @department)"

        Try
            Using conn As New MySqlConnection(connString)
                conn.Open()

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@name", nameText)
                    cmd.Parameters.AddWithValue("@position", positionText)
                    cmd.Parameters.AddWithValue("@salary", salaryValue)
                    cmd.Parameters.AddWithValue("@department", departmentText)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Employee added successfully!")
            ClearFields()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try

    End Sub

    Private Sub ClearFields()
        txtName.Text = "NAME: "
        txtName.SelectionStart = txtName.Text.Length

        txtposition.Text = "POSITION: "
        txtposition.SelectionStart = txtposition.Text.Length

        txtSalary.Text = "SALARY: "
        txtSalary.SelectionStart = txtSalary.Text.Length

        txtDepartment.Text = "DEPARTMENT: "
        txtDepartment.SelectionStart = txtDepartment.Text.Length
    End Sub

    ' Prevent user from deleting prefixes
    Private Sub txtName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtName.KeyPress
        If txtName.SelectionStart <= 6 AndAlso e.KeyChar = ChrW(Keys.Back) Then e.Handled = True
    End Sub

    Private Sub txtposition_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtposition.KeyPress
        If txtposition.SelectionStart <= 9 AndAlso e.KeyChar = ChrW(Keys.Back) Then e.Handled = True
    End Sub

    Private Sub txtSalary_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSalary.KeyPress
        If txtSalary.SelectionStart <= 7 AndAlso e.KeyChar = ChrW(Keys.Back) Then e.Handled = True
    End Sub

    Private Sub txtDepartment_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDepartment.KeyPress
        If txtDepartment.SelectionStart <= 11 AndAlso e.KeyChar = ChrW(Keys.Back) Then e.Handled = True
    End Sub

    ' Ensure cursor never goes before the prefix
    Private Sub txtName_MouseClick(sender As Object, e As MouseEventArgs) Handles txtName.MouseClick
        If txtName.SelectionStart < 6 Then txtName.SelectionStart = txtName.Text.Length
    End Sub

    Private Sub txtposition_MouseClick(sender As Object, e As MouseEventArgs) Handles txtposition.MouseClick
        If txtposition.SelectionStart < 9 Then txtposition.SelectionStart = txtposition.Text.Length
    End Sub

    Private Sub txtSalary_MouseClick(sender As Object, e As MouseEventArgs) Handles txtSalary.MouseClick
        If txtSalary.SelectionStart < 7 Then txtSalary.SelectionStart = txtSalary.Text.Length
    End Sub

    Private Sub txtDepartment_MouseClick(sender As Object, e As MouseEventArgs) Handles txtDepartment.MouseClick
        If txtDepartment.SelectionStart < 11 Then txtDepartment.SelectionStart = txtDepartment.Text.Length
    End Sub

End Class
