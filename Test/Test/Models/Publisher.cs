using System.ComponentModel.DataAnnotations;

namespace Test.Models;

public class Publisher
{
    public int Id { get; set; }
    [Required]
    [MaxLength(100)]
    public string Name { get; set; }
    [MaxLength(50)]
    public string OwnerFirstName { get; set; }
    [Required]
    [MaxLength(100)]
    public string OwnerLastName { get; set; }
}