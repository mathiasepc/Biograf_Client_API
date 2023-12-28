
using System.Reflection.Metadata.Ecma335;

namespace BiografAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class MovieController : ControllerBase
{
    private readonly IGenericRepository<Movie> _repository;

    public MovieController(IGenericRepository<Movie> genericRepository)
    {
        _repository = genericRepository;
    }

    [HttpGet("GetAll")]
    public async Task<List<Movie>> GetAll()
    {
        return await _repository.GetAll();
    }

    [HttpPost("InsertMovie")]
    public async Task<bool> InsertMovie([FromBody] Movie movie)
    {
        try
        {
            bool result = movie != null ? await _repository.InsertModel(movie) : throw new NullReferenceException();

            return result;
        }
        catch (Exception ex)
        {
            throw new Exception($"Noget gik galt {ex.Message}");
        }
    }


}
