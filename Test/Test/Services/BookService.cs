using Test.Models.DTO;
using Test.Repositories;

namespace Test.Services;

public class BookService : IBookService
{
    private IBookRepository _bookRepository;

    public BookService(IBookRepository bookRepository)
    {
        _bookRepository = bookRepository;
    }

    public List<BookDTO> GetEditions(int id)
    {
        return _bookRepository.GetEditions(id);
    }

    public bool AddBookAndEdition()
    {
        throw new NotImplementedException();
    }
}