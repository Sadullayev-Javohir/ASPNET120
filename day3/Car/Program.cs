class Car
{
  private int _speed;

  public string Brand {get;set;}
  public int Speed
  {
    get => _speed;
    set
    {
      if (value < 0)
        throw new ArgumentException("Speed manfiy bo'lmasligi kerak");
      else if (value > 300)
        throw new ArgumentException("Speed 300 dan o'tmasligi kerak");
      _speed = value;
    }
  }

  public void PrintInfo()
  {
    Console.WriteLine($"Mashina brandi: {Brand}, Speed: {Speed}");
  }
}

class Program
{
  static void Main()
  {
    Car car = new Car();
    car.Speed = 301;
    car.Brand = "BMW";
    car.PrintInfo();
  }
}

