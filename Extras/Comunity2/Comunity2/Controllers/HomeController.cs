using Comunity2.Data;
using Comunity2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Comunity2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext db;
        public HomeController(ILogger<HomeController> logger,ApplicationDbContext _applicationDbContext)
        {
            _logger = logger;
            db=_applicationDbContext;
        }

        public IActionResult Index()
        {
            var Post=db.posts.ToList();

            return View(Post);
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
