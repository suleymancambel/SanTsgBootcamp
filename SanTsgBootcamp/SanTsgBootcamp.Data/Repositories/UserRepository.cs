using SanTsgBootcamp.Data.Repositories.Interfaces;
using SanTsgBootcamp.Domain.Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace SanTsgBootcamp.Data.Repositories
{
    public class UserRepository : Repository<User> ,IUserRepository
    {
        private UserDbContext _context;
        public UserRepository(UserDbContext context) : base(context)
        {
            _context = context;
        }
    }

   
}
