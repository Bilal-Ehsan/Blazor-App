using System.ComponentModel.DataAnnotations;

namespace Application.Data;

public class Grocery
{
    [Required]
    [StringLength(15, ErrorMessage = "Name must be no longer than 15 characters")]
    public string? Name { get; set; }

    [Required]
    [Range(1, 10000, ErrorMessage = "Valid price range is from £1 to £10,000")]
    public double Price { get; set; }
}
