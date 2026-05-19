Imports System.IO
Public Class frmWithdraw
    Private Sub btnWithdraw_Click(sender As Object, e As EventArgs) Handles btnWithdraw.Click
        Dim transaction As String

        transaction = txtAccount.Text & "|Withdraw|" & txtAmount.Text & "|" & Date.Now.ToString()

        File.AppendAllText("transactions.txt", transaction & Environment.NewLine)
        Dim lines As New List(Of String)

        lines.AddRange(File.ReadAllLines("customers.txt"))

        For i As Integer = 0 To lines.Count - 1

            Dim data() As String = lines(i).Split("|"c)

            If data(1) = txtAccount.Text Then

                Dim oldBalance As Double = Val(data(4))
                Dim withdrawAmount As Double = Val(txtAmount.Text)

                If withdrawAmount > oldBalance Then

                    MessageBox.Show("Insufficient Balance")
                    Exit Sub

                End If

                Dim newBalance As Double = oldBalance - withdrawAmount

                data(4) = newBalance.ToString()

                lines(i) = String.Join("|", data)

                File.WriteAllLines("customers.txt", lines)

                MessageBox.Show("Withdrawal Successful")

                Exit Sub

            End If

        Next

        MessageBox.Show("Account Not Found")

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        frmDashboard.Show()
        Me.Hide()
    End Sub
End Class