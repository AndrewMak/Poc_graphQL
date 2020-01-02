using Microsoft.EntityFrameworkCore;

namespace POC_GraphQL.Database
{

  public class StoreContext : DbContext
  {
    public StoreContext(){}
    public StoreContext(DbContextOptions<StoreContext> options)
      : base(options)
    { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
      optionsBuilder.UseInMemoryDatabase("BooksDb");
    }

    public DbSet<Collection> Collections { get; set; }
    public DbSet<Security> Securities { get; set; }
  }
}