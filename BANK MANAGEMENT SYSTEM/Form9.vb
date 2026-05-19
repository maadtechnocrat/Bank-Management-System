Imports System.IO
Public Class frmReports
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub btnLoadCustomers_Click(sender As Object, e As EventArgs) Handles btnLoadCustomer.Click

        dgvReports.Rows.Clear()
        dgvReports.Columns.Clear()

        dgvReports.ColumnCount = 5

        dgvReports.Columns(0).Name = "Name"
        dgvReports.Columns(1).Name = "Account"
        dgvReports.Columns(2).Name = "Phone"
        dgvReports.Columns(3).Name = "Address"
        dgvReports.Columns(4).Name = "Balance"

        Dim lines() As String = File.ReadAllLines("customers.txt")

        Dim totalMoney As Double = 0

        For Each line As String In lines

            Dim data() As String = line.Split("|"c)

            dgvReports.Rows.Add(data)

            totalMoney += Val(data(4))

        Next

        lblTotalCustomers.Text = "Total Customers: " & lines.Length

        lblTotalMoney.Text = "Total Bank Balance: " & totalMoney

    End Sub

    Private Sub btnLoadTransactions_Click(sender As Object, e As EventArgs) Handles btnLoadTransactions.Click

        dgvReports.Rows.Clear()
        dgvReports.Columns.Clear()

        dgvReports.ColumnCount = 4

        dgvReports.Columns(0).Name = "Account"
        dgvReports.Columns(1).Name = "Transaction"
        dgvReports.Columns(2).Name = "Amount"
        dgvReports.Columns(3).Name = "Date"

        Dim lines() As String = File.ReadAllLines("transactions.txt")

        For Each line As String In lines

            Dim data() As String = line.Split("|"c)

            dgvReports.Rows.Add(data)

        Next

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        frmDashboard.Show()
        Me.Hide()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim y As Integer = 100

        For Each row As DataGridViewRow In dgvReports.Rows

            If row.Cells(0).Value IsNot Nothing Then

                Dim rowText As String = ""

                For Each cell As DataGridViewCell In row.Cells

                    rowText &= cell.Value & "   "

                Next

                e.Graphics.DrawString(rowText, New Font("Arial", 10), Brushes.Black, 100, y)

                y += 30

            End If

        Next
    End Sub

    Private Sub PrintPreviewDialog1_Load(sender As Object, e As EventArgs) Handles PrintPreviewDialog1.Load

    End Sub

    Private Sub lblTotalCustomers_Click(sender As Object, e As EventArgs) Handles lblTotalCustomers.Click

    End Sub
End Class