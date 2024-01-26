using ToDoList.Operations;

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

            Menu menu = new Menu(operations);
            Application app = new Application(menu);
            app.Run();
        }
    }


}
