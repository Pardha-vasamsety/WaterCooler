using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Preferences.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Preferences.Controllers
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
            var webClient = new WebClient();
            var json = webClient.DownloadString(@"C:\Work\Projects\Watercooler\Development\Data\preferences.json");
            var preferences = JsonConvert.DeserializeObject<UserPreferences>(json);
            //SelectList sl = new SelectList(preferences.workingHoursTo, "id", "Name", 1);
            //TempData["WorkingHoursTo"] = sl;
            //TempData.Keep();
            return View(preferences);
            
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
