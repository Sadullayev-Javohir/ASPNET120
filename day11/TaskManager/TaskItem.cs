namespace TaskManagerCLI;

public class TaskItem
{
  public int Id {get;set;}
  public string Title {get; set;}
  public bool IsCompleted {get;set;}
  public DateTime CreateTime {get;set;}

  public TaskItem(int id, string title)
  {
    Id = id;
    Title = title;
    IsCompleted = false;
    CreateTime = DateTime.Now;
  }

  public override string ToString()
  {
    string status = IsCompleted ? "✅" : "◌";
    return $"{Id}. {Title}: {status} : {CreateTime:dd:MM:yyyy: HH:mm}";
  }
}
