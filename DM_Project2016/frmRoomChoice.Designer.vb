<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRoomChoice
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
        Me.grpLocation = New System.Windows.Forms.GroupBox()
        Me.rdoDublin = New System.Windows.Forms.RadioButton()
        Me.rdoLimerick = New System.Windows.Forms.RadioButton()
        Me.rdoKerry = New System.Windows.Forms.RadioButton()
        Me.rdoCork = New System.Windows.Forms.RadioButton()
        Me.grpHotelChoice = New System.Windows.Forms.GroupBox()
        Me.cmbHotelChoice = New System.Windows.Forms.ComboBox()
        Me.grpDates = New System.Windows.Forms.GroupBox()
        Me.dtpCheckOut = New System.Windows.Forms.DateTimePicker()
        Me.dtpCheckIn = New System.Windows.Forms.DateTimePicker()
        Me.lblCheckOut = New System.Windows.Forms.Label()
        Me.lblCheckIn = New System.Windows.Forms.Label()
        Me.rpSubTotal = New System.Windows.Forms.GroupBox()
        Me.lstSubtotal = New System.Windows.Forms.ListBox()
        Me.lblOnlyTheBest = New System.Windows.Forms.Label()
        Me.grpRoomChoice = New System.Windows.Forms.GroupBox()
        Me.rdoRoomTwin = New System.Windows.Forms.RadioButton()
        Me.rdoRoomSingle = New System.Windows.Forms.RadioButton()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.pgrTransactionProgress = New System.Windows.Forms.ProgressBar()
        Me.grpLocation.SuspendLayout()
        Me.grpHotelChoice.SuspendLayout()
        Me.grpDates.SuspendLayout()
        Me.rpSubTotal.SuspendLayout()
        Me.grpRoomChoice.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpLocation
        '
        Me.grpLocation.Controls.Add(Me.rdoDublin)
        Me.grpLocation.Controls.Add(Me.rdoLimerick)
        Me.grpLocation.Controls.Add(Me.rdoKerry)
        Me.grpLocation.Controls.Add(Me.rdoCork)
        Me.grpLocation.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpLocation.ForeColor = System.Drawing.SystemColors.Control
        Me.grpLocation.Location = New System.Drawing.Point(12, 82)
        Me.grpLocation.Name = "grpLocation"
        Me.grpLocation.Size = New System.Drawing.Size(227, 64)
        Me.grpLocation.TabIndex = 0
        Me.grpLocation.TabStop = False
        Me.grpLocation.Text = "Location:"
        '
        'rdoDublin
        '
        Me.rdoDublin.AutoSize = True
        Me.rdoDublin.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoDublin.Location = New System.Drawing.Point(6, 39)
        Me.rdoDublin.Name = "rdoDublin"
        Me.rdoDublin.Size = New System.Drawing.Size(74, 20)
        Me.rdoDublin.TabIndex = 3
        Me.rdoDublin.TabStop = True
        Me.rdoDublin.Text = "Dublin"
        Me.rdoDublin.UseVisualStyleBackColor = True
        '
        'rdoLimerick
        '
        Me.rdoLimerick.AutoSize = True
        Me.rdoLimerick.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoLimerick.Location = New System.Drawing.Point(80, 39)
        Me.rdoLimerick.Name = "rdoLimerick"
        Me.rdoLimerick.Size = New System.Drawing.Size(90, 20)
        Me.rdoLimerick.TabIndex = 2
        Me.rdoLimerick.TabStop = True
        Me.rdoLimerick.Text = "Limerick"
        Me.rdoLimerick.UseVisualStyleBackColor = True
        '
        'rdoKerry
        '
        Me.rdoKerry.AutoSize = True
        Me.rdoKerry.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoKerry.Location = New System.Drawing.Point(80, 13)
        Me.rdoKerry.Name = "rdoKerry"
        Me.rdoKerry.Size = New System.Drawing.Size(66, 20)
        Me.rdoKerry.TabIndex = 1
        Me.rdoKerry.TabStop = True
        Me.rdoKerry.Text = "Kerry"
        Me.rdoKerry.UseVisualStyleBackColor = True
        '
        'rdoCork
        '
        Me.rdoCork.AutoSize = True
        Me.rdoCork.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoCork.Location = New System.Drawing.Point(6, 13)
        Me.rdoCork.Name = "rdoCork"
        Me.rdoCork.Size = New System.Drawing.Size(58, 20)
        Me.rdoCork.TabIndex = 0
        Me.rdoCork.TabStop = True
        Me.rdoCork.Text = "Cork"
        Me.rdoCork.UseVisualStyleBackColor = True
        '
        'grpHotelChoice
        '
        Me.grpHotelChoice.Controls.Add(Me.cmbHotelChoice)
        Me.grpHotelChoice.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpHotelChoice.ForeColor = System.Drawing.SystemColors.Control
        Me.grpHotelChoice.Location = New System.Drawing.Point(12, 152)
        Me.grpHotelChoice.Name = "grpHotelChoice"
        Me.grpHotelChoice.Size = New System.Drawing.Size(227, 70)
        Me.grpHotelChoice.TabIndex = 1
        Me.grpHotelChoice.TabStop = False
        Me.grpHotelChoice.Text = "Hotel Choice:"
        '
        'cmbHotelChoice
        '
        Me.cmbHotelChoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbHotelChoice.FormattingEnabled = True
        Me.cmbHotelChoice.Location = New System.Drawing.Point(6, 25)
        Me.cmbHotelChoice.Name = "cmbHotelChoice"
        Me.cmbHotelChoice.Size = New System.Drawing.Size(215, 26)
        Me.cmbHotelChoice.TabIndex = 5
        '
        'grpDates
        '
        Me.grpDates.Controls.Add(Me.dtpCheckOut)
        Me.grpDates.Controls.Add(Me.dtpCheckIn)
        Me.grpDates.Controls.Add(Me.lblCheckOut)
        Me.grpDates.Controls.Add(Me.lblCheckIn)
        Me.grpDates.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDates.ForeColor = System.Drawing.SystemColors.Control
        Me.grpDates.Location = New System.Drawing.Point(12, 229)
        Me.grpDates.Name = "grpDates"
        Me.grpDates.Size = New System.Drawing.Size(227, 123)
        Me.grpDates.TabIndex = 3
        Me.grpDates.TabStop = False
        Me.grpDates.Text = "Dates:"
        '
        'dtpCheckOut
        '
        Me.dtpCheckOut.Font = New System.Drawing.Font("Courier New", 9.75!)
        Me.dtpCheckOut.Location = New System.Drawing.Point(9, 84)
        Me.dtpCheckOut.Name = "dtpCheckOut"
        Me.dtpCheckOut.Size = New System.Drawing.Size(206, 22)
        Me.dtpCheckOut.TabIndex = 3
        '
        'dtpCheckIn
        '
        Me.dtpCheckIn.CalendarFont = New System.Drawing.Font("Courier New", 9.75!)
        Me.dtpCheckIn.Checked = False
        Me.dtpCheckIn.Font = New System.Drawing.Font("Courier New", 9.75!)
        Me.dtpCheckIn.Location = New System.Drawing.Point(9, 40)
        Me.dtpCheckIn.Name = "dtpCheckIn"
        Me.dtpCheckIn.Size = New System.Drawing.Size(206, 22)
        Me.dtpCheckIn.TabIndex = 2
        '
        'lblCheckOut
        '
        Me.lblCheckOut.AutoSize = True
        Me.lblCheckOut.Font = New System.Drawing.Font("Courier New", 9.75!)
        Me.lblCheckOut.Location = New System.Drawing.Point(6, 65)
        Me.lblCheckOut.Name = "lblCheckOut"
        Me.lblCheckOut.Size = New System.Drawing.Size(88, 16)
        Me.lblCheckOut.TabIndex = 1
        Me.lblCheckOut.Text = "Check Out:"
        '
        'lblCheckIn
        '
        Me.lblCheckIn.AutoSize = True
        Me.lblCheckIn.Font = New System.Drawing.Font("Courier New", 9.75!)
        Me.lblCheckIn.Location = New System.Drawing.Point(3, 21)
        Me.lblCheckIn.Name = "lblCheckIn"
        Me.lblCheckIn.Size = New System.Drawing.Size(80, 16)
        Me.lblCheckIn.TabIndex = 0
        Me.lblCheckIn.Text = "Check In:"
        '
        'rpSubTotal
        '
        Me.rpSubTotal.Controls.Add(Me.lstSubtotal)
        Me.rpSubTotal.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rpSubTotal.ForeColor = System.Drawing.SystemColors.Control
        Me.rpSubTotal.Location = New System.Drawing.Point(245, 82)
        Me.rpSubTotal.Name = "rpSubTotal"
        Me.rpSubTotal.Size = New System.Drawing.Size(235, 270)
        Me.rpSubTotal.TabIndex = 4
        Me.rpSubTotal.TabStop = False
        Me.rpSubTotal.Text = "SubTotal:"
        '
        'lstSubtotal
        '
        Me.lstSubtotal.Font = New System.Drawing.Font("Courier New", 8.0!)
        Me.lstSubtotal.FormattingEnabled = True
        Me.lstSubtotal.ItemHeight = 14
        Me.lstSubtotal.Location = New System.Drawing.Point(6, 13)
        Me.lstSubtotal.Name = "lstSubtotal"
        Me.lstSubtotal.Size = New System.Drawing.Size(223, 242)
        Me.lstSubtotal.TabIndex = 0
        '
        'lblOnlyTheBest
        '
        Me.lblOnlyTheBest.AutoSize = True
        Me.lblOnlyTheBest.Font = New System.Drawing.Font("Segoe Script", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOnlyTheBest.ForeColor = System.Drawing.SystemColors.Control
        Me.lblOnlyTheBest.Location = New System.Drawing.Point(83, 9)
        Me.lblOnlyTheBest.Name = "lblOnlyTheBest"
        Me.lblOnlyTheBest.Size = New System.Drawing.Size(321, 53)
        Me.lblOnlyTheBest.TabIndex = 6
        Me.lblOnlyTheBest.Text = "OnlyTheBest.Com"
        '
        'grpRoomChoice
        '
        Me.grpRoomChoice.Controls.Add(Me.rdoRoomTwin)
        Me.grpRoomChoice.Controls.Add(Me.rdoRoomSingle)
        Me.grpRoomChoice.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpRoomChoice.ForeColor = System.Drawing.SystemColors.Control
        Me.grpRoomChoice.Location = New System.Drawing.Point(12, 358)
        Me.grpRoomChoice.Name = "grpRoomChoice"
        Me.grpRoomChoice.Size = New System.Drawing.Size(227, 79)
        Me.grpRoomChoice.TabIndex = 8
        Me.grpRoomChoice.TabStop = False
        Me.grpRoomChoice.Text = "Room Choice:"
        '
        'rdoRoomTwin
        '
        Me.rdoRoomTwin.AutoSize = True
        Me.rdoRoomTwin.Font = New System.Drawing.Font("Courier New", 9.75!)
        Me.rdoRoomTwin.Location = New System.Drawing.Point(117, 25)
        Me.rdoRoomTwin.Name = "rdoRoomTwin"
        Me.rdoRoomTwin.Size = New System.Drawing.Size(58, 20)
        Me.rdoRoomTwin.TabIndex = 1
        Me.rdoRoomTwin.TabStop = True
        Me.rdoRoomTwin.Text = "Twin"
        Me.rdoRoomTwin.UseVisualStyleBackColor = True
        '
        'rdoRoomSingle
        '
        Me.rdoRoomSingle.AutoSize = True
        Me.rdoRoomSingle.Font = New System.Drawing.Font("Courier New", 9.75!)
        Me.rdoRoomSingle.Location = New System.Drawing.Point(6, 25)
        Me.rdoRoomSingle.Name = "rdoRoomSingle"
        Me.rdoRoomSingle.Size = New System.Drawing.Size(74, 20)
        Me.rdoRoomSingle.TabIndex = 0
        Me.rdoRoomSingle.TabStop = True
        Me.rdoRoomSingle.Text = "Single"
        Me.rdoRoomSingle.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(245, 358)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(236, 79)
        Me.btnNext.TabIndex = 9
        Me.btnNext.Text = "Next:"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'pgrTransactionProgress
        '
        Me.pgrTransactionProgress.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pgrTransactionProgress.ForeColor = System.Drawing.Color.Coral
        Me.pgrTransactionProgress.Location = New System.Drawing.Point(92, 53)
        Me.pgrTransactionProgress.Name = "pgrTransactionProgress"
        Me.pgrTransactionProgress.Size = New System.Drawing.Size(312, 23)
        Me.pgrTransactionProgress.TabIndex = 10
        Me.pgrTransactionProgress.Value = 43
        '
        'frmRoomChoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(484, 461)
        Me.Controls.Add(Me.pgrTransactionProgress)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.grpRoomChoice)
        Me.Controls.Add(Me.grpDates)
        Me.Controls.Add(Me.lblOnlyTheBest)
        Me.Controls.Add(Me.rpSubTotal)
        Me.Controls.Add(Me.grpHotelChoice)
        Me.Controls.Add(Me.grpLocation)
        Me.Name = "frmRoomChoice"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmRoomChoice"
        Me.grpLocation.ResumeLayout(False)
        Me.grpLocation.PerformLayout()
        Me.grpHotelChoice.ResumeLayout(False)
        Me.grpDates.ResumeLayout(False)
        Me.grpDates.PerformLayout()
        Me.rpSubTotal.ResumeLayout(False)
        Me.grpRoomChoice.ResumeLayout(False)
        Me.grpRoomChoice.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpLocation As System.Windows.Forms.GroupBox
    Friend WithEvents grpHotelChoice As System.Windows.Forms.GroupBox
    Friend WithEvents rdoDublin As System.Windows.Forms.RadioButton
    Friend WithEvents rdoLimerick As System.Windows.Forms.RadioButton
    Friend WithEvents rdoKerry As System.Windows.Forms.RadioButton
    Friend WithEvents rdoCork As System.Windows.Forms.RadioButton
    Friend WithEvents cmbHotelChoice As System.Windows.Forms.ComboBox
    Friend WithEvents grpDates As System.Windows.Forms.GroupBox
    Friend WithEvents lblCheckOut As System.Windows.Forms.Label
    Friend WithEvents lblCheckIn As System.Windows.Forms.Label
    Friend WithEvents rpSubTotal As System.Windows.Forms.GroupBox
    Friend WithEvents lstSubtotal As System.Windows.Forms.ListBox
    Friend WithEvents lblOnlyTheBest As System.Windows.Forms.Label
    Friend WithEvents grpRoomChoice As System.Windows.Forms.GroupBox
    Friend WithEvents rdoRoomTwin As System.Windows.Forms.RadioButton
    Friend WithEvents rdoRoomSingle As System.Windows.Forms.RadioButton
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents dtpCheckOut As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpCheckIn As System.Windows.Forms.DateTimePicker
    Friend WithEvents pgrTransactionProgress As ProgressBar
End Class
