
namespace Utilities.Models;

public class Cinema : BaseModel
{
    public ICollection<Hall>? Halls { get; set; } = new List<Hall>();
}
