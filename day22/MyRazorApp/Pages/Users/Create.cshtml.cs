using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyRazorApp.Models;
using MyRazorApp.Data;

namespace MyRazorApp.Pages.Users;

public class CreateModel : PageModel
{
  private readonly MyDbContext _context;

  public CreateModel(MyDbContext context) => _context = context;

  [BindProperty]
  public User User {get;set;}

  public void OnGet() {}

  public async Task<IActionResult> OnPostAsync()
  {
    if (!ModelState.IsValid) return Page();

    _context.Users.Add(User);

    _context.SaveChangesAsync();

    return RedirectToPage("./Index");
  }
}


