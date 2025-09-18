<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProbarCorreosVW
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
        Me.lb_titulo = New System.Windows.Forms.Label()
        Me.lb_correo_de = New System.Windows.Forms.Label()
        Me.lb_password = New System.Windows.Forms.Label()
        Me.lb_host = New System.Windows.Forms.Label()
        Me.lb_ssl = New System.Windows.Forms.Label()
        Me.lb_puerto = New System.Windows.Forms.Label()
        Me.tx_correo_de = New System.Windows.Forms.TextBox()
        Me.pw_password = New System.Windows.Forms.TextBox()
        Me.tx_host = New System.Windows.Forms.TextBox()
        Me.rb_ssl_1 = New System.Windows.Forms.RadioButton()
        Me.rb_ssl_2 = New System.Windows.Forms.RadioButton()
        Me.tx_puerto = New System.Windows.Forms.TextBox()
        Me.bt_enviar = New System.Windows.Forms.Button()
        Me.bt_enviar_alternativo = New System.Windows.Forms.Button()
        Me.bt_enviar_api = New System.Windows.Forms.Button()
        Me.bt_enviar_timeout = New System.Windows.Forms.Button()
        Me.bt_verificar = New System.Windows.Forms.Button()
        Me.lb_correo_para = New System.Windows.Forms.Label()
        Me.lb_asunto = New System.Windows.Forms.Label()
        Me.tx_correo_para = New System.Windows.Forms.TextBox()
        Me.tx_asunto = New System.Windows.Forms.TextBox()
        Me.lb_cuerpo = New System.Windows.Forms.Label()
        Me.tx_cuerpo = New System.Windows.Forms.TextBox()
        Me.lb_result = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lb_titulo
        '
        Me.lb_titulo.AutoSize = True
        Me.lb_titulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_titulo.Location = New System.Drawing.Point(193, 9)
        Me.lb_titulo.Name = "lb_titulo"
        Me.lb_titulo.Size = New System.Drawing.Size(199, 31)
        Me.lb_titulo.TabIndex = 0
        Me.lb_titulo.Text = "Probar Correos"
        '
        'lb_correo_de
        '
        Me.lb_correo_de.AutoSize = True
        Me.lb_correo_de.Location = New System.Drawing.Point(137, 72)
        Me.lb_correo_de.Name = "lb_correo_de"
        Me.lb_correo_de.Size = New System.Drawing.Size(21, 13)
        Me.lb_correo_de.TabIndex = 1
        Me.lb_correo_de.Text = "De"
        '
        'lb_password
        '
        Me.lb_password.AutoSize = True
        Me.lb_password.Location = New System.Drawing.Point(137, 99)
        Me.lb_password.Name = "lb_password"
        Me.lb_password.Size = New System.Drawing.Size(61, 13)
        Me.lb_password.TabIndex = 2
        Me.lb_password.Text = "Contraseña"
        '
        'lb_host
        '
        Me.lb_host.AutoSize = True
        Me.lb_host.Location = New System.Drawing.Point(137, 128)
        Me.lb_host.Name = "lb_host"
        Me.lb_host.Size = New System.Drawing.Size(29, 13)
        Me.lb_host.TabIndex = 3
        Me.lb_host.Text = "Host"
        '
        'lb_ssl
        '
        Me.lb_ssl.AutoSize = True
        Me.lb_ssl.Location = New System.Drawing.Point(137, 159)
        Me.lb_ssl.Name = "lb_ssl"
        Me.lb_ssl.Size = New System.Drawing.Size(27, 13)
        Me.lb_ssl.TabIndex = 4
        Me.lb_ssl.Text = "SSL"
        '
        'lb_puerto
        '
        Me.lb_puerto.AutoSize = True
        Me.lb_puerto.Location = New System.Drawing.Point(137, 182)
        Me.lb_puerto.Name = "lb_puerto"
        Me.lb_puerto.Size = New System.Drawing.Size(38, 13)
        Me.lb_puerto.TabIndex = 5
        Me.lb_puerto.Text = "Puerto"
        '
        'tx_correo_de
        '
        Me.tx_correo_de.Location = New System.Drawing.Point(219, 69)
        Me.tx_correo_de.Name = "tx_correo_de"
        Me.tx_correo_de.Size = New System.Drawing.Size(193, 20)
        Me.tx_correo_de.TabIndex = 6
        '
        'pw_password
        '
        Me.pw_password.Location = New System.Drawing.Point(219, 96)
        Me.pw_password.Name = "pw_password"
        Me.pw_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.pw_password.Size = New System.Drawing.Size(193, 20)
        Me.pw_password.TabIndex = 7
        '
        'tx_host
        '
        Me.tx_host.Location = New System.Drawing.Point(219, 125)
        Me.tx_host.Name = "tx_host"
        Me.tx_host.Size = New System.Drawing.Size(193, 20)
        Me.tx_host.TabIndex = 8
        '
        'rb_ssl_1
        '
        Me.rb_ssl_1.AutoSize = True
        Me.rb_ssl_1.Location = New System.Drawing.Point(219, 157)
        Me.rb_ssl_1.Name = "rb_ssl_1"
        Me.rb_ssl_1.Size = New System.Drawing.Size(34, 17)
        Me.rb_ssl_1.TabIndex = 9
        Me.rb_ssl_1.TabStop = True
        Me.rb_ssl_1.Text = "Si"
        Me.rb_ssl_1.UseVisualStyleBackColor = True
        '
        'rb_ssl_2
        '
        Me.rb_ssl_2.AutoSize = True
        Me.rb_ssl_2.Location = New System.Drawing.Point(259, 157)
        Me.rb_ssl_2.Name = "rb_ssl_2"
        Me.rb_ssl_2.Size = New System.Drawing.Size(39, 17)
        Me.rb_ssl_2.TabIndex = 10
        Me.rb_ssl_2.TabStop = True
        Me.rb_ssl_2.Text = "No"
        Me.rb_ssl_2.UseVisualStyleBackColor = True
        '
        'tx_puerto
        '
        Me.tx_puerto.Location = New System.Drawing.Point(219, 179)
        Me.tx_puerto.Name = "tx_puerto"
        Me.tx_puerto.Size = New System.Drawing.Size(193, 20)
        Me.tx_puerto.TabIndex = 11
        '
        'bt_enviar
        '
        Me.bt_enviar.Location = New System.Drawing.Point(86, 376)
        Me.bt_enviar.Name = "bt_enviar"
        Me.bt_enviar.Size = New System.Drawing.Size(75, 35)
        Me.bt_enviar.TabIndex = 12
        Me.bt_enviar.Text = "Enviar"
        Me.bt_enviar.UseVisualStyleBackColor = True
        '
        'bt_enviar_alternativo
        '
        Me.bt_enviar_alternativo.Location = New System.Drawing.Point(168, 375)
        Me.bt_enviar_alternativo.Name = "bt_enviar_alternativo"
        Me.bt_enviar_alternativo.Size = New System.Drawing.Size(85, 36)
        Me.bt_enviar_alternativo.TabIndex = 13
        Me.bt_enviar_alternativo.Text = "Enviar (Alternativo)"
        Me.bt_enviar_alternativo.UseVisualStyleBackColor = True
        '
        'bt_enviar_api
        '
        Me.bt_enviar_api.Location = New System.Drawing.Point(259, 375)
        Me.bt_enviar_api.Name = "bt_enviar_api"
        Me.bt_enviar_api.Size = New System.Drawing.Size(75, 36)
        Me.bt_enviar_api.TabIndex = 14
        Me.bt_enviar_api.Text = "Enviar (API)"
        Me.bt_enviar_api.UseVisualStyleBackColor = True
        '
        'bt_enviar_timeout
        '
        Me.bt_enviar_timeout.Location = New System.Drawing.Point(340, 375)
        Me.bt_enviar_timeout.Name = "bt_enviar_timeout"
        Me.bt_enviar_timeout.Size = New System.Drawing.Size(75, 36)
        Me.bt_enviar_timeout.TabIndex = 15
        Me.bt_enviar_timeout.Text = "Enviar (Timeout)"
        Me.bt_enviar_timeout.UseVisualStyleBackColor = True
        '
        'bt_verificar
        '
        Me.bt_verificar.Location = New System.Drawing.Point(421, 376)
        Me.bt_verificar.Name = "bt_verificar"
        Me.bt_verificar.Size = New System.Drawing.Size(75, 35)
        Me.bt_verificar.TabIndex = 16
        Me.bt_verificar.Text = "Verificar Conexion"
        Me.bt_verificar.UseVisualStyleBackColor = True
        '
        'lb_correo_para
        '
        Me.lb_correo_para.AutoSize = True
        Me.lb_correo_para.Location = New System.Drawing.Point(137, 221)
        Me.lb_correo_para.Name = "lb_correo_para"
        Me.lb_correo_para.Size = New System.Drawing.Size(29, 13)
        Me.lb_correo_para.TabIndex = 18
        Me.lb_correo_para.Text = "Para"
        '
        'lb_asunto
        '
        Me.lb_asunto.AutoSize = True
        Me.lb_asunto.Location = New System.Drawing.Point(137, 256)
        Me.lb_asunto.Name = "lb_asunto"
        Me.lb_asunto.Size = New System.Drawing.Size(40, 13)
        Me.lb_asunto.TabIndex = 20
        Me.lb_asunto.Text = "Asunto"
        '
        'tx_correo_para
        '
        Me.tx_correo_para.Location = New System.Drawing.Point(219, 218)
        Me.tx_correo_para.Name = "tx_correo_para"
        Me.tx_correo_para.Size = New System.Drawing.Size(193, 20)
        Me.tx_correo_para.TabIndex = 19
        '
        'tx_asunto
        '
        Me.tx_asunto.Location = New System.Drawing.Point(219, 253)
        Me.tx_asunto.Name = "tx_asunto"
        Me.tx_asunto.Size = New System.Drawing.Size(193, 20)
        Me.tx_asunto.TabIndex = 21
        '
        'lb_cuerpo
        '
        Me.lb_cuerpo.AutoSize = True
        Me.lb_cuerpo.Location = New System.Drawing.Point(137, 310)
        Me.lb_cuerpo.Name = "lb_cuerpo"
        Me.lb_cuerpo.Size = New System.Drawing.Size(41, 13)
        Me.lb_cuerpo.TabIndex = 22
        Me.lb_cuerpo.Text = "Cuerpo"
        '
        'tx_cuerpo
        '
        Me.tx_cuerpo.Location = New System.Drawing.Point(219, 293)
        Me.tx_cuerpo.Multiline = True
        Me.tx_cuerpo.Name = "tx_cuerpo"
        Me.tx_cuerpo.Size = New System.Drawing.Size(193, 47)
        Me.tx_cuerpo.TabIndex = 23
        '
        'lb_result
        '
        Me.lb_result.BackColor = System.Drawing.SystemColors.Window
        Me.lb_result.Location = New System.Drawing.Point(12, 417)
        Me.lb_result.Multiline = True
        Me.lb_result.Name = "lb_result"
        Me.lb_result.ReadOnly = True
        Me.lb_result.Size = New System.Drawing.Size(547, 139)
        Me.lb_result.TabIndex = 24
        '
        'ProbarCorreosVW
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(571, 568)
        Me.Controls.Add(Me.lb_result)
        Me.Controls.Add(Me.tx_cuerpo)
        Me.Controls.Add(Me.lb_cuerpo)
        Me.Controls.Add(Me.tx_asunto)
        Me.Controls.Add(Me.lb_asunto)
        Me.Controls.Add(Me.tx_correo_para)
        Me.Controls.Add(Me.lb_correo_para)
        Me.Controls.Add(Me.bt_verificar)
        Me.Controls.Add(Me.bt_enviar_timeout)
        Me.Controls.Add(Me.bt_enviar_api)
        Me.Controls.Add(Me.bt_enviar_alternativo)
        Me.Controls.Add(Me.bt_enviar)
        Me.Controls.Add(Me.tx_puerto)
        Me.Controls.Add(Me.rb_ssl_2)
        Me.Controls.Add(Me.rb_ssl_1)
        Me.Controls.Add(Me.tx_host)
        Me.Controls.Add(Me.pw_password)
        Me.Controls.Add(Me.tx_correo_de)
        Me.Controls.Add(Me.lb_puerto)
        Me.Controls.Add(Me.lb_ssl)
        Me.Controls.Add(Me.lb_host)
        Me.Controls.Add(Me.lb_password)
        Me.Controls.Add(Me.lb_correo_de)
        Me.Controls.Add(Me.lb_titulo)
        Me.Name = "ProbarCorreosVW"
        Me.Text = "Probar Correos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lb_titulo As Label
    Friend WithEvents lb_correo_de As Label
    Friend WithEvents lb_password As Label
    Friend WithEvents lb_host As Label
    Friend WithEvents lb_ssl As Label
    Friend WithEvents lb_puerto As Label
    Friend WithEvents tx_correo_de As TextBox
    Friend WithEvents pw_password As TextBox
    Friend WithEvents tx_host As TextBox
    Friend WithEvents rb_ssl_1 As RadioButton
    Friend WithEvents rb_ssl_2 As RadioButton
    Friend WithEvents tx_puerto As TextBox
    Friend WithEvents bt_enviar As Button
    Friend WithEvents bt_enviar_alternativo As Button
    Friend WithEvents bt_enviar_api As Button
    Friend WithEvents bt_enviar_timeout As Button
    Friend WithEvents bt_verificar As Button
    Friend WithEvents lb_correo_para As Label
    Friend WithEvents lb_asunto As Label
    Friend WithEvents tx_correo_para As TextBox
    Friend WithEvents tx_asunto As TextBox
    Friend WithEvents lb_cuerpo As Label
    Friend WithEvents tx_cuerpo As TextBox
    Friend WithEvents lb_result As TextBox
End Class
