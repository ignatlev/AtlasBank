using MailKit.Net.Smtp;
using MimeKit;
using System.Configuration;

public class EmailService
{
    private const string SmtpHost = "smtp.gmail.com";
    private const int SmtpPort = 587;
    private const string SmtpUser = "atlas.support.team@gmail.com";
    private static readonly string SmtpPass = ConfigurationManager.AppSettings["smtp-password"]!;

    public void SendResetCode(string toEmail, string code)
    {
        var message = new MimeMessage();
        message.From.Add(new MailboxAddress("Atlas Support Team", SmtpUser));
        message.To.Add(MailboxAddress.Parse(toEmail));
        message.Subject = "Password Reset Code";
        message.Body = new TextPart("plain")
        {
            Text = string.Format("Your password reset code is: {0}\n\nExpires in 10 minutes.", code)
        };

        using var client = new SmtpClient();
        client.Connect(SmtpHost, SmtpPort, MailKit.Security.SecureSocketOptions.StartTls);
        client.Authenticate(SmtpUser, SmtpPass);
        client.Send(message);
        client.Disconnect(true);
    }
}