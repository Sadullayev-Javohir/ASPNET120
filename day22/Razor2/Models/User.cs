using System.ComponentModel.DataAnnotations;

namespace Razor2.Models;

public class User
{
  public int Id {get;set;}

  [Required]
  public string Name {get;set;} = "";
}
