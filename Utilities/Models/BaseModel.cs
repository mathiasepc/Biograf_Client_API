
namespace Utilities.Models;

public class BaseModel : IBaseModel
{
    [Key]
    private Guid _id;
    
    public Guid Id
    {
        get { return _id; }
        private set { _id = value; }
    }

    [Required]
    public string Name { get; set; }

    // Constructor to initialize the Id property
    public BaseModel()
    {
        Id = Guid.NewGuid();
    }
}
