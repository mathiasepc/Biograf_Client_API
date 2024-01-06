
namespace Utilities.Models;

public class User : BaseModel
{
    [Required]
    public string? LastName { get; set; }
    [Required]
    public int? Age { get; set; }
    [Required]
    public string? Email { get; set; }
    [JsonIgnore]
    public ICollection<Cinema>? Cinemas { get; set; } = new List<Cinema>();
}
