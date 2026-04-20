using Avalon.Domain.Entities.Books;
using Microsoft.EntityFrameworkCore;

namespace Avalon.Infrastructure.Persistence.Context;

public class AvalonApplicationDbContext : DbContext
{
    public AvalonApplicationDbContext(DbContextOptions<AvalonApplicationDbContext> options) : base(options)
    {
        
    }

    public DbSet<Book> Books {get; set;} = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AvalonApplicationDbContext).Assembly);
    }
}