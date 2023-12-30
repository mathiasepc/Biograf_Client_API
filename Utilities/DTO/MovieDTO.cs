
using Utilities.Models;

namespace Utilities.DTO;

public class MovieDTO : BaseModel
{
    public string Release { get; set; }
    public int Length { get; set; }
    public string? ImgURL { get; set; }
    public List<string> Themes { get; set; }
}
