using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using MimeKit;

namespace B.U.Z.Controllers
{
    public class EmailSendingServiceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SendEmail(Models.EmailViewModel emailModel)
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("BUZ Project", "buz.stomatologija@gmail.com"));
            message.To.Add(new MailboxAddress("", emailModel.To));
            message.Subject = emailModel.Subject;

            message.Body = new TextPart("plain")
            {
                Text = emailModel.Body
            };

            using (var client = new SmtpClient())
            {
                try
                {
                    client.Connect("smtp.gmail.com", 587, false);
                    client.AuthenticationMechanisms.Remove("XOAUTH2");
                    client.Authenticate("buz.stomatologija@gmail.com", "vmhXPuAg2hTEdw3");

                    client.Send(message);
                }
                catch
                {
                    throw;
                }
                finally
                {
                    client.Disconnect(true);
                    client.Dispose();
                }
            }

            return Redirect("/EmailSendingService");
        }
    }
}
