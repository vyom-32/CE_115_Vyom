using sudoku.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sudoku
{
    public class SQLUserRepository : IUserRepository
    {
        private readonly AppDbContext context;

        public SQLUserRepository(AppDbContext context)
        {
            this.context = context;
        }

        public User AddUser(User user)
        {
            context.User.Add(user);
            context.SaveChanges();
            return user;
        }

        public User DeleteUser(int Id)
        {
            User user = context.User.Find(Id);
            context.User.Remove(user);
            context.SaveChanges();
            return user;
        }

        public List<User> GetAllUsers()
        {
            return context.User.ToList();
        }

        public User GetUser(int Id)
        {
            return context.User.Find(Id);
        }

        public User UpdateUser(User user)
        {
            context.User.Update(user);
            context.SaveChanges();
            return context.User.Find(user.UserId);
        }
    }
}
