using System.Reflection.Metadata;
using Microsoft.EntityFrameworkCore;
using Razor3.Models;

namespace Razor3.Data;

public class AppDbContext : DbContext
{
  public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

  public DbSet<User> Users {get;set;}
}
