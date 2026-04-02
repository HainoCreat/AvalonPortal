using Avalon.Domain.Entities;
using Avalon.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Avalon.Infrastructure.Persistence;

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