Imports MySql.Data.MySqlClient
Imports System.Globalization

Public Class UC_ManageEmployees

    Dim connString As String = "server=localhost;userid=root;password=root;database=crud_employee_db;"

    ' ================= UserControl Load =================
    Private Sub UC_ManageEmployees_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Setup DataGridView
        dgvEmployees.ReadOnly = True
        dgvEmployees.AllowUserToAddRows = False
        dgvEmployees.AllowUserToDeleteRows = False
        dgvEmployees.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvEmployees.MultiSelect = False

        ' Lock textboxes initially
        SetTextboxesReadOnly(True)

        ' Load employees
        LoadEmployees()
    End Sub

    ' ================= UserControl Resize =================
    Private Sub UC_ManageEmployees_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        ResizeColumns()
    End Sub

    ' ================= Load Employees =================
    Private Sub LoadEmployees()
        Dim query As String = "SELECT * FROM employees" ' Removed is_deleted

        Try
            Using conn As New MySqlConnection(connString)
                conn.Open()
                Dim adapter As New MySqlDataAdapter(query, conn)
                Dim table As New DataTable()
                adapter.Fill(table)
                dgvEmployees.DataSource = table

                ' Hide ID column
                If dgvEmployees.Columns.Contains("id") Then dgvEmployees.Columns("id").Visible = False

                ' Resize columns to fill the grid
                ResizeColumns()
            End Using
        Catch ex As MySqlException
            MessageBox.Show("MySQL Error: " & ex.Message)
        Catch ex As Exception
            MessageBox.Show("Error loading employees: " & ex.Message)
        End Try
    End Sub

    ' ================= Resize Columns =================
    Private Sub ResizeColumns()
        If dgvEmployees.Columns.Count = 0 Then Exit Sub

        ' Stretch all columns to fill the DataGridView width
        dgvEmployees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        ' Adjust relative column widths
        If dgvEmployees.Columns.Contains("name") Then dgvEmployees.Columns("name").FillWeight = 200
        If dgvEmployees.Columns.Contains("position") Then dgvEmployees.Columns("position").FillWeight = 150
        If dgvEmployees.Columns.Contains("salary") Then dgvEmployees.Columns("salary").FillWeight = 100
        If dgvEmployees.Columns.Contains("department") Then dgvEmployees.Columns("department").FillWeight = 150
    End Sub

    ' ================= Helper to lock/unlock textboxes =================
    Private Sub SetTextboxesReadOnly(lock As Boolean)
        txtName.ReadOnly = lock
        txtPosition.ReadOnly = lock
        txtSalary.ReadOnly = lock
        txtDepartment.ReadOnly = lock
    End Sub

    ' ================= DataGridView Row Click =================
    Private Sub dgvEmployees_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmployees.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvEmployees.Rows(e.RowIndex)

            txtName.Text = If(IsDBNull(row.Cells("name").Value), "", row.Cells("name").Value.ToString())
            txtPosition.Text = If(IsDBNull(row.Cells("position").Value), "", row.Cells("position").Value.ToString())
            txtSalary.Text = If(IsDBNull(row.Cells("salary").Value), "", row.Cells("salary").Value.ToString())
            txtDepartment.Text = If(IsDBNull(row.Cells("department").Value), "", row.Cells("department").Value.ToString())
            txtHiddenID.Text = If(IsDBNull(row.Cells("id").Value), "", row.Cells("id").Value.ToString())

            ' Keep textboxes locked until Edit is pressed
            SetTextboxesReadOnly(True)
        End If
    End Sub

    ' ================= Edit Button =================
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If txtHiddenID.Text = "" Then
            MessageBox.Show("Select a row first!")
            Exit Sub
        End If
        SetTextboxesReadOnly(False)
    End Sub

    ' ================= Update Button =================
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If txtHiddenID.Text = "" Then
            MessageBox.Show("Select a row first!")
            Exit Sub
        End If

        Dim salaryValue As Decimal
        If Not Decimal.TryParse(txtSalary.Text.Trim(), NumberStyles.Number Or NumberStyles.AllowCurrencySymbol, Globalization.CultureInfo.CurrentCulture, salaryValue) Then
            MessageBox.Show("Salary must be a valid number.")
            Exit Sub
        End If

        Dim idValue As Integer
        If Not Integer.TryParse(txtHiddenID.Text, idValue) Then
            MessageBox.Show("Invalid employee ID.")
            Exit Sub
        End If

        Dim query As String = "UPDATE employees SET name=@name, position=@position, salary=@salary, department=@department WHERE id=@id"

        Try
            Using conn As New MySqlConnection(connString)
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@name", txtName.Text)
                    cmd.Parameters.AddWithValue("@position", txtPosition.Text)
                    cmd.Parameters.AddWithValue("@salary", salaryValue)
                    cmd.Parameters.AddWithValue("@department", txtDepartment.Text)
                    cmd.Parameters.AddWithValue("@id", idValue)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Employee updated!")
            LoadEmployees()
            ClearFields()
            SetTextboxesReadOnly(True)

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    '================= Delete Button =================
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If txtHiddenID.Text = "" Then
            MessageBox.Show("Select a row first!")
            Exit Sub
        End If

        Dim idValue As Integer
        If Not Integer.TryParse(txtHiddenID.Text, idValue) Then
            MessageBox.Show("Invalid employee ID.")
            Exit Sub
        End If

        Dim query As String = "DELETE FROM employees WHERE id=@id"

        Try
            Using conn As New MySqlConnection(connString)
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", idValue)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Employee deleted!")
            LoadEmployees()
            ClearFields()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub ClearFields()
        txtName.Clear()
        txtPosition.Clear()
        txtSalary.Clear()
        txtDepartment.Clear()
        txtHiddenID.Clear()
        SetTextboxesReadOnly(True)
    End Sub

End Class
