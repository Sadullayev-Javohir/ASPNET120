using BankSystem.Models;

namespace BankSystem.Interfaces;

public interface IBankService
{
  void Create(string name, decimal money);
  void Deposit(string number, decimal money);
  void Withdraw(string number, decimal money);
  Account Get(string number);
  List<Account> GetAll();
}
