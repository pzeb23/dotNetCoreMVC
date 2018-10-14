using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using dotnetCoreMVC.Models;
using dotnetCoreMVC.Services;
using dotnetCoreMVC.Interfaces;

namespace dotnetCoreMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult SendMail([FromServices] IEmailConfiguration myEmailConfig)
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

            var myMessage = new EmailMessageModel();
           
            myMessage.ToAddresses.Add(recipient);
            myMessage.FromAddresses.Add(sender);
            myMessage.Subject = "This e-mail was sent by a machine!";
            myMessage.Content = "If you can read this, it means it worked!";

            myEmailService.Send(myMessage);
            
            return View();
        }
    }
}
