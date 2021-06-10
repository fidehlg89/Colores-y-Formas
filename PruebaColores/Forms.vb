Public Class frm_Forms
    Private Sub Frm_Forms_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Cmb_Menu_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Menu.SelectedIndexChanged
        Select Case cmb_Menu.SelectedIndex
            Case 0
                Close()
            Case 1
                Dim colorsForm As New frm_Colors
                Close()
                colorsForm.Show()
            Case 2
                Dim colorsformsForm As New frm_Both
                Close()
                colorsformsForm.Show()
        End Select
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs)

    End Sub
End Class