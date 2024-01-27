using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Infrastructure.Menu;

namespace ToDoList.Infrastructure
{
    internal class Application
    {
        private readonly TaskMenu _menu;

        public Application(TaskMenu menu)
        {
            _menu = menu;
        }

        public void Run()
        {
           

            bool userQuit = false;

            while (!userQuit)
            {

                List<string> operationNames = ["q - выход из программы", .. _menu.GetOperationNames()];

                Console.WriteLine(string.Join(", ", operationNames));

                Console.Write("Введите номер операции: ");

                string? userInput = Console.ReadLine();
                if (userInput.Trim().ToLower() == "q" && userInput != null)
                {
                    userQuit = true;
                }

                bool isNumber = int.TryParse(userInput, out int operationNumber);
                if (isNumber)
                {
                    _menu.Enter(operationNumber);
                }


            }

        }
    }
}
