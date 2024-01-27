using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Models;
using ToDoList.Storages;

namespace ToDoList.Operations.UserOperation
{
    internal class CreateNewUserOperation : IOperation
    {
        public string Name => "Create new user";
        public void Execute()
        {
            Console.Write("Введите свой email: ");
            string? email = Console.ReadLine();


            User newUser = new User()
            {
                Email = email
            };

            bool userCreated = UserStorage.Create(newUser);
            if (!userCreated)
            {
                Console.WriteLine("Пользователь с таким email уже существует");
            }
            else
            {
                Console.WriteLine("Пользователь создан");
            }

            
        }
    }
}
