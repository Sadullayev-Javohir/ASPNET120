// public class Engine
// {
//   public void Start() => Console.WriteLine("Engine started");
// }

// public class Car
// {
//   private Engine _engine;

//   public Car() => _engine = new Engine();

//   public void Drive()
//   {
//     _engine.Start();
//     Console.WriteLine("Car is driving...");
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     Car car = new Car();
//     car.Drive();
//   }
// }

public class Engine
{
  public void Start() => Console.WriteLine("Engine started");
}

public class Car
{
  private readonly Engine _engine;

  public Car(Engine engine) => _engine = engine;

  public void Drive()
  {
    _engine.Start();
    Console.WriteLine("Car is driving...");
  }
}

class Program
{
  static void Main()
  {
    var engine = new Engine();
    var car = new Car(engine);
    car.Drive();
  }
}
