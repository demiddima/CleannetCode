using ToDoList.Infrastructure.Menu;
using ToDoList.Operations;
using ToDoList.Operations.UserOperation;

namespace ToDoList.Infrastructure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IOperation[] operations = new IOperation[]
            {
                new CreateNewUserOperation(),
                new LoginUserOperation()
            };

            TaskMenu menu = new TaskMenu(operations);
            Application app = new Application(menu);
            app.Run();
        }
    }


}
