using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Portfolio3.Models;
using Portfolio3.Interfaces;
using Portfolio3.Services;

namespace Portfolio3.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Resume()
        {
            return View();
        }

        public IActionResult Portfolio()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult SendMail([FromServices] IEmailConfiguration myEmailConfig, [FromForm] string messageContent, [FromForm] string messageSubject, [FromForm] string replyAddress)
        {
            var myEmailService = new EmailService(myEmailConfig);

            var recipient = new EmailAddressModel
            {
                Address = "spotify001@o2.pl"
            };

            var sender = new EmailAddressModel
            {
                Address = "spotify002@o2.pl"
            };

            var externalSender = new EmailAddressModel
            {
                Address = replyAddress
            };

            var myMessage = new EmailMessageModel();

            myMessage.ToAddresses.Add(recipient);
            myMessage.FromAddresses.Add(sender);

            myMessage.Subject = messageSubject;
            myMessage.Content = messageContent + " sent from: " + replyAddress;
            myMessage.FromAddresses.Add(externalSender);

            myEmailService.Send(myMessage);

            return View();
        }
    }
}
