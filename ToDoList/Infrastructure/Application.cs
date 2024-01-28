using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Infrastructure.Menus;

namespace ToDoList.Infrastructure
{
    internal class Application
    {
        private Menu _currentMenu;
        private readonly AccountMenu _accountMenu;
        private readonly TaskMenu _taskMenu;
        

        public Application(AccountMenu accountMenu, TaskMenu taskMen)
        {
            _accountMenu = accountMenu;
            _taskMenu = taskMen;
        }

        public void Run()
        {
           

            bool userQuit = false;

            while (!userQuit)
            {

                // Выбор между меню для учетной записи и меню для задач
                _currentMenu = UserSession.isLoggedIn ? _taskMenu : _accountMenu;

                List<string> operationNames = ["q - выход из программы", .. _currentMenu.GetOperationNames()];

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
                    _currentMenu.Enter(operationNumber);
                }

            }

        }
    }
}
