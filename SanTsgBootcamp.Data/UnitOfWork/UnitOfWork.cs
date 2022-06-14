using SanTsgBootcamp.Data.Repositories;
using SanTsgBootcamp.Data.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SanTsgBootcamp.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        public IUserRepository Users { get; set; }
       

        private readonly UserDbContext _context;
        

        public UnitOfWork()
        {
            _context = new UserDbContext();
            Users = new UserRepository(_context);
           
            
            

        }
        public void Dispose()
        {
            _context.Dispose();
        }

        public Task<int> SaveAsync()
        {
            return _context.SaveChangesAsync();
        }

        public int Save()
        {
            return _context.SaveChanges();
        }

    }
}
