using DTO_QLHT;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QLHT
{
    public class TeachDao
    {
        private student_managementContext db;
        private student_managementContext tracked_db = new student_managementContext();
        public TeachDao()
        {
        }
        public List<Object> GetTeachesByUserId(int userId)
        {
            using (db = new student_managementContext())
            {
                var query = from teach in db.Teaches
                            join teacher in db.Teachers on teach.TeacherId equals teacher.Id
                            join classroom in db.Classrooms on teach.ClassroomId equals classroom.Id
                            join subject in db.Subjects on teach.SubjectId equals subject.Id
                            //where teacher.UserId == userId
                            select new
                            {
                                TeachId = teach.Id,
                                classroom.Year,
                                classroom.Grade,
                                classroom.Order,
                                subject.Name
                            };
                return query.ToList<Object>();
            }
        }

        public Teach GetExamByTeachId(int teachId)
        {
            var query = from teach in tracked_db.Teaches
                        .Include("Classroom")
                        .Include("SubjectGrade")
                        .Include("SubjectGrade.Student")
                        .Include("SubjectGrade.SubjectGradeSemesters")
                        .Include("SubjectGrade.SubjectGradeSemesters.NormalGrades")
                        .Include("SubjectGrade.SubjectGradeSemesters.FinalGrade")
                        where teach.Id == 2
                        select teach;

            return query.First<Teach>();
        }

        public Boolean UpdateTeach(Teach teach)
        {
            tracked_db.Update(teach);
            return tracked_db.SaveChanges() > 0;
        }

        public Boolean AddTeach(int classroomId, int teacherId, int subjectId)
        {
            using(db = new student_managementContext())
            {
                Teach t = new Teach() { ClassroomId = classroomId, TeacherId = teacherId, SubjectId = subjectId };
                db.Teaches.Add(t);
                return db.SaveChanges() > 0;
            }
        }
    }
}
