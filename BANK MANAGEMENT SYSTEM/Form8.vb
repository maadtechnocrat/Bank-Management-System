Imports System.IO
Public Class frmEmployee
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Dim employee As String

        employee = txtUsername.Text & "|" & txtPIN.Text

        File.AppendAllText("employees.txt", employee & Environment.NewLine)

        MessageBox.Show("Employee Registered")

    End Sub

    Private Sub txtPIN_TextChanged(sender As Object, e As EventArgs) Handles txtPIN.TextChanged

    End Sub

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged

    End Sub
End Class