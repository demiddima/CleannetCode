using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ToDoList.Infrastructure;
using ToDoList.Models;
using ToDoList.Storages;
using Task = ToDoList.Models.Task;


namespace ToDoList.Operations.TaskOperation
{
    internal class CreateNewTaskOperation : IOperation
    {
        public string Name => "Create new Task";
        public void Execute()
        {
            Console.WriteLine("Введите заголовок задачи: ");
            string? title = Console.ReadLine();

            Console.WriteLine("Введите описание задачи: ");
            string? descript = Console.ReadLine();

            Task newTask = new Task()
            {
                Name = title,
                Description = descript,
                CreateDate = DateTime.Now,
                UpdateDate = DateTime.Now,
                UserId = UserSession.CurrentUser.Id

            };

            TaskStorage.Create(newTask);
        }
    }
}
