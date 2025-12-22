using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Razor3.Data;
using Razor3.Models;
using System.Data.Common;

namespace Razor3.Pages.Users;

public class IndexModel : PageModel
{
  private readonly AppDbContext _dbContext;

  public IndexModel(AppDbContext dbContext) => _dbContext = dbContext;

  public IList<User> Users = new List<User>();

  public async Task OnGetAsync()
  {
    Users = await _dbContext.Users.ToListAsync();
  }
}


