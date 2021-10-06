using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebExplorerWithKendoUI.Models;

namespace WebExplorerWithKendoUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        WebExplorerContext context;

        public HomeController(ILogger<HomeController> logger, WebExplorerContext context)
        {
            _logger = logger;
            this.context = context;
        }   

        public IActionResult Index()
        {
            var all = context.Nodes.ToList();
            var x = all.Where(c => c.ParentFolder?.ID == 1).ToList();
            return View(x);
        }
        [HttpGet]
        public JsonResult LoadResult()
        {
            var all = context.Nodes.ToList();
            var x = all.Where(c => c.ParentFolder?.ID == 1).ToList();
            return Json(x);
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
    }
}
