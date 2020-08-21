using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Portfolio3.Models
{
    public class EmailMessageModel
    {
        public EmailMessageModel()
        {
            ToAddresses = new List<EmailAddressModel>();
            FromAddresses = new List<EmailAddressModel>();
        }

        public List<EmailAddressModel> ToAddresses { get; set; }
        public List<EmailAddressModel> FromAddresses { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
    }
}
