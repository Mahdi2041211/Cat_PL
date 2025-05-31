using Comunity2.Data;
using Comunity2.Models;
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
            var Post=db.posts.ToList();

            return View(Post);
>>>>>>> 13c9b9920fd44185efb98d925c7aedc94a1ffdee
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
