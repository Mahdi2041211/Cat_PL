using Comunity2.Data;
using Comunity2.Data.Repositories;
using Comunity2.Models;
using Microsoft.EntityFrameworkCore;

namespace Comunity2.Services
{
    public class PostService:IPostService
    {
       readonly IPostRepository _postRepository;
        public PostService(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }

        public void CreatePost(Post post,User user)
        {
            if (user != null)
            {
                post.User_Id = user.Id;
                _postRepository.Add(post);
                _postRepository.Save();

            }
            var files = post.files;
            if (files!=null&&files.Count>0)
            {
                foreach (var file in files)
                {
                    if (file.Length > 0)
                    {
                        using var stream = new MemoryStream();
                        file.CopyTo(stream);
                        var image = new Image()
                        {

                            Post_Id = post.Id,
                            Picture = stream.ToArray(),

                        };
                        _postRepository.Add(image);
                    }

                }

            }
            _postRepository.Save();
        }
        public Task<List<Post>> GetAllPosts()=>_postRepository.GetAll();
    }
}
