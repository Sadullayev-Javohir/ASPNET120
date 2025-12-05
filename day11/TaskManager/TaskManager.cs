namespace TaskManagerCLI;

public class TaskManager
{
  private List<TaskItem> _tasks = new List<TaskItem>();
  private int _nextId = 1;

  public void AddTask(string title)
  {
    var task = new TaskItem(_nextId++, title);
    _tasks.Add(task);
    Console.WriteLine("Task qo'shildi");
  }

  public void ListTasks()
  {
    Console.WriteLine("\n --- VAZIFALAR RO'YXATI ---");
    if (_tasks.Count == 0)
    {
      Console.WriteLine("Ro'yxat bo'sh");
      return;
    }

    foreach(var task in _tasks)
    {
      Console.WriteLine(task.ToString());
    }
  }

  public void RemoveTask(int id)
  {
    var task = _tasks.FirstOrDefault(t => t.Id == id);
    if (task != null)
    {
      _tasks.Remove(task);
      Console.WriteLine($"{task.Title} o'chirildi");
    }
    else
    {
      Console.WriteLine("Topilmadi");
    }
  }

  public void CompleteTask(int id)
  {
    var task = _tasks.FirstOrDefault(t => t.Id == id);

    if (task != null)
    {
      task.IsCompleted = true;
      Console.WriteLine($"{task.Title} bajarildi");
    }
    else
    {
      Console.WriteLine("Topilmadi");
    }
  }
}
