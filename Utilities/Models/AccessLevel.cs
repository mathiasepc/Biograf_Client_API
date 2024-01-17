
namespace Utilities.Models;

public class AccessLevel : BaseModel
{
    public ICollection<User>? Users { get; set; } = new List<User>();
}
