
namespace Utilities.Models;

public class User : BaseModel
{
    public string? LastName { get; set; }
    public int? Age { get; set; }
    public string? Email { get; set; }

    public ICollection<Cinema>? Cinemas { get; set; } = new List<Cinema>();

    public override void MapObject(dynamic m)
    {
        LastName = m.lastName;
        Age = m.age;
        Email = m.email;
        Cinemas = m.cinemas;
    }
}
