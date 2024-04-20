using DTO_QLHT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DAL_QLHT
{
    public class TeacherDao
    {
        private student_managementContext db;

        public List<Object> Search(string keyword, List<int> excludeIds)
        {
            using (db = new student_managementContext())
            {
                var query = db.Teachers
                            .Where(t =>
                                (t.User.LastName+" "+t.User.FirstName)
                                    .Contains(keyword)
                                && !excludeIds.Contains(t.Id))
                            .Select(t => new
                            {
                                Id = t.Id,
                                Name = $"{t.User.LastName} {t.User.FirstName}",
                                Dob = t.User.Dob,
                                Address = t.User.Address
                            });

                return query.ToList<Object>();
            }
        }
    }
}
