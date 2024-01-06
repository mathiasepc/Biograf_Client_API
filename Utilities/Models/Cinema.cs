
namespace Utilities.Models;

public class Cinema : BaseModel
{
    [Required]
    public ICollection<Hall>? Halls { get; set; } = new List<Hall>();
    [Required]
    public ICollection<User>? Users { get; set; } = new List<User>();
}
