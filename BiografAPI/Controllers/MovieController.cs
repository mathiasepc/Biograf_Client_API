
namespace BiografAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class MovieController : BaseController<Movie>
{
    private readonly IRepository<Movie> _repository;

    public MovieController(IRepository<Movie> repository) : base(repository)
    {
        _repository = repository;
    }

    //[HttpGet("GetAllMoviesWithThemes")]
    //public async Task<IEnumerable<MovieDTO>> GetAllMoviesWithThemes()
    //{
    //    try
    //    {
    //        var movies = await _repository.GetAll();

    //        if(movies.IsNullOrEmpty()) { throw new NullReferenceException(); }

    //        var movieDtos = _mapper.Map<IEnumerable<MovieDTO>>(movies);

    //            return movieDtos;
    //    }
    //    catch (NullReferenceException ex)
    //    {
    //        throw new Exception($"Fandt ingenting i databasen {ex.Message}");
    //    }
    //}

    //[HttpPost("InsertMovie")]
    //public async Task<bool> InsertMovie([FromBody] Movie movie)
    //{
    //    try
    //        {
    //        if (movie == null) throw new NullReferenceException();

    //        bool result = movie != null 
    //            ? await _repository.InsertModel(movie) 
    //            : throw new NullReferenceException();

    //        return result;
    //    }
    //    catch (Exception ex)
    //    {
    //        throw new Exception($"Noget gik galt {ex.Message}");
    //    }
    //}


}
