using SanTsgBootcamp.Data.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SanTsgBootcamp.Data.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IUserRepository Users { get; }
      
        int Save();
    }
}
