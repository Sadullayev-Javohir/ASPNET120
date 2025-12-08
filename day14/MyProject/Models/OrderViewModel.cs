namespace MyProject.Models;

public class OrderViewModel
{
  public int OrderId {get;set;}
  public DateTime Date {get;set;}
  public decimal TotalAmount {get;set;}
  public bool IsPaid {get;set;}
}
