using ToDoList.Storages;

namespace ToDoList.Operations.TaskOperation
{
    public class CompleteTaskOperation : IOperation
    {
        public string Name => "Complete the task";
        public void Execute()
        {
            bool isRight = false; 
            while(!isRight)
            {
                Console.WriteLine("id выполненной задачи: ");
                if(int.TryParse(Console.ReadLine(), out int id))
                {
                    if (TaskStorage.Compete(id))
                    {
                        Console.WriteLine($"Задача {id} выполнена!");
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
