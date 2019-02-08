using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SeniorProject.Controllers
{
    public class LogHistoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}