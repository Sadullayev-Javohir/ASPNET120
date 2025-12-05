// using System.Threading.Tasks.Dataflow;

// public class Program
// {
//   // static void BubbleSort(int[] arr)
//   // {
//   //   int n = arr.Length;
//   //   bool swapped;

//   //   for (int i = 0; i < n - 1; i++)
//   //   {
//   //     swapped = false;

//   //     for (int j = 0; j < n - i - 1; j++)
//   //     {
//   //       if (arr[j] > arr[j + 1])
//   //       {
//   //         (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
//   //         swapped = true;
//   //       }
//   //     }

//   //     if (!swapped) break;
//   //   }
//   // }

//   // static int BinarySearch(int[] arr, int t)
//   // {
//   //   int left = 0;
//   //   int right = arr.Length - 1;

//   //   while (left <= right)
//   //   {
//   //     int mid = left + (right - left) / 2;

//   //     if (arr[mid] == t) return mid;

//   //     if (arr[mid] < t) left = mid + 1;
//   //     else right = mid - 1;
//   //   }

//   //   return -1;
//   // }

//   static void Main()
//   {
//     // int[] arr = {6, 2, 7, 3};
//     // // Array.Sort(arr);
//     // // BubbleSort(arr);
//     // var sortedNumbers = arr.OrderBy(n => n).ToArray();
//     // Console.WriteLine(string.Join(", ", sortedNumbers));

//     // int[] arr = {1, 2, 3, 4, 5};
//     // Console.WriteLine(BinarySearch(arr, 3));

//     List<int> sonlar = new List<int> {1, 2, 3, 4, 5};
//     int index = sonlar.BinarySearch(6);

//     Console.WriteLine(index);
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     Console.WriteLine("5 ta talabaning balini kiriting");

//     int i = 0;
//     int[] ballar = new int[5];
//     while (i < ballar.Length)
//     {
//       Console.WriteLine($"{i + 1}-talabani balini kiriting: ");
//       ballar[i++] = int.Parse(Console.ReadLine());
//     }

//     Console.WriteLine("Hozirgi tartib: ");

//     PrintArr(ballar);

//     Console.WriteLine("\nBubble Sort: ");

//     BubbleSort(ballar);

//     PrintArr(ballar);

//     Console.WriteLine("Qaysi ballni qidirayapsiz");

//     int searchedNum = int.Parse(Console.ReadLine());
//     int findNum = BinarySearch(ballar, searchedNum);
//     Console.WriteLine(findNum != -1 ? $"Son topildi: {findNum}" : "Son topilmadi");
//   }

//   static void PrintArr(int[] arr)
//   {
//     int i = 0;
//     while (i < arr.Length)
//     {
//       Console.WriteLine($"{i + 1}: {arr[i++]}");
//     }
//   }

//   static void BubbleSort(int[] arr)
//   {
//     bool sorted;
//     for (int i = 0; i < arr.Length - 1; i++)
//     {
//       sorted = false;
//       for (int j = 0; j < arr.Length - i - 1; j++)
//       {
//         if (arr[j] > arr[j + 1])
//         {
//           (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
//           sorted = true;
//         }
//       }

//       if (!sorted) break;
//     }
//   }

//   static int BinarySearch(int[] arr, int t)
//   {
//     int left = 0, right = arr.Length - 1;

//     while (left <= right)
//     {
//       int mid = left + (right - left) / 2;

//       if (arr[mid] == t) return mid;

//       if (arr[mid] < t) left = mid + 1;
//       else right = mid - 1;
//     }

//     return -1;
//   }
// }


// using System;

// class Calculator
// {
//   public int Add(int a, int b)
//   {
//     return a + b;
//   }

//   public int Add(int a, int b, int c)
//   {
//     return a + b + c;
//   }

//   public double Add(double a, double b)
//   {
//     return a + b;
//   }
// }


// class Animal
// {
//   public virtual void Speak()
//   {
//     Console.WriteLine("Hayvon ovoz chiqaryapti");
//   }
// }

// class Dog : Animal
// {
//   public override void Speak()
//   {
//     Console.WriteLine("It: Hurmoqda");
//   }
// }

// class Cat : Animal
// {
//   public override void Speak()
//   {
//     Console.WriteLine("Mushuk: Miyovlamoqda");
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     Calculator calc = new Calculator();

//     Console.WriteLine(calc.Add(2, 3));
//     Console.WriteLine(calc.Add(2, 3, 4));
//     Console.WriteLine(calc.Add(2.5, 3.2));

//     Animal a1 = new Dog();
//     Animal a2 = new Cat();
//     Animal a3 = new Animal();

//     a1.Speak();
//     a2.Speak();
//     a3.Speak();
//   }
// }

// using System;
// using System.Net.Http;
// using System.Threading.Tasks;

// class Program
// {

//   static async Task Main(string[] args)
//   {

//     Thread countThred = new Thread(CountSeconds);
//     countThred.Start();
//     Console.WriteLine("Ma'lumot yuklanmoqda...");
//     countThred.Join();

//     string data = await GetDataFromWebAsync();

//     Console.WriteLine("Serverdan olingan ma'lumot");
//     Console.WriteLine(data);
//   }

//   static void CountSeconds()
//   {
//     for (int i = 1; i <= 3; i++)
//     {
//       Console.WriteLine($"{i}");
//       Thread.Sleep(1000);
//     }
//   }

//   static async Task<string> GetDataFromWebAsync()
//   {
//     using var client = new HttpClient();

//     string result = await client.GetStringAsync("https://example.com");
//     return result;
//   }
// }


// class Program
// {
//   static async Task Main()
//   {
//     Console.WriteLine("Nonushta tayyorlash boshlandi...");

//     var task1 = TuxumQovurishAsync();
//     var task2 = ChoyDamlashAsync();
//     var task3 = NonQizdirishAsync();

//     await Task.WhenAll(task1, task2, task3);
//     Console.WriteLine("Nonushta tayyor");
//   }

//   static async Task TuxumQovurishAsync()
//   {
//     await Task.Delay(3000);
//     Console.WriteLine("Tuxum pishdi");
//   }

//   static async Task ChoyDamlashAsync()
//   {
//     await Task.Delay(2000);
//     Console.WriteLine("Choy damlandi");
//   }

//   static async Task NonQizdirishAsync()
//   {
//     await Task.Delay(1000);
//     Console.WriteLine("Non qizdirildi");
//   }
// }

using System;
using System.Data;
using System.Threading;

// class Program
// {
//   static void Main()
//   {
//     Console.WriteLine("Dastur boshlandi");

//     Thread.Sleep(3000);

//     Console.WriteLine("3 sekund kutdi");
//     Console.WriteLine("Dastur tugadi");
//   }
// }


class Program
{
  static async Task Main()
  {
    Console.WriteLine("Dastur boshlandi");

    var delayTask = DelayExample();

    for (int i = 1; i <= 5; i++)
    {
      Console.WriteLine($"{i} boshqa ish bajarilmoqda...");
      await Task.Delay(500);
    }

    await delayTask;
    Console.WriteLine("Hammasi tugadi");

    static async Task DelayExample()
    {
      Console.WriteLine("Delay boshlandi: 5 sekund");
      await Task.Delay(5000);
      Console.WriteLine("Delay tugadi");
    }
  }
}
