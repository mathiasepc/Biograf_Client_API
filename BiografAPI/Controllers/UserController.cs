
namespace BiografAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    public readonly IGenericRepository<User> _repository;

    public UserController(IGenericRepository<User> repository)
    {
        _repository = repository;
    }

    [HttpPost]
    public async Task<ActionResult> InsertUser(User user)
    {
        try
        {
            return Ok(await _repository.InsertModel(user));
        }
        catch (NullReferenceException ex) 
        {
            throw new Exception($"Error occoured: {ex.Message}");
        }
    }

}
