using DTO_QLHT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QLHT
{
    public class SubjectDao
    {
        private student_managementContext db;
        public SubjectDao()
        {
        }

        public List<Object> GetSubjectByGrade(GradeEnum grade)
        {
            using (db = new student_managementContext())
            {
                var query = from s in db.Subjects
                            where s.Grade == grade
                            select new
                            {
                                s.Id,
                                s.Name,
                                s.Grade
                            };
                return query.ToList<Object>();
            }
        }

        public Boolean CreateSubject(Subject subject)
        {
            using (db = new student_managementContext())
            {
                db.Subjects.Add(subject);
                return db.SaveChanges() > 0;

            }
        }
        public Boolean UpdateSubject(Subject subject)
        {
            using (db = new student_managementContext())
            {
                db.Subjects.Update(subject);
                return db.SaveChanges() > 0;
            }
        }

        public Boolean DeleteSubject(int id)
        {
            using (db = new student_managementContext())
            {
                db.Subjects.Remove(new Subject() { Id = id });
                return db.SaveChanges() > 0;
            }
        }
    }
}
