using Comunity2.Models;

namespace Comunity2.Services
{
    public interface IPostService
    {
        void CreatePost(Post post,User user);
        Task<List<Post>> GetAllPosts();

    }
}
