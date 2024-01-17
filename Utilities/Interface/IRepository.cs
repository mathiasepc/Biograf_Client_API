
using Utilities.Models;

namespace Utilities.Interface;

public interface IRepository<T> where T : class
{
    Task<List<T>> GetAll();
    Task<T>? GetById(Guid id);
    Task<bool> InsertModel(T model);
    Task<T> UpdateModel(Guid id, T entity);
}
