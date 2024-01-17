using BiografAPI.Base;


namespace BiografAPI.Relation;

[Route("api/[controller]")]
[ApiController]
public class ManyToManyController<T> : BaseController<T> where T : class
{
    private readonly IRepository<T> _repository;

    public ManyToManyController(IRepository<T> repository) : base(repository)
    {
        _repository = repository;
    }

    /// <summary>
    /// Modtager et objekt, som ikke må være null.
    /// </summary>
    /// <param name="entity"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentNullException"></exception>
    [HttpPost("Insert")]
    public virtual async Task<ActionResult<bool>> Insert([FromBody] T entity)
    {
        if (entity == null) throw new ArgumentNullException($"Kan ikke være null: {nameof(entity)}");

        return Ok(await _repository.InsertModel(entity));
    }

    /// <summary>
    /// Laver et tjek på id og indsætter
    /// </summary>
    /// <param name="id"></param>
    /// <param name="entity"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentNullException"></exception>
    [HttpPut("Model")]
    public virtual async Task<ActionResult<T>> Put(Guid id, [FromBody] T entity)
    {
        if (entity == null && id == Guid.Empty)
            throw new ArgumentNullException($"Id eller model er null: {nameof(entity)}");

        return await _repository.UpdateModel(id, entity);
    }
}
