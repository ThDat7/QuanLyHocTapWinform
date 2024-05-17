using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QLHT;

namespace BUS_QLHT
{
    public class TeacherService
    {
        private TeacherDao teacherDao = new TeacherDao();

        public List<Object> SearchNotIsHomeroomTeacher(string keyword, int classroomId)
        {
            return teacherDao.SearchNotIsHomeroomTeacher(keyword, classroomId);
        }

        public List<Object> Search(string keyword, int? subjectId)
        {
            return teacherDao.Search(keyword, subjectId);
        }

        public List<Object> GetAll()
        {
            return teacherDao.GetAll();
        }

        public Object Get(int id) 
        {
            return teacherDao.Get(id);
        }

        public Boolean RemoveSubjectToTeacher(int teacherId, int subjectId)
        {
            return teacherDao.RemoveSubjectToTeacher(teacherId, subjectId);
        }

        public Boolean AssignSubject(int teacherId, int subjectId)
        {
            return teacherDao.AssignSubject(teacherId, subjectId);
        }
    }
}
