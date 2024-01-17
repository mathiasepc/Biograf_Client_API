
using BiografAPI.Base;

namespace BiografAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController : OneToManyController<User>
{
    private readonly IRepository<User> _repository;
    public UserController(IRepository<User> repository) : base(repository)
    {
        _repository = repository;
    }

}
