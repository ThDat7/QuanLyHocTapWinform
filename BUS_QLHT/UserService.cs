using DAL_QLHT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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

        public List<User> SearchUserByRole(String kw, RoleEnum role)
        {
            return userDao.SearchUserByRole(kw, role);
        }

        public User Login(String username, String password)
        {
            User user;
            try
            {
                user = userDao.GetByUsername(username);
            } catch
            {

                throw new Exception("User khong ton tai");
            }

            string enteredHashPassword = HashPassword(password);

            if (user.Password.Equals(enteredHashPassword))
                return user;

            throw new Exception("Password khong khong chinh xac");
        }

        public static string HashPassword(string rawPassword)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(rawPassword));

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        public Boolean CreateUser(User user)
        {
            return userDao.CreateUser(user);
        }

        public Boolean UpdateUser(User user)
        {
            user.Password = HashPassword(user.Password);
            return userDao.UpdateUser(user);
        }

        public Boolean DeleteUser(int id)
        { 
            return userDao.DeleteUser(id);
        }
    }
}
