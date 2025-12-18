public static class ClosureMisoli
{
  public static Func<int, int> TashqiMetod(int boshlangich)
  {
    int hisoblagich = boshlangich;

    Func<int, int> delegat = (int qoshimcha) =>
    {
      hisoblagich += qoshimcha;
      return hisoblagich;
    };
    return delegat;
  }
}

class Program
{
  static void Main()
  {
    var first = ClosureMisoli.TashqiMetod(10);
    Console.WriteLine(first(20));
  }
}
