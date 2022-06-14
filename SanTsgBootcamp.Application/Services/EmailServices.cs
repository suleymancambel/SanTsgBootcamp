using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.Extensions.Options;
using MimeKit;
using SanTsgBootcamp.Application.Interfaces;
using SanTsgBootcamp.Application.Models;
using SanTsgBootcamp.Shared.SettingsModels;
using System;
using System.Collections.Generic;

using System.Text;
using System.Threading.Tasks;

namespace SanTsgBootcamp.Application.Services
{
    public class EmailServices : IEmailServices
    {
        private readonly EMailSettings _mailSettings;
        public EmailServices(IOptions<EMailSettings> mailSettings)
        {
            _mailSettings = mailSettings.Value;
        }

        public async Task SendMailAsync(EmailRequest emailRequest)
        {
            var builder = new BodyBuilder();
            builder.HtmlBody = emailRequest.Body;

            var email = new MimeMessage();
            email.Sender = MailboxAddress.Parse(_mailSettings.Mail);
            email.To.Add(MailboxAddress.Parse(emailRequest.ToEmail));
            email.From.Add(MailboxAddress.Parse("SanTsgProect"));
            email.Subject = emailRequest.Subject;
            email.Body = builder.ToMessageBody();

            using var smtp = new SmtpClient();
            smtp.Connect(_mailSettings.Host, _mailSettings.Port, SecureSocketOptions.StartTls);
            smtp.Authenticate(_mailSettings.Mail, _mailSettings.Password);
            await smtp.SendAsync(email);
            smtp.Disconnect(true);
        }
    }
}
