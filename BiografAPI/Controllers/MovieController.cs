
namespace BiografAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class MovieController : ManyToManyController<Movie>
{
    private readonly IRepository<Movie> _repository;

    public MovieController(IRepository<Movie> repository) : base(repository)
    {
        _repository = repository;
    }
}
