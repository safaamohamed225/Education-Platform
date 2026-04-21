using EduSpark.Core.Models;
using Microsoft.Extensions.Configuration;
using SendGrid;
using SendGrid.Helpers.Mail;
using System.Net.Mail;

namespace EduSpark.Service
{
    public interface IEmailNotification
    {
        Task<Response> SendEmailForContactUs(ContactMessage contactMessage);
    }

    public class EmailNotification : IEmailNotification
    {
        private readonly IConfiguration configuration;

        public EmailNotification(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public Task<Response> SendEmailForContactUs(ContactMessage contactMessage)
        {
            throw new NotImplementedException();
        }

        private string GetEmailContent(ContactMessage contactMessage)
        {

            return $$"""
                    <!DOCTYPE html>
                    <html>
                    <head>
                        <meta charset=""UTF-8"">
                        <title>An enquiry received  - {{contactMessage.Subject}}</title>
                    </head>
                    <body>                        
                        <p>Dear LearnSmartCoding</p>
                        <p>You have received an enquiry from a user and the details as follows.</p>
                    
                        <p><strong>Message details</strong></p>
                        <ul>
                            <li>User Name: {{contactMessage.Name}}</li>
                            <li>User Email: {{contactMessage.Email}}</li>
                    <li>Subject: {{contactMessage.Subject}}</li>
                    <li>Message: {{contactMessage.Message}}</li>
                        </ul>
                    
                    
                        <p><strong>Warm regards,</strong></p>
                        <p>LearnSmartCoding [Automated]</p>
                    </body>
                    </html>                    
                    """;
        }
    }
}