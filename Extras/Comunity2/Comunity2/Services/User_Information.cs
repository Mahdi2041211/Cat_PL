using Comunity2.Data;
using Comunity2.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Comunity2.Services.UserService
{
    public class User_Information
    {

        readonly UserManager<User> _userManager;
        readonly ApplicationDbContext _context;
        public User_Information(ApplicationDbContext context, UserManager<User> userManager)
        {
            _userManager = userManager;
            _context = context;
        }
        public async Task<List<Post>> GettAll_Post_For_User(User user)
        {
            var Posts = await _context.posts.Where(u => u.User_Id == user.Id).ToListAsync();
            return Posts;
        }

        








        





    }
}
