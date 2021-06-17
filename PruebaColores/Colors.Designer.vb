<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_Colors
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Colors))
        Me.btn_Rojo = New System.Windows.Forms.Button()
        Me.btn_Amarillo = New System.Windows.Forms.Button()
        Me.btn_Negro = New System.Windows.Forms.Button()
        Me.btn_Verde = New System.Windows.Forms.Button()
        Me.btn_Azul = New System.Windows.Forms.Button()
        Me.cmb_Menu = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Puntuacion = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_Color = New System.Windows.Forms.Label()
        Me.lbl_Puntos = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_Rojo
        '
        Me.btn_Rojo.BackgroundImage = CType(resources.GetObject("btn_Rojo.BackgroundImage"), System.Drawing.Image)
        Me.btn_Rojo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Rojo.Location = New System.Drawing.Point(25, 95)
        Me.btn_Rojo.Name = "btn_Rojo"
        Me.btn_Rojo.Size = New System.Drawing.Size(121, 95)
        Me.btn_Rojo.TabIndex = 0
        Me.btn_Rojo.Tag = "Rojo"
        Me.btn_Rojo.UseVisualStyleBackColor = True
        '
        'btn_Amarillo
        '
        Me.btn_Amarillo.BackgroundImage = CType(resources.GetObject("btn_Amarillo.BackgroundImage"), System.Drawing.Image)
        Me.btn_Amarillo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Amarillo.Location = New System.Drawing.Point(189, 95)
        Me.btn_Amarillo.Name = "btn_Amarillo"
        Me.btn_Amarillo.Size = New System.Drawing.Size(121, 95)
        Me.btn_Amarillo.TabIndex = 1
        Me.btn_Amarillo.UseVisualStyleBackColor = True
        '
        'btn_Negro
        '
        Me.btn_Negro.BackgroundImage = CType(resources.GetObject("btn_Negro.BackgroundImage"), System.Drawing.Image)
        Me.btn_Negro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Negro.Location = New System.Drawing.Point(352, 95)
        Me.btn_Negro.Name = "btn_Negro"
        Me.btn_Negro.Size = New System.Drawing.Size(121, 95)
        Me.btn_Negro.TabIndex = 2
        Me.btn_Negro.Tag = "Negro"
        Me.btn_Negro.UseVisualStyleBackColor = True
        '
        'btn_Verde
        '
        Me.btn_Verde.BackgroundImage = CType(resources.GetObject("btn_Verde.BackgroundImage"), System.Drawing.Image)
        Me.btn_Verde.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Verde.Location = New System.Drawing.Point(25, 205)
        Me.btn_Verde.Name = "btn_Verde"
        Me.btn_Verde.Size = New System.Drawing.Size(121, 95)
        Me.btn_Verde.TabIndex = 3
        Me.btn_Verde.Tag = "Verde"
        Me.btn_Verde.UseVisualStyleBackColor = True
        '
        'btn_Azul
        '
        Me.btn_Azul.BackgroundImage = CType(resources.GetObject("btn_Azul.BackgroundImage"), System.Drawing.Image)
        Me.btn_Azul.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Azul.Location = New System.Drawing.Point(189, 205)
        Me.btn_Azul.Name = "btn_Azul"
        Me.btn_Azul.Size = New System.Drawing.Size(121, 95)
        Me.btn_Azul.TabIndex = 4
        Me.btn_Azul.Tag = "Azul"
        Me.btn_Azul.UseVisualStyleBackColor = True
        '
        'cmb_Menu
        '
        Me.cmb_Menu.FormattingEnabled = True
        Me.cmb_Menu.Items.AddRange(New Object() {"Principal", "Formas", "Formas y Colores"})
        Me.cmb_Menu.Location = New System.Drawing.Point(12, 12)
        Me.cmb_Menu.Name = "cmb_Menu"
        Me.cmb_Menu.Size = New System.Drawing.Size(121, 21)
        Me.cmb_Menu.TabIndex = 6
        Me.cmb_Menu.Text = "Seleccione Ventana"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(328, 205)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(184, 110)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Seleccione el color correcto según se le pida."
        '
        'Puntuacion
        '
        Me.Puntuacion.AutoSize = True
        Me.Puntuacion.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Puntuacion.Location = New System.Drawing.Point(344, 7)
        Me.Puntuacion.Name = "Puntuacion"
        Me.Puntuacion.Size = New System.Drawing.Size(132, 24)
        Me.Puntuacion.TabIndex = 15
        Me.Puntuacion.Text = "Puntuación:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(186, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 16
        '
        'lbl_Color
        '
        Me.lbl_Color.AutoSize = True
        Me.lbl_Color.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Color.Location = New System.Drawing.Point(192, 49)
        Me.lbl_Color.Name = "lbl_Color"
        Me.lbl_Color.Size = New System.Drawing.Size(0, 24)
        Me.lbl_Color.TabIndex = 18
        '
        'lbl_Puntos
        '
        Me.lbl_Puntos.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Puntos.Location = New System.Drawing.Point(476, 7)
        Me.lbl_Puntos.Name = "lbl_Puntos"
        Me.lbl_Puntos.Size = New System.Drawing.Size(36, 24)
        Me.lbl_Puntos.TabIndex = 19
        Me.lbl_Puntos.Text = "0"
        '
        'frm_Colors
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(524, 324)
        Me.Controls.Add(Me.lbl_Puntos)
        Me.Controls.Add(Me.lbl_Color)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Puntuacion)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmb_Menu)
        Me.Controls.Add(Me.btn_Azul)
        Me.Controls.Add(Me.btn_Verde)
        Me.Controls.Add(Me.btn_Negro)
        Me.Controls.Add(Me.btn_Amarillo)
        Me.Controls.Add(Me.btn_Rojo)
        Me.Name = "frm_Colors"
        Me.Tag = "Amarillo"
        Me.Text = "Colores"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_Rojo As Button
    Friend WithEvents btn_Amarillo As Button
    Friend WithEvents btn_Negro As Button
    Friend WithEvents btn_Verde As Button
    Friend WithEvents btn_Azul As Button
    Friend WithEvents cmb_Menu As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Puntuacion As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_Color As Label
    Friend WithEvents lbl_Puntos As Label
End Class
