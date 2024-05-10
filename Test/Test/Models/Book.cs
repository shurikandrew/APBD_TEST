using System.ComponentModel.DataAnnotations;

namespace Test.Models;

public class Book
{
    public int Id { get; set; }
    [Required]
    [MaxLength(100)]
    public string Title { get; set; }
}