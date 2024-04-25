using DTO_QLHT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DAL_QLHT
{
    public class TeacherDao
    {
        private student_managementContext db;

        public List<Object> SearchNotIsHomeroomTeacher(string keyword, int classroomId)
        {
            using (db = new student_managementContext())
            {
                var query = db.Teachers
                            .Where(t =>
                                (t.User.LastName+" "+t.User.FirstName)
                                    .Contains(keyword)
                                && !(db.Classrooms.Where(c => c.Id==classroomId)
                                    .Any(c => c.HomeroomTeacherId==t.Id)))
                            .Select(t => new
                            {
                                Id = t.Id,
                                Name = $"{t.User.LastName} {t.User.FirstName}",
                                Dob = t.User.Dob,
                                Address = t.User.Address
                            });

                return query.ToList<Object>();
            }
        }

        public List<Object> Search(string keyword)
        {
            using (db = new student_managementContext())
            {
                var query = db.Teachers
                            .Where(t =>
                                (t.User.LastName + " " + t.User.FirstName)
                                    .Contains(keyword))
                            .Select(t => new
                            {
                                Id = t.Id,
                                Name = $"{t.User.LastName} {t.User.FirstName}",
                                Dob = t.User.Dob,
                                Address = t.User.Address
                            });

                return query.ToList<Object>();
            }
        }
    }
}
