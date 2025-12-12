using Project4.Models;

namespace Project4.Services;

public interface IPortfolioService
{
  Task<List<PortfolioItem>> GetAllAsync();
  Task AddAsync(PortfolioItem item);
}
