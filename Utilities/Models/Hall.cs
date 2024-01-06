
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Utilities.Models;

public class Hall : BaseModel
{
    [Required]
    public int? Row { get; set; }
    [Required]
    public int? Column { get; set; }

    [ForeignKey("Id")] // Dette angiver navnet på fremmednøglen
    public Guid CinemaId { get; set; }

    [JsonIgnore]
    public Cinema Cinema { get; set; } // Navigationsegenskab til Cinema    
    public ICollection<Movie>? Movies { get; set; } = new List<Movie>();
}

