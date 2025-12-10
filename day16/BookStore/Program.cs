var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

// ====================

List<BookDto> books = new();

app.MapGet("/books", () =>
{
  return books;
});

app.MapGet("/books/{id}", (int id) =>
{
  var book = books.First(b => b.Id == id);

  return book is not null ? Results.Ok(book) : Results.NotFound();
});

app.MapPost("/books", (BookDto newBook) =>
{
  var book = new BookDto(
    Id: books.Count + 1,
    Title: newBook.Title
  );

  books.Add(book);
  return Results.Created($"/books/{book.Id}", book);

});

app.Run();
