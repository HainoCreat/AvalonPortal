namespace Avalon.Application.DTOs.Genres;

public class GenreDto
{
    public int Id {get; set;}

    public string? Title {get; set;}

    public string? Description {get; set;}

    public DateTimeOffset CreatedAt {get; set;}
}