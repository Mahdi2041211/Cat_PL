using Comunity2.Models;

namespace Comunity2.Data.Repositories
{
    public interface IPostRepository
    {
        public Task<List<Post>> GetAll();
        public void Add(Post P);
        public void Add(Image Im);
        void Save();
        Task<bool> Delete(int id);
        Task<bool>Update(Post P);

    }
}
