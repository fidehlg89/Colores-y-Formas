<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Both
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Both))
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btn_Triangle = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cmb_Menu = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_Color = New System.Windows.Forms.Label()
        Me.lbl_Puntos = New System.Windows.Forms.Label()
        Me.Puntuacion = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button4
        '
        Me.Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), System.Drawing.Image)
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.Location = New System.Drawing.Point(220, 128)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(124, 110)
        Me.Button4.TabIndex = 9
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.Location = New System.Drawing.Point(399, 127)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(108, 110)
        Me.Button3.TabIndex = 8
        Me.Button3.UseVisualStyleBackColor = True
        '
        'btn_Triangle
        '
        Me.btn_Triangle.BackColor = System.Drawing.SystemColors.Control
        Me.btn_Triangle.BackgroundImage = CType(resources.GetObject("btn_Triangle.BackgroundImage"), System.Drawing.Image)
        Me.btn_Triangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Triangle.Location = New System.Drawing.Point(233, 266)
        Me.btn_Triangle.Name = "btn_Triangle"
        Me.btn_Triangle.Size = New System.Drawing.Size(117, 92)
        Me.btn_Triangle.TabIndex = 7
        Me.btn_Triangle.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Location = New System.Drawing.Point(12, 260)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(215, 104)
        Me.Button2.TabIndex = 6
        Me.Button2.Tag = "Rectangulo"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Location = New System.Drawing.Point(45, 123)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(131, 115)
        Me.Button1.TabIndex = 5
        Me.Button1.UseVisualStyleBackColor = False
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
        'lbl_Color
        '
        Me.lbl_Color.AutoSize = True
        Me.lbl_Color.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Color.Location = New System.Drawing.Point(243, 75)
        Me.lbl_Color.Name = "lbl_Color"
        Me.lbl_Color.Size = New System.Drawing.Size(188, 24)
        Me.lbl_Color.TabIndex = 19
        Me.lbl_Color.Text = "Formas y Colores"
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
        'frm_Both
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(577, 392)
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
        Me.Name = "frm_Both"
        Me.Text = "Formas y Colores"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents btn_Triangle As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents cmb_Menu As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_Color As Label
    Friend WithEvents lbl_Puntos As Label
    Friend WithEvents Puntuacion As Label
End Class
