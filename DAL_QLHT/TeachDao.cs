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
                        where teach.Id == teachId
                        select teach;

            return query.First<Teach>();
        }

        public Boolean UpdateTeach(Teach teach)
        {
            tracked_db.Update(teach);
            return tracked_db.SaveChanges() > 0;
        }

        public int AddTeach(int classroomId, int teacherId, int subjectId)
        {
            using(db = new student_managementContext())
            {
                Teach t = new Teach() { ClassroomId = classroomId, TeacherId = teacherId, SubjectId = subjectId };
                db.Teaches.Add(t);
                db.SaveChanges();
                return t.Id;
            }
        }

        public Boolean RemoveTeach(int teachId)
        {
            using (db = new student_managementContext())
            {
                string sql = $"DELETE FROM Teaches " +
                            $"WHERE Id={teachId}";
                int rowEffected = db.Database.ExecuteSqlRaw(sql);
                return rowEffected > 0;
            }
        }

        public Boolean IsGradeExists(int teachId)
        {
            using (db = new student_managementContext())
            {
                var count = db.SubjectGrades
                               .Where(sg => sg.TeachId==teachId)
                               .Count();
                return count > 0;
            }
        }

        public Teach CreateSubjectForTeach(int teachId)
        {
            Teach t = tracked_db.Teaches
                .Where(t => t.Id == teachId)
                .Include("Classroom.Students")
                .FirstOrDefault();

            if (t.Classroom.Students?.Count == 0)
                return t;

            t.SubjectGrade = new List<SubjectGrade>();

            foreach(Student s in t.Classroom.Students)
            {
                NormalGrade ng115 = new NormalGrade() { Factor = FactorEnum.I };
                NormalGrade ng215 = new NormalGrade() { Factor = FactorEnum.I };
                NormalGrade ng145 = new NormalGrade() { Factor = FactorEnum.II };
                NormalGrade ng245 = new NormalGrade() { Factor = FactorEnum.II };

                SubjectGradeSemester sgs1 = new SubjectGradeSemester()
                {
                    Semester = SemesterEnum.I,
                    NormalGrades = new List<NormalGrade>() { ng115, ng145 },
                    FinalGrade = new FinalGrade()
                };
                SubjectGradeSemester sgs2 = new SubjectGradeSemester() { 
                    Semester = SemesterEnum.II,
                    NormalGrades = new List<NormalGrade>() { ng215, ng245 },
                    FinalGrade = new FinalGrade()
                };

                SubjectGrade sg = new SubjectGrade() { 
                    TeachId = t.Id, 
                    StudentId = s.Id, 
                    SubjectGradeSemesters = new List<SubjectGradeSemester>() { sgs1, sgs2}
                };

                t.SubjectGrade.Add(sg);
            }

            tracked_db.Update(t);
            tracked_db.SaveChanges();
            return t;
        }
    }
}
