
using Utilities.Interface;

namespace Utilities.Models;

public abstract class BaseModel : IBaseModel
{
    public Guid Id { get; set; }
    public string Name { get; set; }

    public abstract void MapObject(dynamic model);
}
