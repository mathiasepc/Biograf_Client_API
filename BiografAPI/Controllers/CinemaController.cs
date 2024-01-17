
using BiografAPI.Base;

namespace BiografAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CinemaController : OneToManyController<Cinema>
{
    private readonly IRepository<Cinema> _repository;

    public CinemaController(IRepository<Cinema> repository) : base(repository)
    {
        _repository = repository;
    }
}
