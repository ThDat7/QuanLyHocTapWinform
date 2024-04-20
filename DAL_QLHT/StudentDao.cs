using DTO_QLHT;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QLHT
{
    public class StudentDao
    {
        private student_managementContext db;
        public StudentDao()
        {
        }

        public List<Object> GetStudents()
        {
            using (db = new student_managementContext())
            {
                var query = from s in db.Students
                            select s;
                return query.ToList<Object>();
            }
        }

        public Boolean CreateStudent(Student student)
        {
            using (db = new student_managementContext())
            {
                db.Students.Add(student);
                return db.SaveChanges() > 0;

            }
        }
        public Boolean UpdateStudent(Student student)
        {
            using (db = new student_managementContext())
            {
                db.Students.Update(student);
                return db.SaveChanges() > 0;
            }
        }

        public Boolean DeleteStudent(int id)
        {
            using (db = new student_managementContext())
            {
                db.Students.Remove(new Student() { Id = id });
                return db.SaveChanges() > 0;
            }
        }

        public List<Object> GetInClass(int classroomId)
        {
            using (db = new student_managementContext())
            {
                var query = db.Students
                    .Where(s => s.Classrooms.Any(c => c.Id == classroomId))
                    .Select(s => new
                    {
                        s.Id,
                        name = $"{s.LastName} {s.FirstName}",
                        s.Dob,
                        s.Address
                    });

                return query.ToList<Object>();
            }
        }

        public List<Object> Search(string keyword, List<int> excludeIds)
        {
            using(db = new student_managementContext())
            {
                var query = db.Students
                            .Where(s => (s.LastName+" "+s.FirstName)
                                            .Contains(keyword)
                                        && !excludeIds.Contains(s.Id))
                            .Select(s => new
                            {
                                s.Id,
                                name = $"{s.LastName} {s.FirstName}",
                                s.Dob,
                                s.Address
                            });
                return query.ToList<Object>();
            }
        }
    }
}
