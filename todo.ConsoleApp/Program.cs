using System;
using System.Collections.Generic;
var todos = new List<string>();
while (true)
{
    Console.WriteLine("\"1) Add todo  2) List todos  3) Exit\"");
    var input = Console.ReadLine();
    if (input == "1")
    {
        Console.Write("Task:");
        var task = Console.ReadLine();
        todos.Add(task);
        Console.WriteLine("added");
    }
    else if (input == "2")
    {
        Console.WriteLine("Todos:");
        foreach (var todo in todos)
        {
            Console.WriteLine(todo);
        }
    }
    else if (input == "3")
    {
        break;
    }
}