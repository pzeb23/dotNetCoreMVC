using dotnetCoreMVC.Interfaces;
using dotnetCoreMVC.Models;
using System;
using System.Collections.Generic;

namespace dotnetCoreMVC.Services
{
    public class EmailService : IEmailService
    {
        private readonly IEmailConfiguration _emailConfiguration;

        public EmailService(IEmailConfiguration emailConfiguration)
        {
            _emailConfiguration = emailConfiguration;
        }

        public List<EmailMessageModel> ReceiveEmail(int maxCount = 10)
        {
            throw new NotImplementedException();
        }

        public void Send(EmailMessageModel emailMessage)
        {
            throw new NotImplementedException();
        }
    }
}
