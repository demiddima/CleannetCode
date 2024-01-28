using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Models;
using ToDoList.Storages;
using Task = ToDoList.Models.Task;

namespace ToDoList.Operations.TaskOperation
{
    internal class UpdateTaskOperation : IOperation
    {
        public string Name => "Update the task";
        public void Execute()
        {
            bool isRight = false;
            while (!isRight)
            {
                Console.WriteLine("id задачи для изменения: ");
                if (int.TryParse(Console.ReadLine(), out int id))
                {
                    Console.WriteLine("Заголовок: ");
                    string? name = Console.ReadLine();

                    Console.WriteLine("Описание: ");
                    string? descript = Console.ReadLine();

                    if (TaskStorage.Update(id, name, descript))
                    {
                        Console.WriteLine($"Задача {id} изменена!");
                        isRight = true;
                    }
                    else
                    {
                        Console.WriteLine($"Задачи с {id} не существует");

                    }

                }
            }
        }
    }


}
