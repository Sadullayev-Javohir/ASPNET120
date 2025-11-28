// public class GenericBox<T>
// {
//   public T Value {get;set;}

//   public void DisplayType()
//   {
//     Console.WriteLine($"Qutidagi ma'lumot turi: {typeof(T).Name}");
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     var intBox = new GenericBox<int>();

//     intBox.DisplayType();
//   }
// }


// List<string> foydalanuvchilar = new List<string>();

// foydalanuvchilar.Add("Ali");
// foydalanuvchilar.Add("Vali");
// foydalanuvchilar.Insert(1, "Guli");

// Console.WriteLine($"Ikkinchi foydalanuvchi: {foydalanuvchilar[1]}");

// Dictionary<string, string> davlatlar = new Dictionary<string, string>()
// {
//   {"UZ", "O'ZBEKISTON"},
//   {"KZ", "QOZOG'ISTON"},
//   {"TR", "TURKMANISTON"}
// };

// if (davlatlar.ContainsKey("UZ"))
//   Console.WriteLine($"UZ kodi: {davlatlar["UZ"]}");

// davlatlar.TryAdd("RU", "ROSSIYA");

// foreach(var d in davlatlar)
// {
//   Console.WriteLine(d);
// }


// string input = "abc";
// try
// {
//   int number = int.Parse(input);
//   Console.WriteLine($"Kiritilgan son: {number}");
// }
// catch(FormatException ex)
// {
//   Console.WriteLine($"Xatolik noto'g'ri formatda kiritilgan. Texnik xato: {ex.Message}");
// }
// catch(Exception ex)
// {
//   Console.WriteLine($"Kutilmagan  xato yuz berdi: {ex.GetType().Name}");
// }
// finally
// {
//   Console.WriteLine($"Amaliy bajarish yakunlandi");
// }


// public static class Swapper
// {
//   public static void Swap<T>(ref T a, ref T b)
//   {
//     T temp = a;
//     a = b;
//     b = temp;
//   }
// }

// public static class GenericExample
// {
//   public static void RunGenericExample()
//   {
//     int num1 = 10;
//     int num2 = 20;
//     Console.WriteLine($"Avval: num1={num1}, num2={num2}");
//     Swapper.Swap<int>(ref num1, ref num2);
//     Console.WriteLine($"So'ng: num1={num1}, num2={num2}");
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     GenericExample.RunGenericExample();
//   }
// }


// static class DictionaryExampleSimple
// {
//   public static void Run()
//   {
//     Dictionary<string, decimal> ValyutalarKursi = new Dictionary<string, decimal>();

//     ValyutalarKursi.Add("USD", 12500.00m);
//     ValyutalarKursi.Add("EUR", 13500.50m);

//     decimal usdKursi = ValyutalarKursi["USD"];
//     Console.WriteLine($"1 USD kursi: {usdKursi} so'm");

//     string valyuta = "JPY";
//     if (ValyutalarKursi.ContainsKey(valyuta))
//       Console.WriteLine($"{valyuta} kursi mavjud");
//     else
//     {
//       Console.WriteLine($"{valyuta} kursi topilmadi");
//     }
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     DictionaryExampleSimple.Run();
//   }
// }


// public static class ExceptionExampleSimple
// {
//   public static void Run()
//   {
//     string num1 = "100";
//     string num2 = "0";

//     try
//     {
//       int a = int.Parse(num1);
//       int b = int.Parse(num2);

//       int natija = a / b;

//       Console.WriteLine($"Natija: {natija}");
//     }
//     catch(DivideByZeroException)
//     {
//       Console.WriteLine($"Xatolik: Sonni nolga bo'lish mumkin emas");
//     }
//     catch(FormatException)
//     {
//       Console.WriteLine("Xatolik: kiritilgan ma'lumot son emas");
//     }
//     catch(Exception ex)
//     {
//       Console.WriteLine($"Kutilmagan xato: {ex.Message}");
//     }
//     finally
//     {
//       Console.WriteLine("Bo'lishga urinish yakunlandi");
//     }
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     ExceptionExampleSimple.Run();
//   }
// }

// public class StorageBox<T>
// {
//   public T Data {get;set;}

//   public StorageBox(T data)
//   {
//     Data = data;
//   }

//   public void DisplayType() => Console.WriteLine($"Saqlangan ma'lumot turi: {typeof(T).Name}");
// }

// class Program
// {
//   static void Main()
//   {
//     var intBox = new StorageBox<int>(42);
//     Console.Write("intBox: ");
//     intBox.DisplayType();
//     Console.WriteLine($"Qiymat: {intBox.Data}");
//   }
// }


// public static class GenericMethod
// {
//   public static void Swap<T>(ref T val1, ref T val2)
//   {
//     T temp = val1;
//     val1 = val2;
//     val2 = temp;
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     int a = 10, b = 20;
//     GenericMethod.Swap<int>(ref a, ref b);
//     Console.WriteLine($"a: {a}, b: {b}");
//   }
// }


// public static class ConstraintExample
// {
//     public static T GetMax<T>(T val1, T val2) where T : IComparable<T>
//   {
//     if (val1.CompareTo(val2) > 0)
//       return val1;
//     return val2;
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     Console.WriteLine(ConstraintExample.GetMax<long>(2, 6));
//   }
// }


// public static class ReferenceTypeProcessor<T> where T : class
// {
//   public static void CheckAndProcess(T obj1, T obj2)
//   {
//     if (obj1 != null && obj2 != null)
//     {
//       Console.WriteLine($"Muvaffaqiyat: {typeof(T).Name} obyekt turlari");
//     }
//     else
//     {
//       Console.WriteLine($"Ogohlantirish: {typeof(T).Name} obyektlardan biri null");
//     }
//   }
// }


// class Program
// {
//   static void Main()
//   {
//     // ReferenceTypeProcessor<string>.CheckAndProcess("q", "b");

//   }
// }


// using System.Runtime.CompilerServices;

// public class ValueTypeProcessor<T> where T : struct
// {
//   public void DisplayInfo(T value)
//   {
//     Console.WriteLine($"Muvaffaqiyat: {typeof(T).Name}. Size: {System.Runtime.InteropServices.Marshal.SizeOf(value)} bayt");
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     var processorInt = new ValueTypeProcessor<float>();
//     processorInt.DisplayInfo(192882892222.2f);
//   }
// }

// public interface IValidatable
// {
//   bool IsValid {get;}
//   void Validate();
// }

// public class User : IValidatable
// {
//   public bool IsValid => !string.IsNullOrEmpty(Name);
//   public string Name {get;set;} = "Ali";
//   public void Validate() => Console.WriteLine($"User {Name} tekshirildi");
// }

// public static class Validator
// {
//   public static void RunValidation<T>(T item) where T : IValidatable
//   {
//     if (item.IsValid)
//     {
//       Console.Write($"[{typeof(T).Name}] Haqiqiy.");
//       item.Validate();
//     }
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     Validator.RunValidation(new User());
//   }
// }



// public class Factory<T> where T : new()
// {
//   public T CreateInstance()
//   {
//     T newObject = new T();
//     Console.WriteLine($"Muvaffaqiyat");
//     return newObject;
//   }
// }

// public static class Constructor
// {
//   public class Report();
//   public class Audit(string creator){}

//   public static void Run()
//   {
//     var reportFactory = new Factory<Report>();
//     reportFactory.CreateInstance();
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     Constructor.Factory<Report>();
//   }
// }


using System.Data;
using System.Security.Cryptography.X509Certificates;

// class ReferenceBox<T> where T : class
// {
//   public T Value {get;set;}

//   public void ShowInfo()
//   {
//     Console.WriteLine($"Type: {typeof(T).Name}");
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     ReferenceBox<string> matn = new ReferenceBox<string>();
//     matn.Value = "Salom";
//     matn.ShowInfo();
//   }
// }


// class ValueBox<T> where T : struct
// {
//   public T Value {get;set;}

//   public ValueBox(T value)
//   {
//     Value = value;
//   }

//   public bool IsDefault()
//   {
//     return Value.Equals(default(T));
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     var son = new ValueBox<int>(0);
//     Console.WriteLine(son.IsDefault());
//   }
// }



// public class DoubleValue<T> where T : struct
// {
//   public T Value {get;set;}

//   public DoubleValue(T value)
//   {
//     dynamic dynamicValue = value;

//     this.Value = dynamicValue * 2;
//   }

//   public void Display()
//   {
//     Console.WriteLine($"Turi: {typeof(T).Name}, Natija (x2): {this.Value}");
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     var son = new DoubleValue<int>(29);
//     son.Display();
//   }
// }

// public class Program
// {
//   public static void Main()
//   {
//     dynamic text = "Uzbekistan";

//     try
//     {
//       text.Add("Toshkent");
//     }
//     catch(Microsoft.CSharp.RuntimeBinder.RuntimeBinderException ex)
//     {
//       Console.WriteLine($"Xato ushlandi: {ex.Message}");
//       Console.WriteLine("Sabab: System.String turi 'ADD' methodini o'z ichiga olmaydi");
//     }
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     string staticText = "Test";

//     dynamic dynamicObj = staticText;
//     dynamicObj.Add(5);
//   }
// }


// public static class MathProcessor<T> where T : struct
// {
//   public static T AddValues(T val1, T val2)
//   {
//     dynamic d1 = val1;
//     dynamic d2 = val2;

//     return d1 + d2;
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     Console.WriteLine(MathProcessor<int>.AddValues(1, 2));
//   }
// }

// class CompareRef<T> where T : class
// {
//   public T Value1 {get;set;}
//   public T Value2 {get;set;}

//   public CompareRef(T v1, T v2)
//   {
//     Value1 = v1;
//     Value2 = v2;
//   }

//   public bool CompareTwo()
//   {
//     return Object.ReferenceEquals(Value1, Value2);
//   }
// }

// class Program
// {
//   static void Main()
//   {
//     var compareref = new CompareRef<string>("3", "2");
//     Console.WriteLine(compareref.CompareTwo());
//   }
// }


// public class OnlyStrings<T> where T : class
// {
//   public OnlyStrings()
//   {
//     if (typeof(T) != typeof(string)) throw new InvalidOperationException($"Xatolik: OnlyStrings<T> faqat string turi bilan ishlay oladi. Berilgan tur: {typeof(T).Name}");
//   }
// }

// public class InstanceCreator<T> where T : new()
// {
//   public T Creator() => new T();
// }

// public class Person
// {
//   public string Name = "New Person";
// }

// class Program
// {
//   static void Main()
//   {
//     var creator = new InstanceCreator<Person>();

//     var p1 = creator.Creator();
//     var p2 = creator.Creator();

//     Console.WriteLine(p1.Name);
//     Console.WriteLine(p2.Name);
//   }
// }


public interface ILogEntity
{
  int Id {get;set;}
}

public class LoggableFactory<T> where T : ILogEntity, new()
{
  public T Create(int id)
  {
    T obj = new T();
    obj.Id = id;
    return obj;
  }
}

public class Person : ILogEntity
{
  public int Id {get;set;}
  public string Name = "New Person";
}

class Program
{
  static void Main()
  {
    var factory = new LoggableFactory<Person>();

    var person = factory.Create(101);
    Console.WriteLine(person.Name);
    Console.WriteLine(person.Id);
  }
}
