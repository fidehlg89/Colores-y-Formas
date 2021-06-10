Public Class frm_Both

    Dim colorArray(0 To 4) As String
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

    End Sub

    Private Sub Frm_Both_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Cmb_Menu_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Menu.SelectedIndexChanged
        Select Case cmb_Menu.SelectedIndex
            Case 0
                Close()
            Case 1
                Dim formsColors As New frm_Colors
                Close()
                formsColors.Show()
            Case 2
                Dim formsForm As New frm_Forms
                Close()
                formsForm.Show()
        End Select
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Lbl_Counter_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Lbl_Puntos_Click(sender As Object, e As EventArgs) Handles lbl_Puntos.Click

    End Sub
End Class