
using Utilities.DTO;

namespace Utilities.Models;

public class Movie : BaseModel
{
    [Required]
    public int? Length { get; set; }
    [Required]
    public string? Release {  get; set; }
    [Required]
    public string? ImgURL { get; set; }
    public ICollection<Actor>? Actors { get; set; } = new List<Actor>();
    public ICollection<Hall>? Halls { get; set; } = new List<Hall>();
    public ICollection<Theme>? Themes { get; set; } = new List<Theme>();
}

