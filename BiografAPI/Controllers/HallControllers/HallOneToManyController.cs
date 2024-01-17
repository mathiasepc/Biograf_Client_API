

namespace BiografAPI.Controllers.HallControllers;

[Route("api/[controller]")]
[ApiController]
public class HallOneToManyController : OneToManyController<Hall>
{
    private readonly IRepository<Hall> _repository;

    public HallOneToManyController(IRepository<Hall> repository) : base(repository)
    {
        _repository = repository;
    }
}
