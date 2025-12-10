var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

// ==================
List<MyTask> _tasks = new List<MyTask>();

app.MapGet("/tasks", () =>
{
  return _tasks;
});

app.MapGet("/tasks/{id}", (int id) =>
{
  var task = _tasks.FirstOrDefault(b => b.Id == id);

  return task is not null ? Results.Ok(task) : Results.NotFound();
});

app.MapPost("/tasks", (MyTask task) =>
{
  int newId = _tasks.Count == 0 ? 1 : _tasks.Max(t => t.Id) + 1;
  var newTask =  new MyTask
  {
    Id = _tasks.Count + 1,
    TaskName = task.TaskName
  };

  _tasks.Add(newTask);

  return Results.Created($"/tasks/{newTask.Id}", newTask);
});

app.MapDelete("/tasks/{id}", (int id) =>
{
  var task = _tasks.FirstOrDefault(t => t.Id == id);

  if (task == null) return Results.NotFound();

  _tasks.Remove(task);

  return Results.NoContent();
});

// ==================


app.Run();

public class MyTask
{
  public int Id {get;set;}
  public string TaskName {get;set;}
}
