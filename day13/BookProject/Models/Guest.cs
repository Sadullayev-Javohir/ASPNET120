using System.ComponentModel.DataAnnotations;

namespace BookProject.Models;

public class Guest
{
  public int Id {get;set;}

  [Required(ErrorMessage = "Ism kiritilishi shart")]
  public string Title {get;set;}

  [Required(ErrorMessage ="Description kiritilishi shart")]
  public string Description {get;set;}

  public DateTime Date {get;set;}
}
