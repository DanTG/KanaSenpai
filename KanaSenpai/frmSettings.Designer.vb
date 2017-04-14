<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettings
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
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnReview = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.flpSettings = New System.Windows.Forms.FlowLayoutPanel()
        Me.cbCardType = New System.Windows.Forms.ComboBox()
        Me.cbMaxCorrect = New System.Windows.Forms.ComboBox()
        Me.cbMaxWrong = New System.Windows.Forms.ComboBox()
        Me.lblSettingsTitle = New System.Windows.Forms.Label()
        Me.flpSettings.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnStart
        '
        Me.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStart.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.Location = New System.Drawing.Point(108, 131)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(85, 30)
        Me.btnStart.TabIndex = 0
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnReview
        '
        Me.btnReview.BackColor = System.Drawing.Color.Transparent
        Me.btnReview.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReview.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReview.Location = New System.Drawing.Point(12, 131)
        Me.btnReview.Name = "btnReview"
        Me.btnReview.Size = New System.Drawing.Size(85, 30)
        Me.btnReview.TabIndex = 1
        Me.btnReview.Text = "Review"
        Me.btnReview.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(203, 131)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(85, 30)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'flpSettings
        '
        Me.flpSettings.Controls.Add(Me.cbCardType)
        Me.flpSettings.Controls.Add(Me.cbMaxCorrect)
        Me.flpSettings.Controls.Add(Me.cbMaxWrong)
        Me.flpSettings.Location = New System.Drawing.Point(12, 68)
        Me.flpSettings.Name = "flpSettings"
        Me.flpSettings.Size = New System.Drawing.Size(276, 57)
        Me.flpSettings.TabIndex = 3
        '
        'cbCardType
        '
        Me.cbCardType.FormattingEnabled = True
        Me.cbCardType.Items.AddRange(New Object() {"Basic Hirigana", "Hirigana Variations", "All Hirigana", "Basic Katakana", "Katakana Variations", "All Katakana"})
        Me.cbCardType.Location = New System.Drawing.Point(3, 3)
        Me.cbCardType.Name = "cbCardType"
        Me.cbCardType.Size = New System.Drawing.Size(265, 21)
        Me.cbCardType.TabIndex = 0
        Me.cbCardType.Text = "Flash Card Type"
        '
        'cbMaxCorrect
        '
        Me.cbMaxCorrect.FormattingEnabled = True
        Me.cbMaxCorrect.Items.AddRange(New Object() {"10", "20", "50", "100"})
        Me.cbMaxCorrect.Location = New System.Drawing.Point(3, 30)
        Me.cbMaxCorrect.Name = "cbMaxCorrect"
        Me.cbMaxCorrect.Size = New System.Drawing.Size(129, 21)
        Me.cbMaxCorrect.TabIndex = 2
        Me.cbMaxCorrect.Text = "Number to Win"
        '
        'cbMaxWrong
        '
        Me.cbMaxWrong.FormattingEnabled = True
        Me.cbMaxWrong.Items.AddRange(New Object() {"5", "10", "20"})
        Me.cbMaxWrong.Location = New System.Drawing.Point(138, 30)
        Me.cbMaxWrong.Name = "cbMaxWrong"
        Me.cbMaxWrong.Size = New System.Drawing.Size(129, 21)
        Me.cbMaxWrong.TabIndex = 1
        Me.cbMaxWrong.Text = "Maximum Wrong"
        '
        'lblSettingsTitle
        '
        Me.lblSettingsTitle.AutoSize = True
        Me.lblSettingsTitle.Font = New System.Drawing.Font("Yu Gothic", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSettingsTitle.ForeColor = System.Drawing.Color.DimGray
        Me.lblSettingsTitle.Location = New System.Drawing.Point(6, 19)
        Me.lblSettingsTitle.Name = "lblSettingsTitle"
        Me.lblSettingsTitle.Size = New System.Drawing.Size(119, 35)
        Me.lblSettingsTitle.TabIndex = 4
        Me.lblSettingsTitle.Text = "Settings"
        '
        'frmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(301, 177)
        Me.Controls.Add(Me.lblSettingsTitle)
        Me.Controls.Add(Me.flpSettings)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnReview)
        Me.Controls.Add(Me.btnStart)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmSettings"
        Me.flpSettings.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents btnReview As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents flpSettings As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents cbCardType As System.Windows.Forms.ComboBox
    Friend WithEvents cbMaxCorrect As System.Windows.Forms.ComboBox
    Friend WithEvents cbMaxWrong As System.Windows.Forms.ComboBox
    Friend WithEvents lblSettingsTitle As System.Windows.Forms.Label
End Class
