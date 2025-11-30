using BankSystem.Services;
using BankSystem.Models;
using BankSystem.Interfaces;

class Program
{
  static void Main()
  {
    IBankService bank = new BankService();
    while (true)
    {
      Console.WriteLine("=====🏦BANK SYSTEM🏦=====");
      Console.WriteLine("1. Akkount yaratish");
      Console.WriteLine("2. Pul kiritish");
      Console.WriteLine("3. Pul yechish");
      Console.WriteLine("4. Akkountni ko'rish");
      Console.WriteLine("5. Barcha akkountlarni ko'rish");
      Console.WriteLine("0. Chiqish");

       string choice = Console.ReadLine();

      switch(choice)
      {
        case "1":
          Console.WriteLine("Ism kiriting: ");
          string? name = Console.ReadLine();

          Console.WriteLine("Boshlang'ich summa");

          if (decimal.TryParse(Console.ReadLine(), out decimal money))
          {
            bank.Create(name, money);
          }
          else
          {
            Console.WriteLine("Noto'g'ri summa");
          }
          break;
        case "2":
          Console.WriteLine("Hisob raqamini kiriting: ");
          string dnumber = Console.ReadLine();

          Console.WriteLine("Qancha pul kiritmoqchisiz: ");
          if (decimal.TryParse(Console.ReadLine(), out decimal dmoney))
          {
            bank.Deposit(dnumber, dmoney);
          }
          else
          {
            Console.WriteLine("Noto'g'ri summa");
          }
          break;
        case "3":
          Console.WriteLine("Hisob raqamini kiriting: ");
          string wnumber = Console.ReadLine();

          Console.WriteLine("Qancha pul olmoqchisiz: ");
          if (decimal.TryParse(Console.ReadLine(), out decimal wmoney))
          {
            bank.Withdraw(wnumber, wmoney);
          }
          else
          {
            Console.WriteLine("Noto'g'ri summa");
          }
          break;
        case "4":
          Console.WriteLine("Akkount raqamini kiriting: ");
          string number = Console.ReadLine();

          var acc = bank.Get(number);

          if (acc != null)
          {
            Console.WriteLine($"Akkount egasi: {acc.Name} | Hisob raqam: {acc.Number} | Balans: {acc.Money}");
          }
          else
          {
            Console.WriteLine($"Hisob raqam topilmadi: {number}");
          }
          break;
        case "5":
          var accounts = bank.GetAll();

          foreach(var account in accounts)
          {
            Console.WriteLine($"Akkount egasi: {account.Name} | Hisob raqam: {account.Number} | Balans: {account.Money}");
          }
          break;
        case "0":
          Environment.Exit(0);
          break;
        default:
          Console.WriteLine("Bu tanlov yo'q");
          break;
      }
    }
  }
}
