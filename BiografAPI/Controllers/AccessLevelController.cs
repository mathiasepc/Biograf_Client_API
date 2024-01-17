
using BiografAPI.Base;

namespace BiografAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AccessLevelController : OneToManyController<AccessLevel>
{
    private readonly IRepository<AccessLevel> _reposity;

    public AccessLevelController(IRepository<AccessLevel> repository) : base(repository)
    {
        _reposity = repository;
    }
}
