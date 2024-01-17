namespace BiografAPI.Base;

public class BaseController<T> : Controller where T : class
{
    private readonly IRepository<T> _repository;

    public BaseController(IRepository<T> genericRepository)
    {
        _repository = genericRepository;
    }

    /// <summary>
    /// Kalder på IRepository, get all.
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    public virtual async Task<ActionResult<IEnumerable<T>>> Get()
    {

        return Ok(await _repository.GetAll());
    }

    /// <summary>
    /// Modtager et guid, som ikke må være null.
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentNullException"></exception>
    [HttpGet("GetById")]
    public virtual async Task<ActionResult<T>> GetById(Guid id)
    {
        if (id == Guid.Empty) throw new ArgumentNullException("Manger ID.S");

        var entity = await _repository.GetById(id);
        if (entity == null)
        {
            return NotFound();
        }

        return Ok(entity);
    }

    [HttpDelete("id")]
    public virtual async Task<ActionResult<T>> Delete(Guid id)
    {
        return Ok();
    }
}
