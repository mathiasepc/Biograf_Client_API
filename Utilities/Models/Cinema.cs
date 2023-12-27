
namespace Utilities.Models;

public class Cinema : BaseModel
{
    public string? Location { get; set; }

    public ICollection<Hall>? Halls { get; set; } = new List<Hall>();
    public ICollection<User>? Users { get; set; } = new List<User>();
    public override void MapObject(dynamic m)
    {
        Location = m.location;
        Halls = m.halls;
        Users = m.users;
    }
}
