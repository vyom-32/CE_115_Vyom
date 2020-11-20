using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sudoku.Models
{
    public interface IUserRepository
    {
        User GetUser(int Id);
        User AddUser(User user);
        User UpdateUser(User user);
        User DeleteUser(int Id);
        List<User> GetAllUsers();
    }
}
