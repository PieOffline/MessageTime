Imports System.Net.Sockets
Imports System.Threading
Imports System.Net
Imports System.Text

Public Class Form1
    Private server As TcpListener
    Private client As TcpClient
    Private stream As NetworkStream
    Private serverThread As Thread
    Private isServerRunning As Boolean = False

    ' Start Server Button Click
    Private Sub btnStartServer_Click(sender As Object, e As EventArgs) Handles btnStartServer.Click
        Try
            Dim port As Integer = 5000
            server = New TcpListener(IPAddress.Any, port)
            server.Start()
            isServerRunning = True
            serverThread = New Thread(AddressOf ServerListen)
            serverThread.Start()
            txtMessagesOld.AppendText("Server started on port " & port & vbCrLf)

            Dim host = Dns.GetHostEntry(Dns.GetHostName())
            For Each ip In host.AddressList
                If ip.AddressFamily = AddressFamily.InterNetwork Then
                    IPDisplayBox.Text = ip.ToString()
                End If
            Next
            ProgressBarOnline.Style = ProgressBarStyle.Marquee

        Catch ex As Exception
            MessageBox.Show("Error starting server: " & ex.Message)
        End Try
    End Sub

    ' Server Listening Logic
    Private Sub ServerListen()
        Try
            While isServerRunning
                Dim client As TcpClient = server.AcceptTcpClient()
                Dim stream As NetworkStream = client.GetStream()
                Dim buffer(1024) As Byte
                Dim bytesRead As Integer = stream.Read(buffer, 0, buffer.Length)
                Dim message As String = Encoding.ASCII.GetString(buffer, 0, bytesRead)
                Invoke(Sub() txtMessages.AppendText("Client: " & message & vbCrLf))
                client.Close()
            End While
        Catch ex As Exception
            Invoke(Sub() txtMessagesOld.AppendText("Server error: " & ex.Message & vbCrLf))
        End Try
    End Sub

    ' Connect as Client Button Click
    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        Try
            Dim serverIP As String = txtServerIP.Text
            Dim port As Integer = 5000
            client = New TcpClient(serverIP, port)
            stream = client.GetStream()
            txtMessagesOld.AppendText("Connected to server at " & serverIP & vbCrLf)
            ProgressBar.PerformStep()
            StatusTxt.Text = "Connected!"
        Catch ex As Exception
            MessageBox.Show("Error connecting to server: " & ex.Message)
        End Try
    End Sub

    ' Send Message Button Click
    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        Try
            If stream IsNot Nothing Then
                Dim message As String = txtMessage.Text
                Dim data As Byte() = Encoding.ASCII.GetBytes(message)
                stream.Write(data, 0, data.Length)
                txtMessages.AppendText("You: " & message & vbCrLf)
            Else
                MessageBox.Show("Not connected to a server.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error sending message: " & ex.Message)
        End Try
    End Sub

    ' Stop Server Button Click
    Private Sub btnStopServer_Click(sender As Object, e As EventArgs) Handles btnStopServer.Click
        Try
            isServerRunning = False
            server.Stop()
            txtMessagesOld.AppendText("Server stopped." & vbCrLf)
        Catch ex As Exception
            MessageBox.Show("Error stopping server: " & ex.Message)
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub StatusTxt_Click(sender As Object, e As EventArgs) Handles StatusTxt.Click

    End Sub
End Class
