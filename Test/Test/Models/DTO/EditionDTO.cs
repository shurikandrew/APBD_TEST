using System.ComponentModel.DataAnnotations;

namespace Test.Models.DTO;

public class EditionDTO
{
    [Required]
    [MaxLength(100)]
    public string BookTitle { get; set; }
    [Required]
    [MaxLength(100)]
    public string EditionTitle { get; set; }
    [Required]
    public int PublishingHouseId { get; set; }
    public string releaseDate { get; set; }
    
}