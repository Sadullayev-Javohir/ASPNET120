using Microsoft.EntityFrameworkCore;
using ProductProject.Models;

namespace ProductProject.Data;

public class AppDbContext : DbContext
{
  public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

  public DbSet<Product> Products {get;set;}
}
