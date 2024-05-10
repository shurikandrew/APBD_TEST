using Test.Models.DTO;

namespace Test.Services;

public interface IBookService
{
    public List<BookDTO> GetEditions(int id);
    public bool AddBookAndEdition();
}