using todo.ConsoleApp.Models;
namespace todo.ConsoleApp.Services;

public class TodoService
{
    private List<Todo> _todos = new();
    private int _nextId = 1;

    public void Add(string title)
    {
        var todo = new Todo
        {
            Id = _nextId++,
            Tittle = title,
            IsCompleted = false
        };

        _todos.Add(todo);
    }

    public List<Todo> GetAll()
    {
        return _todos;
    }

    public void Delete(int id)
    {
        var toto = _todos.FirstOrDefault(t => t.Id == id);
        if (toto != null)
        {
            _todos.Remove(toto);
        }
    }
}