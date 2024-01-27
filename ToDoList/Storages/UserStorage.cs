using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Context;
using ToDoList.Models;

namespace ToDoList.Storages
{
    internal static class UserStorage
    {

        public static User? Get(string email)
        {
            using (AppDbContext db = new AppDbContext())
            {
                User? user  = db.Users.SingleOrDefault(u => u.Email == email);
                return user;
            }
        }

        public static bool Create(User user)
        {
            using (AppDbContext db = new AppDbContext())
            {
                User? checkUser = Get(user.Email);
                if (checkUser == null)
                {
                    db.Users.Add(user);
                    db.SaveChanges();
                    return true;
                }
            }

            return false;

        }
    }
}
