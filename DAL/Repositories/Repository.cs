using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamCollege.DAL;
using ExamCollege.DAL.Models;
using static ExamCollege.Config.Services;

namespace ExamCollege.DAL.Repositories
{
    internal class Repository : IRepository<Course>
    {
        DBContext db;
        public Repository()
        {
            db = new DBContext(GetConnectionString());
        }
        public Course FindByName(string name)
        {
            throw new NotImplementedException();
        }

        public List<Course> GetAll()
        {
            DataTable table = db.ExecuteQuery(@"
SELECT Name, Starts FROM Courses
", null);
            List<Course> list = new List<Course>();
            foreach (DataRow dr in table.Rows)
            {
                list.Add(new Course());
            }
            return list;
        }

        public int Insert(Course entity)
        {
            throw new NotImplementedException();
        }

        public int Update(Course entity)
        {
            throw new NotImplementedException();
        }
    }
}
