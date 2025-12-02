Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LoadControl(ctrl As UserControl)
        Panel4.Controls.Clear()
        ctrl.Dock = DockStyle.Fill
        Panel4.Controls.Add(ctrl)
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
End Class

