using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Operations;

namespace ToDoList.Infrastructure.Menus
{
    public class AccountMenu : Menu
    {
        public AccountMenu(IOperation[] operations) : base(operations)
        {
        }
    }
}
