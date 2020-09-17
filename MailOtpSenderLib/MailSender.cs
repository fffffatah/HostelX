using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailOtpSenderLib
{
    public class MailSender
    {
        //WITH ATTACHMENTS
        public void Send(string from, string fromUserName, string to, string toUserName, string subject, string plainText, string html)
        {
            var apiKey = ConfigurationManager.AppSettings.Get("sendgridApiKey");
            var client = new SendGridClient(apiKey);
            var fromBuilder = new EmailAddress(from, fromUserName);
            var subjectBuilder = subject;
            var toBuilder = new EmailAddress(to, toUserName);
            var plainTextContent = plainText;
            var htmlContent = html;
            var msg = MailHelper.CreateSingleEmail(fromBuilder, toBuilder, subjectBuilder, plainTextContent, htmlContent);
            var response = client.SendEmailAsync(msg);
        }

        //WITHOUT ATTACHEMTNS
        public void Send(string from, string fromUserName, string to, string toUserName, string subject, string plainText, string html, string attachmentFileName, byte[] attachmentContent)
        {
            var apiKey = ConfigurationManager.AppSettings.Get("sendgridApiKey");
            var client = new SendGridClient(apiKey);
            var fromBuilder = new EmailAddress(from, fromUserName);
            var subjectBuilder = subject;
            var toBuilder = new EmailAddress(to, toUserName);
            var plainTextContent = plainText;
            var htmlContent = html;
            var attachment = new Attachment();
            attachment.Content = Convert.ToBase64String(attachmentContent);
            attachment.Filename = attachmentFileName + ".pdf";
            attachment.Type = "pdf";
            attachment.Disposition = "attachment";
            var msg = MailHelper.CreateSingleEmail(fromBuilder, toBuilder, subjectBuilder, plainTextContent, htmlContent);
            msg.AddAttachment(attachment);
            var response = client.SendEmailAsync(msg);
        }
    }
}
