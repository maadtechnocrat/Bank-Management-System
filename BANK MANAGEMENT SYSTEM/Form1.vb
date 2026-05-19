Public Class frmlogin
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        If txtUsername.Text = "admin" And txtPIN.Text = "1234" Then

            frmDashboard.Show()
            Me.Hide()

        Else

            MessageBox.Show("Invalid Username or PIN")

        End If

    End Sub

    Private Sub txtPIN_TextChanged(sender As Object, e As EventArgs) Handles txtPIN.TextChanged
        If txtPIN.Text.Length > 4 Then

            MessageBox.Show("PIN must be 4 digits")
            Exit Sub

        End If
    End Sub

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged

    End Sub
End Class