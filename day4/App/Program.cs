// public class Vehicle
// {
//   public string Brand { get; set; }
//   public void Start() => Console.WriteLine("Vehicle started");
// }

// public class Car : Vehicle
// {
//   public int Doors { get; set; }

//   public void ShowInfo() => Console.WriteLine($"Brand: {Brand}, Doors: {Doors}");
// }

// class Program
// {
//   static void Main()
//   {
//     Vehicle myCar = new Vehicle();
//     myCar.Brand = "Toyota";
//     // myCar.Doors = 4;

//     myCar.Start();

//     // myCar.ShowInfo();
//   }
// }


// POLYMORPHISM

// class Vehicle
// {
//   public virtual void Start() => Console.WriteLine("Vehicle started");
// }

// class Car : Vehicle
// {
//   public override void Start()
//   {
//     Console.WriteLine("Car started");
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     Vehicle vehicle = new Vehicle();
//     Car myCar = new Car();

//     vehicle.Start();
//     myCar.Start();
//   }
// }

// public abstract class Vehicle
// {
//   public abstract void Refuel();
// }

// public class Car : Vehicle
// {
//   public override void Refuel() => Console.WriteLine("Car refueled with petrol");
// }


// class Program
// {
//   static void Main()
//   {
//     var car = new Car();
//     car.Refuel();
//   }
// }

// public interface IDrivable
// {
//   void Drive();
// }

// public class Car : IDrivable
// {
//   public void Drive() => Console.WriteLine("Car is driving");
// }

// class Program
// {
//   static void Main()
//   {
//     var car = new Car();
//     car.Drive();
//   }
// }

// public abstract class Vehicle
// {
//   public string Brand {get;set;}
//   public abstract void Drive();
// }

// public class Car : Vehicle
// {
//   public override void Drive() => Console.WriteLine("Car driving fast");
// }

// public class Truck : Vehicle
// {
//   public override void Drive() => Console.WriteLine("Truck driving slowly");
// }

// class Program
// {
//   static void Main()
//   {
//     List<Vehicle> vehicles = new List<Vehicle>()
//     {
//       new Car {Brand = "BMW"},
//       new Truck {Brand = "Volvo"}
//     };

//     foreach(var v in vehicles)
//       v.Drive();
//   }
// }


// public interface IDrivable
// {
//   void Drive();
// }

// public class Car : IDrivable
// {
//   public void Drive() => Console.WriteLine("Car is driving");
// }

// class Program
// {
//   static void Main()
//   {
//     IDrivable car = new Car();
//     car.Drive();
//   }
// }


// public interface IDiscountable
// {
//   decimal ApplyDiscount(decimal price);
// }

// public abstract class Product : IDiscountable
// {
//   public string Name {get;set;}
//   public decimal BasePrice {get;set;}

//   public Product(string name, decimal price)
//   {
//     Name = name;
//     BasePrice = price;
//   }

//   public abstract decimal CalculatePrice();

//   public abstract decimal ApplyDiscount(decimal price);
// }

// public class DigitalProduct : Product
// {
//   public DigitalProduct(string name, decimal price) : base(name, price){}

//   public override decimal CalculatePrice()
//   {
//     decimal finalPrice = BasePrice;

//     finalPrice = ApplyDiscount(finalPrice);

//     return finalPrice;
//   }

//   public override decimal ApplyDiscount(decimal price) => price - (price * 0.10m);
// }

// public class PhysicalProduct : Product
// {
//   public decimal ShippingCost {get;set;}

//   public PhysicalProduct(string name, decimal price, decimal shipping) : base(name, price)
//   {
//     ShippingCost = shipping;
//   }

//   public override decimal CalculatePrice()
//   {
//     decimal finalPrice = BasePrice + ShippingCost;

//     finalPrice = ApplyDiscount(finalPrice);

//     return finalPrice;
//   }

//   public override decimal ApplyDiscount(decimal price) => price - (price * 0.05m);
// }

// public abstract class PaymentProcessor
// {
//   public abstract void ProcessPayment(decimal amount);

//   protected void ConnectToGateway() => Console.WriteLine("Connecting to payment gateway...");
// }

// public class CreditCardProcessor : PaymentProcessor
// {
//   public override void ProcessPayment(decimal amount)
//   {
//     ConnectToGateway();
//     Console.WriteLine($"Processing credit card payment: ${amount}");
//   }
// }

// public class CheckoutService
// {
//   public decimal Checkout(Product product) => product.CalculatePrice();
// }

// class Program
// {
//   static void Main()
//   {
//     var digital = new DigitalProduct("E-book", 20m);
//     var physical = new PhysicalProduct("Laptop", 1000m, 50m);

//     var checkout = new CheckoutService();

//     decimal digitalTotal = checkout.Checkout(digital);
//     decimal physicalTotal = checkout.Checkout(physical);

//     Console.WriteLine($"Digital product total: ${digitalTotal}");
//     Console.WriteLine($"Physical product total: ${physicalTotal}");

//     PaymentProcessor processor = new CreditCardProcessor();
//     processor.ProcessPayment(digitalTotal + physicalTotal);
//   }
// }

// public interface IDiscountable
// {
//   decimal GetBonus();
// }

// public abstract class Employee : IDiscountable
// {
//   public string Name {get;set;}
//   public Employee(string name) => Name = name;

//   public abstract decimal CalculateSalary();

//   public abstract decimal GetBonus();
// }




// public class FullTimeEmployee : Employee
// {
//   public decimal MonthlySalary {get;set;}

//   public FullTimeEmployee(string name, decimal monthlySalary) : base(name) {MonthlySalary = monthlySalary;}

//   public override decimal CalculateSalary() => MonthlySalary;

//   public override decimal GetBonus() => MonthlySalary * 0.10m;
// }

// public class PartTimeEmployee : Employee
// {
//   public decimal HourlyRate {get;set;}
//   public int HoursWorked {get;set;}

//   public PartTimeEmployee(string name, decimal hourlyRate, int hoursWorked)
//   {
//     HourlyRate = hourlyRate;
//     HoursWorked = hoursWorked;
//   }

//   public override decimal CalculateSalary() => HourlyRate * HoursWorked;

//   public override decimal GetBonus() => (HourlyRate * HoursWorked) * 0.05m;
// }

// public class Program
// {
//   static void Main()
//   {
//     List<Employee> employees = new List<Employee>()
//     {
//       new FullTimeEmployee("Ali", 3000m),
//       new PartTimeEmployee("Vali", 20m, 90)
//     };

//     foreach(var emp in employees)
//     {
//       Console.WriteLine($"Employee: {emp.Name}");
//       Console.WriteLine($"Salary: {emp.CalculateSalary()}");
//       Console.WriteLine($"Bonus: {emp.GetBonus()}");
//       Console.WriteLine("-----------------");
//     }
//   }
// }



// class Human
// {
//   public Human(string HumanName) : this(3, HumanName)
//   {
//     Console.WriteLine("im calling nested constructors");
//   }

//   public Human(int age, string fullName) : this(fullName, "My job is a SDE")
//   {
//     Console.WriteLine($"Age is {age}, FullName: {fullName}");
//   }

//   public Human(string fullName, string job)
//   {
//     Console.WriteLine($"Fullname is: {fullName} jobname is: {job}");
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     var human3 = new Human("someone");

//   }
// }


class Product
{
  public Product(string name, double price, int count)
  {
    Console.WriteLine($"3. Yaratildi");
    Console.WriteLine($"Nomi: {name}, Narxi: {price}, Soni: {count}");
  }

  public Product(string name, double price) : this(name, price, 1)
  {
    Console.WriteLine("2. Oraliq bajarilish");
    Console.WriteLine("Soni bjarilmadi, shuning uchun 1 ta deb olindi");
  }

  public Product(string name) : this(name, 9.99)
  {
    Console.WriteLine("1.Boshlang'ich bajarilish");
    Console.WriteLine("Narx belgilanmadi, shuning uchun 9.99 deb olindi");
  }
}

class Program
{
  static void Main()
  {
    var apple = new Product("Olma");
  }
}
