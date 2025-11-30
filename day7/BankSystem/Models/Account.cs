namespace BankSystem.Models;

public class Account
{
  public string Name {get;set;}
  public string Number {get;set;}
  public decimal Money {get;set;}

  public Account(string name, decimal money)
  {
    Number = Guid.NewGuid().ToString().Substring(0, 8);
    Name = name;
    Money = money;

  }
}


