using System.ComponentModel.DataAnnotations;

namespace Test.Models;

public class Edition
{
    public int Id { get; set; }
    [Required]
    public int FKPublisher { get; set; }
    [Required]
    public int FKBook { get; set; }
    [Required]
    [MaxLength(100)]
    public string EditionTitle { get; set; }
    [Required]
    public string ReleaseDate { get; set; }
}