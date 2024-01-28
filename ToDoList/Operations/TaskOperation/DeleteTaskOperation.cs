using ToDoList.Storages;

namespace ToDoList.Operations.TaskOperation
{
    public class DeleteTaskOperation : IOperation
    {
        public string Name => "Delete the task";
        public void Execute()
        {
            bool isRight = false;
            while (!isRight)
            {
                Console.WriteLine("id задачи для удаления: ");
                if (int.TryParse(Console.ReadLine(), out int id))
                {
                    if (TaskStorage.Delete(id))
                    {
                        Console.WriteLine($"Задача {id} удалена!");
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
