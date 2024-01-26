using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Models
{
    internal class User
    {
        public User()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; }
        public string Email { get; init; }
    }
}
