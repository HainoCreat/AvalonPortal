namespace Avalon.Domain.Entities.Books;

public class Book
{
    public Guid Id {get; set;}

    public required string Title {get; set;}

    public string? Description {get; set;}

    public string? Dedication {get; set;}

    public DateTimeOffset CreatedAt {get; set;}

    public List<Chapter> Chapters {get; set;} = new();

}