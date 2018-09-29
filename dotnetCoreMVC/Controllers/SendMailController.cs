using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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