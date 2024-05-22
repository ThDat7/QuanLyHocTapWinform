using DAL_QLHT;
using DTO_QLHT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_QLHT
{
    public class SubjectService
    {
        SubjectDao subjectDao = new SubjectDao();

        public List<Subject> GetSubjectNoAssignedByGrade(GradeEnum grade, int classroomId)
        {
            return subjectDao.GetSubjectNoAssignedByGrade(grade, classroomId);
        }

        public List<Subject> GetSubjectByGrade(GradeEnum grade)
        {
            return subjectDao.GetSubjectByGrade(grade);
        }

        public List<Subject> SearchSubjectByGrade(String kw, GradeEnum grade)
        {
            return subjectDao.SearchSubjectByGrade(kw, grade);
        }

        public Boolean CreateSubject(Subject subject)
        {
            return subjectDao.CreateSubject(subject);
        }
        public Boolean UpdateSubject(Subject subject)
        {
            return subjectDao.UpdateSubject(subject);
        }

        public Boolean DeleteSubject(int id)
        {
            return subjectDao.DeleteSubject(id);
        }

        public List<Subject> SearchForAssign(String keyword, int teacherId)
        {
            return subjectDao.SearchExcludeAssigned(keyword, teacherId);
        }
    }
}
