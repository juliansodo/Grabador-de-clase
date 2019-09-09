Imports System.Runtime.InteropServices
Imports System.Net.Mail
Imports System.Net
Imports System.IO

Public Class Form1

    Private Declare Function mciSendString Lib "winmm.dll" Alias "mciSendStringA" (ByVal lpstrCommand As String,
                                                                                   ByVal lpstrReturnString As String,
                                                                                   ByVal uReturnLength As Integer, ByVal hwndCallback As Integer) As Integer

    Dim ARCHIVO As String
    Private Sub ButtonGRABAR_Click(sender As Object, e As EventArgs) Handles ButtonGRABAR.Click
        Dim ruta As String = txtRuta.Text
        If ButtonGRABAR.Tag = "GRABAR" Then
            If corroborarControles() = False Then Exit Sub
            Dim BITS As Integer = 16
            Dim CANALES As Integer = 1
            Dim MUESTRAS As Integer = 3300


            Dim PROMEDIO As Integer = BITS * CANALES * MUESTRAS / 8
            Dim ALINEACION As Integer = BITS * CANALES / 8
            Dim COMANDO As String
            Try
                COMANDO = "set capture bitspersample " & BITS & " channels " & CANALES & " alignment " & ALINEACION & " samplespersec " &
                MUESTRAS & " bytespersec " & PROMEDIO & " format tag pcm wait"
                mciSendString("close capture", "", 0, 0)
                mciSendString("open new type waveaudio alias capture", "", 0, 0)
                mciSendString(COMANDO, "", 0, 0)
                mciSendString("record capture", "", 0, 0)

                trabarControles()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Timer1.Start()
            ButtonGRABAR.Tag = "PARAR"
            ButtonGRABAR.Text = "PARAR GRABACION"
        Else
            Try
                mciSendString("stop capture", "", 0, 0)
                ARCHIVO = ruta
                mciSendString("save capture " & ARCHIVO, "", 0, 0)
                mciSendString("close capture", "", 0, 0)
                EnviarEmail(ARCHIVO)
                destrabarControles()
                EjecutarAcciones()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            ButtonGRABAR.Tag = "GRABAR"
            ButtonGRABAR.Text = "GRABAR CLASE"
            Timer1.Stop()
        End If
    End Sub

    Public Sub EnviarEmail(ByVal UrlAudio As String)
        Dim email As String = txtEmail.Text
        Dim ruta As String = txtRuta.Text
        Dim materia As String = txtMateria.Text
        Dim archivo As Attachment = New Attachment(ruta)
        Try
            Dim correo As New MailMessage
            Dim smtpCliente As New SmtpClient()
            correo.From = New MailAddress("mensajes@jvsdigital.com")
            correo.Body = "Clase de " + materia + " grabada el " + Now.ToShortDateString
            correo.Subject = "Clase de: " + materia
            correo.IsBodyHtml = True
            correo.To.Add(Trim(email))
            smtpCliente.Host = "smtp.hostinger.com.ar"
            smtpCliente.Credentials = New NetworkCredential("mensajes@jvsdigital.com", "123123jJ")
            smtpCliente.Port = "587"
            smtpCliente.EnableSsl = True
            correo.Attachments.Add(archivo)

            smtpCliente.Send(correo)
            ' MessageBox.Show("Enviado")
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtRuta.Text = My.Computer.FileSystem.SpecialDirectories.Desktop + "\Clase_" + Now.ToShortDateString.Replace("/", "-") + ".mp3"
        ButtonGRABAR.Tag = "GRABAR"
        ButtonGRABAR.Text = "GRABAR CLASE"
        cboxAcciones.SelectedIndex = 0
    End Sub

    Public Sub trabarControles()

        txtEmail.ReadOnly = True
        txtMateria.ReadOnly = True
        dateHorarioEnvio.Enabled = True
    End Sub
    Public Sub destrabarControles()
        txtEmail.ReadOnly = False
        dateHorarioEnvio.Enabled = False
        txtMateria.ReadOnly = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCambiarRuta.Click
        Dim dialog As DialogResult
        dialog = folderBrowser.ShowDialog()
        If dialog = dialog.OK Then
            txtRuta.Text = folderBrowser.SelectedPath + "Clase_" + Now.ToShortDateString.Replace("/", "-") + ".mp3"
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Now.ToShortTimeString >= dateHorarioEnvio.Value.ToShortTimeString Then
            ButtonGRABAR_Click(Nothing, Nothing)
        End If
    End Sub
    Public Function corroborarControles() As Boolean
        If txtEmail.Text.Length < 5 Then
            MessageBox.Show("Email erróneo, verifique.")
            Return False
        ElseIf txtMateria.Text.Length = 0 Then
            MessageBox.Show("Nombre de materia erroneo, verifique.")
            Return False
        ElseIf txtRuta.Text.Length = 0 Then
            MessageBox.Show("Ruta invalida, cierre y vuelva a abrir o coloque una ruta correcta")
            Return False
        End If
        Return True
    End Function
    Public Sub EjecutarAcciones()
        Dim accionActual As String = cboxAcciones.SelectedItem.ToString
        Select Case accionActual
            Case "APAGAR"
                Process.Start("shutdown.exe", "-s -t 50 -f")
            Case "REINICIAR"
                Process.Start("shutdown.exe", "-r -t 50 -f")
            Case "CERRAR"
                Me.Close()
            Case Else
                Exit Sub
        End Select
    End Sub
End Class

