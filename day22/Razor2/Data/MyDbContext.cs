using Microsoft.EntityFrameworkCore;
using Razor2.Models;

namespace Razor2.Data;

public class MyDbContext : DbContext
{
  public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) {}

  public DbSet<User> Users { get; set; }
}
