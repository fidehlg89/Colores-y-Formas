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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btn_Triangle = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.cmb_Menu = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_Color = New System.Windows.Forms.Label()
        Me.lbl_Puntos = New System.Windows.Forms.Label()
        Me.Puntuacion = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Location = New System.Drawing.Point(12, 92)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(144, 115)
        Me.Button1.TabIndex = 0
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Location = New System.Drawing.Point(329, 103)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(215, 104)
        Me.Button2.TabIndex = 1
        Me.Button2.Tag = "Rectangulo"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btn_Triangle
        '
        Me.btn_Triangle.BackColor = System.Drawing.SystemColors.Control
        Me.btn_Triangle.BackgroundImage = CType(resources.GetObject("btn_Triangle.BackgroundImage"), System.Drawing.Image)
        Me.btn_Triangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Triangle.Location = New System.Drawing.Point(181, 103)
        Me.btn_Triangle.Name = "btn_Triangle"
        Me.btn_Triangle.Size = New System.Drawing.Size(127, 92)
        Me.btn_Triangle.TabIndex = 2
        Me.btn_Triangle.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.Location = New System.Drawing.Point(25, 234)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(108, 110)
        Me.Button3.TabIndex = 3
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), System.Drawing.Image)
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.Location = New System.Drawing.Point(181, 234)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(124, 110)
        Me.Button4.TabIndex = 4
        Me.Button4.UseVisualStyleBackColor = True
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
        'lbl_Color
        '
        Me.lbl_Color.AutoSize = True
        Me.lbl_Color.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Color.Location = New System.Drawing.Point(212, 60)
        Me.lbl_Color.Name = "lbl_Color"
        Me.lbl_Color.Size = New System.Drawing.Size(75, 24)
        Me.lbl_Color.TabIndex = 19
        Me.lbl_Color.Text = "Forma"
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
        Me.Controls.Add(Me.lbl_Color)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmb_Menu)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btn_Triangle)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "frm_Forms"
        Me.Text = "Formas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btn_Triangle As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents cmb_Menu As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_Color As Label
    Friend WithEvents lbl_Puntos As Label
    Friend WithEvents Puntuacion As Label
End Class
