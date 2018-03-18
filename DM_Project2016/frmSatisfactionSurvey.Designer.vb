<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSatisfactionSurvey
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
        Me.components = New System.ComponentModel.Container()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblOnlyTheBest = New System.Windows.Forms.Label()
        Me.lblTimer = New System.Windows.Forms.Label()
        Me.lblErrorCounter = New System.Windows.Forms.Label()
        Me.lblErrors = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.mtbCustomerRating = New System.Windows.Forms.MaskedTextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblCHanges = New System.Windows.Forms.Label()
        Me.rchChanges = New System.Windows.Forms.RichTextBox()
        Me.btnLogOut = New System.Windows.Forms.Button()
        Me.btnNewOrder = New System.Windows.Forms.Button()
        Me.pgrTransactionProgress = New System.Windows.Forms.ProgressBar()
        Me.SuspendLayout()
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.SystemColors.Control
        Me.lblTime.Location = New System.Drawing.Point(15, 114)
        Me.lblTime.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(328, 18)
        Me.lblTime.TabIndex = 13
        Me.lblTime.Text = "Time taken for this transaction:"
        '
        'lblOnlyTheBest
        '
        Me.lblOnlyTheBest.AutoSize = True
        Me.lblOnlyTheBest.Font = New System.Drawing.Font("Segoe Script", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOnlyTheBest.ForeColor = System.Drawing.SystemColors.Control
        Me.lblOnlyTheBest.Location = New System.Drawing.Point(74, 9)
        Me.lblOnlyTheBest.Name = "lblOnlyTheBest"
        Me.lblOnlyTheBest.Size = New System.Drawing.Size(321, 53)
        Me.lblOnlyTheBest.TabIndex = 14
        Me.lblOnlyTheBest.Text = "OnlyTheBest.Com"
        '
        'lblTimer
        '
        Me.lblTimer.AutoSize = True
        Me.lblTimer.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimer.ForeColor = System.Drawing.SystemColors.Control
        Me.lblTimer.Location = New System.Drawing.Point(355, 114)
        Me.lblTimer.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblTimer.Name = "lblTimer"
        Me.lblTimer.Size = New System.Drawing.Size(18, 18)
        Me.lblTimer.TabIndex = 16
        Me.lblTimer.Text = "r"
        '
        'lblErrorCounter
        '
        Me.lblErrorCounter.AutoSize = True
        Me.lblErrorCounter.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblErrorCounter.ForeColor = System.Drawing.SystemColors.Control
        Me.lblErrorCounter.Location = New System.Drawing.Point(15, 154)
        Me.lblErrorCounter.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblErrorCounter.Name = "lblErrorCounter"
        Me.lblErrorCounter.Size = New System.Drawing.Size(228, 18)
        Me.lblErrorCounter.TabIndex = 17
        Me.lblErrorCounter.Text = "Number Of Errors Made:"
        '
        'lblErrors
        '
        Me.lblErrors.AutoSize = True
        Me.lblErrors.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblErrors.ForeColor = System.Drawing.SystemColors.Control
        Me.lblErrors.Location = New System.Drawing.Point(355, 154)
        Me.lblErrors.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblErrors.Name = "lblErrors"
        Me.lblErrors.Size = New System.Drawing.Size(18, 18)
        Me.lblErrors.TabIndex = 18
        Me.lblErrors.Text = "e"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(15, 204)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(328, 18)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Rate the customers satisfaction:"
        '
        'mtbCustomerRating
        '
        Me.mtbCustomerRating.Location = New System.Drawing.Point(352, 193)
        Me.mtbCustomerRating.Mask = "0"
        Me.mtbCustomerRating.Name = "mtbCustomerRating"
        Me.mtbCustomerRating.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.mtbCustomerRating.ReadOnly = True
        Me.mtbCustomerRating.Size = New System.Drawing.Size(120, 29)
        Me.mtbCustomerRating.TabIndex = 20
        '
        'lblCHanges
        '
        Me.lblCHanges.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCHanges.ForeColor = System.Drawing.SystemColors.Control
        Me.lblCHanges.Location = New System.Drawing.Point(15, 240)
        Me.lblCHanges.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblCHanges.Name = "lblCHanges"
        Me.lblCHanges.Size = New System.Drawing.Size(328, 37)
        Me.lblCHanges.TabIndex = 21
        Me.lblCHanges.Text = "What changes could be made to improve the service?"
        '
        'rchChanges
        '
        Me.rchChanges.Location = New System.Drawing.Point(18, 298)
        Me.rchChanges.Name = "rchChanges"
        Me.rchChanges.Size = New System.Drawing.Size(454, 77)
        Me.rchChanges.TabIndex = 22
        Me.rchChanges.Text = ""
        '
        'btnLogOut
        '
        Me.btnLogOut.BackColor = System.Drawing.Color.White
        Me.btnLogOut.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogOut.Location = New System.Drawing.Point(300, 381)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(172, 68)
        Me.btnLogOut.TabIndex = 25
        Me.btnLogOut.Text = "LogOut:"
        Me.btnLogOut.UseVisualStyleBackColor = False
        '
        'btnNewOrder
        '
        Me.btnNewOrder.BackColor = System.Drawing.Color.White
        Me.btnNewOrder.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewOrder.Location = New System.Drawing.Point(18, 381)
        Me.btnNewOrder.Name = "btnNewOrder"
        Me.btnNewOrder.Size = New System.Drawing.Size(172, 68)
        Me.btnNewOrder.TabIndex = 26
        Me.btnNewOrder.Text = "New Order:"
        Me.btnNewOrder.UseVisualStyleBackColor = False
        '
        'pgrTransactionProgress
        '
        Me.pgrTransactionProgress.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pgrTransactionProgress.ForeColor = System.Drawing.Color.Coral
        Me.pgrTransactionProgress.Location = New System.Drawing.Point(83, 65)
        Me.pgrTransactionProgress.Name = "pgrTransactionProgress"
        Me.pgrTransactionProgress.Size = New System.Drawing.Size(312, 23)
        Me.pgrTransactionProgress.TabIndex = 27
        Me.pgrTransactionProgress.Value = 100
        '
        'frmSatisfactionSurvey
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(484, 461)
        Me.Controls.Add(Me.pgrTransactionProgress)
        Me.Controls.Add(Me.btnNewOrder)
        Me.Controls.Add(Me.btnLogOut)
        Me.Controls.Add(Me.rchChanges)
        Me.Controls.Add(Me.lblCHanges)
        Me.Controls.Add(Me.mtbCustomerRating)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblErrors)
        Me.Controls.Add(Me.lblErrorCounter)
        Me.Controls.Add(Me.lblTimer)
        Me.Controls.Add(Me.lblOnlyTheBest)
        Me.Controls.Add(Me.lblTime)
        Me.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Name = "frmSatisfactionSurvey"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmSatisfactionSurvey"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTime As Label
    Friend WithEvents lblOnlyTheBest As Label
    Friend WithEvents lblTimer As Label
    Friend WithEvents lblErrorCounter As Label
    Friend WithEvents lblErrors As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents mtbCustomerRating As MaskedTextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblCHanges As Label
    Friend WithEvents rchChanges As RichTextBox
    Friend WithEvents btnLogOut As Button
    Friend WithEvents btnNewOrder As Button
    Friend WithEvents pgrTransactionProgress As ProgressBar
End Class
