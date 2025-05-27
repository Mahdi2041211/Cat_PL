using Comunity2.Data;

namespace Comunity2.Models.Repositories
{
    public interface IRepository<Type> where Type : class
    {
        public void Delete(Type T);
        public Task Add(Type T);
        public Task GetAll(Type T);
        public void Update(Type T);
    }
}
