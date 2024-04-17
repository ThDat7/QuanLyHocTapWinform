using DTO_QLHT;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QLHT
{
    public class UserDao
    {
        private student_managementContext db;
        public UserDao()
        {
        }

        public User Login(string username, string password)
        {
            var query = from u in db.Users
                        where u.Username == username && u.Password == password
                        select u;
            return (User) query;
        }

        public List<User> GetUserByRole(RoleEnum role)
        {
            using (db = new student_managementContext())
            { 
                var query = from u in db.Users
                            where u.Role == role
                            select new User()
                            {
                                Id = u.Id,
                                Username = u.Username,
                                LastName = u.LastName,
                                FirstName = u.FirstName,
                                Dob = u.Dob,
                                Sex = u.Sex,
                                Address = u.Address,
                                Phone = u.Phone,
                                Email = u.Email
                            };
                return query.ToList<User>();
            }
        }

        public Boolean CreateUser(User user)
        {
            using (db = new student_managementContext())
            {
                db.Users.Add(user);
                return db.SaveChanges() > 0;

            }
        }
        public Boolean UpdateUser(User user)
        {
            using (db = new student_managementContext())
            {
                db.Users.Update(user);
                return db.SaveChanges() > 0;
            }
        }

        public Boolean DeleteUser(int id)
        {
            using (db = new student_managementContext())
            {
                db.Users.Remove(new User() { Id = id });
                return db.SaveChanges() > 0;
            }
        }
    }
}
