namespace Avalon.Application.DTOs.Books;

public class BookDto
{
    public Guid Id {get; set;}

    public required string Title {get; set;}

    public string? Description {get; set;}

    public string? Dedication {get; set;}

    public DateTimeOffset CreatedAt {get; set;}
}