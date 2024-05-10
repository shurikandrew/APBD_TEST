using System.Data.SqlClient;
using Test.Models.DTO;

namespace Test.Repositories;

public class BookRepository : IBookRepository
{
    private IConfiguration _configuration;

    public BookRepository(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public List<BookDTO> GetEditions(int id)
    {
        using SqlConnection connection = new SqlConnection(_configuration["ConnectionStrings:DefaultConnection"]);
        using SqlCommand command = new SqlCommand();
        connection.Open();
        command.Connection = connection;
        command.CommandText = "SELECT b.PK, b.title, be.edition_title, ph.name, be.release_date FROM books b " +
                              "JOIN books_editions be ON b.PK = be.FK_book " +
                              "JOIN publishing_houses ph ON ph.PK = be.FK_publishing_house" +
                              "WHERE b.PK = @Id";
        command.Parameters.AddWithValue("@Id", id);
        var reader = command.ExecuteReader();
        var result = new List<BookDTO>();
        while (reader.Read())
        {
            var book = new BookDTO()
            {
                Id =(int)reader["PK"],
                BookTitle = reader["title"].ToString(),
                EditionTitle = reader["edition_title"].ToString(),
                PublishingHouseName = reader["name"].ToString(),
                releaseDate = reader["release_date"].ToString()
            };
            result.Add(book);
        }

        return result;
    }

    public bool AddBookAndEdition()
    {
        throw new NotImplementedException();
    }
}