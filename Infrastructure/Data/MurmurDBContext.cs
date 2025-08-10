using Microsoft.EntityFrameworkCore;
using Murmur.Infrastructure.Models;

namespace Murmur.Infrastructure.Data;

public class MurmurDBContext : DbContext
{
  public DbSet<Interchange> Interchanges
  {
    get;
    set;
  }

  public MurmurDBContext(DbContextOptions options)
    : base(options) { }

  public override int SaveChanges()
  {
    return base.SaveChanges();
  }

  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    base.OnModelCreating(modelBuilder);
  }
}
