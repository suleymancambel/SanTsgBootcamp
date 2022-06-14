using Microsoft.EntityFrameworkCore;
using SanTsgBootcamp.Data.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SanTsgBootcamp.Data.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly UserDbContext _context;
        private DbSet<T> _dbset;

        public Repository(UserDbContext context)
        {
            _context = context;
            _dbset = _context.Set<T>();
        }

        public void Add(T t)
        {
            _dbset.Add(t);

        }

        public void AddRange(IEnumerable<T> ts)
        {
            _context.Set<T>().AddRange(ts);
        }

        public bool Any(Expression<Func<T, bool>> where)
        {
            return _dbset.Any(where);
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public T Find(Expression<Func<T, bool>> where = null)
        {
            return _dbset.FirstOrDefault(where);
        }

        public T Get(string id)
        {
            return _dbset.Find(id);
        }
        public T Get(int id)
        {
            return _dbset.Find(id);
        }
        public  List<T> GetAll()
        {
            return  _dbset.ToList<T>();
        }

        public void Remove(T t)
        {
            _context.Remove(t);

        }

        public void RemoveRange(IEnumerable<T> ts)
        {
            _context.Set<T>().RemoveRange(ts);
        }

        public void Update(T t)
        {
            _dbset.Attach(t);

            _context.Entry(t).State = EntityState.Modified;


        }

        public List<T> Where(Expression<Func<T, bool>> where)
        {
            return _dbset.Where(where).ToList();
        }
    }
}