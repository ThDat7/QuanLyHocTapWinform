﻿using DAL_QLHT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_QLHT
{
    public class TeachService
    {

        TeachDao teachDao = new TeachDao();

        public List<Object> GetTeachesByUserId(int userId)
        {
            return teachDao.GetTeachesByUserId(userId);
        }

        public Teach GetExamByTeachId(int teachId)
        {
            return teachDao.GetExamByTeachId(teachId);
        }

        public Boolean UpdateTeach(Teach teach)
        {
            return teachDao.UpdateTeach(teach);
        }

        public int AddTeach(int classroomId, int teacherId, int subjectId)
        {
            return teachDao.AddTeach(classroomId, teacherId, subjectId);
        }

        public Boolean RemoveTeach(int teachId)
        {
            return teachDao.RemoveTeach(teachId);
        }

        public Teach InitGrade(int teachId)
        {
            if (teachDao.IsGradeExists(teachId))
                return null;

            return teachDao.CreateSubjectForTeach(teachId);
        }
    }
}
