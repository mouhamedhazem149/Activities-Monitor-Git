using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;

namespace OpsMoi.Utilities
{
    public static partial class HM_Manager
    {
        //"cid:{FacebookImage_ContentID}"
        static List<AlternateView> altViews = new List<AlternateView>() {
        new AlternateView($@"{System.AppDomain.CurrentDomain.BaseDirectory}\Resources\facebook2x.png","image/png") { ContentId = "FacebookImage_ContentID" }
        ,new AlternateView($@"{System.AppDomain.CurrentDomain.BaseDirectory}\Resources\white_down.png","image/png") { ContentId = "WhiteDownImage_ContentID" }
        , new AlternateView($@"{System.AppDomain.CurrentDomain.BaseDirectory}\Resources\logo.png","image/png") { ContentId = "LogoImage_ContentID" }
        , new AlternateView($@"{System.AppDomain.CurrentDomain.BaseDirectory}\Resources\Up_pink.png","image/png") { ContentId = "UpPinkImage_ContentID" }
        , new AlternateView($@"{System.AppDomain.CurrentDomain.BaseDirectory}\Resources\Welcome_Email.png","image/png") { ContentId = "WelcomeImage_ContentID" }
        , new AlternateView($@"{System.AppDomain.CurrentDomain.BaseDirectory}\Resources\footer.png","image/png") { ContentId = "FooterImage_ContentID" }
        , new AlternateView($@"{System.AppDomain.CurrentDomain.BaseDirectory}\Resources\Img3_2x.jpg","image/png") { ContentId = "MessageImage_ContentID" }
        };
        public static void SendEmail(string reciever, string body, string subject = "OpsMoi Corp,Inc for personal use apps, خدمة عملاء")
        {

            using (MailMessage message = new MailMessage())
            {
                message.From = new MailAddress(Program.emailSender_Email);
                message.To.Add(new MailAddress(reciever));
                message.Subject = subject; message.IsBodyHtml = true; //to make message body as html  
                message.Body = body;
                foreach (var view in altViews)
                    if (body.Contains(view.ContentId))
                    {
                        AddImageToEmail(message, view.ContentStream, view.ContentId);
                        Attachment att = new Attachment(view.ContentStream, view.ContentType);
                        att.ContentDisposition.Inline = true;
                        message.Attachments.Add(att);
                    }

                using (SmtpClient smtp = new SmtpClient())
                {
                    smtp.Port = 587; smtp.Host = "smtp.gmail.com"; //for gmail host  
                  //smtp.Port = 465; smtp.Host = "smtp.mail.yahoo.com"; //for yahoo host
                    smtp.EnableSsl = true;
                    smtp.UseDefaultCredentials = false;
                    smtp.Credentials = new NetworkCredential(Program.emailSender_Email, Program.emailSender_Password);
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtp.Send(message);
                }
            }
        }
        private static void AddImageToEmail(MailMessage mail, Stream imageStream,string imageContentID)
        {
            var imageResource = new LinkedResource(imageStream, "image/png") { ContentId = imageContentID };
            var alternateView = AlternateView.CreateAlternateViewFromString(mail.Body, mail.BodyEncoding, MediaTypeNames.Text.Html);

            alternateView.LinkedResources.Add(imageResource);
            mail.AlternateViews.Add(alternateView);
        }
    }
}
