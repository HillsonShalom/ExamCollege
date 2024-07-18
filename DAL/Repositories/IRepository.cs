using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ExamCollege.DAL.Repositories
{
    internal interface IRepository<T>
    {
        T FindByName(string name);
        int Insert(T entity);
        int Update(T entity);
        List<T> GetAll();
    }
}
