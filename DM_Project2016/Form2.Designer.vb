<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWelcome
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWelcome))
        Me.btnNext = New System.Windows.Forms.Button()
        Me.pctWelcomePic = New System.Windows.Forms.PictureBox()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.lblOnlyTheBest = New System.Windows.Forms.Label()
        CType(Me.pctWelcomePic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnNext
        '
        Me.btnNext.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.Location = New System.Drawing.Point(73, 263)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(324, 84)
        Me.btnNext.TabIndex = 11
        Me.btnNext.Text = "Next ->"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'pctWelcomePic
        '
        Me.pctWelcomePic.Image = CType(resources.GetObject("pctWelcomePic.Image"), System.Drawing.Image)
        Me.pctWelcomePic.Location = New System.Drawing.Point(236, 83)
        Me.pctWelcomePic.Name = "pctWelcomePic"
        Me.pctWelcomePic.Size = New System.Drawing.Size(161, 135)
        Me.pctWelcomePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctWelcomePic.TabIndex = 10
        Me.pctWelcomePic.TabStop = False
        '
        'lblWelcome
        '
        Me.lblWelcome.Font = New System.Drawing.Font("Courier New", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.ForeColor = System.Drawing.SystemColors.Control
        Me.lblWelcome.Location = New System.Drawing.Point(69, 121)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(130, 63)
        Me.lblWelcome.TabIndex = 9
        Me.lblWelcome.Text = "Welcome Yvonne:"
        '
        'lblOnlyTheBest
        '
        Me.lblOnlyTheBest.AutoSize = True
        Me.lblOnlyTheBest.Font = New System.Drawing.Font("Segoe Script", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOnlyTheBest.ForeColor = System.Drawing.SystemColors.Control
        Me.lblOnlyTheBest.Location = New System.Drawing.Point(76, 30)
        Me.lblOnlyTheBest.Name = "lblOnlyTheBest"
        Me.lblOnlyTheBest.Size = New System.Drawing.Size(321, 53)
        Me.lblOnlyTheBest.TabIndex = 15
        Me.lblOnlyTheBest.Text = "OnlyTheBest.Com"
        '
        'frmWelcome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(484, 461)
        Me.Controls.Add(Me.lblOnlyTheBest)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.pctWelcomePic)
        Me.Controls.Add(Me.lblWelcome)
        Me.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Name = "frmWelcome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmWelcome"
        CType(Me.pctWelcomePic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnNext As Button
    Friend WithEvents pctWelcomePic As PictureBox
    Friend WithEvents lblWelcome As Label
    Friend WithEvents lblOnlyTheBest As Label
End Class
