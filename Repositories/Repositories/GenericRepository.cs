
using Repositories.Database;
using Utilities.Interface;

namespace Repository.Repositories;

public class GenericRepository<T> : IGenericRepository<T> where T : class
{
    private readonly DatabaseContext _context;

    public GenericRepository(DatabaseContext context)
    {
        _context = context;
    }

    public async Task<bool> InsertModel(T model)
    {
        try
        {
            _context.Set<T>().Add(model);
            await _context.SaveChangesAsync();
            return true;
        }
        catch(DbUpdateException ex)
        {
            throw new Exception(ex.Message);
        }
    }
}
