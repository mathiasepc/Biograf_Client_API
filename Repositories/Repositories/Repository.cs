
using Repositories.Database;
using Utilities.Interface;

namespace Repository.Repositories;

public class Repository<T> : IRepository<T> where T : class
{
    private readonly DatabaseContext _context;

    public Repository(DatabaseContext context)
    {
        _context = context;
    }

    public async Task<List<T>> GetAll()
    {
        try
        {
            return _context.Set<T>().ToList();
        }
        catch (Exception ex)
        {
            throw new Exception($"Noget gik galt {ex.Message}");
        }
    }

    public async Task<T> GetById(Guid id)
    {
        try
        {
            return await _context.Set<T>()
                .FirstOrDefaultAsync(entity => entity.GetType().GetProperty("Id").GetValue(entity, null).Equals(id));
        }
        catch (DbUpdateException ex)
        {
            throw new Exception($"Noget gik galt ved hentning af objekt {ex.Message}");
        }
    }

    public async Task<bool> InsertModel(T model)
    {
        try
        {
            _context.Set<T>().Add(model);
            await _context.SaveChangesAsync();
            return true;
        }
        catch (DbUpdateException ex)
        {
            throw new Exception(ex.Message);
        }
    }
}
