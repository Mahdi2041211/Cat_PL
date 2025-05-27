using Comunity2.Data;
using Comunity2.Models;
using jobs.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Comunity2.Controllers
{
    public class HomeController : BaseController
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(SessionManger sessionManger, ApplicationDbContext applicationDbContext) : base(sessionManger, applicationDbContext)
        {
        }

        public IActionResult Index()
        {
                
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
    }
}
