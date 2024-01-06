
namespace BiografAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ReleaseDateController : BaseController<ReleaseDate>
{
    private readonly IRepository<ReleaseDate> _repository;

    public ReleaseDateController(IRepository<ReleaseDate> repository) : base(repository)
    {
        _repository = repository;
    }
}
