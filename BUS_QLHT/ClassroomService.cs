using DAL_QLHT;
using DTO_QLHT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_QLHT
{
    public class ClassroomService
    {
        private ClassroomDao classroomDao = new ClassroomDao();
        public ClassroomService() 
        {
        }

        public List<Object> GetClassroomByYear(int year)
        {
            return classroomDao.GetClassroomByYear(year);
        }

        public List<int> GetYearsClassroom()
        {
            return classroomDao.GetYearsClassroom();
        }

        public Boolean CreateClassroom(Classroom classroom)
        {
            return classroomDao.CreateClassroom(classroom);
        }
        public Boolean UpdateClassroom(Classroom classroom)
        {
            return classroomDao.UpdateClassroom(classroom);
        }

        public Boolean DeleteClassroom(int id)
        {
            return classroomDao.DeleteClassroom(id);
        }

        public Object GetHomeroomTeacher(int id)
        {
            return classroomDao.GetHomeroomTeacher(id);
        }

        public List<Object> GetSubjetTeachers(int id)
        {
            return classroomDao.GetSubjetTeachers(id);
        }

        public Boolean AddStudentToClass(int classId, int studentId)
        {
            return classroomDao.AddStudentToClass(classId, studentId);
        }

        public Boolean RemoveStudentInClass(int classId, int studentId)
        {
            return classroomDao.RemoveStudentInClass(classId, studentId);
        }

        public Boolean SetHomeroomTeacher(int classId, int teacherId)
        {
            return classroomDao.SetHomeroomTeacher(classId, teacherId);
        }
    }
}
