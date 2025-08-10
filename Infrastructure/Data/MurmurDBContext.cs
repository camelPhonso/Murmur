using Microsoft.EntityFrameworkCore;
using Murmur.Domain.Models;

namespace Murmur.Infrastructure.Data;

public class MurmurDBContext : DbContext
{
  public DbSet<Interchange> Interchanges { get; set; }
  public DbSet<Message> Messages { get; set; }

  public MurmurDBContext(DbContextOptions options)
    : base(options) { }

  public override int SaveChanges()
  {
    return base.SaveChanges();
  }

  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    modelBuilder
      .Entity<Interchange>()
      .HasMany<Message>(i => i.Messages)
      .WithOne()
      .HasForeignKey(i => i.Id);

    base.OnModelCreating(modelBuilder);
  }
}
