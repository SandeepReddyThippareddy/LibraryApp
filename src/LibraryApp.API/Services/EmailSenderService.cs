using LibraryApp.API.Interfaces;
using System.Net;
using System.Net.Mail;

namespace LibraryApp.API.Services
{
    public class EmailSenderService : IEmailSenderService 
    {
        private readonly string _smtpServer;
        private readonly int _port;
        private readonly string _fromEmail;
        private readonly string _emailPassword;

        /// <summary>
        /// To send emails
        /// </summary>
        /// <param name="smtpServer"></param>
        /// <param name="port"></param>
        /// <param name="fromEmail"></param>
        /// <param name="emailPassword"></param>
        public EmailSenderService(string smtpServer, int port, string fromEmail, string emailPassword)
        {
            _smtpServer = smtpServer;
            _port = port;
            _fromEmail = fromEmail;
            _emailPassword = emailPassword;
        }

        /// <summary>
        /// Sends an email to user
        /// </summary>
        /// <param name="toEmail"></param>
        /// <param name="subject"></param>
        /// <param name="body"></param>
        /// <returns></returns>
        public async Task SendEmailAsync(string toEmail, string subject, string body)
        {
            var message = new MailMessage(_fromEmail, toEmail)
            {
                Subject = subject,
                Body = body,
                IsBodyHtml = true
            };

            using (var smtpClient = new SmtpClient(_smtpServer, _port))
            {
                smtpClient.Credentials = new NetworkCredential(_fromEmail, _emailPassword);
                smtpClient.EnableSsl = true;

                await smtpClient.SendMailAsync(message);
            }
        }
    }
}
