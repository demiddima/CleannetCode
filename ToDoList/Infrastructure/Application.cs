using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Infrastructure
{
    internal class Application
    {
        private readonly Menu _menu;

        public Application(Menu menu)
        {
            _menu = menu;
        }

        public void Run()
        {
           

            bool userQuit = false;

            while (!userQuit)
            {

                List<string> operationNames = new List<string>();
                operationNames.Add("q - выход из программы");
                operationNames.AddRange(_menu.GetOperationNames());

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
