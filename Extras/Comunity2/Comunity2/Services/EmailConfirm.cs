using Microsoft.AspNetCore.Identity.UI.Services;
using System.Net.Mail;
using System.Net;

namespace Comunity2.Services
{
    public class EmailConfirm : IEmailSender
    {
        public async Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
                var Email = "jazaerefouad@gmail.com";
                var AppPassword = "ecig uyoa ycnu xdrq";
                var message = new MailMessage();
                message.From = new MailAddress(Email);
                message.To.Add(email);
                message.Subject = subject;
                message.Body = $"<html><body>{htmlMessage}</body></html>";
                message.IsBodyHtml = true;
                using (var smtpClient = new SmtpClient("smtp.gmail.com", 587))
                {
                    smtpClient.Credentials = new NetworkCredential(Email, AppPassword);
                    smtpClient.EnableSsl = true;
                    await smtpClient.SendMailAsync(message);
                }
            }
        }
    }
