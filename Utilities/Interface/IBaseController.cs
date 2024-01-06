
using Microsoft.AspNetCore.Mvc;

namespace Utilities.Interface;

public interface IBaseController<T> where T : class
{
    Task<ActionResult<IEnumerable<T>>> Get();
    Task<ActionResult<bool>> Insert([FromBody] T entity);
}
