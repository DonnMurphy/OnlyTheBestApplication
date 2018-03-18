<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInvoice
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInvoice))
        Me.lstInvoice = New System.Windows.Forms.ListBox()
        Me.lblOnlyTheBest = New System.Windows.Forms.Label()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintDialog2 = New System.Windows.Forms.PrintDialog()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument2 = New System.Drawing.Printing.PrintDocument()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.pgrTransactionProgress = New System.Windows.Forms.ProgressBar()
        Me.SuspendLayout()
        '
        'lstInvoice
        '
        Me.lstInvoice.Font = New System.Drawing.Font("Courier New", 9.75!)
        Me.lstInvoice.FormattingEnabled = True
        Me.lstInvoice.ItemHeight = 16
        Me.lstInvoice.Location = New System.Drawing.Point(88, 97)
        Me.lstInvoice.Name = "lstInvoice"
        Me.lstInvoice.Size = New System.Drawing.Size(300, 244)
        Me.lstInvoice.TabIndex = 0
        '
        'lblOnlyTheBest
        '
        Me.lblOnlyTheBest.AutoSize = True
        Me.lblOnlyTheBest.Font = New System.Drawing.Font("Segoe Script", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOnlyTheBest.ForeColor = System.Drawing.SystemColors.Control
        Me.lblOnlyTheBest.Location = New System.Drawing.Point(79, 9)
        Me.lblOnlyTheBest.Name = "lblOnlyTheBest"
        Me.lblOnlyTheBest.Size = New System.Drawing.Size(321, 53)
        Me.lblOnlyTheBest.TabIndex = 9
        Me.lblOnlyTheBest.Text = "OnlyTheBest.Com"
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(88, 347)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(154, 54)
        Me.btnPrint.TabIndex = 11
        Me.btnPrint.Text = "Print Invoice:"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'PrintDialog1
        '
        Me.PrintDialog1.AllowSomePages = True
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintDialog2
        '
        Me.PrintDialog2.UseEXDialog = True
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
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(234, 347)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(154, 54)
        Me.btnNext.TabIndex = 12
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'pgrTransactionProgress
        '
        Me.pgrTransactionProgress.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pgrTransactionProgress.ForeColor = System.Drawing.Color.Coral
        Me.pgrTransactionProgress.Location = New System.Drawing.Point(88, 56)
        Me.pgrTransactionProgress.Name = "pgrTransactionProgress"
        Me.pgrTransactionProgress.Size = New System.Drawing.Size(312, 23)
        Me.pgrTransactionProgress.TabIndex = 13
        Me.pgrTransactionProgress.Value = 85
        '
        'frmInvoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(484, 461)
        Me.Controls.Add(Me.pgrTransactionProgress)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.lblOnlyTheBest)
        Me.Controls.Add(Me.lstInvoice)
        Me.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Name = "frmInvoice"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmInvoice"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstInvoice As System.Windows.Forms.ListBox
    Friend WithEvents lblOnlyTheBest As System.Windows.Forms.Label
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Public WithEvents prtInvoices As Printing.PrintDocument
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PrintDialog2 As PrintDialog
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDocument2 As Printing.PrintDocument
    Friend WithEvents btnNext As Button
    Friend WithEvents pgrTransactionProgress As ProgressBar
End Class
