using System.ComponentModel.DataAnnotations;

namespace Test.Models.DTO;

public class BookDTO
{
    public int Id { get; set; }
    [Required]
    [MaxLength(100)]
    public string BookTitle { get; set; }
    [Required]
    [MaxLength(100)]
    public string EditionTitle { get; set; }
    [Required]
    [MaxLength(100)]
    public string PublishingHouseName { get; set; }
    public string releaseDate { get; set; }
}