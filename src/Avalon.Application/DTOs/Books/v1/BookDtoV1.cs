namespace Avalon.Application.DTOs.Books.v1;

public class BookDtoV1
{
    public Guid Id {get; set;}

    public required string Title {get; set;}

    public string? Description {get; set;}

    public string? Dedication {get; set;}

    public DateTimeOffset CreatedAt {get; set;}
}