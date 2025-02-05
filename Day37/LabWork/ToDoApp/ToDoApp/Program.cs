using ToDoApp.Models;
using static ToDoApp.Models.ToDo;

namespace ToDoApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
           ToDoManager toDoManager = new ToDoManager();
            toDoManager.AddToDo(new ToDo { Id = 1, Description = "Buy milk", IsComplete = false, Priority = PriorityLevel .High});
            toDoManager.AddToDo(new ToDo { Id = 2, Description = "Buy eggs", IsComplete = false, Priority = PriorityLevel.Low });
            toDoManager.AddToDo(new ToDo { Id = 3, Description = "Buy bread", IsComplete = false, Priority= PriorityLevel.High });
            toDoManager.AddToDo(new ToDo { Id = 4, Description = "Buy butter", IsComplete = false, Priority = PriorityLevel.Medium });

            toDoManager.MarkComplete(2);
            toDoManager.RemoveToDoById(3);

            foreach (ToDo toDo in toDoManager.GetToDos())
            {
                Console.WriteLine($"Id: {toDo.Id}, Description: {toDo.Description}, IsComplete: {toDo.IsComplete}, Priority: {toDo.Priority}");
            }
        }
    }
}
