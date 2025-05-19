<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.txtServerIP = New System.Windows.Forms.TextBox()
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.StatusTxt = New System.Windows.Forms.Label()
        Me.RecieveBtn = New System.Windows.Forms.Button()
        Me.ProgressBar = New System.Windows.Forms.ProgressBar()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtMessage = New System.Windows.Forms.TextBox()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.btnStartServer = New System.Windows.Forms.Button()
        Me.ProgressBarOnline = New System.Windows.Forms.ProgressBar()
        Me.btnStopServer = New System.Windows.Forms.Button()
        Me.txtMessagesOld = New System.Windows.Forms.TextBox()
        Me.IPDisplayBox = New System.Windows.Forms.TextBox()
        Me.txtMessages = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtServerIP
        '
        Me.txtServerIP.Location = New System.Drawing.Point(12, 30)
        Me.txtServerIP.Name = "txtServerIP"
        Me.txtServerIP.Size = New System.Drawing.Size(100, 20)
        Me.txtServerIP.TabIndex = 0
        '
        'btnConnect
        '
        Me.btnConnect.BackColor = System.Drawing.Color.DarkOrange
        Me.btnConnect.Location = New System.Drawing.Point(118, 27)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(100, 23)
        Me.btnConnect.TabIndex = 1
        Me.btnConnect.Text = "Let's Go!"
        Me.btnConnect.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Address"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Status:"
        '
        'StatusTxt
        '
        Me.StatusTxt.AutoSize = True
        Me.StatusTxt.Location = New System.Drawing.Point(61, 69)
        Me.StatusTxt.Name = "StatusTxt"
        Me.StatusTxt.Size = New System.Drawing.Size(78, 13)
        Me.StatusTxt.TabIndex = 5
        Me.StatusTxt.Text = "No Connection"
        '
        'RecieveBtn
        '
        Me.RecieveBtn.BackColor = System.Drawing.Color.DodgerBlue
        Me.RecieveBtn.Location = New System.Drawing.Point(143, 64)
        Me.RecieveBtn.Name = "RecieveBtn"
        Me.RecieveBtn.Size = New System.Drawing.Size(75, 22)
        Me.RecieveBtn.TabIndex = 6
        Me.RecieveBtn.Text = "Recieve"
        Me.RecieveBtn.UseVisualStyleBackColor = False
        Me.RecieveBtn.Visible = False
        '
        'ProgressBar
        '
        Me.ProgressBar.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.ProgressBar.Location = New System.Drawing.Point(224, 27)
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Size = New System.Drawing.Size(100, 23)
        Me.ProgressBar.Step = 100
        Me.ProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgressBar.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Inbound"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 215)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Outbound"
        '
        'txtMessage
        '
        Me.txtMessage.Location = New System.Drawing.Point(18, 240)
        Me.txtMessage.Multiline = True
        Me.txtMessage.Name = "txtMessage"
        Me.txtMessage.Size = New System.Drawing.Size(300, 60)
        Me.txtMessage.TabIndex = 11
        '
        'btnSend
        '
        Me.btnSend.BackColor = System.Drawing.Color.Violet
        Me.btnSend.Location = New System.Drawing.Point(15, 306)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(75, 22)
        Me.btnSend.TabIndex = 12
        Me.btnSend.Text = "Over"
        Me.btnSend.UseVisualStyleBackColor = False
        '
        'btnStartServer
        '
        Me.btnStartServer.Location = New System.Drawing.Point(705, 19)
        Me.btnStartServer.Name = "btnStartServer"
        Me.btnStartServer.Size = New System.Drawing.Size(75, 23)
        Me.btnStartServer.TabIndex = 13
        Me.btnStartServer.Text = "Go Online"
        Me.btnStartServer.UseVisualStyleBackColor = True
        '
        'ProgressBarOnline
        '
        Me.ProgressBarOnline.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.ProgressBarOnline.Location = New System.Drawing.Point(696, 12)
        Me.ProgressBarOnline.Name = "ProgressBarOnline"
        Me.ProgressBarOnline.Size = New System.Drawing.Size(92, 38)
        Me.ProgressBarOnline.Step = 1
        Me.ProgressBarOnline.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgressBarOnline.TabIndex = 14
        '
        'btnStopServer
        '
        Me.btnStopServer.Location = New System.Drawing.Point(705, 69)
        Me.btnStopServer.Name = "btnStopServer"
        Me.btnStopServer.Size = New System.Drawing.Size(75, 23)
        Me.btnStopServer.TabIndex = 15
        Me.btnStopServer.Text = "Go Offline"
        Me.btnStopServer.UseVisualStyleBackColor = True
        '
        'txtMessagesOld
        '
        Me.txtMessagesOld.Location = New System.Drawing.Point(688, 98)
        Me.txtMessagesOld.Multiline = True
        Me.txtMessagesOld.Name = "txtMessagesOld"
        Me.txtMessagesOld.Size = New System.Drawing.Size(100, 35)
        Me.txtMessagesOld.TabIndex = 16
        '
        'IPDisplayBox
        '
        Me.IPDisplayBox.Location = New System.Drawing.Point(688, 149)
        Me.IPDisplayBox.Multiline = True
        Me.IPDisplayBox.Name = "IPDisplayBox"
        Me.IPDisplayBox.Size = New System.Drawing.Size(100, 35)
        Me.IPDisplayBox.TabIndex = 17
        '
        'txtMessages
        '
        Me.txtMessages.Location = New System.Drawing.Point(18, 155)
        Me.txtMessages.Multiline = True
        Me.txtMessages.Name = "txtMessages"
        Me.txtMessages.ReadOnly = True
        Me.txtMessages.Size = New System.Drawing.Size(300, 60)
        Me.txtMessages.TabIndex = 18
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtMessages)
        Me.Controls.Add(Me.IPDisplayBox)
        Me.Controls.Add(Me.txtMessagesOld)
        Me.Controls.Add(Me.btnStopServer)
        Me.Controls.Add(Me.btnStartServer)
        Me.Controls.Add(Me.ProgressBarOnline)
        Me.Controls.Add(Me.btnSend)
        Me.Controls.Add(Me.txtMessage)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ProgressBar)
        Me.Controls.Add(Me.RecieveBtn)
        Me.Controls.Add(Me.StatusTxt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnConnect)
        Me.Controls.Add(Me.txtServerIP)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtServerIP As TextBox
    Friend WithEvents btnConnect As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents StatusTxt As Label
    Friend WithEvents RecieveBtn As Button
    Friend WithEvents ProgressBar As ProgressBar
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtMessage As TextBox
    Friend WithEvents btnSend As Button
    Friend WithEvents btnStartServer As Button
    Friend WithEvents ProgressBarOnline As ProgressBar
    Friend WithEvents btnStopServer As Button
    Friend WithEvents txtMessagesOld As TextBox
    Friend WithEvents IPDisplayBox As TextBox
    Friend WithEvents txtMessages As TextBox
End Class
