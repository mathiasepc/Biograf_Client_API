
using System.ComponentModel.DataAnnotations.Schema;

namespace Utilities.Models;

public class User : BaseModel
{
    [Required]
    public string LastName { get; set; }
    [Required]
    public DateTime Age { get; set; }
    [Required]
    public string Email { get; set; }
    [ForeignKey("Id")] // Dette angiver navnet på fremmednøglen
    public Guid? AccessLevelId { get; set; }
    public AccessLevel? AccessLevel { get; set; }
}
