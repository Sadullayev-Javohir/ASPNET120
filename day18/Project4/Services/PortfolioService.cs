using Microsoft.EntityFrameworkCore;
using Project4.Data;
using Project4.Models;

namespace Project4.Services;

public class PortfolioService : IPortfolioService
{
  private readonly AppDbContext _db;

  public PortfolioService(AppDbContext db) => _db = db;

  public Task<List<PortfolioItem>> GetAllAsync() => _db.PortfolioItems.ToListAsync();

  public async Task AddAsync(PortfolioItem item)
  {
    await _db.PortfolioItems.AddAsync(item);
    await _db.SaveChangesAsync();
  }
}


