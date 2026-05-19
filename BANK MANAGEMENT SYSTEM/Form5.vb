Imports System.IO
Public Class frmDeposit
    Private Sub btnDeposit_Click(sender As Object, e As EventArgs) Handles btnDeposit.Click
        Dim transaction As String

        transaction = txtAccount.Text & "|Deposit|" & txtAmount.Text & "|" & Date.Now.ToString()

        File.AppendAllText("transactions.txt", transaction & Environment.NewLine)
        Dim lines As New List(Of String)

        lines.AddRange(File.ReadAllLines("customers.txt"))

        For i As Integer = 0 To lines.Count - 1

            Dim data() As String = lines(i).Split("|"c)

            If data(1) = txtAccount.Text Then

                Dim oldBalance As Double = Val(data(4))
                Dim depositAmount As Double = Val(txtAmount.Text)

                Dim newBalance As Double = oldBalance + depositAmount

                data(4) = newBalance.ToString()

                lines(i) = String.Join("|", data)

                File.WriteAllLines("customers.txt", lines)

                MessageBox.Show("Deposit Successful")

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
