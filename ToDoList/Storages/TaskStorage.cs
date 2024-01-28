using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ToDoList.Context;
using ToDoList.Infrastructure;
using Task = ToDoList.Models.Task;

namespace ToDoList.Storages
{
    public class TaskStorage
    {
        public static void Create(Task newTask)
        {
            using(AppDbContext db = new AppDbContext())
            {
                db.Tasks.Add(newTask);
                db.SaveChanges();
                Console.WriteLine($"Задача добавлена, её номер - {newTask.Id}");
            }
        }

        public static void ReadAllTasks()
        {
            using (AppDbContext db = new AppDbContext())
            {
                List<Task> tasks = db.Tasks.Where(g => g.UserId == UserSession.CurrentUser.Id).ToList();

                foreach(var task in tasks)
                {
                    Console.WriteLine($"id{task.Id} " + task.Name);
                }
            }
        }
    }
}
