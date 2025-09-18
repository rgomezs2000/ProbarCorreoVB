Imports System.Net
Imports System.Net.Mail
Imports System.Net.Sockets
Imports System.Text
Imports System.Text.RegularExpressions
Public Class ProbarCorreosVW
    Dim Email As String
    Dim Password As String
    Dim Host As String
    Dim SSL As Boolean
    Dim Port As Integer
    Dim Para As String
    Dim Subject As String
    Dim Body As String

    Private Sub rb_ssl_1_CheckedChanged(sender As Object, e As EventArgs) Handles rb_ssl_1.CheckedChanged
        If rb_ssl_1.Checked = True Then
            rb_ssl_2.Checked = False
        End If
    End Sub

    Private Sub rb_ssl_2_CheckedChanged(sender As Object, e As EventArgs) Handles rb_ssl_2.CheckedChanged
        If rb_ssl_2.Checked = True Then
            rb_ssl_1.Checked = False
        End If
    End Sub

    Private Sub bt_enviar_Click(sender As Object, e As EventArgs) Handles bt_enviar.Click
        Dim correo_de As String
        Dim password As String
        Dim host As String
        Dim ssl As Boolean
        Dim port As Integer
        Dim correo_para As String
        Dim asunto As String
        Dim cuerpo As String

        If tx_correo_de.Text = "" Then
            lb_result.Text = "Requiere correo electrónico de remitente o de usuario"
            lb_result.ForeColor = Color.Red
            Exit Sub
        End If

        If Not ValidarEmail(tx_correo_de.Text) Then
            lb_result.Text = "El formato del correo del remitente o usuario es inválido"
            lb_result.ForeColor = Color.Red
            Exit Sub
        End If

        If pw_password.Text = "" Then
            lb_result.Text = "Requiere clave del correo electronico de usuario"
            lb_result.ForeColor = Color.Red
            Exit Sub
        End If

        If tx_host.Text = "" Then
            lb_result.Text = "Requiere el host donde debe conectarse"
            lb_result.ForeColor = Color.Red
            lb_result.Visible = True
            Exit Sub
        End If

        If Not rb_ssl_1.Checked And Not rb_ssl_2.Checked Then
            lb_result.Text = "Debe elegir si es SSL o no"
            lb_result.ForeColor = Color.Red
            Exit Sub
        End If

        If tx_puerto.Text = "" Then
            lb_result.Text = "Requiere puerto de conexion"
            lb_result.ForeColor = Color.Red
            Exit Sub
        End If

        If Not IsNumeric(tx_puerto.Text) Then
            lb_result.Text = "El puerto debe ser numerico"
            lb_result.ForeColor = Color.Red
            Exit Sub
        End If

        If tx_correo_para.Text = "" Then
            lb_result.Text = "Requiere correo electrónico del destinatario"
            lb_result.ForeColor = Color.Red
            Exit Sub
        End If

        If Not ValidarEmail(tx_correo_para.Text) Then
            lb_result.Text = "El formato del correo del destinatario es inválido"
            lb_result.ForeColor = Color.Red
            Exit Sub
        End If

        If tx_asunto.Text = "" Then
            lb_result.Text = "Requiere el asunto del mensaje"
            lb_result.ForeColor = Color.Red
            lb_result.Visible = True
            Exit Sub
        End If

        If tx_cuerpo.Text = "" Then
            lb_result.Text = "Requiere el cuerpo del mensaje"
            lb_result.ForeColor = Color.Red
            Exit Sub
        End If

        If tx_correo_de.Text <> "" And pw_password.Text <> "" And tx_host.Text <> "" And tx_puerto.Text <> "" And tx_correo_para.Text <> "" And tx_asunto.Text <> "" _
        And tx_cuerpo.Text <> "" And (rb_ssl_1.Checked Or rb_ssl_2.Checked) And IsNumeric(tx_puerto.Text) And ValidarEmail(tx_correo_de.Text) And ValidarEmail(tx_correo_para.Text) Then
            lb_result.Text = ""
        End If

        correo_de = tx_correo_de.Text
        password = pw_password.Text
        host = tx_host.Text
        port = Integer.Parse(tx_puerto.Text)
        correo_para = tx_correo_para.Text
        asunto = tx_asunto.Text
        cuerpo = tx_cuerpo.Text

        If rb_ssl_1.Checked And Not rb_ssl_2.Checked Then
            ssl = True
        ElseIf Not rb_ssl_1.Checked And rb_ssl_2.Checked Then
            ssl = False
        End If

        EnviarCorreo(correo_de, password, host, ssl, port, correo_para, asunto, cuerpo)

    End Sub

    Private Sub bt_enviar_alternativo_Click(sender As Object, e As EventArgs) Handles bt_enviar_alternativo.Click
        Dim correo_de As String
        Dim password As String
        Dim host As String
        Dim ssl As Boolean
        Dim correo_para As String
        Dim asunto As String
        Dim cuerpo As String

        If tx_correo_de.Text = "" Then
            lb_result.Text = "Requiere correo electrónico de remitente o de usuario"
            lb_result.ForeColor = Color.Red
            Exit Sub
        End If

        If Not ValidarEmail(tx_correo_de.Text) Then
            lb_result.Text = "El formato del correo del remitente o usuario es inválido"
            lb_result.ForeColor = Color.Red
            Exit Sub
        End If

        If pw_password.Text = "" Then
            lb_result.Text = "Requiere clave del correo electronico de usuario"
            lb_result.ForeColor = Color.Red
            Exit Sub
        End If

        If tx_host.Text = "" Then
            lb_result.Text = "Requiere el host donde debe conectarse"
            lb_result.ForeColor = Color.Red
            lb_result.Visible = True
            Exit Sub
        End If

        If Not rb_ssl_1.Checked And Not rb_ssl_2.Checked Then
            lb_result.Text = "Debe elegir si es SSL o no"
            lb_result.ForeColor = Color.Red
            Exit Sub
        End If

        If tx_correo_para.Text = "" Then
            lb_result.Text = "Requiere correo electrónico del destinatario"
            lb_result.ForeColor = Color.Red
            Exit Sub
        End If

        If Not ValidarEmail(tx_correo_para.Text) Then
            lb_result.Text = "El formato del correo del destinatario es inválido"
            lb_result.ForeColor = Color.Red
            Exit Sub
        End If

        If tx_asunto.Text = "" Then
            lb_result.Text = "Requiere el asunto del mensaje"
            lb_result.ForeColor = Color.Red
            lb_result.Visible = True
            Exit Sub
        End If

        If tx_cuerpo.Text = "" Then
            lb_result.Text = "Requiere el cuerpo del mensaje"
            lb_result.ForeColor = Color.Red
            Exit Sub
        End If

        If tx_correo_de.Text <> "" And pw_password.Text <> "" And tx_host.Text <> "" And tx_correo_para.Text <> "" And tx_asunto.Text <> "" _
        And tx_cuerpo.Text <> "" And (rb_ssl_1.Checked Or rb_ssl_2.Checked) And ValidarEmail(tx_correo_de.Text) And ValidarEmail(tx_correo_para.Text) Then
            lb_result.Text = ""
        End If

        correo_de = tx_correo_de.Text
        password = pw_password.Text
        host = tx_host.Text
        correo_para = tx_correo_para.Text
        asunto = tx_asunto.Text
        cuerpo = tx_cuerpo.Text

        If rb_ssl_1.Checked And Not rb_ssl_2.Checked Then
            ssl = True
        ElseIf Not rb_ssl_1.Checked And rb_ssl_2.Checked Then
            ssl = False
        End If

        EnviarCorreoAlternativo(correo_de, password, host, ssl, correo_para, asunto, cuerpo)
    End Sub

    Private Sub bt_verificar_Click(sender As Object, e As EventArgs) Handles bt_verificar.Click
        Dim host As String
        Dim port As Integer

        If tx_host.Text = "" Then
            lb_result.Text = "Requiere el host donde debe conectarse"
            lb_result.ForeColor = Color.Red
            lb_result.Visible = True
            Exit Sub
        End If

        If tx_puerto.Text = "" Then
            lb_result.Text = "Requiere puerto de conexion"
            lb_result.ForeColor = Color.Red
            Exit Sub
        End If

        If Not IsNumeric(tx_puerto.Text) Then
            lb_result.Text = "El puerto debe ser numerico"
            lb_result.ForeColor = Color.Red
            Exit Sub
        End If

        If tx_host.Text <> "" And tx_puerto.Text <> "" And IsNumeric(tx_puerto.Text) Then
            lb_result.Text = ""
        End If

        host = tx_host.Text
        port = Integer.Parse(tx_puerto.Text)

        VerificarConexion(host, port)
    End Sub

    Private Sub EnviarCorreo(ByVal email As String, ByVal password As String, ByVal host As String,
                             ByVal ssl As Boolean, ByVal port As Integer, ByVal para As String,
                             ByVal subject As String, ByVal body As String)
        Try
            Dim SMTP As New SmtpClient(host)
            Dim credenciales As New NetworkCredential(email, password)

            'Configuracion SMTP
            SMTP.UseDefaultCredentials = False
            SMTP.Credentials = credenciales
            SMTP.EnableSsl = ssl
            SMTP.DeliveryMethod = SmtpDeliveryMethod.Network

            Try
                'Puerto que deberia funcionar, el que se tipea en la interfaz como prueba
                SMTP.Port = port

                'Se crea el mensaje de prueba
                Dim EmailMsg As New MailMessage()
                EmailMsg.From = New MailAddress(email)
                EmailMsg.To.Add(para)
                EmailMsg.Subject = subject
                EmailMsg.Body = body
                EmailMsg.IsBodyHtml = False

                'Se envia el correo
                SMTP.Send(EmailMsg)
                lb_result.Text = "Se ha mandado el correo de forma exitosa para el puerto " & port
                lb_result.ForeColor = Color.Green
            Catch smtpex As Exception When TypeOf smtpex Is SmtpException OrElse TypeOf smtpex Is WebException
                lb_result.Text = "Puerto " & port & " falló: " & smtpex.Message
                lb_result.ForeColor = Color.Red
            End Try
        Catch ex As Exception
            lb_result.Text = "Error general: " & ex.Message
            lb_result.ForeColor = Color.Red
        End Try
    End Sub

    Private Sub EnviarCorreoAlternativo(ByVal email As String, ByVal password As String, ByVal host As String,
                                    ByVal ssl As Boolean, ByVal para As String,
                                    ByVal subject As String, ByVal body As String)
        Try
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12
            Dim SMTP As New SmtpClient(host)
            Dim credenciales As New NetworkCredential(email, password)
            Dim resultado As New StringBuilder()

            ' Configura el SMTP
            SMTP.UseDefaultCredentials = False
            SMTP.Credentials = credenciales
            SMTP.EnableSsl = ssl
            SMTP.DeliveryMethod = SmtpDeliveryMethod.Network

            AppendResultado("Iniciando prueba de puertos...", Color.Black)

            ' Revisar puertos y probar cual está habilitado
            Dim ports() As Integer = {587, 465, 25, 2525}

            For Each port As Integer In ports
                Try
                    SMTP.Port = port

                    AppendResultado("Probando puerto " & port & "...", Color.Blue)

                    ' Crea mensaje
                    Dim EmailMsg As New MailMessage()
                    EmailMsg.From = New MailAddress(email)
                    EmailMsg.To.Add(para)
                    EmailMsg.Subject = subject
                    EmailMsg.Body = body
                    EmailMsg.IsBodyHtml = False

                    ' Enviar correo
                    SMTP.Send(EmailMsg)
                    AppendResultado("¡Éxito! Correo enviado por puerto " & port, Color.Green)
                    Exit For

                Catch smtpex As Exception When TypeOf smtpex Is SmtpException OrElse TypeOf smtpex Is WebException
                    AppendResultado("Puerto " & port & " falló: " & smtpex.Message, Color.Red)
                End Try
            Next

            AppendResultado("Prueba de puertos completada.", Color.Black)

        Catch ex As Exception
            AppendResultado("Error general: " & ex.Message, Color.Red)
        End Try
    End Sub

    Public Sub VerificarConexion(ByVal host As String, ByVal port As Integer)
        Try
            Using client As New TcpClient()
                Dim result As IAsyncResult = client.BeginConnect(host, port, Nothing, Nothing)

                If result.AsyncWaitHandle.WaitOne(TimeSpan.FromSeconds(5)) Then
                    client.EndConnect(result)
                    lb_result.Text = "Conexion exitosa al puerto " & port
                    lb_result.ForeColor = Color.Green
                Else
                    lb_result.Text = "Timeout - puerto " & port & " bloqueado"
                    lb_result.ForeColor = Color.Green
                End If
            End Using
        Catch ex As Exception
            lb_result.Text = "Error de conexion: " & ex.Message
            lb_result.ForeColor = Color.Red
        End Try
    End Sub

    ' Función auxiliar para agregar texto y hacer scroll automático
    Private Sub AppendResultado(ByVal mensaje As String, ByVal color As Color)
        If lb_result.Text.Length > 0 Then
            lb_result.Text += Environment.NewLine
        End If
        lb_result.Text += mensaje
        lb_result.ForeColor = color
        ScrollToEnd()
        lb_result.Refresh()
        Application.DoEvents()
    End Sub

    ' Función auxiliar para hacer scroll al final del TextBox
    Private Sub ScrollToEnd()
        lb_result.SelectionStart = lb_result.Text.Length
        lb_result.ScrollToCaret()
    End Sub

    Private Function ValidarEmail(ByVal email As String) As Boolean
        If String.IsNullOrWhiteSpace(email) Then
            Return False
        End If

        ' Patrón de expresión regular para validar emails
        Dim patron As String = "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"

        Return Regex.IsMatch(email.Trim(), patron)
    End Function
End Class
