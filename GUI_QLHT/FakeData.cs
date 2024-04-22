using BUS_QLHT;
using DTO_QLHT;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Data;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_QLHT
{
    internal class FakeData
    {
        student_managementContext context = new student_managementContext();
        public void CreateFakeData()
        {
            FakeTeacher();
            FakeStaff();
            FakeAdmin();
            FakeClassroom();
            FakeStudent();
            FakeSubject();
            FakeTeach();
            FakeSubjectGrade();

        }

        public  void FakeTeacher()
        {
            for (int i = 0; i < 10; i++) { 
                context.Teachers.Add(new Teacher() { 
                    User = new User() 
                    { 
                        Username = "teacher" + i, Password = UserService.HashPassword("123"), Role = RoleEnum.TEACHER,
                        FirstName = ""+ i,
                        LastName = "last " + i
                    } 
                });
            }
            context.SaveChanges();
        }

        public void FakeStaff()
        {
            for (int i = 0; i < 10; i++)
            {
                context.Users.Add( new User()
                    {
                        Username = "staff" + i,
                        Password = UserService.HashPassword("123"),
                        Role = RoleEnum.STAFF,
                        FirstName = "" + i,
                        LastName = "last " + i
                });
            }
            context.SaveChanges();
        }

        public void FakeAdmin()
        {
            for (int i = 0; i < 10; i++)
            {
                context.Users.Add(new User()
                {
                    Username = "admin" + i,
                    Password = UserService.HashPassword("123"),
                    Role = RoleEnum.ADMIN,
                    FirstName = "" + i,
                    LastName = "last " + i
                });
            }
            context.SaveChanges();
        }

        public void FakeClassroom()
        {
            for (int i = 0; i < 3; i++)
            {
                context.Classrooms.Add(new Classroom()
                {
                    Grade = GradeEnum.TENTH,
                    Order = i,
                    Year = 2022 + i
                });

                context.Classrooms.Add(new Classroom()
                {
                    Grade = GradeEnum.ELEVENTH,
                    Order = i,
                    Year = 2022 + i
                });

                context.Classrooms.Add(new Classroom()
                {
                    Grade = GradeEnum.TWELVETH,
                    Order = i,
                    Year = 2020 + i
                });
            }
            context.SaveChanges();
        }

        public void FakeStudent()
        {
            var classrooms = context.Classrooms.ToList();

            for (int i = 0; i < 10; i++)
            {
                var student = new Student()
                {
                    FirstName = "" + i,
                    LastName = "last " + i,
                    Classrooms = classrooms.Take(2).ToList()
                };

                context.Students.Add(student);
            }
            context.SaveChanges();
        }

        public void FakeSubject()
        {
            for (int i = 0; i < 3; i++)
            {
                context.Subjects.Add(new Subject()
                {
                    Name = "subject" + i,
                    Grade = GradeEnum.TENTH
                });

                context.Subjects.Add(new Subject()
                {
                    Name = "subject" + i,
                    Grade = GradeEnum.ELEVENTH
                });

                context.Subjects.Add(new Subject()
                {
                    Name = "subject" + i,
                    Grade = GradeEnum.TWELVETH
                });
            }
            context.SaveChanges();
        }
        public void FakeTeach()
        {
            var random = new Random();
            var teachers = context.Teachers.ToList();
            var subjects = context.Subjects.ToList();
            var classrooms = context.Classrooms.ToList();

            foreach (var classroom in classrooms)
            {
                for (int i = 0; i < 3; i++)
                {
                    var randomSubject = subjects[random.Next(subjects.Count)];

                    context.Teaches.Add(new Teach()
                    {
                        TeacherId = teachers[random.Next(teachers.Count)].Id,
                        SubjectId = randomSubject.Id,
                        ClassroomId = classroom.Id
                    });
                }
            }

            context.SaveChanges();
        }

        public void FakeNormalExams(SubjectGradeSemester exam)
        {
            var random = new Random();
            var factors = Enum.GetValues(typeof(FactorEnum)).Cast<FactorEnum>().ToList();

            foreach (var factor in factors)
            {
                context.NormalGrades.Add(new NormalGrade()
                {
                    SubjectGradeSemester = exam,
                    Factor = factor,
                    Score = random.Next(0, 11) * 1.0f
                });
            }
        }

        public void FakeFinalExam(SubjectGradeSemester exam)
        {
            var random = new Random();
            context.FinalGrades.Add(new FinalGrade()
            {
                SubjectGradeSemester = exam,
                Score = random.Next(0, 11) * 1.0f
            });
        }

        public void FakeSubjectGrade()
        {
            var teaches = context.Teaches.ToList();

            foreach (var teach in teaches)
            {
                var classroom = teach.Classroom;
                if (classroom.Students.IsNullOrEmpty())
                    continue;
                foreach (var student in classroom.Students)
                {
                    var subjectGrade = new SubjectGrade()
                    {
                        StudentId = student.Id,
                        TeachId = teach.Id
                    };

                    context.SubjectGrades.Add(subjectGrade);

                    foreach (var semester in Enum.GetValues(typeof(SemesterEnum)).Cast<SemesterEnum>())
                    {
                        var subjectGradeSemester = new SubjectGradeSemester()
                        {
                            Semester = semester,
                            SubjectGrade = subjectGrade
                        };
                        context.SubjectGradeSemesters.Add(subjectGradeSemester);

                        FakeNormalExams(subjectGradeSemester);
                        FakeFinalExam(subjectGradeSemester);
                    }
                }
            }

            context.SaveChanges();
        }
    }
}
