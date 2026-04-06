namespace Avalon.Application.DTOs.Genres.v1;

public class GenreDtoV1
{
    public int Id {get; set;}

    public string? Title {get; set;}

    public string? Description {get; set;}

    public DateTimeOffset CreatedAt {get; set;}
}