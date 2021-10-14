using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_Asp.Net_FIA35_SimpleAdder.Controllers
{

    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index(int inpWert1, int inpWert2, string inpLog, string btnSubmit)
        {
            if (btnSubmit == "Add")
            {
                ViewBag.Ergebnis = inpWert1 + inpWert2;
                ViewBag.LogString = inpLog + inpWert1 + " + " + inpWert2 + "\n";
            }
            if (btnSubmit == "ShowLog")
            {
                ViewBag.ShowLog = true;                
            }

            ViewBag.ShowLog = false;

            return View();
        }

        [HttpPost]
        public IActionResult Index()
        {            

            return View();
        }

    }
}
