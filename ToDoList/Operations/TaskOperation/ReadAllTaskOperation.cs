using ToDoList.Storages;

namespace ToDoList.Operations.TaskOperation
{
    public class ReadAllTaskOperation : IOperation
    {
        public string Name => "Read all the tasks";
        public void Execute()
        {
            TaskStorage.ReadAllTasks();
        }
    }
}
