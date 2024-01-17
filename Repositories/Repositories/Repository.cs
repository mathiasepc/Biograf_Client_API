
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

    /// <summary>
    /// Collect all data
    /// </summary>
    /// <returns>object T</returns>
    /// <exception cref="Exception"></exception>
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

    /// <summary>
    /// Gets by id
    /// </summary>
    /// <param name="id">Id to check in database</param>
    /// <returns></returns>
    /// <exception cref="Exception"></exception>
    public async Task<T> GetById(Guid id)
    {
        try
        {
            return await _context.Set<T>()
                .FirstOrDefaultAsync(entity => entity.GetType()
                .GetProperty("Id")
                .GetValue(entity, null)
                .Equals(id));
        }
        catch (DbUpdateException ex)
        {
            throw new Exception($"Noget gik galt ved hentning af objekt {ex.Message}");
        }
    }

    /// <summary>
    /// Indsætter objekt.
    /// </summary>
    /// <param name="model">Value to insert</param>
    /// <returns></returns>
    /// <exception cref="Exception"></exception>
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

    /// <summary>
    /// Checks if the item exist. if exist insert.
    /// </summary>
    /// <param name="id">Primarykey represent the object that needs to be updated</param>
    /// <param name="entity">The updated value for the object</param>
    /// <returns>object if not null else null</returns>
    /// <exception cref="Exception">throw this if a error occur</exception>
    public async Task<T> UpdateModel(Guid id, T entity)
    {
        try
        {
            var exist = await _context.FindAsync<T>(id);

            if (exist != null)
            {
                _context.Entry(exist).CurrentValues.SetValues(entity);
                await _context.SaveChangesAsync();
            }

            return exist;
        }
        catch (DbUpdateException ex)
        {
            throw new Exception($"Noget gik galt: {ex.Message}");
        }
    }
}
