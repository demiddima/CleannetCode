using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Models;

namespace ToDoList.Infrastructure
{
    internal static class UserSession
    {
        public static User CurrentUser { get; set; }
    }
}
