


namespace Utilities.Models;

public class Actor : BaseModel
{
    [Required]
    public int? Age { get; set; }
    [JsonIgnore]
    public ICollection<Movie>? Movies { get; set; } = new List<Movie>();
}
