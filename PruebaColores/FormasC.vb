Public Class frm_FormasC

    Dim rnd As New Random
    Dim formaC As String
    Dim formsCList As New ArrayList
    Dim tamano As Integer
    Dim puntos As Integer = 0
    Dim intent As Integer = 5
    Dim selectedIndex As Integer

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

    Private Sub Frm_FormasC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        formsCList.Add("Circulo Azul")
        formsCList.Add("Cuadrado Verde")
        formsCList.Add("Rectangulo Negro")
        formsCList.Add("Estrella Roja")
        formsCList.Add("Triangulo Amarillo")

        tamano = formsCList.Count

        selectedIndex = rnd.Next(0, tamano)

        lbl_FormaC.Text = formsCList(selectedIndex)

        lbl_Puntos.Text = Convert.ToString(puntos)
    End Sub

    Private Sub Btn_CuadradoC_Click(sender As Object, e As EventArgs) Handles btn_CuadradoC.Click
        tamano = formsCList.Count

        If lbl_FormaC.Text = "Cuadrado Verde" Then
            EliminarFormaC(selectedIndex)
            AumentarPuntaje()
            btn_CuadradoC.Enabled = False
        Else
            selectedIndex = rnd.Next(0, tamano)
            formaC = formsCList(selectedIndex)
            lbl_FormaC.Text = formaC
        End If

        IntentosPasados()
    End Sub

    Private Sub AumentarPuntaje()
        puntos += 1
        lbl_Puntos.Text = Convert.ToString(puntos)
    End Sub

    Private Sub EliminarFormaC(ByVal index As Integer)
        formsCList.RemoveAt(index)
        tamano = formsCList.Count
        selectedIndex = rnd.Next(0, tamano)
        If tamano > 0 Then
            formaC = formsCList(selectedIndex)
            lbl_FormaC.Text = formaC
        End If


    End Sub

    Private Sub IntentosPasados()
        intent = intent - 1
        If intent = 0 Then
            lbl_FormaC.Text = "Prueba terminada"
            btn_CuadradoC.Enabled = False
            btn_TrianguloC.Enabled = False
            btn_CirculoC.Enabled = False
            btn_RectanguloC.Enabled = False
            btn_EstrellaC.Enabled = False
        End If
    End Sub

    Private Sub Btn_EstrellaC_Click(sender As Object, e As EventArgs) Handles btn_EstrellaC.Click
        tamano = formsCList.Count

        If lbl_FormaC.Text = "Estrella Roja" Then
            EliminarFormaC(selectedIndex)
            AumentarPuntaje()
            btn_EstrellaC.Enabled = False
        Else
            selectedIndex = rnd.Next(0, tamano)
            formaC = formsCList(selectedIndex)
            lbl_FormaC.Text = formaC
        End If

        IntentosPasados()
    End Sub

    Private Sub Btn_RectanguloC_Click(sender As Object, e As EventArgs) Handles btn_RectanguloC.Click
        tamano = formsCList.Count

        If lbl_FormaC.Text = "Rectangulo Negro" Then
            EliminarFormaC(selectedIndex)
            AumentarPuntaje()
            btn_RectanguloC.Enabled = False
        Else
            selectedIndex = rnd.Next(0, tamano)
            formaC = formsCList(selectedIndex)
            lbl_FormaC.Text = formaC
        End If

        IntentosPasados()
    End Sub

    Private Sub Btn_CirculoC_Click(sender As Object, e As EventArgs) Handles btn_CirculoC.Click
        tamano = formsCList.Count

        If lbl_FormaC.Text = "Circulo Azul" Then
            EliminarFormaC(selectedIndex)
            AumentarPuntaje()
            btn_CirculoC.Enabled = False
        Else
            selectedIndex = rnd.Next(0, tamano)
            formaC = formsCList(selectedIndex)
            lbl_FormaC.Text = formaC
        End If

        IntentosPasados()
    End Sub

    Private Sub Btn_TrianguloC_Click(sender As Object, e As EventArgs) Handles btn_TrianguloC.Click
        tamano = formsCList.Count

        If lbl_FormaC.Text = "Triangulo Amarillo" Then
            EliminarFormaC(selectedIndex)
            AumentarPuntaje()
            btn_TrianguloC.Enabled = False
        Else
            selectedIndex = rnd.Next(0, tamano)
            formaC = formsCList(selectedIndex)
            lbl_FormaC.Text = formaC
        End If

        IntentosPasados()
    End Sub
End Class