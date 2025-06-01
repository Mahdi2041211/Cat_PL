using Comunity2.Models;
using Microsoft.EntityFrameworkCore;

namespace Comunity2.Data.Repositories
{
    public class PostRepository : IPostRepository
    {
        readonly ApplicationDbContext _context;

        public PostRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public void Add(Post P)=>_context.Add(P);

        public void Add(Image Im)=>_context.Add(Im);

        public async Task<bool> Delete(int id)
        {
            var post = await _context.posts.FindAsync(id);
            if (post != null)
            {
                _context.Remove(post);
                Save();
                return true;
            }
            else return false;
        }
        public async Task<List<Post>> GetAll() => await _context.posts.Include(p=>p.Images).ToListAsync();

        public void Save() => _context.SaveChanges();

        public Task<bool> Update(Post P)
        {
            throw new NotImplementedException();
        }
    }
}
