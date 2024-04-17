using DTO_QLHT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QLHT
{
    public class ClassroomDao
    {
        private student_managementContext db;
        public ClassroomDao()
        {
        }

        public List<Object> GetClassroomByYear(int year)
        {
            using (db = new student_managementContext())
            {
                var query = from c in db.Classrooms
                            where c.Year == year
                            select new
                            {
                                c.Id,
                                c.Grade,
                                c.Order,
                                c.Year
                            };
                return query.ToList<Object>();
            }
        }

        public List<int> GetYearsClassroom()
        {
            using (db = new student_managementContext())
            {
                var query = from c in db.Classrooms
                             group c by c.Year into yearGroup
                             select yearGroup.Key;
                return query.ToList<int>();
            }
        }

        public Boolean CreateClassroom(Classroom classroom)
        {
            using (db = new student_managementContext())
            {
                db.Classrooms.Add(classroom);
                return db.SaveChanges() > 0;

            }
        }
        public Boolean UpdateClassroom(Classroom classroom)
        {
            using (db = new student_managementContext())
            {
                db.Classrooms.Update(classroom);
                return db.SaveChanges() > 0;
            }
        }

        public Boolean DeleteClassroom(int id)
        {
            using (db = new student_managementContext())
            {
                db.Classrooms.Remove(new Classroom() { Id = id });
                return db.SaveChanges() > 0;
            }
        }
    }
}
