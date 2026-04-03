namespace Avalon.Domain.Entities;

public class Book
{
    public Guid Id {get; set;}

    public string Title {get; set;} = string.Empty;

    public string? Text {get; set;}

    public string? Description {get; set;}

    public string? Dedication {get; set;}

}