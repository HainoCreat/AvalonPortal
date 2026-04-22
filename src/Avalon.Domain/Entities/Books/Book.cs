namespace Avalon.Domain.Entities.Books;

public class Book
{
    public Guid Id {get; set;} = Guid.NewGuid();

    public required string Title {get; set;}

    public string? Description {get; set;}

    public string? Dedication {get; set;}

    //Навигация
    public virtual List<Chapter> Chapters {get; set;} = new();

    public virtual ICollection<Genre> Genres { get; set; } = new HashSet<Genre>();

}