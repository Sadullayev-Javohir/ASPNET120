using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Razor2.Data;
using Razor2.Models;

namespace Razor2.Pages.Users;

public class IndexModel : PageModel
{
  private readonly MyDbContext _context;

  public IndexModel(MyDbContext context) => _context = context;

  public IList<User> Users {get;set;} = new List<Users>();

  public async Task OnGetAsync() => Users = await _context.Users.ToListAsync();
}
