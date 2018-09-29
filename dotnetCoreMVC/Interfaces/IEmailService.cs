using dotnetCoreMVC.Models;
using System.Collections.Generic;


namespace dotnetCoreMVC.Interfaces
{
    public interface IEmailService
    {
        void Send(EmailMessageModel emailMessage);
        List<EmailMessageModel> ReceiveEmail(int maxCount = 10);
    }
}
