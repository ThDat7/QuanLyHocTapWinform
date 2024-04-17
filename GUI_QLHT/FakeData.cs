using DTO_QLHT;
using System;
using System.Collections.Generic;
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

            FakeStudent();
            FakeSubject();
            FakeClassroom();
        }

        public  void FakeTeacher()
        {
            for (int i = 0; i < 10; i++) { 
                context.Teachers.Add(new Teacher() { 
                    User = new User() 
                    { 
                        Username = "teacher" + i, Password = "123", Role = RoleEnum.TEACHER,
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
                        Password = "123",
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
                    Password = "123",
                    Role = RoleEnum.ADMIN,
                    FirstName = "" + i,
                    LastName = "last " + i
                });
            }
            context.SaveChanges();
        }

        public void FakeStudent()
        {
            for (int i = 0; i < 10; i++)
            {
                context.Students.Add(new Student()
                {
                    FirstName = "" + i,
                    LastName = "last " + i
                });
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
    }
}
