
using System.ComponentModel.DataAnnotations.Schema;

namespace Utilities.Models;

public class Hall : BaseModel
{
    [Required]
    public int? Row { get; set; }
    [Required]
    public int? Column { get; set; }

    [ForeignKey("Id")] // Dette angiver navnet på fremmednøglen
    public Guid? CinemaId { get; set; }

    [JsonIgnore]
    public Cinema? Cinema { get; set; }   
    public ICollection<Movie>? Movies { get; set; } = new List<Movie>();
}

