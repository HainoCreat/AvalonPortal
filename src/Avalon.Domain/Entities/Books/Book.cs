namespace Avalon.Domain.Entities.Books;

public class Book
{
    public Guid Id {get; set;}

    public required string Title {get; set;}

    public string? Text {get; set;}

    public string? Description {get; set;}

    public string? Dedication {get; set;}

    public DateTimeOffset CreatedAt {get; set;}

}