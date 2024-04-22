using DTO_QLHT;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QLHT
{
    public class SubjectGradeDao
    {
        private student_managementContext db;
        public List<Dictionary<String, object>> GetAvgExamByClass(int classroomId, SemesterEnum? semester)
        {
            int semesterInt = semester == SemesterEnum.I ? 1 : 2;
            using (db = new student_managementContext()) 
            {
                List<Dictionary<string, object>> result = new List<Dictionary<string, object>>();


                var cmd = db.Database.GetDbConnection().CreateCommand();
                cmd.CommandText = "GetStudentGrades";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ClassroomId", classroomId));
                cmd.Parameters.Add(new SqlParameter("@Semester", semesterInt));

                if (cmd.Connection.State != ConnectionState.Open)
                {
                    cmd.Connection.Open();
                }

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Dictionary<string, object> row = new Dictionary<string, object>();
                            for (int i = 0; i < reader.FieldCount; i++)
                                row[reader.GetName(i)] = reader[i];
                            result.Add(row);
                        }
                    }
                }
                return result;
            }
        }
    }
}
