
using System.Reflection.Metadata.Ecma335;

namespace Utilities.Models;

public class BaseModel : IBaseModel
{
    private Guid _id;

    [Key]
    public Guid Id
    {
        get { return _id; }
        set { _id = value; }
    }

    [Required]
    public string Name { get; set; }    

    public BaseModel()
    {
        _id = Guid.NewGuid();
    }
}
