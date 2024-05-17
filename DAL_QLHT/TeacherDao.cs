using DTO_QLHT;
using Microsoft.EntityFrameworkCore;
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

        public List<Object> Search(string keyword, int? subjectId)
        {
            using (db = new student_managementContext())
            {
                var query = db.Teachers
                            .Where(t =>
                                (t.User.LastName + " " + t.User.FirstName)
                                    .Contains(keyword) && (subjectId == null || t.Subjects.Any(s => s.Id == subjectId)))
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

        public List<Object> GetAll()
        {
            using(db = new student_managementContext())
            {
                var query = db.Teachers
                    .Select(t => new
                    {
                        Id = t.Id,
                        Name = $"{t.User.LastName} {t.User.FirstName}",
                        Dob = t.User.Dob,
                        Sex = t.User.Sex,
                        Address = t.User.Address
                    });

                return query.ToList<Object>();
            }
        }

        public Object Get(int id)
        {
            using (db = new student_managementContext())
            {
                var query = db.Teachers
                    .Include("Subjects")
                    .Where(t => t.Id == id);

                return query.FirstOrDefault<Object>();
            }
        }

        public Boolean AssignSubject(int teacherId, int subjectId)
        {
            using (var db = new student_managementContext())
            {
                string sql = $"INSERT INTO SubjectTeacher " +
                            $"(SubjectsId, TeachersId) " +
                            $"VALUES ({subjectId}, {teacherId})";
                int rowEffected = db.Database.ExecuteSqlRaw(sql);
                return rowEffected > 0;
            }
        }

        public bool RemoveSubjectToTeacher(int teacherId, int subjectId)
        {
            using (var db = new student_managementContext())
            {
                string sql = $"DELETE FROM SubjectTeacher " +
                            $"WHERE TeachersId={teacherId} AND " +
                            $"SubjectsId={subjectId}";
                int rowEffected = db.Database.ExecuteSqlRaw(sql);
                return rowEffected > 0;
            }
        }
    }
}
