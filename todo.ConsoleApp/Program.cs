using System;
using System.Collections.Generic;
using todo.ConsoleApp.Services;

var service = new TodoService();



while (true)
{
    Console.WriteLine("\"1) Add todo  2) List todos  3) Delete  4) Exit\"");
    var input = Console.ReadLine();
    if (input == "1")
    {
        Console.Write("Task:");
        var task = Console.ReadLine();
        service.Add(task);
        Console.WriteLine("added");
    }
    else if (input == "2")
    {
        var todos = service.GetAll();
        foreach (var todo in todos)
        {
            Console.WriteLine($"{todo.Id}. {todo.Tittle}");
        }
    }
    else if (input == "3")
    {
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());
        service.Delete(number);
        Console.WriteLine("removed");
    }
    else if (input == "4")
    {
        break;
    }
}