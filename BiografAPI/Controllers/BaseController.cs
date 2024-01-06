
namespace BiografAPI.Controllers;

public class BaseController<T> : Controller where T : class
{
    private readonly IRepository<T> _repository;

    public BaseController(IRepository<T> genericRepository)
    {
        _repository = genericRepository;
    }

    [HttpGet]
    public virtual async Task<ActionResult<IEnumerable<T>>> Get()
    {
        return Ok(await _repository.GetAll());
    }

    [HttpGet("GetById")]
    public virtual async Task<ActionResult<T>> GetById(Guid id)
    {
        if (id == null) throw new ArgumentNullException("ID er null");

        var entity = await _repository.GetById(id);
        if (entity == null)
        {
            return NotFound();
        }

        return Ok(entity);
    }

    [HttpPost("InsertObject")]
    public virtual async Task<ActionResult<bool>> Insert([FromBody] T entity)
    {
        if (entity == null) throw new ArgumentNullException(nameof(entity));

        return Ok(await _repository.InsertModel(entity));
    }

    [HttpPut("id")]
    public virtual async Task<ActionResult<T>> Put(Guid id, [FromBody] T entity)
    {
        return Ok();
    }


    [HttpDelete("id")]
    public virtual async Task<ActionResult<T>> Delete(Guid id)
    {
        return Ok();
    }


}
