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
        Me.components = New System.ComponentModel.Container()
        Me.ButtonGRABAR = New System.Windows.Forms.Button()
        Me.dateHorarioEnvio = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMateria = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblRuta = New System.Windows.Forms.Label()
        Me.txtRuta = New System.Windows.Forms.TextBox()
        Me.btnCambiarRuta = New System.Windows.Forms.Button()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.folderBrowser = New System.Windows.Forms.FolderBrowserDialog()
        Me.cboxAcciones = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ButtonGRABAR
        '
        Me.ButtonGRABAR.BackColor = System.Drawing.Color.Black
        Me.ButtonGRABAR.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.ButtonGRABAR.Location = New System.Drawing.Point(2, 303)
        Me.ButtonGRABAR.Name = "ButtonGRABAR"
        Me.ButtonGRABAR.Size = New System.Drawing.Size(268, 40)
        Me.ButtonGRABAR.TabIndex = 2
        Me.ButtonGRABAR.Text = "GRABAR CLASE"
        Me.ButtonGRABAR.UseVisualStyleBackColor = False
        '
        'dateHorarioEnvio
        '
        Me.dateHorarioEnvio.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dateHorarioEnvio.Location = New System.Drawing.Point(12, 214)
        Me.dateHorarioEnvio.Name = "dateHorarioEnvio"
        Me.dateHorarioEnvio.Size = New System.Drawing.Size(247, 22)
        Me.dateHorarioEnvio.TabIndex = 3
        Me.dateHorarioEnvio.Value = New Date(2019, 9, 8, 12, 20, 0, 0)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(61, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Materia"
        '
        'txtMateria
        '
        Me.txtMateria.Location = New System.Drawing.Point(12, 37)
        Me.txtMateria.Name = "txtMateria"
        Me.txtMateria.Size = New System.Drawing.Size(213, 22)
        Me.txtMateria.TabIndex = 5
        Me.txtMateria.Text = "Laboratorio"
        '
        'Timer1
        '
        Me.Timer1.Interval = 60000
        '
        'lblRuta
        '
        Me.lblRuta.AutoSize = True
        Me.lblRuta.Location = New System.Drawing.Point(18, 78)
        Me.lblRuta.Name = "lblRuta"
        Me.lblRuta.Size = New System.Drawing.Size(133, 16)
        Me.lblRuta.TabIndex = 6
        Me.lblRuta.Text = "Ruta de guardado"
        '
        'txtRuta
        '
        Me.txtRuta.Location = New System.Drawing.Point(12, 97)
        Me.txtRuta.Name = "txtRuta"
        Me.txtRuta.ReadOnly = True
        Me.txtRuta.Size = New System.Drawing.Size(213, 22)
        Me.txtRuta.TabIndex = 7
        '
        'btnCambiarRuta
        '
        Me.btnCambiarRuta.ForeColor = System.Drawing.Color.Black
        Me.btnCambiarRuta.Location = New System.Drawing.Point(231, 96)
        Me.btnCambiarRuta.Name = "btnCambiarRuta"
        Me.btnCambiarRuta.Size = New System.Drawing.Size(28, 23)
        Me.btnCambiarRuta.TabIndex = 8
        Me.btnCambiarRuta.Text = "..."
        Me.btnCambiarRuta.UseVisualStyleBackColor = True
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(18, 136)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(47, 16)
        Me.lblEmail.TabIndex = 9
        Me.lblEmail.Text = "Email"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(12, 155)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(247, 22)
        Me.txtEmail.TabIndex = 10
        Me.txtEmail.Text = "sodojulian@gmail.com"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 195)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 16)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Horario de envío"
        '
        'cboxAcciones
        '
        Me.cboxAcciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxAcciones.FormattingEnabled = True
        Me.cboxAcciones.Items.AddRange(New Object() {"APAGAR", "REINICIAR", "CERRAR", "NADA"})
        Me.cboxAcciones.Location = New System.Drawing.Point(12, 273)
        Me.cboxAcciones.Name = "cboxAcciones"
        Me.cboxAcciones.Size = New System.Drawing.Size(247, 24)
        Me.cboxAcciones.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 254)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(167, 16)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Accion luego de enviar"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(271, 344)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cboxAcciones)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.btnCambiarRuta)
        Me.Controls.Add(Me.txtRuta)
        Me.Controls.Add(Me.lblRuta)
        Me.Controls.Add(Me.txtMateria)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dateHorarioEnvio)
        Me.Controls.Add(Me.ButtonGRABAR)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GRABADORA MICROFONO"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonGRABAR As System.Windows.Forms.Button
    Friend WithEvents dateHorarioEnvio As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents txtMateria As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblRuta As Label
    Friend WithEvents txtRuta As TextBox
    Friend WithEvents btnCambiarRuta As Button
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents folderBrowser As FolderBrowserDialog
    Friend WithEvents cboxAcciones As ComboBox
    Friend WithEvents Label3 As Label
End Class
