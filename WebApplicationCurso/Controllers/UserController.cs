using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplicationCurso.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Message"] = "Acesso ao Sistema";
            return View();
        }
    }
}
