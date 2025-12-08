using System.Collections.Generic;

namespace MyProject.Models;

public class CustomerDetailViewModel
{
  public string FullName {get;set;}
  public string Email {get;set;}
  public string Phone {get;set;}
  public List<OrderViewModel> Orders {get;set;}

  public string PageTitle {get;set;}
}
