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

        public List<Object> Search(string keyword)
        {
            return teacherDao.Search(keyword);
        }
    }
}
