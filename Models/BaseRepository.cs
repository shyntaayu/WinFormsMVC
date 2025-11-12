using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsMVC.Models
{
    // Abstract base repository (Inheritance & Polymorphism)
    public abstract class BaseRepository<T> : IRepository<T> where T : class
    {
        protected readonly KampusDbContext _context;
        protected readonly DbSet<T> _dbSet;

        // Constructor
        protected BaseRepository()
        {
            _context = new KampusDbContext();
            _dbSet = _context.Set<T>();
        }

        // Virtual methods yang bisa di-override (Polymorphism)
        public virtual T GetById(int id)
        {
            try
            {
                return _dbSet.Find(id);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error getting entity: {ex.Message}");
            }
        }

        public virtual List<T> GetAll()
        {
            try
            {
                return _dbSet.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error getting all entities: {ex.Message}");
            }
        }

        public virtual bool Add(T entity)
        {
            try
            {
                _dbSet.Add(entity);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error adding entity: {ex.Message}");
            }
        }

        public virtual bool Update(T entity)
        {
            try
            {
                _dbSet.Update(entity);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error updating entity: {ex.Message}");
            }
        }

        public virtual bool Delete(int id)
        {
            try
            {
                var entity = GetById(id);
                if (entity != null)
                {
                    _dbSet.Remove(entity);
                    _context.SaveChanges();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error deleting entity: {ex.Message}");
            }
        }

        public virtual List<T> Find(Expression<Func<T, bool>> predicate)
        {
            try
            {
                return _dbSet.Where(predicate).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error finding entities: {ex.Message}");
            }
        }

        public virtual T FirstOrDefault(Expression<Func<T, bool>> predicate)
        {
            try
            {
                return _dbSet.FirstOrDefault(predicate);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error finding entity: {ex.Message}");
            }
        }

        // Dispose pattern
        public void Dispose()
        {
            _context?.Dispose();
        }
    }
}