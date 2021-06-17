<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Main))
        Me.btn_Forms = New System.Windows.Forms.Button()
        Me.btn_Both = New System.Windows.Forms.Button()
        Me.btn_Colors = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_Forms
        '
        Me.btn_Forms.BackgroundImage = CType(resources.GetObject("btn_Forms.BackgroundImage"), System.Drawing.Image)
        Me.btn_Forms.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Forms.Location = New System.Drawing.Point(198, 64)
        Me.btn_Forms.Name = "btn_Forms"
        Me.btn_Forms.Size = New System.Drawing.Size(121, 109)
        Me.btn_Forms.TabIndex = 1
        Me.btn_Forms.UseVisualStyleBackColor = True
        '
        'btn_Both
        '
        Me.btn_Both.BackgroundImage = CType(resources.GetObject("btn_Both.BackgroundImage"), System.Drawing.Image)
        Me.btn_Both.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Both.Location = New System.Drawing.Point(373, 64)
        Me.btn_Both.Name = "btn_Both"
        Me.btn_Both.Size = New System.Drawing.Size(136, 109)
        Me.btn_Both.TabIndex = 2
        Me.btn_Both.UseVisualStyleBackColor = True
        '
        'btn_Colors
        '
        Me.btn_Colors.BackgroundImage = CType(resources.GetObject("btn_Colors.BackgroundImage"), System.Drawing.Image)
        Me.btn_Colors.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Colors.Location = New System.Drawing.Point(26, 64)
        Me.btn_Colors.Name = "btn_Colors"
        Me.btn_Colors.Size = New System.Drawing.Size(121, 109)
        Me.btn_Colors.TabIndex = 0
        Me.btn_Colors.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Prueba de Colores"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(213, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Prueba de Formas"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(370, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Prueba de Formas y Colores"
        '
        'frm_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(540, 236)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_Both)
        Me.Controls.Add(Me.btn_Forms)
        Me.Controls.Add(Me.btn_Colors)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_Main"
        Me.Text = ".:. Formas con Colores .:."
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_Forms As Button
    Friend WithEvents btn_Both As Button
    Friend WithEvents btn_Colors As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
