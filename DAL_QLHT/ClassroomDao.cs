using DTO_QLHT;
using Microsoft.EntityFrameworkCore;
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

        private student_managementContext tracked_db = new student_managementContext();
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
                //var query = from c in db.Classrooms
                //             group c by c.Year into yearGroup
                //             select yearGroup.Key;
                var query = db.Classrooms
                            .Select(c => c.Year)
                            .Distinct()
                            .OrderByDescending(y => y);
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

        public Object GetHomeroomTeacher(int id)
        {
            using (db = new student_managementContext())
            {
                var query = db.Classrooms
                    .Where(c => c.Id == id && c.HomeroomTeacher != null)
                    .Select(c => new
                    {
                        Id = c.HomeroomTeacher.Id,
                        Name = $"{c.HomeroomTeacher.User.LastName} {c.HomeroomTeacher.User.FirstName}",
                        Dob = c.HomeroomTeacher.User.Dob,
                        Address = c.HomeroomTeacher.User.Address
                    });

                return query.FirstOrDefault();
            }
        }

        public List<Object> GetSubjetTeachers(int id)
        {
            id = 2;
            using (db = new student_managementContext())
            {
                var query = from teach in db.Teaches
                            join teacher in db.Teachers on teach.TeacherId equals teacher.Id
                            join subject in db.Subjects on teach.SubjectId equals subject.Id
                            where teach.ClassroomId == id
                            select new
                            {
                                Id = teacher.Id,
                                SubjectName = subject.Name,
                                Name = $"{teacher.User.LastName} {teacher.User.FirstName}",
                                Dob = teacher.User.Dob,
                                Address = teacher.User.Address
                            };
                return query.ToList<Object>();
            }
        }

        public Classroom GetByIdWithStudents(int id)
        {
            using (db = new student_managementContext())
            {
                var query = db.Classrooms
                            .Include("Students")
                            .Where(c => c.Id == id)
                            .Select(c => c);
                return query.FirstOrDefault();
            }
        }

        public Boolean AddStudentToClass(int classroomId, int studentId)
        {
            using (var db = new student_managementContext())
            {
                string sql = $"INSERT INTO ClassroomStudent " +
                            $"(ClassroomsId, StudentsId) " +
                            $"VALUES ({classroomId}, {studentId})";
                int rowEffected = db.Database.ExecuteSqlRaw(sql);
                return rowEffected > 0;
            }
        }

        public Boolean RemoveStudentInClass(int classId, int studentId)
        {
            using (var db = new student_managementContext())
            {
                string sql = $"DELETE FROM ClassroomStudent " +
                            $"WHERE ClassroomsId={classId} AND " +
                            $"StudentsId={studentId}";
                int rowEffected = db.Database.ExecuteSqlRaw(sql);
                return rowEffected > 0;
            }
        }


        public Boolean SetHomeroomTeacher(int classId, int teacherId)
        {
            using (var db = new student_managementContext())
            {
                string sql = $"UPDATE Classrooms SET HomeroomTeacherId={teacherId} " +
                            $"WHERE Id={classId}";
                int rowEffected = db.Database.ExecuteSqlRaw(sql);
                return rowEffected > 0;
            }
        }

        public GradeEnum GetGradeById(int classId)
        {
            using (var db = new student_managementContext())
            {
                var query = db.Classrooms
                            .Where(c => c.Id == classId)
                            .Select(c => c.Grade);
                return query.FirstOrDefault<GradeEnum>();
            }
        }

    }
}
