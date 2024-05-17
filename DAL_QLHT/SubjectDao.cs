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

        public List<Subject> GetSubjectByGrade(GradeEnum grade)
        {
            using (db = new student_managementContext())
            {
                var query = db.Subjects
                            .Where(s => s.Grade == grade)
                            .Select(s => s);
                return query.ToList<Subject>();
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

        public List<Subject> SearchExcludeAssigned(String keyword, int teacherId)
        {
            using (db = new student_managementContext())
            {
                var assigned = db.Subjects.Where(s => s.Teachers.Any(t => t.Id == teacherId)).ToList();
                var query = db.Subjects.Where(s => s.Name.Contains(keyword) && !assigned.Contains(s));
                return query.ToList<Subject>();
            }
        }
    }
}
