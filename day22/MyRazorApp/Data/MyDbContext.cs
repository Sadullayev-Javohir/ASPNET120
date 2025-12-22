using System.Reflection.Metadata;
using Microsoft.EntityFrameworkCore;
using MyRazorApp.Models;

namespace MyRazorApp.Data;

public class MyDbContext : DbContext
{
  public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) {}

  public DbSet<User> Users {get;set;}
}
