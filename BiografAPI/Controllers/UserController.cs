
namespace BiografAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController : BaseController<User>
{
    private readonly IRepository<User> _repository;
    public UserController(IRepository<User> repository) : base(repository)
    {
        _repository = repository;
    }

    //[HttpPost]
    //public async Task<ActionResult> InsertUser(User user)
    //{
    //    try
    //    {
    //        return Ok(_repository.InsertModel(user));
    //    }
    //    catch (NullReferenceException ex) 
    //    {
    //        throw new Exception($"Error occoured: {ex.Message}");
    //    }
    //}

}
