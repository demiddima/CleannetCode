using ToDoList.Infrastructure.Menus;
using ToDoList.Operations;
using ToDoList.Operations.TaskOperation;
using ToDoList.Operations.UserOperation;

namespace ToDoList.Infrastructure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IOperation[] accountOperations = new IOperation[]
            {
                new CreateNewUserOperation(),
                new LoginUserOperation()
            };

            IOperation[] taskOperations = new IOperation[]
            {
                new CreateNewTaskOperation(),
                new ReadAllTaskOperation(),
                new UpdateTaskOperation(),
                new CompleteTaskOperation(),
                new DeleteTaskOperation()
            };

            AccountMenu accountMenu = new AccountMenu(accountOperations);
            TaskMenu taskMenu = new TaskMenu(taskOperations);
            Application app = new Application(accountMenu, taskMenu);
            app.Run();
        }
    }


}
