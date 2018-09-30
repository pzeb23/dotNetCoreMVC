using Microsoft.AspNetCore.Mvc;

namespace dotnetCoreMVC.Controllers
{
    public class SendMailController : Controller
    {
        public IActionResult SendMail()
        {
            return View();
        }
    }
}