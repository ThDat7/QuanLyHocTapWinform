using DAL_QLHT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_QLHT
{
    public class StudentService
    {
        StudentDao studentDao = new StudentDao();
        public List<Object> GetStudents()
        {
            return studentDao.GetStudents();
        }

        public Boolean CreateStudent(Student student)
        {
            return studentDao.CreateStudent(student);
        }

        public Boolean UpdateStudent(Student student)
        {
            return studentDao.UpdateStudent(student);
        }

        public Boolean DeleteStudent(int id)
        {
            return studentDao.DeleteStudent(id);
        }

        public List<Object> GetInClass(int classroomId)
        {
            return studentDao.GetInClass(classroomId);
        }

        public List<Object> SearchAddToClassroom(string keyword, int classroomId)
        {
            
            return studentDao.SearchNotInClassroom(keyword, classroomId);
        }
    }
}
