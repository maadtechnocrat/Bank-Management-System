Imports System.IO
Public Class Form7
    Private Sub frmReports_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim lines() As String = File.ReadAllLines("customers.txt")

        lblCustomers.Text = lines.Length.ToString()

        Dim total As Double = 0

        For Each line As String In lines

            Dim data() As String = line.Split("|"c)

            total += Val(data(4))

        Next

        lblMoney.Text = total.ToString()

    End Sub
End Class