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
                    Console.WriteLine($"id{task.Id} status {task.IsDone} " + task.Name);
                }
            }
        }

        public static Task? GetById(int id)
        {
            
            using (AppDbContext db = new AppDbContext())
            {
                return db.Tasks.SingleOrDefault(t => t.Id == id);

            }
        }


        public static bool Compete(int id)
        {
            using (AppDbContext db = new AppDbContext())
            {               

                var task = db.Tasks.SingleOrDefault<Task>(t => t.Id == id);
                if (task != null)
                {
                    task.IsDone = true;
                    task.UpdateDate = DateTime.Now;
                    db.SaveChanges();
                    return true;
                }
                return false;

            }
        }

        public static bool Delete(int id)
        {
            using (AppDbContext db = new AppDbContext())
            {
                var task = db.Tasks.SingleOrDefault<Task>(t => t.Id == id);
                if (task != null)
                {
                    db.Tasks.Remove(task);
                    db.SaveChanges();
                    return true;
                }
                return false;
            }
        }

        internal static bool Update(int id, string name, string descript)
        {
            using (AppDbContext db = new AppDbContext())
            {
                var task = db.Tasks.SingleOrDefault<Task>(t => t.Id == id);
                if (task != null)
                {
                    if(string.IsNullOrEmpty(name))
                    {
                        name = task.Name;
                    }

                    if (string.IsNullOrEmpty(descript))
                    {
                        descript = task.Description;
                    }
                       

                    task.Name = name;
                    task.Description = descript;
                    task.UpdateDate = DateTime.Now;

                    db.SaveChanges();
                    return true;
                }
                return false;
            }
        }
    }
}
