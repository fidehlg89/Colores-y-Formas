Public Class frm_Main

    Private Sub Btn_Colors_Click(sender As Object, e As EventArgs) Handles btn_Colors.Click
        Dim colorsForm As New frm_Colors
        colorsForm.Show()
    End Sub

    Private Sub Btn_Forms_Click(sender As Object, e As EventArgs) Handles btn_Forms.Click
        Dim formsForm As New frm_Forms
        formsForm.Show()
    End Sub

    Private Sub Btn_Both_Click(sender As Object, e As EventArgs) Handles btn_Both.Click
        Dim colorsformsForm As New frm_Both
        colorsformsForm.Show()
    End Sub
End Class
