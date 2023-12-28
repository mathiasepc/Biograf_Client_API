
namespace Utilities.Models;

public class Cinema : BaseModel
{
    [Required]
    public string? Location { get; set; }

    public ICollection<Hall>? Halls { get; set; } = new List<Hall>();
    public ICollection<User>? Users { get; set; } = new List<User>();
   
}
