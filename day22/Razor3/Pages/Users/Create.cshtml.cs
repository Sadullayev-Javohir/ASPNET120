using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Razor3.Data;
using Razor3.Models;

namespace Razor3.Pages.Users;

public class CreateModel : PageModel
{
  private readonly AppDbContext _dbContext;

  public CreateModel(AppDbContext dbContext) => _dbContext = dbContext;

  [BindProperty]
  public User User {get;set;} = new User();

  public void OnGet() {}

  public async Task<IActionResult> OnPostAsync()
  {
    if (!ModelState.IsValid) return Page();

    _dbContext.Users.Add(User);
    await _dbContext.SaveChangesAsync();

    return RedirectToPage("./Index");
  }
}
