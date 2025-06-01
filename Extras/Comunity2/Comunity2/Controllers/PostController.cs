using Comunity2.Models;
using Comunity2.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Comunity2.Controllers
{
    public class PostController : Controller
    {
        readonly UserManager<User> _userManager;
        readonly IPostService _IpostService;
        public PostController(IPostService IpostService,UserManager<User> userManager)
        {
            _IpostService = IpostService;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public async Task< IActionResult>Add(Post p)
        {
            var user = await _userManager.GetUserAsync(User);
            if (user != null)
            {
                _IpostService.CreatePost(p, user);
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
    }
}
