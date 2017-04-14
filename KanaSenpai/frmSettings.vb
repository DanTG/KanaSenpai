Imports System.Threading

Public Class frmSettings

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click

        Try
            Hide()
            count = 0
            getSettings(cbCardType.SelectedIndex, CInt(cbMaxCorrect.Text), CInt(cbMaxWrong.Text))
            createCards()
            btnReview.Enabled = True
            modMain.update()
        Catch
            Hide()
            lblSettingsTitle.Font = New Font("Yu Gothic", 14, FontStyle.Italic)
            lblSettingsTitle.Text = "Please Select Game Settings."
            Show()
        End Try

    End Sub


    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Hide()
        frmMain.Close()
    End Sub


    Private Sub btnReview_Click(sender As Object, e As EventArgs) Handles btnReview.Click

        reviewStatus = True
        count = 0
        Hide()
        createCards()
        modMain.update()

    End Sub

End Class