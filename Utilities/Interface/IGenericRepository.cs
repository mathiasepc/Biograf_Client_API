

namespace Utilities.Interface
{
    public interface IGenericRepository<T> where T : class
    {
        Task<bool> InsertModel(T model);
    }
}