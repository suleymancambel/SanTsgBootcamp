﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SanTsgBootcamp.Data.Repositories.Interfaces
{
    public interface IRepository <T> where T : class
    {
        T Get(string id);
        T Get(int id);
        List<T> GetAll();

        T Find(Expression<Func<T, bool>> where = null);

        bool Any(Expression<Func<T, bool>> where);

        List<T> Where(Expression<Func<T, bool>> where);

        void Add(T t);

        void Update(T t);

        void AddRange(IEnumerable<T> ts);

        void Remove(T t);

        void RemoveRange(IEnumerable<T> ts);

    }
}
