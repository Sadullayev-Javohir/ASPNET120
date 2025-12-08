using System.ComponentModel.DataAnnotations;

namespace ProductProject.Models;

public class Product
{
  [Required(ErrorMessage = "Name is Required")]
  [StringLength(100)]
  public string Name {get;set;}

  [Range(1, 10000, ErrorMessage = "Price must be between 1 and 10000")]
  public decimal Price {get;set;}

  public int Id {get;set;}
}
