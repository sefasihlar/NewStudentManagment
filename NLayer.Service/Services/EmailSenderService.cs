using MailKit.Security;
using Microsoft.Extensions.Configuration;
using MimeKit;
using NLayer.Core.Services;
using System.Net.Mail;
using SmtpClient = MailKit.Net.Smtp.SmtpClient;

namespace NLayer.Service.Services
{
    public class EmailSenderService : IEmailSenderService
    {
        readonly IConfiguration _configuration;

        public EmailSenderService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task SendEmailAsync(string to, string subject, string body, bool isBodyHtml = true)
        {
            await SendEmailAsync(new[] { to }, subject, body, isBodyHtml);
        }

        public async Task SendEmailAsync(string[] tos, string subject, string body, bool isBodyHtml = true)
        {

            using var mail = new MailMessage();
            mail.IsBodyHtml = isBodyHtml;
            foreach (var to in tos)
                mail.To.Add(to);
            mail.Subject = subject;
            mail.Body = body;
            mail.From = new MailAddress(_configuration["Mail:Username"], "Meta Akdeniz", System.Text.Encoding.UTF8);

            using var smpt = new SmtpClient();

            smpt.Connect(_configuration["Mail:Host"], 465, SecureSocketOptions.SslOnConnect);

            // Kullanıcı adınızı ve şifrenizi girin.
            smpt.Authenticate("destek@metaakdeniz.com.tr", "MutluBaharat.12");

            smpt.Send((MimeMessage)mail);

            smpt.Disconnect(true);

        }
    }
}
