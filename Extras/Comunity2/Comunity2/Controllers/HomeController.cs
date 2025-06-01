using Comunity2.Models;
using Comunity2.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Comunity2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        readonly IPostService _IpostService;

        public HomeController(ILogger<HomeController> logger,IPostService Ipost)
        {
           _IpostService = Ipost;
            _logger = logger;
        }

        public async Task<IActionResult>Index()
        {
            var Posts= await _IpostService.GetAllPosts();
            return View(Posts);
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
