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

        public List<Object> Search(string keyword, List<int> excludeIds)
        {
            return teacherDao.Search(keyword, excludeIds);
        }
    }
}
