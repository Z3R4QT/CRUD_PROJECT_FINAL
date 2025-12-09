Imports MySql.Data.MySqlClient

Public Class UC_ManageEmployees
    Private Sub UC_ManageEmployees_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub LoadData()
        Try
            Using con = DB.GetConnection()
                Using cmd As New MySqlCommand("SELECT id, name, position, salary, department FROM employees WHERE is_deleted = 0", con)
                    Dim dt As New DataTable()
                    Using da As New MySqlDataAdapter(cmd)
                        da.Fill(dt)
                    End Using
                    DataGridView1.DataSource = dt
                    If DataGridView1.Columns.Contains("id") Then DataGridView1.Columns("id").Visible = False
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading data: " & ex.Message)
        End Try
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            txtName.Text = selectedRow.Cells("name").Value.ToString()
            txtPosition.Text = selectedRow.Cells("position").Value.ToString()
            txtSalary.Text = selectedRow.Cells("salary").Value.ToString()
            txtDepartment.Text = selectedRow.Cells("department").Value.ToString()
            txtHiddenID.Text = selectedRow.Cells("id").Value.ToString()
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim query As String = "UPDATE employees SET name=@name, position=@position, salary=@salary, department=@department WHERE id=@id"
        Try
            Using con = DB.GetConnection()
                con.Open()
                Using cmd As New MySqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@name", txtName.Text)
                    cmd.Parameters.AddWithValue("@position", txtPosition.Text)
                    cmd.Parameters.AddWithValue("@salary", Decimal.Parse(txtSalary.Text))
                    cmd.Parameters.AddWithValue("@department", txtDepartment.Text)
                    cmd.Parameters.AddWithValue("@id", Integer.Parse(txtHiddenID.Text))
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            MessageBox.Show("Record updated successfully!")
            ClearFields()
            LoadData()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim query As String = "UPDATE employees SET is_deleted = 1 WHERE id=@id"
        Try
            Using con = DB.GetConnection()
                con.Open()
                Using cmd As New MySqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@id", Integer.Parse(txtHiddenID.Text))
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            MessageBox.Show("Record deleted successfully!")
            ClearFields()
            LoadData()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        ' Fill fields from selected row if not using double click
        If DataGridView1.CurrentRow IsNot Nothing Then
            Dim selectedRow As DataGridViewRow = DataGridView1.CurrentRow
            txtName.Text = selectedRow.Cells("name").Value.ToString()
            txtPosition.Text = selectedRow.Cells("position").Value.ToString()
            txtSalary.Text = selectedRow.Cells("salary").Value.ToString()
            txtDepartment.Text = selectedRow.Cells("department").Value.ToString()
            txtHiddenID.Text = selectedRow.Cells("id").Value.ToString()
        End If
    End Sub

    Private Sub ClearFields()
        txtName.Text = ""
        txtPosition.Text = ""
        txtSalary.Text = ""
        txtDepartment.Text = ""
        txtHiddenID.Text = ""
    End Sub
End Class
