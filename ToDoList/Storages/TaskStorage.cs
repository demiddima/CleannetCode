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

        public static bool Check(int id)
        {
            
            using (AppDbContext db = new AppDbContext())
            {
                Task? task = db.Tasks.SingleOrDefault(t => t.Id == id);
                return task != null;

            }
        }


        public static bool Compete(int id)
        {
            using (AppDbContext db = new AppDbContext())
            {               
                if(Check(id))
                {
                    var task = db.Tasks.SingleOrDefault<Task>(t => t.Id == id);
                    task.IsDone = false;
                    task.UpdateDate = DateTime.Now;
                    db.SaveChanges();
                    return true;
                }
                else { return false; }
            }
        }
    }
}
