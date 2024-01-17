

using System.Text.Json.Serialization;

namespace Utilities.Models;

public class Movie : BaseModel
{
    [Required]
    public int? Length { get; set; }
    [Required]
    public string? ImgURL { get; set; }
    public ICollection<Actor>? Actors { get; set; } = new List<Actor>();
    public ICollection<Theme>? Themes { get; set; } = new List<Theme>();
    [JsonIgnore]
    public ICollection<ReleaseDate>? ReleaseDate { get; set; } = new List<ReleaseDate>();
    [JsonIgnore]
    public ICollection<Hall>? Halls { get; set; } = new List<Hall>();
}

