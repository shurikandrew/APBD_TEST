using Test.Models.DTO;

namespace Test.Repositories;

public interface IBookRepository
{
    public List<BookDTO> GetEditions(int id);
    public bool AddBookAndEdition();
}