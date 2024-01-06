
namespace BiografAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class HallController : BaseController<Hall>
{
    private readonly IRepository<Hall> _repository;

    public HallController(IRepository<Hall> repository) : base(repository)
    {
        _repository = repository;
    }
}
