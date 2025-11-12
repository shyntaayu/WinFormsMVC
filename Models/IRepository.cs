using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsMVC.Models
{
    // Interface untuk Repository Pattern (Abstraction)
    public interface IRepository<T> where T : class
    {
        // CRUD Operations
        T GetById(int id);
        List<T> GetAll();
        bool Add(T entity);
        bool Update(T entity);
        bool Delete(int id);

        // Query operations
        List<T> Find(Expression<Func<T, bool>> predicate);
        T FirstOrDefault(Expression<Func<T, bool>> predicate);
    }
}
