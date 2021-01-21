'CODE CONVENTIONS " SUB PROCEDURE (BYval EFUWEHJ aS iNTEGER){{{{{}}}}}}
Imports System.Net.Mail
Public Class Form1
    Dim header As String
    Dim message As String

    'Email sending sub didn't work because school blocks sending of emails

    Public Sub EmailSend(smtpServer As Object) '(Dim smtpServer As New SmtpClient)
        'Dim mail As New MailMessage()
        'smtpServer.Credentials = New Net.NetworkCredential("EMAIL_ADDRESS", "PASSWORD")
        'smtpServer.Port = 587
        'smtpServer.Host = "smtp.gmail.com"
        'smtpServer.EnableSsl = True
        'mail = New MailMessage()
        'mail.From = New MailAddress("EMAIL_ADDRESS", "HEADER")
        'mail.To.Add("REDACTED")
        'mail.Subject = "Info"
        'mail.Body = txtHeader.Text & txtmessage.Text
        'smtpServer.Send(mail)
    End Sub

    Private Sub Check_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        'Call EmailSend(Dim smtpServer As New SmtpClient()
        Me.txtHeader.Text = header
        Me.txtMessage.Text = message
        Timer1.Enabled = True
    End Sub

    Private Sub TextBox4_Click(sender As Object, e As EventArgs)
        Me.txtMessage.Text = Nothing
        Me.txtMessage.ForeColor = Color.Black
    End Sub
    'This timer smoothly animates the fake progress bar
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value < 1000 Then

            ProgressBar1.Value = ProgressBar1.Value + 10
            labelComplete.Visible = True
            labelComplete.Text = ProgressBar1.Value / 10 & "% Completed"

            If ProgressBar1.Value >= 1000 Then
                labelComplete.Visible = False
                Timer2.Enabled = True
            End If
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        labelComplete.Text = "Completed"
        Timer1.Enabled = False
        labelComplete.Location = New Point(500, 105)
        If labelComplete.Visible = False Then
            Timer3.Enabled = True
            Timer2.Enabled = False
        End If
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        If labelComplete.Visible = False Then
            labelComplete.Visible = True
        Else
            labelComplete.Visible = False
        End If
    End Sub

    Private Sub Label1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles Label1.MouseDoubleClick
        Application.Exit()
    End Sub

End Class
