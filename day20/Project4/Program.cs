// ==================== SOLID ===================

// 1. S - Single Responsibility Principle SRP
// Har bir class ning ichida faqatgina bitta vazifa bajarilishi kerak va uni o'zgartirish uchun faqat bitta sabab bo'lishi lozim.


// public class UserService
// {
//   public void Register(string email, string password)
//   {
//     Console.WriteLine($"Password bazaga saqlandi: {password}");

//     Console.WriteLine($"Email yuborildi: {email}");
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     var u1 = new UserService();
//     u1.Register("1234", "javohir@gmail.com");

//   }
// }

// class EmailService
// {
//   public void SendEmail(string email)
//   {
//     Console.WriteLine($"Email yuborildi: {email}");
//   }
// }

// class UserService
// {
//   public void PrintUser(string user) => Console.WriteLine($"Bu userni chop etdi: {user}");
// }

// class Program
// {
//   static void Main()
//   {
//     var email = new EmailService();
//     var user = new UserService();

//     email.SendEmail("Salom xabari");
//     user.PrintUser("Javohir");
//   }
// }

// 2 O - OCP - Open/Closed Principle - Ochiqlik/Yopiqlik tamoyili

// Class lar kengaytirish uchun ochiq lekin o'zgartirish uchun yopiq bo'lishi kerak.

// public class PaymentProcessor
// {
//   public void ProcessPayment(string type)
//   {
//     if (type == "Click") { /*Click to'lovi*/}
//     else if (type == "Payme") {/*Payme to'lovi*/}
//     // Yangi to'lov qo'shilsa, shu yerni o'zgartirishga to'g'ri keladi
//   }
// }

// public interface IPayment
// {
//   void Process();
// }

// public class ClickPayment : IPayment
// {
//   public void Process() => Console.WriteLine("Click orqali to'landi");
// }

// public class PaymePayment : IPayment
// {
//   public void Process() => Console.WriteLine("Payme orqa'li to'landi");
// }

// Yangi to'lov turi kerakmi? Shunchaki yangi klass ochasiz (UzumPay)

// 3 . Liskov Substitution Principle (LSP)
// Liskov o'rnini bosish tamoyili
// Voris klasslar ota klass ning o'rnini hech qanday muammolarsiz bosishi kerak.

// public class Bird
// {
//   public virtual void Fly() => Console.WriteLine("Uchayapti...");
// }

// public class Eagle : Bird
// {
//   public override void Fly() {}
// }

// public class Penguin : Bird
// {
//   public override void Fly()
//   {
//     throw new Exception("Pingvinlar ucha olmaydi");
//   }
// }


// public abstract class Bird {}

// public interface IFlyable
// {
//   void Fly();
// }

// public class Eagle : Bird, IFlyable
// {
//   public void Fly() => Console.WriteLine("Eagle uchayapti");
// }

// public class Penguin : Bird {}


// Fly metodi yo'q shuning uchun xatolik ham bo'lmaydi

// 4. Interface Segregation Principle (ISP)
// Interfeyslarni ajratish tamoyili
// Mijozlar o'zlari ishlatmaydigan metodlarga bog'liq bo'lishga majburlanmasligi kerak. "Semiz" interface lardan ko'ra, kichik va maxsus interfacelar yaxshiroq.


// public interface ISmartDevice
// {
//   void Print();
//   void Fax();
//   void Scan();
// }

// public class SimplePrinter : ISmartDevice
// {
//   public void Print(){}
//   public void Fax() {throw new NotImplementedException();}
//   public void Scan() {throw new NotImplementedException();}
// }


// public interface IPrinter {void Print();}
// public interface IScanner {void Scan();}

// public class SimplePrinter : IPrinter
// {
//   public void Print() {}
// }

// public class MultiFunctionPrinter : IPrinter, IScanner
// {
//   public void Print() {}
//   public void Scan() {}
// }


// 5. D - Dependency Inversion Principle (DIP)
// Bog'liqlikni teskari yo'naltirish tamoyili
// Yuqori darajadagi modullar past darajadagi modullarga bog'liq bo'lmasligi kerak. Ikkalasi ham abstraksiyalarga bog'liq bo'lishi kerak.

// public class EmailSender
// {
//   public void Send() => Console.WriteLine("Email ketdi");
// }

// public class Notification
// {
//   private EmailSender _sender = new EmailSender();

//   public void Notify() => _sender.Send();
// }



// public interface IMessageSender
// {
//   void Send();
// }

// public class EmailSender : IMessageSender
// {
//   public void Send() => Console.WriteLine("Email ketdi");
// }

// public class SmsSender : IMessageSender
// {
//   public void Send() => Console.WriteLine("Sms ketdi");
// }

// public class Notification
// {
//   private readonly IMessageSender _sender;

//   public Notification(IMessageSender sender) => _sender = sender;

//   public void Notify() => _sender.Send();
// }

// public class Program
// {
//   static void Main()
//   {
//     var email = new EmailSender();
//     var notification = new Notification(email);
//     notification.Notify();
//   }
// }


// public class UserService
// {
//   public void Register(string email, string password)
//   {
//     Console.WriteLine($"Password bazaga saqlandi: {password}");
//     Console.WriteLine($"Email yuborildi: {email}");
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     var u1 = new UserService();
//     u1.Register("1234", "password123");
//   }
// }

// public class EmailService
// {
//   public void SendEmail(string email)
//   {
//     Console.WriteLine($"Email yuborildi: {email}");
//   }
// }

// public class UserService
// {
//   private readonly EmailService _emailService = new EmailService();

//   public UserService(EmailService emailService)
//   {
//     _emailService = emailService;
//   }

//   public void Register(string email)
//   {
//     Console.WriteLine("User bazaga saqlandi");
//     _emailService.SendEmail(email);
//   }
// }

// public class PaymentProcessor
// {
//   public void ProcessPayment(string type)
//   {
//     if (type == "Click") { /*Click to'lovi*/}
//     else if (type == "Payme") {/*Payme to'lovi*/}
//     // Yangi to'lov qo'shilsa, shu yerni o'zgartirishga to'g'ri keladi
//   }
// }

// public interface IPayment
// {
//   void Process();
// }

// public class ClickPayment : IPayment
// {
//   public void Process() => Console.WriteLine("Click orqali to'landi");
// }

// public class PaymePayment : IPayment
// {
//   public void Process() => Console.WriteLine("Payme orqali to'landi");
// }


// public class Bird
// {
//   public virtual void Fly() => Console.WriteLine("Uchayapti...");
// }

// public class Penguin : Bird
// {
//   public override void Fly()
//   {
//     throw new Exception("Pingvinlar ucha olmaydi");
//   }
// }


public abstract class Bird {}

public interface IFlyable
{
  void Fly();
}

public class Eagle : Bird, IFlyable
{
  public void Fly() => Console.WriteLine("Eagle uchayapti");
}

public class Penguin : Bird
{
  public Penguin()
  {
    // Pingvinlar ucha olmaydi, shuning uchun IFlyable interfeysini implementatsiya qilmaydi
  }
}

// public interface IPrinter {void Print(); }
// public interface IScanner {void Scan();}

// public class SimplePrinter : IPrinter
// {
//   public void Print() {}
// }

// public class MultiFunctionPrinter : IPrinter, IScanner
// {
//   public void Print() {}
//   public void Scan() {}
// }

// public interface IMessageSender
// {
//   void Send();
// }

// public class EmailSender : IMessageSender
// {
//   public void Send() => Console.WriteLine("Email ketdi");
// }

// public class SmsSender : IMessageSender
// {
//   public void Send() => Console.WriteLine("Sms ketdi");
// }

// public class Notification
// {
//   private readonly IMessageSender _sender;

//   public Notification(IMessageSender sender) => _sender = sender;

//   public void Notify() => _sender.Send();
// }

// public class Program
// {
//   static void Main()
//   {
//     var email = new EmailSender();
//     var notification = new Notification(email);
//     notification.Notify();
//   }
// }


