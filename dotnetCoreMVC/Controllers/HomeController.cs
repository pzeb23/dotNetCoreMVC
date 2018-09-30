using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using dotnetCoreMVC.Models;
using dotnetCoreMVC.Services;
using dotnetCoreMVC.Configurations;
using System.Configuration;
using Microsoft.Extensions.Configuration;

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

        public IActionResult SendMail()
        {
            /*
            var myConfig = new EmailConfiguration();

            var myEmailService = new EmailService(myConfig);

            var recipient = new EmailAddressModel
            {
                Address = "spotify001@o2.pl"
            };

            var myMessage = new EmailMessageModel();
           
            myMessage.ToAddresses.Add(recipient);
            myMessage.Subject = "This e-mail was sent by a machine!";
            myMessage.Content = "If you can read this, it means it worked!";

            myEmailService.Send(myMessage);
            */

            return View();
        }
    }
}
