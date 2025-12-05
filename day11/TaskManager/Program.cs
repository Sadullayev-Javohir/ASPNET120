namespace TaskManagerCLI;

public class Program
{
  static void Main()
  {
    TaskManager manager = new TaskManager();
    bool running = true;

    while (running)
    {
      Console.WriteLine("\n=== TASK MANAGER CLI ===");
      Console.WriteLine("1. Vazifa qo'shish");
      Console.WriteLine("2. Vazifalarni ko'rish");
      Console.WriteLine("3. Vazifani bajarish (Complete)");
      Console.WriteLine("4. Vazifani o'chirish");
      Console.WriteLine("5. Chiqish");
      Console.Write("Tanlang: ");

      string choice = Console.ReadLine();

      switch(choice)
      {
        case "1":
          Console.Write("Vazifa nomini kiriting: ");
          string title = Console.ReadLine();
          if (!string.IsNullOrWhiteSpace(title))
          {
            manager.AddTask(title);
          }
          break;
        case "2":
          manager.ListTasks();
          break;
        case "3":
          Console.Write("Bajarilgan vazifa ID sini kiriting: ");
          if (int.TryParse(Console.ReadLine(), out int completeId))
          {
            manager.CompleteTask(completeId);
          }
          else
          {
            Console.WriteLine("Noto'g'ri Id kiritildi");
          }
          break;
        case "4":
          Console.Write("O'chirmoqchi bo'lgan vazifa ID sini kiriting: ");
          if (int.TryParse(Console.ReadLine(), out int removeId))
          {
            manager.RemoveTask(removeId);
          }
          else
          {
            Console.WriteLine("Noto'g'ri id kiritildi");
          }
          break;
        case "5":
          running = false;
          Console.WriteLine("Dastur tugadi");
          break;
        default:
          Console.WriteLine("Noto'g'ri buyruq.");
          break;
      }
    }
  }
}
