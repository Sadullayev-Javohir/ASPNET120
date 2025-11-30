using BankSystem.Models;
using BankSystem.Interfaces;

namespace BankSystem.Services;

public class BankService : IBankService
{
  private List<Account> _accounts = new List<Account>();
  public void Create(string name, decimal money)
  {
    var acc = new Account(name, money);

    _accounts.Add(acc);

    Console.WriteLine("Hisob yaratildi");
    Console.WriteLine($"Sizning hisob raqamingiz: {acc.Number}");
  }

  public void Deposit(string number, decimal money)
  {
    var acc = Get(number);
    if (acc != null && money > 0)
    {
      acc.Money += money;

      Console.WriteLine($"Hisobingiz {money} ga to'ldirildi: Hozir balansingiz: {acc.Money}");
    }
    else
    {
      Console.WriteLine($"Hisob raqam topilmadi: {number}");
    }
  }

  public void Withdraw(string number, decimal money)
  {
    var acc = Get(number);
    if (acc != null)
    {
      if (money >= 0 && acc.Money > money)
      {
        acc.Money -= money;
        Console.WriteLine($"Sizning hisobingizdan {money} oldindi. Hozirgi balansingiz: {acc.Money}");
      }
      else
      {
        Console.WriteLine("Hisobdan pul yechib bo'lmadi");
      }
    }
    else
    {
      Console.WriteLine($"Hisob raqam topilmadi: {number}");
    }
  }

  public Account Get(string number) => _accounts.FirstOrDefault(x => x.Number == number);

  public List<Account> GetAll() => _accounts;
}
