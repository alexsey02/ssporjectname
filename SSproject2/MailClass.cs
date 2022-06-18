using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using MimeKit;
using MailKit.Net.Smtp;
using System.Threading.Tasks;



namespace SSproject2
{
    public class MailClass
    {
        public async Task SendEmail(string email, string subject, string message)//объявление метода отправки сообщения
        {
            var emailMessage = new MimeMessage();

            emailMessage.From.Add(new MailboxAddress("Студенческмй совет", "testssmpt@yandex.ru"));
            emailMessage.To.Add(new MailboxAddress("", email));
            emailMessage.Subject = subject;
            emailMessage.Body = new TextPart(MimeKit.Text.TextFormat.Html)
            {
                Text = message
            };

            using (var client = new SmtpClient())
            {
                await client.ConnectAsync("smtp.yandex.ru", 25, false);
                await client.AuthenticateAsync("testssmpt@yandex.ru", "n5bwqUwTcFWW3Ch4bCHT");
                await client.SendAsync(emailMessage);

                await client.DisconnectAsync(true);
            }
        }
        public async Task EmailTime(string emailTime, string subject, string message)//объявление метода отправки второго сообщения
        {

            var emailMessage = new MimeMessage();

            emailMessage.From.Add(new MailboxAddress("Администрация сайта", "testssmpt@yandex.ru"));
            emailMessage.To.Add(new MailboxAddress("", emailTime));
            emailMessage.Subject = subject;
            emailMessage.Body = new TextPart(MimeKit.Text.TextFormat.Html)
            {
                Text = message
            };

            using (var client = new SmtpClient())
            {
                await client.ConnectAsync("smtp.yandex.ru", 25, false);
                await client.AuthenticateAsync("testssmpt@yandex.ru", "n5bwqUwTcFWW3Ch4bCHT");
                await client.SendAsync(emailMessage);

                await client.DisconnectAsync(true);
            }
        }

    }
}
