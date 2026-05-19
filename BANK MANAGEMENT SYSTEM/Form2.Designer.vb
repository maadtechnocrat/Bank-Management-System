<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnCustomer = New System.Windows.Forms.Button()
        Me.btnView = New System.Windows.Forms.Button()
        Me.btnDeposit = New System.Windows.Forms.Button()
        Me.btnWithdraw = New System.Windows.Forms.Button()
        Me.btnReports = New System.Windows.Forms.Button()
        Me.btnEmployee = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCustomer
        '
        Me.btnCustomer.ForeColor = System.Drawing.Color.Indigo
        Me.btnCustomer.Location = New System.Drawing.Point(12, 12)
        Me.btnCustomer.Name = "btnCustomer"
        Me.btnCustomer.Size = New System.Drawing.Size(111, 31)
        Me.btnCustomer.TabIndex = 0
        Me.btnCustomer.Text = "Add Customer"
        Me.btnCustomer.UseVisualStyleBackColor = True
        '
        'btnView
        '
        Me.btnView.ForeColor = System.Drawing.Color.Indigo
        Me.btnView.Location = New System.Drawing.Point(193, 12)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(111, 31)
        Me.btnView.TabIndex = 1
        Me.btnView.Text = "View Customer"
        Me.btnView.UseVisualStyleBackColor = True
        '
        'btnDeposit
        '
        Me.btnDeposit.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnDeposit.Location = New System.Drawing.Point(361, 12)
        Me.btnDeposit.Name = "btnDeposit"
        Me.btnDeposit.Size = New System.Drawing.Size(75, 31)
        Me.btnDeposit.TabIndex = 2
        Me.btnDeposit.Text = "Deposit"
        Me.btnDeposit.UseVisualStyleBackColor = True
        '
        'btnWithdraw
        '
        Me.btnWithdraw.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnWithdraw.Location = New System.Drawing.Point(497, 12)
        Me.btnWithdraw.Name = "btnWithdraw"
        Me.btnWithdraw.Size = New System.Drawing.Size(75, 31)
        Me.btnWithdraw.TabIndex = 3
        Me.btnWithdraw.Text = "Withdraw"
        Me.btnWithdraw.UseVisualStyleBackColor = True
        '
        'btnReports
        '
        Me.btnReports.ForeColor = System.Drawing.SystemColors.Highlight
        Me.btnReports.Location = New System.Drawing.Point(497, 85)
        Me.btnReports.Name = "btnReports"
        Me.btnReports.Size = New System.Drawing.Size(75, 37)
        Me.btnReports.TabIndex = 4
        Me.btnReports.Text = "Reports"
        Me.btnReports.UseVisualStyleBackColor = True
        '
        'btnEmployee
        '
        Me.btnEmployee.ForeColor = System.Drawing.SystemColors.Highlight
        Me.btnEmployee.Location = New System.Drawing.Point(245, 85)
        Me.btnEmployee.Name = "btnEmployee"
        Me.btnEmployee.Size = New System.Drawing.Size(172, 37)
        Me.btnEmployee.TabIndex = 5
        Me.btnEmployee.Text = "Employee Registration"
        Me.btnEmployee.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.ForeColor = System.Drawing.Color.Maroon
        Me.btnExit.Location = New System.Drawing.Point(342, 188)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 29)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnLogout
        '
        Me.btnLogout.ForeColor = System.Drawing.Color.Red
        Me.btnLogout.Location = New System.Drawing.Point(497, 188)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(75, 29)
        Me.btnLogout.TabIndex = 7
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'frmDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnEmployee)
        Me.Controls.Add(Me.btnReports)
        Me.Controls.Add(Me.btnWithdraw)
        Me.Controls.Add(Me.btnDeposit)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.btnCustomer)
        Me.Name = "frmDashboard"
        Me.Text = "frmDashboard"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnCustomer As Button
    Friend WithEvents btnView As Button
    Friend WithEvents btnDeposit As Button
    Friend WithEvents btnWithdraw As Button
    Friend WithEvents btnReports As Button
    Friend WithEvents btnEmployee As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnLogout As Button
End Class
