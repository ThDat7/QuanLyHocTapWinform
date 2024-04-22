using DAL_QLHT;
using DTO_QLHT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_QLHT
{
    public class SubjectGradeService
    {
        private SubjectGradeDao SubjectGradeDao = new SubjectGradeDao();

        public List<Dictionary<String, object>> GetAvgExamByClass(int classroomId, SemesterEnum? semester)
        {
            return SubjectGradeDao.GetAvgExamByClass(classroomId, semester);
        }
    }
}
