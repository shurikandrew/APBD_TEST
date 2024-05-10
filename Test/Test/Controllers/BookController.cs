using Microsoft.AspNetCore.Mvc;
using Test.Repositories;
using Test.Services;

namespace Test.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BookController : ControllerBase
{
    private IBookService _bookService;

    public BookController(IBookService bookService)
    {
        _bookService = bookService;
    }

    [HttpGet("{id:int}")]
    public IActionResult getEditions(int id)
    {
        return Ok(_bookService.GetEditions(id));
    }
}