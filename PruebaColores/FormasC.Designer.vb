<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_FormasC
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_FormasC))
        Me.btn_EstrellaC = New System.Windows.Forms.Button()
        Me.btn_CirculoC = New System.Windows.Forms.Button()
        Me.btn_TrianguloC = New System.Windows.Forms.Button()
        Me.btn_RectanguloC = New System.Windows.Forms.Button()
        Me.btn_CuadradoC = New System.Windows.Forms.Button()
        Me.cmb_Menu = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_FormaC = New System.Windows.Forms.Label()
        Me.lbl_Puntos = New System.Windows.Forms.Label()
        Me.Puntuacion = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_EstrellaC
        '
        Me.btn_EstrellaC.BackgroundImage = CType(resources.GetObject("btn_EstrellaC.BackgroundImage"), System.Drawing.Image)
        Me.btn_EstrellaC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_EstrellaC.Location = New System.Drawing.Point(220, 128)
        Me.btn_EstrellaC.Name = "btn_EstrellaC"
        Me.btn_EstrellaC.Size = New System.Drawing.Size(124, 110)
        Me.btn_EstrellaC.TabIndex = 9
        Me.btn_EstrellaC.UseVisualStyleBackColor = True
        '
        'btn_CirculoC
        '
        Me.btn_CirculoC.BackgroundImage = CType(resources.GetObject("btn_CirculoC.BackgroundImage"), System.Drawing.Image)
        Me.btn_CirculoC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_CirculoC.Location = New System.Drawing.Point(399, 127)
        Me.btn_CirculoC.Name = "btn_CirculoC"
        Me.btn_CirculoC.Size = New System.Drawing.Size(108, 110)
        Me.btn_CirculoC.TabIndex = 8
        Me.btn_CirculoC.UseVisualStyleBackColor = True
        '
        'btn_TrianguloC
        '
        Me.btn_TrianguloC.BackColor = System.Drawing.SystemColors.Control
        Me.btn_TrianguloC.BackgroundImage = CType(resources.GetObject("btn_TrianguloC.BackgroundImage"), System.Drawing.Image)
        Me.btn_TrianguloC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_TrianguloC.Location = New System.Drawing.Point(233, 266)
        Me.btn_TrianguloC.Name = "btn_TrianguloC"
        Me.btn_TrianguloC.Size = New System.Drawing.Size(117, 92)
        Me.btn_TrianguloC.TabIndex = 7
        Me.btn_TrianguloC.UseVisualStyleBackColor = False
        '
        'btn_RectanguloC
        '
        Me.btn_RectanguloC.BackColor = System.Drawing.Color.White
        Me.btn_RectanguloC.BackgroundImage = CType(resources.GetObject("btn_RectanguloC.BackgroundImage"), System.Drawing.Image)
        Me.btn_RectanguloC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_RectanguloC.Location = New System.Drawing.Point(12, 260)
        Me.btn_RectanguloC.Name = "btn_RectanguloC"
        Me.btn_RectanguloC.Size = New System.Drawing.Size(215, 104)
        Me.btn_RectanguloC.TabIndex = 6
        Me.btn_RectanguloC.Tag = "Rectangulo"
        Me.btn_RectanguloC.UseVisualStyleBackColor = False
        '
        'btn_CuadradoC
        '
        Me.btn_CuadradoC.BackColor = System.Drawing.Color.White
        Me.btn_CuadradoC.BackgroundImage = CType(resources.GetObject("btn_CuadradoC.BackgroundImage"), System.Drawing.Image)
        Me.btn_CuadradoC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_CuadradoC.Location = New System.Drawing.Point(45, 123)
        Me.btn_CuadradoC.Name = "btn_CuadradoC"
        Me.btn_CuadradoC.Size = New System.Drawing.Size(131, 115)
        Me.btn_CuadradoC.TabIndex = 5
        Me.btn_CuadradoC.UseVisualStyleBackColor = False
        '
        'cmb_Menu
        '
        Me.cmb_Menu.FormattingEnabled = True
        Me.cmb_Menu.Items.AddRange(New Object() {"Principal", "Colores", "Formas"})
        Me.cmb_Menu.Location = New System.Drawing.Point(12, 12)
        Me.cmb_Menu.Name = "cmb_Menu"
        Me.cmb_Menu.Size = New System.Drawing.Size(121, 21)
        Me.cmb_Menu.TabIndex = 10
        Me.cmb_Menu.Text = "Seleccione Ventana"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(375, 266)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(190, 110)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Seleccione la Forma y color correctos según se pida."
        '
        'lbl_FormaC
        '
        Me.lbl_FormaC.AutoSize = True
        Me.lbl_FormaC.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_FormaC.Location = New System.Drawing.Point(243, 75)
        Me.lbl_FormaC.Name = "lbl_FormaC"
        Me.lbl_FormaC.Size = New System.Drawing.Size(0, 24)
        Me.lbl_FormaC.TabIndex = 19
        '
        'lbl_Puntos
        '
        Me.lbl_Puntos.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Puntos.Location = New System.Drawing.Point(527, 7)
        Me.lbl_Puntos.Name = "lbl_Puntos"
        Me.lbl_Puntos.Size = New System.Drawing.Size(38, 24)
        Me.lbl_Puntos.TabIndex = 21
        Me.lbl_Puntos.Text = "0"
        '
        'Puntuacion
        '
        Me.Puntuacion.AutoSize = True
        Me.Puntuacion.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Puntuacion.Location = New System.Drawing.Point(395, 7)
        Me.Puntuacion.Name = "Puntuacion"
        Me.Puntuacion.Size = New System.Drawing.Size(132, 24)
        Me.Puntuacion.TabIndex = 20
        Me.Puntuacion.Text = "Puntuación:"
        '
        'frm_FormasC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(577, 392)
        Me.Controls.Add(Me.lbl_Puntos)
        Me.Controls.Add(Me.Puntuacion)
        Me.Controls.Add(Me.lbl_FormaC)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmb_Menu)
        Me.Controls.Add(Me.btn_EstrellaC)
        Me.Controls.Add(Me.btn_CirculoC)
        Me.Controls.Add(Me.btn_TrianguloC)
        Me.Controls.Add(Me.btn_RectanguloC)
        Me.Controls.Add(Me.btn_CuadradoC)
        Me.Name = "frm_FormasC"
        Me.Text = "Formas + Colores"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_EstrellaC As Button
    Friend WithEvents btn_CirculoC As Button
    Friend WithEvents btn_TrianguloC As Button
    Friend WithEvents btn_RectanguloC As Button
    Friend WithEvents btn_CuadradoC As Button
    Friend WithEvents cmb_Menu As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_FormaC As Label
    Friend WithEvents lbl_Puntos As Label
    Friend WithEvents Puntuacion As Label
End Class
