using System.ComponentModel.DataAnnotations;

namespace MyRazorApp.Models;

public class User
{
  public int Id {get;set;}

  [Required(ErrorMessage = "Ism majburiy")]
  [StringLength(50)]
  public string Name {get;set;}
}
