using Comunity2.Data;

namespace Comunity2.Models.Repositories
{
    public interface IRepository<Type> where Type : class
    {
        public Task Delete(Type T);
        public Task<Type> Add();
        public Task<Type>GetAll();
        
    }
}
