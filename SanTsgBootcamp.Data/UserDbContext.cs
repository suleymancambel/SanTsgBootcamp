using Microsoft.EntityFrameworkCore;

using SanTsgBootcamp.Domain;

using SanTsgBootcamp.Domain.Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace SanTsgBootcamp.Data
{
    public class UserDbContext : DbContext
    {

        public static readonly string connectionString = "Server=localhost;Database=deneme;Trusted_Connection=true;";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlServer(connectionString);
      


      


        public DbSet<User> Users { get; set; }

       
       
      
        
      
       
       
      
       
       
       
    }
}
