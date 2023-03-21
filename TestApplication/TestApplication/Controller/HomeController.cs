using Microsoft.AspNetCore.Mvc;
using System;

namespace TestApplication.Controller
{
    public class HomeController : ControllerBase
    {
        public IActionResult TestPage()
        {
            return View();
        }

        private IActionResult View()
        {
            throw new NotImplementedException();
        }
    }
}
