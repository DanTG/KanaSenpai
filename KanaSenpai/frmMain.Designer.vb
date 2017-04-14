<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.lblLast = New System.Windows.Forms.Label()
        Me.tbInput = New System.Windows.Forms.TextBox()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.lblWrong = New System.Windows.Forms.Label()
        Me.flpWrongHist = New System.Windows.Forms.FlowLayoutPanel()
        Me.lblChar = New System.Windows.Forms.Label()
        Me.flpCharOutput = New System.Windows.Forms.FlowLayoutPanel()
        Me.flpCharOutput.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblLast
        '
        Me.lblLast.AutoSize = True
        Me.lblLast.BackColor = System.Drawing.Color.Transparent
        Me.lblLast.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLast.Location = New System.Drawing.Point(12, 71)
        Me.lblLast.Name = "lblLast"
        Me.lblLast.Size = New System.Drawing.Size(55, 20)
        Me.lblLast.TabIndex = 3
        Me.lblLast.Text = "lblLast"
        Me.lblLast.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbInput
        '
        Me.tbInput.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbInput.Location = New System.Drawing.Point(12, 445)
        Me.tbInput.Name = "tbInput"
        Me.tbInput.Size = New System.Drawing.Size(304, 30)
        Me.tbInput.TabIndex = 4
        Me.tbInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.BackColor = System.Drawing.Color.Transparent
        Me.lblScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.Location = New System.Drawing.Point(12, 9)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(66, 20)
        Me.lblScore.TabIndex = 5
        Me.lblScore.Text = "lblScore"
        Me.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblWrong
        '
        Me.lblWrong.AutoSize = True
        Me.lblWrong.BackColor = System.Drawing.Color.Transparent
        Me.lblWrong.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWrong.Location = New System.Drawing.Point(12, 38)
        Me.lblWrong.Name = "lblWrong"
        Me.lblWrong.Size = New System.Drawing.Size(71, 20)
        Me.lblWrong.TabIndex = 6
        Me.lblWrong.Text = "lblWrong"
        Me.lblWrong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'flpWrongHist
        '
        Me.flpWrongHist.BackColor = System.Drawing.Color.Transparent
        Me.flpWrongHist.Location = New System.Drawing.Point(12, 481)
        Me.flpWrongHist.Name = "flpWrongHist"
        Me.flpWrongHist.Size = New System.Drawing.Size(303, 96)
        Me.flpWrongHist.TabIndex = 7
        '
        'lblChar
        '
        Me.lblChar.AutoSize = True
        Me.lblChar.BackColor = System.Drawing.Color.Transparent
        Me.lblChar.Font = New System.Drawing.Font("Tahoma", 200.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChar.Location = New System.Drawing.Point(3, 0)
        Me.lblChar.Name = "lblChar"
        Me.lblChar.Size = New System.Drawing.Size(268, 322)
        Me.lblChar.TabIndex = 8
        Me.lblChar.Text = "L"
        '
        'flpCharOutput
        '
        Me.flpCharOutput.BackColor = System.Drawing.Color.Transparent
        Me.flpCharOutput.Controls.Add(Me.lblChar)
        Me.flpCharOutput.Location = New System.Drawing.Point(12, 99)
        Me.flpCharOutput.Name = "flpCharOutput"
        Me.flpCharOutput.Size = New System.Drawing.Size(303, 334)
        Me.flpCharOutput.TabIndex = 8
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(328, 588)
        Me.Controls.Add(Me.flpCharOutput)
        Me.Controls.Add(Me.flpWrongHist)
        Me.Controls.Add(Me.lblWrong)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.tbInput)
        Me.Controls.Add(Me.lblLast)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "KanaSenpai"
        Me.flpCharOutput.ResumeLayout(False)
        Me.flpCharOutput.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblLast As System.Windows.Forms.Label
    Friend WithEvents tbInput As System.Windows.Forms.TextBox
    Friend WithEvents lblScore As System.Windows.Forms.Label
    Friend WithEvents lblWrong As System.Windows.Forms.Label
    Friend WithEvents flpWrongHist As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents lblChar As System.Windows.Forms.Label
    Friend WithEvents flpCharOutput As System.Windows.Forms.FlowLayoutPanel

End Class
