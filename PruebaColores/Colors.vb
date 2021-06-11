Public Class frm_Colors

    Dim rnd As New Random
    Dim color As String
    Dim colorsList As New ArrayList
    Dim tamano As Integer
    Dim puntos As Integer = 0
    Dim intent As Integer = 5
    Dim selectedIndex As Integer

    Private Sub Frm_Colors_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        colorsList.Add("Verde")
        colorsList.Add("Amarillo")
        colorsList.Add("Negro")
        colorsList.Add("Rojo")
        colorsList.Add("Azul")

        tamano = colorsList.Count

        selectedIndex = rnd.Next(0, tamano)

        lbl_Color.Text = colorsList(selectedIndex)

        lbl_Puntos.Text = Convert.ToString(puntos)

    End Sub

    Private Sub Btn_GoMain_Click(sender As Object, e As EventArgs)
        frm_Main.Show()
        Me.Close()
    End Sub

    Private Sub Cmb_Menu_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Menu.SelectedIndexChanged
        Select Case cmb_Menu.SelectedIndex
            Case 0
                Close()
            Case 1
                Dim formsForm As New frm_Forms
                Close()
                formsForm.Show()
            Case 2
                Dim colorsformsForm As New frm_FormasC
                Close()
                colorsformsForm.Show()
        End Select
    End Sub

    Private Sub Btn_Rojo_Click(sender As Object, e As EventArgs) Handles btn_Rojo.Click
        tamano = colorsList.Count

        If lbl_Color.Text = "Rojo" Then
            EliminarColor(selectedIndex)
            AumentarPuntaje()
            btn_Rojo.Enabled = False
        Else
            selectedIndex = rnd.Next(0, tamano)
            color = colorsList(selectedIndex)
            lbl_Color.Text = color
        End If

        IntentosPasados()
    End Sub


    Private Sub Btn_Amarillo_Click(sender As Object, e As EventArgs) Handles btn_Amarillo.Click
        tamano = colorsList.Count

        If lbl_Color.Text = "Amarillo" Then
            EliminarColor(selectedIndex)
            AumentarPuntaje()
            btn_Amarillo.Enabled = False
        Else
            selectedIndex = rnd.Next(0, tamano)
            color = colorsList(selectedIndex)
            lbl_Color.Text = color
        End If

        IntentosPasados()
    End Sub

    Private Sub Btn_Negro_Click(sender As Object, e As EventArgs) Handles btn_Negro.Click
        tamano = colorsList.Count

        If lbl_Color.Text = "Negro" Then
            EliminarColor(selectedIndex)
            AumentarPuntaje()
            btn_Negro.Enabled = False
        Else
            selectedIndex = rnd.Next(0, tamano)
            color = colorsList(selectedIndex)
            lbl_Color.Text = color
        End If

        IntentosPasados()
    End Sub

    Private Sub Btn_Azul_Click(sender As Object, e As EventArgs) Handles btn_Azul.Click
        tamano = colorsList.Count

        If lbl_Color.Text = "Azul" Then
            EliminarColor(selectedIndex)
            AumentarPuntaje()
            btn_Azul.Enabled = False
        Else
            selectedIndex = rnd.Next(0, tamano)
            color = colorsList(selectedIndex)
            lbl_Color.Text = color
        End If

        IntentosPasados()
    End Sub

    Private Sub Btn_Verde_Click(sender As Object, e As EventArgs) Handles btn_Verde.Click
        tamano = colorsList.Count

        If lbl_Color.Text = "Verde" Then
            EliminarColor(selectedIndex)
            AumentarPuntaje()
            btn_Verde.Enabled = False
        Else
            selectedIndex = rnd.Next(0, tamano)
            color = colorsList(selectedIndex)
            lbl_Color.Text = color
        End If

        IntentosPasados()
    End Sub

    Private Sub AumentarPuntaje()
        puntos += 1
        lbl_Puntos.Text = Convert.ToString(puntos)
    End Sub

    Private Sub EliminarColor(ByVal index As Integer)
        colorsList.RemoveAt(index)
        tamano = colorsList.Count
        selectedIndex = rnd.Next(0, tamano)
        If tamano > 0 Then
            color = colorsList(selectedIndex)
            lbl_Color.Text = color
        End If


    End Sub

    Private Sub IntentosPasados()
        intent = intent - 1
        If intent = 0 Then
            lbl_Color.Text = "Prueba terminada"
            btn_Amarillo.Enabled = False
            btn_Azul.Enabled = False
            btn_Rojo.Enabled = False
            btn_Negro.Enabled = False
            btn_Verde.Enabled = False
        End If


    End Sub

End Class