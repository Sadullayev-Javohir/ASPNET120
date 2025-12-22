  using Microsoft.AspNetCore.Mvc.RazorPages;
  using MyRazorApp.Models;
  using MyRazorApp.Data;
  using Microsoft.EntityFrameworkCore;

  namespace MyRazorApp.Pages.Users;

  public class IndexModel : PageModel
  {
    private readonly MyDbContext _context;

    public IndexModel(MyDbContext context) => _context = context;

    public IList<User> Users {get;set;}

    public async Task OnGetAsync()
    {
      Users = await _context.Users.ToListAsync();
    }
  }
