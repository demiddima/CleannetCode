using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using ToDoList.Infrastructure;
using ToDoList.Models;
using ToDoList.Storages;

namespace ToDoList.Operations
{
    internal class LoginUserOperation : IOperation
    {
        public string Name => "LogIn";
        public void Execute()
        {
            Console.Write("Введите ваш email: ");
            string? email = Console.ReadLine();
            User? user = UserStorage.Get(email);

            if (user == null)
            {
                UserSession.CurrentUser = user;
            }
        }
    }
}
