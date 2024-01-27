using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Models
{
    internal class User
    {
        [Key]
        public Guid Id { get; }
        [EmailAddress]
        [Required]
        public string Email { get; init; }

        public User()
        {
            Id = Guid.NewGuid();
        }
    }
}
