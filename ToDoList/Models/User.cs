using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;


namespace ToDoList.Models
{
    public class User
    {
        [Key]
        public Guid Id { get; }
        [EmailAddress]
        [Required]
        public string Email { get; init; }

        public List<Task> Tasks {  get; set; } = new List<Task>();

        public User()
        {
            Id = Guid.NewGuid();
        }
    }
}
