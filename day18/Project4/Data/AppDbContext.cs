using Microsoft.EntityFrameworkCore;
using Project4.Models;

namespace Project4.Data;

public class AppDbContext : DbContext
{
  public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

  public DbSet<PortfolioItem> PortfolioItems {get;set;}
}
