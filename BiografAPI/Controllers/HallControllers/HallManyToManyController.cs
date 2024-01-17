

namespace BiografAPI.Controllers.HallControllers;

[Route("api/[controller]")]
[ApiController]
public class HallManyToManyController : ManyToManyController<Hall>
{
    private readonly IRepository<Hall> _repository;

    public HallManyToManyController(IRepository<Hall> repository) : base(repository)
    {
        _repository = repository;
    }
}
