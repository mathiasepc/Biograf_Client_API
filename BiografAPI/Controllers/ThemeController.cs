
using BiografAPI.Base;

namespace BiografAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ThemeController : ManyToManyController<Theme>
{
    private readonly IRepository<Theme> _repository;
    public ThemeController(IRepository<Theme> repository) : base(repository)
    { 
        _repository = repository;
    }
}
