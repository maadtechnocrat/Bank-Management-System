<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmReports
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReports))
        Me.btnLoadCustomer = New System.Windows.Forms.Button()
        Me.btnLoadTransactions = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.dgvReports = New System.Windows.Forms.DataGridView()
        Me.lblTotalMoney = New System.Windows.Forms.Label()
        Me.lblTotalCustomers = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        CType(Me.dgvReports, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnLoadCustomer
        '
        Me.btnLoadCustomer.ForeColor = System.Drawing.Color.Green
        Me.btnLoadCustomer.Location = New System.Drawing.Point(21, 294)
        Me.btnLoadCustomer.Name = "btnLoadCustomer"
        Me.btnLoadCustomer.Size = New System.Drawing.Size(140, 23)
        Me.btnLoadCustomer.TabIndex = 0
        Me.btnLoadCustomer.Text = "Customer Reports"
        Me.btnLoadCustomer.UseVisualStyleBackColor = True
        '
        'btnLoadTransactions
        '
        Me.btnLoadTransactions.ForeColor = System.Drawing.Color.Green
        Me.btnLoadTransactions.Location = New System.Drawing.Point(202, 294)
        Me.btnLoadTransactions.Name = "btnLoadTransactions"
        Me.btnLoadTransactions.Size = New System.Drawing.Size(153, 23)
        Me.btnLoadTransactions.TabIndex = 1
        Me.btnLoadTransactions.Text = "Transaction Report"
        Me.btnLoadTransactions.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.ForeColor = System.Drawing.Color.Olive
        Me.btnPrint.Location = New System.Drawing.Point(133, 348)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(113, 23)
        Me.btnPrint.TabIndex = 2
        Me.btnPrint.Text = "Print report"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'dgvReports
        '
        Me.dgvReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReports.Location = New System.Drawing.Point(15, 12)
        Me.dgvReports.Name = "dgvReports"
        Me.dgvReports.RowHeadersWidth = 51
        Me.dgvReports.RowTemplate.Height = 24
        Me.dgvReports.Size = New System.Drawing.Size(773, 174)
        Me.dgvReports.TabIndex = 3
        '
        'lblTotalMoney
        '
        Me.lblTotalMoney.AutoSize = True
        Me.lblTotalMoney.ForeColor = System.Drawing.Color.Coral
        Me.lblTotalMoney.Location = New System.Drawing.Point(79, 204)
        Me.lblTotalMoney.Name = "lblTotalMoney"
        Me.lblTotalMoney.Size = New System.Drawing.Size(82, 16)
        Me.lblTotalMoney.TabIndex = 4
        Me.lblTotalMoney.Text = "Total Money"
        '
        'lblTotalCustomers
        '
        Me.lblTotalCustomers.AutoSize = True
        Me.lblTotalCustomers.ForeColor = System.Drawing.Color.Coral
        Me.lblTotalCustomers.Location = New System.Drawing.Point(264, 203)
        Me.lblTotalCustomers.Name = "lblTotalCustomers"
        Me.lblTotalCustomers.Size = New System.Drawing.Size(105, 16)
        Me.lblTotalCustomers.TabIndex = 5
        Me.lblTotalCustomers.Text = "Total Customers"
        '
        'btnExit
        '
        Me.btnExit.ForeColor = System.Drawing.Color.Red
        Me.btnExit.Location = New System.Drawing.Point(146, 396)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'frmReports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblTotalCustomers)
        Me.Controls.Add(Me.lblTotalMoney)
        Me.Controls.Add(Me.dgvReports)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnLoadTransactions)
        Me.Controls.Add(Me.btnLoadCustomer)
        Me.Name = "frmReports"
        Me.Text = "frmReports"
        CType(Me.dgvReports, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnLoadCustomer As Button
    Friend WithEvents btnLoadTransactions As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents dgvReports As DataGridView
    Friend WithEvents lblTotalMoney As Label
    Friend WithEvents lblTotalCustomers As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
End Class
