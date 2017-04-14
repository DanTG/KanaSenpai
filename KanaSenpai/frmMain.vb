Public Class frmMain


    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmSettings.btnReview.Enabled = False
        frmSettings.ShowDialog()
        lblChar.Parent = flpCharOutput
    End Sub


    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles tbInput.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            checkAns(tbInput.Text.ToUpper)
            modMain.update()
        End If
    End Sub




End Class
