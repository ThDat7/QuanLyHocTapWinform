using DAL_QLHT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_QLHT
{
    public class UserService
    {
        UserDao userDao = new UserDao();
        public List<User> GetUserByRole(RoleEnum role)
        {
            return userDao.GetUserByRole(role);
        }

        public Boolean CreateUser(User user)
        {
            return userDao.CreateUser(user);
        }

        public Boolean UpdateUser(User user)
        {
            return userDao.UpdateUser(user);
        }

        public Boolean DeleteUser(int id)
        { 
            return userDao.DeleteUser(id);
        }
    }
}
