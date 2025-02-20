﻿// See https://aka.ms/new-console-template for more information
using WorkingWithLists.Models;



namespace WorkingWithLists
{
    internal class Program
    {
        static void Main(string[] args)
        {   //var todo1 = new Todo();
            //todo1.Name = "Clean room";
            //todo1.Description = "Just clean the room";
            //todo1.Completed = false;

            //var todo2 = new Todo()
            //{
            //    Name = "Wash clothes",
            //    Description = "Just use the washing machine",
            //    Completed = true
            //};
            //var todo3 = new Todo()
            //{
            //    Name = "Wash clothes",
            //    Description = "Just use the washing machine",
            //    Completed = true
            //};
            //var todos = new List<Todo>();
            //todos.Add(todo1);
            //todos.Add(todo2);
            //todos.Add(todo3);

            //// forEach -> forEach
            //todos.ForEach(todo => todo.Description = "");

            //// filter -> Where
            ////var todos2 = new List<Todo>();
            //todos/*2*/ = todos.Where(t => t.Completed == true).ToList();
            //// map -> Select
            //var names = todos.Select(t => t.Name + t.Description).ToList();



            var todos = new List<Todo>();

            while (true)
            {
                Console.WriteLine("Please enter your command: 'Add' or 'List'");
                var command = Console.ReadLine();

                if(command == "Add")
                {
                    Console.WriteLine("Please enter the name");
                    var name = Console.ReadLine();
                    Console.WriteLine("Please enter the description");
                    var description = Console.ReadLine();

                    var todo = new Todo(name, description);
                    todos.Add(todo);
                }
                else if(command == "List")
                {
                    Console.WriteLine("Executing list");
                    foreach(var todo in todos)
                    {
                        Console.WriteLine($"Name: {todo.Name}, Description: {todo.Description}");
                    }
                }
                else
                {
                    Console.WriteLine("Unknown command");
                }
            }
        }
    }
}