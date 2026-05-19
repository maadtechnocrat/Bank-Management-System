Public Class frmDashboard
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnReports.Click
        frmReports.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btnEmployee.Click
        frmEmployee.Show()
    End Sub

    Private Sub btnCustomer_Click(sender As Object, e As EventArgs) Handles btnCustomer.Click
        frmCustomer.Show()
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        frmViewCustomers.Show()
    End Sub

    Private Sub btnDeposit_Click(sender As Object, e As EventArgs) Handles btnDeposit.Click
        frmDeposit.Show()
    End Sub

    Private Sub btnWithdraw_Click(sender As Object, e As EventArgs) Handles btnWithdraw.Click
        frmWithdraw.Show()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        frmlogin.Show()
        Me.Close()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click

        Dim result As DialogResult

        result = MessageBox.Show("Do you really want to logout from the system?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then

            Application.Exit()

        End If

    End Sub
End Class