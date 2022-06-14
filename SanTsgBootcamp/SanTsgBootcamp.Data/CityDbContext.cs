using Microsoft.EntityFrameworkCore;
using SanTsgBootcamp.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace SanTsgBootcamp.Data
{
    public class CityDbContext : DbContext
    {
        public static readonly string connectionString = "Server=localhost;Database=deneme;Trusted_Connection=true;";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlServer(connectionString);


        public DbSet<CityModel> CityModels { get; set; }
    }
}
