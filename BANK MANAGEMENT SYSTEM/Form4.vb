Imports System.IO
Public Class frmViewCustomers
    Private Sub LoadCustomers()

        dgvCustomers.Rows.Clear()

        If File.Exists("customers.txt") Then

            Dim lines() As String = File.ReadAllLines("customers.txt")

            For Each line As String In lines

                Dim data() As String = line.Split("|"c)

                dgvCustomers.Rows.Add(data)

            Next

        End If

    End Sub

    Private Sub frmViewCustomers_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dgvCustomers.ColumnCount = 5

        dgvCustomers.Columns(0).Name = "Name"
        dgvCustomers.Columns(1).Name = "Account"
        dgvCustomers.Columns(2).Name = "Phone"
        dgvCustomers.Columns(3).Name = "Address"
        dgvCustomers.Columns(4).Name = "Balance"

        LoadCustomers()

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        dgvCustomers.Rows.Clear()

        Dim lines() As String = File.ReadAllLines("customers.txt")

        For Each line As String In lines

            Dim data() As String = line.Split("|"c)

            If data(1).Contains(txtSearch.Text) Then

                dgvCustomers.Rows.Add(data)

            End If

        Next

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        frmDashboard.Show()
        Me.Hide()

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        If dgvCustomers.SelectedRows.Count = 0 Then

            MessageBox.Show("Please select a customer to delete")
            Exit Sub

        End If

        Dim result As DialogResult

        result = MessageBox.Show("Do you really want to delete this customer?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If result = DialogResult.Yes Then

            Dim accountNumber As String

            accountNumber = dgvCustomers.SelectedRows(0).Cells(1).Value.ToString()

            Dim lines As New List(Of String)

            lines.AddRange(File.ReadAllLines("customers.txt"))

            For i As Integer = lines.Count - 1 To 0 Step -1

                Dim data() As String = lines(i).Split("|"c)

                If data(1) = accountNumber Then

                    lines.RemoveAt(i)

                End If

            Next

            File.WriteAllLines("customers.txt", lines)

            LoadCustomers()

            MessageBox.Show("Customer Deleted Successfully")

        End If

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged

        If txtSearch.Text = "" Then

            LoadCustomers()

        End If

    End Sub
End Class