Public Class frm_Forms

    Dim rnd As New Random
    Dim forma As String
    Dim formsList As New ArrayList
    Dim tamano As Integer
    Dim puntos As Integer = 0
    Dim intent As Integer = 5
    Dim selectedIndex As Integer

    Private Sub Frm_Forms_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        formsList.Add("Circulo")
        formsList.Add("Cuadrado")
        formsList.Add("Rectangulo")
        formsList.Add("Estrella")
        formsList.Add("Triangulo")

        tamano = formsList.Count

        selectedIndex = rnd.Next(0, tamano)

        lbl_Forma.Text = formsList(selectedIndex)

        lbl_Puntos.Text = Convert.ToString(puntos)
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
                Dim colorsformsForm As New frm_FormasC
                Close()
                colorsformsForm.Show()
        End Select
    End Sub

    Private Sub Btn_Cuadrado_Click(sender As Object, e As EventArgs) Handles btn_Cuadrado.Click
        tamano = formsList.Count

        If lbl_Forma.Text = "Cuadrado" Then
            EliminarForma(selectedIndex)
            AumentarPuntaje()
            btn_Cuadrado.Enabled = False
        Else
            selectedIndex = rnd.Next(0, tamano)
            forma = formsList(selectedIndex)
            lbl_Forma.Text = forma
        End If

        IntentosPasados()
    End Sub

    Private Sub Btn_Triangulo_Click(sender As Object, e As EventArgs) Handles btn_Triangulo.Click
        tamano = formsList.Count

        If lbl_Forma.Text = "Triangulo" Then
            EliminarForma(selectedIndex)
            AumentarPuntaje()
            btn_Cuadrado.Enabled = False
        Else
            selectedIndex = rnd.Next(0, tamano)
            forma = formsList(selectedIndex)
            lbl_Forma.Text = forma
        End If

        IntentosPasados()
    End Sub

    Private Sub Btn_Rectangulo_Click(sender As Object, e As EventArgs) Handles btn_Rectangulo.Click
        tamano = formsList.Count

        If lbl_Forma.Text = "Rectangulo" Then
            EliminarForma(selectedIndex)
            AumentarPuntaje()
            btn_Cuadrado.Enabled = False
        Else
            selectedIndex = rnd.Next(0, tamano)
            forma = formsList(selectedIndex)
            lbl_Forma.Text = forma
        End If

        IntentosPasados()
    End Sub

    Private Sub Btn_Estrella_Click(sender As Object, e As EventArgs) Handles btn_Estrella.Click
        tamano = formsList.Count

        If lbl_Forma.Text = "Estrella" Then
            EliminarForma(selectedIndex)
            AumentarPuntaje()
            btn_Cuadrado.Enabled = False
        Else
            selectedIndex = rnd.Next(0, tamano)
            forma = formsList(selectedIndex)
            lbl_Forma.Text = forma
        End If

        IntentosPasados()
    End Sub

    Private Sub Btn_Circulo_Click(sender As Object, e As EventArgs) Handles btn_Circulo.Click
        tamano = formsList.Count

        If lbl_Forma.Text = "Circulo" Then
            EliminarForma(selectedIndex)
            AumentarPuntaje()
            btn_Cuadrado.Enabled = False
        Else
            selectedIndex = rnd.Next(0, tamano)
            forma = formsList(selectedIndex)
            lbl_Forma.Text = forma
        End If

        IntentosPasados()
    End Sub

    Private Sub AumentarPuntaje()
        puntos += 1
        lbl_Puntos.Text = Convert.ToString(puntos)
    End Sub

    Private Sub EliminarForma(ByVal index As Integer)
        formsList.RemoveAt(index)
        tamano = formsList.Count
        selectedIndex = rnd.Next(0, tamano)
        If tamano > 0 Then
            forma = formsList(selectedIndex)
            lbl_Forma.Text = forma
        End If
    End Sub

    Private Sub IntentosPasados()
        intent = intent - 1
        If intent = 0 Then
            lbl_Forma.Text = "Prueba terminada"
            btn_Cuadrado.Enabled = False
            btn_Triangulo.Enabled = False
            btn_Circulo.Enabled = False
            btn_Rectangulo.Enabled = False
            btn_Estrella.Enabled = False
        End If
    End Sub
End Class