<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_Forms
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Forms))
        Me.btn_Cuadrado = New System.Windows.Forms.Button()
        Me.btn_Rectangulo = New System.Windows.Forms.Button()
        Me.btn_Triangulo = New System.Windows.Forms.Button()
        Me.btn_Circulo = New System.Windows.Forms.Button()
        Me.btn_Estrella = New System.Windows.Forms.Button()
        Me.cmb_Menu = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_Forma = New System.Windows.Forms.Label()
        Me.lbl_Puntos = New System.Windows.Forms.Label()
        Me.Puntuacion = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_Cuadrado
        '
        Me.btn_Cuadrado.BackColor = System.Drawing.Color.White
        Me.btn_Cuadrado.BackgroundImage = CType(resources.GetObject("btn_Cuadrado.BackgroundImage"), System.Drawing.Image)
        Me.btn_Cuadrado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Cuadrado.Location = New System.Drawing.Point(12, 92)
        Me.btn_Cuadrado.Name = "btn_Cuadrado"
        Me.btn_Cuadrado.Size = New System.Drawing.Size(144, 115)
        Me.btn_Cuadrado.TabIndex = 0
        Me.btn_Cuadrado.UseVisualStyleBackColor = False
        '
        'btn_Rectangulo
        '
        Me.btn_Rectangulo.BackColor = System.Drawing.Color.White
        Me.btn_Rectangulo.BackgroundImage = CType(resources.GetObject("btn_Rectangulo.BackgroundImage"), System.Drawing.Image)
        Me.btn_Rectangulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Rectangulo.Location = New System.Drawing.Point(329, 103)
        Me.btn_Rectangulo.Name = "btn_Rectangulo"
        Me.btn_Rectangulo.Size = New System.Drawing.Size(215, 104)
        Me.btn_Rectangulo.TabIndex = 1
        Me.btn_Rectangulo.Tag = "Rectangulo"
        Me.btn_Rectangulo.UseVisualStyleBackColor = False
        '
        'btn_Triangulo
        '
        Me.btn_Triangulo.BackColor = System.Drawing.SystemColors.Control
        Me.btn_Triangulo.BackgroundImage = CType(resources.GetObject("btn_Triangulo.BackgroundImage"), System.Drawing.Image)
        Me.btn_Triangulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Triangulo.Location = New System.Drawing.Point(181, 103)
        Me.btn_Triangulo.Name = "btn_Triangulo"
        Me.btn_Triangulo.Size = New System.Drawing.Size(127, 92)
        Me.btn_Triangulo.TabIndex = 2
        Me.btn_Triangulo.UseVisualStyleBackColor = False
        '
        'btn_Circulo
        '
        Me.btn_Circulo.BackgroundImage = CType(resources.GetObject("btn_Circulo.BackgroundImage"), System.Drawing.Image)
        Me.btn_Circulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Circulo.Location = New System.Drawing.Point(25, 234)
        Me.btn_Circulo.Name = "btn_Circulo"
        Me.btn_Circulo.Size = New System.Drawing.Size(108, 110)
        Me.btn_Circulo.TabIndex = 3
        Me.btn_Circulo.UseVisualStyleBackColor = True
        '
        'btn_Estrella
        '
        Me.btn_Estrella.BackgroundImage = CType(resources.GetObject("btn_Estrella.BackgroundImage"), System.Drawing.Image)
        Me.btn_Estrella.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Estrella.Location = New System.Drawing.Point(181, 234)
        Me.btn_Estrella.Name = "btn_Estrella"
        Me.btn_Estrella.Size = New System.Drawing.Size(124, 110)
        Me.btn_Estrella.TabIndex = 4
        Me.btn_Estrella.UseVisualStyleBackColor = True
        '
        'cmb_Menu
        '
        Me.cmb_Menu.FormattingEnabled = True
        Me.cmb_Menu.Items.AddRange(New Object() {"Principal", "Colores", "Formas y Colores"})
        Me.cmb_Menu.Location = New System.Drawing.Point(12, 12)
        Me.cmb_Menu.Name = "cmb_Menu"
        Me.cmb_Menu.Size = New System.Drawing.Size(121, 21)
        Me.cmb_Menu.TabIndex = 11
        Me.cmb_Menu.Text = "Seleccione Ventana"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(329, 234)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(207, 110)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Seleccione la Forma correcta según se pida."
        '
        'lbl_Forma
        '
        Me.lbl_Forma.AutoSize = True
        Me.lbl_Forma.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Forma.Location = New System.Drawing.Point(212, 60)
        Me.lbl_Forma.Name = "lbl_Forma"
        Me.lbl_Forma.Size = New System.Drawing.Size(0, 24)
        Me.lbl_Forma.TabIndex = 19
        '
        'lbl_Puntos
        '
        Me.lbl_Puntos.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Puntos.Location = New System.Drawing.Point(500, 8)
        Me.lbl_Puntos.Name = "lbl_Puntos"
        Me.lbl_Puntos.Size = New System.Drawing.Size(44, 24)
        Me.lbl_Puntos.TabIndex = 21
        Me.lbl_Puntos.Text = "0"
        '
        'Puntuacion
        '
        Me.Puntuacion.AutoSize = True
        Me.Puntuacion.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Puntuacion.Location = New System.Drawing.Point(368, 7)
        Me.Puntuacion.Name = "Puntuacion"
        Me.Puntuacion.Size = New System.Drawing.Size(132, 24)
        Me.Puntuacion.TabIndex = 20
        Me.Puntuacion.Text = "Puntuación:"
        '
        'frm_Forms
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(556, 366)
        Me.Controls.Add(Me.lbl_Puntos)
        Me.Controls.Add(Me.Puntuacion)
        Me.Controls.Add(Me.lbl_Forma)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmb_Menu)
        Me.Controls.Add(Me.btn_Estrella)
        Me.Controls.Add(Me.btn_Circulo)
        Me.Controls.Add(Me.btn_Triangulo)
        Me.Controls.Add(Me.btn_Rectangulo)
        Me.Controls.Add(Me.btn_Cuadrado)
        Me.Name = "frm_Forms"
        Me.Text = "Formas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_Cuadrado As Button
    Friend WithEvents btn_Rectangulo As Button
    Friend WithEvents btn_Triangulo As Button
    Friend WithEvents btn_Circulo As Button
    Friend WithEvents btn_Estrella As Button
    Friend WithEvents cmb_Menu As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_Forma As Label
    Friend WithEvents lbl_Puntos As Label
    Friend WithEvents Puntuacion As Label
End Class
