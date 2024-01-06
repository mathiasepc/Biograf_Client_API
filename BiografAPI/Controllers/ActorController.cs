

namespace BiografAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ActorController : BaseController<Actor> 
{
    private readonly IRepository<Actor> _repository;

    public ActorController(IRepository<Actor> repository) : base(repository)
    {
        _repository = repository;
    }
    
}
