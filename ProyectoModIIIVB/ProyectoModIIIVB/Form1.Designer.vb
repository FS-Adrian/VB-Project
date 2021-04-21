<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Bitacora = New System.Windows.Forms.Button()
        Me.Encuesta = New System.Windows.Forms.Button()
        Me.Informacion = New System.Windows.Forms.Button()
        Me.Salir = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Agendar = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Bitacora
        '
        Me.Bitacora.Location = New System.Drawing.Point(138, 71)
        Me.Bitacora.Name = "Bitacora"
        Me.Bitacora.Size = New System.Drawing.Size(110, 23)
        Me.Bitacora.TabIndex = 0
        Me.Bitacora.Text = "Bitacora de Servicio"
        Me.Bitacora.UseVisualStyleBackColor = True
        '
        'Encuesta
        '
        Me.Encuesta.Location = New System.Drawing.Point(138, 173)
        Me.Encuesta.Name = "Encuesta"
        Me.Encuesta.Size = New System.Drawing.Size(136, 23)
        Me.Encuesta.TabIndex = 1
        Me.Encuesta.Text = "Encuesta de Satisfaccion"
        Me.Encuesta.UseVisualStyleBackColor = True
        '
        'Informacion
        '
        Me.Informacion.Location = New System.Drawing.Point(138, 223)
        Me.Informacion.Name = "Informacion"
        Me.Informacion.Size = New System.Drawing.Size(75, 23)
        Me.Informacion.TabIndex = 2
        Me.Informacion.Text = "Informacion"
        Me.Informacion.UseVisualStyleBackColor = True
        '
        'Salir
        '
        Me.Salir.Location = New System.Drawing.Point(138, 280)
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(75, 23)
        Me.Salir.TabIndex = 3
        Me.Salir.Text = "Salir"
        Me.Salir.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(73, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(213, 37)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Centro de Atencion y Servicios Buenos dias, ¿que necesita?"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.indice2
        Me.PictureBox1.Location = New System.Drawing.Point(12, 71)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(89, 232)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Agendar
        '
        Me.Agendar.Location = New System.Drawing.Point(138, 121)
        Me.Agendar.Name = "Agendar"
        Me.Agendar.Size = New System.Drawing.Size(161, 23)
        Me.Agendar.TabIndex = 6
        Me.Agendar.Text = "Agendar visita a Dependencia"
        Me.Agendar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(355, 315)
        Me.Controls.Add(Me.Agendar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Salir)
        Me.Controls.Add(Me.Informacion)
        Me.Controls.Add(Me.Encuesta)
        Me.Controls.Add(Me.Bitacora)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Bitacora As System.Windows.Forms.Button
    Friend WithEvents Encuesta As System.Windows.Forms.Button
    Friend WithEvents Informacion As System.Windows.Forms.Button
    Friend WithEvents Salir As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Agendar As System.Windows.Forms.Button

End Class
